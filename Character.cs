﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Character
    {
        //Verweise
        public Attributes Attributes { get; set; }
        public Appearance Appearance { get; set; }
        public Skills Skills { get; set; }

        //Eigenschaften
        public String CharacterName { get; set; }
        public String Class { get; set; }
        public UInt16 Level { get; set; }
        public String PlayerName { get; set; }
        public String Background { get; set; }
        public String Race { get; set; }
        public UInt64 ExperiencePoints { get; set; }
        public UInt16 Age { get; set; }
        public String Faction { get; set; }
        public String Alignment { get; set; }

        //Konstruktor
        public Character()
        {
            Attributes = new Attributes(this);
            Appearance = new Appearance();
            Skills = new Skills(this);
        }
    }
}
