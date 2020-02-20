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
    /// Interaktionslogik für CharacterCreationMain.xaml
    /// </summary>
    public partial class CharacterCreationMain : Window
    {
        List<Classesdata> ClassesDataList = new List<Classesdata>();
        List<Classesdata> RacesDataList = new List<Classesdata>();
        List<Classesdata> SubracesDataList = new List<Classesdata>();
        //List<SelectedClassesData> selectedClassesListLevel = new List<SelectedClassesData>();

        public CharacterCreationMain()
        {
            InitializeComponent();

            RacesDataList.Add(new Classesdata { Photo = "Resources/Menu/Dwarf.png", Name = "Dwarf" });
            RacesDataList.Add(new Classesdata { Photo = "Resources/Menu/Elf.png", Name = "Elf" });
            RacesDataList.Add(new Classesdata { Photo = "Resources/Menu/Human.png", Name = "Human" });
            cmbRaces.ItemsSource = RacesDataList;
            cmbRaces.SelectedIndex = 0;
            ClassesDataList.Add(new Classesdata { Photo = "Resources/Menu/Barbarian.png", Name = "Barbarian" });
            ClassesDataList.Add(new Classesdata { Photo = "Resources/Menu/Cleric.png", Name = "Cleric" });
            ClassesDataList.Add(new Classesdata { Photo = "Resources/Menu/Rogue.png", Name = "Rogue" });
            cmbClasses.ItemsSource = ClassesDataList;
            cmbClasses.SelectedIndex = 0;
        }
        public class SelectedClassesData
        {
            public string Title { get; set; }
            public string Level { get; set; }
            //public int Completion { get; set; }
        }
        public class Classesdata
        {
            public string Photo { get; set; }
            public string Name { get; set; }
        }
        private void CmbRaces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SubracesDataList.Clear();
            if (cmbRaces.SelectedIndex == 0)
            {
                SubracesDataList.Add(new Classesdata { Name = "Hill" });
                SubracesDataList.Add(new Classesdata { Name = "Mountain" });
            }
            else if (cmbRaces.SelectedIndex == 1)
            {
                SubracesDataList.Add(new Classesdata { Name = "Wood" });
                SubracesDataList.Add(new Classesdata { Name = "High" });
                SubracesDataList.Add(new Classesdata { Name = "Drow" });
            }
            else if (cmbRaces.SelectedIndex == 2)
            {
                SubracesDataList.Add(new Classesdata { Name = "Vanilla" });
                SubracesDataList.Add(new Classesdata { Name = "Variant" });
            }
            cmbSubraces.ItemsSource = SubracesDataList;
            cmbSubraces.Items.Refresh();
            cmbSubraces.SelectedIndex = 0;
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            int selectedClassIndex;
            double expBarValueHolder;
            double expBarTotalLevel = 20;
            double addedLevel = 0;

            selectedClassIndex = cmbClasses.SelectedIndex + 1;
            if (selectedClassIndex == getClassIndexFromColor(expBar1))
            {
                if ((Convert.ToInt32(expBarLabel.Text) + (cmbLevels.SelectedIndex + 1)) <= 20)
                {
                    if (expBar1.Minimum == 0)
                    {
                        expBar1.Minimum = cmbLevels.SelectedIndex + 1;
                        expBarTotalLevel = expBar1.Minimum;
                        expBarLabel.Text = Convert.ToString(expBarTotalLevel);
                        expBar1.Foreground = getColorFromClassIndex(selectedClassIndex);
                    }
                    else if (expBar1.Minimum != 0)
                    {
                        expBarValueHolder = expBar1.Minimum;
                        expBar1.Minimum = (cmbLevels.SelectedIndex + 1) + expBarValueHolder;
                        expBarTotalLevel = Convert.ToInt32(expBarLabel.Text) + (cmbLevels.SelectedIndex + 1);
                        expBarLabel.Text = Convert.ToString(expBarTotalLevel);
                        expBar1.Foreground = getColorFromClassIndex(selectedClassIndex);
                        addedLevel = cmbLevels.SelectedIndex + 1;
                        RefreshLevel(selectedClassIndex, expBar1.Minimum);
                    }
                }
                expBar1.Width = 50 * expBar1.Minimum;
                if (expBar2.Minimum > 0)
                {
                    expBar2.Width = (expBar2.Width + (addedLevel * 50));
                    if (expBar3.Minimum > 0)
                    {
                        expBar3.Width = (expBar3.Width + (addedLevel * 50));
                    }
                }
            }
            else if (selectedClassIndex == getClassIndexFromColor(expBar2))
            {
                if ((Convert.ToInt32(expBarLabel.Text) + (cmbLevels.SelectedIndex + 1)) <= 20)
                {
                    if (expBar2.Minimum == 0)
                    {
                        expBar2.Minimum = cmbLevels.SelectedIndex + 1;
                        expBarTotalLevel = expBar2.Minimum;
                        expBarLabel.Text = Convert.ToString(expBarTotalLevel);
                        expBar2.Foreground = getColorFromClassIndex(selectedClassIndex);
                    }
                    else if (expBar2.Minimum != 0)
                    {
                        expBarValueHolder = expBar2.Minimum;
                        expBar2.Minimum = (cmbLevels.SelectedIndex + 1) + expBarValueHolder;
                        expBarTotalLevel = Convert.ToInt32(expBarLabel.Text) + (cmbLevels.SelectedIndex + 1);
                        expBarLabel.Text = Convert.ToString(expBarTotalLevel);
                        expBar2.Foreground = getColorFromClassIndex(selectedClassIndex);
                        addedLevel = cmbLevels.SelectedIndex + 1;
                        RefreshLevel(selectedClassIndex, expBar2.Minimum);
                    }
                }
                // selectedClassesList.Items.Add(new SelectedClassesData() { Title = getClassTitleFromIndex(selectedClassIndex),
                //    Level = Convert.ToString(expBar2.Minimum)});//, Completion = Convert.ToInt32(expBar2.Minimum) });
                expBar2.Width = 50 * (expBar2.Minimum + expBar1.Minimum);
                if (expBar3.Minimum > 0)
                {
                    expBar3.Width = (expBar3.Width + (addedLevel * 50));
                }
            }
            else if (selectedClassIndex == getClassIndexFromColor(expBar3))
            {
                if ((Convert.ToInt32(expBarLabel.Text) + (cmbLevels.SelectedIndex + 1)) <= 20)
                {
                    if (expBar3.Minimum == 0)
                    {
                        expBar3.Minimum = cmbLevels.SelectedIndex + 1;
                        expBarTotalLevel = expBar3.Minimum;
                        expBarLabel.Text = Convert.ToString(expBarTotalLevel);
                        expBar3.Foreground = getColorFromClassIndex(selectedClassIndex);
                    }
                    else if (expBar3.Minimum != 0)
                    {
                        expBarValueHolder = expBar3.Minimum;
                        expBar3.Minimum = (cmbLevels.SelectedIndex + 1) + expBarValueHolder;
                        expBarTotalLevel = Convert.ToInt32(expBarLabel.Text) + (cmbLevels.SelectedIndex + 1);
                        expBarLabel.Text = Convert.ToString(expBarTotalLevel);
                        expBar3.Foreground = getColorFromClassIndex(selectedClassIndex);
                        RefreshLevel(selectedClassIndex, expBar3.Minimum);
                    }
                }
                // selectedClassesList.Items.Add(new SelectedClassesData() { Title = getClassTitleFromIndex(selectedClassIndex),
                //    Level = Convert.ToString(expBar3.Minimum)});//, Completion = Convert.ToInt32(expBar3.Minimum) });
                expBar3.Width = 50 * (expBar3.Minimum + expBar2.Minimum + expBar1.Minimum);
            }
            else
            {
                ProgressBar newBar = expBar1;
                if (expBar1.Minimum == 0)
                {
                    newBar = expBar1;
                    newBar.Minimum = cmbLevels.SelectedIndex + 1;
                    expBarTotalLevel = newBar.Minimum;
                }
                else if (expBar2.Minimum == 0)
                {
                    newBar = expBar2;
                    newBar.Minimum = cmbLevels.SelectedIndex + 1;
                    expBarTotalLevel = newBar.Minimum + expBar1.Minimum;
                }
                else if (expBar3.Minimum == 0)
                {
                    newBar = expBar3;
                    newBar.Minimum = cmbLevels.SelectedIndex + 1;
                    expBarTotalLevel = newBar.Minimum + expBar1.Minimum + expBar2.Minimum;
                }
                expBarLabel.Text = Convert.ToString(expBarTotalLevel);
                newBar.Foreground = getColorFromClassIndex(selectedClassIndex);
                selectedClassesList.Items.Add(new SelectedClassesData()
                {
                    Title = getClassTitleFromIndex(selectedClassIndex),
                    Level = Convert.ToString(newBar.Minimum)
                });//, Completion = Convert.ToInt32(newBar.Minimum) });
                newBar.Width = 50 * expBarTotalLevel;
                selectedClassesList.Items.Refresh();
            }
        }
        private void RemoveExpBar(int selectedClassIndex)
        {
            if (selectedClassIndex == getClassIndexFromColor(expBar1))
            {
                expBar1.Minimum = expBar2.Minimum;
                expBar1.Width = 50 * expBar1.Minimum;
                expBar1.Foreground = expBar2.Foreground;
                expBar2.Minimum = expBar3.Minimum;
                expBar2.Width = expBar1.Width + (50 * expBar2.Minimum);
                expBar2.Foreground = expBar3.Foreground;
                expBar3.Minimum = 0;
                expBar3.Width = 0;
                expBar3.Foreground = getColorFromClassIndex(99);
                expBarLabel.Text = Convert.ToString(expBar1.Minimum + expBar2.Minimum);
            }
            else if (selectedClassIndex == getClassIndexFromColor(expBar2))
            {
                expBar2.Minimum = expBar3.Minimum;
                expBar2.Width = expBar1.Width + (50 * expBar2.Minimum);
                expBar2.Foreground = expBar3.Foreground;
                expBar3.Minimum = 0;
                expBar3.Width = 0;
                expBar3.Foreground = getColorFromClassIndex(99);
                expBarLabel.Text = Convert.ToString(expBar1.Minimum + expBar2.Minimum);
            }
            else if (selectedClassIndex == getClassIndexFromColor(expBar3))
            {
                expBar3.Minimum = 0;
                expBar3.Width = 0;
                expBar3.Foreground = getColorFromClassIndex(99);
                expBarLabel.Text = Convert.ToString(expBar1.Minimum + expBar2.Minimum);
            }
        }
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            foreach (SelectedClassesData eachItem in selectedClassesList.SelectedItems)
            {
                if (eachItem.Title == "Barbarian")
                {
                    RemoveExpBar(1);
                }
                else if (eachItem.Title == "Cleric")
                {
                    RemoveExpBar(2);
                }
                else if (eachItem.Title == "Rogue")
                {
                    RemoveExpBar(3);
                }
                selectedClassesList.Items.Remove(eachItem);
                break;
            }
            selectedClassesList.Items.Refresh();
        }
        private string getClassTitleFromIndex(int currBar)
        {
            string classTitle = "";
            switch (currBar)
            {
                case 1:
                    classTitle = "Barbarian";
                    break;
                case 2:
                    classTitle = "Cleric";
                    break;
                case 3:
                    classTitle = "Rogue";
                    break;
                default:
                    break;
            }
            return classTitle;
        }
        private void RefreshLevel(int currClass, double currLevel)
        {
            foreach (SelectedClassesData item in selectedClassesList.Items)
            {
                if (item.Title.Equals("Barbarian"))
                {
                    if (currClass == 1)
                    {
                        item.Level = Convert.ToString(currLevel);
                    }
                }
                else if (item.Title.Equals("Cleric"))
                {
                    if (currClass == 2)
                    {
                        item.Level = Convert.ToString(currLevel);
                    }
                }
                else if (item.Title.Equals("Rogue"))
                {
                    if (currClass == 3)
                    {
                        item.Level = Convert.ToString(currLevel);
                    }
                }
            }
            selectedClassesList.Items.Refresh();
        }
        private int getClassIndexFromColor(ProgressBar i)
        {
            int classIndex = 0;
            string barColor;
            barColor = i.Foreground.ToString();
            switch (barColor)
            {
                case "#FFFF0000":
                    classIndex = 1;
                    break;
                case "#FF0000FF":
                    classIndex = 2;
                    break;
                case "#FF696969":
                    classIndex = 3;
                    break;
                default:
                    break;
            }

            return classIndex;
        }
        private SolidColorBrush getColorFromClassIndex(int index)
        {

            SolidColorBrush classColor;
            switch (index)
            {
                case 1:
                    classColor = new SolidColorBrush(Colors.Red);
                    break;
                case 2:
                    classColor = new SolidColorBrush(Colors.Blue);
                    break;
                case 3:
                    classColor = new SolidColorBrush(Colors.DimGray);
                    break;
                case 99:
                    classColor = new SolidColorBrush(Colors.Green);
                    break;
                default:
                    classColor = new SolidColorBrush(Colors.Yellow);
                    break;
            }
            return classColor;
        }

    }

}
