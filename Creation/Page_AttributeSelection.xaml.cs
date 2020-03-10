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
    /// Interaktionslogik für Page_AttributeSelection.xaml
    /// </summary>
    public partial class Page_AttributeSelection : Page
    {
        List<StatsList> AttributeValues = new List<StatsList>();
        public Page_AttributeSelection()
        {
            InitializeComponent();
            AttributeValues.Add(new StatsList { Number = "8" });
            AttributeValues.Add(new StatsList { Number = "10" });
            AttributeValues.Add(new StatsList { Number = "12" });
            AttributeValues.Add(new StatsList { Number = "13" });
            AttributeValues.Add(new StatsList { Number = "14" });
            AttributeValues.Add(new StatsList { Number = "15" });
            cmbAttributeValuesStr.ItemsSource = cmbAttributeValuesDex.ItemsSource = cmbAttributeValuesCon.ItemsSource = cmbAttributeValuesInt.ItemsSource
                = cmbAttributeValuesWis.ItemsSource = cmbAttributeValuesCha.ItemsSource = AttributeValues;
        }
        public class StatsList
        {
            public string Number { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ComboBox)sender).Tag.ToString())
            {
                case "STR":
                    Label_STR.Content = ((ComboBox)sender).Text;
                    break;
                default:
                    break;
            }
        }

        private void cmbAttributeValuesStr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string attval = "";
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    attval = Convert.ToString(-1);
                    break;
                case 1:
                    attval = Convert.ToString(0);
                    break;
                case 2:
                    attval = Convert.ToString("+"+1);
                    break;
                case 3:
                    attval = Convert.ToString("+"+1);
                    break;
                default:
                    break;
            }
            Label_STR.Content = attval;
        }
    }
}
