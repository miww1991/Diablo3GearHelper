using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Diablo3GearHelper.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace Diablo3GearHelper
{
    public class WebDataRetriever
    {
        /// <summary>
        /// Retrieves all the heroes attached to the specified BattleTag
        /// </summary>
        /// <param name="battleTagString">The BattleTag to retrieve information from</param>
        /// <returns>An array of all heroes attached to the specified BattleTag</returns>
        public static Hero[] GetHeroes(string battleTagString)
        {
            // Create the list to store our heroes in
            List<Hero> heroes = new List<Hero>();

            // Assemble our the web address to send our api request to
            string webAddress = "http://us.battle.net/api/d3/profile/" + battleTagString + "/";

            // Create our web request handler
            WebRequest webRequest = WebRequest.Create(webAddress);

            // Get the response from the web request and convert it to a readable string
            // TODO: Try/catch block to handle a WebException for 404 not found
            Stream responseStream = webRequest.GetResponse().GetResponseStream();
            StreamReader response = new StreamReader(responseStream);
            string responseString = response.ReadToEnd();

            // TODO: Try catch blocks for parsing the response
            // Parse the JSON response from the web API into a JObject
            JObject accountObject = JObject.Parse(responseString);

            // Take all the hero entries from our JObject and put them into a list
            List<JToken> results = accountObject["heroes"].Children().ToList();

            // For all the hero entries that were in the JSON response, deserialize them into a hero object
            foreach (JToken token in results)
            {
                heroes.Add(JsonConvert.DeserializeObject<Hero>(token.ToString()));
            }

            // Return the list of heroes
            return heroes.ToArray();
        }

        public static void GetDetailedHeroInformation(string battleTagString, ref Hero hero)
        {
            // Assemble our the web address to send our api request to
            string webAddress = "http://us.battle.net/api/d3/profile/" + battleTagString + "/hero/" + hero.Id;

            // Create our web request handler
            WebRequest webRequest = WebRequest.Create(webAddress);

            // Get the response from the web request and convert it to a readable string
            Stream responseStream = webRequest.GetResponse().GetResponseStream();
            StreamReader response = new StreamReader(responseStream);
            string responseString = response.ReadToEnd();

            // Parse the JSON response from the web API into a JObject
            JObject heroObject = JObject.Parse(responseString);

            // Extract the information and store it in our hero object
            ParseHeroInformationIntoObject(heroObject, ref hero);
        }

        private static void ParseHeroInformationIntoObject(JObject rawInformation, ref Hero hero)
        {
            List<JToken> activeSkills = rawInformation["skills"]["active"].Children().ToList();
            List<JToken> passiveSkills = rawInformation["skills"]["passive"].Children().ToList();
            List<JToken> items = rawInformation["items"].Children().ToList();
            JObject itemsObj = rawInformation["items"].Value<JObject>();
            List<JToken> values = itemsObj.Values().ToList();

            Debug.Assert(activeSkills.Count <= hero.ActiveSkills.Length);
            for (int i = 0; i < activeSkills.Count; i++)
            {
                hero.ActiveSkills[i] = (activeSkills[i])["skill"]["name"].Value<string>();
            }

            Debug.Assert(passiveSkills.Count <= hero.PassiveSkills.Length);
            for (int i = 0; i < passiveSkills.Count; i++)
            {
                hero.PassiveSkills[i] = (passiveSkills[i])["skill"]["name"].Value<string>();
            }

            Debug.Assert(activeSkills.Count <= hero.Runes.Length);
            for (int i = 0; i < activeSkills.Count; i++)
            {
                hero.Runes[i] = (activeSkills[i])["rune"]["name"].Value<string>();
            }

            foreach (JToken item in values)
            {
                string type = itemsObj.Properties().ToList()[values.IndexOf(item)].Name;
                string fakeJson = '"' + type + '"';
                ItemSlot slot = JsonConvert.DeserializeObject<ItemSlot>(fakeJson);
                Item newItem = null;

                switch (slot)
                {
                    case ItemSlot.Helm:
                        newItem = new Helm();
                        hero.Gear.Helm = newItem as Helm;
                        break;
                    case ItemSlot.Amulet:
                        newItem = new Amulet();
                        hero.Gear.Amulet = newItem as Amulet;
                        break;
                    case ItemSlot.Bracers:
                        newItem = new Bracers();
                        hero.Gear.Bracers = newItem as Bracers;
                        break;
                    case ItemSlot.Boots:
                        newItem = new Boots();
                        hero.Gear.Boots = newItem as Boots;
                        break;
                    case ItemSlot.Gloves:
                        newItem = new Gloves();
                        hero.Gear.Gloves = newItem as Gloves;
                        break;
                    case ItemSlot.LeftRing:
                        newItem = new Ring(ItemSlot.LeftRing);
                        hero.Gear.LeftRing = newItem as Ring;
                        break;
                    case ItemSlot.RightRing:
                        newItem = new Ring(ItemSlot.RightRing);
                        hero.Gear.RightRing = newItem as Ring;
                        break;
                    case ItemSlot.Pants:
                        newItem = new Pants();
                        hero.Gear.Pants = newItem as Pants;
                        break;
                    case ItemSlot.MainHand:
                        newItem = new Weapon(ItemSlot.MainHand);
                        hero.Gear.MainHand = newItem as Weapon;
                        break;
                    case ItemSlot.OffHand:
                        newItem = new OffHand();
                        hero.Gear.OffHand = newItem as OffHand;
                        break;
                    case ItemSlot.Shoulders:
                        newItem = new Shoulders();
                        hero.Gear.Shoulders = newItem as Shoulders;
                        break;
                    case ItemSlot.Chest:
                        newItem = new Chest();
                        hero.Gear.Chest = newItem as Chest;
                        break;
                    case ItemSlot.Belt:
                        newItem = new Belt();
                        hero.Gear.Belt = newItem as Belt;
                        break;
                    default:
                        throw new InvalidDataException();
                }

                string tooltipParams = item.Value<string>("tooltipParams");
                string url = "http://us.battle.net/api/d3/data/" + tooltipParams;
                GetItemInfo(url, ref newItem);
            }
        }

        private static void GetItemInfo(string url, ref Item item)
        {
            // Create our web request handler
            WebRequest webRequest = WebRequest.Create(url);

            // Get the response from the web request and convert it to a readable string
            Stream responseStream = webRequest.GetResponse().GetResponseStream();
            StreamReader response = new StreamReader(responseStream);
            string responseString = response.ReadToEnd();

            // Parse the JSON response from the web API into a JObject
            JObject heroObject = JObject.Parse(responseString);
            JObject parsedAttributesObject = heroObject["attributes"].Value<JObject>();
            JObject affixesObject = heroObject["attributesRaw"].Value<JObject>();

            JsonConvert.PopulateObject(responseString, item);

            List<JToken> RawAffixes = affixesObject.Children().ToList();

            foreach (JToken affixToken in RawAffixes)
            {
                string affixString = affixesObject.Properties().ToList()[RawAffixes.IndexOf(affixToken)].Name;
                string fakeJson = '"' + affixString + '"';
                try
                {
                    AffixType affixType = JsonConvert.DeserializeObject<AffixType>(fakeJson);
                    Affix affix = new Affix();
                    affix.AffixType = affixType;
                    affix.Value = GetAverageValueFloat(affixesObject[affixString]);
                    item.PrimaryAffixes.Add(affix);
                }
                catch (JsonSerializationException) { }
            }

            switch (item.Slot)
            {
                case ItemSlot.MainHand:
                    (item as Weapon).AttacksPerSecond = GetAverageValueFloat(heroObject["attacksPerSecond"]);
                    (item as Weapon).MinDamage = GetAverageValueInt(heroObject["minDamage"]);
                    (item as Weapon).MaxDamage = GetAverageValueInt(heroObject["maxDamage"]);
                    break;
                default:
                    break;
            }
        }

        private static float GetAverageValueFloat(JToken container)
        {
            float min = JsonConvert.DeserializeObject<float>(container["min"].ToString());
            float max = JsonConvert.DeserializeObject<float>(container["max"].ToString());
            float average = (min + max) / 2.0f;
            return average;
        }

        private static int GetAverageValueInt(JToken container)
        {
            int min = JsonConvert.DeserializeObject<int>(container["min"].ToString());
            int max = JsonConvert.DeserializeObject<int>(container["max"].ToString());
            int average = (min + max) / 2;
            return average;
        }
    }
}