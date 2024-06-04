using Microsoft.AspNetCore.Components.Forms;

namespace Pin.LiveSports.Blazor.Services.Interfaces
{
    public interface IFileService
    {
        Task<string> LoadFile (IBrowserFile file);
    }
}
