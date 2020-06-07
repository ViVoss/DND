using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class Spells
    {
        [JsonProperty("_id")]
        public string Id { get; set; } = "-";

        [JsonProperty("index")]
        public string Index { get; set; } = "-";

        [JsonProperty("name")]
        public string Name { get; set; } = "-";

        [JsonProperty("desc")]
        public List<string> Desc { get; set; } = new List<string>();

        [JsonProperty("higher_level")]
        public List<string> HigherLevel { get; set; } = new List<string>();

        [JsonProperty("page")]
        public string Page { get; set; } = "-";

        [JsonProperty("range")]
        public string Range { get; set; } = "-";

        [JsonProperty("components")]
        public List<string> Components { get; set; } = new List<string>();
         
        [JsonProperty("material")]
        public string Material { get; set; } = "-";

        [JsonProperty("ritual")]
        public bool Ritual { get; set; } = false;

        [JsonProperty("duration")]
        public string Duration { get; set; } = "-";

        [JsonProperty("concentration")]
        public bool Concentration { get; set; } = false;

        [JsonProperty("casting_time")]
        public string CastingTime { get; set; } = "-";

        [JsonProperty("level")]
        public long Level { get; set; } = 1;

        [JsonProperty("school")]
        public School School { get; set; }

        [JsonProperty("classes")]
        public List<Klasse> Classes { get; set; }

        [JsonProperty("subclasses")]
        public List<Proficiency> Subclasses { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; } = "-";
    }

    public partial class School
    {
        [JsonProperty("name")]
        public string Name { get; set; } = "-";

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Spells
    {
        public static Spells FromJson(string json) => JsonConvert.DeserializeObject<Spells>(json, DND.Converter.Settings);
    }
}

