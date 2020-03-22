using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    public class DnDInformation
    {
        StringBuilder builder = new StringBuilder();
        private string requestParameter;
        public string GetRaceInformation(string rasse)
        {
            builder.Clear();
            WebAufruf<Rasse> webAufruf = new WebAufruf<Rasse>();
            requestParameter = "races/" + rasse;
            Rasse race = webAufruf.GetJsonResponse(requestParameter);

            builder.Append("Ability Score Increase: ");
            foreach (AbilityBonus abilityBonus in race.AbilityBonuses)
            {
                if (abilityBonus.Equals(race.AbilityBonuses.Last()))
                {
                    builder.Append(abilityBonus.Name + " + " + abilityBonus.Bonus);
                }
                else
                {
                    builder.Append(abilityBonus.Name + ", ");
                }
            }

            builder.Append("\n\nAge: " + race.Age);
            builder.Append("\n\nAlignment: " + race.Alignment);
            builder.Append("\n\nSize: " + race.SizeDescription);

            builder.Append("\n\nTraits: ");
            foreach (Trait trait in race.Traits)
            {
                if (trait.Equals(race.Traits.Last()))
                {
                    builder.Append(trait.Name);
                }
                else
                {
                    builder.Append(trait.Name + ", ");
                }
            }

            builder.Append("\n\nSpeed: " + race.Speed + "ft.");

            builder.Append("\n\nLanguages: ");
            foreach (Language language in race.Languages)
            {
                if (language.Equals(race.Languages.Last()))
                {
                    builder.Append(language.Name);
                }
                else
                {
                    builder.Append(language.Name + ", ");
                }
            }

            builder.Append("\n\nSubraces: ");
            foreach (SubRace subRace in race.Subraces)
            {
                if (subRace.Equals(race.Subraces.Last()))
                {
                    builder.Append(subRace.Name);
                }
                else
                {
                    builder.Append(subRace.Name + ", ");
                }
            }

            return builder.ToString();
        }

        public string GetSubRaceInformation(string subrasse)
        {
            builder.Clear();
            WebAufruf<SubRace> webAufruf = new WebAufruf<SubRace>();
            requestParameter = "subraces/" + subrasse;
            SubRace subrace = webAufruf.GetJsonResponse(requestParameter);

            builder.Append(subrace.Desc);
            builder.Append("\n\nAbility Score Increase: " + subrace.AbilityBonuses);
            builder.Append("\n\nStarting Proficiences: " + subrace.StartingProficiencies);
            builder.Append("\n\nLanguages: " + subrace.Languages);
            builder.Append("\n\nRacial Traits: " + subrace.RacialTraits);

            return builder.ToString();
        }

        public string GetClassInformation(string klasse)
        {
            builder.Clear();
            WebAufruf<Klasse> webAufruf = new WebAufruf<Klasse>();
            requestParameter = "classes/" + klasse;
            Klasse clazz = webAufruf.GetJsonResponse(requestParameter);

            builder.Append("Hit Points:" + "\n\n");
            builder.Append("Hit Dice: 1d" + clazz.HitDie + " per " + klasse + " level\n\n");
            builder.Append("Hit Points at 1st Level: " + clazz.HitDie + " + your Constitution modifier\n\n");
            builder.Append("Hit Points at Higher Levels: " + "1d" + clazz.HitDie + " (or " + ((clazz.HitDie / 2) + 1) + ") + your Constitution modifier per " + klasse + " lever after 1st\n\n");

            builder.Append("Proficiencies: ");
            foreach (Proficiency prof in clazz.Proficiencies)
            {
                if (prof.Equals(clazz.Proficiencies.Last()))
                {
                    builder.Append(prof.Name);
                }
                else
                {
                    builder.Append(prof.Name + ", ");
                }
            }

            builder.Append("\n\nSaving Throws: ");
            foreach (Proficiency saveThr in clazz.SavingThrows)
            {
                if (saveThr.Equals(clazz.SavingThrows.Last()))
                {
                    builder.Append(saveThr.Name);
                }
                else
                {
                    builder.Append(saveThr.Name + ", ");
                }
            }

            foreach (ProficiencyChoice skills in clazz.ProficiencyChoices)
            {
                builder.Append("\n\nChoose " + skills.Choose + " from: ");
                foreach (Proficiency prof in skills.From)
                {
                    string skillsStr = prof.Name;
                    skillsStr = skillsStr.Replace("Skill: ", "");

                    if (prof.Equals(skills.From.Last()))
                    {
                        builder.Append(skillsStr);
                    }
                    else
                    {
                        builder.Append(skillsStr + ", ");
                    }
                }
            }


            builder.Append(clazz.StartingEquipment);

            return builder.ToString();
        }

        //public String BackgroundInformation
    }
}
