using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public class Fees {
    public static List<ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees>? getAllFees() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_COUNTRIES = """
                                         USE DriverAndVehicleLicenseDepartment
                                         SELECT *
                                         FROM ClientManagementSystem.Fees
                                         """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_COUNTRIES,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees> fees          = [];
            SqlDataReader                                                         sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                byte    feesID    = (byte) sqlDataReader["FeesID"];
                string  feesName  = (string) sqlDataReader["FeesName"];
                decimal amount    = (decimal) sqlDataReader["Amount"];
                byte    currenyID = (byte) sqlDataReader["CurrencyID"];

                fees.Add(
                    new ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees(
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

    public static ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees? getFeesByFeesID(
        ref byte feesID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_COUNTRY_BY_COUNTRY_ID = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    SELECT *
                                                    FROM ClientManagementSystem.Fees
                                                    WHERE FeesID = @feesID
                                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_COUNTRY_BY_COUNTRY_ID,
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
                return new ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees(
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