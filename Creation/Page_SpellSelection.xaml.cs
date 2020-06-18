using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Primitives;

namespace DND
{
    /// <summary>
    /// Interaktionslogik für Page_SpellSelection.xaml
    /// </summary>
    public partial class Page_SpellSelection : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        List<Spells> spellList = new List<Spells>();
        List<string> list = new List<string>();
        int choicesToMake = 1;


        public Creation Creation { get; set; }

        public Page_SpellSelection(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            switch (Character.Current.Class)
            {
                case "bard":
                    Label_SpellSelectionClassTitle.Content = "Bard";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("bard", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                case "cleric":
                    Label_SpellSelectionClassTitle.Content = "Cleric";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("cleric", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                case "druid":
                    Label_SpellSelectionClassTitle.Content = "Druid";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("druid", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                case "paladin":
                    Label_SpellSelectionClassTitle.Content = "Paladin";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("paladin", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                case "ranger":
                    Label_SpellSelectionClassTitle.Content = "Ranger";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("ranger", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                case "sorcerer":
                    Label_SpellSelectionClassTitle.Content = "Sorcerer";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("sorcerer", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                case "warlock":
                    Label_SpellSelectionClassTitle.Content = "Warlock";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("warlock", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                case "wizard":
                    Label_SpellSelectionClassTitle.Content = "Wizard";
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("wizard", 1);
                    choicesToMake = 3;
                    AddSpellsInformationPerClassAndLevel(spellList, choicesToMake);
                    EnableContinueBtn();

                    break;
                default:
                    break;
            }
        }

        private void AddSpellsInformationPerClassAndLevel(List<Spells> spellList, int choicesToMake)
        {
            SpellSelection_CheckListBox.Items.Clear();

            SpellSelectionChoiceToMake_TextBlock.Text = "Please select " + choicesToMake + " spells:";

            foreach (Spells spell in spellList) {
                SpellSelection_CheckListBox.Items.Add(spell.Name);
            }

            //select spells
            foreach (string spell in Character.Current.Spells)
            {
                SpellSelection_CheckListBox.SelectedItems.Add(spell);
            }
        }

        private void EnableContinueBtn()
        {
            if (Character.Current.SpellList.Spells.Count > choicesToMake - 2)
            {
                this.Creation.Btn_Continue.IsEnabled = true;
            }
            else
            {
                this.Creation.Btn_Continue.IsEnabled = false;
            }
        }

        private void SpellSelection_CheckListBox_ItemSelectionChanged(object sender, ItemSelectionChangedEventArgs e)
        {

            if (SpellSelection_CheckListBox.SelectedItem != null)
            {
                Character.Current.SpellList.Spells.Add(new Spell(SpellSelection_CheckListBox.SelectedItem.ToString(), 1, true));
            }

            EnableContinueBtn();

            if (Character.Current.SpellList.Spells.Count > choicesToMake)
            {
                Character.Current.SpellList.Spells.RemoveAt(choicesToMake - 1);
            }

            if (SpellSelection_CheckListBox.SelectedItems.Count > choicesToMake)
            {
                SpellSelection_CheckListBox.SelectedItems.RemoveAt(choicesToMake - 1);
            }

            List<String> spells = new List<String>();
            foreach (var item in SpellSelection_CheckListBox.SelectedItems)
            {
                spells.Add(item.ToString());
            }

            Character.Current.Spells = spells;
        }
    }
}
