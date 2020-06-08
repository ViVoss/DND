using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    public class DnDInformation
    {
        private string requestParameter;
        private int index;

        public Rasse GetRaceInformation(string rasse)
        {
            WebAufruf<Rasse> webAufruf = new WebAufruf<Rasse>();
            requestParameter = "races/" + rasse;
            Rasse race = webAufruf.GetJsonResponse(requestParameter);

            return race;
        }

        public SubRace GetSubRaceInformation(string subrasse)
        {

            WebAufruf<SubRace> webAufruf = new WebAufruf<SubRace>();
            requestParameter = "subraces/" + subrasse;
            SubRace subrace = webAufruf.GetJsonResponse(requestParameter);

            return subrace;
        }

        public SubRace GetSubRaceDbInformation(string subrasse)
        {
            MongoConnection<SubRace> mongoConnection = new MongoConnection<SubRace>();
            SubRace subrace = mongoConnection.GetDocumentByIndex("Subrace", subrasse);

            return subrace;
        }

        public Klasse GetClassInformation(string klasse)
        {
            WebAufruf<Klasse> webAufruf = new WebAufruf<Klasse>();

            requestParameter = "classes/" + klasse;
            Klasse clazz = webAufruf.GetJsonResponse(requestParameter);

            return clazz;
        }

        public StartingEquipment GetStartingEquipmentInformation(string klasse)
        {
            WebAufruf<StartingEquipment> webAufruf = new WebAufruf<StartingEquipment>();

            foreach (int enumVal in Enum.GetValues(typeof(EnumKlasse)))
            {
                if (klasse.Equals(Enum.GetName(typeof(EnumKlasse), enumVal)))
                {
                    index = enumVal;
                }
            }

            requestParameter = "starting-equipment/" + index;
            StartingEquipment startingEquipment = webAufruf.GetJsonResponse(requestParameter);

            return startingEquipment;
        }

        public Background GetBackgroundInformation(string hintergrund)
        {
            MongoConnection<Background> mongoConnection = new MongoConnection<Background>();
            Background background = mongoConnection.GetDocumentByIndex("Background", hintergrund);

            return background;
        }

        public List<Spells> GetSpellsInformation()
        {
            List<Spells> spellList = new List<Spells>();

            WebAufruf<SpellsCollection> webAufruf = new WebAufruf<SpellsCollection>();
            SpellsCollection spells =  webAufruf.GetJsonResponse("spells");

            foreach (Result result in spells.Results)
            {
                WebAufruf<Spells> webAufruf1 = new WebAufruf<Spells>();
                requestParameter = "spells/" + result.Index;
                Spells spell = webAufruf1.GetJsonResponse(requestParameter);

                spellList.Add(new Spells()
                {
                    Name = spell.Name,
                    Desc = spell.Desc,
                    HigherLevel = spell.HigherLevel,
                    Range = spell.Range,
                    Components = spell.Components,
                    Material = spell.Material,
                    Ritual = spell.Ritual,
                    Duration = spell.Duration,
                    Concentration = spell.Concentration,
                    CastingTime = spell.CastingTime,
                    Level = spell.Level,
                    School = spell.School,
                    Classes = spell.Classes,
                    Subclasses = spell.Subclasses
                });
                
            }
            
            return spellList;
        }

    }
}
