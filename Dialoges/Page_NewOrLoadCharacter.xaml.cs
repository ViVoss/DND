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

namespace DND.Dialoges
{
    /// <summary>
    /// Interaktionslogik für Page_NewOrLoadCharacter.xaml
    /// </summary>
    public partial class Page_NewOrLoadCharacter : Page
    {
        public MainMenu MainMenu { get; set; }
        public Page_NewOrLoadCharacter(MainMenu mainMenu)
        {
            InitializeComponent();
            this.MainMenu = mainMenu;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            List<Character> characterList = Character.GetAll();
            foreach (Character character in characterList)
            {
                this.pageCharacterList.Items.Add(character.CharacterName);
            }
        }

        private void btnCharacterÖffnen_Click(object sender, RoutedEventArgs e)
        {
            this.MainMenu.CharacterName = this.pageCharacterList.SelectedItem.ToString();
        }

        private void pageCharacterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.buttonCharacterÖffnen.IsEnabled = true;
        }
    }
}
