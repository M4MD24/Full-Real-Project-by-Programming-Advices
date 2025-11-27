using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Licenses {
    public static List<License>? getAll(
        ref int? clientID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.getAllLicensesByClientID(
        ref clientID
    );

    public static int delete(
        int? licenseID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.deleteByLicenseID(
        ref licenseID
    );

    public static int renew(
        int? licenseID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.renewByLicenseID(
        ref licenseID
    );

    public static int replace(
        int?                  licenseID,
        Constants.ReplaceMode replaceMode
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.replaceByLicenseID(
        ref licenseID,
        replaceMode
    );

    public static int? add(
        License license
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.addNewLicense(
        ref license
    );

    public static License? get(
        int? licenseID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Licenses.getLicenseByLicenseID(
        ref licenseID
    );
}