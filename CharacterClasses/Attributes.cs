using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Attributes
    {
        //Verweise
        public Character Character { get; set; }

        //Eigenschaften
        public UInt16 Strength { get; set; }
        public Int16 StrengthModifier
        {
            get
            {
                return CalculateModifier(Strength);
            }
        }
        public UInt16 Dexterity { get; set; }
        public Int16 DexterityModifier
        {
            get
            {
                return CalculateModifier(Dexterity);
            }
        }
        public UInt16 Constitution { get; set; }
        public Int16 ConstitutionModifier
        {
            get
            {
                return CalculateModifier(Constitution);
            }
        }
        public UInt16 Intelligence { get; set; }
        public Int16 IntelligenceModifier
        {
            get
            {
                return CalculateModifier(Intelligence);
            }
        }
        public UInt16 Wisdon { get; set; }
        public Int16 WisdonModifier
        {
            get
            {
                return CalculateModifier(Wisdon);
            }
        }
        public UInt16 Charisma { get; set; }
        public Int16 CharismaModifier
        {
            get
            {
                return CalculateModifier(Charisma); 
            }
        }

        public UInt16 ProficiencyBonus
        {
            get
            {
                UInt16 lvl = Character.Level;
                if (lvl >= 1 && lvl <= 4)
                {
                    return 2;
                }
                else if (lvl >= 5 && lvl <= 8)
                {
                    return 3;
                }
                else if (lvl >= 9 && lvl <= 12)
                {
                    return 4;
                }
                else if (lvl >= 13 && lvl <= 16)
                {
                    return 5;
                }
                else if (lvl >= 17 && lvl <= 20)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        public Int16 CalculateModifier(UInt16 attributeValue)
        {
            switch (attributeValue)
            {
                case 0:
                    return -5;
                case 1:
                    return -5;
                case 2:
                    return -4;
                case 3:
                    return -4;
                case 4:
                    return -3;
                case 5:
                    return -3;
                case 6:
                    return -2;
                case 7:
                    return -2;
                case 8:
                    return -1;
                case 9:
                    return -1;
                case 10:
                    return 0;
                case 11:
                    return 0;
                case 12:
                    return 1;
                case 13:
                    return 1;
                case 14:
                    return 2;
                case 15:
                    return 2;
                case 16:
                    return 3;
                case 17:
                    return 3;
                case 18:
                    return 4;
                case 19:
                    return 4;
                case 20:
                    return 5;
                default:
                    return Int16.MinValue;
            }
        }

        //Konstruktor
        public Attributes(Character character)
        {
            this.Character = character;
        }
    }
}
