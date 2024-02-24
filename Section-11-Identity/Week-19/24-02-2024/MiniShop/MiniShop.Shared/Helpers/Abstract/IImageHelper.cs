using Microsoft.AspNetCore.Http;
using MiniShop.Shared.ResponseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<string> UploadImage(IFormFile image, string folderName);
        bool ImageIsValid(string extension);
    }
}
