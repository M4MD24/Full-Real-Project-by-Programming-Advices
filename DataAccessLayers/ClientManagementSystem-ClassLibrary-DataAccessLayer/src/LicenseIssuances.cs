using System;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class LicenseIssuances {
    public static LicenseIssuance? getLicenseIssuanceByLicenseIssuanceID(
        ref byte? licenseIssuanceID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_LICENSE_ISSUANCE_BY_LICENSE_ISSUANCE_ID = """
                                                                   USE DriverAndVehicleLicenseDepartment
                                                                   SELECT *
                                                                   FROM ClientManagementSystem.LicenseIssuances
                                                                   WHERE LicenseIssuanceID = @licenseIssuanceID
                                                                   """;

        SqlCommand sqlCommand = new SqlCommand(
            GET_LICENSE_ISSUANCE_BY_LICENSE_ISSUANCE_ID,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseIssuanceID",
            licenseIssuanceID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                string licenseIssuanceName = (string) sqlDataReader["LicenseIssuanceName"];

                return new LicenseIssuance(
                    licenseIssuanceID,
                    licenseIssuanceName
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