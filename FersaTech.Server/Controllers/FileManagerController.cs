using FersaTech.Domain.dtos;
using FersaTech.Domain.Models.Entities;
using FersaTech.Domain.RestApi.Response;
using FersaTech.Server.Utils.Interfaces;
using FersaTech.Services.Database.Service.Interfaces;
using FersaTech.Services.Database.Service.Respositories;
using FersaTech.Services.File.Service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FersaTech.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileManagerController : ControllerBase
    {
        private readonly IFileUtilRepository fileUtilRepository;
        private readonly IFileExcelRepository fileRepository;
        private readonly ITransaccionesRepository transaccionesRepository;
        private readonly ITransaccionesDetalleRepository transaccionesDetalleRepository;
        private readonly IAlertasRepository alertasRepository;
        private readonly IBitacoraIncidenciasRepository bitacoraIncidenciasRepository;

        public FileManagerController(IFileUtilRepository fileUtilRepository, 
            IFileExcelRepository fileRepository,
            ITransaccionesRepository transaccionesRepository,
            ITransaccionesDetalleRepository transaccionesDetalleRepository,
            IAlertasRepository alertasRepository,
            IBitacoraIncidenciasRepository bitacoraIncidenciasRepository)
        {
            this.fileUtilRepository = fileUtilRepository;
            this.fileRepository = fileRepository;
            this.transaccionesRepository = transaccionesRepository;
            this.transaccionesDetalleRepository = transaccionesDetalleRepository;
            this.alertasRepository = alertasRepository;
            this.bitacoraIncidenciasRepository = bitacoraIncidenciasRepository;
        }

        [HttpPost]
        public ApiFileResponse UploadExcel(IFormFile file)
        {
            ApiFileResponse  response = fileUtilRepository.ValidateFile(file);

            try
            {
                if (response.Code == (int)HttpStatusCode.OK)
                {
                    var filePath = fileUtilRepository.SaveFile(file);
                    List<ExcelTransaction> Data = fileRepository.ReadDataFromFile(filePath);

                    if (Data.Count > 0)
                    {
                        response.Data = Data;
                        Transacciones Trans = transaccionesRepository.AddTransaction(file.FileName);
                        Trans.TotalProcesados = transaccionesDetalleRepository.AddDetails(Data, Trans);
                        Trans.TotalAlertas = alertasRepository.AddAlertas(Data, Trans);
                        Trans.TotalIncidencias = bitacoraIncidenciasRepository.AddIncidencias(Data, Trans);

                        response.Result.TotalIncidencias = Trans.TotalIncidencias;
                        response.Result.TotalProcesados = Trans.TotalProcesados;
                        response.Result.TotalAlertas = Trans.TotalAlertas;
                        transaccionesRepository.Update(Trans);
                    }
                    else
                    {
                        response.Code = (int)HttpStatusCode.BadRequest;
                        response.Message = "Archivo vacio";
                    }
                }
            }catch(Exception err)
            {
                response.Code = (int)HttpStatusCode.InternalServerError;
                response.Message = $"Error: {err.Message}";
            }

            return response;
        }
    }
}
