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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DND.Subraces
{
    /// <summary>
    /// Interaktionslogik für Page_Subrace_Gnome.xaml
    /// </summary>
    public partial class Page_Subrace_Gnome : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Creation Creation { get; set; }
        public Page_Subrace_Gnome(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();

            SubRace rockGnome = dndInformation.GetSubRaceInformation("rock-gnome");
            SubRace forestGnome = dndInformation.GetSubRaceDbInformation("forest-gnome");

            Frame_ForestGnome_StackPanel.Content = new Page_Subrace_Info_StackPanel(forestGnome);
            Frame_RockGnome_StackPanel.Content = new Page_Subrace_Info_StackPanel(rockGnome);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Creation.Label_Subrace.Content = "Subrace";
            this.Creation.TextBox_Subrace.Text = ((Button)sender).Tag.ToString();
            this.Creation.TextBox_Race.Text = "Gnome";
            this.Creation.ButtonContinueEnabled(true);
            ((Window_SubraceSelection)Window.GetWindow(this)).Close();
        }
    }
}
