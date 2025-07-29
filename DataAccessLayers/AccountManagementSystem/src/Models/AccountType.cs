namespace AccountManagementSystem.Models;

public class AccountType(
    byte?   accountTypeID,
    string? accountTypeName
) {
    public byte?   accountTypeID   { get; set; } = accountTypeID;
    public string? accountTypeName { get; set; } = accountTypeName;

    public AccountType(
        string? accountTypeName
    ) : this(
        null,
        accountTypeName
    ) {}
}