using Microsoft.AspNetCore.Http;

namespace VehicleMakes.Service.Abstracts
{
    public interface IFileService
    {
        public Task<string> UploadImage(string Location, IFormFile file);
    }
}
