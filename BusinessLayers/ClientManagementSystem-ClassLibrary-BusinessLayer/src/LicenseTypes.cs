using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class LicenseTypes {
    public static List<string>? getAllLicenseTypeNames() => ClientManagementSystem_ClassLibrary_DataAccessLayer.LicenseTypes.getAllLicenseTypeNames();

    public static LicenseType? get(
        string name
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.LicenseTypes.getLicenseTypeByName(
        ref name
    );
}