using ClientManagementSystem_ClassLibrary_BusinessLayer;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using ContactInformation = ClientManagementSystem_ClassLibrary_BusinessLayer.ContactInformation;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public static class FullClients {
    public static FullClient get(
        ref int? clientID
    ) {
        Client? client = ClientManagementSystem_ClassLibrary_DataAccessLayer.Clients.getClientByClientID(
            ref clientID
        );

        int? personID = client!.personID;
        Person? person = ClientManagementSystem_ClassLibrary_DataAccessLayer.Persons.getPersonByPersonID(
            ref personID
        );

        int? fullNameID = person!.fullNameID;
        FullName? fullName = ClientManagementSystem_ClassLibrary_DataAccessLayer.FullNames.getFullNameByFullNameID(
            ref fullNameID
        );

        int? contactInformationID = person.contactInformationID;
        ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation? contactInformation = ClientManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.getContactInformationByContactInformationID(
            ref contactInformationID
        );

        int? mobileNumberID = contactInformation!.mobileNumberID;
        MobileNumber? mobileNumber = ClientManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.getMobileNumberByMobileNumberID(
            ref mobileNumberID
        );

        byte? mobileNumberCountryID = mobileNumber!.countryID;
        Country? countryMobileNumber = ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
            ref mobileNumberCountryID
        );

        byte? countryID = person.countryID;
        Country? country = ClientManagementSystem_ClassLibrary_DataAccessLayer.Countries.getCountryByCountryID(
            ref countryID
        );

        return new FullClient(
            clientID,
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
            person.imageURL
        );
    }

    public static void add(
        ref FullClient.FullClientFields fullClientFields
    ) {
        FullName fullName = new FullName(
            fullClientFields.firstName,
            fullClientFields.secondName,
            fullClientFields.thirdName,
            fullClientFields.fourthName
        );
        int? fullNameID = FullNames.add(
            ref fullName
        );

        byte? countryID_MobileNumber = ClientManagementSystem_ClassLibrary_BusinessLayer.Countries.get(
                                                                                            ref fullClientFields.mobileNumberCountryName!
                                                                                        )!
                                                                                        .countryID;
        MobileNumber mobileNumber = new MobileNumber(
            fullClientFields.contactNumber,
            countryID_MobileNumber
        );
        int? mobileNumberID = MobileNumbers.add(
            ref mobileNumber
        );

        ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation = new ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation(
            mobileNumberID,
            fullClientFields.email
        );
        int? contactInformationID = ContactInformation.add(
            ref contactInformation
        );

        byte? countryID = ClientManagementSystem_ClassLibrary_BusinessLayer.Countries.get(
                                                                               ref fullClientFields.countryName!
                                                                           )!
                                                                           .countryID;

        Person person = new Person(
            fullClientFields.nationalNumber,
            fullNameID,
            fullClientFields.dateOfBirth,
            fullClientFields.address,
            contactInformationID,
            countryID,
            fullClientFields.imageURL
        );

        person.personID = Persons.add(
            ref person
        );

        string? nationalNumber = fullClientFields.nationalNumber!;

        person.imageURL = Tools.ImageTools.copyImageToImageDirectory(
            ref nationalNumber,
            ref fullClientFields.imageURL!
        );

        Persons.update(
            ref person
        );

        Client client = new Client(
            person.personID
        );
        Clients.add(
            ref client
        );
    }

    public static void delete(
        ref Client client
    ) {
        int? clientID = client.clientID,
             personID = client.personID;
        Person person = Persons.get(
            ref personID
        )!;
        int? fullNameID           = person.fullNameID,
             contactInformationID = person.contactInformationID;
        string? imageURL = person.imageURL;
        ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation = ContactInformation.get(
            ref contactInformationID
        )!;
        int? mobileNumberID = contactInformation.mobileNumberID;

        Clients.delete(
            ref clientID
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
        ref FullClient.FullClientIDs    fullClientIDs,
        ref FullClient.FullClientFields fullClientFields
    ) {
        Client client = new Client(
            fullClientIDs.clientID,
            fullClientIDs.personID
        );

        Clients.update(
            ref client
        );

        Person person = new Person(
            fullClientIDs.personID,
            fullClientFields.nationalNumber,
            fullClientIDs.fullNameID,
            fullClientFields.dateOfBirth,
            fullClientFields.address,
            fullClientIDs.contactInformationID,
            fullClientIDs.countryID,
            fullClientFields.imageURL
        );

        Person? lastPerson = Persons.get(
            ref fullClientIDs.personID
        );

        string? lastSelectedImagePath = lastPerson!.imageURL,
                lastNationalNumber    = lastPerson.nationalNumber;

        if (
            lastSelectedImagePath != person.imageURL ||
            lastNationalNumber    != person.nationalNumber
        ) {
            person.imageURL = Tools.ImageTools.copyImageToImageDirectory(
                ref fullClientFields.nationalNumber,
                ref fullClientFields.imageURL!
            );
            Tools.ImageTools.deleteImageByImagePath(
                ref lastSelectedImagePath
            );
        }

        Persons.update(
            ref person
        );

        FullName fullName = new FullName(
            fullClientIDs.clientID,
            fullClientFields.firstName,
            fullClientFields.secondName,
            fullClientFields.thirdName,
            fullClientFields.fourthName
        );

        FullNames.update(
            ref fullName
        );

        ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation = new ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation(
            fullClientIDs.contactInformationID,
            fullClientIDs.mobileNumberID,
            fullClientFields.email
        );

        ContactInformation.update(
            ref contactInformation
        );

        MobileNumber mobileNumber = new MobileNumber(
            fullClientIDs.mobileNumberID,
            fullClientFields.contactNumber,
            fullClientIDs.mobileNumberCountryID
        );

        MobileNumbers.update(
            ref mobileNumber
        );
    }
}