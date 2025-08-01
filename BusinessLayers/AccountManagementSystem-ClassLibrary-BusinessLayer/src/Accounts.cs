using System.Collections.Generic;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public class Accounts {
    public static int update(
        ref Account account
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.updateAccountByAccountID(
        ref account
    );

    public static int delete(
        ref int accountID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.deleteAccountByAccountID(
        ref accountID
    );

    public static int add(
        ref Account account
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.addNewAccount(
        ref account
    );

    public static List<Account>? all() => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.getAllAccounts();

    public static Account? get(
        ref int accountID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.getAccountByAccountID(
        ref accountID
    );
}