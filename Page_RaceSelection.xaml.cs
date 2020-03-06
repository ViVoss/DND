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
    /// <summary>
    /// Interaktionslogik für Page_RaceSelection.xaml
    /// </summary>
    public partial class Page_RaceSelection : Page
    { 
        public static string getRaceInformation(string race)
        {
            string jsonstring;
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

                Race rasse = JsonConvert.DeserializeObject<Race>(jsonstring);
                jsonstring = rasse.Results[1].Name;
                
            }
            response.Close();
            return jsonstring;



        }
        public Page_RaceSelection()
        {
            InitializeComponent();

        }

        private void Button_Race_Click(object sender, RoutedEventArgs e)
        {
            string currRace = ((Button)sender).Tag.ToString();
            switch (currRace)
            {
                case "tiefling":
                    break;
                case "half-elf":
                    break;
                case "half-orc":
                    break;
                default:
                    Window_SubraceSelection subra = new Window_SubraceSelection(((Creation)Window.GetWindow(this)), currRace);
                    subra.ShowDialog();
                    break;
            }
        }
        private void Button_Race_MouseEnter(object sender, MouseEventArgs e)
        {
            string race = ((Button)sender).Tag.ToString();
           TextBox_Description.Text = getRaceInformation(race);


        }

        private void Button_Race_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
