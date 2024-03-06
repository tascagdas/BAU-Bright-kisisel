using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.ResponseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        //localhost:5000/wwwroot/images
        private readonly string _imagesFolder;

        public ImageHelper(IWebHostEnvironment _environment)
        {
            _imagesFolder = Path.Combine(_environment.WebRootPath, "images");
        }

        public bool ImageIsValid(string extension)
        {
            string[] correctExtensions = { ".png",".jpg",".jpeg" };
            if(correctExtensions.Contains(extension))
            {
                return true;
            }
            return false;
        }

        public async Task<string> UploadImage(IFormFile image, string folderName)
        {
            if (image==null)
            {
                return null;
            }
            var fileExtension = Path.GetExtension(image.FileName);
            if (!ImageIsValid(fileExtension))
            {
                return "";
            }
            //localhost:5000/wwwroot/images/products
            //localhost:5000/wwwroot/images/categories
            //localhost:5000/wwwroot/images/users
            var targetFolder = Path.Combine(_imagesFolder, folderName);
            if(!Directory.Exists(targetFolder)) 
            { 
                Directory.CreateDirectory(targetFolder);
            }

            
            var fileName = $"{Guid.NewGuid()}{fileExtension}";
            var fileFullPath= Path.Combine(targetFolder, fileName);
            await using (var stream = new FileStream(fileFullPath, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return fileName;

        }
    }
}
