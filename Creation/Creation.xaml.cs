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
    /// Interaktionslogik für Creation.xaml
    /// </summary>
    public partial class Creation : Window
    {
        Page_ClassSelection ClassSelection;
        Page_RaceSelection RaceSelection;
        Page_BackgroundSelection BackgroundSelection;
        Page_AttributeSelection AttributeSelection;
        Page_SpellSelection SpellSelection;
        Page_InventorySelection InventorySelection;
        Page_Miscellaneous MiscellaneousSelection;
        Page_Overview OverviewSelection;

        public static Creation OpenWindow()
        {
            Creation creation = new Creation();
            creation.Show();
            return creation;
        }

        private Creation()
        {
            InitializeComponent();
            ClassSelection = new Page_ClassSelection();
            RaceSelection = new Page_RaceSelection(this);
            BackgroundSelection = new Page_BackgroundSelection();
            AttributeSelection = new Page_AttributeSelection();
            SpellSelection = new Page_SpellSelection();
            InventorySelection = new Page_InventorySelection();
            MiscellaneousSelection = new Page_Miscellaneous();
            OverviewSelection = new Page_Overview(this);
            this.Btn_Back.IsEnabled = false;
            Frame1.Content = RaceSelection;
        }

        private void Btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (Frame1.Content == RaceSelection)
            {
                Frame1.Content = ClassSelection;
            }
            else if (Frame1.Content == ClassSelection)
            {
                Frame1.Content = BackgroundSelection;
            }
            else if (Frame1.Content == BackgroundSelection)
            {
                Frame1.Content = AttributeSelection;
            }
            else if (Frame1.Content == AttributeSelection)
            {
                Frame1.Content = InventorySelection;
            }
            else if (Frame1.Content == InventorySelection)
            {
                Frame1.Content = SpellSelection;
            }
            else if (Frame1.Content == SpellSelection)
            {
                Frame1.Content = MiscellaneousSelection;
            }
            else if (Frame1.Content == MiscellaneousSelection)
            {
                //Characternamen übernehmen
                Character.Current.CharacterName = MiscellaneousSelection.CharacterName.Text;

                Frame1.Content = OverviewSelection;
            }
            else if(Frame1.Content == OverviewSelection)
            {

            }
            //EnableDisableButtons();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {

            if (Frame1.Content == RaceSelection)
            {

            }
            else if (Frame1.Content == ClassSelection)
            {
                Frame1.Content = RaceSelection;
            }
            else if (Frame1.Content == BackgroundSelection)
            {
                Frame1.Content = ClassSelection;
            }
            else if (Frame1.Content == AttributeSelection)
            {
                Frame1.Content = BackgroundSelection;
            }
            else if (Frame1.Content == InventorySelection)
            {
                Frame1.Content = AttributeSelection;

            }
            else if (Frame1.Content == SpellSelection)
            {
                Frame1.Content = InventorySelection;
            }
            else if (Frame1.Content == MiscellaneousSelection)
            {
                Frame1.Content = SpellSelection;
            }
            else if (Frame1.Content == OverviewSelection)
            {
                Frame1.Content = MiscellaneousSelection;
            }
            //EnableDisableButtons();
        }
        
        public void BackButtonEnabled(bool activated)
        {
            this.Btn_Back.IsEnabled = activated;
        }
        public void ContinueButtonEnabled(bool activated)
        {
            this.Btn_Continue.IsEnabled = activated;
        }
    }
}
