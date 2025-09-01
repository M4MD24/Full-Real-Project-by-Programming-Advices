using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public static class FullNames {
    public static int update(
        ref FullName fullName
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.FullNames.updateFullNameByFullNameID(
        ref fullName
    );

    public static int delete(
        ref int? fullNameID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.FullNames.deleteFullNameByFullNameID(
        ref fullNameID
    );

    public static int add(
        ref FullName fullName
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.FullNames.addNewFullName(
        ref fullName
    );

    public static FullName? get(
        ref int? fullNameID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.FullNames.getFullNameByFullNameID(
        ref fullNameID
    );
}