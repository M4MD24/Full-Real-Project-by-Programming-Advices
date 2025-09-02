namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class ContactInformation(
    int?    contactInformationID,
    int?    mobileNumberID,
    string? email
) {
    public int?    contactInformationID { get; } = contactInformationID;
    public int?    mobileNumberID       { get; } = mobileNumberID;
    public string? email                { get; } = email;

    public ContactInformation(
        int?    mobileNumberID,
        string? email
    ) : this(
        null,
        mobileNumberID,
        email
    ) {}
}