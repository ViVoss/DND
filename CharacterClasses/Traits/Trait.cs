using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Trait
    {

        [BsonElement("name")]
        public string Name { get; set; }

        public Trait(string name)
        {
            this.Name = name;
        }
    }
}
