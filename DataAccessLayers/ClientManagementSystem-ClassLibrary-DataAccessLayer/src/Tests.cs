using System;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Tests {
    public static int addNewTest(
        ref Test test
    ) {
        const string ADD_NEW_TEST = """
                                    USE DriverAndVehicleLicenseDepartment
                                    INSERT INTO ClientManagementSystem.Tests (LicenseID, CurrencyID, TestDate)
                                    VALUES (@licenseID, @currencyID, @testDate);
                                    SELECT SCOPE_IDENTITY();
                                    """;

        int newID = saveData(
            ref test,
            ADD_NEW_TEST
        );
        test.testID = newID;
        return newID;
    }

    private static int saveData(
        ref Test test,
        string   query
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseID",
            test.licenseID
        );

        sqlCommand.Parameters.AddWithValue(
            "@currencyID",
            test.currencyID
        );

        sqlCommand.Parameters.AddWithValue(
            "@testDate",
            test.testDate.HasValue
                    ? test.testDate.Value.ToDateTime(
                        TimeOnly.MinValue
                    )
                    : DBNull.Value
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