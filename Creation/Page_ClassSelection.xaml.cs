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
    /// Interaktionslogik für ClassesSelection.xaml
    /// </summary>
    public partial class Page_ClassSelection : Page
    {
        WebAufruf call = new WebAufruf();
        public Page_ClassSelection()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            string klasse = ((Button)sender).Tag.ToString();
            TextBox_Description.Text = call.GetClassInformation(klasse);
        }
    }
}
