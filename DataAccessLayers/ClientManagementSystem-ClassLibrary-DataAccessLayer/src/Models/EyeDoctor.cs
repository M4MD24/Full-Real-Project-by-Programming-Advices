namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class EyeDoctor(
    int? eyeDoctorID,
    int? personID
) {
    public int? eyeDoctorID { get; set; } = eyeDoctorID;
    public int? personID    { get; set; } = personID;
}