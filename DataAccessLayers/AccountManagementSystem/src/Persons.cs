using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccountManagementSystem.Models;
using AccountManagementSystem.Utilities;

namespace AccountManagementSystem;

public class Persons {
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