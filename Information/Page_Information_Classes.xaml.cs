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
    /// Interaktionslogik für Page_Information_Classes.xaml
    /// </summary>
    public partial class Page_Information_Classes : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Page_Information_Classes()
        {
            InitializeComponent();
        }

        private void Button_Class_Click(object sender, RoutedEventArgs e)
        {
            string currRace = ((Button)sender).Tag.ToString();

            //TextBlock_RaceInfoTitle.Visibility = Visibility.Visible;

            switch (currRace)
            {
                case "barbarian":
                    ClassDataGrid.Items.Clear();
                    //SubraceDataGrid.Items.Clear();
                    //SubraceDataGrid.Visibility = Visibility.Visible;


                    //TextBlock_SubRaceInfoTitle.Visibility = Visibility.Visible;
                    TextBlock_ClassInfoTitle.Text = "Barbarian";
                    //TextBlock_SubRaceInfoTitle.Text = "Dwarf Subraces";

                    ClassLevels barbarian = dndInformation.GetClassLevelsDataGridInformation("barbarian");
                    //SubRace hillDwarf = dndInformation.GetSubRaceDataGridInformation("hill-dwarf");
                    //SubRace mountainDwarf = dndInformation.GetSubRaceDbDataGridInformation("mountain-dwarf");

                    addClassDataGridInformation(barbarian,1);
                    //addSubRaceDataGridInformation(hillDwarf, 1);
                    //addSubRaceDataGridInformation(mountainDwarf, 2);

                    break;
            }
        }
        public void addClassDataGridInformation(ClassLevels classlvls, int lvl)
        {
            /*string compAbilityBonuses = "";
            string traits = "";
            string languages = "";
            */
            /*
            foreach (AbilityBonus abilityBonus in race.AbilityBonuses)
            {
                if (abilityBonus.Equals(race.AbilityBonuses.Last()))
                {
                    compAbilityBonuses += abilityBonus.Name + " +" + abilityBonus.Bonus;
                }
                else
                {
                    compAbilityBonuses += abilityBonus.Name + " +" + abilityBonus.Bonus + ", ";
                }
            }

            foreach (Trait trait in race.Traits)
            {
                if (trait.Equals(race.Traits.Last()))
                {
                    traits += trait.Name;
                }
                else
                {
                    traits += trait.Name + ", ";
                }
            }

            foreach (Language language in race.Languages)
            {
                if (language.Equals(race.Languages.Last()))
                {
                    languages += language.Name;
                }
                else
                {
                    languages += language.Name + ", ";
                }
            }
            */
            DataGridItem dataClassGridItem = new DataGridItem()
            {
                LevelCol = lvl,
                ProficiencyBonusCol = classlvls.Class,
                /*AgeCol = race.Age,
                AlignmentCol = race.Alignment,
                SizeCol = race.Size,
                SizeDescCol = race.SizeDescription,
                TraitsCol = traits,
                SpeedCol = race.Speed,
                LanguagesCol = languages,
                LanguageDescCol = race.LanguageDesc*/
            };

            ClassDataGrid.Items.Add(dataClassGridItem);
        }
    }
}
