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

namespace DND
{
    public class WebAufruf
    {
        public static void setCache(WebRequest request)
        {
            HttpRequestCachePolicy caching = new HttpRequestCachePolicy(HttpRequestCacheLevel.CacheIfAvailable);
            request.CachePolicy = caching;
        }

        public string GetRaceInformation(string race)
        {
            return race;
            string jsonstring;
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string url = "http://dnd5eapi.co/api/races/rasse";
            url = url.Replace("rasse", race);

            // Create WebRequest to URI
            WebRequest request = WebRequest.Create(url);
            setCache(request);

            // Get Response from WebRequest
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Filter JSON String from Response
                jsonstring = reader.ReadToEnd();

                Rasse rasse = JsonConvert.DeserializeObject<Rasse>(jsonstring);
                int i = 1;
                foreach (AbilityBonus element in rasse.AbilityBonuses)
                {

                    if (race == "human")
                    {
                        builder.Append("Your ability scores each increase by 1.");
                        break;
                    }
                    if (i == 1)
                    {
                        builder.Append("Your " + element.Name + " score increases by " + element.Bonus);
                        i = 0;
                    }
                    else
                    {
                        builder.Append(", and your " + element.Name + " score increases by " + element.Bonus);
                        i = 1;
                    }
                }
                builder.Append("\nAge:\n" + rasse.Age + "\n");
                builder.Append("Alignment:\n" + rasse.Alignment + "\n");
                builder.Append("Size:\n" + rasse.SizeDescription + "\n");
                builder.Append("Speed\n" + rasse.Speed + "ft.\n");
                foreach (Proficiency prof in rasse.StartingProficiencies)
                {
                    builder.Append(prof.Name + ", ");
                }
                /*
                foreach (StartingProficiencyOptions spopt in rasse.StartingProficiencyOptions)
                {
                    foreach (Proficiency prof in spopt.From)
                    {
                        builder.Append(prof.Name + ", ");
                    }
                }
                */
                builder.Append(rasse.StartingProficiencies + "\n");
                builder.Append(rasse.LanguageDesc + "\n");
            }
            response.Close();
            return builder.ToString();
        }
        public string GetSubRaceInformation(string race)
        {
            string jsonstring;
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string url = "http://dnd5eapi.co/api/races/rasse";
            url = url.Replace("rasse", race);

            // Create WebRequest of URI
            WebRequest request = WebRequest.Create(url);
            setCache(request);

            // Get Response from WebRequest
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Filter JSON String from Response
                jsonstring = reader.ReadToEnd();

                Rasse rasse = JsonConvert.DeserializeObject<Rasse>(jsonstring);

                builder.Append(rasse.Name + "\n");
                foreach (AbilityBonus element in rasse.AbilityBonuses)
                {

                }
            }
            response.Close();
            return builder.ToString();
        }

        public string GetClassInformation(string klasse)
        {
            string jsonstring;
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string url = "http://dnd5eapi.co/api/classes/klasse";
            url = url.Replace("klasse", klasse);

            // Create WebRequest of URI
            WebRequest request = WebRequest.Create(url);
            setCache(request);

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

            }
            response.Close();
            return builder.ToString();
        }
    }
}
