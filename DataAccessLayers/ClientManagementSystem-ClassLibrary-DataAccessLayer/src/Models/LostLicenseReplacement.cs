namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class LostLicenseReplacement(
    int? lostLicenseReplacementID,
    int? licenseID
) {
    public int? lostLicenseReplacementID { get; set; } = lostLicenseReplacementID;
    public int? licenseID                { get; set; } = licenseID;
}