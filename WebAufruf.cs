using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Linq;
using System.Text;

namespace DND
{
    public class WebAufruf
    {
        StringBuilder builder = new StringBuilder();
        private string jsonstring;
        private string uri;

        public static void SetCache(WebRequest request)
        {
            HttpRequestCachePolicy caching = new HttpRequestCachePolicy(HttpRequestCacheLevel.CacheIfAvailable);
            request.CachePolicy = caching;
        }

        public string GetRaceInformation(string rasse)
        {
            builder.Clear();
            uri = "http://dnd5eapi.co/api/races/" + rasse;

            // Create WebRequest to URI
            WebRequest request = WebRequest.Create(uri);
            SetCache(request);

            // Get Response from WebRequest
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Filter JSON String from Response
                jsonstring = reader.ReadToEnd();

                Rasse race = JsonConvert.DeserializeObject<Rasse>(jsonstring);
                
                builder.Append("Ability Score Increase: ");
                foreach (AbilityBonus abilityBonus in race.AbilityBonuses)
                {
                    if (abilityBonus.Equals(race.AbilityBonuses.Last()))
                    {
                        builder.Append(abilityBonus.Name + " + " + abilityBonus.Bonus);
                    }
                    else
                    {
                        builder.Append(abilityBonus.Name + ", ");
                    }
                }

                builder.Append("\n\nAge: " + race.Age);
                builder.Append("\n\nAlignment: " + race.Alignment);
                builder.Append("\n\nSize: " + race.SizeDescription);
 
                builder.Append("\n\nTraits: ");
                foreach (Trait trait in race.Traits)
                {
                    if (trait.Equals(race.Traits.Last()))
                    {
                        builder.Append(trait.Name);
                    }
                    else
                    {
                        builder.Append(trait.Name + ", ");
                    }
                }

                builder.Append("\n\nSpeed: " + race.Speed + "ft.");
                
                builder.Append("\n\nLanguages: ");
                foreach (Language language in race.Languages)
                {
                    if (language.Equals(race.Languages.Last()))
                    {
                        builder.Append(language.Name);
                    }
                    else
                    {
                        builder.Append(language.Name + ", ");
                    }
                }

                builder.Append("\n\nSubraces: ");
                foreach (SubRace subRace in race.Subraces)
                {
                    if (subRace.Equals(race.Subraces.Last()))
                    {
                        builder.Append(subRace.Name);
                    }
                    else
                    {
                        builder.Append(subRace.Name + ", ");
                    }
                }

            }
            response.Close();
            return builder.ToString();
        }
        public string GetSubRaceInformation(string subrasse)
        {
            builder.Clear();
            uri = "http://dnd5eapi.co/api/subraces/" + subrasse;

            // Create WebRequest of URI
            WebRequest request = WebRequest.Create(uri);
            SetCache(request);

            // Get Response from WebRequest
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Filter JSON String from Response
                jsonstring = reader.ReadToEnd();

                SubRace subrace = JsonConvert.DeserializeObject<SubRace>(jsonstring);

                builder.Append(subrace.Desc);
                builder.Append("\n\nAbility Score Increase: " + subrace.AbilityBonuses);
                builder.Append("\n\nStarting Proficiences: " + subrace.StartingProficiencies);
                builder.Append("\n\nLanguages: " + subrace.Languages);
                builder.Append("\n\nRacial Traits: " + subrace.RacialTraits);
            }
            response.Close();
            return builder.ToString();
        }

        public string GetClassInformation(string klasse)
        {
            builder.Clear();
            uri = "http://dnd5eapi.co/api/classes/" + klasse;

            // Create WebRequest of URI
            WebRequest request = WebRequest.Create(uri);
            SetCache(request);

            // Get Response from WebRequest
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Filter JSON String from Response
                jsonstring = reader.ReadToEnd();

                Klasse clazz = JsonConvert.DeserializeObject<Klasse>(jsonstring);

                builder.Append("Hit Points:" + "\n\n");
                builder.Append("Hit Dice: 1d" + clazz.HitDie + " per " + klasse + " level\n\n");
                builder.Append("Hit Points at 1st Level: " + clazz.HitDie + " + your Constitution modifier\n\n");
                builder.Append("Hit Points at Higher Levels: " + "1d" + clazz.HitDie + " (or " + ((clazz.HitDie / 2) + 1) + ") + your Constitution modifier per " + klasse + " lever after 1st\n\n");
     
                builder.Append("Proficiencies: ");
                foreach (Proficiency prof in clazz.Proficiencies)
                {
                    if (prof.Equals(clazz.Proficiencies.Last()))
                    {
                        builder.Append(prof.Name);
                    }
                    else
                    {
                        builder.Append(prof.Name + ", ");
                    }
                }

                builder.Append("\n\nSaving Throws: ");
                foreach (Proficiency saveThr in clazz.SavingThrows)
                {
                    if (saveThr.Equals(clazz.SavingThrows.Last()))
                    {
                        builder.Append(saveThr.Name);
                    }
                    else
                    {
                        builder.Append(saveThr.Name + ", ");
                    }
                }

                foreach (ProficiencyChoice skills in clazz.ProficiencyChoices)
                {
                    builder.Append("\n\nChoose " + skills.Choose + " from: ");
                    foreach (Proficiency prof in skills.From)
                    {
                        string skillsStr = prof.Name;
                        skillsStr = skillsStr.Replace("Skill: ", "");

                        if (prof.Equals(skills.From.Last()))
                        {
                            builder.Append(skillsStr);
                        }
                        else
                        {
                            builder.Append(skillsStr + ", ");
                        }
                    }
                }

                builder.Append(clazz.StartingEquipment);
            }

            response.Close();
            return builder.ToString();
        }
    }
}
