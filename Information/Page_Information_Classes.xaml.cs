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
            string currClass = ((Button)sender).Tag.ToString();

            //TextBlock_RaceInfoTitle.Visibility = Visibility.Visible;
            RagesColumn.Visibility = Visibility.Hidden;
            RageDamageColumn.Visibility = Visibility.Hidden;
            MartialArtsColumn.Visibility = Visibility.Hidden;
            KiPointsColumn.Visibility = Visibility.Hidden;
            UnarmoredMovementColumn.Visibility = Visibility.Hidden;
            SneakAttackColumn.Visibility = Visibility.Hidden;
            SorceryPointsColumn.Visibility = Visibility.Hidden;
            CantripsKnownColumn.Visibility = Visibility.Hidden;
            SpellsKnownColumn.Visibility = Visibility.Hidden;
            FirstLevelSpellColumn.Visibility = Visibility.Hidden;
            SecondLevelSpellColumn.Visibility = Visibility.Hidden;
            ThirdLevelSpellColumn.Visibility = Visibility.Hidden;
            FourthLevelSpellColumn.Visibility = Visibility.Hidden;
            FithLevelSpellColumn.Visibility = Visibility.Hidden;
            SixthLevelSpellColumn.Visibility = Visibility.Hidden;
            SeventhLevelSpellColumn.Visibility = Visibility.Hidden;
            EigthLevelSpellColumn.Visibility = Visibility.Hidden;
            NinthLevelSpellColumn.Visibility = Visibility.Hidden;
            switch (currClass)
            {
                case "barbarian":
                    ClassDataGrid.Items.Clear();
                    RagesColumn.Visibility = Visibility.Visible;
                    RageDamageColumn.Visibility = Visibility.Visible;
                    TextBlock_ClassInfoTitle.Text = "Barbarian";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel barbarian = dndInformation.GetClassLevelInformation("barbarian", i);
                        addClassDataGridInformation(barbarian);
                    }
                    break;
                case "bard":
                    ClassDataGrid.Items.Clear();
                    CantripsKnownColumn.Visibility = Visibility.Visible;
                    SpellsKnownColumn.Visibility = Visibility.Visible;
                    FirstLevelSpellColumn.Visibility = Visibility.Visible;
                    SecondLevelSpellColumn.Visibility = Visibility.Visible;
                    ThirdLevelSpellColumn.Visibility = Visibility.Visible;
                    FourthLevelSpellColumn.Visibility = Visibility.Visible;
                    FithLevelSpellColumn.Visibility = Visibility.Visible;
                    SixthLevelSpellColumn.Visibility = Visibility.Visible;
                    SeventhLevelSpellColumn.Visibility = Visibility.Visible;
                    EigthLevelSpellColumn.Visibility = Visibility.Visible;
                    NinthLevelSpellColumn.Visibility = Visibility.Visible;
                    TextBlock_ClassInfoTitle.Text = "Bard";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel bard = dndInformation.GetClassLevelInformation("bard", i);
                        addClassDataGridInformation(bard);
                    }
                    break;
                case "cleric":
                    ClassDataGrid.Items.Clear();
                    CantripsKnownColumn.Visibility = Visibility.Visible;
                    SpellsKnownColumn.Visibility = Visibility.Visible;
                    FirstLevelSpellColumn.Visibility = Visibility.Visible;
                    SecondLevelSpellColumn.Visibility = Visibility.Visible;
                    ThirdLevelSpellColumn.Visibility = Visibility.Visible;
                    FourthLevelSpellColumn.Visibility = Visibility.Visible;
                    FithLevelSpellColumn.Visibility = Visibility.Visible;
                    SixthLevelSpellColumn.Visibility = Visibility.Visible;
                    SeventhLevelSpellColumn.Visibility = Visibility.Visible;
                    EigthLevelSpellColumn.Visibility = Visibility.Visible;
                    NinthLevelSpellColumn.Visibility = Visibility.Visible;
                    TextBlock_ClassInfoTitle.Text = "Cleric";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel cleric = dndInformation.GetClassLevelInformation("cleric", i);
                        addClassDataGridInformation(cleric);
                    }
                    break;
            }
        }
        public void addClassDataGridInformation(KlasseLevel classlvls)
        {
            string features = "";
            foreach (Features feature in classlvls.Features)
            {
                if (feature.Equals(classlvls.Features.Last()))
                {
                    features += feature.Name;
                }
                else
                {
                    features += feature.Name + ", ";
                }
            }
            switch(classlvls.klasse.Name)
            {
                case "Barbarian":
                    if ((classlvls.Level == 6) || (classlvls.Level == 10) || (classlvls.Level == 14))
                    {
                        features += "Path Feature";
                    }
                    break;
                case "Bard":
                    if ((classlvls.Level == 6) || (classlvls.Level == 14))
                    {
                        features += ", Bard College Feature";
                    }
                    break;
                case "Cleric":
                    if ((classlvls.Level == 2) || (classlvls.Level == 6) || (classlvls.Level == 8) || (classlvls.Level == 17))
                    {
                        features += ", Divine Domain Feature";
                    }
                    break;
            }
            switch(classlvls.klasse.Name)
            {
                case "Barbarian":
                    DataGridItem dataClassGridItem = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = classlvls.ProfBonus,
                        FeaturesCol = features,
                        RagesCol = classlvls.ClassSpecific.RageCount,
                        RageDamageCol = classlvls.ClassSpecific.RageDamageBonus
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem);
                    break;
                case "Bard":
                case "Cleric":
                    DataGridItem dataClassGridItem1 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = classlvls.ProfBonus,
                        FeaturesCol = features,
                        CantripsKnownCol = classlvls.Spellcasting.CantripsKnown,
                        SpellsKnownCol = classlvls.Spellcasting.SpellsKnown,
                        FirstLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel1,
                        SecondLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel2,
                        ThirdLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel3,
                        FourthLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel4,
                        FithLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel5,
                        SixthLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel6,
                        SeventhLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel7,
                        EigthLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel8,
                        NinthLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel9
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem1);
                    break;
            }
        }
        /*
        private void ClassDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KlasseLevel test = (KlasseLevel)ClassDataGrid.SelectedItem;
            foreach (Features features in test.Features)
            {
                MessageBox.Show(features.Name);
            }
        }
        */
    }
}
