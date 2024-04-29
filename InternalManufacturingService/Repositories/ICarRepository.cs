using Models;

namespace InternalManufacturingService.Repositories;

public interface ICarRepository
{
    ExternalCar GetByRegistrationNumber(string regNumber);

    void InsertOne(ExternalCar car);
}