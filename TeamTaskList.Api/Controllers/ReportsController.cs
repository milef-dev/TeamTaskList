using Microsoft.AspNetCore.Mvc;
using TeamTaskList.Application.Interfaces;

namespace TeamTaskList.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        //[HttpGet("performance/{userId}")]
        //public async Task<IActionResult> GetUserPerformance(Guid userId)
        //{
        //    var result = await _reportService.GetPerformanceReportAsync(userId);
        //    return Ok(result);
        //}
    }
}
