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
        List<CharacterExcerpt> Excerpt = new List<CharacterExcerpt>();
        public Page_ChooseCharacterToLoad(Window window, MainMenu mainMenu)
        {
            InitializeComponent();
            this.Window = window;
            this.MainMenu = mainMenu;
            this.MainMenu.CharacterName = "";
        }
        public class CharacterExcerpt
        {
            public string PlayerName { get; set; }
            public string CharacterName { get; set; }
            public ushort Level { get; set; }
            public string Race { get; set; }
            public string Subrace { get; set; }
            public string Class { get; set; }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            List<Character> characterList = Character.GetAll();
            foreach (Character character in characterList)
            {
                Excerpt.Add(new CharacterExcerpt { PlayerName = character.PlayerName, CharacterName = character.CharacterName, Level = character.Level, Race = character.Race, Subrace = character.SubRace, Class = character.Class });
            }
            pageCharacterList.ItemsSource = Excerpt;
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
}
