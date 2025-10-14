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
                int  licenseID         = (int) sqlDataReader["LicenseID"];
                byte licenseTypeID     = (byte) sqlDataReader["LicenseTypeID"];
                byte licenseIssuanceID = (byte) sqlDataReader["LicenseIssuanceID"];
                byte licenseCoverageID = (byte) sqlDataReader["LicenseCoverageID"];
                DateTime? issueDateTime = sqlDataReader["IssueDateTime"] == DBNull.Value
                                                  ? null
                                                  : (DateTime) sqlDataReader["IssueDateTime"];

                DateTime? expiryDateTime = sqlDataReader["ExpiryDateTime"] == DBNull.Value
                                                   ? null
                                                   : (DateTime) sqlDataReader["ExpiryDateTime"];
                bool isActive = (bool) sqlDataReader["IsActive"];

                licenses.Add(
                    new License(
                        licenseID,
                        licenseTypeID,
                        clientID,
                        licenseIssuanceID,
                        licenseCoverageID,
                        issueDateTime,
                        expiryDateTime,
                        isActive
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

    public static int deleteByLicenseID(
        ref int? licenseID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_LICENSE_BY_LICENSE_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    DELETE ClientManagementSystem.Licenses
                                                    WHERE LicenseID = @licenseID
                                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_LICENSE_BY_LICENSE_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@licenseID",
            licenseID
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

    public static int? addNewLicense(
        ref License license
    ) {
        const string ADD_NEW_LICENSE = """
                                       USE DriverAndVehicleLicenseDepartment
                                       INSERT INTO ClientManagementSystem.Licenses (LicenseTypeID, ClientID, LicenseIssuanceID, LicenseCoverageID, IsActive)
                                       VALUES (@licenseTypeID, @clientID, @licenseIssuanceID, @licenseCoverageID, 0);
                                       SELECT SCOPE_IDENTITY();
                                       """;

        int? newID = saveData(
            ref license,
            ADD_NEW_LICENSE
        );
        license.licenseID = newID;
        return newID;
    }

    private static int? saveData(
        ref License license,
        string      query
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseTypeID",
            license.licenseTypeID
        );

        sqlCommand.Parameters.AddWithValue(
            "@clientID",
            license.clientID
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseIssuanceID",
            license.licenseIssuanceID
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseCoverageID",
            license.licenseCoverageID
        );

        int rowAffected = 0;
        try {
            sqlConnection.Open();
            object result = sqlCommand.ExecuteScalar()!;
            int newID = Convert.ToInt32(
                result
            );
            return newID;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return rowAffected;
    }

    public static int renewByLicenseID(
        ref int? licenseID
    ) {
        return -1;
    }

    public static int replaceByLicenseID(
        ref int?              licenseID,
        Constants.ReplaceMode replaceMode
    ) {
        return -1;
    }

    public static License? getLicenseByLicenseID(
        ref int? licenseID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_LICENSE_BY_LICENSE_ID = """
                                                 USE DriverAndVehicleLicenseDepartment
                                                 SELECT *
                                                 FROM ClientManagementSystem.Licenses
                                                 WHERE LicenseID = @licenseID 
                                                 """;

        SqlCommand sqlCommand = new SqlCommand(
            GET_LICENSE_BY_LICENSE_ID,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseID",
            licenseID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                byte licenseTypeID     = (byte) sqlDataReader["LicenseTypeID"];
                byte licenseIssuanceID = (byte) sqlDataReader["LicenseIssuanceID"];
                byte licenseCoverageID = (byte) sqlDataReader["LicenseCoverageID"];
                DateTime? issueDateTime = sqlDataReader["IssueDateTime"] == DBNull.Value
                                                  ? null
                                                  : (DateTime) sqlDataReader["IssueDateTime"];
                DateTime? expiryDateTime = sqlDataReader["ExpiryDateTime"] == DBNull.Value
                                                   ? null
                                                   : (DateTime) sqlDataReader["ExpiryDateTime"];
                bool isActive = (bool) sqlDataReader["IsActive"];

                return new License(
                    licenseID,
                    licenseTypeID,
                    licenseIssuanceID,
                    licenseCoverageID,
                    issueDateTime,
                    expiryDateTime,
                    isActive
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