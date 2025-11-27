namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class FullLicense(
    License?         license,
    LicenseType?     licenseType,
    LicenseIssuance? licenseIssuance,
    Coverage?        licenseCoverage
) {
    public License?         license         { get; set; } = license;
    public LicenseType?     licenseType     { get; set; } = licenseType;
    public LicenseIssuance? licenseIssuance { get; set; } = licenseIssuance;
    public Coverage?        licenseCoverage { get; set; } = licenseCoverage;
}