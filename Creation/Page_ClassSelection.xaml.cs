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
    /// Interaktionslogik für ClassesSelection.xaml
    /// </summary>
    public partial class Page_ClassSelection : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Creation Creation { get; set; }

        public Page_ClassSelection(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();
        }

        private void Button_Class_Click(object sender, RoutedEventArgs e)
        {

            Creation.TextBox_Class.Text = ((Button)sender).Tag.ToString();
            Character.Current.Class = Creation.TextBox_Class.Text;
            this.Creation.ButtonContinueEnabled(true);

            Label_ClassInfoTitle.Visibility = Visibility.Visible;
            TextBlock_ClassHitPointsKey.Visibility = Visibility.Visible;
            TextBlock_ClassHitDiceKey.Visibility = Visibility.Visible;
            TextBlock_ClassHitPoints1LvlKey.Visibility = Visibility.Visible;
            TextBlock_ClassHitPointsHigherLevelKey.Visibility = Visibility.Visible;
            TextBlock_ClassProficienciesKey.Visibility = Visibility.Visible;
            TextBlock_ClassSavingThrowsKey.Visibility = Visibility.Visible;
            TextBlock_ClassSkillsKey.Visibility = Visibility.Visible;
            TextBlock_ClassStartingEquipmentKey.Visibility = Visibility.Visible;

            TextBlock_ClassHitPointsValue.Visibility = Visibility.Visible;
            TextBlock_ClassHitDiceValue.Visibility = Visibility.Visible;
            TextBlock_ClassHitPoints1LvlValue.Visibility = Visibility.Visible;
            TextBlock_ClassHitPointsHigherLevelValue.Visibility = Visibility.Visible;
            TextBlock_ClassProficienciesValue.Visibility = Visibility.Visible;
            TextBlock_ClassSavingThrowsValue.Visibility = Visibility.Visible;
            TextBlock_ClassStartingEquipmentValue.Visibility = Visibility.Visible;
            TextBlock_ChoicesToMake.Visibility = Visibility.Visible;

            string currClass = ((Button)sender).Tag.ToString();

            switch (currClass)
            {
                case "barbarian":
                    Label_ClassInfoTitle.Content = "Barbarian";
                    Klasse barbarian = dndInformation.GetClassInformation("barbarian");
                    StartingEquipment barbarianStartingEquip = dndInformation.GetStartingEquipmentInformation("barbarian");
                    addClassInfoToTextBlock(barbarian);
                    addStartingEquipInfoToTextBlock(barbarianStartingEquip);

                    break;
                case "bard":
                    Label_ClassInfoTitle.Content = "Bard";
                    Klasse bard = dndInformation.GetClassInformation("bard");
                    StartingEquipment bardStartingEquip = dndInformation.GetStartingEquipmentInformation("bard");
                    addClassInfoToTextBlock(bard);
                    addStartingEquipInfoToTextBlock(bardStartingEquip);

                    break;
                case "cleric":
                    Label_ClassInfoTitle.Content = "Cleric";
                    Klasse cleric = dndInformation.GetClassInformation("cleric");
                    StartingEquipment clericStartingEquip = dndInformation.GetStartingEquipmentInformation("cleric");
                    addClassInfoToTextBlock(cleric);
                    addStartingEquipInfoToTextBlock(clericStartingEquip);

                    break;
                case "druid":
                    Label_ClassInfoTitle.Content = "Druid";
                    Klasse druid = dndInformation.GetClassInformation("druid");
                    StartingEquipment druidStartingEquip = dndInformation.GetStartingEquipmentInformation("druid");
                    addClassInfoToTextBlock(druid);
                    addStartingEquipInfoToTextBlock(druidStartingEquip);

                    break;
                case "fighter":
                    Label_ClassInfoTitle.Content = "Fighter";
                    Klasse fighter = dndInformation.GetClassInformation("fighter");
                    StartingEquipment fighterStartingEquip = dndInformation.GetStartingEquipmentInformation("fighter");
                    addClassInfoToTextBlock(fighter);
                    addStartingEquipInfoToTextBlock(fighterStartingEquip);

                    break;
                case "monk":
                    Label_ClassInfoTitle.Content = "Monk";
                    Klasse monk = dndInformation.GetClassInformation("monk");
                    StartingEquipment monkStartingEquip = dndInformation.GetStartingEquipmentInformation("monk");
                    addClassInfoToTextBlock(monk);
                    addStartingEquipInfoToTextBlock(monkStartingEquip);

                    break;
                case "paladin":
                    Label_ClassInfoTitle.Content = "Paladin";
                    Klasse paladin = dndInformation.GetClassInformation("paladin");
                    StartingEquipment paladinStartingEquip = dndInformation.GetStartingEquipmentInformation("paladin");
                    addClassInfoToTextBlock(paladin);
                    addStartingEquipInfoToTextBlock(paladinStartingEquip);

                    break;
                case "ranger":
                    Label_ClassInfoTitle.Content = "Ranger";
                    Klasse ranger = dndInformation.GetClassInformation("ranger");
                    StartingEquipment rangerStartingEquip = dndInformation.GetStartingEquipmentInformation("ranger");
                    addClassInfoToTextBlock(ranger);
                    addStartingEquipInfoToTextBlock(rangerStartingEquip);

                    break;
                case "rogue":
                    Label_ClassInfoTitle.Content = "Rogue";
                    Klasse rogue = dndInformation.GetClassInformation("rogue");
                    StartingEquipment rogueStartingEquip = dndInformation.GetStartingEquipmentInformation("rogue");
                    addClassInfoToTextBlock(rogue);
                    addStartingEquipInfoToTextBlock(rogueStartingEquip);

                    break;
                case "sorcerer":
                    Label_ClassInfoTitle.Content = "Sorcerer";
                    Klasse sorcerer = dndInformation.GetClassInformation("sorcerer");
                    StartingEquipment sorcererStartingEquip = dndInformation.GetStartingEquipmentInformation("sorcerer");
                    addClassInfoToTextBlock(sorcerer);
                    addStartingEquipInfoToTextBlock(sorcererStartingEquip);

                    break;
                case "warlock":
                    Label_ClassInfoTitle.Content = "Warlock";
                    Klasse warlock = dndInformation.GetClassInformation("warlock");
                    StartingEquipment warlockStartingEquip = dndInformation.GetStartingEquipmentInformation("warlock");
                    addClassInfoToTextBlock(warlock);
                    addStartingEquipInfoToTextBlock(warlockStartingEquip);

                    break;
                case "wizard":
                    Label_ClassInfoTitle.Content = "Wizard";
                    Klasse wizard = dndInformation.GetClassInformation("wizard");
                    StartingEquipment wizardStartingEquip = dndInformation.GetStartingEquipmentInformation("wizard");
                    addClassInfoToTextBlock(wizard);
                    addStartingEquipInfoToTextBlock(wizardStartingEquip);

                    break;
                default:
                    break;
            }
        }

        private void addClassInfoToTextBlock(Klasse clazz)
        {
            TextBlock_ClassHitPointsValue.Text = "";
            TextBlock_ClassHitDiceValue.Text = "1d" + clazz.HitDie + " per " + clazz.Name + " level";
            TextBlock_ClassHitPoints1LvlValue.Text = clazz.HitDie + " your constitution modifier";
            TextBlock_ClassHitPointsHigherLevelValue.Text = "1d" + clazz.HitDie + " (or " + ((clazz.HitDie / 2) + 1) + ") + your constitution modifier per " + clazz.Name + " level after 1st";

            string proficiencies = "";

            foreach (Proficiency prof in clazz.Proficiencies)
            {
                if (prof.Equals(clazz.Proficiencies.Last()))
                {
                    proficiencies += prof.Name;
                }
                else
                {
                    proficiencies += prof.Name + ", ";
                }
            }

            TextBlock_ClassProficienciesValue.Text = proficiencies;

            string savingThrows = "";

            foreach (Proficiency savingThrow in clazz.SavingThrows)
            {
                if (savingThrow.Equals(clazz.SavingThrows.Last()))
                {
                    savingThrows += savingThrow.Name;
                }
                else
                {
                    savingThrows += savingThrow.Name + ", ";
                }
            }

            TextBlock_ClassSavingThrowsValue.Text = savingThrows;

            ClassSkillsStackPanel.Children.RemoveRange(1, ClassSkillsStackPanel.Children.Count - 1);

            foreach (ProficiencyChoice skills in clazz.ProficiencyChoices)
            {
                TextBlock SkillsToChooseFrom_TextBlock = new TextBlock();
                SkillsToChooseFrom_TextBlock.FontSize = 10;
                SkillsToChooseFrom_TextBlock.TextWrapping = TextWrapping.Wrap;
                SkillsToChooseFrom_TextBlock.Text = "Choose " + skills.Choose + " from: ";

                ClassSkillsStackPanel.Children.Add(SkillsToChooseFrom_TextBlock);

                for (int i = 0; i < skills.Choose; i++)
                {
                    ComboBox SkillsToChooseFrom_ComboBox = new ComboBox();
                    SkillsToChooseFrom_ComboBox.Width = 200;
                    SkillsToChooseFrom_ComboBox.HorizontalAlignment = HorizontalAlignment.Left;

                    foreach (Proficiency skill in skills.From)
                    {
                        string skillStr = skill.Name;
                        skillStr = skillStr.Replace("Skill: ", "");

                        SkillsToChooseFrom_ComboBox.Items.Add(skillStr);
                    }

                    ClassSkillsStackPanel.Children.Add(SkillsToChooseFrom_ComboBox);
                }
            }
        }

        private void addStartingEquipInfoToTextBlock(StartingEquipment startingEquipment)
        {
            string startingEquip = "";

            if (startingEquipment.StartingEquipmentElement.Count > 0)
            {
                foreach (StartingEquipmentElement startingEquipmentElement in startingEquipment.StartingEquipmentElement)
                {
                    {
                        if (startingEquipmentElement.Equals(startingEquipment.StartingEquipmentElement.Last()))
                        {
                            startingEquip += startingEquipmentElement.Quantity + " " + startingEquipmentElement.Item.Name + "\n";
                        }
                        else
                        {
                            startingEquip += startingEquipmentElement.Quantity + " " + startingEquipmentElement.Item.Name + ", ";
                        }
                    }
                }
            }
            else
            {
                startingEquip = "-";
            }

            TextBlock_ChoicesToMake.Text = "Choices to make: " + startingEquipment.ChoicesToMake + "\n";

            ClassStartingEquipmentStackPanel.Children.RemoveRange(3, ClassStartingEquipmentStackPanel.Children.Count);

            addStartingEquipmentChoiceToMakeInfoToTextBlock(startingEquipment.Choice, 1);
            addStartingEquipmentChoiceToMakeInfoToTextBlock(startingEquipment.Choice2, 2);
            addStartingEquipmentChoiceToMakeInfoToTextBlock(startingEquipment.Choice3, 3);
            addStartingEquipmentChoiceToMakeInfoToTextBlock(startingEquipment.Choice4, 4);
            addStartingEquipmentChoiceToMakeInfoToTextBlock(startingEquipment.Choice5, 5);

            TextBlock_ClassStartingEquipmentValue.Text = startingEquip;
        }

        private void addStartingEquipmentChoiceToMakeInfoToTextBlock(List<Choice> choices, int choiceNumber)
        {
            if (choices != null)
            {
                TextBlock TextBlock_StartingEquipChoice = new TextBlock();
                TextBlock_StartingEquipChoice.FontSize = 10;
                TextBlock_StartingEquipChoice.TextWrapping = TextWrapping.Wrap;
                TextBlock_StartingEquipChoice.Text = "Choice " + choiceNumber + ":";

                ClassStartingEquipmentStackPanel.Children.Add(TextBlock_StartingEquipChoice);

                foreach (Choice choice in choices)
                {
                    TextBlock TextBlock_StartingEquipChooseFrom = new TextBlock();
                    TextBlock_StartingEquipChooseFrom.FontSize = 10;
                    TextBlock_StartingEquipChooseFrom.TextWrapping = TextWrapping.Wrap;
                    TextBlock_StartingEquipChooseFrom.Text = "Choose " + choice.Choose + " from: ";

                    ClassStartingEquipmentStackPanel.Children.Add(TextBlock_StartingEquipChooseFrom);

                    ComboBox ComboBox_StartingEquipment = new ComboBox();
                    ComboBox_StartingEquipment.Width = 200;
                    ComboBox_StartingEquipment.HorizontalAlignment = HorizontalAlignment.Left;

                    foreach (StartingEquipmentElement startingEquipElem in choice.From)
                    {
                        ComboBox_StartingEquipment.Items.Add(startingEquipElem.Quantity + " " + startingEquipElem.Item.Name);
                    }
                    
                    ClassStartingEquipmentStackPanel.Children.Add(ComboBox_StartingEquipment);
                }
            }
        }
    }
}
