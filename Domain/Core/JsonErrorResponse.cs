using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core
{
    public class JsonErrorResponse
    {
        public string status { get; set; } = String.Empty;
        public string errorCode { get; set; } = String.Empty;
        public string data { get; set; } = String.Empty;
    }
}
