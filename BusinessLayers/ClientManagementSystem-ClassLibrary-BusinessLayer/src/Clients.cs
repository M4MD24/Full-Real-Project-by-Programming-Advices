using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Clients {
    public static List<Client>? getAll() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Clients.getAllClients();
}