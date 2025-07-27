namespace AccountManagementSystem.Models;

public class ContactInformation(
    int?    contactInformationID,
    string? phoneNumber,
    string? email
) {
    public int?    contactInformationID { get; set; } = contactInformationID;
    public string? phoneNumber          { get; set; } = phoneNumber;
    public string? email                { get; set; } = email;

    public ContactInformation(
        string? phoneNumber,
        string? email
    ) : this(
        null,
        phoneNumber,
        email
    ) {}
}