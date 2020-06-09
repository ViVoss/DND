using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DND
{
    class Character
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String ID { get; set; }

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

        [BsonElement("spelllist")]
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
        [BsonElement("charactername")]
        public String CharacterName { get; set; }

        [BsonIgnore]
        public String OldCharacterName { get; set; }

        [BsonElement("class")]
        public String Class { get; set; }

        [BsonElement("level")]
        public UInt16 Level { get; set; } = 1;

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
        }
        public static bool Load(String characterName)
        {
            //Connect
            MongoConnectionForCharacter.Connect();

            List<Character> found = MongoConnectionForCharacter.Collection.Find<Character>(x => x.CharacterName == characterName).ToList();

            if(found.Count == 0)
            {
                MessageBox.Show("Fehler: Es konnte kein Character mit dem Namen '" + characterName + "' gefunden werden.");
                return false;
            }
            else if(found.Count > 1)
            {
                MessageBox.Show("Fehler: Es wurden mehrere Character mit dem Namen '" + characterName + "' gefunden.");
                return false;
            }
            else
            {
                Character.Current = found[0];
                return true;
            }
        }

        public static void Save()
        {
            //Connect
            MongoConnectionForCharacter.Connect();

            bool exists = Exists(Character.Current.OldCharacterName);

            MessageBox.Show(exists.ToString());

            if (exists)
            {
                //Löscht alten Eintrag
                Delete(Character.Current.OldCharacterName);
            }
            //Erstellt neuen Eintrag
            MongoConnectionForCharacter.Collection.InsertOne(Character.Current);
        }

        public static void Delete(String characterName)
        {
            //Connect
            MongoConnectionForCharacter.Connect();

            MongoConnectionForCharacter.Collection.DeleteOne<Character>(x => x.CharacterName == characterName);

        }

        public static List<Character> GetAll()
        {
            //Connect
            MongoConnectionForCharacter.Connect();

            List<Character> result = MongoConnectionForCharacter.Collection.Find<Character>(x => true).ToList();
            return result;
        }

        public static bool Exists(String characterName)
        {
            //Connect
            MongoConnectionForCharacter.Connect();

            bool notFound = MongoConnectionForCharacter.Collection.Find<Character>(x => x.CharacterName == characterName) == null;
            return !notFound;
        }
    }
}