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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DND.Subraces
{
    /// <summary>
    /// Interaktionslogik für Page_Subrace_Halfling.xaml
    /// </summary>
    public partial class Page_Subrace_Halfling : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Creation Creation { get; set; }
        public Page_Subrace_Halfling(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();

            SubRace lightfootHalfling = dndInformation.GetSubRaceInformation("lightfoot-halfling");
            SubRace stoutHalfling = dndInformation.GetSubRaceDbInformation("stout-halfling");

            Frame_LightfootHalfling_StackPanel.Content = new Page_Subrace_Info_StackPanel(lightfootHalfling);
            Frame_StoutHalfling_StackPanel.Content = new Page_Subrace_Info_StackPanel(stoutHalfling);
        }

        private void Button_Subrace_Click(object sender, RoutedEventArgs e)
        {
            this.Creation.Label_Subrace.Content = "Subrace";
            this.Creation.TextBox_Subrace.Text = ((Button)sender).Tag.ToString();
            this.Creation.TextBox_Race.Text = "Halfling";
            this.Creation.ButtonContinueEnabled(true);
        }
    }
}
