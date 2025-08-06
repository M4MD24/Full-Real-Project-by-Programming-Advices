using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public class Countries {
    public static int updateCountryByCountryID(
        ref Country country
    ) {
        const string UPDATE_COUNTRY_BY_COUNTRY_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    UPDATE AccountManagementSystem.Countries
                                                    SET CountryName = @countryName,
                                                        CountryCode = @countryCode
                                                    WHERE CountryID = @countryID
                                                    """;

        return saveData(
            ref country,
            UPDATE_COUNTRY_BY_COUNTRY_ID,
            Constants.Mode.Update
        );
    }

    public static int deleteCountryByCountryID(
        ref byte countryID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_COUNTRY_BY_COUNTRY_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    DELETE AccountManagementSystem.Countries
                                                    WHERE CountryID = @countryID
                                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_COUNTRY_BY_COUNTRY_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@countryID",
            countryID
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

    public static int addNewCountry(
        ref Country country
    ) {
        const string ADD_NEW_COUNTRY = """
                                       USE DriverAndVehicleLicenseDepartment
                                       INSERT INTO AccountManagementSystem.Countries (CountryName, CountryCode)
                                       VALUES (@countryName, @countryCode);
                                       SELECT SCOPE_IDENTITY();
                                       """;

        return saveData(
            ref country,
            ADD_NEW_COUNTRY,
            Constants.Mode.Add
        );
    }

    private static int saveData(
        ref Country    country,
        string         query,
        Constants.Mode mode
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        if (mode == Constants.Mode.Update)
            sqlCommand.Parameters.AddWithValue(
                "@countryID",
                country.countryID
            );

        sqlCommand.Parameters.AddWithValue(
            "@countryName",
            country.countryName
        );
        sqlCommand.Parameters.AddWithValue(
            "@countryCode",
            country.countryCode
        );

        int rowAffected = 0;
        try {
            if (mode == Constants.Mode.Add) {
                object result = sqlCommand.ExecuteScalar()!;
                int newID = Convert.ToInt32(
                    result
                );
                return newID;
            } else
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