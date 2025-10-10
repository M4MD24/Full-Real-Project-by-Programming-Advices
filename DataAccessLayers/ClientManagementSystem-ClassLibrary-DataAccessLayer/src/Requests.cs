using System;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Requests {
    public static int addNewRequest(
        ref Request request
    ) {
        const string ADD_NEW_REQUEST = """
                                       USE DriverAndVehicleLicenseDepartment
                                       INSERT INTO ClientManagementSystem.Requests (RequestDateTime, ClientID, PaymentID, LicenseID)
                                       VALUES (@requestDateTime, @clientID, @paymentID, @licenseID);
                                       SELECT SCOPE_IDENTITY();
                                       """;

        int newID = saveData(
            ref request,
            ADD_NEW_REQUEST
        );
        request.requestID = newID;
        return newID;
    }

    private static int saveData(
        ref Request request,
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
            "@requestDateTime",
            request.requestDateTime
        );

        sqlCommand.Parameters.AddWithValue(
            "@licenseID",
            request.licenseID
        );

        sqlCommand.Parameters.AddWithValue(
            "@clientID",
            request.clientID
        );

        sqlCommand.Parameters.AddWithValue(
            "@paymentID",
            request.paymentID
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