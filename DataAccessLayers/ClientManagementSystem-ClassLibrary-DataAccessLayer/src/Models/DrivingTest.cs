namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class DrivingTest(
    int? drivingTestID,
    int? testID,
    int? drivingExaminerID
) {
    public int? drivingTestID     { get; set; } = drivingTestID;
    public int? testID            { get; set; } = testID;
    public int? drivingExaminerID { get; set; } = drivingExaminerID;
}