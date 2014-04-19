using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Diablo3GearHelper.Data;
using Diablo3GearHelper.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;

namespace Diablo3GearHelper
{
    public class WebDataRetriever
    {
        private static AffixLookupTable affixLookupTable = AffixLookupTable.Instance;
        private static SkillLookupTable skillLookupTable = SkillLookupTable.Instance;

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
                Hero temp = JsonConvert.DeserializeObject<Hero>(token.ToString());

                if (temp.Level == 70)
                    heroes.Add(temp);
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

            List<JToken> activeSkills = heroObject["skills"]["active"].Children().ToList();
            List<JToken> passiveSkills = heroObject["skills"]["passive"].Children().ToList();
            List<JToken> items = heroObject["items"].Children().ToList();
            JObject itemsObj = heroObject["items"].Value<JObject>();
            List<JToken> values = itemsObj.Values().ToList();

            // Import Active Skill Information
            Debug.Assert(activeSkills.Count == hero.ActiveSkills.Length);
            for (int i = 0; i < activeSkills.Count; i++)
            {
                string name = (activeSkills[i])["skill"]["name"].Value<string>();
                string rune = (activeSkills[i])["rune"]["name"].Value<string>();
                AffixType? SkillDamageType = null;
                AffixType?  SkillDamageAffix = null;

                SkillLookupTableEntry[] entries = skillLookupTable.Table.Where(entry => entry.Name == name).ToArray();

                if (entries.Count() > 0 && entries.Any(entry => entry.Rune == rune))
                {
                    SkillDamageType = entries.Where(entry => entry.Rune == rune).First().SpellSchoolDamageAffix;
                    SkillDamageAffix = entries.Where(entry => entry.Rune == rune).First().SpellDamageAffix;
                }
                else if (entries.Count() > 0)
                {
                    SkillDamageType = entries.Where(entry => entry.Rune == null).First().SpellSchoolDamageAffix;
                    SkillDamageAffix = entries.Where(entry => entry.Rune == null).First().SpellDamageAffix;
                }

                Skill newSkill = new Skill(name, SkillDamageType, rune, SkillDamageAffix);
                hero.ActiveSkills[i] = newSkill;

            }

            // Import Passive Skill Informations
            Debug.Assert(passiveSkills.Count <= hero.PassiveSkills.Length);
            for (int i = 0; i < passiveSkills.Count; i++)
            {
                string name = (passiveSkills[i])["skill"]["name"].Value<string>();

                Skill newSkill = new Skill(name);   
                hero.PassiveSkills[i] = newSkill;
            }

            List<Task> tasks = new List<Task>();
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
                Action action = () => GetItemInfo(url, ref newItem);
                Task worker = Task.Factory.StartNew(action);
                tasks.Add(worker);
            }
            Task.WaitAll(tasks.ToArray());
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
            float damageDelta = 0;
            float damageMin = 0;
            foreach (JToken affixToken in RawAffixes)
            {
                string affixString = affixesObject.Properties().ToList()[RawAffixes.IndexOf(affixToken)].Name;

                if (affixString.Contains("Damage_Min") || affixString.Contains("Damage_Weapon_Bonus_Min_X1"))
                {
                    damageMin = GetAverageValueFloat(affixesObject[affixString]);
                }
                else if (affixString.Contains("Damage_Delta") || affixString.Contains("Damage_Weapon_Bonus_Delta_X1"))
                {
                    damageDelta = GetAverageValueFloat(affixesObject[affixString]);
                }

                string fakeJson = '"' + affixString + '"';
                try
                {
                    AffixType affixType = JsonConvert.DeserializeObject<AffixType>(fakeJson);
                    Affix affix = new Affix();
                    affix.AffixType = affixType;

                    affix.AffixQuality = affixLookupTable.Table.Where(a => a.Type == affixType).FirstOrDefault().Quality;

                    affix.Value = GetAverageValueFloat(affixesObject[affixString]);

                    if (affix.AffixQuality == AffixQuality.Primary)
                    {
                        item.PrimaryAffixes.Add(affix);
                    }
                    else
                    {
                        item.SecondaryAffixes.Add(affix);
                    }
                }
                catch (JsonSerializationException) { }
            }

            if (damageDelta > 0 && damageMin > 0)
            {
                float averageDamage = damageMin + (damageDelta / 2);
                Affix avgDmg = new Affix(AffixQuality.Primary, AffixType.AverageDamage, false, averageDamage);
                item.PrimaryAffixes.Add(avgDmg);
            }

            List<JToken> prettyAffixes = parsedAttributesObject["primary"].Children().ToList();
            prettyAffixes.AddRange(parsedAttributesObject["secondary"].Children());

            foreach (JToken token in prettyAffixes)
            {
                bool enchanted = (token["affixType"].Value<string>() == "enchant");
                if (enchanted)
                {
                    string text = token["text"].Value<string>();
                    text = text.Replace("+", "");

                    Regex regExp = new Regex(@"[\d]{1,4}([.,][\d]{1,2})?");//@"\d+");
                    Match match = regExp.Match(text); // 70–132 Damage (\d+)-(\d+)

                    Regex regEx = new Regex(@"(\d+)–(\d+)\s?.* Damage");

                    if (regEx.IsMatch(text))
                    {
                        Affix enchantedAffix = item.PrimaryAffixes.Where(affix => affix.AffixType == AffixType.AverageDamage).FirstOrDefault();
                        if (enchantedAffix != null)
                        {
                            enchantedAffix.Enchanted = true;
                        }
                    }
                    else
                    {
                        text = text.Replace(match.ToString(), "{1}");

                        AffixTableEntry tableEntry = affixLookupTable.Table.Where(entry => entry.DisplayString == text).FirstOrDefault();

                        if (tableEntry != null)
                        {
                            AffixType type = tableEntry.Type;
                            Affix enchantedAffix = item.PrimaryAffixes.Where(affix => affix.AffixType == type).FirstOrDefault();
                            if (enchantedAffix == null)
                            {
                                enchantedAffix = item.SecondaryAffixes.Where(affix => affix.AffixType == type).FirstOrDefault();
                            }

                            if (enchantedAffix != null)
                            {
                                enchantedAffix.Enchanted = true;
                            }
                        }
                    }
                }
            }

            if (item.PrimaryAffixes.Any(affix => affix.AffixType == AffixType.Sockets))
            {
                JArray gemsObject = heroObject["gems"].Value<JArray>();
                List<JToken> raw = gemsObject.Children().ToList();
                foreach (JToken token in raw)
                {
                    string name = token["item"]["name"].Value<string>();

                    JObject rawAttributes = token["attributesRaw"].Value<JObject>();

                    string affixString = rawAttributes.Properties().FirstOrDefault().Name;

                    string fakeJson = '"' + affixString + '"';

                    try
                    {
                        AffixType affixType = JsonConvert.DeserializeObject<AffixType>(fakeJson);
                        float gemValue = GetAverageValueFloat(token["attributesRaw"][affixString]);
                        Gem newGem = new Gem(name, affixType, gemValue);

                        item.Gems.Add(newGem);
                    }
                    catch (JsonSerializationException) { }
                }
            }

            if (heroObject["armor"] != null)
            {
                item.BaseArmor = GetAverageValueInt(heroObject["armor"]);
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
            int min = (int)Math.Round(JsonConvert.DeserializeObject<float>(container["min"].ToString()));
            int max = (int)Math.Round(JsonConvert.DeserializeObject<float>(container["max"].ToString()));
            int average = (min + max) / 2;
            return average;
        }
    }
}