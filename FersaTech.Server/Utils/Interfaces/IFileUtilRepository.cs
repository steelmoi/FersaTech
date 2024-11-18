using FersaTech.Domain.RestApi.Response;

namespace FersaTech.Server.Utils.Interfaces
{
    public interface IFileUtilRepository
    {
        ApiFileResponse ValidateFile(IFormFile file);
        string SaveFile(IFormFile file);
    }
}
