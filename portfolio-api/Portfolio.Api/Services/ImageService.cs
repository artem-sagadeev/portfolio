using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Api.Services
{
    public class ImageService : IImageService
    {
        private readonly ApplicationContext _context;

        public ImageService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<string> GetImagePath(Guid imageId)
        {
            var image = await _context.Images.FirstAsync(image => image.Id == imageId);

            return Path.Combine(Directory.GetCurrentDirectory(), $"./Images/{image.Path}");
        }
    }
}