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
    /// Interaktionslogik für Page_Subrace_Info_StackPanel.xaml
    /// </summary>
    public partial class Page_Subrace_Info_StackPanel : Page
    {
        public Page_Subrace_Info_StackPanel(SubRace subrace)
        {
            InitializeComponent();

            Label_Subrace.Content = subrace.Name;

            string abilityBonusInc = "";

            if (subrace.AbilityBonuses.Count() > 0)
            {
                foreach (AbilityBonus abilityBonus in subrace.AbilityBonuses)
                {
                    if (abilityBonus.Equals(subrace.AbilityBonuses.Last()))
                    {
                        abilityBonusInc += abilityBonus.Name + " + " + abilityBonus.Bonus;
                    }
                    else
                    {
                        abilityBonusInc += abilityBonus.Name + ", ";
                    }
                }
            }
            else
            {
                abilityBonusInc = "-";
            }

            TextBlock_Subrace_AbilityScoreIncValue.Text = abilityBonusInc;

            string startingProficiencies = "";

            if (subrace.StartingProficiencies.Count() > 0)
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

            TextBlock_Subrace_StartingProficienciesValue.Text = startingProficiencies;

            string languages = "";

            if (subrace.Languages.Count() > 0)
            {
                foreach (Language lang in subrace.Languages)
                {
                    if (lang.Equals(subrace.Languages.Last()))
                    {
                        languages += lang.Name;
                    }
                    else
                    {
                        languages += lang.Name + ", ";
                    }
                }
            }
            else
            {
                languages = "-";
            }

            TextBlock_Subrace_LanguagesValue.Text = languages;

            string languageOptions = "";

            //if (subrace.LanguageOptions != null)
            //{
            //    foreach (From lang in subrace.LanguageOptions?.From)
            //    {
            //        if (lang.Equals(subrace.LanguageOptions.From.Last()))
            //        {
            //            builder.Append(lang.Name);
            //        }
            //        else
            //        {
            //            builder.Append(lang.Name + ", ");
            //        }
            //    }
            //}

            TextBlock_Subrace_LanguageOptionsValue.Text = languageOptions;

            string racialTraits = "";

            if (subrace.RacialTraits.Count() > 0)
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

            TextBlock_Subrace_RacialTraitsValue.Text = racialTraits;

            string racialTraitOptions = "";

            //if (subrace.GetType().GetProperty("RacialTraitOptions") != null)
            //{
            //    builder.Append("\n\nRacial Trait Options: Choose " + subrace.RacialTraitOptions?.Choose + "from: ");
            //    foreach (From racialTraitOptions in subrace.RacialTraitOptions?.From)
            //    {
            //        if (racialTraitOptions.Equals(subrace.RacialTraitOptions.From.Last()))
            //        {
            //            builder.Append(racialTraitOptions.Name);
            //        }
            //        else
            //        {
            //            builder.Append(racialTraitOptions.Name + ", ");
            //        }
            //    }
            //}

            TextBlock_Subrace_RacialTraitOptionsValue.Text = racialTraitOptions;
        }
    }
}
