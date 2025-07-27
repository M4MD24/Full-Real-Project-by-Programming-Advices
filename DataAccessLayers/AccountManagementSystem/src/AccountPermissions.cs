using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class AccountPermissions {
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