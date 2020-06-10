using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DND
{
    public class MongoConnection<T>
    {
        public static IMongoClient Client { get; set; }
        public static IMongoDatabase Database { get; set; }
        public static IMongoCollection<T> Collection { get; set; }
        public static string ConnectionLink { get; set; } = "mongodb+srv://dbAdmin:Passwort123@dnd-wqlyc.mongodb.net/test?retryWrites=true&w=majority";
        public static string DatabaseName { get; set; } = "DnD";

        public dynamic GetDocumentByIndex(string collectionName, string documentIndex)
        {
            Client = new MongoClient(MongoUrl.Create(ConnectionLink));
            Database = Client.GetDatabase("DnD");
            IMongoCollection<BsonDocument> collection = Database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("index", documentIndex);
            var result = collection.Find(filter).First();
            return BsonSerializer.Deserialize<T>(result);
        }
    }
}
