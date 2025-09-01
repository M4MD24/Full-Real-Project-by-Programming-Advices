using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class Currencies {
    public static List<Currency>? getAll() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Currencies.getAllCurrencies();

    public static Currency? get(
        ref byte currencyID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Currencies.getCurrencyByCurrencyID(
        ref currencyID
    );
}