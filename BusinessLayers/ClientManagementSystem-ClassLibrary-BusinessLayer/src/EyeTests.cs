using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class EyeTests {
    public static void add(
        EyeTest testID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.EyeTests.addNewTest(
        ref testID
    );
}