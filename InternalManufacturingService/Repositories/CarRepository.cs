using InternalManufacturingService.Data;
using Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InternalManufacturingService.Repositories;

public class CarRepository: ICarRepository
{
    private readonly MongoDBClient _client;
    private readonly string _databaseName;
    private readonly string _collectionName;
    
    public CarRepository(string databaseName = "ManufacturedCars", string collectionName = "Cars")
    {
        _client = new MongoDBClient("mongodb://mongodb:27017");
        _databaseName = databaseName;
        _collectionName = collectionName;
    }
    
    public ExternalCar GetByRegistrationNumber(string regNumber)
    {
        
        var collection = _client.Collection<ExternalCar>(_databaseName, _collectionName);
        var car = collection.Find(x => x.BasicInformation.RegistrationNumber == regNumber).FirstOrDefault();
        return car;
    }

    public void InsertOne(ExternalCar car)
    {
        var collection = _client.Collection<ExternalCar>(_databaseName, _collectionName);
        collection.InsertOne(car);
    }
}