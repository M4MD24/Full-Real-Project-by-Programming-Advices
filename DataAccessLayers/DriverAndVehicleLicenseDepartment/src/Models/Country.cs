namespace DriverAndVehicleLicenseDepartment.Models;

public class Country(
    byte?   countryID,
    string? countryName,
    string? countryCode
) {
    public byte?   countryID   { get; set; } = countryID;
    public string? countryName { get; set; } = countryName;
    public string? countryCode { get; set; } = countryCode;

    public Country(
        string? countryName,
        string? countryCode
    ) : this(
        null,
        countryName,
        countryCode
    ) {}
}