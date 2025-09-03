namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class RequestType(
    byte?   requestTypeID,
    string? requestTypeName
) {
    public byte?   requestTypeID   { get; set; } = requestTypeID;
    public string? requestTypeName { get; set; } = requestTypeName;
}