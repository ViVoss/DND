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
        string CopyrightDisclaimer = "Dungeons & Dragons, D&D, their respective logos, and all Wizards titles and characters are property of Wizards of the Coast LLC in the U.S.A. and other countries. ©2020 Wizards.";
        public String CharacterName { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            Label_CopyrightDisclaimer.Content = CopyrightDisclaimer;
        }
        // Creation >>>
        private void Creation_ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Neuen Character erstellen?", "Charactererstellung", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                //Neuer leerer Character erstellt
                Character.New();
            }
            else if(result == MessageBoxResult.No)
            {
                Window_Dialog window = new Window_Dialog();
                Page_NewOrLoadCharacter page = new Page_NewOrLoadCharacter(this);
                window.frame.Content = page;
                window.ShowDialog();

                //Character finden und laden
                if (Character.Load("") == false)
                {

                }
            }
            else
            {

            }


            Creation Creation1 = new Creation();
            Creation1.Show();
        }
        private void Spells_Click(object sender, RoutedEventArgs e)
        {            

        }
        private void Races_ButtonClick(object sender, RoutedEventArgs e)
        {

        }
        private void Classes_ButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void Classes_Click(object sender, RoutedEventArgs e)
        {
            TEST_Window TEST = new TEST_Window();
            TEST.Show();
        }
    }
}

