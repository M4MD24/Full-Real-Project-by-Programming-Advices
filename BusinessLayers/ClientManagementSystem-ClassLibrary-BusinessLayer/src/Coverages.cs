using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Coverages {
    public static List<string>? getAllCoverageNames() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Coverages.getAllCoverageNames();

    public static Coverage? get(
        string coverageName
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Coverages.getCoverageByCoverageName(
        coverageName
    );
}