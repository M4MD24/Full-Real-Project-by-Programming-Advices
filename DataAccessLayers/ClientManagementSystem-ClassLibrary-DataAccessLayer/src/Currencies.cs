using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Currencies {
    public static List<Currency>? getAllCurrencies() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_CURRENCIES = """
                                          USE DriverAndVehicleLicenseDepartment
                                          SELECT *
                                          FROM ClientManagementSystem.Currencies
                                          """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_CURRENCIES,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Currency> countries     = [];
            SqlDataReader  sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                byte   currencyID   = (byte) sqlDataReader["CurrencyID"];
                string currencyName = (string) sqlDataReader["CurrencyName"];
                byte   countryID    = (byte) sqlDataReader["CountryID"];

                countries.Add(
                    new Currency(
                        currencyID,
                        currencyName,
                        countryID
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

    public static Currency? getCurrencyByCurrencyID(
        ref byte currencyID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CURRENCY_BY_CURRENCY_ID = """
                                                      USE DriverAndVehicleLicenseDepartment
                                                      SELECT *
                                                      FROM ClientManagementSystem.Currencies
                                                      WHERE CurrencyID = @currencyID
                                                      """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_CURRENCY_BY_CURRENCY_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@currencyID",
            currencyID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string currencyName = (string) sqlDataReader["CurrencyName"];
                byte   countryID    = (byte) sqlDataReader["CountryID"];
                return new Currency(
                    currencyID,
                    currencyName,
                    countryID
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