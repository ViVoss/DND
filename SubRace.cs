using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class SubRace
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("race")]
        public Rac Race { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("ability_bonuses")]
        public List<AbilityBonus> AbilityBonuses { get; set; }

        [JsonProperty("starting_proficiencies")]
        public List<object> StartingProficiencies { get; set; }

        [JsonProperty("languages")]
        public List<object> Languages { get; set; }

        [JsonProperty("racial_traits")]
        public List<Rac> RacialTraits { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Rac
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class SubRace
    {
        public static SubRace FromJson(string json) => JsonConvert.DeserializeObject<SubRace>(json, DND.Converter.Settings);
    }
}