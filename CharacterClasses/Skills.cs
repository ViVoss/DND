using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Skills
    {
        //Verweise
        [BsonIgnore]
        public Character Character { get; set; }

        //Eigenschaften
        [BsonElement("acrobaticsproficiency")]
        public Boolean AcrobaticsProficiency { get; set; }
        [BsonElement("acrobaticsexpertise")]
        public Boolean AcrobaticsExpertise { get; set; }
        [BsonIgnore]
        public Int32 Acrobatics { 
            get
            {
                return CalculateSkillBonus(Character.Attributes.DexterityModifier, AcrobaticsProficiency, AcrobaticsExpertise);
            } 
        }

        [BsonElement("animalhandlingproficiency")]
        public Boolean AnimalHandlingProficiency { get; set; }
        [BsonElement("animalhandlingexpertise")]
        public Boolean AnimalHandlingExpertise { get; set; }
        [BsonIgnore]
        public Int32 AnimalHandling
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, AnimalHandlingProficiency, AnimalHandlingExpertise);
            }
        }

        [BsonElement("arcanaproficiency")]
        public Boolean ArcanaProficiency { get; set; }
        [BsonElement("arcanaexpertise")]
        public Boolean ArcanaExpertise { get; set; }
        [BsonIgnore]
        public Int32 Arcana
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, ArcanaProficiency, ArcanaExpertise);
            }
        }

        [BsonElement("athleticsproficiency")]
        public Boolean AthleticsProficiency { get; set; }
        [BsonElement("athleticsexpertise")]
        public Boolean AthleticsExpertise { get; set; }
        [BsonIgnore]
        public Int32 Athletics
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.StrengthModifier, AthleticsProficiency, AthleticsExpertise);
            }
        }

        [BsonElement("deceptionproficiency")]
        public Boolean DeceptionProficiency { get; set; }
        [BsonElement("deceptionexpertise")]
        public Boolean DeceptionExpertise { get; set; }
        [BsonIgnore]
        public Int32 Deception
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, DeceptionProficiency, DeceptionExpertise);
            }
        }

        [BsonElement("historyproficiency")]
        public Boolean HistoryProficiency { get; set; }
        [BsonElement("historyexpertise")]
        public Boolean HistoryExpertise { get; set; }
        [BsonIgnore]
        public Int32 History
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, HistoryProficiency, HistoryExpertise);
            }
        }

        [BsonElement("insightproficiency")]
        public Boolean InsightProficiency { get; set; }
        [BsonElement("insightexpertise")]
        public Boolean InsightExpertise { get; set; }
        [BsonIgnore]
        public Int32 Insight
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, InsightProficiency, InsightExpertise);
            }
        }

        [BsonElement("intimidationproficiency")]
        public Boolean IntimidationProficiency { get; set; }
        [BsonElement("intimidationexpertise")]
        public Boolean IntimidationExpertise { get; set; }
        [BsonIgnore]
        public Int32 Intimidation
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, IntimidationProficiency, IntimidationExpertise);
            }
        }

        [BsonElement("investigationproficiency")]
        public Boolean InvestigationProficiency { get; set; }
        [BsonElement("investigationexpertise")]
        public Boolean InvestigationExpertise { get; set; }
        [BsonIgnore]
        public Int32 Investigation
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, InvestigationProficiency, InvestigationExpertise);
            }
        }

        [BsonElement("medicineproficiency")]
        public Boolean MedicineProficiency { get; set; }
        [BsonElement("medicineexpertise")]
        public Boolean MedicineExpertise { get; set; }
        [BsonIgnore]
        public Int32 Medicine
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, MedicineProficiency, MedicineExpertise);
            }
        }

        [BsonElement("natureproficiency")]
        public Boolean NatureProficiency { get; set; }
        [BsonElement("natureexpertise")]
        public Boolean NatureExpertise { get; set; }
        [BsonIgnore]
        public Int32 Nature
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, NatureProficiency, NatureExpertise);
            }
        }

        [BsonElement("perceptionproficiency")]
        public Boolean PerceptionProficiency { get; set; }
        [BsonElement("perceptionexpertise")]
        public Boolean PerceptionExpertise { get; set; }
        [BsonIgnore]
        public Int32 Perception
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, PerceptionProficiency, PerceptionExpertise);
            }
        }

        [BsonElement("performanceproficiency")]
        public Boolean PerformanceProficiency { get; set; }
        [BsonElement("performanceexpertise")]
        public Boolean PerformanceExpertise { get; set; }
        [BsonIgnore]
        public Int32 Performance
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, PerformanceProficiency, PerformanceExpertise);
            }
        }

        [BsonElement("persuasionproficiency")]
        public Boolean PersuasionProficiency { get; set; }
        [BsonElement("persuasionexpertise")]
        public Boolean PersuasionExpertise { get; set; }
        [BsonIgnore]
        public Int32 Persuasion
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, PersuasionProficiency, PersuasionExpertise);
            }
        }

        [BsonElement("religionproficiency")]
        public Boolean ReligionProficiency { get; set; }
        [BsonElement("religionexpertise")]
        public Boolean ReligionExpertise { get; set; }
        [BsonIgnore]
        public Int32 Religion
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, ReligionProficiency, ReligionExpertise);
            }
        }

        [BsonElement("sleightofhandproficiency")]
        public Boolean SleightOfHandProficiency { get; set; }
        [BsonElement("sleightofhandexpertise")]
        public Boolean SleightOfHandExpertise { get; set; }
        [BsonIgnore]
        public Int32 SleightOfHand
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.DexterityModifier, SleightOfHandProficiency, SleightOfHandExpertise);
            }
        }

        [BsonElement("stealthproficiency")]
        public Boolean StealthProficiency { get; set; }
        [BsonElement("stealthexpertise")]
        public Boolean StealthExpertise { get; set; }
        [BsonIgnore]
        public Int32 Stealth
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.DexterityModifier, StealthProficiency, StealthExpertise);
            }
        }

        [BsonElement("survivalproficiency")]
        public Boolean SurvivalProficiency { get; set; }
        [BsonElement("survivalexpertise")]
        public Boolean SurvivalExpertise { get; set; }
        [BsonIgnore]
        public Int32 Survival
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, SurvivalProficiency, SurvivalExpertise);
            }
        }

        //Konstruktor
        public Skills(Character character)
        {
            this.Character = character;
        }

        //Private Methoden
        private Int32 CalculateSkillBonus(Int16 modifier, Boolean proficiency, Boolean expertise)
        {
            if (proficiency && expertise)
            {
                return modifier + Character.Attributes.ProficiencyBonus * 2;
            }
            else if (proficiency)
            {
                return modifier + Character.Attributes.ProficiencyBonus;
            }
            else return modifier;
        }
    }
}
