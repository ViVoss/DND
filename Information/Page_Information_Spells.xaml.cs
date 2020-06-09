using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
        
        private int id = 1;
        private string spellClasses = "-";
        private string spellSubclasses = "-";
        private ICollectionView spellDataGridCollection;
        public Page_Information_Spells()
        {
            InitializeComponent();
            List<DataGridItem> spellDataGridItems = new List<DataGridItem>();

            foreach(Spells spell in dndInformation.GetSpellsInformation())
            {
                foreach (Klasse clazz in spell.Classes)
                {
                    spellClasses = String.Join(", ", clazz.Name);
                }

                foreach (Proficiency subclass in spell.Subclasses)
                {
                    spellSubclasses = String.Join(", ", subclass.Name);
                }

                DataGridItem dataGridItem = new DataGridItem() {
                    IdCol = id++,
                    NameCol = spell.Name,
                    DescCol = String.Join(", ", spell.Desc),
                    HigherLvlCol = String.Join(", ", spell.HigherLevel),
                    RangeCol = spell.Range,
                    ComponentsCol = String.Join(", ", spell.Components),
                    MaterialCol = spell.Material,
                    RitualCol = spell.Ritual,
                    DurationCol = spell.Duration,
                    ConcentrationCol = spell.Concentration,
                    CastingTimeCol = spell.CastingTime,
                    LevelCol = spell.Level,
                    SchoolCol = spell.School.Name,
                    ClassesCol = spellClasses,
                    SubclassesCol = spellSubclasses,
                };

                spellDataGridItems.Add(dataGridItem);
            }

            Spell_Info_DataGrid.ItemsSource = spellDataGridItems;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(Spell_Info_DataGrid.ItemsSource);
            view.Filter = SpellDataGridFilter;
        }

        private bool SpellDataGridFilter(object item)
        {
            if (String.IsNullOrEmpty(TextBox_Spells_Info_Filter.Text))
            {
                return true;
            }
            else
            {
                if (
                    (item as DataGridItem).IdCol.ToString().IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).NameCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).DescCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).HigherLvlCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).RangeCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).ComponentsCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).MaterialCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).DurationCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).CastingTimeCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).LevelCol.ToString().IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).SchoolCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).ClassesCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DataGridItem).SubclassesCol.IndexOf(TextBox_Spells_Info_Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0
                )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
                
        }

        private void TextBoxSpellsInfoFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(Spell_Info_DataGrid.ItemsSource).Refresh();
        }
    }
}
