using InternalManufacturingService.Repositories;
using Models;

namespace InternalManufacturingService.Services;

public class CarService: ICarService
{
    private readonly ICarRepository _repository;
    private readonly IHTTPService _httpService;

    public CarService(ICarRepository repository, IHTTPService httpService)
    {
        _repository = repository;
        _httpService = httpService;
    }
    
    public ExternalCar GetCar(string regNumber){
        var car = _repository.GetByRegistrationNumber(regNumber);
        // Check for car in repo (DB)

        if (car != null)
        {
            Console.WriteLine("Car was found in database. Car is returned and execution stops.");
            // If found => return car
            return car;
        }

        Console.WriteLine("Car could not be found in database. Fetching from external service.");
        // Else call ExernalManufacturingService
        car = _httpService.GetCarPartsAsync(regNumber).Result;
        
        if (car != null)
        {
            Console.WriteLine("Car was fetched from external service and will now be saved the database.");
            // If found => save car in repo (DB) and return car
            SaveCar(car);
            return car;
        }
        
        // Else return null
        Console.WriteLine("Car was not found in database or external service. Returning null.");
        return null;
    }
    
    public void SaveCar(ExternalCar car){
        _repository.InsertOne(car);
        Console.WriteLine("Car was saved in database.");
    }
}