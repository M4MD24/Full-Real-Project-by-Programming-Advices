using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer;

public class Persons {
    public static int updatePersonByPersonID(
        ref Person person
    ) {
        const string UPDATE_PERSON_BY_PERSON_ID = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  UPDATE AccountManagementSystem.Accounts
                                                  SET NationalNumber       = @nationalNumber,
                                                      FullNameID           = @fullNameID,
                                                      DateOfBirth          = @dateOfBirth,
                                                      Address              = @address,
                                                      ContactInformationID = @contactInformationID,
                                                      CountryID            = @countryID,
                                                      ImageURL             = @imageURL
                                                  WHERE AccountID = @accountID
                                                  """;

        return saveData(
            ref person,
            UPDATE_PERSON_BY_PERSON_ID,
            Constants.Mode.Update
        );
    }

    public static int deletePersonByPersonID(
        ref int personID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_PERSON_BY_PERSON_ID = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  DELETE AccountManagementSystem.Persons
                                                  WHERE PersonID = @personID
                                                  """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_PERSON_BY_PERSON_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@personID",
            personID
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

    public static int addNewPerson(
        ref Person person
    ) {
        const string ADD_NEW_PERSON = """
                                      USE DriverAndVehicleLicenseDepartment
                                      INSERT INTO AccountManagementSystem.Persons (NationalNumber, FullNameID, DateOfBirth, Address, ContactInformationID, CountryID, ImageURL)
                                      VALUES (@nationalNumber, @fullNameID, @dateOfBirth, @address, @contactInformationID, @countryID, @imageURL)
                                      """;

        return saveData(
            ref person,
            ADD_NEW_PERSON,
            Constants.Mode.Add
        );
    }

    private static int saveData(
        ref Person     person,
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
                "@personID",
                person.personID
            );

        sqlCommand.Parameters.AddWithValue(
            "@nationalNumber",
            person.nationalNumber
        );
        sqlCommand.Parameters.AddWithValue(
            "@fullNameID",
            person.fullNameID
        );
        sqlCommand.Parameters.AddWithValue(
            "@dateOfBirth",
            person.dateOfBirth
        );
        sqlCommand.Parameters.AddWithValue(
            "@address",
            person.address
        );
        sqlCommand.Parameters.AddWithValue(
            "@contactInformationID",
            person.contactInformationID
        );
        sqlCommand.Parameters.AddWithValue(
            "@countryID",
            person.countryID
        );
        sqlCommand.Parameters.AddWithValue(
            "@imageURL",
            person.imageURL
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

    public static List<Person>? getAllPersons() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_PERSONS = """
                                       USE DriverAndVehicleLicenseDepartment
                                       SELECT *
                                       FROM AccountManagementSystem.Persons
                                       """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_PERSONS,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Person>  persons       = [];
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                int      personID             = (int) sqlDataReader["PersonID"];
                string   nationalNumber       = (string) sqlDataReader["NationalNumber"];
                int      fullNameID           = (int) sqlDataReader["FullNameID"];
                DateTime dateOfBirth          = (DateTime) sqlDataReader["DateOfBirth"];
                string   address              = (string) sqlDataReader["Address"];
                int      contactInformationID = (int) sqlDataReader["ContactInformationID"];
                byte     countryID            = (byte) sqlDataReader["CountryID"];
                string   imageURL             = (string) sqlDataReader["ImageURL"];

                persons.Add(
                    new Person(
                        personID,
                        nationalNumber,
                        fullNameID,
                        dateOfBirth,
                        address,
                        contactInformationID,
                        countryID,
                        imageURL
                    )
                );
            }

            sqlDataReader.Close();
            return persons;
        } catch (Exception exception) {
            Console.WriteLine(
                exception.Message
            );
        } finally {
            sqlConnection.Close();
        }

        return null;
    }

    public static Person? getPersonByPersonID(
        ref int personID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_PERSON_BY_PERSON_ID = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  SELECT *
                                                  FROM AccountManagementSystem.Persons
                                                  WHERE PersonID = @personID
                                                  """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_PERSON_BY_PERSON_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@personID",
            personID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                string   nationalNumber       = (string) sqlDataReader["NationalNumber"];
                int      fullNameID           = (int) sqlDataReader["FullNameID"];
                DateTime dateOfBirth          = (DateTime) sqlDataReader["DateOfBirth"];
                string   address              = (string) sqlDataReader["Address"];
                int      contactInformationID = (int) sqlDataReader["ContactInformationID"];
                byte     countryID            = (byte) sqlDataReader["CountryID"];
                string   imageURL             = (string) sqlDataReader["ImageURL"];
                return new Person(
                    personID,
                    nationalNumber,
                    fullNameID,
                    dateOfBirth,
                    address,
                    contactInformationID,
                    countryID,
                    imageURL
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