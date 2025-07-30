using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DriverAndVehicleLicenseDepartment.Models;
using DriverAndVehicleLicenseDepartment.Utilities;

namespace DriverAndVehicleLicenseDepartment;

public class Currencies {
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