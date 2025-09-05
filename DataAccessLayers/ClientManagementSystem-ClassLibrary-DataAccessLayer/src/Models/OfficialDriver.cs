namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class OfficialDriver(
    int? officialDriverID,
    int? requestID
) {
    public int? officialDriverID { get; set; } = officialDriverID;
    public int? requestID        { get; set; } = requestID;
}