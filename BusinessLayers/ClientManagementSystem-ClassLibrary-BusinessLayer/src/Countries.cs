using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public class Countries {
    public static int update(
        ref Country country
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.updateCountryByCountryID(
        ref country
    );

    public static int delete(
        ref byte countryID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.deleteCountryByCountryID(
        ref countryID
    );

    public static int add(
        ref Country country
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.addNewCountry(
        ref country
    );

    public static List<Country>? all() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.getAllCountries();

    public static Country? get(
        ref byte countryID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
        ref countryID
    );
}