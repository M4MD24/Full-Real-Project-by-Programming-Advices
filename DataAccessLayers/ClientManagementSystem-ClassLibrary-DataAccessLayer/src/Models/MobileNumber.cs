namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class MobileNumber(
    int?    mobileNumberID,
    string? contactNumber,
    byte?   countryID
) {
    public int?    mobileNumberID { get; set; } = mobileNumberID;
    public string? contactNumber  { get; set; } = contactNumber;
    public byte?   countryID      { get; set; } = countryID;

    public MobileNumber(
        string? contactNumber,
        byte?   countryID
    ) : this(
        null,
        contactNumber,
        countryID
    ) {}
}