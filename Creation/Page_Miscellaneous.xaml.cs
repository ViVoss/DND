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
    /// Interaktionslogik für Page_Miscellaneous.xaml
    /// </summary>
    public partial class Page_Miscellaneous : Page
    {

        public Creation Creation { get; set; }

        public Page_Miscellaneous(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();

            loadMiscellaneous();
        }

        private void loadMiscellaneous()
        {
            this.CharacterName.Text = Character.Current.CharacterName;
            this.PlayerName.Text = Character.Current.PlayerName;
            this.CharacterExperiencePoints.Text = Character.Current.ExperiencePoints != 0 ? Character.Current.ExperiencePoints.ToString() : "";
            this.CharacterAge.Text = Character.Current.Age != 0 ? Character.Current.Age.ToString() : "";
            this.CharacterSex.Text = Character.Current.Appearance.Gender;
            this.CharacterHeight.Text = Character.Current.Appearance.Size;
            this.CharacterWeight.Text = Character.Current.Appearance.Weight;
            this.CharacterHairColor.Text = Character.Current.Appearance.Haircolor;
            this.CharacterEyeColor.Text = Character.Current.Appearance.Eyecolor;
            this.CharacterSkinColor.Text = Character.Current.Appearance.Skincolor;
            this.CharacterPersonalityTrait1.Text = Character.Current.PersonalityTraitOne;
            this.CharacterPersonalityTrait2.Text = Character.Current.PersonalityTraitTwo;
            this.CharacterIdeals.Text = Character.Current.Ideals;
            this.CharacterBonds.Text = Character.Current.Bonds;
            this.CharacterFlaws.Text = Character.Current.Flaws;
            this.CharacterFactionName.Text = Character.Current.FactionName;
            this.CharacterDescriptionBackstory.Text = Character.Current.BackStory;
            this.CharacterNotes.Text = Character.Current.Notes;

        }

        private void CharacterName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.CharacterName = ((TextBox)sender).Text;
        }

        private void PlayerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.PlayerName = ((TextBox)sender).Text;
        }

        private void CharacterExperiencePoints_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Character.Current.ExperiencePoints = ((TextBox)sender).Text != "" ? Convert.ToUInt64(((TextBox)sender).Text) : 0;
            }
            catch (Exception)
            {
                Character.Current.ExperiencePoints = 0;
                ((TextBox)sender).Text = "";
                MessageBox.Show("Ungültiger Wert");
            }

        }

        private void CharacterAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Character.Current.Age = ((TextBox)sender).Text != "" ? Convert.ToUInt16(((TextBox)sender).Text) : (ushort)0;
            }
            catch (Exception)
            {
                Character.Current.Age = 0;
                ((TextBox)sender).Text = "";
                MessageBox.Show("Ungültiger Wert");
            }
        }

        private void CharacterSex_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Appearance.Gender = ((TextBox)sender).Text;
        }

        private void CharacterHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Appearance.Size = ((TextBox)sender).Text;
        }

        private void CharacterWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Appearance.Weight = ((TextBox)sender).Text;
        }

        private void CharacterHairColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Appearance.Haircolor = ((TextBox)sender).Text;
        }

        private void CharacterEyeColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Appearance.Eyecolor = ((TextBox)sender).Text;
        }

        private void CharacterSkinColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Appearance.Skincolor = ((TextBox)sender).Text;
        }

        private void CharacterPersonalityTrait1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.PersonalityTraitOne = ((TextBox)sender).Text;
        }

        private void CharacterPersonalityTrait2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.PersonalityTraitTwo = ((TextBox)sender).Text;
        }

        private void CharacterIdeals_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Ideals = ((TextBox)sender).Text;
        }

        private void CharacterBonds_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Bonds = ((TextBox)sender).Text;
        }

        private void CharacterFlaws_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Flaws = ((TextBox)sender).Text;
        }

        private void CharacterFactionName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.FactionName = ((TextBox)sender).Text;
        }

        private void CharacterDescriptionBackstory_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.BackStory = ((TextBox)sender).Text;
        }

        private void CharacterNotes_TextChanged(object sender, TextChangedEventArgs e)
        {
            Character.Current.Notes = ((TextBox)sender).Text;
        }
    }
}
