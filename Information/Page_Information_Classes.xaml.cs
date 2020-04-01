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
    /// Interaktionslogik für Page_Information_Classes.xaml
    /// </summary>
    public partial class Page_Information_Classes : Page
    {
        public Page_Information_Classes()
        {
            InitializeComponent();
        }

        private void Button_Class_Click(object sender, RoutedEventArgs e)
        {
            string currClass = ((Button)sender).Tag.ToString();

            
            switch (currClass)
            {
                case "barbarian":
                    Frame_LevelTable.Navigate(new Level_Table_Barbarian(this));
                    break;
                case "bard":
                    Frame_LevelTable.Navigate(new Level_Table_Bard());
                    break;
                case "cleric":
                    break;
                case "druid":
                    //Frame_LevelTable.Navigate(new Level_Table_Druid());
                    break;
                default:
                    break;
            }
        }
    }
}
