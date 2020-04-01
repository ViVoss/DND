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
    /// Interaktionslogik für Page_Information_Spells.xaml
    /// </summary>
    public partial class Page_Information_Spells : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Page_Information_Spells()
        {
            InitializeComponent();
            DataGrid_Spells.ItemsSource = dndInformation.GetSpellsInformation();
        }
    }
}
