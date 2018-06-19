using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories;
using Domain.Core;

namespace Business.Managers
{
    public class EngineerManager : IEngineerManager
    {
        IEngineerRepository engineerRepository;
        public EngineerManager(IEngineerRepository engineerRepository)
        {
            this.engineerRepository = engineerRepository;
        }
        public async Task<List<Engineer>> getAvailableEngineers()
        {
            List<Engineer> availableEngineers = new List<Engineer>();
            availableEngineers.AddRange(await engineerRepository.GetEngineers());
            availableEngineers.AddRange(await engineerRepository.GetEngineers());
            return availableEngineers;
        }
    }
}
