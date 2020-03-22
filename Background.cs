using System;
using System.Collections.Generic;
using System.Globalization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DND
{
    [BsonIgnoreExtraElements]
    public class Background
    {
        [BsonId]
        public ObjectId ID { get; set; }

        [BsonElement("index")]
        public string Index { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("skill_proficiences")]
        public List<string> SkillProficiences { get; set; }

        [BsonElement("tool_proficiences")]
        public List<string> ToolProficiences { get; set; }

        [BsonElement("languages")]
        public List<string> Languages { get; set; }

        [BsonElement("language_options")]
        public LanguageOptions LanguageOptions { get; set; }

        [BsonElement("equipment")]
        public List<string> Equipment { get; set; }

        [BsonElement("equipment_options")]
        public EquipmentOptions EquipmentOptions { get; set; }

        [BsonElement("feature")]
        public List<string> Feature { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class EquipmentOptions
    {
        [BsonElement("choose")]
        public int Choose { get; set; }

        [BsonElement("from")]
        public List<string> From { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }
    }
}
