using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public interface IEngineerManager
    {
        Task<List<Engineer>> getAvailableEngineers();
    }
}
