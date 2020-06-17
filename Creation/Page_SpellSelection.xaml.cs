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
    /// Interaktionslogik für Page_SpellSelection.xaml
    /// </summary>
    public partial class Page_SpellSelection : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        List<Spells> spellList = new List<Spells>();

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
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("bard", 1);
                    foreach (Spells spell in spellList)
                    {
                        TextBox textBox = new TextBox();
                        textBox.TextWrapping = TextWrapping.Wrap;
                        textBox.Text = spell.Name;
                        SpellSelection_StackPanel.Children.Add(textBox);
                    }

                    break;
                case "cleric":
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("cleric", 1);

                    break;
                case "druid":
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("druid", 1);

                    break;
                case "paladin":
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("paladin", 1);

                    break;
                case "ranger":
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("ranger", 1);

                    break;
                case "sorcerer":
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("sorcerer", 1);

                    break;
                case "warlock":
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("warlock", 1);

                    break;
                case "wizard":
                    spellList = dndInformation.GetSpellsInformationPerClassAndLevel("wizard", 1);

                    break;
                default:
                    break;
            }
        }
    }
}
