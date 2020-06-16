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
using System.Linq;

namespace DND
{

    /// <summary>
    /// Interaktionslogik für Page_RaceSelection.xaml
    /// </summary>
    public partial class Page_RaceSelection : Page
    {
        DnDInformation dndInformation = new DnDInformation();

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
                    this.Creation.ButtonContinueEnabled(true);
                    break;
                case "half-elf":
                    ClearSubraceBox();
                    SetRaceTextBox(currRace);
                    this.Creation.ButtonContinueEnabled(true);
                    break;
                case "half-orc":
                    ClearSubraceBox();
                    SetRaceTextBox(currRace);
                    this.Creation.ButtonContinueEnabled(true);
                    break;
                case "human":
                    ClearSubraceBox();
                    SetRaceTextBox(currRace);
                    this.Creation.ButtonContinueEnabled(true);
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
            Label_RaceInfoTitle.Visibility = Visibility.Visible;
            TextBlock_RaceAbilityScoreIncKey.Visibility = Visibility.Visible;
            TextBlock_RaceAgeKey.Visibility = Visibility.Visible;
            TextBlock_RaceAlignmentKey.Visibility = Visibility.Visible;
            TextBlock_RaceSizeKey.Visibility = Visibility.Visible;
            TextBlock_RaceTraitsKey.Visibility = Visibility.Visible;
            TextBlock_RaceSpeedKey.Visibility = Visibility.Visible;
            TextBlock_RaceLanguagesKey.Visibility = Visibility.Visible;
            TextBlock_RaceSubracesKey.Visibility = Visibility.Visible;

            TextBlock_RaceAbilityScoreIncValue.Visibility = Visibility.Visible;
            TextBlock_RaceAgeValue.Visibility = Visibility.Visible;
            TextBlock_RaceAlignmentValue.Visibility = Visibility.Visible;
            TextBlock_RaceSizeValue.Visibility = Visibility.Visible;
            TextBlock_RaceTraitsValue.Visibility = Visibility.Visible;
            TextBlock_RaceSpeedValue.Visibility = Visibility.Visible;
            TextBlock_RaceLanguagesValue.Visibility = Visibility.Visible;
            TextBlock_RaceSubracesValue.Visibility = Visibility.Visible;

            string currRace = ((Button)sender).Tag.ToString();
            
            switch(currRace)
            {
                case "dwarf":
                    Label_RaceInfoTitle.Content = "Dwarf";
                    Rasse dwarf = dndInformation.GetRaceInformation("dwarf");
                    addRaceInfoToTextBlock(dwarf);

                    break;
                case "elf":
                    Label_RaceInfoTitle.Content = "Elf";
                    Rasse elf = dndInformation.GetRaceInformation("elf");
                    addRaceInfoToTextBlock(elf);

                    break;
                case "halfling":
                    Label_RaceInfoTitle.Content = "Halfling";
                    Rasse halfling = dndInformation.GetRaceInformation("halfling");
                    addRaceInfoToTextBlock(halfling);

                    break;
                case "human":
                    Label_RaceInfoTitle.Content = "Human";
                    Rasse human = dndInformation.GetRaceInformation("human");
                    addRaceInfoToTextBlock(human);

                    break;
                case "dragonborn":
                    Label_RaceInfoTitle.Content = "Dragonborn";
                    Rasse dragonborn = dndInformation.GetRaceInformation("dragonborn");
                    addRaceInfoToTextBlock(dragonborn);

                    break;
                case "gnome":
                    Label_RaceInfoTitle.Content = "Gnome";
                    Rasse gnome = dndInformation.GetRaceInformation("gnome");
                    addRaceInfoToTextBlock(gnome);

                    break;
                case "half-orc":
                    Label_RaceInfoTitle.Content = "Half-Orc";
                    Rasse halfOrc = dndInformation.GetRaceInformation("half-orc");
                    addRaceInfoToTextBlock(halfOrc);

                    break;
                case "half-elf":
                    Label_RaceInfoTitle.Content = "Half-Elf";
                    Rasse halfElf = dndInformation.GetRaceInformation("half-elf");
                    addRaceInfoToTextBlock(halfElf);

                    break;
                case "tiefling":
                    Label_RaceInfoTitle.Content = "Tiefling";
                    Rasse tiefling = dndInformation.GetRaceInformation("tiefling");
                    addRaceInfoToTextBlock(tiefling);

                    break;
                default:
                    break;
            }

        }

        private void addRaceInfoToTextBlock(Rasse race)
        {
            TextBlock_RaceAgeValue.Text = race.Age;
            TextBlock_RaceAlignmentValue.Text = race.Alignment;
            TextBlock_RaceSizeValue.Text = race.Size;
            TextBlock_RaceSpeedValue.Text = race.Speed.ToString();

            string compAbilityBonuses = "";                  

            foreach (AbilityBonus abilityBonus in race.AbilityBonuses)
            {
                if (abilityBonus.Equals(race.AbilityBonuses.Last()))
                {
                    compAbilityBonuses += abilityBonus.Name + " +" + abilityBonus.Bonus;
                }
                else
                {
                    compAbilityBonuses += abilityBonus.Name + " +" + abilityBonus.Bonus + ", ";
                }
            }

            TextBlock_RaceAbilityScoreIncValue.Text = compAbilityBonuses;

            string traits = "";

            foreach (Trait trait in race.Traits)
            {
                if (trait.Equals(race.Traits.Last()))
                {
                    traits += trait.Name;
                }
                else
                {
                    traits += trait.Name + ", ";
                }
                
            }

            if (race.Index.Equals("human"))
            {
                TextBlock_RaceTraitsValue.Text = "-";
            }
            else
            {
                TextBlock_RaceTraitsValue.Text = traits;
            }

            string languages = "";

            foreach (Language language in race.Languages)
            {
                if (language.Equals(race.Languages.Last()))
                {
                    languages += language.Name;
                }
                else
                {
                    languages += language.Name + ", ";
                }
            }

            TextBlock_RaceLanguagesValue.Text = languages;

            string subraces = "";

            foreach (SubRace subrace in race.Subraces)
            {
                if (subrace.Equals(race.Subraces.Last()))
                {
                    subraces += subrace.Name;
                }
                else
                {
                    subraces += subrace.Name + ", ";
                }        
            }   
            
            switch(race.Index)
            {
                case "dwarf":
                    subraces += ", Mountain Dwarf";

                    break;
                case "elf":
                    subraces += ", Wood Elf, Dark Elf";

                    break;
                case "halfling":
                    subraces += ", Stout Halfling";

                    break;
                case "gnome":
                    subraces += ", Forest Gnome";

                    break;
                case "human":
                    subraces += "-";

                    break;
                case "dragonborn":
                    subraces += "-";

                    break;
                case "tiefling":
                    subraces += "-";

                    break;
                case "half-orc":
                    subraces += "-";

                    break;
                case "half-elf":
                    subraces += "-";

                    break;
                default:
                    break;
            }

            TextBlock_RaceSubracesValue.Text = subraces;
        }

        private void Button_Race_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
