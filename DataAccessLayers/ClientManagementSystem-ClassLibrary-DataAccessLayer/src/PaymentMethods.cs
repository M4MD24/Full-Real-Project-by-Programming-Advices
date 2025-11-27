using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class PaymentMethods {
    public static List<string>? getAllPaymentMethodNames() {
        using SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_PAYMENT_METHOD_NAMES = """
                                                    USE DriverAndVehicleLicenseDepartment
                                                    SELECT PaymentMethodName
                                                    FROM ClientManagementSystem.PaymentMethods 
                                                    """;
        using SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_PAYMENT_METHOD_NAMES,
            sqlConnection
        );
        try {
            sqlConnection.Open();
            List<string> paymentMethodNames = [];

            using SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string paymentMethodName = sqlDataReader.GetString(
                    0
                );
                paymentMethodNames.Add(
                    paymentMethodName
                );
            }

            return paymentMethodNames;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
            return null;
        }
    }

    public static PaymentMethod? getPaymentMethodByPaymentMethodName(
        string paymentMethodName
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_PAYMENT_METHOD_BY_PAYMENT_METHOD_NAME = """
                                                                    USE DriverAndVehicleLicenseDepartment
                                                                    SELECT *
                                                                    FROM ClientManagementSystem.PaymentMethods
                                                                    WHERE PaymentMethodName = @paymentMethodName
                                                                    """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_PAYMENT_METHOD_BY_PAYMENT_METHOD_NAME,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@paymentMethodName",
            paymentMethodName
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                byte paymentMethodID = (byte) sqlDataReader["PaymentMethodID"];
                return new PaymentMethod(
                    paymentMethodID,
                    paymentMethodName
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