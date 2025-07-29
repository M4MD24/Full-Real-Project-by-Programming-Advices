using System;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class Accounts {
    public static int setActiveStatus(
        ref int  accountID,
        ref bool isActive
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        const string SET_ACTIVE_STATUS = """
                                         USE DriverAndVehicleLicenseDepartment
                                         UPDATE AccountManagementSystem.Accounts
                                         SET IsActive = @isActive
                                         WHERE AccountID = @accountID
                                         """;

        SqlCommand sqlCommand = new SqlCommand(
            SET_ACTIVE_STATUS,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@isActive",
            isActive
        );
        sqlCommand.Parameters.AddWithValue(
            "@accountID",
            accountID
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

    public static Account? getAccountByAccountID(
        ref int accountID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_ACCOUNT_BY_ACCOUNT_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    SELECT *
                                                    FROM AccountManagementSystem.Accounts
                                                    WHERE AccountID = @accountID
                                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_ACCOUNT_BY_ACCOUNT_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@accountID",
            accountID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int    personID      = (int) sqlDataReader["PersonID"];
                string username      = (string) sqlDataReader["Username"];
                string password      = (string) sqlDataReader["Password"];
                bool   isActive      = (bool) sqlDataReader["IsActive"];
                byte   accountTypeID = (byte) sqlDataReader["AccountTypeID"];
                return new Account(
                    accountID,
                    personID,
                    username,
                    password,
                    isActive,
                    accountTypeID
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