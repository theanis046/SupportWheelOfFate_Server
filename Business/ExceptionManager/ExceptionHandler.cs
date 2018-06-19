using Domain.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.ExceptionManager
{
    public class ExceptionHandler : IExceptionHandler
    {
        public async Task<dynamic> InitiateFunc<T>(Func<Task<T>> method, HttpRequest request)
        {
            try
            {
                return new OkObjectResult(await method.Invoke());
            }
            catch (Exception ex)
            {
                JsonErrorResponse error = new JsonErrorResponse();
                if (ex.Data.Count == 0)
                {
                    error = new JsonErrorResponse { data = ex.Message.ToString(), errorCode = "400", status = "conflict" };
                }
                else if (ex.Data.Count > 0)
                {
                    error = new JsonErrorResponse { data = ex.Data["message"].ToString(), errorCode = ex.Data["errorCode"].ToString(), status = "Bad Request" };
                }
                return new BadRequestResult();
            }
        }
    }
}
