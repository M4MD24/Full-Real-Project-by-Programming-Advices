namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Employee(
    int? employeeID,
    int? personID
) {
    public int? employeeID { get; set; } = employeeID;
    public int? personID   { get; set; } = personID;
}