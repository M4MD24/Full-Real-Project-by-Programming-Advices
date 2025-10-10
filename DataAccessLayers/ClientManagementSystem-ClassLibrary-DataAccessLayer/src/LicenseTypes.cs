using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class LicenseTypes {
    public static List<string>? getAllLicenseTypeNames() {
        using SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_LICENSE_TYPE_NAMES = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  SELECT Name
                                                  FROM ClientManagementSystem.LicenseTypes 
                                                  """;
        using SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_LICENSE_TYPE_NAMES,
            sqlConnection
        );
        try {
            sqlConnection.Open();
            List<string> names = [];

            using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string name = sqlDataReader.GetString(
                    0
                );
                names.Add(
                    name
                );
            }

            return names;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
            return null;
        }
    }

    public static LicenseType? getLicenseTypeByName(
        ref string name
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_LICENSE_TYPE_BY_NAME = """
                                                   USE DriverAndVehicleLicenseDepartment
                                                   SELECT *
                                                   FROM ClientManagementSystem.LicenseTypes
                                                   WHERE Name = @name
                                                   """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_LICENSE_TYPE_BY_NAME,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@name",
            name
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                byte   licenseTypeID = (byte) sqlDataReader["LicenseTypeID"];
                string description   = (string) sqlDataReader["Description"];
                byte   minimumAge    = (byte) sqlDataReader["MinimumAge"];
                byte   duration      = (byte) sqlDataReader["Duration"];
                return new LicenseType(
                    licenseTypeID,
                    name,
                    description,
                    minimumAge,
                    duration
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