using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class TheoreticalTests {
    public static void add(
        TheoreticalTest theoreticalTest
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.TheoreticalTests.addNewTest(
        ref theoreticalTest
    );
}