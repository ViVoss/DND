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

        private void Button_Background_MouseEnter(object sender, MouseEventArgs e)
        {
            string background = ((Button)sender).Tag.ToString();
            TextBlock_BackgroundInfo.Text = dndInformation.GetBackgroundInformation(background);
        }

        private void Button_Background_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Button_Background_Click(object sender, RoutedEventArgs e)
        {
            Creation.TextBox_Background.Text = ((Button)sender).Tag.ToString();
            Character.Current.Background = Creation.TextBox_Background.Text;
            this.Creation.ButtonContinueEnabled(true);
        }
    }
}
