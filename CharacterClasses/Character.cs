using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Character
    {
        //Verweise
        public Appearance Appearance { get; set; }
        public Attributes Attributes { get; set; }
        public Skills Skills { get; set; }
        public SavingThrows SavingThrows { get; set; }
        public TraitList TraitList { get; set; }
        public SpellList SpellList { get; set; }
        public Inventory Inventory { get; set; }

        //Konstruktor
        public Character()
        {
            Appearance = new Appearance();
            Attributes = new Attributes(this);
            Skills = new Skills(this);
            SavingThrows = new SavingThrows();
            TraitList = new TraitList();
            SpellList = new SpellList();
            Inventory = new Inventory();
        }

        //Eigenschaften
        public String CharacterName { get; set; }
        public String Class { get; set; }
        public UInt16 Level { get; set; }
        public String PlayerName { get; set; }
        public String Background { get; set; }
        public String Race { get; set; }
        public String SubRace { get; set; }
        public UInt64 ExperiencePoints { get; set; }
        public UInt16 Age { get; set; }
        public String Faction { get; set; }
        public String Alignment { get; set; }

        public static Character Current { get; set; }
        public static void New()
        {
            Current = new Character();
        }
        public static void Load(String characterName)
        {
            
        }
        public static void Save()
        {

        }
    }
}