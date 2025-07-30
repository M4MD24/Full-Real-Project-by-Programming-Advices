namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class FullName(
    int?    fullNameID,
    string? firstName,
    string? secondName,
    string? thirdName,
    string? fourthName
) {
    public int?    fullNameID { get; set; } = fullNameID;
    public string? firstName  { get; set; } = firstName;
    public string? secondName { get; set; } = secondName;
    public string? thirdName  { get; set; } = thirdName;
    public string? fourthName { get; set; } = fourthName;

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