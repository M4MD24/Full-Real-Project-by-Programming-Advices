using System.Collections.Generic;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class AccountPermissions(
    int?        accountID,
    List<byte>? permissionIDs
) {
    public int?        accountID     { get; } = accountID;
    public List<byte>? permissionIDs { get; } = permissionIDs;
}