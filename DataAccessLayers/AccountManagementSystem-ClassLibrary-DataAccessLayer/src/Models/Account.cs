namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Account(
    int?    accountID,
    int?    personID,
    string? username,
    string? password,
    bool?   isActive,
    byte?   accountTypeID
) {
    public int?    accountID     { get; set; } = accountID;
    public int?    personID      { get; }      = personID;
    public string? username      { get; }      = username;
    public string? password      { get; }      = password;
    public bool?   isActive      { get; }      = isActive;
    public byte?   accountTypeID { get; }      = accountTypeID;

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