using System.Collections.Generic;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public static class Countries {
    public static List<string> getAllCountryNames() => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getAllCountryNames();

    public static int update(
        ref Country country
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.updateCountryByCountryID(
        ref country
    );

    public static int delete(
        ref byte countryID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.deleteCountryByCountryID(
        ref countryID
    );

    public static int add(
        ref Country country
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.addNewCountry(
        ref country
    );

    public static List<Country>? getAll() => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getAllCountries();

    public static Country? get(
        ref byte countryID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
        ref countryID
    );

    public static Country? get(
        ref string countryName
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryName(
        ref countryName
    );
}