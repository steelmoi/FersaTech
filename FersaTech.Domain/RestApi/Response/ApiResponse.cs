using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.RestApi.Response
{
    public class ApiResponse
    {
        public int Code {  get; set; } = (int)HttpStatusCode.OK;
        public string Message { get; set; } = string.Empty;
    }
}
