using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DND
{
    /// <summary>
    /// Interaktionslogik für Creation.xaml
    /// </summary>
    public partial class Creation : Window
    {
        List<CharacterStats> characterStats = new List<CharacterStats>();
        Page_ClassSelection ClassSelection;
        Page_RaceSelection RaceSelection;
        Page_BackgroundSelection BackgroundSelection;
        Page_AttributeSelection AttributeSelection;
        Page_SpellSelection SpellSelection;
        Page_Miscellaneous MiscellaneousSelection;
        Page_Overview OverviewSelection;

        public static Creation OpenWindow()
        {
            //Window erstellen
            Creation creation = new Creation();

            //Window anzeigen
            creation.Show();

            //Window übergeben
            return creation;
        }

        public class CharacterStats
        {
            public string Race { get; set; }
            public string Subrace { get; set; }
            public string Class { get; set; }
            public string Background { get; set; }
        }
        private Creation()
        {
            InitializeComponent();

            //Pages erstellen
            RaceSelection = new Page_RaceSelection(this);
            ClassSelection = new Page_ClassSelection(this);
            BackgroundSelection = new Page_BackgroundSelection(this);
            AttributeSelection = new Page_AttributeSelection(this);
            SpellSelection = new Page_SpellSelection(this);
            MiscellaneousSelection = new Page_Miscellaneous(this);
            OverviewSelection = new Page_Overview(this);

            //Erste Seite anzeigen
            Frame1.Content = RaceSelection;

            //RaceSelection laden
            this.TextBox_Race.Text = Character.Current.Race;
            this.TextBox_Subrace.Text = Character.Current.SubRace;
            this.TextBox_Class.Text = Character.Current.Class;
            this.TextBox_Background.Text = Character.Current.Background;

            //Continue-Button zu Beginn deaktivieren
            if (this.TextBox_Race.Text == "")
                ButtonContinueEnabled(false);
            else
                ButtonContinueEnabled(true);

            //Back-Button zu Beginn deaktivieren
            Btn_Back.Visibility = Visibility.Hidden;
            ButtonBackEnabled(false);
        }

        private void Btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (Frame1.Content == RaceSelection)
            {
                Character.Current.OldCharacterName = Character.Current.CharacterName;

                //RaceSelection speichern
                Character.Current.Race = this.TextBox_Race.Text;
                Character.Current.SubRace = this.TextBox_Subrace.Text;

                //ClassSelection laden
                Frame1.Content = ClassSelection;
                this.TextBox_Class.Text = Character.Current.Class;

                //Continue-Button zu Beginn deaktivieren
                if (this.TextBox_Class.Text == "")
                    ButtonContinueEnabled(false);
                else
                    ButtonContinueEnabled(true);

                //Back-Button aktivieren
                Btn_Back.Visibility = Visibility.Visible;
                ButtonBackEnabled(true);
            }

            else if (Frame1.Content == ClassSelection)
            {
                //ClassSelection speichern
                Character.Current.Class = this.TextBox_Class.Text;

                //BackgroundSelection laden
                Frame1.Content = BackgroundSelection;
                this.TextBox_Background.Text = Character.Current.Background;
                
                //Continue-Button zu Beginn deaktivieren
                if (this.TextBox_Background.Text == "")
                    ButtonContinueEnabled(false);
                else
                    ButtonContinueEnabled(true);
            }

            else if (Frame1.Content == BackgroundSelection)
            {
                //BackgroundSelection speichern
                Character.Current.Background = this.TextBox_Background.Text;

                //AttributeSelection laden
                Frame1.Content = AttributeSelection;
                if (AttributeSelection.cmbAttributeValuesStr.Text == "" || AttributeSelection.cmbAttributeValuesDex.Text == "" || AttributeSelection.cmbAttributeValuesCon.Text == "" ||
                    AttributeSelection.cmbAttributeValuesInt.Text == "" || AttributeSelection.cmbAttributeValuesWis.Text == "" || AttributeSelection.cmbAttributeValuesCha.Text == "")
                    ButtonContinueEnabled(false);
                else
                    ButtonContinueEnabled(true);
                return;
                AttributeSelection.cmbAttributeValuesStr.Text = Convert.ToString(Character.Current.Attributes.Strength);
                AttributeSelection.cmbAttributeValuesDex.Text = Convert.ToString(Character.Current.Attributes.Dexterity);
                AttributeSelection.cmbAttributeValuesCon.Text = Convert.ToString(Character.Current.Attributes.Constitution);
                AttributeSelection.cmbAttributeValuesInt.Text = Convert.ToString(Character.Current.Attributes.Intelligence);
                AttributeSelection.cmbAttributeValuesWis.Text = Convert.ToString(Character.Current.Attributes.Wisdom);
                AttributeSelection.cmbAttributeValuesCha.Text = Convert.ToString(Character.Current.Attributes.Charisma);
            }

            else if (Frame1.Content == AttributeSelection)
            {
                //AttributeSelection speichern
                Character.Current.Attributes.Strength = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesStr.Text);
                Character.Current.Attributes.Dexterity = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesDex.Text);
                Character.Current.Attributes.Constitution = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesCon.Text);
                Character.Current.Attributes.Intelligence = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesInt.Text);
                Character.Current.Attributes.Wisdom = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesWis.Text);
                Character.Current.Attributes.Charisma = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesCha.Text);

                //InventorySelection laden
                switch (Character.Current.Class)
                {
                    case "bard":
                        Frame1.Content = SpellSelection;

                        break;
                    case "cleric":
                        Frame1.Content = SpellSelection;

                        break;
                    case "druid":
                        Frame1.Content = SpellSelection;

                        break;
                    case "paladin":
                        Frame1.Content = SpellSelection;

                        break;
                    case "ranger":
                        Frame1.Content = SpellSelection;

                        break;
                    case "sorcerer":
                        Frame1.Content = SpellSelection;

                        break;
                    case "warlock":
                        Frame1.Content = SpellSelection;

                        break;
                    case "wizard":
                        Frame1.Content = SpellSelection;

                        break;
                    default:
                        Frame1.Content = MiscellaneousSelection;

                        break;
                }
            }


            else if (Frame1.Content == SpellSelection)
            {
                //SpellSelection speichern

                //MiscellaneousSelection laden
                Frame1.Content = MiscellaneousSelection;

                if (Character.Current.CharacterName != "")
                {
                    //Kopie vom CharacterName im OldCharacterName hinterlegen
                    Character.Current.OldCharacterName = Character.Current.CharacterName;

                    //Characternamen auslesen
                    MiscellaneousSelection.CharacterName.Text = Character.Current.CharacterName;
                }
            }


            else if (Frame1.Content == MiscellaneousSelection)
            {
                //MiscellaneousSelection speichern

                if (MiscellaneousSelection.CharacterName.Text == "")
                {
                    MessageBox.Show("CharacterName is missing");
                    return;
                }
                else
                {
                    //OverviewSelection laden
                    Frame1.Content = OverviewSelection;
                    Btn_Continue.Visibility = Visibility.Hidden;
                }
            }


            else if (Frame1.Content == OverviewSelection)
            {
                //OverviewSelection speichern

            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {

            if (Frame1.Content == RaceSelection)
            {
            }
            else if (Frame1.Content == ClassSelection)
            {
                Frame1.Content = RaceSelection;
                Btn_Back.Visibility = Visibility.Hidden;
                if (this.TextBox_Race.Text != "")
                    ButtonContinueEnabled(true);
            }
            else if (Frame1.Content == BackgroundSelection)
            {
                Frame1.Content = ClassSelection;
                if (this.TextBox_Class.Text != "")
                    ButtonContinueEnabled(true);
            }
            else if (Frame1.Content == AttributeSelection)
            {
                Frame1.Content = BackgroundSelection;
                if (this.TextBox_Background.Text != "")
                    ButtonContinueEnabled(true);
            }
            else if (Frame1.Content == SpellSelection)
            {
                Frame1.Content = AttributeSelection;
            }
            else if (Frame1.Content == MiscellaneousSelection)
            {
                switch (Character.Current.Class)
                {
                    case "bard":
                        Frame1.Content = SpellSelection;

                        break;
                    case "cleric":
                        Frame1.Content = SpellSelection;

                        break;
                    case "druid":
                        Frame1.Content = SpellSelection;

                        break;
                    case "paladin":
                        Frame1.Content = SpellSelection;

                        break;
                    case "ranger":
                        Frame1.Content = SpellSelection;

                        break;
                    case "sorcerer":
                        Frame1.Content = SpellSelection;

                        break;
                    case "warlock":
                        Frame1.Content = SpellSelection;

                        break;
                    case "wizard":
                        Frame1.Content = SpellSelection;

                        break;
                    default:
                        Frame1.Content = AttributeSelection;

                        break;
                }
            }
            else if (Frame1.Content == OverviewSelection)
            {
                Frame1.Content = MiscellaneousSelection;
                ButtonContinueEnabled(true);
                Btn_Continue.Visibility = Visibility.Visible;
            }
        }

        public void ButtonBackEnabled(bool activated)
        {
            this.Btn_Back.IsEnabled = activated;
        }
        public void ButtonContinueEnabled(bool activated)
        {
            this.Btn_Continue.IsEnabled = activated;
        }
    }
}
