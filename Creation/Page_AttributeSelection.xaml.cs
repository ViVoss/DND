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
        public Page_AttributeSelection()
        {
            InitializeComponent();
        }


        private void cmbAttributeValuesStr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
            MessageBox.Show((((ComboBox)sender)).SelectedItem.ToString()); //wie kommt man genau an den Inhalt?
            string test = (((ComboBox)sender)).SelectedItem.ToString();
            Character.Current.Attributes.Strength = Convert.ToUInt16(test);
            this.Label_STR.Content = Character.Current.Attributes.StrengthModifier;


        }
        private void cmbAttributeValuesDex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void cmbAttributeValuesCon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbAttributeValuesInt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbAttributeValuesWis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbAttributeValuesCha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
