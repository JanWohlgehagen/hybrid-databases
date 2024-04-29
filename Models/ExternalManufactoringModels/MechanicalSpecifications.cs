namespace Models;

public class MechanicalSpecifications
{
    public string EngineType { get; set; }
    public double EngineDisplacement { get; set; }
    public int NumberOfCylinders { get; set; }
    public int Horsepower { get; set; }
    public int Torque { get; set; }
    public string FuelType { get; set; }
    public double FuelTankCapacity { get; set; }
    public string TransmissionType { get; set; }
    public string DriveType { get; set; }
    public string SuspensionType { get; set; }
    public string BrakeType { get; set; }
    public string SteeringType { get; set; }
    public string WheelSize { get; set; }
    public string TireSize { get; set; }
}