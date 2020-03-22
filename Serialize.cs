using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DND
{

    public static class Serialize
    {
        public static string ToJson(this Rasse self) => JsonConvert.SerializeObject(self, DND.Converter.Settings);
        public static string ToJson(this Spells self) => JsonConvert.SerializeObject(self, DND.Converter.Settings);
        public static string ToJson(this Klasse self) => JsonConvert.SerializeObject(self, DND.Converter.Settings);
        public static string ToJson(this SubRace self) => JsonConvert.SerializeObject(self, DND.Converter.Settings);
    }
}
