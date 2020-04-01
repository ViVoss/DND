using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class SpellsCollection
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class SpellsCollection
    {
        public static SpellsCollection FromJson(string json) => JsonConvert.DeserializeObject<SpellsCollection>(json, DND.Converter.Settings);
    }
}
