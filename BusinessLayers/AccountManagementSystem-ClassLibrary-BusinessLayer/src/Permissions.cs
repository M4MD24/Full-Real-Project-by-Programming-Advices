using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public class Permissions {
    public static Permission? get(
        ref byte permissioonID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Permissions.getPermissionByPermissionID(
        ref permissioonID
    );
}