using System.Collections.Generic;
using AccountManagementSystem_ClassLibrary_BusinessLayer;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using AccountPermissions = AccountManagementSystem_ClassLibrary_BusinessLayer.AccountPermissions;
using ContactInformation = AccountManagementSystem_ClassLibrary_BusinessLayer.ContactInformation;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public static class FullAccounts {
    public static FullAccount get(
        ref int? accountID
    ) {
        Account? account = AccountManagementSystem_ClassLibrary_DataAccessLayer.Accounts.getAccountByAccountID(
            ref accountID
        );

        int? personID = account!.personID;
        Person? person = AccountManagementSystem_ClassLibrary_DataAccessLayer.Persons.getPersonByPersonID(
            ref personID
        );

        int? fullNameID = person!.fullNameID;
        FullName? fullName = AccountManagementSystem_ClassLibrary_DataAccessLayer.FullNames.getFullNameByFullNameID(
            ref fullNameID
        );

        int? contactInformationID = person.contactInformationID;
        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation? contactInformation = AccountManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.getContactInformationByContactInformationID(
            ref contactInformationID
        );

        int? mobileNumberID = contactInformation!.mobileNumberID;
        MobileNumber? mobileNumber = AccountManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.getMobileNumberByMobileNumberID(
            ref mobileNumberID
        );

        byte? mobileNumberCountryID = mobileNumber!.countryID;
        Country? countryMobileNumber = AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
            ref mobileNumberCountryID
        );

        byte? countryID = person.countryID;
        Country? country = AccountManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
            ref countryID
        );

        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermissions? accountPermissions = AccountPermissions.getAll(
            ref accountID
        );

        List<byte> permissionIDs = accountPermissions!.permissionIDs!;

        List<Permission> permissions = Permissions.getAll(
            ref permissionIDs
        );

        byte? accountTypeID = account.accountTypeID;
        AccountType? accountType = AccountManagementSystem_ClassLibrary_DataAccessLayer.AccountTypes.getAccountTypeByAccountTypeID(
            ref accountTypeID
        );

        return new FullAccount(
            accountID,
            personID,
            person.nationalNumber,
            fullNameID,
            fullName!.firstName,
            fullName.secondName,
            fullName.thirdName,
            fullName.fourthName,
            person.dateOfBirth,
            person.address,
            contactInformationID,
            mobileNumberID,
            mobileNumber.contactNumber,
            mobileNumberCountryID,
            countryMobileNumber!.countryName,
            countryMobileNumber.countryCode,
            contactInformation.email,
            countryID,
            country!.countryName,
            country.countryCode,
            person.imageURL,
            account.username,
            account.password,
            permissions,
            account.isActive,
            accountTypeID,
            accountType!.accountTypeName
        );
    }

    public static void add(
        ref FullAccount.FullAccountFields fullAccountFields
    ) {
        FullName fullName = new FullName(
            fullAccountFields.firstName,
            fullAccountFields.secondName,
            fullAccountFields.thirdName,
            fullAccountFields.fourthName
        );
        int? fullNameID = FullNames.add(
            ref fullName
        );

        byte? countryID_MobileNumber = AccountManagementSystem_ClassLibrary_BusinessLayer.Countries.get(
                                                                                             ref fullAccountFields.mobileNumberCountryName!
                                                                                         )!
                                                                                         .countryID;
        MobileNumber mobileNumber = new MobileNumber(
            fullAccountFields.contactNumber,
            countryID_MobileNumber
        );
        int? mobileNumberID = MobileNumbers.add(
            ref mobileNumber
        );

        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation = new AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation(
            mobileNumberID,
            fullAccountFields.email
        );
        int? contactInformationID = ContactInformation.add(
            ref contactInformation
        );

        byte? countryID = AccountManagementSystem_ClassLibrary_BusinessLayer.Countries.get(
                                                                                ref fullAccountFields.countryName!
                                                                            )!
                                                                            .countryID;

        Person person = new Person(
            fullAccountFields.nationalNumber,
            fullNameID,
            fullAccountFields.dateOfBirth,
            fullAccountFields.address,
            contactInformationID,
            countryID,
            fullAccountFields.imageURL
        );

        person.personID = Persons.add(
            ref person
        );

        string? nationalNumber = fullAccountFields.nationalNumber!;

        person.imageURL = Tools.ImageTools.copyImageToImageDirectory(
            ref nationalNumber,
            ref fullAccountFields.imageURL!
        );

        Persons.update(
            ref person
        );

        byte? accountTypeID = AccountTypes.get(
            ref fullAccountFields.accountTypeName!
        )!.accountTypeID;

        Account account = new Account(
            person.personID,
            fullAccountFields.username,
            fullAccountFields.password,
            true,
            accountTypeID
        );
        Accounts.add(
            ref account
        );

        int? accountID = account.accountID;
        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermissions accountPermissions = new(
            accountID,
            fullAccountFields.permissionIDs
        );
        AccountPermissions.addAll(
            ref accountPermissions
        );
    }

    public static void delete(
        ref Account account
    ) {
        int? accountID = account.accountID,
             personID  = account.personID;
        Person person = Persons.get(
            ref personID
        )!;
        int? fullNameID           = person.fullNameID,
             contactInformationID = person.contactInformationID;
        string? imageURL = person.imageURL;
        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation = ContactInformation.get(
            ref contactInformationID
        )!;
        int? mobileNumberID = contactInformation.mobileNumberID;

        AccountPermissions.deleteAll(
            ref accountID
        );

        Accounts.delete(
            ref accountID
        );

        Persons.delete(
            ref personID
        );

        Tools.ImageTools.deleteImageByImagePath(
            ref imageURL
        );

        FullNames.delete(
            ref fullNameID
        );

        ContactInformation.delete(
            ref contactInformationID
        );

        MobileNumbers.delete(
            ref mobileNumberID
        );
    }

    public static void update(
        ref FullAccount.FullAccountIDs    fullAccountIDs,
        ref FullAccount.FullAccountFields fullAccountFields,
        ref bool?                         isActive
    ) {
        Account account = new Account(
            fullAccountIDs.accountID,
            fullAccountIDs.personID,
            fullAccountFields.username,
            fullAccountFields.password,
            isActive,
            fullAccountIDs.accountTypeID
        );

        Accounts.update(
            ref account
        );

        int? accountID = fullAccountIDs.accountID;

        AccountPermissions.deleteAll(
            ref accountID
        );

        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermissions accountPermissions = new AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermissions(
            fullAccountIDs.accountID,
            fullAccountFields.permissionIDs
        );

        AccountPermissions.addAll(
            ref accountPermissions
        );

        Person person = new Person(
            fullAccountIDs.personID,
            fullAccountFields.nationalNumber,
            fullAccountIDs.fullNameID,
            fullAccountFields.dateOfBirth,
            fullAccountFields.address,
            fullAccountIDs.contactInformationID,
            fullAccountIDs.countryID,
            fullAccountFields.imageURL
        );

        Person? lastPerson = Persons.get(
            ref fullAccountIDs.personID
        );

        string? lastSelectedImagePath = lastPerson!.imageURL,
                lastNationalNumber    = lastPerson.nationalNumber;

        if (
            lastSelectedImagePath != person.imageURL ||
            lastNationalNumber    != person.nationalNumber
        ) {
            person.imageURL = Tools.ImageTools.copyImageToImageDirectory(
                ref fullAccountFields.nationalNumber,
                ref fullAccountFields.imageURL!
            );
            Tools.ImageTools.deleteImageByImagePath(
                ref lastSelectedImagePath
            );
        }

        Persons.update(
            ref person
        );

        FullName fullName = new FullName(
            fullAccountIDs.accountID,
            fullAccountFields.firstName,
            fullAccountFields.secondName,
            fullAccountFields.thirdName,
            fullAccountFields.fourthName
        );

        FullNames.update(
            ref fullName
        );

        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation = new AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation(
            fullAccountIDs.contactInformationID,
            fullAccountIDs.mobileNumberID,
            fullAccountFields.email
        );

        ContactInformation.update(
            ref contactInformation
        );

        MobileNumber mobileNumber = new MobileNumber(
            fullAccountIDs.mobileNumberID,
            fullAccountFields.contactNumber,
            fullAccountIDs.mobileNumberCountryID
        );

        MobileNumbers.update(
            ref mobileNumber
        );
    }
}