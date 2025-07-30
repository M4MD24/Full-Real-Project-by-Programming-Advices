using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DriverAndVehicleLicenseDepartment.Models;
using DriverAndVehicleLicenseDepartment.Utilities;

namespace DriverAndVehicleLicenseDepartment;

public class Currencies {
    public static int updateCurrencyByCurrencyID(
        ref Currency currency
    ) {
        const string UPDATE_CURRENCY_BY_CURRENCY_ID = """
                                                      USE DriverAndVehicleLicenseDepartment
                                                      UPDATE DriverAndVehicleLicenseDepartment.Currencies
                                                      SET Amount    = @amount,
                                                          CountryID = @countryID
                                                      WHERE CurrencyID = @currencyID
                                                      """;

        return saveData(
            ref currency,
            UPDATE_CURRENCY_BY_CURRENCY_ID,
            Constants.Mode.Update
        );
    }

    public static int deleteCurrencyByCurrencyID(
        ref int currencyID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_CURRENCY_BY_CURRENCY_ID = """
                                                      USE DriverAndVehicleLicenseDepartment
                                                      DELETE DriverAndVehicleLicenseDepartment.Currencies
                                                      WHERE CurrencyID = @currencyID
                                                      """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_CURRENCY_BY_CURRENCY_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@currencyID",
            currencyID
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

    public static int addNewCurrency(
        ref Currency currency
    ) {
        const string ADD_NEW_CURRENCY = """
                                        USE DriverAndVehicleLicenseDepartment
                                        INSERT INTO DriverAndVehicleLicenseDepartment.Currencies (Amount, CountryID)
                                        VALUES (@amount, @countryID)
                                        """;

        return saveData(
            ref currency,
            ADD_NEW_CURRENCY,
            Constants.Mode.Add
        );
    }

    private static int saveData(
        ref Currency   currency,
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
                "@currencyID",
                currency.currencyID
            );

        sqlCommand.Parameters.AddWithValue(
            "@amount",
            currency.amount
        );
        sqlCommand.Parameters.AddWithValue(
            "@countryID",
            currency.countryID
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

    public static List<Currency>? getAllCurrencies() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_CURRENCIES = """
                                          USE DriverAndVehicleLicenseDepartment
                                          SELECT *
                                          FROM DriverAndVehicleLicenseDepartment.Currencies
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
                byte    currencyID = (byte) sqlDataReader["CurrencyID"];
                decimal amount     = (decimal) sqlDataReader["Amount"];
                byte    countryID  = (byte) sqlDataReader["CountryID"];

                countries.Add(
                    new Currency(
                        currencyID,
                        amount,
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
                                                      FROM DriverAndVehicleLicenseDepartment.Currencies
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
                decimal amount    = (decimal) sqlDataReader["Amount"];
                byte    countryID = (byte) sqlDataReader["CountryID"];
                return new Currency(
                    currencyID,
                    amount,
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