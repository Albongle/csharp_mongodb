using MongoDB.Bson;
using MongoDB.Driver;
namespace Entidades
{
    public class MongoManager
    {
        private static string stringConnection;
        private static MongoClient client;
        private IMongoDatabase database;

        static MongoManager()
        {
            MongoManager.stringConnection = @"mongodb://localhost:27017";
            MongoManager.client = new MongoClient(MongoManager.stringConnection);


        }

        public MongoManager(string nameDatabase)
        {
            this.database = MongoManager.client.GetDatabase(nameDatabase);
        }


        public bool InsertOne<T>(string nameCollection, T element)
        {
            IMongoCollection<T> collection = this.database.GetCollection<T>(nameCollection);
            collection.InsertOne(element);

            return true;
        }




    }
}