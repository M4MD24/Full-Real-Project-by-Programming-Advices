using System;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public class DrivingTests {
    public static int addNewTest(
        ref DrivingTest drivingTests
    ) {
        const string ADD_NEW_DRIVING_TESTS = """
                                             USE DriverAndVehicleLicenseDepartment
                                             INSERT INTO ClientManagementSystem.DrivingTests (TestID)
                                             VALUES (@testID);
                                             SELECT SCOPE_IDENTITY();
                                             """;

        int newID = saveData(
            ref drivingTests,
            ADD_NEW_DRIVING_TESTS
        );
        drivingTests.testID = newID;
        return newID;
    }

    private static int saveData(
        ref DrivingTest drivingTests,
        string          query
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@testID",
            drivingTests.testID
        );

        int rowAffected = 0;
        try {
            sqlConnection.Open();
            object result = sqlCommand.ExecuteScalar()!;
            int newID = Convert.ToInt32(
                result
            );
            return newID;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return rowAffected;
    }
}