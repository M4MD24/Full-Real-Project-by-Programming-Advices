namespace AccountManagementSystem.Models;

public class ContactInformation {
    public byte?   contactInformationID { get; set; }
    public string? phoneNumber          { get; set; }
    public string? email                { get; set; }

    public ContactInformation(
        byte   contactInformationID,
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