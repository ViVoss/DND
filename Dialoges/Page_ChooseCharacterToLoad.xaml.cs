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
    public partial class Page_ChooseCharacterToLoad : Page
    {
        public Window Window { get; set; }
        public MainMenu MainMenu { get; set; }
        public Page_ChooseCharacterToLoad(Window window, MainMenu mainMenu)
        {
            InitializeComponent();
            this.Window = window;
            this.MainMenu = mainMenu;
            this.MainMenu.CharacterName = "";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Character> characterList = Character.GetAll();
            foreach (Character character in characterList)
            {
                //this.pageCharacterList.Items.Add(character.PlayerName, character.CharacterName);
                this.pageCharacterList.Items.Add(new CharacterListData(character.PlayerName, character.CharacterName, character.Level, character.Race, character.SubRace, character.Class));
            }
        }

        private void pageCharacterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.buttonCharacterÖffnen.IsEnabled = true;
        }

        private void btnCharacterÖffnen_Click(object sender, RoutedEventArgs e)
        {
            this.MainMenu.CharacterName = this.pageCharacterList.SelectedItem.ToString();

            //Schießt das Fenster
            //Wenn wie oben der Name gesetzt wurde, wird es nach dem Schließen als Erfolg erkannt
            Window.Close();
        }


    }

    public class CharacterListData
    {
        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
        public ushort Level { get; set; }
        public string Race { get; set; }
        public string Subrace { get; set; }
        public string Class { get; set; }

        public CharacterListData(string PlayerName, string CharacterName, ushort Level, string Race, string Subrace, string Class)
        {
            this.PlayerName = PlayerName;
            this.CharacterName = CharacterName;
            this.Level = Level;
            this.Race = Race;
            this.Subrace = Subrace;
            this.Class = Class;
        }
    }
}
