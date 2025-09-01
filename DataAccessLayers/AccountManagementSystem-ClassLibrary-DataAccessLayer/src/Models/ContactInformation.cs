namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class ContactInformation(
    int?    contactInformationID,
    int?    mobileNumberID,
    string? email
) {
    public int?    contactInformationID { get; set; } = contactInformationID;
    public int?    mobileNumberID       { get; set; } = mobileNumberID;
    public string? email                { get; set; } = email;

    public ContactInformation(
        int?    mobileNumberID,
        string? email
    ) : this(
        null,
        mobileNumberID,
        email
    ) {}
}