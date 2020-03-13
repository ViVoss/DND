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
    /// Interaktionslogik für Page_Overview.xaml
    /// </summary>
    public partial class Page_Overview : Page
    {

        public Creation Creation { get; set; }

        public Page_Overview(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();


        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Creation.Close();
            Character.Save();
        }
    }
}
