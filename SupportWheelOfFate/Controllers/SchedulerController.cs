//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Business.ExceptionManager;
//using Business.Managers;
//using Domain;
//using Domain.Core;
//using Domain.ViewModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Options;



using Business.ExceptionManager;
using Business.Managers;
using Domain;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SupportWheelOfFate.Controllers
{
    public class SchedulerController : Controller
    {
        ISchedulingManager manager;
        IOptions<AppSettings> appSettings;
        IExceptionHandler exceptionHandler;
        private static string[] workingWeekDays = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        public SchedulerController(ISchedulingManager manager, IOptions<AppSettings> appSettings, IExceptionHandler exceptionHandler)
        {
            this.manager = manager;
            this.appSettings = appSettings;
            this.exceptionHandler = exceptionHandler;
        }
        
        [HttpGet]
        [Route("api/v1/getSchedule")]
        public async Task<IActionResult> getSchedule()
        {
            var result =  await exceptionHandler.InitiateFunc(() => manager.getSchedule(workingWeekDays), Request);
            return result;
        }
    }
}