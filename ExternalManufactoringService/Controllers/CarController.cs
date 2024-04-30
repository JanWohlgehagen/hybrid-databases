using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ExternalManufactoringService.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    
    [HttpGet(Name = "GetCarParts")]
    public IActionResult Get(String registrationNumber)
    {
        
        ExternalCar car = new ExternalCar();
        
        car.BasicInformation = new BasicInformation();
        car.BasicInformation.Make = "Toyota";
        car.BasicInformation.Model = "Camry";
        car.BasicInformation.Year = 2022;
        car.BasicInformation.VIN = "1HGCM82633A001234";
        car.BasicInformation.RegistrationNumber = registrationNumber;
        car.BasicInformation.Color = "Silver";
        car.BasicInformation.BodyStyle = "Sedan";
        car.BasicInformation.NumberOfDoors = 4;
        car.BasicInformation.NumberOfSeats = 5;
        car.BasicInformation.CountryOfManufacture = "Japan";

        car.MechanicalSpecifications = new MechanicalSpecifications();
        car.MechanicalSpecifications.EngineType = "Inline-4";
        car.MechanicalSpecifications.EngineDisplacement = 2.5;
        car.MechanicalSpecifications.NumberOfCylinders = 4;
        car.MechanicalSpecifications.Horsepower = 203;
        car.MechanicalSpecifications.Torque = 184;
        car.MechanicalSpecifications.FuelType = "Gasoline";
        car.MechanicalSpecifications.FuelTankCapacity = 15.8;
        car.MechanicalSpecifications.TransmissionType = "Automatic";
        car.MechanicalSpecifications.DriveType = "Front-Wheel Drive";
        car.MechanicalSpecifications.SuspensionType = "MacPherson Strut (Front), Double Wishbone (Rear)";
        car.MechanicalSpecifications.BrakeType = "Disc";
        car.MechanicalSpecifications.SteeringType = "Electric Power Steering";
        car.MechanicalSpecifications.WheelSize = "17 inches";
        car.MechanicalSpecifications.TireSize = "P215/55R17";

        car.PerformanceMetrics = new PerformanceMetrics();
        car.PerformanceMetrics.Acceleration = 7.9;
        car.PerformanceMetrics.TopSpeed = 135;
        car.PerformanceMetrics.FuelEfficiency = 32.5;

        car.SafetyFeatures = new SafetyFeatures();
        car.SafetyFeatures.HasAirbags = true;
        car.SafetyFeatures.HasABS = true;
        car.SafetyFeatures.HasESC = true;
        car.SafetyFeatures.HasTCS = true;
        car.SafetyFeatures.HasBlindSpotMonitoring = true;
        car.SafetyFeatures.HasLaneDepartureWarning = true;
        car.SafetyFeatures.HasForwardCollisionWarning = true;
        car.SafetyFeatures.HasAutomaticEmergencyBraking = true;
        car.SafetyFeatures.HasAdaptiveCruiseControl = true;
        car.SafetyFeatures.HasRearviewCamera = true;
        car.SafetyFeatures.HasParkingSensors = true;
        car.SafetyFeatures.HasTPMS = true;
        car.SafetyFeatures.HasChildSafetyLocks = true;
        car.SafetyFeatures.HasAntiTheftSystem = true;

        car.ConvenienceFeatures = new ConvenienceFeatures();
        car.ConvenienceFeatures.HasAC = true;
        car.ConvenienceFeatures.HasHeating = true;
        car.ConvenienceFeatures.HasPowerWindows = true;
        car.ConvenienceFeatures.HasPowerDoorLocks = true;
        car.ConvenienceFeatures.HasPowerMirrors = true;
        car.ConvenienceFeatures.HasKeylessEntry = true;
        car.ConvenienceFeatures.HasRemoteStart = true;
        car.ConvenienceFeatures.HasPushButtonStart = true;
        car.ConvenienceFeatures.HasInfotainmentSystem = true;
        car.ConvenienceFeatures.HasNavigationSystem = true;
        car.ConvenienceFeatures.HasBluetoothConnectivity = true;
        car.ConvenienceFeatures.HasUSBPorts = true;
        car.ConvenienceFeatures.HasAuxiliaryInput = true;
        car.ConvenienceFeatures.HasSmartphoneIntegration = true;
        car.ConvenienceFeatures.HasWiFiHotspot = true;
        car.ConvenienceFeatures.HasWirelessPhoneCharging = true;
        car.ConvenienceFeatures.HasSteeringWheelControls = true;
        car.ConvenienceFeatures.HasCruiseControl = true;
        car.ConvenienceFeatures.HasAdjustableSeats = true;
        car.ConvenienceFeatures.HasAdjustableSteeringWheel = true;
        car.ConvenienceFeatures.HasSunroof = true;
        car.ConvenienceFeatures.HasFoldableRearSeats = true;
        car.ConvenienceFeatures.CargoSpace = 15;

        car.ExteriorFeatures = new ExteriorFeatures();
        car.ExteriorFeatures.HasAlloyWheels = true;
        car.ExteriorFeatures.HasFogLights = true;
        car.ExteriorFeatures.HasLEDHeadlights = true;
        car.ExteriorFeatures.HasRoofRails = false;
        car.ExteriorFeatures.HasSpoiler = false;
        car.ExteriorFeatures.HasTintedWindows = true;
        car.ExteriorFeatures.HasPowerLiftgate = false;
        car.ExteriorFeatures.HasRunningBoards = false;
        car.ExteriorFeatures.HasTowingPackage = false;
        car.ExteriorFeatures.HasRainSensingWipers = true;
        car.ExteriorFeatures.HasAutoDimmingMirrors = true;

        car.InteriorFeatures = new InteriorFeatures();
        car.InteriorFeatures.HasLeatherSeats = true;
        car.InteriorFeatures.HasClothSeats = false;
        car.InteriorFeatures.HasLeatherSteeringWheel = true;
        car.InteriorFeatures.HasWoodTrim = false;
        car.InteriorFeatures.HasCarbonFiberTrim = false;
        car.InteriorFeatures.HasAmbientLighting = true;
        car.InteriorFeatures.NumberOfCupHolders = 4;
        car.InteriorFeatures.HasCenterConsoleStorage = true;
        car.InteriorFeatures.HasGloveCompartment = true;
        car.InteriorFeatures.HasDoorPockets = true;
        car.InteriorFeatures.HasSunglassesHolder = true;
        car.InteriorFeatures.HasVanityMirrors = true;
        car.InteriorFeatures.HasFloorMats = true;

        car.OptionalPackagesAndAccessories = new OptionalPackagesAndAccessories();
        car.OptionalPackagesAndAccessories.HasPremiumSoundSystem = true;
        car.OptionalPackagesAndAccessories.HasUpgradedWheels = false;
        car.OptionalPackagesAndAccessories.HasPerformanceUpgrades = false;
        car.OptionalPackagesAndAccessories.HasColdWeatherPackage = true;
        car.OptionalPackagesAndAccessories.HasTechnologyPackage = true;
        car.OptionalPackagesAndAccessories.HasLuxuryPackage = false;
        car.OptionalPackagesAndAccessories.HasOffRoadPackage = false;
        car.OptionalPackagesAndAccessories.HasAppearancePackage = false;
        car.OptionalPackagesAndAccessories.HasSportPackage = false;

        Console.WriteLine("I was hit and I returned a car!");
        return Ok(car);
    }
}