using InternalManufacturingService.Repositories;
using Models;

namespace InternalManufacturingService.Services;

public class CarService: ICarService
{
    private readonly ICarRepository _repository;

    public CarService(ICarRepository repository)
    {
        _repository = repository;
    }
    
    public ExternalCar GetCar(string regNumber){
        // Check for car in repo (DB)
        // If found => return car
        // Else call ExernalManufacturingService
        // If found => save car in repo (DB) and return car
        // Else return null
        return _repository.GetByRegistrationNumber(regNumber);
    }
    
    public void SaveCar(ExternalCar car){
        _repository.InsertOne(car);
    }
}