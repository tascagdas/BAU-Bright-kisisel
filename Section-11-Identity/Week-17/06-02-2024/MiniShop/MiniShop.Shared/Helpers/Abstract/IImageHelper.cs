using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MiniShop.Shared.ResponseViewModels;

namespace MiniShop.Shared.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<string> UploadImage(IFormFile image, string folderName);
        bool ImageIsValid(string extension);
    }
}