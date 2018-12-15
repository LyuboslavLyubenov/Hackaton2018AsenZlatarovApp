namespace HakatonApp.Services
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;

    using static HakatonApp.Common.GlobalConstants;

    public class ImageService : IImageService, IService
    {
        public bool SaveImages(IEnumerable<IFormFile> images, string questName)
        {
            try
            {
                var questPath = Path.Combine(PathToImages, questName);
                Directory.CreateDirectory(questPath);

                using (var stream = new FileStream(PathToImages, FileMode.Create))
                {
                    int counter = 0;

                    foreach (var image in images)
                    {
                        counter++;
                        File.Copy(image.FileName, counter.ToString());
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
