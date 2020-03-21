using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DND
{
    class MongoConnection
    {
        public static IMongoClient Client { get; set; }
        public static IMongoDatabase Database { get; set; }
        public static IMongoCollection<Character> Collection { get; set; }
        public static string ConnectionLink { get; set; } = "mongodb+srv://dbAdmin:Passwort123@dnd-wqlyc.mongodb.net/test?retryWrites=true&w=majority";
        public static string DatabaseName { get; set; } = "DnD";

        public static void Connect()
        {
            var client = new MongoClient(MongoUrl.Create(ConnectionLink));
            client.GetDatabase("DnD");
        }

        //public static void CreateCollection()
        //{

        //}

        public static void GetCollection(string collectionName)
        {
            var client = new MongoClient(MongoUrl.Create(ConnectionLink));
            IMongoDatabase db = client.GetDatabase("DnD");
            db.GetCollection<BsonDocument>(collectionName);
        }

        public static void GetDocumentByIndex(string collectionName, string documentIndex)
        {
            var client = new MongoClient(MongoUrl.Create(ConnectionLink));
            IMongoDatabase db = client.GetDatabase("DnD");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("index", documentIndex);
            collection.Find(filter).First();
        }

        public static void InsertOneDocument(BsonDocument bsonDoc, string collectionName)
        {
            var client = new MongoClient(MongoUrl.Create(ConnectionLink));
            IMongoDatabase db = client.GetDatabase("DnD");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(bsonDoc);
        }

        public static void InsertManyDocuments(List<BsonDocument> bsonDocList ,string collectionName)
        {
            var client = new MongoClient(MongoUrl.Create(ConnectionLink));
            IMongoDatabase db = client.GetDatabase("DnD");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(collectionName);
            collection.InsertMany(bsonDocList);
        }



        //internal static void Connect()
        //{
        //    if (Collection == null)
        //    {
        //        try
        //        {
        //            Client = new MongoClient(ConnectionLink);
        //            Database = Client.GetDatabase(DatabaseName);
        //            //MessageBox.Show("Successfully connected");

        //            Collection = Database.GetCollection<Character>("Character");
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        //}

    }
}
