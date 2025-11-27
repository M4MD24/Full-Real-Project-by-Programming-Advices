using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Fees {
    public static List<Models.Fees>? getAllFees() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_FEES = """
                                    USE DriverAndVehicleLicenseDepartment
                                    SELECT *
                                    FROM ClientManagementSystem.Fees
                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_FEES,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Models.Fees> fees          = [];
            SqlDataReader                                                         sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                byte    feesID    = (byte) sqlDataReader["FeesID"];
                string  feesName  = (string) sqlDataReader["FeesName"];
                decimal amount    = (decimal) sqlDataReader["Amount"];
                byte    currenyID = (byte) sqlDataReader["CurrencyID"];

                fees.Add(
                    new Models.Fees(
                        feesID,
                        feesName,
                        amount,
                        currenyID
                    )
                );
            }

            sqlDataReader.Close();
            return fees;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }

    public static Models.Fees? getFeesByFeesID(
        ref byte feesID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_FEES_BY_FEES_ID = """
                                              USE DriverAndVehicleLicenseDepartment
                                              SELECT *
                                              FROM ClientManagementSystem.Fees
                                              WHERE FeesID = @feesID
                                              """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_FEES_BY_FEES_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@feesID",
            feesID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string  feesName  = (string) sqlDataReader["FeesName"];
                decimal amount    = (decimal) sqlDataReader["Amount"];
                byte    currenyID = (byte) sqlDataReader["CurrencyID"];
                return new Models.Fees(
                    feesName,
                    amount,
                    currenyID
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

    public static Models.Fees? getFeesByFeesName(
        string feesName
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_FEES_BY_FEES_NAME = """
                                                USE DriverAndVehicleLicenseDepartment
                                                SELECT *
                                                FROM ClientManagementSystem.Fees
                                                WHERE FeesName = @feesName
                                                """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_FEES_BY_FEES_NAME,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@feesName",
            feesName
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                decimal amount    = (decimal) sqlDataReader["Amount"];
                byte    currenyID = (byte) sqlDataReader["CurrencyID"];
                return new Models.Fees(
                    feesName,
                    amount,
                    currenyID
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