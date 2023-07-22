using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Models;

namespace Portfolio.Api.Services
{
    public class CaseService : ICaseService
    {
        private readonly ApplicationContext _context;
        
        public CaseService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<CasePreviewModel>> GetCasesPreviews()
        {
            var cases = await _context.Cases.Include(@case => @case.PreviewImage).ToListAsync();

            return cases.Select(@case => new CasePreviewModel
            {
                Id = @case.Id,
                Title = @case.Title,
                ShortDescription = @case.ShortDescription,
                PreviewImagePath = @case.PreviewImage.Path
            }).ToList();
        }
        
        public async Task<CaseModel> GetCase(Guid caseId)
        {
            var @case = await _context.Cases
                .Include(@case => @case.PreviewImage)
                .Include(@case => @case.MainImage)
                .SingleAsync(@case => @case.Id == caseId);

            return new CaseModel
            {
                Id = @case.Id,
                Title = @case.Title,
                ShortDescription = @case.ShortDescription,
                PreviewImagePath = @case.PreviewImage.Path,
                MainImagePath = @case.MainImage.Path
            };
        }
    }
}