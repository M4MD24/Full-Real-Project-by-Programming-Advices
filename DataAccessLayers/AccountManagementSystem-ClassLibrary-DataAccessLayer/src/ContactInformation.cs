using System;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public class ContactInformation {
    public static int updateContactInformationByContactInformationID(
        ref Models.ContactInformation contactInformationID
    ) {
        const string UPDATE_CONTACT_INFORMATION_BY_CONTACT_INFORMATION_ID = """
                                                                            USE DriverAndVehicleLicenseDepartment
                                                                            UPDATE AccountManagementSystem.ContactInformation
                                                                            SET PhoneNumber = @phoneNumber,
                                                                                Email       = @email
                                                                            WHERE ContactInformationID = @contactInformationID
                                                                            """;

        return saveData(
            ref contactInformationID,
            UPDATE_CONTACT_INFORMATION_BY_CONTACT_INFORMATION_ID,
            Constants.Mode.Update
        );
    }

    public static int deleteContactInformationByContactInformationID(
        ref int contactInformationID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_CONTACT_INFORMATION_BY_CONTACT_INFORMATION_ID = """
                                                                            USE DriverAndVehicleLicenseDepartment
                                                                            DELETE AccountManagementSystem.ContactInformation
                                                                            WHERE ContactInformationID = @contactInformationID
                                                                            """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_CONTACT_INFORMATION_BY_CONTACT_INFORMATION_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactInformationID",
            contactInformationID
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

    public static int addNewContactInformation(
        ref Models.ContactInformation contactInformation
    ) {
        const string ADD_NEW_CONTACT_INFORMATION = """
                                                   USE DriverAndVehicleLicenseDepartment
                                                   INSERT INTO AccountManagementSystem.ContactInformation (PhoneNumber, Email)
                                                   VALUES (@phoneNumber, @email)
                                                   """;

        return saveData(
            ref contactInformation,
            ADD_NEW_CONTACT_INFORMATION,
            Constants.Mode.Add
        );
    }

    private static int saveData(
        ref Models.ContactInformation contactInformation,
        string                        query,
        Constants.Mode                mode
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
                "@contactInformationID",
                contactInformation.contactInformationID
            );

        sqlCommand.Parameters.AddWithValue(
            "@phoneNumber",
            contactInformation.phoneNumber
        );
        sqlCommand.Parameters.AddWithValue(
            "@email",
            contactInformation.email
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
                    contactInformationID,
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