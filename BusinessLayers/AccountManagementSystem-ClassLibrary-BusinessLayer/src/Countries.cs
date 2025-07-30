using System;
using System.Collections.Generic;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public class Countries {
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

    public static List<Country>? all() => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getAllCountries();

    public static Country? get(
        ref byte countryID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
        ref countryID
    );
}