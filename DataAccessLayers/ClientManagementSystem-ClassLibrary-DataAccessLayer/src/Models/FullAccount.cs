using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class FullClient(
    int?      clientID,
    int?      personID,
    string?   nationalNumber,
    int?      fullNameID,
    string?   firstName,
    string?   secondName,
    string?   thirdName,
    string?   fourthName,
    DateTime? dateOfBirth,
    string?   address,
    int?      contactInformationID,
    int?      mobileNumberID,
    string?   contactNumber,
    byte?     mobileNumberCountryID,
    string?   mobileNumberCountryName,
    string?   mobileNumberCountryCode,
    string?   email,
    byte?     countryID,
    string?   countryName,
    string?   countryCode,
    string?   imageURL
) {
    public int?      clientID               { get; } = clientID;
    public int?      personID                { get; } = personID;
    public string?   nationalNumber          { get; } = nationalNumber;
    public int?      fullNameID              { get; } = fullNameID;
    public string?   firstName               { get; } = firstName;
    public string?   secondName              { get; } = secondName;
    public string?   thirdName               { get; } = thirdName;
    public string?   fourthName              { get; } = fourthName;
    public DateTime? dateOfBirth             { get; } = dateOfBirth;
    public string?   address                 { get; } = address;
    public int?      contactInformationID    { get; } = contactInformationID;
    public int?      mobileNumberID          { get; } = mobileNumberID;
    public string?   contactNumber           { get; } = contactNumber;
    public byte?     mobileNumberCountryID   { get; } = mobileNumberCountryID;
    public string?   mobileNumberCountryName { get; } = mobileNumberCountryName;
    public string?   mobileNumberCountryCode { get; } = mobileNumberCountryCode;
    public string?   email                   { get; } = email;
    public byte?     countryID               { get; } = countryID;
    public string?   countryName             { get; } = countryName;
    public string?   countryCode             { get; } = countryCode;
    public string?   imageURL                { get; } = imageURL;

    public struct FullClientFields(
        string?   nationalNumber,
        string?   firstName,
        string?   secondName,
        string?   thirdName,
        string?   fourthName,
        DateTime? dateOfBirth,
        string?   address,
        string?   mobileNumberCountryName,
        string?   contactNumber,
        string?   email,
        string?   countryName,
        string?   imageUrl
    ) {
        public          string?   nationalNumber          = nationalNumber;
        public readonly string?   firstName               = firstName;
        public readonly string?   secondName              = secondName;
        public readonly string?   thirdName               = thirdName;
        public readonly string?   fourthName              = fourthName;
        public readonly DateTime? dateOfBirth             = dateOfBirth;
        public readonly string?   address                 = address;
        public          string?   mobileNumberCountryName = mobileNumberCountryName;
        public readonly string?   contactNumber           = contactNumber;
        public readonly string?   email                   = email;
        public          string?   countryName             = countryName;
        public          string?   imageURL                = imageUrl;
    }

    public struct FullClientIDs(
        int?  clientID,
        int?  personID,
        int?  fullNameID,
        int?  contactInformationID,
        int?  mobileNumberID,
        byte? mobileNumberCountryID,
        byte? countryID
    ) {
        public readonly int?  clientID             = clientID;
        public          int?  personID              = personID;
        public readonly int?  fullNameID            = fullNameID;
        public readonly int?  contactInformationID  = contactInformationID;
        public readonly int?  mobileNumberID        = mobileNumberID;
        public readonly byte? mobileNumberCountryID = mobileNumberCountryID;
        public readonly byte? countryID             = countryID;
    }
}