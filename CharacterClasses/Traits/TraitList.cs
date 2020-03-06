using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class TraitList
    {
        //Eigenschaften
        [BsonElement("traits")]
        public List<Trait> Traits { get; set; } = new List<Trait>();
    }
}
