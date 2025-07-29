namespace AccountManagementSystem.Models;

public class AccountPermission(
    int?  accountID,
    byte? permissionID
) {
    public int?  accountID    { get; } = accountID;
    public byte? permissionID { get; } = permissionID;
}