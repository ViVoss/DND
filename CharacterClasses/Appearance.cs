using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Appearance
    {
        //Eigenschaften

        [BsonElement("sizecategory")]
        public String SizeCategory { get; set; }

        [BsonElement("size")]
        public String Size { get; set; }

        [BsonElement("weight")]
        public String Weight { get; set; }

        [BsonElement("gender")]
        public String Gender { get; set; }

        [BsonElement("eyecolor")]
        public String Eyecolor { get; set; }

        [BsonElement("haircolor")]
        public String Haircolor { get; set; }

        [BsonElement("skincolor")]
        public String Skincolor { get; set; }
    }
}
