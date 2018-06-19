using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public interface IEngineerRepository
    {
        Task<List<Engineer>> GetEngineers();
    }
}
