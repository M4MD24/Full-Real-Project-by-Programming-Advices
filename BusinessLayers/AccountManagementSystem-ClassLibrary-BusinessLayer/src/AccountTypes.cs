using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public class AccountTypes {
    public static AccountType? get(
        ref byte accountTypeID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountTypes.getAccountTypeByAccountTypeID(
        ref accountTypeID
    );

    public static AccountType? get(
        ref string accountTypeName
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountTypes.getAccountTypeByAccountTypeName(
        ref accountTypeName
    );
}