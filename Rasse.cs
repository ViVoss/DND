using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class Rasse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("speed")]
        public long Speed { get; set; }

        [JsonProperty("ability_bonuses")]
        public List<AbilityBonus> AbilityBonuses { get; set; }

        [JsonProperty("alignment")]
        public string Alignment { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("size_description")]
        public string SizeDescription { get; set; }

        [JsonProperty("starting_proficiencies")]
        public List<Language> StartingProficiencies { get; set; }

        [JsonProperty("starting_proficiency_options")]
        public StartingProficiencyOptions StartingProficiencyOptions { get; set; }

        [JsonProperty("languages")]
        public List<Language> Languages { get; set; }

        [JsonProperty("language_desc")]
        public string LanguageDesc { get; set; }

        [JsonProperty("traits")]
        public List<Trait> Traits { get; set; }

        [JsonProperty("subraces")]
        public List<SubRace> Subraces { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Trait
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class AbilityBonus
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("bonus")]
        public long Bonus { get; set; }
    }

    public partial class Language
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class StartingProficiencyOptions
    {
        [JsonProperty("choose")]
        public long Choose { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public List<Proficiency> From { get; set; }
    }

    public partial class Rasse
    {
        public static Rasse FromJson(string json) => JsonConvert.DeserializeObject<Rasse>(json, Converter.Settings);
    }
}
