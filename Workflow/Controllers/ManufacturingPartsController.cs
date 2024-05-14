using Microsoft.AspNetCore.Mvc;
using Models;
using Workflow.Services;

namespace Workflow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManufacturingPartsController : ControllerBase
    {
        IHTTPService _HTTPService { get; set; }

        public ManufacturingPartsController(IHTTPService hTTPService)
        {
            _HTTPService = hTTPService;
        }

        [HttpGet("GetManufacturingParts")]
        public async Task<IActionResult> GetManufacturingParts(string regNr)
        {
            var externalCar = await _HTTPService.GetCarPartsAsync(regNr);
            if (externalCar != null)
            {
                return Ok(externalCar);
            }
            else
            {
                return StatusCode(404);
            }
        }
    }
}
