using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Tests {
    public static int add(
        Test test
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Tests.addNewTest(
        ref test
    );
}