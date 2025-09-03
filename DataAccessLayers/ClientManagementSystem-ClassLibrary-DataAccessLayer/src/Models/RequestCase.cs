namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class RequestCase(
    byte?   requestCaseID,
    string? requestCaseName
) {
    public byte?   requestCaseID   { get; set; } = requestCaseID;
    public string? requestCaseName { get; set; } = requestCaseName;
}