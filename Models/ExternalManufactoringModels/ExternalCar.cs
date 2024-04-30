namespace Models;
using MongoDB.Bson.Serialization.Attributes;

//Ignored the _id field from the MongoDB
[BsonIgnoreExtraElements]
public class ExternalCar
{
     // Basic Information
     public BasicInformation BasicInformation { get; set; }
     
    // Mechanical Specifications
    public MechanicalSpecifications MechanicalSpecifications { get; set; }

    // Performance Metrics
    public PerformanceMetrics PerformanceMetrics { get; set; }

    // Safety Features
    public SafetyFeatures SafetyFeatures { get; set; }
    
    // Comfort and Convenience Features
    public ConvenienceFeatures ConvenienceFeatures { get; set; }
    
    // Exterior Features
    public ExteriorFeatures ExteriorFeatures { get; set; }

    // Interior Features
    public InteriorFeatures InteriorFeatures { get; set; }
   
    // Optional Packages and Accessories
    public OptionalPackagesAndAccessories OptionalPackagesAndAccessories { get; set; }
}