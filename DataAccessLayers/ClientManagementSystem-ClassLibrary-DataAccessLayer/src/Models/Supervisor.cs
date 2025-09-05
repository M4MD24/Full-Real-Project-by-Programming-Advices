namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Supervisor(
    int? supervisorID,
    int? personID
) {
    public int? supervisorID { get; set; } = supervisorID;
    public int? personID     { get; set; } = personID;
}