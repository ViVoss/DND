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
using System.Windows.Shapes;

namespace DND
{
    /// <summary>
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        // Creation >>>
        private void Creation_ButtonClick(object sender, RoutedEventArgs e)
        {
            var CreationMainPage = new CharacterCreationMain();
            CreationMainPage.Show();
            //this.NavigationService.Navigate(CreationMainPage);
        }
        // Creation <<<

        // Barbarian >>>
        private void Barbarian_MouseEnter(object sender, MouseEventArgs e)
        {
            this.ViewImage.Source = new BitmapImage(new Uri("/Resources/Menu/Barbarian.png", UriKind.Relative));
        }
        private void Barbarian_MouseLeave(object sender, MouseEventArgs e)
        {
            this.ViewImage.Source = new BitmapImage(new Uri("/Resources/Menu/PNGTotal.png", UriKind.Relative));
        }
        private void Barbarian_ButtonClick(object sender, RoutedEventArgs e)
        {
            //Barbarian BarbarianInfoPage = new Barbarian();
            //this.NavigationService.Navigate(BarbarianInfoPage);
            Maintenance MaintenancePage = new Maintenance();
            //this.NavigationService.Navigate(MaintenancePage);
        }
        // Barbarian <<<


        // Cleric >>>
        private void Cleric_MouseEnter(object sender, MouseEventArgs e)
        {
            this.ViewImage.Source = new BitmapImage(new Uri("/Resources/Menu/Cleric.png", UriKind.Relative));
        }
        private void Cleric_MouseLeave(object sender, MouseEventArgs e)
        {
            this.ViewImage.Source = new BitmapImage(new Uri("/Resources/Menu/PNGTotal.png", UriKind.Relative));
        }
        private void Cleric_ButtonClick(object sender, RoutedEventArgs e)
        {
            //Cleric ClericInfoPage = new Cleric();
            //this.NavigationService.Navigate(ClericInfoPage);
            Maintenance MaintenancePage = new Maintenance();
            //this.NavigationService.Navigate(MaintenancePage);
        }
        // Cleric <<<


        // Rogue >>>
        private void Rogue_MouseEnter(object sender, MouseEventArgs e)
        {
            this.ViewImage.Source = new BitmapImage(new Uri("/Resources/Menu/Rogue.png", UriKind.Relative));
        }
        private void Rogue_MouseLeave(object sender, MouseEventArgs e)
        {
            this.ViewImage.Source = new BitmapImage(new Uri("/Resources/Menu/PNGTotal.png", UriKind.Relative));
        }
        private void Rogue_ButtonClick(object sender, RoutedEventArgs e)
        {
            //Rogue RogueInfoPage = new Rogue();
            //this.NavigationService.Navigate(RogueInfoPage);
            Maintenance MaintenancePage = new Maintenance();
            //this.NavigationService.Navigate(MaintenancePage);
        }
        // Rogue <<<
    }
}

