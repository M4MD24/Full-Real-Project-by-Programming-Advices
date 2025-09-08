using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Clients {
    public static int update(
        ref Client client
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Clients.updateClientByClientID(
        ref client
    );

    public static int delete(
        ref int? clientID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Clients.deleteClientByClientID(
        ref clientID
    );

    public static int add(
        ref Client client
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Clients.addNewClient(
        ref client
    );

    public static List<Client>? getAll() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Clients.getAllClients();

    public static Client? get(
        ref int? clientID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Clients.getClientByClientID(
        ref clientID
    );
}