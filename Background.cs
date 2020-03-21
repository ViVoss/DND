using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class Background
    {
        [JsonProperty("_id")]
        public Id Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("skill_proficiences")]
        public List<string> SkillProficiences { get; set; }

        [JsonProperty("tool_proficiences")]
        public List<string> ToolProficiences { get; set; }

        [JsonProperty("laguage_options")]
        public Options LaguageOptions { get; set; }

        [JsonProperty("equipment")]
        public List<string> Equipment { get; set; }

        [JsonProperty("equipment_options")]
        public Options EquipmentOptions { get; set; }

        [JsonProperty("feature")]
        public List<object> Feature { get; set; }
    }

    public partial class Options
    {
        [JsonProperty("choose")]
        public long Choose { get; set; }

        [JsonProperty("from")]
        public List<object> From { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Id
    {
        [JsonProperty("$oid")]
        public string Oid { get; set; }
    }

    public partial class Background
    {
        public static Background FromJson(string json) => JsonConvert.DeserializeObject<Background>(json, DND.Converter.Settings);
    }
}
