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

            //Creates Request of URl
            WebRequest request = WebRequest.Create(url);
            setCache(request);

            //get Response
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Hier komm der JSon String
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

            //Creates Request of URl
            WebRequest request = WebRequest.Create(url);
            setCache(request);

            //get Response
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Hier komm der JSon String
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

            //Creates Request of URl

            WebRequest request = WebRequest.Create(url);
            setCache(request);

            //get Response
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Hier komm der JSon String
                jsonstring = reader.ReadToEnd();

                Klasse clazz = JsonConvert.DeserializeObject<Klasse>(jsonstring);
                builder.Append("Hit Points:" + "\n");
                builder.Append("Hit Dice: 1d" + clazz.HitDie + " per " + klasse + " level\n");
                builder.Append("Hit Points at 1st Level: " + clazz.HitDie + " + your Constitution modifier\n");
                builder.Append("Hit Points at Higher Levels: " + "1d" + clazz.HitDie + " (or " + ((clazz.HitDie / 2) + 1) + ") + your Constitution modifier per " + klasse + " lever after 1st\n");
                builder.Append("Proficiencies:" + "\n");
                foreach (Proficiency prof in clazz.Proficiencies)
                {
                    builder.Append(prof.Name + ", ");
                }
                builder.Append("Saving Throws:\n");
                foreach (Proficiency saveThr in clazz.SavingThrows)
                {
                    builder.Append(saveThr.Name + ", ");
                }
                foreach (ProficiencyChoice skills in clazz.ProficiencyChoices)
                {
                    builder.Append("Choose " + skills.Choose + " from: \n");
                    foreach (Proficiency prof in skills.From)
                    {
                        string a = prof.Name;
                        a = a.Replace("Skill: ", "");
                        builder.Append(a + ", ");
                    }
                    builder.Append("\n");
                }

            }
            response.Close();
            return builder.ToString();
        }
    }
}
