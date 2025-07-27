using System;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class AccountTypes {
    public static AccountType? getAccountTypeByAccountTypeID(
        ref byte accountTypeID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_ACCOUNT_TYPE_BY_ACCOUNT_TYPE_ID = """
                                                              USE DriverAndVehicleLicenseDepartment
                                                              SELECT *
                                                              FROM AccountManagementSystem.AccountTypes
                                                              WHERE AccountTypeID = @personID
                                                              """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_ACCOUNT_TYPE_BY_ACCOUNT_TYPE_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@accountTypeID",
            accountTypeID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string accountTypeName = (string) sqlDataReader["AccountTypeName"];
                return new AccountType(
                    accountTypeID,
                    accountTypeName
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