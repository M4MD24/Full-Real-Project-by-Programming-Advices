using System;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Payments {
    public static int? addNewPayment(
        Payment payment
    ) {
        const string ADD_NEW_PAYMENT = """
                                       USE DriverAndVehicleLicenseDepartment
                                       INSERT INTO ClientManagementSystem.Payments (Amount, CurrencyID, PaymentDateTime, PaymentMethodID)
                                       VALUES (@amount, @currencyID, @paymentDateTime, @paymentMethodID);
                                       SELECT SCOPE_IDENTITY();
                                       """;
        int newID = saveData(
            ref payment,
            ADD_NEW_PAYMENT
        );
        payment.paymentID = newID;
        return newID;
    }

    private static int saveData(
        ref Payment payment,
        string      query
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );

        SqlCommand sqlCommand = new SqlCommand(
            query,
            sqlConnection
        );

        sqlCommand.Parameters.AddWithValue(
            "@amount",
            payment.amount
        );
        sqlCommand.Parameters.AddWithValue(
            "@currencyID",
            payment.currencyID
        );
        sqlCommand.Parameters.AddWithValue(
            "@paymentDateTime",
            payment.paymentDateTime
        );
        sqlCommand.Parameters.AddWithValue(
            "@paymentMethodID",
            payment.paymentMethodID
        );

        int rowAffected = 0;
        try {
            sqlConnection.Open();
            object result = sqlCommand.ExecuteScalar()!;
            int newID = Convert.ToInt32(
                result
            );
            return newID;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return rowAffected;
    }
}