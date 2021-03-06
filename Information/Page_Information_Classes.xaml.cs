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
    /// Interaktionslogik für Page_Information_Classes.xaml
    /// </summary>
    public partial class Page_Information_Classes : Page
    {
        DnDInformation dndInformation = new DnDInformation();
        public Page_Information_Classes()
        {
            InitializeComponent();

        }
        private int warlockslots;
        private void Button_Class_Click(object sender, RoutedEventArgs e)
        {
            string currClass = ((Button)sender).Tag.ToString();
            LevelColumn.Visibility = Visibility.Visible;
            ProfBonusColumn.Visibility = Visibility.Visible;
            FeaturesColumn.Visibility = Visibility.Visible;
            TextBlock_ClassInfoTitle.Visibility = Visibility.Visible;
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
            SpellSlotsColumn.Visibility = Visibility.Hidden;
            SlotLevelColumn.Visibility = Visibility.Hidden;
            InvocationsKnownColumn.Visibility = Visibility.Hidden;
            switch (currClass)
            {
                case "barbarian":
                    RagesColumn.Visibility = Visibility.Visible;
                    RageDamageColumn.Visibility = Visibility.Visible;
                    break;
                case "bard":
                case "sorcerer":
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
                    break;
                case "cleric":
                case "druid":
                case "wizard":
                    CantripsKnownColumn.Visibility = Visibility.Visible;
                    FirstLevelSpellColumn.Visibility = Visibility.Visible;
                    SecondLevelSpellColumn.Visibility = Visibility.Visible;
                    ThirdLevelSpellColumn.Visibility = Visibility.Visible;
                    FourthLevelSpellColumn.Visibility = Visibility.Visible;
                    FithLevelSpellColumn.Visibility = Visibility.Visible;
                    SixthLevelSpellColumn.Visibility = Visibility.Visible;
                    SeventhLevelSpellColumn.Visibility = Visibility.Visible;
                    EigthLevelSpellColumn.Visibility = Visibility.Visible;
                    NinthLevelSpellColumn.Visibility = Visibility.Visible;
                    break;
                case "monk":
                    MartialArtsColumn.Visibility = Visibility.Visible;
                    KiPointsColumn.Visibility = Visibility.Visible;
                    UnarmoredMovementColumn.Visibility = Visibility.Visible;
                    break;
                case "paladin":
                    FirstLevelSpellColumn.Visibility = Visibility.Visible;
                    SecondLevelSpellColumn.Visibility = Visibility.Visible;
                    ThirdLevelSpellColumn.Visibility = Visibility.Visible;
                    FourthLevelSpellColumn.Visibility = Visibility.Visible;
                    FithLevelSpellColumn.Visibility = Visibility.Visible;
                    break;
                case "ranger":
                    SpellsKnownColumn.Visibility = Visibility.Visible;
                    FirstLevelSpellColumn.Visibility = Visibility.Visible;
                    SecondLevelSpellColumn.Visibility = Visibility.Visible;
                    ThirdLevelSpellColumn.Visibility = Visibility.Visible;
                    FourthLevelSpellColumn.Visibility = Visibility.Visible;
                    FithLevelSpellColumn.Visibility = Visibility.Visible;
                    break;
                case "rogue":
                    SneakAttackColumn.Visibility = Visibility.Visible;
                    break;
                case "warlock":
                    CantripsKnownColumn.Visibility = Visibility.Visible;
                    SpellsKnownColumn.Visibility = Visibility.Visible;
                    SpellSlotsColumn.Visibility = Visibility.Visible;
                    SlotLevelColumn.Visibility = Visibility.Visible;
                    InvocationsKnownColumn.Visibility = Visibility.Visible;
                    break;
            }
            switch (currClass)
            {
                case "barbarian":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Barbarian";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel barbarian = dndInformation.GetClassLevelInformation("barbarian", i);
                        addClassDataGridInformation(barbarian);
                    }
                    break;
                case "bard":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Bard";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel bard = dndInformation.GetClassLevelInformation("bard", i);
                        addClassDataGridInformation(bard);
                    }
                    break;
                case "cleric":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Cleric";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel cleric = dndInformation.GetClassLevelInformation("cleric", i);
                        addClassDataGridInformation(cleric);
                    }
                    break;
                case "druid":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Druid";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel druid = dndInformation.GetClassLevelInformation("druid", i);
                        addClassDataGridInformation(druid);
                    }
                    break;
                case "fighter":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Fighter";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel fighter = dndInformation.GetClassLevelInformation("fighter", i);
                        addClassDataGridInformation(fighter);
                    }
                    break;
                case "monk":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Monk";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel monk = dndInformation.GetClassLevelInformation("monk", i);
                        addClassDataGridInformation(monk);
                    }
                    break;
                case "paladin":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Paladin";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel paladin = dndInformation.GetClassLevelInformation("paladin", i);
                        addClassDataGridInformation(paladin);
                    }
                    break;
                case "ranger":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Ranger";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel ranger = dndInformation.GetClassLevelInformation("ranger", i);
                        addClassDataGridInformation(ranger);
                    }
                    break;
                case "rogue":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Rogue";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel rogue = dndInformation.GetClassLevelInformation("rogue", i);
                        addClassDataGridInformation(rogue);
                    }
                    break;
                case "sorcerer":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Sorcerer";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel sorcerer = dndInformation.GetClassLevelInformation("sorcerer", i);
                        addClassDataGridInformation(sorcerer);
                    }
                    break;
                case "warlock":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Warlock";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel warlock = dndInformation.GetClassLevelInformation("warlock", i);
                        addClassDataGridInformation(warlock);
                    }
                    break;
                case "wizard":
                    ClassDataGrid.Items.Clear();
                    TextBlock_ClassInfoTitle.Text = "Wizard";
                    for (int i = 1; i <= 20; i++)
                    {
                        KlasseLevel wizard = dndInformation.GetClassLevelInformation("wizard", i);
                        addClassDataGridInformation(wizard);
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
                    if ((classlvls.Level == 3) || (classlvls.Level == 10))
                    {
                        features += ", Expertise";
                    }
                    break;
                case "Cleric":
                    if ((classlvls.Level == 2) || (classlvls.Level == 6) || (classlvls.Level == 8) || (classlvls.Level == 17))
                    {
                        features += ", Divine Domain Feature";
                    }
                    break;
                case "Druid":
                    if ((classlvls.Level == 6) || (classlvls.Level == 10) || (classlvls.Level == 14))
                    {
                        features += "Druid Circle Feature";
                    }
                    break;
                case "Fighter":
                    if ((classlvls.Level == 7) || (classlvls.Level == 10) || (classlvls.Level == 15) || (classlvls.Level == 18))
                    {
                        features += "Martial Archetype Feature";
                    }
                    break;
                case "Monk":
                    if ((classlvls.Level == 11) || (classlvls.Level == 17))
                    {
                        features += "Monastic Tradition Feature";
                    }
                    else if ((classlvls.Level == 6))
                    {
                        features += ", Monastic Tradition Feature";
                    }
                    break;
                case "Paladin":
                    if ((classlvls.Level == 7) || (classlvls.Level == 15) || (classlvls.Level == 20))
                    {
                        features += "Sacred Oath Feature";
                    }
                    break;
                case "Ranger":
                    if ((classlvls.Level == 7) || (classlvls.Level == 11) || (classlvls.Level == 15))
                    {
                        features += "Ranger Archetype Feature";
                    }
                    break;
                case "Rogue":
                    if ((classlvls.Level == 9) || (classlvls.Level == 13) || (classlvls.Level == 17))
                    {
                        features += "Roguish Archetype Feature";
                    }
                    if (classlvls.Level == 1)
                    {
                        features += ", Expertise";
                    }
                    if (classlvls.Level == 6)
                    {
                        features += "Expertise";
                    }
                    break;
                case "Sorcerer":
                    if ((classlvls.Level == 6) || (classlvls.Level == 14) || (classlvls.Level == 18))
                    {
                        features += "Sorcerous Origin Feature";
                    }
                    if ((classlvls.Level == 3) || (classlvls.Level == 10) || (classlvls.Level == 17))
                    {
                        features += "Metamagic";
                    }
                    break;
                case "Warlock":
                    if ((classlvls.Level == 6) || (classlvls.Level == 10) || (classlvls.Level == 14))
                    {
                        features += "Otherworldly Patron Feature";
                    }
                    if (classlvls.Level == 2)
                    {
                        features += "Eldritch Invocations";
                    }
                    if (classlvls.Level == 3)
                    {
                        features += "Pact Boon";
                    }
                    break;
                case "Wizard":
                    if ((classlvls.Level == 6) || (classlvls.Level == 10) || (classlvls.Level == 14))
                    {
                        features += "Arcane Tradition Feature";
                    }
                    break;
            }
            switch(classlvls.klasse.Name)
            {
                case "Barbarian":
                    DataGridItem dataClassGridItem = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        RagesCol = classlvls.ClassSpecific.RageCount,
                        RageDamageCol = "+" + classlvls.ClassSpecific.RageDamageBonus
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem);
                    break;
                case "Bard":
                    DataGridItem dataClassGridItem1 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
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
                case "Cleric":
                case "Druid":
                case "Wizard":
                    DataGridItem dataClassGridItem2 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        CantripsKnownCol = classlvls.Spellcasting.CantripsKnown,
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
                    ClassDataGrid.Items.Add(dataClassGridItem2);
                    break;
                case "Fighter":
                    DataGridItem dataClassGridItem9 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem9);
                    break;
                case "Monk":
                    DataGridItem dataClassGridItem3 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        MartialArtsCol = classlvls.ClassSpecific.MartialArts.DiceCount + "d" + classlvls.ClassSpecific.MartialArts.DiceValue,
                        KiPointsCol = classlvls.ClassSpecific.KiPoints,
                        UnarmoredMovementCol = "+" + classlvls.ClassSpecific.UnarmoredMovement + " ft."
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem3);
                    break;
                case "Paladin":
                    DataGridItem dataClassGridItem4 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        FirstLevelSpellCol = classlvls.SpellSlotsLevel1,
                        SecondLevelSpellCol = classlvls.SpellSlotsLevel2,
                        ThirdLevelSpellCol = classlvls.SpellSlotsLevel3,
                        FourthLevelSpellCol = classlvls.SpellSlotsLevel4,
                        FithLevelSpellCol = classlvls.SpellSlotsLevel5
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem4);
                    break;
                case "Ranger":
                    DataGridItem dataClassGridItem5 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        SpellsKnownCol = classlvls.Spellcasting.SpellsKnown,
                        FirstLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel1,
                        SecondLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel2,
                        ThirdLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel3,
                        FourthLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel4,
                        FithLevelSpellCol = classlvls.Spellcasting.SpellSlotsLevel5
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem5);
                    break;
                case "Rogue":
                    DataGridItem dataClassGridItem6 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        SneakAttackCol = classlvls.ClassSpecific.SneakAttack.DiceCount + "d" + classlvls.ClassSpecific.SneakAttack.DiceValue
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem6);
                    break;
                case "Sorcerer":
                    DataGridItem dataClassGridItem7 = new DataGridItem()
                    {
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        SorceryPointsCol = classlvls.ClassSpecific.SorceryPoints,
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
                    ClassDataGrid.Items.Add(dataClassGridItem7);
                    break;
                case "Warlock":
                    DataGridItem dataClassGridItem8 = new DataGridItem()
                    {                        
                        LevelCol = classlvls.Level,
                        ProfBonusCol = "+" + classlvls.ProfBonus,
                        FeaturesCol = features,
                        CantripsKnownCol = classlvls.Spellcasting.CantripsKnown,
                        SpellsKnownCol = classlvls.Spellcasting.SpellsKnown,
                        SlotLevelCol = GetSlotLevel(classlvls),
                        SpellSlotsCol = warlockslots,
                        InvocationsKnownCol = classlvls.ClassSpecific.InvocationsKnown
                    };
                    ClassDataGrid.Items.Add(dataClassGridItem8);
                    break;
            }
        }
        public string GetSlotLevel(KlasseLevel classlvls)
        {
            string slotlvl = "";
            if (classlvls.Spellcasting.SpellSlotsLevel1 != 0)
            {
                slotlvl = "1st";
                warlockslots = classlvls.Spellcasting.SpellSlotsLevel1;
            }
            if (classlvls.Spellcasting.SpellSlotsLevel2 != 0)
            {
                slotlvl = "2nd";
                warlockslots = classlvls.Spellcasting.SpellSlotsLevel2;
            }
            if (classlvls.Spellcasting.SpellSlotsLevel3 != 0)
            {
                slotlvl = "3rd";
                warlockslots = classlvls.Spellcasting.SpellSlotsLevel3;
            }
            if (classlvls.Spellcasting.SpellSlotsLevel4 != 0)
            {
                slotlvl = "4th";
                warlockslots = classlvls.Spellcasting.SpellSlotsLevel4;
            }
            if (classlvls.Spellcasting.SpellSlotsLevel5 != 0)
            {
                slotlvl = "5th";
                warlockslots = classlvls.Spellcasting.SpellSlotsLevel5;
            }
            return slotlvl;
        }
    }
}
