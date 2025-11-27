using System;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class EyeTests {
    public static int addNewTest(
        ref EyeTest eyeTest
    ) {
        const string ADD_NEW_EYE_TEST = """
                                        USE DriverAndVehicleLicenseDepartment
                                        INSERT INTO ClientManagementSystem.EyeTests (TestID)
                                        VALUES (@testID);
                                        SELECT SCOPE_IDENTITY();
                                        """;

        int newID = saveData(
            ref eyeTest,
            ADD_NEW_EYE_TEST
        );
        eyeTest.testID = newID;
        return newID;
    }

    private static int saveData(
        ref EyeTest eyeTest,
        string      query
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
            eyeTest.testID
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