using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Connections;

namespace Business.ConnectionManager
{
    public class AppConnectionManager : IAppConnectionManager
    {
        IOptions<AppSettings> _appSettings;
        public AppConnectionManager(IOptions<AppSettings> _appSettings)
        {
            this._appSettings = _appSettings;
            _db = SetMongoDatabase();
        }
        public readonly IMongoDatabase _db;
        public IConnection GetConnection()
        {
            throw new NotImplementedException();
        }


        private IMongoDatabase SetMongoDatabase()
        {

            var client = new MongoClient(_appSettings.Value.ConnectionString);
            return (client.GetDatabase(_appSettings.Value.Database));
        }

        public IMongoDatabase GetMongoDatabase()
        {
            return this._db;
        }
    }
}
