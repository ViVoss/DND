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
    /// Interaktionslogik für ClassesSelection.xaml
    /// </summary>
    public partial class Page_ClassSelection : Page
    {
        public Page_ClassSelection()
        {
            InitializeComponent();
        }

        private void Barbarian_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Description.Text = "Dies is der Barbar. Er macht Smash.\n\nHit Die: d12\nSaving Throws: Strength, Constitution";
        }

        private void Barbarian_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Description.Clear();
        }

        private void Bard_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Description.Text = "Dies is der Barde. Er kann singen und tanzen. Er ist im Prinzip ein Waldorfschüler der einen Hogwartsbrief bekommen hat.";
        }

        private void Bard_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Description.Clear();
        }

        private void Druid_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Description.Text = "Dies is der Barbar. Er macht Smash.";
        }

        private void Druid_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Description.Clear();
        }

        private void Druid_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}