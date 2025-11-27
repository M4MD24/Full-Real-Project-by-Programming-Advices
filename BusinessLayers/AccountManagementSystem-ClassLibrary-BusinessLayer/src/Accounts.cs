using System.Collections.Generic;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public static class Accounts {
    public static int update(
        ref Account account
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.updateAccountByAccountID(
        ref account
    );

    public static int delete(
        ref int? accountID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.deleteAccountByAccountID(
        ref accountID
    );

    public static int add(
        ref Account account
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.addNewAccount(
        ref account
    );

    public static List<Account>? getAll() => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.getAllAccounts();

    public static Account? get(
        ref int? accountID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.getAccountByAccountID(
        ref accountID
    );

    public static bool isExist(
        string? username
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.isAccountExistByUsername(
        ref username
    );

    public static int changeStatus(
        ref int? accountID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.changeStatusbyAccountID(
        ref accountID
    );

    public static bool isCorrect(
        string? username,
        string? password
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.isCorrectAccountByUsernameAndPassword(
        ref username,
        ref password
    );

    public static bool isActive(
        string? username,
        string? password
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.isActiveByUsernameAndPassword(
        ref username,
        ref password
    );
}