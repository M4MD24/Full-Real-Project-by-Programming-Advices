using System;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer.Models;

public class FullAccount(
    int?      accountID,
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
    string?   imageURL,
    string?   username,
    string?   password,
    bool?     isActive,
    byte?     accountTypeID,
    string?   accountTypeName
) {
    public int?      accountID               { get; set; } = accountID;
    public int?      personID                { get; set; } = personID;
    public string?   nationalNumber          { get; set; } = nationalNumber;
    public int?      fullNameID              { get; set; } = fullNameID;
    public string?   firstName               { get; set; } = firstName;
    public string?   secondName              { get; set; } = secondName;
    public string?   thirdName               { get; set; } = thirdName;
    public string?   fourthName              { get; set; } = fourthName;
    public DateTime? dateOfBirth             { get; set; } = dateOfBirth;
    public string?   address                 { get; set; } = address;
    public int?      contactInformationID    { get; set; } = contactInformationID;
    public int?      mobileNumberID          { get; set; } = mobileNumberID;
    public string?   contactNumber           { get; set; } = contactNumber;
    public byte?     mobileNumberCountryID   { get; set; } = mobileNumberCountryID;
    public string?   mobileNumberCountryName { get; set; } = mobileNumberCountryName;
    public string?   mobileNumberCountryCode { get; set; } = mobileNumberCountryCode;
    public string?   email                   { get; set; } = email;
    public byte?     countryID               { get; set; } = countryID;
    public string?   countryName             { get; set; } = countryName;
    public string?   countryCode             { get; set; } = countryCode;
    public string?   imageURL                { get; set; } = imageURL;
    public string?   username                { get; set; } = username;
    public string?   password                { get; set; } = password;
    public bool?     isActive                { get; set; } = isActive;
    public byte?     accountTypeID           { get; set; } = accountTypeID;
    public string?   accountTypeName         { get; set; } = accountTypeName;

    public FullAccount(
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
        string?   imageURL,
        string?   username,
        string?   password,
        bool?     isActive,
        byte?     accountTypeID,
        string?   accountTypeName
    ) : this(
        null,
        personID,
        nationalNumber,
        fullNameID,
        firstName,
        secondName,
        thirdName,
        fourthName,
        dateOfBirth,
        address,
        contactInformationID,
        mobileNumberID,
        contactNumber,
        mobileNumberCountryID,
        mobileNumberCountryName,
        mobileNumberCountryCode,
        email,
        countryID,
        countryName,
        countryCode,
        imageURL,
        username,
        password,
        isActive,
        accountTypeID,
        accountTypeName
    ) {}
}