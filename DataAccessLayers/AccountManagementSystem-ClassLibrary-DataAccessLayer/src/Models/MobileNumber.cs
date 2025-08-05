namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class MobileNumber(
    int?    mobileNumberID,
    string? contactNumber,
    int?    countryID
) {
    public int?    mobileNumberID { get; set; } = mobileNumberID;
    public string? contactNumber  { get; set; } = contactNumber;
    public int?    countryID      { get; set; } = countryID;

    public MobileNumber(
        string? contactNumber,
        int?    countryID
    ) : this(
        null,
        contactNumber,
        countryID
    ) {}
}