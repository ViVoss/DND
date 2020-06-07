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
using System.Windows.Shapes;

namespace DND
{
    /// <summary>
    /// Interaktionslogik für Window_Information_Classes.xaml
    /// </summary>
    public partial class Window_Information : Window
    {
        Page_Information_Classes Information_Classes = new Page_Information_Classes();
        Page_Information_Spells Information_Spells = new Page_Information_Spells();
        Page_Information_Races Information_Races = new Page_Information_Races();
        public Window_Information(string str)
        {
            InitializeComponent();
            if (str == "spells")
            {
                Frame_Information.Content = Information_Spells;
                this.Title = "Spells Overview";
            }
            else if (str == "classes")
            {
                Frame_Information.Content = Information_Classes;
                this.Title = "Classes Overview";
            }
            else if (str == "races")
            {
                Frame_Information.Content = Information_Races;
                this.Title = "Races & Subraces Overview";
            }
            else
            {
                MessageBox.Show("We are sorry an error occurred. Please contact the customer support!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
