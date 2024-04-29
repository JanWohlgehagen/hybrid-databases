using MongoDB.Driver;

namespace InternalManufacturingService.Data;

public class MongoDBClient 
{
    private readonly string _connectionString;
    private IMongoClient _client;
    
    public MongoDBClient(string connectionString)
    {
        _connectionString = connectionString;
        Connect();
    }

    public void Connect()
    {
        _client = new MongoClient(_connectionString);
    }

    public IMongoCollection<T> Collection<T>(string databaseName, string collectionName)
    {
        return _client.GetDatabase(databaseName).GetCollection<T>(collectionName);
    }
}