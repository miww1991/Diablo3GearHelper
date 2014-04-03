using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Diablo3GearHelper.Types;
using Newtonsoft.Json;

namespace Diablo3GearHelper
{
    public class WebDataRetriever
    {
        public static Hero[] GetHeroes(string battleTagString)
        {
            string webAddress = "http://us.battle.net/api/d3/profile/" + battleTagString + "/";
            WebRequest webRequest = WebRequest.Create(webAddress);

            Stream responseStream = webRequest.GetResponse().GetResponseStream();
            StreamReader response = new StreamReader(responseStream);
            string responseString = response.ReadToEnd();
            responseString = responseString.Replace("class", "classType");
            responseString = responseString.Replace("last-updated", "lastUpdated");

            dynamic stuff = JsonConvert.DeserializeObject(responseString);

            List<Hero> heroes = new List<Hero>();
            foreach (dynamic item in stuff.heroes)
            {
                string name = item.name;
                int id = item.id;
                int level = item.level;
                bool hardcore = item.hardcore;
                int paragonLevel = item.paragonLevel;
                HeroGender gender = (HeroGender)item.gender;
                bool dead = item.dead;
                ClassType heroClass = GetClassType((string)item.classType);
                DateTime lastUpdated = FromUnixTime((long)item.lastUpdated);

                Hero h = new Hero(name, id, level, hardcore, paragonLevel, gender, dead, heroClass, lastUpdated);
                heroes.Add(h);
            }

            return heroes.ToArray();
        }

        #region Helper Methods

        // Thanks to LukeH at http://stackoverflow.com/questions/2883576/how-do-you-convert-epoch-time-in-c
        private static DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        private static ClassType GetClassType(string classString)
        {
            switch (classString)
            {
                case "barbarian":
                    return ClassType.Barbarian;
                case "crusader":
                    return ClassType.Crusader;
                case "demon-hunter":
                    return ClassType.DemonHunter;
                case "monk":
                    return ClassType.Monk;
                case "witch-doctor":
                    return ClassType.WitchDoctor;
                case "wizard":
                    return ClassType.Wizard;
                default:
                    return ClassType.InvalidClassType;
            }
        }

        #endregion
    }
}
