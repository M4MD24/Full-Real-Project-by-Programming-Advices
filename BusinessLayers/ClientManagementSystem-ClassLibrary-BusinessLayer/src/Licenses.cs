using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Licenses {
    public static List<License>? getAll(
        ref int? clientID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.getAllLicensesByClientID(
        ref clientID
    );

    public static void delete(
        int? licenseID
    ) {
        throw new System.NotImplementedException();
    }

    public static void renew(
        int? licenseID
    ) {
        throw new System.NotImplementedException();
    }

    public static void replace(
        int? licenseID
    ) {
        throw new System.NotImplementedException();
    }
}