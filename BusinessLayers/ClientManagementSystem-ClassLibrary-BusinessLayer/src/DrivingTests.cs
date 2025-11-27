using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class DrivingTests {
    public static void add(
        DrivingTest drivingTest
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.DrivingTests.addNewTest(
        ref drivingTest
    );
}