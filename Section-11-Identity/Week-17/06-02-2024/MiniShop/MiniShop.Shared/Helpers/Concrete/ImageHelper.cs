using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.ResponseViewModels;

namespace MiniShop.Shared.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private readonly string _imagesFolder;
        public ImageHelper(IWebHostEnvironment _enviroment)
        {
            _imagesFolder = Path.Combine(_enviroment.WebRootPath, "images");
        }

        public bool ImageIsValid(string extension)
        {
            string[] correctExtensions = { ".png", ".jpg", ".jpeg" };
            if (correctExtensions.Contains(extension))
            {
                return true;
            }
            return false;
        }

        public async Task<string> UploadImage(IFormFile image, string folderName)

        {
            if (image == null)
            {
                return null;
            }
            var fileExtension = Path.GetExtension(image.FileName);
            if (!ImageIsValid(fileExtension))
            {
                return "";
            }
            var targetFolder = Path.Combine(_imagesFolder, folderName);
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
            var fileName = $"{Guid.NewGuid()}{fileExtension}";
            var fileFullPath = Path.Combine(targetFolder, fileName);
            await using (var stream = new FileStream(fileFullPath, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return fileName;
        }
    }
}