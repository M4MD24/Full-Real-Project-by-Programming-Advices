USE DriverAndVehicleLicenceDepartment;

CREATE SCHEMA AccountManagementSystem;

CREATE TABLE AccountManagementSystem.Countries
(
    CountryID   INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    CountryName NVARCHAR(75) NOT NULL,
    CountryCode NVARCHAR(3)  NOT NULL
)

CREATE TABLE AccountManagementSystem.ContactInformation
(
    ContactInformationID INT           NOT NULL PRIMARY KEY IDENTITY (1,1),
    PhoneNumber          NVARCHAR(20)  NOT NULL,
    Email                NVARCHAR(100) NOT NULL
)

CREATE TABLE AccountManagementSystem.FullNames
(
    FullNameID INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    FirstName  NVARCHAR(20) NOT NULL,
    SecondName NVARCHAR(20) NOT NULL,
    ThirdName  NVARCHAR(20) NOT NULL,
    FourthName NVARCHAR(20) NOT NULL
)

CREATE TABLE AccountManagementSystem.Persons
(
    PersonID             INT           NOT NULL PRIMARY KEY IDENTITY (1,1),
    NationalNumber       NVARCHAR(30)  NOT NULL,
    FullNameID           INT           NOT NULL,
    DateOfBirth          DATETIME      NOT NULL,
    Address              NVARCHAR(200) NOT NULL,
    ContactInformationID INT           NOT null,
    CountryID            INT           NOT null,
    ImageURL             NVARCHAR(2083),
    FOREIGN KEY (FullNameID) REFERENCES AccountManagementSystem.FullNames (FullNameID),
    FOREIGN KEY (ContactInformationID) REFERENCES AccountManagementSystem.ContactInformation (ContactInformationID),
    FOREIGN KEY (CountryID) REFERENCES AccountManagementSystem.Countries (CountryID)
)