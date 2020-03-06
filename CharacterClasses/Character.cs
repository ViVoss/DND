using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Character
    {

        //Verweise
        [BsonElement("appearance")]
        public Appearance Appearance { get; set; }

        [BsonElement("attributes")]
        public Attributes Attributes { get; set; }

        [BsonElement("skilllist")]
        public Skills Skills { get; set; }

        [BsonElement("savingthrows")]
        public SavingThrows SavingThrows { get; set; }

        [BsonElement("traitlist")]
        public TraitList TraitList { get; set; }

        [BsonElement("spells")]
        public SpellList SpellList { get; set; }

        [BsonElement("inventory")]
        public Inventory Inventory { get; set; }


        //Konstruktor
        public Character()
        {
            Appearance = new Appearance();
            Attributes = new Attributes(this);
            Skills = new Skills(this);
            SavingThrows = new SavingThrows();
            TraitList = new TraitList();
            SpellList = new SpellList();
            Inventory = new Inventory();
        }

        //Eigenschaften
        [BsonId]
        //[BsonElement("charactername")]
        public String CharacterName { get; set; }

        [BsonElement("class")]
        public String Class { get; set; }

        [BsonElement("level")]
        public UInt16 Level { get; set; }

        [BsonElement("playername")]
        public String PlayerName { get; set; }

        [BsonElement("background")]
        public String Background { get; set; }

        [BsonElement("race")]
        public String Race { get; set; }

        [BsonElement("subrace")]
        public String SubRace { get; set; }

        [BsonElement("experiencepoints")]
        public UInt64 ExperiencePoints { get; set; }

        [BsonElement("age")]
        public UInt16 Age { get; set; }

        [BsonElement("faction")]
        public String Faction { get; set; }

        [BsonElement("alignment")]
        public String Alignment { get; set; }

        [BsonIgnore]
        public static Character Current { get; set; }

        public static void New()
        {
            Current = new Character();

            Character newCharacter = new Character();

            //BsonDocument

            //MongoConnection.Collection.InsertOne(newCharacter);
            
        }
        public static void Load(String characterName)
        {
            MongoConnection.Connect();

            //MongoConnection.Collection.Find(new BsonDocument()).;
            

        }
        public static void Save()
        {
            MongoConnection.Connect();
        }
    }
}