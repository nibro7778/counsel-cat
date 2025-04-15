using System.Text.Json;
using AdviceWrapper.Services;
using Microsoft.AspNetCore.Mvc;

namespace CounselCat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CounselCatController(AdviceService adviceService, ILogger<CounselCatController> logger) : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly AdviceService _adviceService = adviceService;
        private readonly ILogger<CounselCatController> _logger = logger;

        [HttpGet(Name = "advice")]
        public async Task<IActionResult> GetAsync()
        {
            var advice = await _adviceService.GetAdviceAsync();
            return Ok(advice);
        }
    }
}
