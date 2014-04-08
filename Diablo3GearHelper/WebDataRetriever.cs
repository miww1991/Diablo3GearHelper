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

            hero.Gear = new Gear();
            foreach (JToken item in values)
            {
                string type = itemsObj.Properties().ToList()[values.IndexOf(item)].Name;
                string fakeJson = '"' + type + '"';
                ItemSlot slot = JsonConvert.DeserializeObject<ItemSlot>(fakeJson);
                Item newItem = new Item(slot);

                string tooltipParams = item.Value<string>("tooltipParams");
                string url = "http://us.battle.net/api/d3/data/" + tooltipParams;
                GetItemInfo(url, ref newItem);

                switch(newItem.Slot)
                {
                    case ItemSlot.Head:
                        hero.Gear.Helm = newItem;
                        break;
                    case ItemSlot.Neck:
                        hero.Gear.Amulet = newItem;
                        break;
                    case ItemSlot.Bracers:
                        hero.Gear.Bracers = newItem;
                        break;
                    case ItemSlot.Feet:
                        hero.Gear.Boots = newItem;
                        break;
                    case ItemSlot.Hands:
                        hero.Gear.Gloves = newItem;
                        break;
                    case ItemSlot.LeftFinger:
                        hero.Gear.LeftFinger = newItem;
                        break;
                    case ItemSlot.RightFinger:
                        hero.Gear.RightFinger = newItem;
                        break;
                    case ItemSlot.Legs:
                        hero.Gear.Pants = newItem;
                        break;
                    case ItemSlot.MainHand:
                        hero.Gear.MainHand = newItem;
                        break;
                    case ItemSlot.OffHand:
                        hero.Gear.Helm = newItem;
                        break;
                    case ItemSlot.Shoulders:
                        hero.Gear.Shoulders = newItem;
                        break;
                    case ItemSlot.Torso:
                        hero.Gear.Chest = newItem;
                        break;
                    case ItemSlot.Waist:
                        hero.Gear.Belt = newItem;
                        break;
                    default:
                        throw new InvalidDataException();
                }
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

            JsonConvert.PopulateObject(responseString, item);
        }
    }
}