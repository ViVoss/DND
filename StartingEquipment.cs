using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class StartingEquipment
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public long Index { get; set; }

        [JsonProperty("starting_equipment")]
        public List<StartingEquipmentElement> StartingEquipmentElement { get; set; }

        [JsonProperty("choices_to_make")]
        public long ChoicesToMake { get; set; }

        [JsonProperty("choice_1")]
        public List<Choice> Choice { get; set; }

        [JsonProperty("choice_2")]
        public List<Choice> Choice2 { get; set; }

        [JsonProperty("choice_3")]
        public List<Choice> Choice3 { get; set; }

        [JsonProperty("choice_4")]
        public List<Choice> Choice4 { get; set; }

        [JsonProperty("choice_5")]
        public List<Choice> Choice5 { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Choice
    {
        [JsonProperty("choose")]
        public long Choose { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public List<StartingEquipmentElement> From { get; set; }
    }

    public partial class StartingEquipmentElement
    {
        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
