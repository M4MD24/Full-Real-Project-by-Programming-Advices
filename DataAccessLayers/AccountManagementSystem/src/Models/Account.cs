namespace AccountManagementSystem.Models;

public class Account(
    int?    accountID,
    int?    personID,
    string? username,
    string? password,
    bool?   isActive,
    byte?   accountTypeID
) {
    public int?    accountID     { get; set; } = accountID;
    public int?    personID      { get; set; } = personID;
    public string? username      { get; set; } = username;
    public string? password      { get; set; } = password;
    public bool?   isActive      { get; set; } = isActive;
    public byte?   accountTypeID { get; set; } = accountTypeID;

    public Account(
        int?    personID,
        string? username,
        string? password,
        bool?   isActive,
        byte?   accountTypeID
    ) : this(
        null,
        personID,
        username,
        password,
        isActive,
        accountTypeID
    ) {}
}