namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public static class AccountPermissions {
    public static int delete(
        ref int  accountID,
        ref byte permissionID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountPermissions.deleteAccountPermission(
        ref accountID,
        ref permissionID
    );

    public static int deleteAll(
        ref int? accountID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountPermissions.deleteAccountPermissionsByAccountID(
        ref accountID
    );

    public static int add(
        ref AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermission accountPermissions
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountPermissions.addAccountPermission(
        ref accountPermissions
    );

    public static AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermissions? getAll(
        ref int? accountID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountPermissions.getAccountPermissionsByAccountID(
        ref accountID
    );

    public static void addAll(
        ref AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermissions accountPermissions
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountPermissions.addAllAccountPermissions(
        ref accountPermissions
    );
}