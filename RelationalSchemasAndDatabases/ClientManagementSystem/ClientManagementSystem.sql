USE DriverAndVehicleLicenseDepartment;

CREATE SCHEMA ClientManagementSystem;

CREATE TABLE ClientManagementSystem.Countries
(
    CountryID   TINYINT      NOT NULL PRIMARY KEY,
    CountryName NVARCHAR(60) NOT NULL UNIQUE,
    CountryCode NVARCHAR(3)  NOT NULL UNIQUE
)

CREATE TABLE AccountManagementSystem.MobileNumbers
(
    MobileNumberID INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    ContactNumber  NVARCHAR(20) NOT NULL,
    CountryID      TINYINT      NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES AccountManagementSystem.Countries (CountryID)
)

CREATE TABLE ClientManagementSystem.ContactInformation
(
    ContactInformationID INT           NOT NULL PRIMARY KEY IDENTITY (1,1),
    MobileNumberID       INT           NOT NULL,
    Email                NVARCHAR(100) NOT NULL,
    FOREIGN KEY (MobileNumberID) REFERENCES ClientManagementSystem.MobileNumbers (MobileNumberID)
)

CREATE TABLE ClientManagementSystem.FullNames
(
    FullNameID INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    FirstName  NVARCHAR(20) NOT NULL,
    SecondName NVARCHAR(20) NOT NULL,
    ThirdName  NVARCHAR(20) NOT NULL,
    FourthName NVARCHAR(20) NOT NULL
)

CREATE TABLE ClientManagementSystem.Persons
(
    PersonID             INT            NOT NULL PRIMARY KEY IDENTITY (1,1),
    NationalNumber       NVARCHAR(30)   NOT NULL UNIQUE,
    FullNameID           INT            NOT NULL UNIQUE,
    DateOfBirth          DATE           NOT NULL,
    Address              NVARCHAR(200)  NOT NULL,
    ContactInformationID INT            NOT NULL,
    CountryID            TINYINT        NOT NULL,
    ImageURL             NVARCHAR(2083) NOT NULL UNIQUE,
    FOREIGN KEY (FullNameID) REFERENCES ClientManagementSystem.FullNames (FullNameID),
    FOREIGN KEY (ContactInformationID) REFERENCES ClientManagementSystem.ContactInformation (ContactInformationID),
    FOREIGN KEY (CountryID) REFERENCES ClientManagementSystem.Countries (CountryID)
)

CREATE TABLE ClientManagementSystem.Clients
(
    ClientID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES ClientManagementSystem.Persons (PersonID)
)

CREATE TABLE ClientManagementSystem.Employees
(
    EmployeeID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID   INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES ClientManagementSystem.Persons (PersonID)
)

CREATE TABLE ClientManagementSystem.EyeDoctors
(
    EyeDoctorID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID    INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES ClientManagementSystem.Persons (PersonID)
)

CREATE TABLE ClientManagementSystem.Supervisors
(
    SupervisorID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID     INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES ClientManagementSystem.Persons (PersonID)
)

CREATE TABLE ClientManagementSystem.DrivingExaminers
(
    DrivingExaminerID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID          INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES ClientManagementSystem.Persons (PersonID)
)

CREATE TABLE ClientManagementSystem.Currencies
(
    CurrencyID TINYINT NOT NULL PRIMARY KEY IDENTITY (1,1),
    Amount     MONEY   NOT NULL,
    CountryID  TINYINT NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES ClientManagementSystem.Countries (CountryID)
)

CREATE TABLE ClientManagementSystem.Tests
(
    TestID       INT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestDateTime DATETIME NOT NULL,
    CurrencyID   TINYINT  NOT NULL,
    IsSucceed    BIT      NOT NULL,
    FOREIGN KEY (CurrencyID) REFERENCES ClientManagementSystem.Currencies (CurrencyID)
)

CREATE TABLE ClientManagementSystem.EyeTests
(
    EyeTestID   INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID      INT NOT NULL UNIQUE,
    EyeDoctorID INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES ClientManagementSystem.Tests (TestID),
    FOREIGN KEY (EyeDoctorID) REFERENCES ClientManagementSystem.EyeDoctors (EyeDoctorID)
)

CREATE TABLE ClientManagementSystem.TheoreticalTests
(
    TheoreticalTestID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID            INT NOT NULL UNIQUE,
    SupervisorID      INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES ClientManagementSystem.Tests (TestID),
    FOREIGN KEY (SupervisorID) REFERENCES ClientManagementSystem.Supervisors (SupervisorID)
)

CREATE TABLE ClientManagementSystem.DrivingTests
(
    DrivingTestID     INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID            INT NOT NULL UNIQUE,
    DrivingExaminerID INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES ClientManagementSystem.Tests (TestID),
    FOREIGN KEY (DrivingExaminerID) REFERENCES ClientManagementSystem.DrivingExaminers (DrivingExaminerID)
)

CREATE TABLE ClientManagementSystem.RequestTypes
(
    RequestTypeID   TINYINT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    RequestTypeName NVARCHAR(50) NOT NULL
)

CREATE TABLE ClientManagementSystem.RequestCases
(
    RequestCaseID   TINYINT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    RequestCaseName NVARCHAR(20) NOT NULL
)

CREATE TABLE ClientManagementSystem.Payments
(
    PaymentID       INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    CurrencyID      TINYINT      NOT NULL,
    PaymentDateTime DATETIME     NOT NULL,
    PaymentMethod   NVARCHAR(50) NOT NULL,
    FOREIGN KEY (CurrencyID) REFERENCES ClientManagementSystem.Currencies (CurrencyID)
)

CREATE TABLE ClientManagementSystem.Requests
(
    RequestID         INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    RequestDateTime   DATETIME,
    ClientID          INT UNIQUE,
    RequestTypeID     TINYINT,
    RequestCaseID     TINYINT,
    PaymentID         INT,
    EyeTestID         INT,
    TheoreticalTestID INT,
    DrivingTestID     INT,
    FOREIGN KEY (ClientID) REFERENCES ClientManagementSystem.Clients (ClientID),
    FOREIGN KEY (RequestTypeID) REFERENCES ClientManagementSystem.RequestTypes (RequestTypeID),
    FOREIGN KEY (RequestCaseID) REFERENCES ClientManagementSystem.RequestCases (RequestCaseID),
    FOREIGN KEY (PaymentID) REFERENCES ClientManagementSystem.Payments (PaymentID),
    FOREIGN KEY (EyeTestID) REFERENCES ClientManagementSystem.EyeTests (EyeTestID),
    FOREIGN KEY (TheoreticalTestID) REFERENCES ClientManagementSystem.TheoreticalTests (TheoreticalTestID),
    FOREIGN KEY (DrivingTestID) REFERENCES ClientManagementSystem.DrivingTests (DrivingTestID)
)

CREATE TABLE ClientManagementSystem.LicenseIssuances
(
    LicenseIssuanceID   TINYINT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseIssuanceName NVARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE ClientManagementSystem.LicenseTypes
(
    LicenseTypeID          INT           NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseTypeName        NVARCHAR(75)  NOT NULL,
    LicenseDescription     NVARCHAR(200) NOT NULL,
    MinimumAge             TINYINT       NOT NULL,
    LicenseFees            MONEY         NOT NULL,
    LicenseDuration        TINYINT       NOT NULL,
    LicenseConditionsNotes NVARCHAR(300) NOT NULL,
    LicenseIssuanceID      TINYINT       NOT NULL,
    IssueDateTime          DATETIME      NOT NULL,
    ExpiryDateTime         DATETIME      NOT NULL,
    IsActive               BIT           NOT NULL,
    FOREIGN KEY (LicenseIssuanceID) REFERENCES ClientManagementSystem.LicenseIssuances (LicenseIssuanceID),
)

CREATE TABLE ClientManagementSystem.Licenses
(
    LicenseID     INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseTypeID INT NOT NULL,
    ClientID      INT NOT NULL,
    FOREIGN KEY (LicenseTypeID) REFERENCES ClientManagementSystem.LicenseTypes (LicenseTypeID),
    FOREIGN KEY (ClientID) REFERENCES ClientManagementSystem.Clients (ClientID)
)

CREATE TABLE ClientManagementSystem.Retests
(
    RetestID      INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LastRequestID INT NOT NULL UNIQUE,
    NewRequestID  INT NOT NULL UNIQUE,
    FOREIGN KEY (LastRequestID) REFERENCES ClientManagementSystem.Requests (RequestID),
    FOREIGN KEY (NewRequestID) REFERENCES ClientManagementSystem.Requests (RequestID)
)

CREATE TABLE ClientManagementSystem.OfficialDrivers
(
    OfficialDriverID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    RequestID        INT NOT NULL UNIQUE,
    FOREIGN KEY (RequestID) REFERENCES ClientManagementSystem.Requests (RequestID)
)

CREATE TABLE ClientManagementSystem.LockedLicenses
(
    LockedLicenseID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID       INT NOT NULL UNIQUE,
    FOREIGN KEY (LicenseID) REFERENCES ClientManagementSystem.Licenses (LicenseID)
)

CREATE TABLE ClientManagementSystem.UnlockLicenses
(
    UnlockLicenseID INT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID       INT      NOT NULL UNIQUE,
    DateTimeUnlock  DATETIME NOT NULL,
    PaymentID       INT      NOT NULL,
    FOREIGN KEY (LicenseID) REFERENCES ClientManagementSystem.Licenses (LicenseID),
    FOREIGN KEY (PaymentID) REFERENCES ClientManagementSystem.Payments (PaymentID)
)

CREATE TABLE ClientManagementSystem.LostLicenseReplacements
(
    LostLicenseReplacementID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID                INT NOT NULL UNIQUE,
    FOREIGN KEY (LicenseID) REFERENCES ClientManagementSystem.Licenses (LicenseID)
)

CREATE TABLE ClientManagementSystem.DamagedLicenseReplacements
(
    DamagedLicenseReplacementID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID                   INT NOT NULL UNIQUE,
    FOREIGN KEY (LicenseID) REFERENCES ClientManagementSystem.Licenses (LicenseID)
)

CREATE TABLE ClientManagementSystem.Fees
(
    RequestFeesID                   TINYINT NOT NULL,
    EyeTestFeesID                   TINYINT NOT NULL,
    TheoreticalTestFeesID           TINYINT NOT NULL,
    RetestFeesID                    TINYINT NOT NULL,
    LicenseRenewalFeesID            TINYINT NOT NULL,
    LostLicenseReplacementFeesID    TINYINT NOT NULL,
    DamagedLicenseReplacementFeesID TINYINT NOT NULL,
    InternationalLicenseFeesID      TINYINT NOT NULL,
    FOREIGN KEY (RequestFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
    FOREIGN KEY (EyeTestFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
    FOREIGN KEY (TheoreticalTestFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
    FOREIGN KEY (RetestFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
    FOREIGN KEY (LicenseRenewalFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
    FOREIGN KEY (LostLicenseReplacementFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
    FOREIGN KEY (DamagedLicenseReplacementFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
    FOREIGN KEY (InternationalLicenseFeesID) REFERENCES ClientManagementSystem.Currencies (CurrencyID),
)