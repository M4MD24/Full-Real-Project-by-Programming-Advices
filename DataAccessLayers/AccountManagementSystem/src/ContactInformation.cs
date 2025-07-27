using System;
using System.Data.SqlClient;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class ContactInformation {
    public static Models.ContactInformation? getContactInformationByContactInformationID(
        ref int contactInformationID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CONTACT_INFORMATION_BY_CONTACT_INFORMATION_ID = """
                                                                            USE DriverAndVehicleLicenseDepartment
                                                                            SELECT *
                                                                            FROM AccountManagementSystem.ContactInformation
                                                                            WHERE ContactInformationID = @contactInformationID
                                                                            """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_CONTACT_INFORMATION_BY_CONTACT_INFORMATION_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactInformationID",
            contactInformationID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string phoneNumber = (string) sqlDataReader["PhoneNumber"],
                       email       = (string) sqlDataReader["Email"];
                return new Models.ContactInformation(
                    phoneNumber,
                    email
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