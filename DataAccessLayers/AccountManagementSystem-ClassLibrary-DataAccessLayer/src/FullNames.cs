using System;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public static class FullNames {
    public static int updateFullNameByFullNameID(
        ref FullName fullName
    ) {
        const string UPDATE_FULL_NAME_BY_FULL_NAME_ID = """
                                                        USE DriverAndVehicleLicenseDepartment
                                                        UPDATE AccountManagementSystem.FullNames
                                                        SET FirstName  = @firstName,
                                                            SecondName = @secondName,
                                                            ThirdName  = @thirdName,
                                                            FourthName = @fourthName
                                                        WHERE FullNameID = @fullNameID
                                                        """;

        return saveData(
            ref fullName,
            UPDATE_FULL_NAME_BY_FULL_NAME_ID,
            Constants.Mode.Update
        );
    }

    public static int deleteFullNameByFullNameID(
        ref int? fullNameID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_FULL_NAME_BY_FULL_NAME_ID = """
                                                        USE DriverAndVehicleLicenseDepartment
                                                        DELETE AccountManagementSystem.FullNames
                                                        WHERE FullNameID = @fullNameID
                                                        """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_FULL_NAME_BY_FULL_NAME_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@fullNameID",
            fullNameID
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

    public static int addNewFullName(
        ref FullName fullName
    ) {
        const string ADD_NEW_FULL_NAME = """
                                         USE DriverAndVehicleLicenseDepartment
                                         INSERT INTO AccountManagementSystem.FullNames (FirstName, SecondName, ThirdName, FourthName)
                                         VALUES (@firstName, @secondName, @thirdName, @fourthName);
                                         SELECT SCOPE_IDENTITY();
                                         """;

        return saveData(
            ref fullName,
            ADD_NEW_FULL_NAME,
            Constants.Mode.Add
        );
    }

    private static int saveData(
        ref FullName   fullName,
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
                "@fullNameID",
                fullName.fullNameID
            );

        sqlCommand.Parameters.AddWithValue(
            "@firstName",
            fullName.firstName
        );
        sqlCommand.Parameters.AddWithValue(
            "@secondName",
            fullName.secondName
        );
        sqlCommand.Parameters.AddWithValue(
            "@thirdName",
            fullName.thirdName
        );
        sqlCommand.Parameters.AddWithValue(
            "@fourthName",
            fullName.fourthName
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

    public static FullName? getFullNameByFullNameID(
        ref int fullNameID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_FULL_NAME_BY_FULL_NAME_ID = """
                                                        USE DriverAndVehicleLicenseDepartment
                                                        SELECT *
                                                        FROM AccountManagementSystem.FullNames
                                                        WHERE FullNameID = @fullNameID
                                                        """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_FULL_NAME_BY_FULL_NAME_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@fullNameID",
            fullNameID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string firstName  = (string) sqlDataReader["FirstName"],
                       secondName = (string) sqlDataReader["SecondName"],
                       thirdName  = (string) sqlDataReader["ThirdName"],
                       fourthName = (string) sqlDataReader["FourthName"];
                return new FullName(
                    fullNameID,
                    firstName,
                    secondName,
                    thirdName,
                    fourthName
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