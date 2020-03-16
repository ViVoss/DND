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


        //Obsolete?
        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    switch (((ComboBox)sender).Tag.ToString())
        //    {
        //        case "STR":
        //            Label_STR.Content = ((ComboBox)sender).Text;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private void cmbAttributeValuesStr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((ComboBox)sender).SelectedItem.ToString()); //wie kommt man genau an den Inhalt?
            MessageBox.Show(this.cmbAttributeValuesStr.Text);

            Character.Current.Attributes.Strength = Convert.ToUInt16(this.cmbAttributeValuesStr.Text);
            this.Label_STR.Content = Character.Current.Attributes.StrengthModifier;
        }
        private void cmbAttributeValuesDex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Dexterity = Convert.ToUInt16(this.cmbAttributeValuesDex.Text);
            this.Label_DEX.Content = Character.Current.Attributes.DexterityModifier;
        }

        private void cmbAttributeValuesCon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Constitution = Convert.ToUInt16(this.cmbAttributeValuesCon.Text);
            this.Label_CON.Content = Character.Current.Attributes.ConstitutionModifier;
        }

        private void cmbAttributeValuesInt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Intelligence = Convert.ToUInt16(this.cmbAttributeValuesInt.Text);
            this.Label_INT.Content = Character.Current.Attributes.IntelligenceModifier;
        }

        private void cmbAttributeValuesWis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Wisdon = Convert.ToUInt16(this.cmbAttributeValuesWis.Text);
            this.Label_WIS.Content = Character.Current.Attributes.WisdonModifier;
        }

        private void cmbAttributeValuesCha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Charisma = Convert.ToUInt16(this.cmbAttributeValuesCha.Text);
            this.Label_CHA.Content = Character.Current.Attributes.CharismaModifier;
        }
    }
}
