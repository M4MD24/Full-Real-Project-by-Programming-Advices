namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class LicenseIssuance(
    int? licenseIssuanceID,
    int? licenseIssuanceName
) {
    public int? licenseIssuanceID   { get; set; } = licenseIssuanceID;
    public int? licenseIssuanceName { get; set; } = licenseIssuanceName;
}