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
    /// Interaktionslogik für Page_Information_Races.xaml
    /// </summary>
    public partial class Page_Information_Races : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Page_Information_Races()
        {
            InitializeComponent();
        }

        private void Button_Race_Click(object sender, RoutedEventArgs e)
        {
            string currRace = ((Button)sender).Tag.ToString();

            switch (currRace)
            {
                case "dwarf":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("dwarf");
                    break;
                case "elf":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("elf");
                    break;
                case "halfling":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("halfling");
                    break;
                case "human":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("human");
                    break;
                case "dragonborn":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("dragonborn");
                    break;
                case "gnome":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("gnome");
                    break;
                case "half-orc":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("half-orc");
                    break;
                case "half-elf":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("half-elf");
                    break;
                case "tiefling":
                    TextBlock_RaceInfo.Text = dndInformation.GetRaceInformation("tiefling");
                    break;
                default:
                    break;
            }
        }
    }
}
