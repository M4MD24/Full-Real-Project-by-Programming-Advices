namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class DrivingExaminer(
    int? damagedLicenseReplacementID,
    int? licenseID
) {
    public int? damagedLicenseReplacementID { get; set; } = damagedLicenseReplacementID;
    public int? licenseID                   { get; set; } = licenseID;
}