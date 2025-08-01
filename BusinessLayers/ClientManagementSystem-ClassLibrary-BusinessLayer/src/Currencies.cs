using System.Collections.Generic;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public class Currencies {
    public static int update(
        ref Currency currency
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Currencies.updateCurrencyByCurrencyID(
        ref currency
    );

    public static int delete(
        ref byte currencyID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Currencies.deleteCurrencyByCurrencyID(
        ref currencyID
    );

    public static int add(
        ref Currency currency
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Currencies.addNewCurrency(
        ref currency
    );

    public static List<Currency>? getAll() => ClientManagementSystem_ClassLibrary_DataAccessLayer.Currencies.getAllCurrencies();

    public static Currency? get(
        ref byte currencyID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.Currencies.getCurrencyByCurrencyID(
        ref currencyID
    );
}