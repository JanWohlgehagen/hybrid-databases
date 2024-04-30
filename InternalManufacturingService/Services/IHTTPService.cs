using Models;

namespace InternalManufacturingService.Services;

public interface IHTTPService
{ 
    Task<ExternalCar> GetCarPartsAsync(string registrationNumber);
}