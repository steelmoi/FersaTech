using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using FersaTech.Domain.dtos;
using FersaTech.Services.File.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.File.Service.Repositories
{
    public class FileExcelRepository : IFileExcelRepository
    {
        public List<ExcelTransaction> ReadDataFromFile(string Path)
        {
            List<ExcelTransaction> Data = new List<ExcelTransaction>();
            using (IXLWorkbook workbook = new XLWorkbook(Path))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);
                bool FirstRow = true, useHeader = true;
                int LineNumber = 1;
                foreach (var row in worksheet.Rows())
                {
                    if (useHeader && FirstRow)
                    {
                        FirstRow = false;
                    }
                    else
                    {
                        Data.Add(
                            new ExcelTransaction()
                            {
                                Type = row.Cell(1).GetValue<string>(),
                                Amount = row.Cell(2).GetValue<string>(),
                                Date = row.Cell(3).GetValue<string>(),
                                NumLinea = LineNumber
                            }
                        );
                    }
                    LineNumber++;
                }                
            }
            return Data;
        }
    }
}
