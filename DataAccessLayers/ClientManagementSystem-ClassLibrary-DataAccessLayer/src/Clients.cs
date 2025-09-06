using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Clients {
    public static List<Client>? getAllClients() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_ACCOUNTS = """
                                        USE DriverAndVehicleLicenseDepartment
                                        SELECT *
                                        FROM ClientManagementSystem.Clients
                                        """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_ACCOUNTS,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Client>  accounts      = [];
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                int accountID = (int) sqlDataReader["ClientID"];
                int personID  = (int) sqlDataReader["PersonID"];

                accounts.Add(
                    new Client(
                        accountID,
                        personID
                    )
                );
            }

            sqlDataReader.Close();
            return accounts;
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