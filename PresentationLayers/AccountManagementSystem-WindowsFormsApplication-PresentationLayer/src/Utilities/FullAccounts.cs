using System;
using System.Collections.Generic;
using AccountManagementSystem_ClassLibrary_BusinessLayer;
using AccountManagementSystem_ClassLibrary_BusinessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountPermissions = AccountManagementSystem_ClassLibrary_BusinessLayer.AccountPermissions;
using ContactInformation = AccountManagementSystem_ClassLibrary_BusinessLayer.ContactInformation;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

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
            account.isActive,
            accountTypeID,
            accountType!.accountTypeName
        );
    }

    public static void add(
        ref string   nationalNumber,
        ref string   firstName,
        ref string   secondName,
        ref string   thirdName,
        ref string   fourthName,
        ref DateTime dateOfBirth,
        ref string   address,
        ref string   countryNameMobileNumber,
        ref string   contactNumber,
        ref string   email,
        ref string   countryName,
        ref string   imageURL,
        ref string   username,
        ref string   password,
        ref string   accountTypeName
    ) {
        FullName fullName = new FullName(
            firstName,
            secondName,
            thirdName,
            fourthName
        );
        int? fullNameID = FullNames.add(
            ref fullName
        );

        byte? countryID_MobileNumber = Countries.get(
                                                    ref countryNameMobileNumber
                                                )!
                                                .countryID;
        MobileNumber mobileNumber = new MobileNumber(
            contactNumber,
            countryID_MobileNumber
        );
        int? mobileNumberID = MobileNumbers.add(
            ref mobileNumber
        );

        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation = new AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation(
            mobileNumberID,
            email
        );
        int? contactInformationID = ContactInformation.add(
            ref contactInformation
        );

        byte? countryID = Countries.get(
                                       ref countryName
                                   )!
                                   .countryID;

        Person person = new Person(
            nationalNumber,
            fullNameID,
            dateOfBirth,
            address,
            contactInformationID,
            countryID,
            imageURL
        );

        person.personID = Persons.add(
            ref person
        );

        person.imageURL = AddAndEditAccount.copyImageToImageDirectory(
            person.personID
        );

        Persons.update(
            ref person
        );

        byte? accountTypeID = AccountTypes.get(
            ref accountTypeName
        )!.accountTypeID;

        Account account = new Account(
            person.personID,
            username,
            password,
            true,
            accountTypeID
        );
        Accounts.add(
            ref account
        );

        int?       accountID             = account.accountID;
        List<byte> selectedPermissionIds = AddAndEditAccount.getPermissionIDsFromSelectedPermissions();
        AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.AccountPermissions accountPermissions = new(
            accountID,
            selectedPermissionIds
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

        Tools.ImageTools.deleteImage(
            imageURL!
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
}