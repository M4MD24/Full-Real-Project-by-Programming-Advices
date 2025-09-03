namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class TheoreticalTest(
    int? theoreticalTestID,
    int? testID,
    int? supervisorID
) {
    public int? theoreticalTestID { get; set; } = theoreticalTestID;
    public int? testID            { get; set; } = testID;
    public int? supervisorID      { get; set; } = supervisorID;
}