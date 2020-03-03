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
        public Character Character { get; set; }

        //Eigenschaften
        public Boolean AcrobaticsProficiency { get; set; }
        public Boolean AcrobaticsExpertise { get; set; }
        public Int32 Acrobatics { 
            get
            {
                return CalculateSkillBonus(Character.Attributes.DexterityModifier, AcrobaticsProficiency, AcrobaticsExpertise);
            } 
        }

        public Boolean AnimalHandlingProficiency { get; set; }
        public Boolean AnimalHandlingExpertise { get; set; }
        public Int32 AnimalHandling
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, AnimalHandlingProficiency, AnimalHandlingExpertise);
            }
        }

        public Boolean ArcanaProficiency { get; set; }
        public Boolean ArcanaExpertise { get; set; }
        public Int32 Arcana
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, ArcanaProficiency, ArcanaExpertise);
            }
        }

        public Boolean AthleticsProficiency { get; set; }
        public Boolean AthleticsExpertise { get; set; }
        public Int32 Athletics
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.StrengthModifier, AthleticsProficiency, AthleticsExpertise);
            }
        }

        public Boolean DeceptionProficiency { get; set; }
        public Boolean DeceptionExpertise { get; set; }
        public Int32 Deception
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, DeceptionProficiency, DeceptionExpertise);
            }
        }

        public Boolean HistoryProficiency { get; set; }
        public Boolean HistoryExpertise { get; set; }
        public Int32 History
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, HistoryProficiency, HistoryExpertise);
            }
        }

        public Boolean InsightProficiency { get; set; }
        public Boolean InsightExpertise { get; set; }
        public Int32 Insight
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, InsightProficiency, InsightExpertise);
            }
        }

        public Boolean IntimidationProficiency { get; set; }
        public Boolean IntimidationExpertise { get; set; }
        public Int32 Intimidation
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, IntimidationProficiency, IntimidationExpertise);
            }
        }

        public Boolean InvestigationProficiency { get; set; }
        public Boolean InvestigationExpertise { get; set; }
        public Int32 Investigation
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, InvestigationProficiency, InvestigationExpertise);
            }
        }

        public Boolean MedicineProficiency { get; set; }
        public Boolean MedicineExpertise { get; set; }
        public Int32 Medicine
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, MedicineProficiency, MedicineExpertise);
            }
        }

        public Boolean NatureProficiency { get; set; }
        public Boolean NatureExpertise { get; set; }
        public Int32 Nature
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, NatureProficiency, NatureExpertise);
            }
        }

        public Boolean PerceptionProficiency { get; set; }
        public Boolean PerceptionExpertise { get; set; }
        public Int32 Perception
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.WisdonModifier, PerceptionProficiency, PerceptionExpertise);
            }
        }

        public Boolean PerformanceProficiency { get; set; }
        public Boolean PerformanceExpertise { get; set; }
        public Int32 Performance
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, PerformanceProficiency, PerformanceExpertise);
            }
        }

        public Boolean PersuasionProficiency { get; set; }
        public Boolean PersuasionExpertise { get; set; }
        public Int32 Persuasion
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.CharismaModifier, PersuasionProficiency, PersuasionExpertise);
            }
        }

        public Boolean ReligionProficiency { get; set; }
        public Boolean ReligionExpertise { get; set; }
        public Int32 Religion
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.IntelligenceModifier, ReligionProficiency, ReligionExpertise);
            }
        }

        public Boolean SleightOfHandProficiency { get; set; }
        public Boolean SleightOfHandExpertise { get; set; }
        public Int32 SleightOfHand
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.DexterityModifier, SleightOfHandProficiency, SleightOfHandExpertise);
            }
        }

        public Boolean StealthProficiency { get; set; }
        public Boolean StealthExpertise { get; set; }
        public Int32 Stealth
        {
            get
            {
                return CalculateSkillBonus(Character.Attributes.DexterityModifier, StealthProficiency, StealthExpertise);
            }
        }

        public Boolean SurvivalProficiency { get; set; }
        public Boolean SurvivalExpertise { get; set; }
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
