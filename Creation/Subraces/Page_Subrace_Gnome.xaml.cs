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

namespace DND.Subraces
{
    /// <summary>
    /// Interaktionslogik für Page_Subrace_Gnome.xaml
    /// </summary>
    public partial class Page_Subrace_Gnome : Page
    {

        public Creation Creation { get; set; }

        public Page_Subrace_Gnome(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Creation.Textbox_Selection_Info.Text = ((Button)sender).Tag.ToString();
            Creation.ButtonContinueEnabled(true);
            ((Window_SubraceSelection)Window.GetWindow(this)).Close();
        }
    }
}
