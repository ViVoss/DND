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
    /// Interaktionslogik für Page_Subrace_Elf.xaml
    /// </summary>
    public partial class Page_Subrace_Elf : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Creation Creation { get; set; }
        public Page_Subrace_Elf(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();

            SubRace highElf = dndInformation.GetSubRaceInformation("high-elf");
            SubRace woodElf = dndInformation.GetSubRaceDbInformation("wood-elf");
            SubRace darkElf = dndInformation.GetSubRaceDbInformation("dark-elf");

            Frame_HighElf_StackPanel.Content = new Page_Subrace_Info_StackPanel(highElf);
            Frame_WoodElf_StackPanel.Content = new Page_Subrace_Info_StackPanel(woodElf);
            Frame_DarkElf_StackPanel.Content = new Page_Subrace_Info_StackPanel(darkElf);
        }

        private void Button_Subrace_Click(object sender, RoutedEventArgs e)
        {
            this.Creation.Label_Subrace.Content = "Subrace";
            this.Creation.TextBox_Subrace.Text = ((Button)sender).Tag.ToString();
            this.Creation.TextBox_Race.Text = "Elf";
            this.Creation.ButtonContinueEnabled(true);
            ((Window_SubraceSelection)Window.GetWindow(this)).Close();
        }
    }
}
