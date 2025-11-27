using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public static class FullLicenses {
    public static FullLicense get(
        ref int? licenseID
    ) {
        License? license = ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.getLicenseByLicenseID(
            ref licenseID
        );

        byte? licenseTypeID = license!.licenseTypeID;
        LicenseType? licenseType = ClientManagementSystem_ClassLibrary_DataAccessLayer.LicenseTypes.getLicenseTypeByLicenseTypeID(
            ref licenseTypeID
        );

        byte? licenseIssuanceID = license.licenseIssuanceID;
        LicenseIssuance? licenseIssuance = ClientManagementSystem_ClassLibrary_DataAccessLayer.LicenseIssuances.getLicenseIssuanceByLicenseIssuanceID(
            ref licenseIssuanceID
        );

        byte? licenseCoverageID = license.licenseCoverageID;
        Coverage? licenseCoverage = ClientManagementSystem_ClassLibrary_DataAccessLayer.Coverages.getCoverageByCoverageID(
            ref licenseCoverageID
        );

        return new FullLicense(
            license,
            licenseType,
            licenseIssuance,
            licenseCoverage
        );
    }
}