using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Services;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("/api/images")]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }
        
        [HttpGet("{imageId:guid}")]
        public async Task<IActionResult> GetImage(Guid imageId)
        {
            var imagePath = await _imageService.GetImagePath(imageId);
            
            return PhysicalFile(imagePath, "image/png");
        }
    }
}