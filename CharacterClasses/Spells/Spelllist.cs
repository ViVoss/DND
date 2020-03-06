using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class SpellList
    {
        //Eigenschaften

        [BsonElement("spells")]
        public List<Spell> Spells { get; set; } = new List<Spell>();
    }
}
