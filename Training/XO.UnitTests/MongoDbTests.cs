using MongoDB.Bson;
using MongoDB.Driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.UnitTests
{
    [TestFixture]
    public class MongoDbTests
    {
        //[Test]
        public void TestConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("rainbow");

            db.CreateCollection("staff");

            var collection = db.GetCollection<BsonDocument>("staff");

            var document = new BsonDocument
            {
                { "name", "MongoDB" },
                { "type", "Database" },
                { "count", 1 },
                { "info", new BsonDocument
                    {
                        { "x", 203 },
                        { "y", 102 }
                    }}
            };

            collection.InsertOne(document);
        }
    }
}
