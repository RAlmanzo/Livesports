using Microsoft.AspNetCore.Components.Forms;
using Pin.LiveSports.Blazor.Services.Interfaces;
using Pin.LiveSports.Core.Models;

namespace Pin.LiveSports.Blazor.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _webHost;

        public FileService(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public async Task<string> LoadFile(IBrowserFile file)
        {
            var fileName = string.Empty;
            if (file != null)
            {
                fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.Name)}";

                var pathToFolder = Path.Combine(_webHost.WebRootPath, "images");
                var pathToFile = Path.Combine(pathToFolder, fileName);

                Directory.CreateDirectory(Path.GetDirectoryName(pathToFolder));

                using (var fileStream = new FileStream(pathToFile, FileMode.Create))
                {
                    await file.OpenReadStream().CopyToAsync(fileStream);
                }
            }

            return fileName;
        }
    }
}
