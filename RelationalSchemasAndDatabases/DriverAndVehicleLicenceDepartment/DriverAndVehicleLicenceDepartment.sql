USE DriverAndVehicleLicenceDepartment;

CREATE SCHEMA DriverAndVehicleLicenceDepartment;

CREATE TABLE DriverAndVehicleLicenceDepartment.Countries
(
    CountryID   TINYINT      NOT NULL PRIMARY KEY,
    CountryName NVARCHAR(75) NOT NULL,
    CountryCode NVARCHAR(3)  NOT NULL
)

CREATE TABLE DriverAndVehicleLicenceDepartment.ContactInformation
(
    ContactInformationID INT           NOT NULL PRIMARY KEY IDENTITY (1,1),
    PhoneNumber          NVARCHAR(20)  NOT NULL,
    Email                NVARCHAR(100) NOT NULL
)

CREATE TABLE DriverAndVehicleLicenceDepartment.FullNames
(
    FullNameID INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    FirstName  NVARCHAR(20) NOT NULL,
    SecondName NVARCHAR(20) NOT NULL,
    ThirdName  NVARCHAR(20) NOT NULL,
    FourthName NVARCHAR(20) NOT NULL
)

CREATE TABLE DriverAndVehicleLicenceDepartment.Persons
(
    PersonID             INT           NOT NULL PRIMARY KEY IDENTITY (1,1),
    NationalNumber       NVARCHAR(30)  NOT NULL,
    FullNameID           INT           NOT NULL,
    DateOfBirth          DATETIME      NOT NULL,
    Address              NVARCHAR(200) NOT NULL,
    ContactInformationID INT           NOT NULL,
    CountryID            TINYINT       NOT NULL,
    ImageURL             NVARCHAR(2083),
    FOREIGN KEY (FullNameID) REFERENCES DriverAndVehicleLicenceDepartment.FullNames (FullNameID),
    FOREIGN KEY (ContactInformationID) REFERENCES DriverAndVehicleLicenceDepartment.ContactInformation (ContactInformationID),
    FOREIGN KEY (CountryID) REFERENCES DriverAndVehicleLicenceDepartment.Countries (CountryID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.Clients
(
    ClientID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID INT NOT NULL,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenceDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.Employees
(
    EmployeeID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID   INT NOT NULL,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenceDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.EyeDoctors
(
    EyeDoctorID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID    INT NOT NULL,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenceDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.Supervisors
(
    SupervisorID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID     INT NOT NULL,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenceDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.DrivingExaminers
(
    DrivingExaminerID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID          INT NOT NULL,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenceDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.Currencies
(
    CurrencyID INT     NOT NULL PRIMARY KEY IDENTITY (1,1),
    Amount     MONEY   NOT NULL,
    CountryID  TINYINT NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES DriverAndVehicleLicenceDepartment.Countries (CountryID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.Tests
(
    TestID       INT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestDateTime DATETIME NOT NULL,
    CurrencyID   INT      NOT NULL,
    IsSucceed    BIT      NOT NULL,
    FOREIGN KEY (CurrencyID) REFERENCES DriverAndVehicleLicenceDepartment.Currencies (CurrencyID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.EyeTests
(
    EyeTestID   INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID      INT NOT NULL,
    EyeDoctorID INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES DriverAndVehicleLicenceDepartment.Tests (TestID),
    FOREIGN KEY (EyeDoctorID) REFERENCES DriverAndVehicleLicenceDepartment.EyeDoctors (EyeDoctorID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.TheoreticalTests
(
    TheoreticalTestID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID            INT NOT NULL,
    SupervisorID      INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES DriverAndVehicleLicenceDepartment.Tests (TestID),
    FOREIGN KEY (SupervisorID) REFERENCES DriverAndVehicleLicenceDepartment.Supervisors (SupervisorID)
)

CREATE TABLE DriverAndVehicleLicenceDepartment.DrivingTests
(
    DrivingTestID     INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID            INT NOT NULL,
    DrivingExaminerID INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES DriverAndVehicleLicenceDepartment.Tests (TestID),
    FOREIGN KEY (DrivingExaminerID) REFERENCES DriverAndVehicleLicenceDepartment.DrivingExaminers (DrivingExaminerID)
)