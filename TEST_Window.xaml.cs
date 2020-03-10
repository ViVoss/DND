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
    /// Interaktionslogik für TEST_Window.xaml
    /// </summary>
    public partial class TEST_Window : Window
    {
        Page_AttributeSelection test = new Page_AttributeSelection();
        public TEST_Window()
        {
            InitializeComponent();
            Test_Frame.Content = test;
        }
    }
}
