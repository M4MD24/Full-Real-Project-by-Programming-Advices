namespace AccountManagementSystem.Models;

public class Country {
    public byte?   countryID   { get; set; }
    public string? countryName { get; set; }
    public string? countryCode { get; set; }

    public Country(
        byte?   countryId,
        string? countryName,
        string? countryCode
    ) {
        countryID        = countryId;
        this.countryName = countryName;
        this.countryCode = countryCode;
    }

    public Country(
        string? countryName,
        string? countryCode
    ) {
        this.countryName = countryName;
        this.countryCode = countryCode;
    }
}