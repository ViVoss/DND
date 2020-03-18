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
        public Window_Information()
        {
            InitializeComponent();
            Frame_Information.Content = Information_Classes;
        }
    }
}
