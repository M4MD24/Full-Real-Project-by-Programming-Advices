using System.Collections.Generic;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public static class Permissions {
    public static Permission? get(
        ref byte permissionID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Permissions.getPermissionByPermissionID(
        ref permissionID
    );
    public static Permission? get(
        ref string permissionName
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Permissions.getPermissionByPermissionName(
        ref permissionName
    );

    public static List<Permission>? getAll() => AccountManagementSystem_ClassLibrary_DataAccessLayer.Permissions.getAllPermissions();
}