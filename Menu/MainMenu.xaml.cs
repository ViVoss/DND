using DND.Dialoges;
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
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        private string CopyrightDisclaimer = "Dungeons & Dragons, D&D, their respective logos, and all Wizards titles and characters are property of Wizards of the Coast LLC in the U.S.A. and other countries. ©2020 Wizards.";
        public string TargetCharacterName { get; set; }
        public Window_Dialog Window { get; set; }
        public Page_ChooseCharacterToLoad Page { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            Label_CopyrightDisclaimer.Content = CopyrightDisclaimer;
        }
        // Creation >>>
        private void Creation_ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to create a new character?", "Character creation", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                //Neuen leeren Character erstellen
                Character.New();

                DND.Creation.OpenWindow();
            }
            else if(result == MessageBoxResult.No)
            {
                //Abfragefenster erstellen
                Window = new Window_Dialog();
                Page = new Page_ChooseCharacterToLoad(Window, this);
                Window.frame.Content = Page;
                //Öffnen
                Window.ShowDialog();


                //Eingabe gemacht?
                if(TargetCharacterName != "")
                {
                    //Character finden und laden
                    if (Character.Load(TargetCharacterName))
                    {
                        DND.Creation.OpenWindow();
                    }
                }
            }

            //In die Klammern verschoben
            //Creation Creation1 = new Creation();
            //Creation1.Show();
        }
        private void Spells_Click(object sender, RoutedEventArgs e)
        {
            Window_Information spellsInfo = new Window_Information("spells");
            spellsInfo.Show();
        }
        private void Races_Click(object sender, RoutedEventArgs e)
        {
            Window_Information racesInfo = new Window_Information("races");
            racesInfo.Show();
        }

        private void Classes_Click(object sender, RoutedEventArgs e)
        {
            Window_Information classesInfo = new Window_Information("classes");
            classesInfo.Show();
        }
    }
}

