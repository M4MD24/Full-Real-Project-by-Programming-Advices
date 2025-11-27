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

    public static Constants.NextTestStatus getNextRequiredTest(
        int? licenseID
    ) {
        const string GET_NEXT_REQUIRED_TEST = """
                                                  USE DriverAndVehicleLicenseDepartment;

                                                  SELECT
                                                      CASE
                                                          WHEN NOT EXISTS (
                                                              SELECT 1 FROM ClientManagementSystem.Tests test
                                                              INNER JOIN ClientManagementSystem.EyeTests eyeTest ON test.TestID = eyeTest.TestID
                                                              WHERE test.LicenseID = @licenseID AND test.IsSucceed = 1
                                                          ) THEN 'EYE'

                                                          WHEN NOT EXISTS (
                                                              SELECT 1 FROM ClientManagementSystem.Tests test
                                                              INNER JOIN ClientManagementSystem.TheoreticalTests theoreticalTest ON test.TestID = theoreticalTest.TestID
                                                              WHERE test.LicenseID = @licenseID AND test.IsSucceed = 1
                                                          ) THEN 'THEORETICAL'

                                                          WHEN NOT EXISTS (
                                                              SELECT 1 FROM ClientManagementSystem.Tests test
                                                              INNER JOIN ClientManagementSystem.DrivingTests drivingTest ON test.TestID = drivingTest.TestID
                                                              WHERE test.LicenseID = @licenseID AND test.IsSucceed = 1
                                                          ) THEN 'DRIVING'

                                                          ELSE 'DONE'
                                                      END AS NextTest;
                                              """;

        using SqlConnection connection = new(
            Constants.DATABASE_CONNECTIVITY
        );
        using SqlCommand command = new(
            GET_NEXT_REQUIRED_TEST,
            connection
        );
        command.Parameters.AddWithValue(
            "@licenseID",
            licenseID
        );

        connection.Open();
        var result = command.ExecuteScalar() as string;

        return Enum.TryParse(
                   result,
                   ignoreCase : true,
                   out Constants.NextTestStatus nextTestStatus
               )
                       ? nextTestStatus
                       : Constants.NextTestStatus.Eye;
    }

    public static Constants.CanSetTestStatus canSetTestStatus(
        int?   licenseID,
        string testType
    ) {
        string tableName = $"ClientManagementSystem.{testType}Tests";

        string personFieldID = testType switch {
            "Eye"         => "EyeDoctorID",
            "Theoretical" => "SupervisorID",
            "Driving"     => "DrivingExaminerID",
            _ => throw new Exception(
                     "Invalid test type"
                 )
        };

        string query = $"""
                        USE DriverAndVehicleLicenseDepartment;

                        WITH LastTest AS (
                            SELECT TOP 1 TestID
                            FROM ClientManagementSystem.Tests
                            WHERE LicenseID = @licenseID
                            ORDER BY TestDate DESC
                        )

                        SELECT test.TestID
                        FROM LastTest lastTest
                        JOIN {
                            tableName
                        } test
                            ON test.TestID = lastTest.TestID
                            AND test.{
                                personFieldID
                            } IS NOT NULL;
                        """;

        using SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        using SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseID",
            licenseID
        );

        sqlConnection.Open();
        object result = sqlCommand.ExecuteScalar()!;

        if (
            !isSetTest(
                licenseID,
                testType
            )
        )
            return Constants.CanSetTestStatus.NotYet;

        if (
            isSetTest(
                licenseID,
                testType
            ) &&
            result == DBNull.Value
        )
            return Constants.CanSetTestStatus.WaitingForSetPerson;

        return Constants.CanSetTestStatus.Done;
    }

    private static bool isSetTest(
        int?   licenseID,
        string testType
    ) {
        string tableName = $"ClientManagementSystem.{testType}Tests";

        string query = $"""
                        USE DriverAndVehicleLicenseDepartment;

                        WITH LastTest AS (
                            SELECT TOP 1 TestID
                            FROM ClientManagementSystem.Tests
                            WHERE LicenseID = @licenseID
                            ORDER BY TestDate DESC
                        )

                        SELECT test.TestID
                        FROM LastTest lastTest
                        JOIN {
                            tableName
                        } test
                            ON test.TestID = lastTest.TestID;
                        """;

        using SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        using SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseID",
            licenseID
        );

        sqlConnection.Open();
        object result = sqlCommand.ExecuteScalar()!;

        return result != DBNull.Value;
    }

    public static void setStatus(
        int? licenseID,
        bool isSucceed
    ) {
        const string SET_STATUS_QUERY = """
                                        USE DriverAndVehicleLicenseDepartment;

                                        WITH LastTest AS (
                                            SELECT TOP 1 TestID
                                            FROM ClientManagementSystem.Tests
                                            WHERE LicenseID = @licenseID
                                            ORDER BY TestDate DESC
                                        )
                                        UPDATE ClientManagementSystem.Tests
                                            SET IsSucceed = @isSucceed
                                        WHERE TestID = (SELECT TestID FROM LastTest);
                                        """;

        using SqlConnection connection = new(
            Constants.DATABASE_CONNECTIVITY
        );
        using SqlCommand command = new(
            SET_STATUS_QUERY,
            connection
        );

        command.Parameters.AddWithValue(
            "@licenseID",
            licenseID
        );
        command.Parameters.AddWithValue(
            "@isSucceed",
            isSucceed
        );

        connection.Open();
        int rows = command.ExecuteNonQuery();
    }
}