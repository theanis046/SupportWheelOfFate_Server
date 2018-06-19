using Business.Managers;
using Business.Repositories;
using Business.RuleEngine;
using Domain;
using Domain.Core;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BusinessTest
{
    public class EngineerManager_Test
    {
        [Fact]
        public void TestTotalEngineerCountCount()
        {
            var engineerRepository = new Mock<IEngineerRepository>();
            var engineerManager = new EngineerManager(engineerRepository.Object);

            engineerRepository.Setup(m => m.GetEngineers()).Returns(Task.FromResult(new List<Engineer>
            {
                new Engineer { Id = 1, Name = "Engineer 1"},
                new Engineer { Id = 2, Name = "Engineer2"}
            }));
            Assert.True(engineerManager.getAvailableEngineers().Result.Count == 4);
        }
    }
}
