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
using DND.Subraces;

namespace DND
{

    /// <summary>
    /// Interaktionslogik für Page_RaceSelection.xaml
    /// </summary>
    public partial class Page_RaceSelection : Page
    {
        WebAufruf call = new WebAufruf();

        public Creation Creation { get; set; }

        public Page_RaceSelection(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();

            //Subrace laden, wenn vorhanden
            if (Character.Current.SubRace != "")
            {
                this.Creation.TextBox_Subrace.Text = Character.Current.SubRace;
            }
        }

        private void Button_Race_Click(object sender, RoutedEventArgs e)
        {

            string currRace = ((Button)sender).Tag.ToString();

            //Rasse setzen
            Character.Current.Race = currRace;

            switch (currRace)
            {
                case "tiefling":
                    ClearSubraceBox();
                    SetRaceTextBox(currRace);
                    break;
                case "half-elf":
                    ClearSubraceBox();
                    SetRaceTextBox(currRace);
                    break;
                case "half-orc":
                    ClearSubraceBox();
                    SetRaceTextBox(currRace);
                    break;
                case "human":
                    ClearSubraceBox();
                    SetRaceTextBox(currRace);
                    break;
                default:
                    Window_SubraceSelection subra = new Window_SubraceSelection((Creation)Window.GetWindow(this), currRace);
                    subra.ShowDialog();
                    break;
            }
        }
        private void ClearSubraceBox()
        {
            this.Creation.Label_Subrace.Content = "Subrace";
            this.Creation.TextBox_Subrace.Text = "";
        }
        private void SetRaceTextBox(string currrace)
        {
            this.Creation.TextBox_Race.Text = currrace;
        }
        private void Button_Race_MouseEnter(object sender, MouseEventArgs e)
        {
            string race = ((Button)sender).Tag.ToString();
            TextBox_Description.Text = call.GetRaceInformation(race);
        }

        private void Button_Race_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
