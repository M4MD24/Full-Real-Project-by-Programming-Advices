using System;
using System.Collections.Generic;

namespace AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class FullAccount(
    int?              accountID,
    int?              personID,
    string?           nationalNumber,
    int?              fullNameID,
    string?           firstName,
    string?           secondName,
    string?           thirdName,
    string?           fourthName,
    DateTime?         dateOfBirth,
    string?           address,
    int?              contactInformationID,
    int?              mobileNumberID,
    string?           contactNumber,
    byte?             mobileNumberCountryID,
    string?           mobileNumberCountryName,
    string?           mobileNumberCountryCode,
    string?           email,
    byte?             countryID,
    string?           countryName,
    string?           countryCode,
    string?           imageURL,
    string?           username,
    string?           password,
    List<Permission>? permissions,
    bool?             isActive,
    byte?             accountTypeID,
    string?           accountTypeName
) {
    public int?              accountID               { get; } = accountID;
    public int?              personID                { get; } = personID;
    public string?           nationalNumber          { get; } = nationalNumber;
    public int?              fullNameID              { get; } = fullNameID;
    public string?           firstName               { get; } = firstName;
    public string?           secondName              { get; } = secondName;
    public string?           thirdName               { get; } = thirdName;
    public string?           fourthName              { get; } = fourthName;
    public DateTime?         dateOfBirth             { get; } = dateOfBirth;
    public string?           address                 { get; } = address;
    public int?              contactInformationID    { get; } = contactInformationID;
    public int?              mobileNumberID          { get; } = mobileNumberID;
    public string?           contactNumber           { get; } = contactNumber;
    public byte?             mobileNumberCountryID   { get; } = mobileNumberCountryID;
    public string?           mobileNumberCountryName { get; } = mobileNumberCountryName;
    public string?           mobileNumberCountryCode { get; } = mobileNumberCountryCode;
    public string?           email                   { get; } = email;
    public byte?             countryID               { get; } = countryID;
    public string?           countryName             { get; } = countryName;
    public string?           countryCode             { get; } = countryCode;
    public string?           imageURL                { get; } = imageURL;
    public string?           username                { get; } = username;
    public string?           password                { get; } = password;
    public List<Permission>? permissions             { get; } = permissions;
    public bool?             isActive                { get; } = isActive;
    public byte?             accountTypeID           { get; } = accountTypeID;
    public string?           accountTypeName         { get; } = accountTypeName;

    public struct FullAccountFields(
        string?     nationalNumber,
        string?     firstName,
        string?     secondName,
        string?     thirdName,
        string?     fourthName,
        DateTime?   dateOfBirth,
        string?     address,
        string?     mobileNumberCountryName,
        string?     contactNumber,
        string?     email,
        string?     countryName,
        string?     imageUrl,
        string?     username,
        string?     password,
        List<byte>? permissionIDs,
        string?     accountTypeName
    ) {
        public          string?     nationalNumber          = nationalNumber;
        public readonly string?     firstName               = firstName;
        public readonly string?     secondName              = secondName;
        public readonly string?     thirdName               = thirdName;
        public readonly string?     fourthName              = fourthName;
        public readonly DateTime?   dateOfBirth             = dateOfBirth;
        public readonly string?     address                 = address;
        public          string?     mobileNumberCountryName = mobileNumberCountryName;
        public readonly string?     contactNumber           = contactNumber;
        public readonly string?     email                   = email;
        public          string?     countryName             = countryName;
        public          string?     imageURL                = imageUrl;
        public readonly string?     username                = username;
        public readonly string?     password                = password;
        public readonly List<byte>? permissionIDs           = permissionIDs;
        public          string?     accountTypeName         = accountTypeName;
    }

    public struct FullAccountIDs(
        int?  accountID,
        int?  personID,
        int?  fullNameID,
        int?  contactInformationID,
        int?  mobileNumberID,
        byte? mobileNumberCountryID,
        byte? countryID,
        byte? accountTypeID
    ) {
        public readonly int?  accountID             = accountID;
        public          int?  personID              = personID;
        public readonly int?  fullNameID            = fullNameID;
        public readonly int?  contactInformationID  = contactInformationID;
        public readonly int?  mobileNumberID        = mobileNumberID;
        public readonly byte? mobileNumberCountryID = mobileNumberCountryID;
        public readonly byte? countryID             = countryID;
        public readonly byte? accountTypeID         = accountTypeID;
    }
}