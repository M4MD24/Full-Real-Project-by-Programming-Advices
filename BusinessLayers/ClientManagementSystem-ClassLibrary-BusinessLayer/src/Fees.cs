using System.Collections.Generic;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Fees {
    public static List<ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees>? getAll() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Fees.getAllFees();

    public static ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees? get(
        ref byte countryID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Fees.getFeesByFeesID(
        ref countryID
    );
}