using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories;
using Business.RuleEngine;
using Domain;
using Domain.Core;
using Domain.ViewModels;
using Microsoft.Extensions.Options;

namespace Business.Managers
{
    public class SchedulingManager : ISchedulingManager
    {
        IEngineerRepository engineerRepository;
        IEngineerManager engineerManager;
        IOptions<AppSettings> appSettings;
        IBusinessRuleEngine businessRuleEngine;
        public SchedulingManager(IEngineerRepository engineerRepository, IEngineerManager engineerManager, IOptions<AppSettings> appSettings, IBusinessRuleEngine businessRuleEngine)
        {
            this.engineerRepository = engineerRepository;
            this.engineerManager = engineerManager;
            this.appSettings = appSettings;
            this.businessRuleEngine = businessRuleEngine;
        }

        public SchedulingManager(IEngineerRepository engineerRepository, IEngineerManager engineerManager, IBusinessRuleEngine businessRuleEngine)
        {
            this.engineerRepository = engineerRepository;
            this.engineerManager = engineerManager;
            this.appSettings = appSettings;
            this.businessRuleEngine = businessRuleEngine;
        }

        public async Task<List<OneDaySchedule>> getSchedule(string[] weekDays)
        {
            List<Shift> lstShifts = await scheduleShifts();
            var shiftsPerDay = appSettings.Value.ShiftsInDay;
            var oneDaySchedule = new List<OneDaySchedule>();
            for (int i = 0; i < appSettings.Value.TotalWorkingDays; i++)
            {
                oneDaySchedule.Add(new OneDaySchedule
                {
                    Name = weekDays[i % 5],
                    Shifts = lstShifts.Skip(i * shiftsPerDay).Take(shiftsPerDay).ToList(),
                    WeekNumber = i < 5 ? 1 : 2
                });
            }
            return oneDaySchedule;
        }

        public async Task<List<Shift>> scheduleShifts()
        {
            List<Shift> lstShifts = new List<Shift>();
            List<Engineer> availableEngineers = await engineerManager.getAvailableEngineers();

            for (int i = 0; i < appSettings.Value.TotalShifts; i++)
            {
                Engineer engineer;
                Random r = new Random();
                int maxRNum = r.Next(0, appSettings.Value.TotalShifts - i);
                int rand = maxRNum == 0 ? maxRNum : maxRNum - 1;
                engineer = availableEngineers[rand];
                if (businessRuleEngine.validate(engineer))
                {
                    lstShifts.Add(new Shift() { shiftId = i, engineer = engineer });
                    availableEngineers.Remove(engineer);
                }
            }
            return lstShifts;
        }
    }
}
