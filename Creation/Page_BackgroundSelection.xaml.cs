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

        public Creation Creation { get; set; }

        public Page_BackgroundSelection(Creation CreationWindow)
        {
            this.Creation = CreationWindow;
            InitializeComponent();
        }

        private void ListBox_BackgroundTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Creation.TextBox_Background.Text = ((ListBoxItem)this.ListBox_BackgroundTitle.SelectedItem).Content.ToString();
            Character.Current.Background = Creation.TextBox_Background.Text;
            this.Creation.ButtonContinueEnabled(true);
        }
    }
}
