using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public static class Accounts {
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
        ref int? accountID
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
                                       VALUES (@personID, @username, @password, @isActive, @accountTypeID);
                                       SELECT SCOPE_IDENTITY();
                                       """;

        int newID = saveData(
            ref account,
            ADD_NEW_ACCOUNT,
            Constants.Mode.Add
        );
        account.accountID = newID;
        return newID;
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
            if (mode == Constants.Mode.Add) {
                object result = sqlCommand.ExecuteScalar()!;
                int newID = Convert.ToInt32(
                    result
                );
                return newID;
            } else
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

    public static int changeStatusbyAccountID(
        ref int? accountID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        const string CHANGE_STATUS_BY_ACCOUNT_ID = """
                                                   USE DriverAndVehicleLicenseDepartment
                                                   UPDATE AccountManagementSystem.Accounts
                                                   SET IsActive = ~IsActive
                                                   WHERE AccountID = @accountID
                                                   """;

        SqlCommand sqlCommand = new SqlCommand(
            CHANGE_STATUS_BY_ACCOUNT_ID,
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

    public static Account? getAccountByAccountID(
        ref int? accountID
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

    public static List<Account>? getAllAccounts() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_ACCOUNTS = """
                                        USE DriverAndVehicleLicenseDepartment
                                        SELECT *
                                        FROM AccountManagementSystem.Accounts
                                        """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_ACCOUNTS,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Account> accounts      = [];
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                int    accountID     = (int) sqlDataReader["AccountID"];
                int    personID      = (int) sqlDataReader["PersonID"];
                string username      = (string) sqlDataReader["Username"];
                string password      = (string) sqlDataReader["Password"];
                bool   isActive      = (bool) sqlDataReader["IsActive"];
                byte   accountTypeID = (byte) sqlDataReader["AccountTypeID"];

                accounts.Add(
                    new Account(
                        accountID,
                        personID,
                        username,
                        password,
                        isActive,
                        accountTypeID
                    )
                );
            }

            sqlDataReader.Close();
            return accounts;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }

    public static bool isAccountExistByUsername(
        ref string? username
    ) {
        if (
            string.IsNullOrWhiteSpace(
                username
            )
        )
            return false;

        using SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        const string IS_USERNAME_EXIST = """
                                         USE DriverAndVehicleLicenseDepartment
                                         IF EXISTS (
                                             SELECT 1
                                             FROM AccountManagementSystem.Accounts
                                             WHERE Username = @username
                                         )
                                             SELECT 1
                                         ELSE
                                             SELECT 0
                                         """;

        using SqlCommand sqlCommand = new SqlCommand(
            IS_USERNAME_EXIST,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@username",
            username
        );

        try {
            sqlConnection.Open();
            return Convert.ToInt32(
                       sqlCommand.ExecuteScalar()
                   ) == 1;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
            return false;
        }
    }
}