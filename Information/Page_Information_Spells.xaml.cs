using MongoDB.Bson;
using System;
using System.Collections.Generic;
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
        public Page_Information_Spells()
        {
            InitializeComponent();

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

                SpellDataGrid.Items.Add(dataGridItem);
            }
        }
    }
}
