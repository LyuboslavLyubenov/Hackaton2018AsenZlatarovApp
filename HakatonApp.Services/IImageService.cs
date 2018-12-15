namespace HakatonApp.Services
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;

    public interface IImageService
    {
        bool SaveImages(IEnumerable<IFormFile> images, string questName);
    }
}
