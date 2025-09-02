namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Country(
    byte?   countryID,
    string? countryName,
    string? countryCode
) {
    public byte?   countryID   { get; } = countryID;
    public string? countryName { get; } = countryName;
    public string? countryCode { get; } = countryCode;
}