using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public class Countries {
    public static List<Country>? getAll() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.getAllCountries();

    public static Country? get(
        ref byte countryID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
        ref countryID
    );
}