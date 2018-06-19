using Domain.Core;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public interface ISchedulingManager
    {
        Task<List<Shift>> scheduleShifts();
        Task<List<OneDaySchedule>> getSchedule(string[] weekDays);
    }
}
