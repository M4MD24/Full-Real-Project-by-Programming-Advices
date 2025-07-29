using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DriverAndVehicleLicenseDepartment.Models;
using DriverAndVehicleLicenseDepartment.Utilities;

namespace DriverAndVehicleLicenseDepartment;

public class Countries {
    public static Country? getCountryByCountryID(
        ref byte countryID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_COUNTRY_BY_COUNTRY_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    SELECT *
                                                    FROM DriverAndVehicleLicenseDepartment.Countries
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
                    countryID,
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