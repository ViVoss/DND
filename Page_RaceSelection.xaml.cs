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
    /// Interaktionslogik für Page_RaceSelection.xaml
    /// </summary>
    public partial class Page_RaceSelection : Page
    {
        public Page_RaceSelection()
        {
            InitializeComponent();
        }

        private void Button_Race_Click(object sender, RoutedEventArgs e)
        {
            string currRace = ((Button)sender).Tag.ToString();
            Window_SubraceSelection subra = new Window_SubraceSelection(((Creation)Window.GetWindow(this)), currRace);
            subra.ShowDialog();
        }
        private void Button_Race_MouseEnter(object sender, MouseEventArgs e)
        {

        }
        private void Button_Race_MouseLeave(object sender, MouseEventArgs e)
        {

        }
        private void Dwarf_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Description.Text = getTestString_Dwarf();
        }

        private void Dwarf_MouseLeave(object sender, MouseEventArgs e)
        {
            //TextBox_Description.Clear();
        }
        private void Elf_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Description.Text = "11\nFriggin Baumknutscher";
        }

        private void Elf_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Description.Clear();
        }


        private void Human_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Description.Text = "Ich heiße Marvin";
        }

        private void Human_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Description.Clear();
        }

        private void Human_Click(object sender, RoutedEventArgs e)
        {

        }
        private string getTestString_Dwarf()
        {
            string dwarfTraits = "Ability Score Increase\nYour Constitution score increases by 2.\n\nAge\nDwarves mature at the same rate as humans, but they’re considered young until they reach the age of 50.On average, they live about 350 years.\n\nAlignment\nMost dwarves are lawful, believing firmly in the benefits of a well - ordered society.They tend toward good as well, with a strong sense of fair play and a belief that everyone deserves to share in the benefits of a just order.\n\nSize\nDwarves stand between 4 and 5 feet tall and average about 150 pounds.Your size is Medium.\n\nSpeed\nYour base walking speed is 25 feet.Your speed is not reduced by wearing heavy armor.\n\nDarkvision\nAccustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.You can’t discern color in darkness, only shades of gray.\nDwarven Resilience\nYou have advantage on saving throws against poison, and you have resistance against poison damage(explained in the “Combat” section).\n\nDwarven Combat Training\nYou have proficiency with the battleaxe, handaxe, light hammer, and warhammer.\n\nTool Proficiency\nYou gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.\n\nStonecunning\nWhenever you make an Intelligence(History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus.\n\nLanguages\nYou can speak, read, and write Common and Dwarvish.Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak.";
            return dwarfTraits;
        }

        private void Dwarf_Click(object sender, RoutedEventArgs e)
        {
            //Window_SubraceSelection subra = new Window_SubraceSelection(((Creation)Window.GetWindow(this)));
            //subra.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
