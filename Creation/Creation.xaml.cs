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
    /// Interaktionslogik für Creation.xaml
    /// </summary>
    public partial class Creation : Window
    {
        Page_ClassSelection ClassSelectionPage1 = new Page_ClassSelection();
        Page_RaceSelection RaceSelectionPage1 = new Page_RaceSelection();
        Page_BackgroundSelection BackgroundSelectionPage1 = new Page_BackgroundSelection();
        bool ClassPageOpen = false;

        
        

        public Creation()
        {
            InitializeComponent();
            Frame1.Content = RaceSelectionPage1;
   

        }

        private void Btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (!ClassPageOpen)
            {
                Frame1.Content = ClassSelectionPage1;
                ClassPageOpen = true;
            }
            else
                Frame1.Content = BackgroundSelectionPage1;
                
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            //Frame1.Content = null;
            Frame1.Content = RaceSelectionPage1;
            ClassPageOpen = false;
        }
    }
}
