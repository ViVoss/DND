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
        public static string ConnectionLink { get; set; } = "mongodb+srv://dbAdmin:Passwort123@dnd-wqlyc.mongodb.net/test?retryWrites=true&w=majority";
        public static string DatabaseName { get; set; } = "DnD";

        internal static void Connect()
        {
            try
            {
                Client = new MongoClient(ConnectionLink);
                Database = Client.GetDatabase(DatabaseName);
                MessageBox.Show("Successfully connected");                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
