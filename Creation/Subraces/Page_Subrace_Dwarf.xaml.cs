using DND;
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


namespace DND
{
    /// <summary>
    /// Interaktionslogik für Page_Subrace_Dwarf.xaml
    /// </summary>
    public partial class Page_Subrace_Dwarf : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Creation Creation { get; set; }

        public Page_Subrace_Dwarf(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();

            SubRace hillDwarf = dndInformation.GetSubRaceInformation("hill-dwarf");
            SubRace mountainDwarf = dndInformation.GetSubRaceDbInformation("mountain-dwarf");

            Frame_HillDwarf_StackPanel.Content = new Page_Subrace_Info_StackPanel(hillDwarf);
            Frame_MountainDwarf_StackPanel.Content = new Page_Subrace_Info_StackPanel(mountainDwarf);
        }
        private void Button_Subrace_Click(object sender, RoutedEventArgs e)
        {
            this.Creation.Label_Subrace.Content = "Subrace";
            this.Creation.TextBox_Subrace.Text = ((Button)sender).Tag.ToString();
            this.Creation.TextBox_Race.Text = "Dwarf";
            this.Creation.ButtonContinueEnabled(true);
        }
    }
}
