namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Permission(
    byte?   permissionID,
    string? permissionName
) {
    public byte?   permissionID   { get; } = permissionID;
    public string? permissionName { get; } = permissionName;
}