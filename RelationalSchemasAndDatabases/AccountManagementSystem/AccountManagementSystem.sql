USE DriverAndVehicleLicenseDepartment;

CREATE SCHEMA AccountManagementSystem;

CREATE TABLE AccountManagementSystem.Countries
(
    CountryID   TINYINT      NOT NULL PRIMARY KEY,
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
    ContactInformationID INT           NOT NULL,
    CountryID            TINYINT       NOT NULL,
    ImageURL             NVARCHAR(2083),
    FOREIGN KEY (FullNameID) REFERENCES AccountManagementSystem.FullNames (FullNameID),
    FOREIGN KEY (ContactInformationID) REFERENCES AccountManagementSystem.ContactInformation (ContactInformationID),
    FOREIGN KEY (CountryID) REFERENCES AccountManagementSystem.Countries (CountryID)
)

CREATE TABLE AccountManagementSystem.AccountTypes
(
    AccountTypeID   TINYINT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    AccountTypeName NVARCHAR(25) NOT NULL
)

CREATE TABLE AccountManagementSystem.Accounts
(
    AccountID     INT         NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID      INT         NOT NULL,
    Username      VARCHAR(50) NOT NULL,
    Password      VARCHAR(50) NOT NULL,
    IsActive      BIT         NOT NULL,
    AccountTypeID TINYINT     NOT NULL,
    FOREIGN KEY (PersonID) REFERENCES AccountManagementSystem.Persons (PersonID),
    FOREIGN KEY (AccountTypeID) REFERENCES AccountManagementSystem.AccountTypes (AccountTypeID)
)

CREATE TABLE AccountManagementSystem.Permissions
(
    PermissionID     TINYINT     NOT NULL PRIMARY KEY IDENTITY (1,1),
    PermissionNumber TINYINT     NOT NULL,
    PermissionName   VARCHAR(50) NOT NULL
)

CREATE TABLE AccountManagementSystem.AccountPermissions
(
    AccountID    INT     NOT NULL,
    PermissionID TINYINT NOT NULL,
    FOREIGN KEY (AccountID) REFERENCES AccountManagementSystem.Accounts (AccountID),
    FOREIGN KEY (PermissionID) REFERENCES AccountManagementSystem.Permissions (PermissionID)
)