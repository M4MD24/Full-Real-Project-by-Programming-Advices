namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Clients(
    int? clientID,
    int? personID
) {
    public int? clientID { get; set; } = clientID;
    public int? personID { get; set; } = personID;
}