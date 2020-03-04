using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DND
{
    /// <summary>
    /// Interaktionslogik für Page_RaceSelection.xaml
    /// </summary>
    public partial class Page_RaceSelection : Page
    {
        public string race = "";
        public string information = "";



        public Page_RaceSelection()
        {
            InitializeComponent();

        }

        public static async Task<string> GetRaceInformation(string race)
        {
            
                
            string baseUrl = "http://dnd5eapi.co/api/races/rasse";
            baseUrl = baseUrl.Replace("rasse", race);
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                            else
                            {
                                return data;
                            }
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Found ----- {0}", exception);
                return null;
            }
        }

        public async Task<string> fetchAPI(string race)
        {
            var infor = await GetRaceInformation(race).ConfigureAwait(false);
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject(infor);
            var fetchdata = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
            Regex.Unescape(fetchdata);
            fetchdata = fetchdata.Replace("[", "").Replace("]", "").Replace("\"", "").Replace("{", "").Replace("}", "").Replace(":", "").Replace(",", "");
            fetchdata = Regex.Replace(fetchdata, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            return fetchdata;
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
        private async void Button_Race_MouseEnter(object sender, MouseEventArgs e)
        {
            string race = ((Button)sender).Tag.ToString();
            string fetchdata = await fetchAPI(race);
            TextBox_Description.Text = fetchdata.ToString();
            //TextBox_Description.Text = await GetRaceInformation();            
        }

        private void Button_Race_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
