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

namespace DND
{
    public class WebAufruf
    {
        public string GetRaceInformation(string race)
        {
            string jsonstring;
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string url = "http://dnd5eapi.co/api/races/rasse";
            url = url.Replace("rasse", race);

            //Creates Request of URl
            WebRequest request = WebRequest.Create(url);

            //get Response
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Hier komm der JSon String
                jsonstring = reader.ReadToEnd();

                Rasse rasse = JsonConvert.DeserializeObject<Rasse>(jsonstring);

                builder.Append(rasse.Name);
                foreach (DND.AbilityBonus element in rasse.AbilityBonuses)
                {
                    builder.Append("\n" + element.Name + " +" + element.Bonus);
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

            //get Response
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Hier komm der JSon String
                jsonstring = reader.ReadToEnd();

                Klasse clazz = JsonConvert.DeserializeObject<Klasse>(jsonstring);
                builder.Append("HitDice 1d" + clazz.HitDie + " pro " + klasse + " level" + "\n");
                builder.Append("Hitpoints at 1st Level " + clazz.HitDie + " + Konstitution Modifikator" + "\n");
                builder.Append("Hitpoints at Higher Level " + "1d" + clazz.HitDie + "(or" + ((clazz.HitDie / 2) + 1) + ")" + "\n");
                foreach (DND.Proficiency prof in clazz.Proficiencies)
                {
                    builder.Append(prof.Name + "\n");
                }
            }
            response.Close();
            return builder.ToString();
        }
    }    
}
