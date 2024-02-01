using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFileUploadApp.Core
{
    public static class Uploader
    {
        public static string UploadImage(IFormFile image)
        {
            //
            var extension = "." + image.FileName.Split('.')[image.FileName.Split('.').Length - 1];
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            var FileName = $"{Guid.NewGuid()}{extension}";
            var path = Path.Combine(filePath, FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return FileName;
        }
    }
}