using System;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class FullNames {
    private static int saveData(
        ref FullName   fullName,
        string         query,
        Constants.Mode mode
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        if (mode == Constants.Mode.Update)
            sqlCommand.Parameters.AddWithValue(
                "@fullNameID",
                fullName.fullNameID
            );

        sqlCommand.Parameters.AddWithValue(
            "@firstName",
            fullName.firstName
        );
        sqlCommand.Parameters.AddWithValue(
            "@secondName",
            fullName.secondName
        );
        sqlCommand.Parameters.AddWithValue(
            "@thirdName",
            fullName.thirdName
        );
        sqlCommand.Parameters.AddWithValue(
            "@fourthName",
            fullName.fourthName
        );

        int rowAffected = 0;
        try {
            sqlConnection.Open();
            rowAffected = sqlCommand.ExecuteNonQuery();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return rowAffected;
    }

    public static FullName? getFullNameByFullNameID(
        ref int fullNameID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_FULL_NAME_BY_FULL_NAME_ID = """
                                                        USE DriverAndVehicleLicenseDepartment
                                                        SELECT *
                                                        FROM AccountManagementSystem.FullNames
                                                        WHERE FullNameID = @fullNameID
                                                        """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_FULL_NAME_BY_FULL_NAME_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@fullNameID",
            fullNameID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string firstName  = (string) sqlDataReader["FirstName"],
                       secondName = (string) sqlDataReader["SecondName"],
                       thirdName  = (string) sqlDataReader["ThirdName"],
                       fourthName = (string) sqlDataReader["FourthName"];
                return new FullName(
                    fullNameID,
                    firstName,
                    secondName,
                    thirdName,
                    fourthName
                );
            }

            sqlDataReader.Close();
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }
}