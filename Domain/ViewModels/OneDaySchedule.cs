using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModels
{
    public class OneDaySchedule
    {
        public string Name { get; set; }

        public List<Shift> Shifts { get; set; }

        public int WeekNumber { get; set; }
    }
}
