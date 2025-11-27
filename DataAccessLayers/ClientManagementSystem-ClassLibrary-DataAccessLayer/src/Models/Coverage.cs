namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Coverage(
    byte?   coverageID,
    string? coverageName
) {
    public byte?   coverageID   { get; set; } = coverageID;
    public string? coverageName { get; set; } = coverageName;
}