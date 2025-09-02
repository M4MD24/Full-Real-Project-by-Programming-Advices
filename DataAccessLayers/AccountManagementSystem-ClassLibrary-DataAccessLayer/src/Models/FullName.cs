namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class FullName(
    int?    fullNameID,
    string? firstName,
    string? secondName,
    string? thirdName,
    string? fourthName
) {
    public int?    fullNameID { get; } = fullNameID;
    public string? firstName  { get; } = firstName;
    public string? secondName { get; } = secondName;
    public string? thirdName  { get; } = thirdName;
    public string? fourthName { get; } = fourthName;

    public FullName(
        string? firstName,
        string? secondName,
        string? thirdName,
        string? fourthName
    ) : this(
        null,
        firstName,
        secondName,
        thirdName,
        fourthName
    ) {}
}