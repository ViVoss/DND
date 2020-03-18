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
        Page_RaceSelection RaceSelection;
        Page_ClassSelection ClassSelection;
        Page_BackgroundSelection BackgroundSelection;
        Page_AttributeSelection AttributeSelection;
        Page_InventorySelection InventorySelection;
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

        private Creation()
        {
            InitializeComponent();

            //Pages erstellen
            RaceSelection = new Page_RaceSelection(this);
            ClassSelection = new Page_ClassSelection(this);
            BackgroundSelection = new Page_BackgroundSelection(this);
            AttributeSelection = new Page_AttributeSelection(this);
            InventorySelection = new Page_InventorySelection(this);
            SpellSelection = new Page_SpellSelection(this);
            MiscellaneousSelection = new Page_Miscellaneous(this);
            OverviewSelection = new Page_Overview(this);
            Btn_Back.Visibility = Visibility.Hidden;

            //Erste Seite anzeigen
            Frame1.Content = RaceSelection;

            //RaceSelection laden
            this.Textbox_Selection_Info.Text = Character.Current.SubRace;

            //Continue-Button zu Beginn deaktivieren
            if (this.Textbox_Selection_Info.Text == "")
                ButtonContinueEnabled(false);
            else
                ButtonContinueEnabled(true);

            //Back-Button zu Beginn deaktivieren
            ButtonBackEnabled(false);
        }

        private void Btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (Frame1.Content == RaceSelection)
            {
                //RaceSelection speichern
                Character.Current.SubRace = this.Textbox_Selection_Info.Text;

                Frame1.Content = ClassSelection;
                //ClassSelection laden

                this.Textbox_Selection_Info.Text = Character.Current.Class;

                //Continue-Button zu Beginn deaktivieren
                if (this.Textbox_Selection_Info.Text == "")
                    ButtonContinueEnabled(false);
                else
                    ButtonContinueEnabled(true);

                //Back-Button aktivieren
                ButtonBackEnabled(true);

            }


            else if (Frame1.Content == ClassSelection)
            {
                //ClassSelection speichern
                Character.Current.Class = this.Textbox_Selection_Info.Text;

                Frame1.Content = BackgroundSelection;
                //BackgroundSelection laden

                this.Textbox_Selection_Info.Text = Character.Current.Background;
            }


            else if (Frame1.Content == BackgroundSelection)
            {
                //BackgroundSelection speichern
                Character.Current.Background = this.Textbox_Selection_Info.Text;

                Frame1.Content = AttributeSelection;
                //AttributeSelection laden

                this.Textbox_Selection_Info.Text = "";
                AttributeSelection.cmbAttributeValuesStr.Text = Convert.ToString(Character.Current.Attributes.Strength);
                AttributeSelection.cmbAttributeValuesDex.Text = Convert.ToString(Character.Current.Attributes.Dexterity);
                AttributeSelection.cmbAttributeValuesCon.Text = Convert.ToString(Character.Current.Attributes.Constitution);
                AttributeSelection.cmbAttributeValuesInt.Text = Convert.ToString(Character.Current.Attributes.Intelligence);
                AttributeSelection.cmbAttributeValuesWis.Text = Convert.ToString(Character.Current.Attributes.Wisdon);
                AttributeSelection.cmbAttributeValuesCha.Text = Convert.ToString(Character.Current.Attributes.Charisma);
            }


            else if (Frame1.Content == AttributeSelection)
            {
                //AttributeSelection speichern
                Character.Current.Attributes.Strength = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesStr.Text);
                Character.Current.Attributes.Dexterity = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesDex.Text);
                Character.Current.Attributes.Constitution = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesCon.Text);
                Character.Current.Attributes.Intelligence = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesInt.Text);
                Character.Current.Attributes.Wisdon = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesWis.Text);
                Character.Current.Attributes.Charisma = Convert.ToUInt16(AttributeSelection.cmbAttributeValuesCha.Text);


                Frame1.Content = InventorySelection;
                //InventorySelection laden
            }


            else if (Frame1.Content == InventorySelection)
            {
                //InventorySelection speichern


                Frame1.Content = SpellSelection;
                //SpellSelection laden
            }


            else if (Frame1.Content == SpellSelection)
            {
                //SpellSelection speichern


                Frame1.Content = MiscellaneousSelection;
                //MiscellaneousSelection laden

                if (Character.Current.CharacterName != "")
                {
                    //Kopie vom CharacterName im OldCharacterName hinterlegen
                    if (Character.Current.OldCharacterName == null)
                    {
                        Character.Current.OldCharacterName = Character.Current.CharacterName;
                    }

                    //Characternamen einlesen
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
                    Character.Current.CharacterName = MiscellaneousSelection.CharacterName.Text;
                }

                Frame1.Content = OverviewSelection;
                //OverviewSelection laden

            }


            else if(Frame1.Content == OverviewSelection)
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
            }
            else if (Frame1.Content == BackgroundSelection)
            {
                Frame1.Content = ClassSelection;
            }
            else if (Frame1.Content == AttributeSelection)
            {
                Frame1.Content = BackgroundSelection;
            }
            else if (Frame1.Content == InventorySelection)
            {
                Frame1.Content = AttributeSelection;
            }
            else if (Frame1.Content == SpellSelection)
            {
                Frame1.Content = InventorySelection;
            }
            else if (Frame1.Content == MiscellaneousSelection)
            {
                Frame1.Content = SpellSelection;
            }
            else if (Frame1.Content == OverviewSelection)
            {
                Frame1.Content = MiscellaneousSelection;
                ContinueButtonEnabled(true);
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
