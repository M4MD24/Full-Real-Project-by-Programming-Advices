using System;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class TheoreticalTests {
    public static int addNewTest(
        ref TheoreticalTest theoreticalTest
    ) {
        const string ADD_NEW_THEORETICAL_TEST = """
                                                USE DriverAndVehicleLicenseDepartment
                                                INSERT INTO ClientManagementSystem.TheoreticalTests (TestID)
                                                VALUES (@testID);
                                                SELECT SCOPE_IDENTITY();
                                                """;

        int newID = saveData(
            ref theoreticalTest,
            ADD_NEW_THEORETICAL_TEST
        );
        theoreticalTest.testID = newID;
        return newID;
    }

    private static int saveData(
        ref TheoreticalTest theoreticalTest,
        string              query
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
            theoreticalTest.testID
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