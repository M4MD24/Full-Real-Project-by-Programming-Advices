namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class LicenseIssuance(
    int?    licenseIssuanceID,
    string? licenseIssuanceName
) {
    public int?    licenseIssuanceID   { get; set; } = licenseIssuanceID;
    public string? licenseIssuanceName { get; set; } = licenseIssuanceName;
}