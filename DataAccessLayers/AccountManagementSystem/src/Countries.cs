using System;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class Countries {
    public static Country? getCountryByCountryID(
        ref int countryID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_COUNTRY_BY_COUNTRY_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    SELECT *
                                                    FROM AccountManagementSystem.Countries
                                                    WHERE CountryID = @countryID
                                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_COUNTRY_BY_COUNTRY_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@countryID",
            countryID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string countryName = (string) sqlDataReader["CountryName"],
                       countryCode = (string) sqlDataReader["CountryCode"];
                return new Country(
                    countryName,
                    countryCode
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