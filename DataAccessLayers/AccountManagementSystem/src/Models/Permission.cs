namespace AccountManagementSystem.Models;

public class Permission(
    byte?   permissionID,
    string? permissionName
) {
    public byte?   permissionID   { get; set; } = permissionID;
    public string? permissionName { get; set; } = permissionName;

    public Permission(
        string? permissionName
    ) : this(
        null,
        permissionName
    ) {}
}