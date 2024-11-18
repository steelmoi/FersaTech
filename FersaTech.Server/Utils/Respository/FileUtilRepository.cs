using FersaTech.Domain.RestApi.Response;
using FersaTech.Server.Utils.Interfaces;
using System.Net;

namespace FersaTech.Server.Utils.Respository
{
    public class FileUtilRepository : IFileUtilRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileUtilRepository(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string SaveFile(IFormFile file)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;

            string filePath = Path.Combine(contentRootPath, file.FileName);
            using (Stream fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }
            return filePath;
        }

        public ApiFileResponse ValidateFile(IFormFile file)
        {
            ApiFileResponse response = new ApiFileResponse()
            {
                Result = new FileSummary()
            };

            var FileExtension = System.IO.Path.GetExtension(file.FileName).ToLower();
            if (file == null)
            {
                response.Code = (int)HttpStatusCode.BadRequest;
                response.Message = "Archivo no correcto";
                return response;
            }

            if (file.Length <= 0)
            {
                response.Code = (int)HttpStatusCode.BadRequest;
                response.Message = "Archivo vacio";
                return response;
            }
            string[] extension = { ".xlsx", ".xls" };
            if (!extension.Contains(FileExtension))
            {
                response.Code = (int)HttpStatusCode.BadRequest;
                response.Message = "Extension no valida";
                return response;
            }

            return response;
        }
    }
}
