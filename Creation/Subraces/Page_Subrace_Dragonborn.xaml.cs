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

namespace DND.Subraces
{
    /// <summary>
    /// Interaktionslogik für Page_Subrace_Dragonborn.xaml
    /// </summary>
    public partial class Page_Subrace_Dragonborn : Page
    {
        List<DraconicAncestry> DraconicAncestryList = new List<DraconicAncestry>();
        public Page_Subrace_Dragonborn()
        {
            InitializeComponent();
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Black", DamageType = "Acid", BreathWeapon = "5 by 30 ft. line (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Blue", DamageType = "Lightning", BreathWeapon = "5 by 30 ft. line (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Brass", DamageType = "Fire", BreathWeapon = "5 by 30 ft. line (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Bronze", DamageType = "Lightning", BreathWeapon = "5 by 30 ft. line (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Copper", DamageType = "Acid", BreathWeapon = "5 by 30 ft. line (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Gold", DamageType = "Fire", BreathWeapon = "15 ft. cone (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Green", DamageType = "Poison", BreathWeapon = "15 ft. cone (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Red", DamageType = "Fire", BreathWeapon = "15 ft. cone (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "Silver", DamageType = "Cold", BreathWeapon = "15 ft. cone (Dex. save)" });
            DraconicAncestryList.Add(new DraconicAncestry { Dragon = "White", DamageType = "Cold", BreathWeapon = "15 ft. cone (Dex. save)" });
            Listview_DraconicAncenstry.ItemsSource = DraconicAncestryList;
        }
        public class DraconicAncestry
        {
            public string Dragon { get; set; }
            public string DamageType { get; set; }
            public string BreathWeapon { get; set; }
            //public int Completion { get; set; }
        }
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Listview_DraconicAncenstry.SelectedIndex = Convert.ToInt32(((Image)sender).Tag.ToString());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Listview_DraconicAncenstry.SelectedIndex = Convert.ToInt32(((Image)sender).Tag.ToString());
        }

        private void Button_Select_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
