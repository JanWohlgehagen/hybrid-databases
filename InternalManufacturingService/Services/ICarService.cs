using Models;

namespace InternalManufacturingService.Services;

public interface ICarService
{
    ExternalCar GetCar(string regNumber);

    void SaveCar(ExternalCar car);
}