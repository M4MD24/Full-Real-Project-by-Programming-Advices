using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class UnlockLicense(
    int?      unlockLicenseID,
    int?      licenseID,
    DateTime? dateTimeUnlock,
    int?      paymentID
) {
    public int?      unlockLicenseID { get; set; } = unlockLicenseID;
    public int?      licenseID       { get; set; } = licenseID;
    public DateTime? dateTimeUnlock  { get; set; } = dateTimeUnlock;
    public int?      paymentID       { get; set; } = paymentID;
}