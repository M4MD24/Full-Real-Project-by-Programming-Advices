using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Requests {
    public static int? add(
        Request request
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Requests.addNewRequest(
        ref request
    );
}