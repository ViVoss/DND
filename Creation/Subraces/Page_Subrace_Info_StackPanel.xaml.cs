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

            if (subrace.AbilityBonuses.Count > 0)
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

            TextBlock_Subrace_StartingProficienciesValue.Text = startingProficiencies;

            string languages = "";

            if (subrace.Languages.Count > 0)
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

            if (subrace.LanguageOptions != null)
            {
                if (subrace.LanguageOptions.From.Count > 0)
                {
                    foreach (From lang in subrace.LanguageOptions.From)
                    {
                        LanguageOption_ComboBox.Items.Add(lang.Name);
                    }
                }
                else
                {
                    LanguageOption_ComboBox.IsEnabled = false;
                }
            }
            else
            {
                LanguageOption_ComboBox.IsEnabled = false;
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

            TextBlock_Subrace_RacialTraitsValue.Text = racialTraits;

            if (subrace.RacialTraitOptions != null)
            {
                if (subrace.RacialTraitOptions.From.Count > 0) {
                    foreach (From racialTraitOptions in subrace.RacialTraitOptions.From)
                    {
                        RacialTraitOption_ComboBox.Items.Add(racialTraitOptions.Name);
                    }
                }
                else
                {
                    RacialTraitOption_ComboBox.IsEnabled = false;
                }
            }
            else
            {
                RacialTraitOption_ComboBox.IsEnabled = false;
            }

        }
    }
}
