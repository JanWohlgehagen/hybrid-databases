using InternalManufacturingService.Services;
using Microsoft.AspNetCore.Mvc;

namespace InternalManufacturingService.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    
    private readonly ICarService _carService;
    
    public CarController(ICarService carService)
    {
        _carService = carService;
    }
    
    [HttpGet(Name = "GetCarParts")]
    public IActionResult Get(String registrationNumber)
    {
        // Look up car in service and return it
        return Ok();
    }
}