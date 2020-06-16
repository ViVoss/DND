using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class Klasse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hit_die")]
        public long HitDie { get; set; }

        [JsonProperty("proficiency_choices")]
        public List<ProficiencyChoice> ProficiencyChoices { get; set; }

        [JsonProperty("proficiencies")]
        public List<Proficiency> Proficiencies { get; set; }

        [JsonProperty("saving_throws")]
        public List<Proficiency> SavingThrows { get; set; }

        [JsonProperty("starting_equipment")]
        public ClassLevels StartingEquipment { get; set; }

        [JsonProperty("class_levels")]
        public ClassLevels ClassLevels { get; set; }

        [JsonProperty("subclasses")]
        public List<Proficiency> Subclasses { get; set; }

        [JsonProperty("spellcasting")]
        public ClassLevels Spellcasting { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class ClassLevels
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public partial class Proficiency
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class ProficiencyChoice
    {
        [JsonProperty("choose")]
        public long Choose { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public List<Proficiency> From { get; set; }
    }
    public partial class Klasse
    {
        public static Klasse FromJson(string json) => JsonConvert.DeserializeObject<Klasse>(json, DND.Converter.Settings);
    }
    public partial class ClassLevels
    {
        public static ClassLevels FromJson(string json) => JsonConvert.DeserializeObject<ClassLevels>(json, DND.Converter.Settings);
    }
}
