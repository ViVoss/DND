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
            Character.Current.Attributes.Strength = Convert.ToUInt16(((ComboBox) sender).SelectedValue);
            this.Label_STR.Content = Character.Current.Attributes.StrengthModifier;
            



            //string attval = "";
            //switch (((ComboBox)sender).SelectedIndex)
            //{
            //    case 0:
            //        attval = Convert.ToString(-1);
            //        break;
            //    case 1:
            //        attval = Convert.ToString(0);
            //        break;
            //    case 2:
            //        attval = Convert.ToString("+" + 1);
            //        break;
            //    case 3:
            //        attval = Convert.ToString("+" + 2);
            //        break;
            //    case 4:
            //        attval = Convert.ToString("+" + 3);
            //        break;
            //    case 5:
            //        attval = Convert.ToString("+" + 4);
            //        break;
            //    case 6:
            //        attval = Convert.ToString("+" + 5);
            //        break;
            //    default:
            //        break;
            //}
            //Label_STR.Content = attval;
        }
    }
}
