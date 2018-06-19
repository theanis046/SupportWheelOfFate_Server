using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Business.ExceptionManager
{
    public interface IExceptionHandler
    {
        Task<dynamic> InitiateFunc<T>(Func<Task<T>> method, HttpRequest request);
    }
}
