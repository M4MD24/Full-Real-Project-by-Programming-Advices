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
    public string?   nationalNumber       { get; set; } = nationalNumber;
    public int?      fullNameID           { get; set; } = fullNameID;
    public DateTime? dateOfBirth          { get; set; } = dateOfBirth;
    public string?   address              { get; set; } = address;
    public int?      contactInformationID { get; set; } = contactInformationID;
    public byte?     countryID            { get; set; } = countryID;
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