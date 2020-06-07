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
            string currBackground = ((Button)sender).Tag.ToString();

            Creation.TextBox_Background.Text = currBackground;
            Character.Current.Background = Creation.TextBox_Background.Text;
            this.Creation.ButtonContinueEnabled(true);

            TextBlock_BackgroundInfoTitle.Visibility = Visibility.Visible;
            TextBlock_BackgroundSkillProfKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundToolProfKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundLangOptionsKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundEquipKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundEquipOptionsKey.Visibility = Visibility.Visible;
            TextBlock_BackgroundFeatureKey.Visibility = Visibility.Visible;

            switch (currBackground)
            {
                case "acolythe":
                    TextBlock_BackgroundInfoTitle.Text = "Acolythe";

                    Background acolythe = dndInformation.GetBackgroundInformation("acolythe");
                    addBackgroundInfoToTextBlock(acolythe);

                    break;
                case "criminal":
                    TextBlock_BackgroundInfoTitle.Text = "Criminal";

                    Background criminal = dndInformation.GetBackgroundInformation("criminal");
                    addBackgroundInfoToTextBlock(criminal);

                    break;
                case "charlatan":
                    TextBlock_BackgroundInfoTitle.Text = "Charlatan";

                    Background charlatan = dndInformation.GetBackgroundInformation("charlatan");
                    addBackgroundInfoToTextBlock(charlatan);

                    break;
                case "entertainer":
                    TextBlock_BackgroundInfoTitle.Text = "Entertainer";

                    Background entertainer = dndInformation.GetBackgroundInformation("entertainer");
                    addBackgroundInfoToTextBlock(entertainer);

                    break;
                case "folk-hero":
                    TextBlock_BackgroundInfoTitle.Text = "Folk Hero";

                    Background folkHero = dndInformation.GetBackgroundInformation("folk-hero");
                    addBackgroundInfoToTextBlock(folkHero);

                    break;
                case "guild-artisan":
                    TextBlock_BackgroundInfoTitle.Text = "Guild Artisan";
                    
                    Background guildArtisan = dndInformation.GetBackgroundInformation("guild-artisan");
                    addBackgroundInfoToTextBlock(guildArtisan);

                    break;
                case "hermit":
                    TextBlock_BackgroundInfoTitle.Text = "Hermit";

                    Background hermit = dndInformation.GetBackgroundInformation("hermit");
                    addBackgroundInfoToTextBlock(hermit);

                    break;
                case "noble":
                    TextBlock_BackgroundInfoTitle.Text = "Noble";

                    Background noble = dndInformation.GetBackgroundInformation("noble");
                    addBackgroundInfoToTextBlock(noble);

                    break;
                case "outlander":
                    TextBlock_BackgroundInfoTitle.Text = "Outlander";

                    Background outlander = dndInformation.GetBackgroundInformation("outlander");
                    addBackgroundInfoToTextBlock(outlander);

                    break;
                case "sage":
                    TextBlock_BackgroundInfoTitle.Text = "Sage";

                    Background sage = dndInformation.GetBackgroundInformation("sage");
                    addBackgroundInfoToTextBlock(sage);

                    break;
                case "sailor":
                    TextBlock_BackgroundInfoTitle.Text = "Sailor";

                    Background sailor = dndInformation.GetBackgroundInformation("sailor");
                    addBackgroundInfoToTextBlock(sailor);

                    break;
                case "soldier":
                    TextBlock_BackgroundInfoTitle.Text = "Soldier";

                    Background soldier = dndInformation.GetBackgroundInformation("soldier");
                    addBackgroundInfoToTextBlock(soldier);

                    break;
                case "urchin":
                    TextBlock_BackgroundInfoTitle.Text = "Urchin";

                    Background urchin = dndInformation.GetBackgroundInformation("urchin");
                    addBackgroundInfoToTextBlock(urchin);

                    break;
                default:
                    break;
            }

        }
        
        public void addBackgroundInfoToTextBlock(Background background)
        {
            string skillProfs = "";
            string toolProfs = "";
            string languageOptions = "";
            string equipments = "";
            string equipmentOptions = "";
            string features = "";

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

            foreach (string toolProf in background.SkillProficiences)
            {
                if (toolProf.Equals(background.SkillProficiences.Last()))
                {
                    toolProfs += toolProf;
                }
                else
                {
                    toolProfs += toolProf + ", ";
                }
            }

            foreach (string equipment in background.Equipment)
            {
                if (equipment.Equals(background.Equipment.Last()))
                {
                    equipments += equipment;
                }
                else
                {
                    equipments += equipment + ", ";
                }
            }

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

            TextBlock_BackgroundSkillProfValue.Text = skillProfs;
            TextBlock_BackgroundToolProfValue.Text = toolProfs;
            TextBlock_BackgroundLangOptionsValue.Text = languageOptions;
            TextBlock_BackgroundEquipValue.Text = equipments;
            TextBlock_BackgroundEquipOptionsValue.Text = equipmentOptions;
            TextBlock_BackgroundFeatureValue.Text = features;
        }
    }
}
