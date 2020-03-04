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
    /// Interaktionslogik für Page_RaceSelection.xaml
    /// </summary>
    public partial class Page_RaceSelection : Page
    {
        public Page_RaceSelection()
        {
            InitializeComponent();
        }

        private void Button_Race_Click(object sender, RoutedEventArgs e)
        {
            string currRace = ((Button)sender).Tag.ToString();
            Window_SubraceSelection subra = new Window_SubraceSelection(((Creation)Window.GetWindow(this)), currRace);
            subra.ShowDialog();
        }
        private void Button_Race_MouseEnter(object sender, MouseEventArgs e)
        {

        }
        private void Button_Race_MouseLeave(object sender, MouseEventArgs e)
        {
        }
    }
}