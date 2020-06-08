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
    /// Interaktionslogik für Page_Information_Races.xaml
    /// </summary>
    public partial class Page_Information_Races : Page
    {
        DnDInformation dndInformation = new DnDInformation();

        public Page_Information_Races()
        {
            InitializeComponent();
        }

        private void Button_Race_Click(object sender, RoutedEventArgs e)
        {
            string currRace = ((Button)sender).Tag.ToString();

            TextBlock_RaceInfoTitle.Visibility = Visibility.Visible;

            switch (currRace)
            {
                case "dwarf":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Visible;


                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Visible;
                    TextBlock_RaceInfoTitle.Text = "Dwarf";
                    TextBlock_SubRaceInfoTitle.Text = "Dwarf Subraces";

                    Rasse dwarf = dndInformation.GetRaceInformation("dwarf");
                    SubRace hillDwarf = dndInformation.GetSubRaceInformation("hill-dwarf");
                    SubRace mountainDwarf = dndInformation.GetSubRaceDbInformation("mountain-dwarf");

                    addRaceDataGridInformation(dwarf);
                    addSubRaceDataGridInformation(hillDwarf, 1);
                    addSubRaceDataGridInformation(mountainDwarf, 2);

                    break;
                case "elf":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Visible;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Visible;
                    TextBlock_RaceInfoTitle.Text = "Elf";
                    TextBlock_SubRaceInfoTitle.Text = "Elf Subraces";

                    Rasse elf = dndInformation.GetRaceInformation("elf");
                    SubRace highElf = dndInformation.GetSubRaceInformation("high-elf");
                    SubRace darkElf = dndInformation.GetSubRaceDbInformation("dark-elf");
                    SubRace woodElf = dndInformation.GetSubRaceDbInformation("wood-elf");

                    addRaceDataGridInformation(elf);
                    addSubRaceDataGridInformation(highElf, 1);
                    addSubRaceDataGridInformation(darkElf, 2);
                    addSubRaceDataGridInformation(woodElf, 3);

                    break;
                case "halfling":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Visible;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Visible;
                    TextBlock_RaceInfoTitle.Text = "Halfling";
                    TextBlock_SubRaceInfoTitle.Text = "Halfling Subraces";

                    Rasse halfling = dndInformation.GetRaceInformation("halfling");
                    SubRace lightfootHalfling = dndInformation.GetSubRaceInformation("lightfoot-halfling");
                    SubRace stoutHalfling = dndInformation.GetSubRaceDbInformation("stout-halfling");

                    addRaceDataGridInformation(halfling);
                    addSubRaceDataGridInformation(lightfootHalfling, 1);
                    addSubRaceDataGridInformation(stoutHalfling, 2);

                    break;
                case "human":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Hidden;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Hidden;
                    TextBlock_RaceInfoTitle.Text = "Human";

                    Rasse human = dndInformation.GetRaceInformation("human");
                    addRaceDataGridInformation(human);

                    break;
                case "dragonborn":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Hidden;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Hidden;
                    TextBlock_RaceInfoTitle.Text = "Dragonborn";

                    Rasse dragonborn = dndInformation.GetRaceInformation("dragonborn");

                    addRaceDataGridInformation(dragonborn);

                    break;
                case "gnome":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Visible;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Visible;
                    TextBlock_RaceInfoTitle.Text = "Gnome";
                    TextBlock_SubRaceInfoTitle.Text = "Gnome Subraces";

                    Rasse gnome = dndInformation.GetRaceInformation("gnome");
                    SubRace rockGnome = dndInformation.GetSubRaceInformation("rock-gnome");
                    SubRace forestGnome = dndInformation.GetSubRaceDbInformation("forest-gnome");

                    addRaceDataGridInformation(gnome);
                    addSubRaceDataGridInformation(rockGnome, 1);
                    addSubRaceDataGridInformation(forestGnome, 2);

                    break;
                case "half-orc":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Hidden;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Hidden;
                    TextBlock_RaceInfoTitle.Text = "Half-Orc";

                    Rasse halfOrc = dndInformation.GetRaceInformation("half-orc");

                    addRaceDataGridInformation(halfOrc);

                    break;
                case "half-elf":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Hidden;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Hidden;
                    TextBlock_RaceInfoTitle.Text = "Half-Ef";

                    Rasse halfElf = dndInformation.GetRaceInformation("half-elf");

                    addRaceDataGridInformation(halfElf);

                    break;
                case "tiefling":
                    RaceDataGrid.Items.Clear();
                    SubraceDataGrid.Items.Clear();
                    SubraceDataGrid.Visibility = Visibility.Hidden;

                    TextBlock_SubRaceInfoTitle.Visibility = Visibility.Hidden;
                    TextBlock_RaceInfoTitle.Text = "Tiefling";

                    Rasse tiefling = dndInformation.GetRaceInformation("tiefling");

                    addRaceDataGridInformation(tiefling);

                    break;
                default:
                    break;
            }
        }

        public void addRaceDataGridInformation(Rasse race)
        {
            string compAbilityBonuses = "";
            string traits = "";
            string languages = "";
            
            foreach (AbilityBonus abilityBonus in race.AbilityBonuses) {
                if (abilityBonus.Equals(race.AbilityBonuses.Last())) {
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

            DataGridItem dataRaceGridItem = new DataGridItem()
            {
                IdCol = 1,
                AbilityScoreIncreaseCol = compAbilityBonuses,
                AgeCol = race.Age,
                AlignmentCol = race.Alignment,
                SizeCol = race.Size,
                SizeDescCol = race.SizeDescription,
                TraitsCol = traits,
                SpeedCol = race.Speed,
                LanguagesCol = languages,
                LanguageDescCol = race.LanguageDesc
            };

            RaceDataGrid.Items.Add(dataRaceGridItem);
        }

        public void addSubRaceDataGridInformation(SubRace subrace, int id)
        {
            string compAbilityBonus = "";

            if (subrace.AbilityBonuses.Count > 0)
            {
                foreach (AbilityBonus abilityBonus in subrace.AbilityBonuses)
                {
                    if (abilityBonus.Equals(subrace.AbilityBonuses.Last()))
                    {
                        compAbilityBonus += abilityBonus.Name;
                    }
                    else
                    {
                        compAbilityBonus += abilityBonus.Name + ", ";
                    }
                }
            }
            else
            {
                compAbilityBonus = "-";
            }

            string startingProficiencies = "";

            if (subrace.StartingProficiencies.Count > 0)
            {
                foreach (StartingProficiency startingProficiency in subrace.StartingProficiencies)
                {
                    if (startingProficiency.Equals(subrace.StartingProficiencies.Last()))
                    {
                        startingProficiencies += startingProficiency.Name;
                    }
                    else
                    {
                        startingProficiencies += startingProficiency.Name + ", ";
                    }
                }
            }
            else
            {
                startingProficiencies = "-";
            }

            string languages = "";

            if (subrace.Languages.Count > 0)
            {
                foreach (Language language in subrace.Languages)
                {
                    if (language.Equals(subrace.Languages.Last()))
                    {
                        languages += language.Name;
                    }
                    else
                    {
                        languages += language.Name + ", ";
                    }
                }
            }
            else
            {
                languages = "-";
            }

            string languageOptions = "";

            if (subrace.LanguageOptions != null)
            {
                if (subrace.LanguageOptions.From.Count > 0)
                {
                    foreach (From languageOpt in subrace.LanguageOptions.From)
                    {
                        if (languageOpt.Equals(subrace.LanguageOptions.From.Last()))
                        {
                            languageOptions += languageOpt.Name;
                        }
                        else
                        {
                            languageOptions += languageOpt.Name + ", ";
                        }
                    }
                }
                else
                {
                    languageOptions = "-";
                }
            }
            else
            {
                languageOptions = "-";
            }

            string racialTraits = "";

            if (subrace.RacialTraits.Count > 0)
            {
                foreach (Rac racialTrait in subrace.RacialTraits)
                {
                    if (racialTrait.Equals(subrace.RacialTraits.Last()))
                    {
                        racialTraits += racialTrait.Name;
                    }
                    else
                    {
                        racialTraits += racialTrait.Name + ", ";
                    }
                }
            }
            else
            {
                racialTraits = "-";
            }

            string racialTraitOptions = "";

            if (subrace.RacialTraitOptions != null)
            {
                if (subrace.RacialTraitOptions.From.Count > 0)
                {
                    foreach (From racialTraitOpt in subrace.RacialTraitOptions.From)
                    {
                        if (racialTraitOpt.Equals(subrace.RacialTraitOptions.From.Last()))
                        {
                            racialTraitOptions += racialTraitOpt.Name;
                        }
                        else
                        {
                            racialTraitOptions += racialTraitOpt.Name + ", ";
                        }
                    }
                }
                else
                {
                    racialTraitOptions = "-";
                }
            }
            else
            {
                racialTraitOptions = "-";
            }

            DataGridItem dataSubRaceGridItem = new DataGridItem()
            {
                IdCol = id,
                NameCol = subrace.Name,
                DescCol = subrace.Desc,
                AbilityScoreIncreaseCol = compAbilityBonus,
                StartingProficiencesCol = startingProficiencies,
                LanguagesCol = languages,
                LanguageOptionsCol = languageOptions,
                RacialTraitsCol = racialTraits,
                RacialTraitOptionsCol = racialTraitOptions
            };

            SubraceDataGrid.Items.Add(dataSubRaceGridItem);
        }
    }
}
