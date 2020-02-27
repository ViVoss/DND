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

        public Creation()
        {

            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Barbarian BarbarianPage = new Barbarian();
            Frame1.Content = BarbarianPage;

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Cleric clericPage = new Cleric();
            Frame1.Content = clericPage;
        }
    }
}
