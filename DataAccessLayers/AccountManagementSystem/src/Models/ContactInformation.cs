namespace AccountManagementSystem.Models;

public class ContactInformation {
    public int?    contactInformationID { get; set; }
    public string? phoneNumber          { get; set; }
    public string? email                { get; set; }

    public ContactInformation(
        int    contactInformationID,
        string phoneNumber,
        string email
    ) {
        this.contactInformationID = contactInformationID;
        this.phoneNumber          = phoneNumber;
        this.email                = email;
    }

    public ContactInformation(
        string phoneNumber,
        string email
    ) {
        this.phoneNumber = phoneNumber;
        this.email       = email;
    }
}