using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class AccountPermissions {
    public static int addNewAccountPermission(
        ref Models.AccountPermission accountPermission
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        const string ADD_NEW_ACCOUNT_PERMISSION = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  INSERT INTO AccountManagementSystem.AccountPermissions (AccountID, PermissionID)
                                                  VALUES (@accountID, @permissionID)
                                                  """;

        SqlCommand sqlCommand = new SqlCommand(
            ADD_NEW_ACCOUNT_PERMISSION,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@accountID",
            accountPermission.accountID
        );

        sqlCommand.Parameters.AddWithValue(
            "@permissionID",
            accountPermission.permissionID
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

    public static Models.AccountPermissions? getAccountPermissionsByAccountID(
        ref int accountID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_ACCOUNT_PERMISSIONS_BY_ACCOUNT_PERMISSION_ID = """
                                                                           USE DriverAndVehicleLicenseDepartment
                                                                           SELECT *
                                                                           FROM AccountManagementSystem.AccountPermissions
                                                                           WHERE AccountID = @accountID
                                                                           """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_ACCOUNT_PERMISSIONS_BY_ACCOUNT_PERMISSION_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@accountID",
            accountID
        );

        try {
            sqlConnection.Open();
            List<byte>          permissionIDs = [];
            using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                byte permissionID = (byte) sqlDataReader["PermissionID"];
                permissionIDs.Add(
                    permissionID
                );
            }

            sqlConnection.Close();
            return new Models.AccountPermissions(
                accountID,
                permissionIDs
            );
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