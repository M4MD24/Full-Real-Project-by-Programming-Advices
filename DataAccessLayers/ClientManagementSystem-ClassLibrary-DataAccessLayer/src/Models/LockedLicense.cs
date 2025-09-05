namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class LockedLicense(
    int? lockedLicenseID,
    int? licenseID
) {
    public int? lockedLicenseID { get; set; } = lockedLicenseID;
    public int? licenseID       { get; set; } = licenseID;
}