﻿using DND.Subraces;
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
    /// Interaktionslogik für Window_SubraceSelection.xaml
    /// </summary>
    public partial class Window_SubraceSelection : Window
    {
        public Creation Creation { get; set; }
        public string currRace { get; set; } 

        public Window_SubraceSelection(Creation CreationWindow, string currRace)
        {
            this.Creation = CreationWindow;
            InitializeComponent();
            Page test = null;
            switch (currRace)
            {
                case "Dwarf":
                    test = new Page_Subrace_Dwarf(Creation);
                    break;
                case "Elf":
                    test = new Page_Subrace_Elf();
                    this.Width = 540;
                    break;
                case "Halfling":
                    test = new Page_Subrace_Halfling();
                    break;
                case "Human":
                    test = new Page_Subrace_Human();
                    break;
                case "Dragonborn":
                    test = new Page_Subrace_Dragonborn();
                    break;
                case "Half-Elf":
                    test = new Page_Subrace_HalfElf();
                    break;
                case "Half-Orc":
                    test = new Page_Subrace_HalfOrc();
                    break;
                case "Tiefling":
                    test = new Page_Subrace_Tiefling();
                    break;
                case "Gnome":
                    test = new Page_Subrace_Gnome();
                    break;
                default:
                    break;
            }
            Frame_SubraceSelection.Content = test;
        }
    }
}