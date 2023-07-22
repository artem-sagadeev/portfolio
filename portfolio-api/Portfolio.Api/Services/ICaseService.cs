using Portfolio.Api.Models;

namespace Portfolio.Api.Services
{
    public interface ICaseService
    {
        Task<List<CasePreviewModel>> GetCasesPreviews();

        Task<CaseModel> GetCase(Guid caseId);
    }
}