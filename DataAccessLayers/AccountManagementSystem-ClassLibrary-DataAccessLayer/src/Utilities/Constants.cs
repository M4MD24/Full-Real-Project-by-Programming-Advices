namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

public static class Constants {
    public enum Mode {
        Add    = 0,
        Update = 1
    }

    private const string SERVER_NAME   = "M4MD24";
    private const string DATABASE_NAME = "DriverAndVehicleLicenseDepartment";
    private const string USERNAME = "sa",
                         PASSWORD = "Mm_1234?";
    public const string DATABASE_CONNECTIVITY = $"Server={SERVER_NAME};Database={DATABASE_NAME};User Id={USERNAME};Password={PASSWORD};";
}