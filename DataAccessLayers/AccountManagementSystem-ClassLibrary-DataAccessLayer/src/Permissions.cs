using System;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public class Permissions {
    public static Permission? getPermissionByPermissionID(
        ref byte permissionID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_PERMISSION_BY_PERMISSION_ID = """
                                                          USE DriverAndVehicleLicenseDepartment
                                                          SELECT *
                                                          FROM AccountManagementSystem.Permissions
                                                          WHERE PermissionID = @permissionID
                                                          """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_PERMISSION_BY_PERMISSION_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@permissionID",
            permissionID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string permissionName = (string) sqlDataReader["PermissionName"];
                return new Permission(
                    permissionID,
                    permissionName
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