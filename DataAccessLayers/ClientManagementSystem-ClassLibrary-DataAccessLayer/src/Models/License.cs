namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class License(
    int?  licenseID,
    byte? licenseTypeID,
    int?  clientID
) {
    public int?  licenseID     { get; set; } = licenseID;
    public byte? licenseTypeID { get; set; } = licenseTypeID;
    public int?  clientID      { get; set; } = clientID;
}