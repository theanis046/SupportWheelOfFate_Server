using MongoDB.Driver;
using MongoDB.Driver.Core.Connections;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConnectionManager
{
    public interface IAppConnectionManager
    {
        IConnection GetConnection();
        IMongoDatabase GetMongoDatabase();
        
    }
}
