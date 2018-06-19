using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class AppSettings : IAppSettings
    {
        public int ShiftsInDay { get; set; }
        public int TotalShifts { get; set; }
        public int TotalWorkingDays { get; set; }
        public int TotalEngineers { get; set; }
        public string ConnectionString { get; set; }
        public string Database { get; set; }

    }

    public interface IAppSettings
    {
        int ShiftsInDay { get; set; }
        int TotalShifts { get; set; }
        int TotalWorkingDays { get; set; }
        int TotalEngineers { get; set; }
        string ConnectionString { get; set; }
        string Database { get; set; }

    }
}
