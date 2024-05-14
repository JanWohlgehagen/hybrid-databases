using Models;

namespace Workflow.Services;

public interface IHTTPService
{ 
    Task<ExternalCar> GetCarPartsAsync(string registrationNumber);
}