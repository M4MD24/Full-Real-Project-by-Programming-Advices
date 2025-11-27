namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class LicenseType(
    byte?   licenseTypeID,
    string? name,
    string? description,
    byte?   minimumAge,
    byte?   duration
) {
    public byte?   licenseTypeID { get; set; } = licenseTypeID;
    public string? name          { get; set; } = name;
    public string? description   { get; set; } = description;
    public byte?   minimumAge    { get; set; } = minimumAge;
    public byte?   duration      { get; set; } = duration;

    public LicenseType(
        string name,
        string description,
        byte   minimumAge,
        byte   duration
    ) : this(
        null,
        name,
        description,
        minimumAge,
        duration
    ) {}
}