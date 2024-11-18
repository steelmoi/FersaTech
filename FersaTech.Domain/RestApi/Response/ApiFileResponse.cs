using FersaTech.Domain.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.RestApi.Response
{
    public class ApiFileResponse: ApiResponse
    {
        public FileSummary? Result { get; set; }
        public List<ExcelTransaction> Data { get; set; }
    }
}
