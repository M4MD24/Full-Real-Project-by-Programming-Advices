using System;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Person(
    int?      personID,
    string?   nationalNumber,
    int?      fullNameID,
    DateTime? dateOfBirth,
    string?   address,
    int?      contactInformationID,
    byte?     countryID,
    string?   imageURL
) {
    public int?      personID             { get; set; } = personID;
    public string?   nationalNumber       { get; }      = nationalNumber;
    public int?      fullNameID           { get; }      = fullNameID;
    public DateTime? dateOfBirth          { get; }      = dateOfBirth;
    public string?   address              { get; }      = address;
    public int?      contactInformationID { get; }      = contactInformationID;
    public byte?     countryID            { get; }      = countryID;
    public string?   imageURL             { get; set; } = imageURL;

    public Person(
        string?   nationalNumber,
        int?      fullNameID,
        DateTime? dateOfBirth,
        string?   address,
        int?      contactInformationID,
        byte?     countryID,
        string?   imageURL
    ) : this(
        null,
        nationalNumber,
        fullNameID,
        dateOfBirth,
        address,
        contactInformationID,
        countryID,
        imageURL
    ) {}
}