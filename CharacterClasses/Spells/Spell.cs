using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Spell
    {
        //Eigenschaften
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("level")]
        public UInt16 Level { get; set; }

        [BsonElement("prepared")]
        public bool Prepared { get; set; }

        //Konstruktor
        public Spell(string name, UInt16 level, bool prepared)
        {
            this.Name = name;
            this.Level = level;
            this.Prepared = prepared;
        }
    }
}
