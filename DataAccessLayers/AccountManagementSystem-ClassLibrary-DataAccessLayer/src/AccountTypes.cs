using System;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

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
                                                              WHERE AccountTypeID = @accountTypeID
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

    public static AccountType? getAccountTypeByAccountTypeName(
        ref string accountTypeName
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_ACCOUNT_TYPE_BY_ACCOUNT_TYPE_NAME = """
                                                                USE DriverAndVehicleLicenseDepartment
                                                                SELECT *
                                                                FROM AccountManagementSystem.AccountTypes
                                                                WHERE AccountTypeName = @accountTypeName
                                                                """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_ACCOUNT_TYPE_BY_ACCOUNT_TYPE_NAME,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@accountTypeName",
            accountTypeName
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                byte accountTypeID = (byte) sqlDataReader["AccountTypeID"];
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