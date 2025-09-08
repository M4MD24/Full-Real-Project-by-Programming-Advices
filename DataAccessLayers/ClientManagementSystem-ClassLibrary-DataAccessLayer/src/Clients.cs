using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer;

public static class Clients {
    public static int updateClientByClientID(
        ref Client client
    ) {
        const string UPDATE_CLIENT_BY_CLIENT_ID = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  UPDATE ClientManagementSystem.Clients
                                                  SET PersonID      = @personID
                                                  WHERE ClientID = @clientID
                                                  """;

        return saveData(
            ref client,
            UPDATE_CLIENT_BY_CLIENT_ID,
            Constants.Mode.Update
        );
    }

    public static int deleteClientByClientID(
        ref int? clientID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string DELETE_CLIENT_BY_CLIENT_ID = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  DELETE ClientManagementSystem.Clients
                                                  WHERE ClientID = @clientID
                                                  """;
        SqlCommand sqlCommand = new SqlCommand(
            DELETE_CLIENT_BY_CLIENT_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@clientID",
            clientID
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

    public static int addNewClient(
        ref Client client
    ) {
        const string ADD_NEW_CLIENT = """
                                      USE DriverAndVehicleLicenseDepartment
                                      INSERT INTO ClientManagementSystem.Clients (PersonID)
                                      VALUES (@personID);
                                      SELECT SCOPE_IDENTITY();
                                      """;

        int newID = saveData(
            ref client,
            ADD_NEW_CLIENT,
            Constants.Mode.Add
        );
        client.clientID = newID;
        return newID;
    }

    private static int saveData(
        ref Client     client,
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
                "@clientID",
                client.clientID
            );

        sqlCommand.Parameters.AddWithValue(
            "@personID",
            client.personID
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

    public static Client? getClientByClientID(
        ref int? clientID
    ) {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string SELECT_CLIENT_BY_CLIENT_ID = """
                                                  USE DriverAndVehicleLicenseDepartment
                                                  SELECT *
                                                  FROM ClientManagementSystem.Clients
                                                  WHERE ClientID = @clientID
                                                  """;
        SqlCommand sqlCommand = new SqlCommand(
            SELECT_CLIENT_BY_CLIENT_ID,
            sqlConnection
        );
        sqlCommand.Parameters.AddWithValue(
            "@clientID",
            clientID
        );

        try {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int personID = (int) sqlDataReader["PersonID"];
                return new Client(
                    clientID,
                    personID
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

    public static List<Client>? getAllClients() {
        SqlConnection sqlConnection = new SqlConnection(
            Constants.DATABASE_CONNECTIVITY
        );
        const string GET_ALL_CLIENTS = """
                                       USE DriverAndVehicleLicenseDepartment
                                       SELECT *
                                       FROM ClientManagementSystem.Clients
                                       """;
        SqlCommand sqlCommand = new SqlCommand(
            GET_ALL_CLIENTS,
            sqlConnection
        );

        try {
            sqlConnection.Open();
            List<Client>  clients       = [];
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                int clientID = (int) sqlDataReader["ClientID"];
                int personID = (int) sqlDataReader["PersonID"];

                clients.Add(
                    new Client(
                        clientID,
                        personID
                    )
                );
            }

            sqlDataReader.Close();
            return clients;
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