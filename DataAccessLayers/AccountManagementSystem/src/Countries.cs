using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class Countries {
    public static List<Country>? getAllCountries() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_COUNTRIES = """
                                         USE DriverAndVehicleLicenseDepartment
                                         SELECT *
                                         FROM AccountManagementSystem.Countries
                                         """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_COUNTRIES,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Country> countries     = [];
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                byte   countryID   = (byte) sqlDataReader["CountryID"];
                string countryName = (string) sqlDataReader["CountryName"];
                string countryCode = (string) sqlDataReader["CountryCode"];

                countries.Add(
                    new Country(
                        countryID,
                        countryName,
                        countryCode
                    )
                );
            }

            sqlDataReader.Close();
            return countries;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }

    public static Country? getCountryByCountryID(
        ref byte countryID
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