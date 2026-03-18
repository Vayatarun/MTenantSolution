using Microsoft.AspNetCore.Components.Forms;

namespace MTenantSolution.BlazorApp.Service
{
    public interface IFileService
    {
        Task<string> ReadFileAsync(string path);
        Task<string> UploadImageAsync(IBrowserFile file, string container);
        Task DeleteImageAsync(string fileName, string container);
    }
}
