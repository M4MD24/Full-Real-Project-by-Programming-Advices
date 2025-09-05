namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Retest(
    int? retestID,
    int? lastRequestID,
    int? newRequestID
) {
    public int? retestID      { get; set; } = retestID;
    public int? lastRequestID { get; set; } = lastRequestID;
    public int? newRequestID  { get; set; } = newRequestID;
}