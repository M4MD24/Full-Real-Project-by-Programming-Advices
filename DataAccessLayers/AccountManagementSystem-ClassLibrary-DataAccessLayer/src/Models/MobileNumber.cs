namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class MobileNumber(
    int?    mobileNumberID,
    string? contactNumber,
    byte?   countryID
) {
    public int?    mobileNumberID { get; } = mobileNumberID;
    public string? contactNumber  { get; } = contactNumber;
    public byte?   countryID      { get; } = countryID;

    public MobileNumber(
        string? contactNumber,
        byte?   countryID
    ) : this(
        null,
        contactNumber,
        countryID
    ) {}
}