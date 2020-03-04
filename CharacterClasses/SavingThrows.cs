using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class SavingThrows
    {
        //Verweise
        public Character Character { get; set; }

        //Eigenschaften
        public Boolean StrengthProficiency { get; set; }
        public Int32 Strength
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, StrengthProficiency);
            }
        }

        public Boolean DexterityProficiency { get; set; }
        public Int32 Dexterity
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, DexterityProficiency);
            }
        }
        public Boolean ConstitutionProficiency { get; set; }
        public Int32 Constitution
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, ConstitutionProficiency);
            }
        }
        public Boolean IntelligenceProficiency { get; set; }
        public Int32 Intelligence
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, IntelligenceProficiency);
            }
        }
        public Boolean WisdonProficiency { get; set; }
        public Int32 Wisdon
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, WisdonProficiency);
            }
        }
        public Boolean CharismaProficiency { get; set; }
        public Int32 Charisma
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, CharismaProficiency);
            }
        }


        //Private Methoden
        private Int32 CalculateSavingThrow(Int16 modifier, Boolean proficiency)
        {
            if (proficiency)
            {
                return modifier + Character.Attributes.ProficiencyBonus;
            }
            else return modifier;
        }
    }
}
