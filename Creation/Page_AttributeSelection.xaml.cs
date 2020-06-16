using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        public ObservableCollection<int> cmbItemList = new ObservableCollection<int>();

        public Creation Creation { get; set; }

        public Page_AttributeSelection(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();

            cmbItemList.Add(8);
            cmbItemList.Add(10);
            cmbItemList.Add(12);
            cmbItemList.Add(13);
            cmbItemList.Add(14);
            cmbItemList.Add(15);

            cmbAttributeValuesStr.ItemsSource = cmbItemList;
            cmbAttributeValuesDex.ItemsSource = cmbItemList;
            cmbAttributeValuesCon.ItemsSource = cmbItemList;
            cmbAttributeValuesInt.ItemsSource = cmbItemList;
            cmbAttributeValuesWis.ItemsSource = cmbItemList;
            cmbAttributeValuesCha.ItemsSource = cmbItemList;
        }

        private void cmbAttributeValuesStr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Strength = Convert.ToUInt16(GetAttributeValueFromSelectedIndex(this.cmbAttributeValuesStr.SelectedIndex));
            this.Label_STR.Content = Character.Current.Attributes.StrengthModifier;
            EnableContinueBtn();
        }
        private void cmbAttributeValuesDex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Dexterity = Convert.ToUInt16(GetAttributeValueFromSelectedIndex(this.cmbAttributeValuesDex.SelectedIndex));
            this.Label_DEX.Content = Character.Current.Attributes.DexterityModifier;
            EnableContinueBtn();
        }

        private void cmbAttributeValuesCon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Constitution = Convert.ToUInt16(GetAttributeValueFromSelectedIndex(this.cmbAttributeValuesCon.SelectedIndex));
            this.Label_CON.Content = Character.Current.Attributes.ConstitutionModifier;
            EnableContinueBtn();
        }

        private void cmbAttributeValuesInt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Intelligence = Convert.ToUInt16(GetAttributeValueFromSelectedIndex(this.cmbAttributeValuesInt.SelectedIndex));
            this.Label_INT.Content = Character.Current.Attributes.IntelligenceModifier;
            EnableContinueBtn();
        }

        private void cmbAttributeValuesWis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Wisdom = Convert.ToUInt16(GetAttributeValueFromSelectedIndex(this.cmbAttributeValuesWis.SelectedIndex));
            this.Label_WIS.Content = Character.Current.Attributes.WisdomModifier;
            EnableContinueBtn();
        }

        private void cmbAttributeValuesCha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.Attributes.Charisma = Convert.ToUInt16(GetAttributeValueFromSelectedIndex(this.cmbAttributeValuesCha.SelectedIndex));
            this.Label_CHA.Content = Character.Current.Attributes.CharismaModifier;
            EnableContinueBtn();
        }
        private void EnableContinueBtn()
        {
            if (Character.Current.Attributes.Strength != 0 & Character.Current.Attributes.Dexterity != 0 & Character.Current.Attributes.Constitution != 0 &
                Character.Current.Attributes.Intelligence != 0 & Character.Current.Attributes.Wisdom != 0 & Character.Current.Attributes.Charisma != 0)
            {
                int[] attrValues = new int[6] {
                    Character.Current.Attributes.Strength,
                    Character.Current.Attributes.Dexterity,
                    Character.Current.Attributes.Constitution,
                    Character.Current.Attributes.Intelligence,
                    Character.Current.Attributes.Wisdom,
                    Character.Current.Attributes.Charisma
                };

                if (attrValues.Distinct().Count() == attrValues.Length)
                {
                    TextBlock_Attribute_Selection_Error.Visibility = Visibility.Hidden;
                    this.Creation.Btn_Continue.IsEnabled = true;
                }
                else
                {
                    this.Creation.Btn_Continue.IsEnabled = false;
                    TextBlock_Attribute_Selection_Error.Text = "Die Attributsauswahl darf keine übereinstimmenden Werte haben!";
                    TextBlock_Attribute_Selection_Error.Visibility = Visibility.Visible;
                }
            }
            else
            {
                this.Creation.Btn_Continue.IsEnabled = false;
            }
        }

        private int GetAttributeValueFromSelectedIndex(int index)
        {
            int value = 0;
            
            switch (index)
            {
                case 0:
                    value = 8;
                    break;
                case 1:
                    value = 10;
                    break;
                case 2:
                    value = 12;
                    break;
                case 3:
                    value = 13;
                    break;
                case 4:
                    value = 14;
                    break;
                case 5:
                    value = 15;
                    break;
                default:
                    break;
            }

            return value;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EnableContinueBtn();
        }
    }
}
