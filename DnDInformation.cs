﻿using Newtonsoft.Json;
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
        private int index;
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

            if (race.Traits.Count() > 0)
            {
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

                switch(rasse)
                {
                    case "dwarf":
                        builder.Append(", Mountain Dwarf");
                        break;
                    case "elf":
                        builder.Append(", Dark Elf (Drow)");
                        builder.Append(", Wood elf");
                        break;
                    case "halfling":
                        builder.Append(", Stout Halfling");
                        break;
                    case "gnome":
                        builder.Append(", Forest Gnome");
                        break;
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
            
            if (subrace.AbilityBonuses.Count() > 0)
            {
                builder.Append("\n\nAbility Score Increase: ");
                foreach (AbilityBonus abilityBonus in subrace.AbilityBonuses)
                {
                    if (abilityBonus.Equals(subrace.AbilityBonuses.Last()))
                    {
                        builder.Append(abilityBonus.Name + " + " + abilityBonus.Bonus);
                    }
                    else
                    {
                        builder.Append(abilityBonus.Name + ", ");
                    }
                }
            }
            
            if (subrace.StartingProficiencies.Count() > 0)
            {
                builder.Append("\n\nStarting Proficiences: ");
                foreach (StartingProficiency startingProficiency in subrace.StartingProficiencies)
                {
                    if (startingProficiency.Equals(subrace.StartingProficiencies.Last()))
                    {
                        builder.Append(startingProficiency.Name);
                    }
                    else
                    {
                        builder.Append(startingProficiency.Name + ", ");
                    }
                }
            }

            if (subrace.Languages.Count() > 0)
            {
                builder.Append("\n\nLanguages: ");
                foreach (Language lang in subrace.Languages)
                {
                    if (lang.Equals(subrace.Languages.Last()))
                    {
                        builder.Append(lang.Name);
                    }
                    else
                    {
                        builder.Append(lang.Name + ", ");
                    }
                }
            }

            //if (subrace.GetType().GetProperty("LanguageOptions") != null)
            //{
            //    builder.Append("\n\nLanguages Options: Choose " + subrace.LanguageOptions?.Choose + " from: ");
            //    foreach (From lang in subrace.LanguageOptions?.From)
            //    {
            //        if (lang.Equals(subrace.LanguageOptions.From.Last()))
            //        {
            //            builder.Append(lang.Name);
            //        }
            //        else
            //        {
            //            builder.Append(lang.Name + ", ");
            //        }
            //    }
            //}

            if (subrace.RacialTraits.Count() > 0)
            {
                builder.Append("\n\nRacial Traits: ");
                foreach (Rac racialTrait in subrace.RacialTraits)
                {
                    if (racialTrait.Equals(subrace.RacialTraits.Last()))
                    {
                        builder.Append(racialTrait.Name);
                    }
                    else
                    {
                        builder.Append(racialTrait.Name + ", ");
                    }
                }
            }

            //if (subrace.GetType().GetProperty("RacialTraitOptions") != null)
            //{
            //    builder.Append("\n\nRacial Trait Options: Choose " + subrace.RacialTraitOptions?.Choose + "from: ");
            //    foreach (From racialTraitOptions in subrace.RacialTraitOptions?.From)
            //    {
            //        if (racialTraitOptions.Equals(subrace.RacialTraitOptions.From.Last()))
            //        {
            //            builder.Append(racialTraitOptions.Name);
            //        }
            //        else
            //        {
            //            builder.Append(racialTraitOptions.Name + ", ");
            //        }
            //    }
            //}

            return builder.ToString();
        }

        public string GetSubraceDbInformation(string subrasse)
        {
            builder.Clear();

            MongoConnection<SubRace> mongoConnection = new MongoConnection<SubRace>();
            SubRace subrace = mongoConnection.GetDocumentByIndex("Subrace", subrasse);

            builder.Append(subrace.Desc);

            if (subrace.AbilityBonuses.Count() > 0)
            {
                builder.Append("\n\nAbility Score Increase: ");
                foreach (AbilityBonus abilityBonus in subrace.AbilityBonuses)
                {
                    if (abilityBonus.Equals(subrace.AbilityBonuses.Last()))
                    {
                        builder.Append(abilityBonus.Name + " + " + abilityBonus.Bonus);
                    }
                    else
                    {
                        builder.Append(abilityBonus.Name + ", ");
                    }
                }
            }

            if (subrace.StartingProficiencies.Count() > 0)
            {
                builder.Append("\n\nStarting Proficiences: ");
                foreach (StartingProficiency startingProficiency in subrace.StartingProficiencies)
                {
                    if (startingProficiency.Equals(subrace.StartingProficiencies.Last()))
                    {
                        builder.Append(startingProficiency.Name);
                    }
                    else
                    {
                        builder.Append(startingProficiency.Name + ", ");
                    }
                }
            }

            if (subrace.Languages.Count() > 0)
            {
                builder.Append("\n\nLanguages: ");
                foreach (Language lang in subrace.Languages)
                {
                    if (lang.Equals(subrace.Languages.Last()))
                    {
                        builder.Append(lang.Name);
                    }
                    else
                    {
                        builder.Append(lang.Name + ", ");
                    }
                }
            }

            //if (subrace.GetType().GetProperty("LanguageOptions") != null)
            //{
            //    builder.Append("\n\nLanguages Options: Choose " + subrace.LanguageOptions?.Choose + " from: ");
            //    foreach (From lang in subrace.LanguageOptions?.From)
            //    {
            //        if (lang.Equals(subrace.LanguageOptions.From.Last()))
            //        {
            //            builder.Append(lang.Name);
            //        }
            //        else
            //        {
            //            builder.Append(lang.Name + ", ");
            //        }
            //    }
            //}

            if (subrace.RacialTraits.Count() > 0)
            {
                builder.Append("\n\nRacial Traits: ");
                foreach (Rac racialTrait in subrace.RacialTraits)
                {
                    if (racialTrait.Equals(subrace.RacialTraits.Last()))
                    {
                        builder.Append(racialTrait.Name);
                    }
                    else
                    {
                        builder.Append(racialTrait.Name + ", ");
                    }
                }
            }

            //if (subrace.GetType().GetProperty("RacialTraitOptions") != null)
            //{
            //    builder.Append("\n\nRacial Trait Options: Choose " + subrace.RacialTraitOptions?.Choose + "from: ");
            //    foreach (From racialTraitOptions in subrace.RacialTraitOptions?.From)
            //    {
            //        if (racialTraitOptions.Equals(subrace.RacialTraitOptions.From.Last()))
            //        {
            //            builder.Append(racialTraitOptions.Name);
            //        }
            //        else
            //        {
            //            builder.Append(racialTraitOptions.Name + ", ");
            //        }
            //    }
            //}

            return builder.ToString();
        }

        public string GetClassInformation(string klasse)
        {
            builder.Clear();
            WebAufruf<Klasse> webAufruf = new WebAufruf<Klasse>();
            WebAufruf<StartingEquipment> webAufruf1 = new WebAufruf<StartingEquipment>();

            requestParameter = "classes/" + klasse;
            Klasse clazz = webAufruf.GetJsonResponse(requestParameter);

            foreach (int enumVal in Enum.GetValues(typeof(EnumKlasse)))
            {
                if (klasse.Equals(Enum.GetName(typeof(EnumKlasse), enumVal)))
                {
                    index = enumVal;
                }
            }

            requestParameter = "starting-equipment/" + index;
            StartingEquipment startingEquipment = webAufruf1.GetJsonResponse(requestParameter);

            builder.Append("Hit Points: ");
            builder.Append("\n\nHit Dice: 1d" + clazz.HitDie + " per " + klasse + " level.");
            builder.Append("\n\nHit Points at 1st Level: " + clazz.HitDie + " + your constitution modifier.");
            builder.Append("\n\nHit Points at Higher Levels: " + "1d" + clazz.HitDie + " (or " + ((clazz.HitDie / 2) + 1) + ") + your Constitution modifier per " + klasse + " lever after 1st.");

            builder.Append("\n\nProficiencies: ");
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

            builder.Append("\n\nStarting Equipment: ");
            foreach (StartingEquipmentElement startingEquipmentElement in startingEquipment.StartingEquipmentElement)
            {
                if (startingEquipmentElement.Equals(startingEquipment.StartingEquipmentElement.Last()))
                {
                    builder.Append(startingEquipmentElement.Quantity + " " + startingEquipmentElement.Item.Name);
                }
                else
                {
                    builder.Append(startingEquipmentElement.Quantity + " " + startingEquipmentElement.Item.Name + ", ");
                }
            }

            builder.Append("\n\nChoices to make: " + startingEquipment.ChoicesToMake);

            if (startingEquipment.GetType().GetProperty("Choice") != null)
            {
                builder.Append("\n\nChoice 1:");
                foreach (Choice choice in startingEquipment.Choice ?? new List<Choice>())
                {
                    builder.Append("\nChoose " + choice.Choose + " from: ");
                    foreach (StartingEquipmentElement from in choice.From)
                    {
                        if (from.Equals(choice.From.Last()))
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name);
                        }
                        else
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name + ", ");
                        }
                    }
                }
            }

            
            if (startingEquipment.GetType().GetProperty("Choice2") != null)
            {
                builder.Append("\n\nChoice 2:");
                foreach (Choice choice in startingEquipment.Choice2 ?? new List<Choice>())
                {
                    builder.Append("\nChoose " + choice.Choose + " from: ");
                    foreach (StartingEquipmentElement from in choice.From)
                    {
                        if (from.Equals(choice.From.Last()))
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name);
                        }
                        else
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name + ", ");
                        }
                    }
                }
            }

            if (startingEquipment.GetType().GetProperty("Choice3") != null)
            {
                builder.Append("\n\nChoice 3:");
                foreach (Choice choice in startingEquipment.Choice3 ?? new List<Choice>())
                {
                    builder.Append("\nChoose " + choice.Choose + " from: ");
                    foreach (StartingEquipmentElement from in choice.From)
                    {
                        if (from.Equals(choice.From.Last()))
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name);
                        }
                        else
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name + ", ");
                        }
                    }
                }
            }

            if (startingEquipment.GetType().GetProperty("Choice4") != null)
            {
                builder.Append("\n\nChoice 4:");
                foreach (Choice choice in startingEquipment.Choice4 ?? new List<Choice>())
                {
                    builder.Append("\nChoose " + choice.Choose + " from: ");
                    foreach (StartingEquipmentElement from in choice.From)
                    {
                        if (from.Equals(choice.From.Last()))
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name);
                        }
                        else
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name + ", ");
                        }
                    }
                }
            }

            if (startingEquipment.GetType().GetProperty("Choice5") != null)
            {
                builder.Append("\n\nChoice 5:");
                foreach (Choice choice in startingEquipment.Choice5 ?? new List<Choice>())
                {
                    builder.Append("\nChoose " + choice.Choose + " from: ");
                    foreach (StartingEquipmentElement from in choice.From)
                    {
                        if (from.Equals(choice.From.Last()))
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name);
                        }
                        else
                        {
                            builder.Append(from.Quantity + " " + from.Item.Name + ", ");
                        }
                    }
                }
            }

            return builder.ToString();
        }

        public string GetBackgroundInformation(string hintergrund)
        {
            builder.Clear();
            MongoConnection<Background> mongoConnection = new MongoConnection<Background>();
            Background background = mongoConnection.GetDocumentByIndex("Background", hintergrund);

            if (background.SkillProficiences.Count() > 0)
            {
                builder.Append("Skill Proficiences: ");
                foreach (string prof in background.SkillProficiences)
                {
                    if (prof.Equals(background.SkillProficiences.Last()))
                    {
                        builder.Append(prof);
                    }
                    else
                    {
                        builder.Append(prof + ", ");
                    }
                }
            }

            if (background.ToolProficiences.Count() > 0)
            {
                builder.Append("\n\nTool Proficiences: ");
                foreach (string prof in background.ToolProficiences)
                {
                    if (prof.Equals(background.ToolProficiences.Last()))
                    {
                        builder.Append(prof);
                    }
                    else
                    {
                        builder.Append(prof + ", ");
                    }
                }
            }

            if (background.Languages.Count() > 0)
            {
                builder.Append("\n\nLanguages: " + background.Languages);
                foreach (string lang in background.Languages)
                {
                    if (lang.Equals(background.Languages.Last()))
                    {
                        builder.Append(lang);
                    }
                    else
                    {
                        builder.Append(lang + ", ");
                    }
                }
            }

            if (background.LanguageOptions.Choose > 0)
            {
                builder.Append("\n\nLanguage Options: Choose " + background.LanguageOptions.Choose + " from: ");
                foreach (string lang in background.LanguageOptions.From)
                {
                    if (lang.Equals(background.Equipment.Last()))
                    {
                        builder.Append(lang);
                    }
                    else
                    {
                        builder.Append(lang + ", ");
                    }
                }
            }

            if (background.Equipment.Count() > 0)
            {
                builder.Append("\n\nEquipment: ");
                foreach (string equip in background.Equipment)
                {
                    if (equip.Equals(background.Equipment.Last()))
                    {
                        builder.Append(equip);
                    }
                    else
                    {
                        builder.Append(equip + ", ");
                    }
                }
            }

            if (background.EquipmentOptions.Choose > 0)
            {
                builder.Append("\n\nEquipment Options: Choose " + background.EquipmentOptions.Choose + " from: ");
                foreach (string equip in background.EquipmentOptions.From)
                {
                    if (equip.Equals(background.Equipment.Last()))
                    {
                        builder.Append(equip);
                    }
                    else
                    {
                        builder.Append(equip + ", ");
                    }
                }
            }

            if (background.Feature.Count() > 0)
            {
                builder.Append("\n\nFeature: ");
                foreach (string feat in background.Feature)
                {
                    if (feat.Equals(background.Feature.Last()))
                    {
                        builder.Append(feat);
                    }
                    else
                    {
                        builder.Append(feat + ", ");
                    }
                }
            }

            return builder.ToString();
        }

        public List<Spells> GetSpellsInformation()
        {
            List<Spells> spellList = new List<Spells>();

            WebAufruf<SpellsCollection> webAufruf = new WebAufruf<SpellsCollection>();
            SpellsCollection spells =  webAufruf.GetJsonResponse("spells");

            foreach (Result result in spells.Results)
            {
                WebAufruf<Spells> webAufruf1 = new WebAufruf<Spells>();
                requestParameter = "spells/" + result.Index;
                Spells spell = webAufruf1.GetJsonResponse(requestParameter);

                spellList.Add(new Spells()
                {
                    Name = spell.Name,
                    Desc = spell.Desc,
                    HigherLevel = spell.HigherLevel,
                    Range = spell.Range,
                    Material = spell.Material,
                    Ritual = spell.Ritual,
                    Duration = spell.Duration,
                    Concentration = spell.Concentration,
                    CastingTime = spell.CastingTime,
                    Level = spell.Level
                });
                
            }
            
            return spellList;
        }

    }
}