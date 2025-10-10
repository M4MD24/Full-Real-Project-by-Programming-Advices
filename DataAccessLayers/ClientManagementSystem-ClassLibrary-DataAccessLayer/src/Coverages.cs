using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Coverages {
    public static List<string>? getAllCoverageNames() {
        using SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_COVERAGE_NAMES = """
                                              USE DriverAndVehicleLicenseDepartment
                                              SELECT CoverageName
                                              FROM ClientManagementSystem.Coverages 
                                              """;
        using SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_COVERAGE_NAMES,
            sqlConnection
        );
        try {
            sqlConnection.Open();
            List<string> coverageNames = [];

            using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string licenseTypeName = sqlDataReader.GetString(
                    0
                );
                coverageNames.Add(
                    licenseTypeName
                );
            }

            return coverageNames;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
            return null;
        }
    }

    public static Models.Coverage? getCoverageByCoverageName(
        string coverageName
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_COVERAGE_BY_COVERAGE_NAME = """
                                                        USE DriverAndVehicleLicenseDepartment
                                                        SELECT *
                                                        FROM ClientManagementSystem.Coverages
                                                        WHERE CoverageName = @coverageName
                                                        """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_COVERAGE_BY_COVERAGE_NAME,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@coverageName",
            coverageName
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                byte coverageID = (byte) sqlDataReader["CoverageID"];
                return new Models.Coverage(
                    coverageID,
                    coverageName
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