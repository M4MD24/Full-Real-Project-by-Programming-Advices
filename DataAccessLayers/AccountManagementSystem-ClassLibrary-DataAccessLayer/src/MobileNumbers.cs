using System;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public static class MobileNumbers {
    public static int updateMobileNumberByMobileNumberID(
        ref MobileNumber mobileNumberID
    ) {
        const string UPDATE_MOBILE_NUMBER_BY_MOBILE_NUMBER_ID = """
                                                                USE DriverAndVehicleLicenseDepartment
                                                                UPDATE AccountManagementSystem.MobileNumbers
                                                                SET ContactNumber = @contactNumber,
                                                                    CountryID     = @countryID
                                                                WHERE MobileNumberID = @mobileNumberID
                                                                """;

        return saveData(
            ref mobileNumberID,
            UPDATE_MOBILE_NUMBER_BY_MOBILE_NUMBER_ID,
            Constants.Mode.Update
        );
    }

    public static int deleteMobileNumberByMobileNumberID(
        ref int mobileNumberID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_MOBILE_NUMBER_BY_MOBILE_NUMBER_ID = """
                                                                USE DriverAndVehicleLicenseDepartment
                                                                DELETE AccountManagementSystem.MobileNumbers
                                                                WHERE MobileNumberID = @mobileNumberID
                                                                """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_MOBILE_NUMBER_BY_MOBILE_NUMBER_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@mobileNumberID",
            mobileNumberID
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

    public static int addNewMobileNumber(
        ref MobileNumber mobileNumber
    ) {
        const string ADD_NEW_CONTACT_INFORMATION = """
                                                   USE DriverAndVehicleLicenseDepartment
                                                   INSERT INTO AccountManagementSystem.MobileNumbers (ContactNumber, CountryID)
                                                   VALUES (@contactNumber, @countryID);
                                                   SELECT SCOPE_IDENTITY();
                                                   """;

        return saveData(
            ref mobileNumber,
            ADD_NEW_CONTACT_INFORMATION,
            Constants.Mode.Add
        );
    }

    private static int saveData(
        ref MobileNumber mobileNumber,
        string           query,
        Constants.Mode   mode
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
                "@mobileNumberID",
                mobileNumber.mobileNumberID
            );

        sqlCommand.Parameters.AddWithValue(
            "@contactNumber",
            mobileNumber.contactNumber
        );
        sqlCommand.Parameters.AddWithValue(
            "@countryID",
            mobileNumber.countryID
        );

        int rowAffected = 0;
        try {
            sqlConnection.Open();
            if (mode == Constants.Mode.Add) {
                object result = sqlCommand.ExecuteScalar()!;
                int newID = Convert.ToInt32(
                    result
                );
                return newID;
            } else
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

    public static MobileNumber? getMobileNumberByMobileNumberID(
        ref int mobileNumberID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_MOBILE_NUMBER_BY_MOBILE_NUMBER_ID = """
                                                                USE DriverAndVehicleLicenseDepartment
                                                                SELECT *
                                                                FROM AccountManagementSystem.MobileNumbers
                                                                WHERE MobileNumberID = @mobileNumberID
                                                                """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_MOBILE_NUMBER_BY_MOBILE_NUMBER_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@mobileNumberID",
            mobileNumberID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string contactNumber = (string) sqlDataReader["ContactNumber"];
                int    countryID     = (int) sqlDataReader["CountryID"];
                return new MobileNumber(
                    mobileNumberID,
                    contactNumber,
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