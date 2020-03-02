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
    /// Interaktionslogik für Window_SubraceSelection.xaml
    /// </summary>
    public partial class Window_SubraceSelection : Window
    {
        Page_Subrace_Dwarf PageSubraceDwarf = new Page_Subrace_Dwarf();
        public Window_SubraceSelection()
        {
            InitializeComponent();
            Frame_SubraceSelection.Content = PageSubraceDwarf;
        }
    }
}
