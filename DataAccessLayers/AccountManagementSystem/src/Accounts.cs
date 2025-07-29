using System;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class Accounts {
    public static int updateAccountByAccountID(
        ref Account account
    ) {
        const string UPDATE_ACCOUNT_BY_ACCOUNT_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    UPDATE AccountManagementSystem.Accounts
                                                    SET PersonID      = @personID,
                                                        Username      = @username,
                                                        Password      = @password,
                                                        IsActive      = @isActive,
                                                        AccountTypeID = @accountTypeID
                                                    WHERE AccountID = @accountID
                                                    """;

        return saveData(
            ref account,
            UPDATE_ACCOUNT_BY_ACCOUNT_ID,
            Constants.Mode.Update
        );
    }

    public static int deleteAccountByAccountID(
        ref int accountID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_ACCOUNT_BY_ACCOUNT_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    DELETE AccountManagementSystem.Accounts
                                                    WHERE AccountID = @accountID
                                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_ACCOUNT_BY_ACCOUNT_ID,
            sqlConnection
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

    public static int addNewAccount(
        ref Account account
    ) {
        const string ADD_NEW_ACCOUNT = """
                                       USE DriverAndVehicleLicenseDepartment
                                       INSERT INTO AccountManagementSystem.Accounts (PersonID, Username, Password, IsActive, AccountTypeID)
                                       VALUES (@personID, @username, @password, @isActive, @accountTypeID)
                                       """;

        return saveData(
            ref account,
            ADD_NEW_ACCOUNT,
            Constants.Mode.Add
        );
    }

    private static int saveData(
        ref Account    account,
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
                "@accountID",
                account.accountID
            );

        sqlCommand.Parameters.AddWithValue(
            "@personID",
            account.personID
        );
        sqlCommand.Parameters.AddWithValue(
            "@username",
            account.username
        );
        sqlCommand.Parameters.AddWithValue(
            "@password",
            account.password
        );
        sqlCommand.Parameters.AddWithValue(
            "@isActive",
            account.isActive
        );
        sqlCommand.Parameters.AddWithValue(
            "@accountTypeID",
            account.accountTypeID
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

    public static int setActiveStatusbyAccountID(
        ref int  accountID,
        ref bool isActive
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        const string SET_ACTIVE_STATUS_BY_ACCOUNT_ID = """
                                                       USE DriverAndVehicleLicenseDepartment
                                                       UPDATE AccountManagementSystem.Accounts
                                                       SET IsActive = @isActive
                                                       WHERE AccountID = @accountID
                                                       """;

        SqlCommand sqlCommand = new SqlCommand(
            SET_ACTIVE_STATUS_BY_ACCOUNT_ID,
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