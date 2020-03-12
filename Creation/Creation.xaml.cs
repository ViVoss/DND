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
        Page_ClassSelection ClassSelection = new Page_ClassSelection();
        Page_RaceSelection RaceSelection = new Page_RaceSelection();
        Page_BackgroundSelection BackgroundSelection = new Page_BackgroundSelection();
        Page_AttributeSelection AttributeSelection = new Page_AttributeSelection();
        Page_SpellSelection SpellSelection = new Page_SpellSelection();
        Page_InventorySelection InventorySelection = new Page_InventorySelection();
        Page_Miscellaneous MiscellaneousSelection = new Page_Miscellaneous();
        bool RaceOpen, ClassOpen, BackgroundOpen, AttributeOpen, SpellOpen, InventoryOpen, MiscellaneousOpen;

        public Creation()
        {
            ClassSelectionPage1 = new Page_ClassSelection();
            RaceSelectionPage1 = new Page_RaceSelection(this);
            BackgroundSelectionPage1 = new Page_BackgroundSelection();

            InitializeComponent();
            Frame1.Content = RaceSelection;
            RaceOpen = true;
        }

        private void Btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (RaceOpen)
            {
                Frame1.Content = ClassSelection;
                ClassOpen = true;
                RaceOpen = false;
            }
            else if (ClassOpen)
            {
                Frame1.Content = BackgroundSelection;
                BackgroundOpen = true;
                ClassOpen = false;
            }
            else if (BackgroundOpen)
            {
                Frame1.Content = AttributeSelection;
                AttributeOpen = true;
                BackgroundOpen = false;
            }
            else if (AttributeOpen)
            {
                Frame1.Content = InventorySelection;
                InventoryOpen = true;
                AttributeOpen = false;
            }
            else if (InventoryOpen)
            {
                Frame1.Content = SpellSelection;
                SpellOpen = true;
                InventoryOpen = false;
            }
            else if (SpellOpen)
            {
                Frame1.Content = MiscellaneousSelection;
                MiscellaneousOpen = true;
                SpellOpen = false;
            }
            else if (MiscellaneousOpen)
            {

            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            if (RaceOpen)
            {

            }
            else if (ClassOpen)
            {
                Frame1.Content = RaceSelection;
                RaceOpen = true;
                ClassOpen = false;
            }
            else if (BackgroundOpen)
            {
                Frame1.Content = ClassSelection;
                ClassOpen = true;
                BackgroundOpen = false;
            }
            else if (AttributeOpen)
            {
                Frame1.Content = BackgroundSelection;
                BackgroundOpen = true;
                AttributeOpen = false;
            }
            else if (InventoryOpen)
            {
                Frame1.Content = AttributeSelection;
                AttributeOpen = true;
                InventoryOpen = false;
            }
            else if (SpellOpen)
            {
                Frame1.Content = InventorySelection;
                InventoryOpen = true;
                SpellOpen = false;
            }
            else if (MiscellaneousOpen)
            {
                Frame1.Content = SpellSelection;
                SpellOpen = true;
                MiscellaneousOpen = false;
            }
        }
    }
}
