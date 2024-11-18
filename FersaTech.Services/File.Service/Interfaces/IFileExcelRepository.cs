using FersaTech.Domain.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.File.Service.Interfaces
{
    public interface IFileExcelRepository
    {
        List<ExcelTransaction> ReadDataFromFile(string Path);
    }
}
