using Microsoft.AspNetCore.Http;

namespace MiniShop.Shared.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<string> UploadImage(IFormFile image, string folderName);
        bool ImageIsValid(string extension);
    }
}
