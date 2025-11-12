using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Tests {
    public static int add(
        Test test
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Tests.addNewTest(
        ref test
    );

    public static Constants.NextTestStatus getNextRequiredTest(
        int? licenseID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Tests.getNextRequiredTest(
        licenseID
    );
}