using Business.ConnectionManager;
using Domain.Core;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.MongoDBContext
{
    public abstract class MongoDbContext
    {
        public readonly IMongoDatabase _db;
        public MongoDbContext(IAppConnectionManager appConnectionManager)
        {
            _db = appConnectionManager.GetMongoDatabase();
        }

        public IMongoCollection<Engineer> Engineers
        {
            get
            {
                return _db.GetCollection<Engineer>("Engineers");
            }
        }

        
    }
}
