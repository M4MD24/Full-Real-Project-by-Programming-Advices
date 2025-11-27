using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Requests {
    public static int? add(
        Request request
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Requests.addNewRequest(
        ref request
    );

    public static List<Request>? getAll(
        ref int? clientID,
        ref int? licenseID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Requests.getAllRequests(
        ref clientID,
        ref licenseID
    );

    public static Request? get(
        int? licenseID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Requests.getRequestByLicenseID(
        ref licenseID
    );
}