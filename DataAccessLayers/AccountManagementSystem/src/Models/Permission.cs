namespace AccountManagementSystem.Models;

public class Permission(
    byte?   PermissionID,
    string? PermissionName
) {
    public byte?   countryID      { get; set; } = PermissionID;
    public string? PermissionName { get; set; } = PermissionName;

    public Permission(
        string? PermissionName
    ) : this(
        null,
        PermissionName
    ) {}
}