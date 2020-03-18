using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Net.Cache;

namespace DND
{
    /// <summary>
    /// Interaktionslogik für Level_Table_Barbarian.xaml
    /// </summary>
    public partial class Level_Table_Barbarian : Page
    {
        List<TestLevel> testLevels = new List<TestLevel>();
        public Level_Table_Barbarian(Page_Information_Classes page_Information_Classes)
        {
            InitializeComponent();
            this.Page_Information_Classes = page_Information_Classes;
            testLevels.Add(new TestLevel { Level = "1st", ProficiencyBonus = "+2", Features = "Rage, Unarmored Defense", Rages = "2", RageDamage = "+2" });
            testLevels.Add(new TestLevel { Level = "2nd", ProficiencyBonus = "+2", Features = "Reckless Attack, Danger Sense", Rages = "2", RageDamage = "+2" });
            testLevels.Add(new TestLevel { Level = "3rd", ProficiencyBonus = "+2", Features = "Primal Path", Rages = "3", RageDamage = "+2" });
            ListView_LevelTable.ItemsSource = testLevels;
        }
        public Page_Information_Classes Page_Information_Classes { get; set; }
        public class TestLevel
        {
            public string Level { get; set; }
            public string ProficiencyBonus { get; set; }
            public string Features { get; set; }
            public string Rages { get; set; }
            public string RageDamage { get; set; }
        }
        public void GetInformation(int i)
        {
            switch (i)
            {
                case 1:
                    Page_Information_Classes.TextBlock_ClassInfo.Text = "RAGE:\nIn battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action. While raging, you gain the following benefits if you aren't wearing heavy armor: You have advantage on Strength checks and Strength saving throws. When you make a melee weapon Attack using Strength, you gain a +2 bonus to the damage roll. This bonus increases as you level. You have Resistance to bludgeoning, piercing, and slashing damage. If you are able to cast Spells, you can't cast them or concentrate on them while raging. Your rage lasts for 1 minute. It ends early if you are knocked Unconscious or if Your Turn ends and you haven't attacked a hostile creature since your last turn or taken damage since then. You can also end your rage on Your Turn as a Bonus Action. Once you have raged the maximum number of times for your barbarian level, you must finish a Long Rest before you can rage again. You may rage 2 times at 1st level, 3 at 3rd, 4 at 6th, 5 at 12th, and 6 at 17th.\n\nUnarmored Defense:\nWhile you are not wearing any armor, your Armor Class equals 10 + your Dexterity modifier +your Constitution modifier. You can use a shield and still gain this benefit.";
                    break;
                case 2:
                    Page_Information_Classes.TextBlock_ClassInfo.Text = "";
                    break;
                case 3:
                    Page_Information_Classes.TextBlock_ClassInfo.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void ListView_LevelTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetInformation(ListView_LevelTable.SelectedIndex);
        }
    }
}