using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Payments {
    public static int? add(
        Payment payment
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Payments.addNewPayment(
        payment
    );
}