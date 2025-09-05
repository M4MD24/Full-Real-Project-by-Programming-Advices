namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class EyeTest(
    int? eyeTestID,
    int? testID,
    int? eyeDoctorID
) {
    public int? eyeTestID   { get; set; } = eyeTestID;
    public int? testID      { get; set; } = testID;
    public int? eyeDoctorID { get; set; } = eyeDoctorID;
}