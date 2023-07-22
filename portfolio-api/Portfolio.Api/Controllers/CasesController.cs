using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Services;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("/api/cases")]
    public class CasesController : ControllerBase
    {
        private readonly ICaseService _caseService;

        public CasesController(ICaseService caseService)
        {
            _caseService = caseService;
        }

        [HttpGet("previews")]
        public async Task<IActionResult> GetCasesPreviews()
        {
            var casesPreviews = await _caseService.GetCasesPreviews();
            
            return Ok(casesPreviews);
        }

        [HttpGet("{caseId:guid}")]
        public async Task<IActionResult> GetCase(Guid caseId)
        {
            var @case = await _caseService.GetCase(caseId);

            return Ok(@case);
        }
    }
}