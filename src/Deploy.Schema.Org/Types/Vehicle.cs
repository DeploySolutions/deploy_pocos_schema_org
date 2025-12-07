using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
    public partial class Vehicle : Product
    {
        public Vehicle()
        {
            Type = "Vehicle";
        }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("accelerationTime")]
        public virtual QuantitativeValue? AccelerationTime { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("bodyType")]
        public virtual object? BodyType { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("callSign")]
        public virtual string? CallSign { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("cargoVolume")]
        public virtual QuantitativeValue? CargoVolume { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("dateVehicleFirstRegistered")]
        public virtual DateTime? DateVehicleFirstRegistered { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("driveWheelConfiguration")]
        public virtual object? DriveWheelConfiguration { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("emissionsCO2")]
        public virtual double? EmissionsCO2 { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("fuelCapacity")]
        public virtual QuantitativeValue? FuelCapacity { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("fuelConsumption")]
        public virtual QuantitativeValue? FuelConsumption { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("fuelEfficiency")]
        public virtual QuantitativeValue? FuelEfficiency { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("fuelType")]
        public virtual object? FuelType { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("knownVehicleDamages")]
        public virtual string? KnownVehicleDamages { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("meetsEmissionStandard")]
        public virtual object? MeetsEmissionStandard { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("mileageFromOdometer")]
        public virtual QuantitativeValue? MileageFromOdometer { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("modelDate")]
        public virtual DateTime? ModelDate { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("numberOfAirbags")]
        public virtual object? NumberOfAirbags { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("numberOfAxles")]
        public virtual object? NumberOfAxles { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("numberOfDoors")]
        public virtual object? NumberOfDoors { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("numberOfForwardGears")]
        public virtual object? NumberOfForwardGears { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("numberOfPreviousOwners")]
        public virtual object? NumberOfPreviousOwners { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("payload")]
        public virtual QuantitativeValue? Payload { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("productionDate")]
        public virtual DateTime? ProductionDate { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("purchaseDate")]
        public virtual DateTime? PurchaseDate { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("seatingCapacity")]
        public virtual object? SeatingCapacity { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("speed")]
        public virtual QuantitativeValue? Speed { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("steeringPosition")]
        public virtual SteeringPositionValue? SteeringPosition { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("stupidProperty")]
        public virtual QuantitativeValue? StupidProperty { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("tongueWeight")]
        public virtual QuantitativeValue? TongueWeight { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("trailerWeight")]
        public virtual QuantitativeValue? TrailerWeight { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleConfiguration")]
        public virtual string? VehicleConfiguration { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleEngine")]
        public virtual EngineSpecification? VehicleEngine { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleIdentificationNumber")]
        public virtual string? VehicleIdentificationNumber { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleInteriorColor")]
        public virtual string? VehicleInteriorColor { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleInteriorType")]
        public virtual string? VehicleInteriorType { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleModelDate")]
        public virtual DateTime? VehicleModelDate { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleSeatingCapacity")]
        public virtual object? VehicleSeatingCapacity { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleSpecialUsage")]
        public virtual object? VehicleSpecialUsage { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("vehicleTransmission")]
        public virtual object? VehicleTransmission { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("weightTotal")]
        public virtual QuantitativeValue? WeightTotal { get; set; }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
        [JsonPropertyName("wheelbase")]
        public virtual QuantitativeValue? Wheelbase { get; set; }

    }
}
