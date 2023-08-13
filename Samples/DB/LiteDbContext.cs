using LiteDB;
using Samples.Model;
using System;

namespace Samples.DB
{
    public class LiteDbContext
    {
        private readonly LiteDatabase _db;
        public LiteDbContext(string connectionString) {
            _db = new LiteDatabase(connectionString);
        }
        public ILiteCollection<User> User => _db.GetCollection<User>("user");
    }
}
