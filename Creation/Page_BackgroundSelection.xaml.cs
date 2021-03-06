﻿using System;
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
    /// Interaktionslogik für Page_BackgroundSelection.xaml
    /// </summary>
    public partial class Page_BackgroundSelection : Page
    {
        DnDInformation dndInformation = new DnDInformation();

        public Creation Creation { get; set; }

        public Page_BackgroundSelection(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();
        }

        private void Button_Background_Click(object sender, RoutedEventArgs e)
        {
            this.ComboBox_BackgroundLanguageOptions.SelectedValue = Character.Current.BackgroundLanguage;
            this.ComboBox_BackgroundEquipmentOptions.SelectedValue = Character.Current.BackgroundEquipment;

            string currBackground = ((Button)sender).Tag.ToString();

            Label_BackgroundInfoTitle.Visibility = Visibility.Visible;
            TextBlock_BackgroundSkillProfKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundToolProfKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundLangOptionsKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundEquipKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundEquipOptionsKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundFeatureKey.Visibility = Visibility.Visible;
            ComboBox_BackgroundLanguageOptions.Visibility = Visibility.Visible;
            ComboBox_BackgroundEquipmentOptions.Visibility = Visibility.Visible;

            switch (currBackground)
            {
                case "acolythe":
                    Label_BackgroundInfoTitle.Content = "Acolythe";

                    Background acolythe = dndInformation.GetBackgroundInformation("acolythe");
                    addBackgroundInfoToTextBlock(acolythe);

                    break;
                case "criminal":
                    Label_BackgroundInfoTitle.Content = "Criminal";

                    Background criminal = dndInformation.GetBackgroundInformation("criminal");
                    addBackgroundInfoToTextBlock(criminal);

                    break;
                case "charlatan":
                    Label_BackgroundInfoTitle.Content = "Charlatan";

                    Background charlatan = dndInformation.GetBackgroundInformation("charlatan");
                    addBackgroundInfoToTextBlock(charlatan);

                    break;
                case "entertainer":
                    Label_BackgroundInfoTitle.Content = "Entertainer";

                    Background entertainer = dndInformation.GetBackgroundInformation("entertainer");
                    addBackgroundInfoToTextBlock(entertainer);

                    break;
                case "folk-hero":
                    Label_BackgroundInfoTitle.Content = "Folk Hero";

                    Background folkHero = dndInformation.GetBackgroundInformation("folk-hero");
                    addBackgroundInfoToTextBlock(folkHero);

                    break;
                case "guild-artisan":
                    Label_BackgroundInfoTitle.Content = "Guild Artisan";

                    Background guildArtisan = dndInformation.GetBackgroundInformation("guild-artisan");
                    addBackgroundInfoToTextBlock(guildArtisan);

                    break;
                case "hermit":
                    Label_BackgroundInfoTitle.Content = "Hermit";

                    Background hermit = dndInformation.GetBackgroundInformation("hermit");
                    addBackgroundInfoToTextBlock(hermit);

                    break;
                case "noble":
                    Label_BackgroundInfoTitle.Content = "Noble";

                    Background noble = dndInformation.GetBackgroundInformation("noble");
                    addBackgroundInfoToTextBlock(noble);

                    break;
                case "outlander":
                    Label_BackgroundInfoTitle.Content = "Outlander";

                    Background outlander = dndInformation.GetBackgroundInformation("outlander");
                    addBackgroundInfoToTextBlock(outlander);

                    break;
                case "sage":
                    Label_BackgroundInfoTitle.Content = "Sage";

                    Background sage = dndInformation.GetBackgroundInformation("sage");
                    addBackgroundInfoToTextBlock(sage);

                    break;
                case "sailor":
                    Label_BackgroundInfoTitle.Content = "Sailor";

                    Background sailor = dndInformation.GetBackgroundInformation("sailor");
                    addBackgroundInfoToTextBlock(sailor);

                    break;
                case "soldier":
                    Label_BackgroundInfoTitle.Content = "Soldier";

                    Background soldier = dndInformation.GetBackgroundInformation("soldier");
                    addBackgroundInfoToTextBlock(soldier);

                    break;
                case "urchin":
                    Label_BackgroundInfoTitle.Content = "Urchin";

                    Background urchin = dndInformation.GetBackgroundInformation("urchin");
                    addBackgroundInfoToTextBlock(urchin);

                    break;
                default:
                    break;
            }

            Creation.TextBox_Background.Text = currBackground;
            Character.Current.Background = Creation.TextBox_Background.Text;
            this.Creation.ButtonContinueEnabled(true);                  
        }
        
        private void addBackgroundInfoToTextBlock(Background background)
        {
            string skillProfs = "";

            if (background.SkillProficiences.Count > 0) {
                foreach (string skillProf in background.SkillProficiences)
                {
                    if (skillProf.Equals(background.SkillProficiences.Last()))
                    {
                        skillProfs += skillProf;
                    }
                    else
                    {
                        skillProfs += skillProf + ", ";
                    }
                }
            }
            else
            {
                skillProfs = "-";
            }

            TextBlock_BackgroundSkillProfValue.Text = skillProfs;

            string toolProfs = "";

            if (background.ToolProficiences.Count > 0)
            {
                foreach (string toolProf in background.ToolProficiences)
                {
                    if (toolProf.Equals(background.ToolProficiences.Last()))
                    {
                        toolProfs += toolProf;
                    }
                    else
                    {
                        toolProfs += toolProf + ", ";
                    }
                }
            }
            else
            {
                toolProfs = "-";
            }

            TextBlock_BackgroundToolProfValue.Text = toolProfs;

            ComboBox_BackgroundLanguageOptions.IsEnabled = true;
            ComboBox_BackgroundLanguageOptions.Items.Clear();

            if (background.LanguageOptions.From.Count > 0)
            {
                foreach (string language in background.LanguageOptions.From)
                {
                    ComboBox_BackgroundLanguageOptions.Items.Add(language);
                }
            }
            else
            {
                ComboBox_BackgroundLanguageOptions.IsEnabled = false;
            }

            string equipments = "";

            if (background.Equipment.Count > 0)
            {
                foreach (string equipment in background.Equipment)
                {
                    if (equipment.Equals(background.Equipment.Last()))
                    {
                        equipments += equipment;
                    }
                    else
                    {
                        equipments += equipment + "\n";
                    }
                }
            }
            else
            {
                equipments = "-";
            }

            TextBlock_BackgroundEquipValue.Text = equipments;

            ComboBox_BackgroundEquipmentOptions.IsEnabled = true;
            ComboBox_BackgroundEquipmentOptions.Items.Clear();

            if (background.EquipmentOptions.From.Count > 0)
            {
                foreach (string equipmentOption in background.EquipmentOptions.From)
                {
                    ComboBox_BackgroundEquipmentOptions.Items.Add(equipmentOption);
                }
            }
            else
            {
                ComboBox_BackgroundEquipmentOptions.IsEnabled = false;
            }

            string features = "";

            if (background.Feature.Count > 0)
            {
                foreach (string feature in background.Feature)
                {
                    if (feature.Equals(background.Feature.Last()))
                    {
                        features += feature;
                    }
                    else
                    {
                        features += feature + ", ";
                    }
                }
            }
            else
            {
                features = "-";
            }
            
            TextBlock_BackgroundFeatureValue.Text = features;
        }

        private void ComboBox_BackgroundLanguageOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.BackgroundLanguage = ((ComboBox)sender).SelectedValue.ToString();
            
        }

        private void ComboBox_BackgroundEquipmentOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Current.BackgroundEquipment = ((ComboBox)sender).SelectedValue.ToString();
        }
    }
}
