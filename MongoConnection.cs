using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class MongoConnection
    {
        public static IMongoClient Client { get; set; }
        public static IMongoDatabase Database { get; set; }
        public static string ConnectionString { get; set; } = "mongodb+srv://dbAdmin:Passwort123@dnd-wqlyc.mongodb.net/test?retryWrites=true&w=majority";
        public static string DatabaseString { get; set; } = "DnD";

        internal static void Connect()
        {
            try
            {
                Client = new MongoClient(ConnectionString);
                Database = Client.GetDatabase(DatabaseString);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
