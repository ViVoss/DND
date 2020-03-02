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
        public Page_Subrace_Dwarf()
        {
            InitializeComponent();
        }

        private void Button_Click_HillDwarf(object sender, RoutedEventArgs e)
        {
            ((Creation)Window.GetWindow(this)).Textbox_Creation_Race.Text = ((Button)sender).Tag.ToString();
        }

        private void Button_Click_MountainDwarf (object sender, RoutedEventArgs e)
        {
            ((Creation)Window.GetWindow(this)).Textbox_Creation_Race.Text = ((Button)sender).Tag.ToString();
        }
    }
}
