using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Licenses {
    public static List<License>? getAllLicensesByClientID(
        ref int? clientID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_LICENSES = """
                                       USE DriverAndVehicleLicenseDepartment
                                       SELECT *
                                       FROM ClientManagementSystem.Licenses
                                       WHERE ClientID = @clientID 
                                       """;

        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_LICENSES,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@clientID",
            clientID
        );

        try {
            sqlConnection.Open();
            List<License> licenses      = [];
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                int  licenseID     = (int) sqlDataReader["LicenseID"];
                byte licenseTypeID = (byte) sqlDataReader["LicenseTypeID"];

                licenses.Add(
                    new License(
                        licenseID,
                        licenseTypeID,
                        clientID
                    )
                );
            }

            sqlDataReader.Close();
            return licenses;
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