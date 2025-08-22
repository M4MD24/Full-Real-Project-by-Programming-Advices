using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public static class Permissions {
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

    public static List<Permission>? getAllPermissions() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_PERMISSIONS = """
                                           USE DriverAndVehicleLicenseDepartment
                                           SELECT *
                                           FROM AccountManagementSystem.Permissions
                                           """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_PERMISSIONS,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Permission> permissions   = [];
            SqlDataReader    sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                byte   permissionID   = (byte) sqlDataReader["PermissionID"];
                string permissionName = (string) sqlDataReader["PermissionName"];

                permissions.Add(
                    new Permission(
                        permissionID,
                        permissionName
                    )
                );
            }

            sqlDataReader.Close();
            return permissions;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }

    public static List<Permission> getAllPermissions(
        ref List<byte> permissionIDs
    ) {
        List<Permission> permissions = [];

        using SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        sqlConnection.Open();

        string permissionIDsLine = string.Join(
            ",",
            permissionIDs.Select(
                (
                            id,
                            index
                        ) => $"@id{index}"
            )
        );

        string getPermissionsByPermissionIDs = $"""
                                                USE DriverAndVehicleLicenseDepartment
                                                SELECT *
                                                FROM AccountManagementSystem.Permissions
                                                WHERE PermissionID IN ({
                                                    permissionIDsLine
                                                });
                                                """;

        using SqlCommand sqlCommand = new SqlCommand(
            getPermissionsByPermissionIDs,
            sqlConnection
        );
        for (
            byte index = 0;
            index < permissionIDs.Count;
            index++
        )
            sqlCommand.Parameters.AddWithValue(
                $"@id{index}",
                permissionIDs[index]
            );

        using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
            permissions.Add(
                new Permission(
                    sqlDataReader.GetByte(
                        0
                    ),
                    sqlDataReader.GetString(
                        1
                    )
                )
            );

        return permissions;
    }

    public static Permission? getPermissionByPermissionName(
        ref string permissionName
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_PERMISSION_BY_PERMISSION_NAME = """
                                                            USE DriverAndVehicleLicenseDepartment
                                                            SELECT *
                                                            FROM AccountManagementSystem.Permissions
                                                            WHERE PermissionName = @permissionName
                                                            """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_PERMISSION_BY_PERMISSION_NAME,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@permissionName",
            permissionName
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                byte permissionID = (byte) sqlDataReader["PermissionID"];
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