using DND.Subraces;
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
    /// Interaktionslogik für Window_SubraceSelection.xaml
    /// </summary>
    public partial class Window_SubraceSelection : Window
    {
        public Creation Creation { get; set; }
        public string currRace { get; set; } 

        public Window_SubraceSelection(Creation CreationWindow, string currRace)
        {
            this.Creation = CreationWindow;
            InitializeComponent();
            Page test = null;
            switch (currRace)
            {
                case "dwarf":
                    test = new Page_Subrace_Dwarf(Creation);
                    break;
                case "elf":
                    test = new Page_Subrace_Elf(Creation);
                    this.Width = 540;
                    break;
                case "halfling":
                    test = new Page_Subrace_Halfling(Creation);
                    break;
                case "dragonborn":
                    test = new Page_Subrace_Dragonborn(Creation);
                    this.Height = 460;
                    break;
                case "gnome":
                    test = new Page_Subrace_Gnome(Creation);
                    break;
                default:
                    this.Creation.TextBox_Subrace.Text = "";
                    this.Creation.TextBox_Race.Text = "";
                    break;
            }
            Frame_SubraceSelection.Content = test;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //Schreibt die Informationen aus der Textbox_Selection_Info der Creation Page in den Current Character
            //(die bevor das Fenster geschlossen wird, frisch mit der Subrace beschrieben wurde)
            Character.Current.SubRace = this.Creation.TextBox_Subrace.Text;
            Character.Current.Race = this.Creation.TextBox_Race.Text;
        }
    }
}
