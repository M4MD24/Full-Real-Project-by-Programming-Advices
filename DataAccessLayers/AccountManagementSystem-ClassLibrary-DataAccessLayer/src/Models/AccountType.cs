namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class AccountType(
    byte?   accountTypeID,
    string? accountTypeName
) {
    public byte?   accountTypeID   { get; } = accountTypeID;
    public string? accountTypeName { get; } = accountTypeName;
}