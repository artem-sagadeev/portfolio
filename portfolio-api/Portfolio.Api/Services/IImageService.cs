namespace Portfolio.Api.Services
{
    public interface IImageService
    {
        Task<string> GetImagePath(Guid imageId);
    }
}