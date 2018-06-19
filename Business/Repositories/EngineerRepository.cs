using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.ConnectionManager;
using Business.MongoDBContext;
using Domain.Core;
using MongoDB.Driver;

namespace Business.Repositories
{
    public class EngineerRepository : MongoDbContext , IEngineerRepository
    {
        public readonly IAppConnectionManager _appConnectionManager;
        public EngineerRepository(IAppConnectionManager appConnectionManager) : base(appConnectionManager)
        {
            _appConnectionManager = appConnectionManager;
        }
        public async Task<List<Engineer>> GetEngineers()
        {
            var engineers =  (await Engineers.FindAsync(e => e.Id != null).Result.ToListAsync());
            return engineers;
        }
    }
}

#region engineersLst

//List<Engineer> lstEngineer = new List<Engineer>();
//Engineer engineer1 = new Engineer();
//engineer1.Id = 1;
//engineer1.Name = "Anis";
//lstEngineer.Add(engineer1);
//Engineer engineer2 = new Engineer();
//engineer2.Id = 2;
//engineer2.Name = "Mark";
//lstEngineer.Add(engineer2);
//Engineer engineer3 = new Engineer();
//engineer3.Id = 3;
//engineer3.Name = "Matt";
//lstEngineer.Add(engineer3);
//Engineer engineer4 = new Engineer();
//engineer4.Id = 4;
//engineer4.Name = "Yerachmiel";
//lstEngineer.Add(engineer4);
//Engineer engineer5 = new Engineer();
//engineer5.Id = 5;
//engineer5.Name = "Dan";
//lstEngineer.Add(engineer5);
//Engineer engineer6 = new Engineer();
//engineer6.Id = 6;
//engineer6.Name = "Michael";
//lstEngineer.Add(engineer6);
//Engineer engineer7 = new Engineer();
//engineer7.Id = 7;
//engineer7.Name = "Laura";
//lstEngineer.Add(engineer7);
//Engineer engineer8 = new Engineer();
//engineer8.Id = 8;
//engineer8.Name = "Meghan";
//lstEngineer.Add(engineer8);
//Engineer engineer9 = new Engineer();
//engineer9.Id = 9;
//engineer9.Name = "Harry";
//lstEngineer.Add(engineer9);
//Engineer engineer10 = new Engineer();
//engineer10.Id = 10;
//engineer10.Name = "Diana";
//lstEngineer.Add(engineer10);

//return lstEngineer;
#endregion
