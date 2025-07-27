using System;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class FullNames {
    public static FullName? getFullNameByID(
        ref int fullNameID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_FULL_NAME_BY_ID = """
                                              USE DriverAndVehicleLicenseDepartment
                                              SELECT *
                                              FROM AccountManagementSystem.FullName
                                              WHERE FullNameID = @fullNameID
                                              """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_FULL_NAME_BY_ID,
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