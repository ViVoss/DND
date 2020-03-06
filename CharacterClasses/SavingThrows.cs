using MongoDB.Bson.Serialization.Attributes;
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
        [BsonIgnore]
        public Character Character { get; set; }

        //Eigenschaften
        [BsonElement("strengthproficiency")]
        public Boolean StrengthProficiency { get; set; }

        [BsonIgnore]
        public Int32 Strength
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, StrengthProficiency);
            }
        }

        [BsonElement("dexterityproficiency")]
        public Boolean DexterityProficiency { get; set; }

        [BsonIgnore]
        public Int32 Dexterity
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, DexterityProficiency);
            }
        }

        [BsonElement("constitutionproficiency")]
        public Boolean ConstitutionProficiency { get; set; }

        [BsonIgnore]
        public Int32 Constitution
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, ConstitutionProficiency);
            }
        }

        [BsonElement("intelligenceproficiency")]
        public Boolean IntelligenceProficiency { get; set; }

        [BsonIgnore]
        public Int32 Intelligence
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, IntelligenceProficiency);
            }
        }

        [BsonElement("wisdonproficiency")]
        public Boolean WisdonProficiency { get; set; }

        [BsonIgnore]
        public Int32 Wisdon
        {
            get
            {
                return CalculateSavingThrow(Character.Attributes.StrengthModifier, WisdonProficiency);
            }
        }

        [BsonElement("charismaproficiency")]
        public Boolean CharismaProficiency { get; set; }

        [BsonIgnore]
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
