using System;
using System.Collections.Generic;
using System.Globalization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class SubRace
    {
        [BsonId]
        public ObjectId ID { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        [BsonElement("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        [JsonProperty("race")]
        [BsonElement("race")]
        public Rac Race { get; set; }

        [JsonProperty("desc")]
        [BsonElement("desc")]
        public string Desc { get; set; }

        [JsonProperty("ability_bonuses")]
        [BsonElement("ability_bonuses")]
        public List<AbilityBonus> AbilityBonuses { get; set; }

        [JsonProperty("starting_proficiencies")]
        [BsonElement("starting_proficiencies")]
        public List<StartingProficiency> StartingProficiencies { get; set; }

        [JsonProperty("languages")]
        [BsonElement("languages")]
        public List<Language> Languages { get; set; }

        [JsonProperty("language_options")]
        [BsonElement("language_options")]
        public LanguageOptions LanguageOptions { get; set; }

        [JsonProperty("racial_traits")]
        [BsonElement("racial_traits")]
        public List<Rac> RacialTraits { get; set; }

        [JsonProperty("racial_trait_options")]
        [BsonElement("racial_trait_options")]
        public RacialTraitOptions RacialTraitOptions { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Rac
    {
        [JsonProperty("url")]
        [BsonElement("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }
    }

    [BsonIgnoreExtraElements]
    public partial class StartingProficiency
    {
        [JsonProperty("url")]
        [BsonElement("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

    }

    [BsonIgnoreExtraElements]
    public partial class LanguageOptions
    {
        [JsonProperty("choose")]
        [BsonElement("choose")]
        public int Choose { get; set; }

        [JsonProperty("from")]
        [BsonElement("from")]
        public List<From> From { get; set; }

        [JsonProperty("type")]
        [BsonElement("type")]
        public string Type { get; set; }
    }


    [BsonIgnoreExtraElements]
    public partial class RacialTraitOptions
    {
        [JsonProperty("choose")]
        [BsonElement("choose")]
        public int Choose { get; set; }

        [JsonProperty("from")]
        [BsonElement("from")]
        public List<From> From { get; set; }

        [JsonProperty("type")]
        [BsonElement("type")]
        public string Type { get; set; }
    }

    [BsonIgnoreExtraElements]
    public partial class From
    {
        [JsonProperty("url")]
        [BsonElement("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }
    }

    public partial class SubRace
    {
        public static SubRace FromJson(string json) => JsonConvert.DeserializeObject<SubRace>(json, DND.Converter.Settings);
    }
}