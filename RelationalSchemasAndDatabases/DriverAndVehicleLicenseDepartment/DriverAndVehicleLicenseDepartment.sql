USE DriverAndVehicleLicenseDepartment;

CREATE SCHEMA DriverAndVehicleLicenseDepartment;

CREATE TABLE DriverAndVehicleLicenseDepartment.Countries
(
    CountryID   TINYINT      NOT NULL PRIMARY KEY,
    CountryName NVARCHAR(75) NOT NULL UNIQUE,
    CountryCode NVARCHAR(3)  NOT NULL UNIQUE
)

CREATE TABLE DriverAndVehicleLicenseDepartment.ContactInformation
(
    ContactInformationID INT           NOT NULL PRIMARY KEY IDENTITY (1,1),
    PhoneNumber          NVARCHAR(20)  NOT NULL,
    Email                NVARCHAR(100) NOT NULL
)

CREATE TABLE DriverAndVehicleLicenseDepartment.FullNames
(
    FullNameID INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    FirstName  NVARCHAR(20) NOT NULL,
    SecondName NVARCHAR(20) NOT NULL,
    ThirdName  NVARCHAR(20) NOT NULL,
    FourthName NVARCHAR(20) NOT NULL
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Persons
(
    PersonID             INT            NOT NULL PRIMARY KEY IDENTITY (1,1),
    NationalNumber       NVARCHAR(30)   NOT NULL UNIQUE,
    FullNameID           INT            NOT NULL UNIQUE,
    DateOfBirth          DATETIME       NOT NULL,
    Address              NVARCHAR(200)  NOT NULL,
    ContactInformationID INT            NOT NULL,
    CountryID            TINYINT        NOT NULL UNIQUE,
    ImageURL             NVARCHAR(2083) NOT NULL UNIQUE,
    FOREIGN KEY (FullNameID) REFERENCES DriverAndVehicleLicenseDepartment.FullNames (FullNameID),
    FOREIGN KEY (ContactInformationID) REFERENCES DriverAndVehicleLicenseDepartment.ContactInformation (ContactInformationID),
    FOREIGN KEY (CountryID) REFERENCES DriverAndVehicleLicenseDepartment.Countries (CountryID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Clients
(
    ClientID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenseDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Employees
(
    EmployeeID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID   INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenseDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.EyeDoctors
(
    EyeDoctorID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID    INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenseDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Supervisors
(
    SupervisorID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID     INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenseDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.DrivingExaminers
(
    DrivingExaminerID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    PersonID          INT NOT NULL UNIQUE,
    FOREIGN KEY (PersonID) REFERENCES DriverAndVehicleLicenseDepartment.Persons (PersonID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Currencies
(
    CurrencyID TINYINT NOT NULL PRIMARY KEY IDENTITY (1,1),
    Amount     MONEY   NOT NULL,
    CountryID  TINYINT NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES DriverAndVehicleLicenseDepartment.Countries (CountryID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Tests
(
    TestID       INT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestDateTime DATETIME NOT NULL,
    CurrencyID   TINYINT  NOT NULL,
    IsSucceed    BIT      NOT NULL,
    FOREIGN KEY (CurrencyID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.EyeTests
(
    EyeTestID   INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID      INT NOT NULL UNIQUE,
    EyeDoctorID INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES DriverAndVehicleLicenseDepartment.Tests (TestID),
    FOREIGN KEY (EyeDoctorID) REFERENCES DriverAndVehicleLicenseDepartment.EyeDoctors (EyeDoctorID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.TheoreticalTests
(
    TheoreticalTestID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID            INT NOT NULL UNIQUE,
    SupervisorID      INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES DriverAndVehicleLicenseDepartment.Tests (TestID),
    FOREIGN KEY (SupervisorID) REFERENCES DriverAndVehicleLicenseDepartment.Supervisors (SupervisorID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.DrivingTests
(
    DrivingTestID     INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    TestID            INT NOT NULL UNIQUE,
    DrivingExaminerID INT NOT NULL,
    FOREIGN KEY (TestID) REFERENCES DriverAndVehicleLicenseDepartment.Tests (TestID),
    FOREIGN KEY (DrivingExaminerID) REFERENCES DriverAndVehicleLicenseDepartment.DrivingExaminers (DrivingExaminerID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.RequestTypes
(
    RequestTypeID   TINYINT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    RequestTypeName NVARCHAR(50) NOT NULL
)

CREATE TABLE DriverAndVehicleLicenseDepartment.RequestCases
(
    RequestCaseID   TINYINT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    RequestCaseName NVARCHAR(20) NOT NULL
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Payments
(
    PaymentID       INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    CurrencyID      TINYINT      NOT NULL,
    PaymentDateTime DATETIME     NOT NULL,
    PaymentMethod   NVARCHAR(50) NOT NULL,
    FOREIGN KEY (CurrencyID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Requests
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
    FOREIGN KEY (ClientID) REFERENCES DriverAndVehicleLicenseDepartment.Clients (ClientID),
    FOREIGN KEY (RequestTypeID) REFERENCES DriverAndVehicleLicenseDepartment.RequestTypes (RequestTypeID),
    FOREIGN KEY (RequestCaseID) REFERENCES DriverAndVehicleLicenseDepartment.RequestCases (RequestCaseID),
    FOREIGN KEY (PaymentID) REFERENCES DriverAndVehicleLicenseDepartment.Payments (PaymentID),
    FOREIGN KEY (EyeTestID) REFERENCES DriverAndVehicleLicenseDepartment.EyeTests (EyeTestID),
    FOREIGN KEY (TheoreticalTestID) REFERENCES DriverAndVehicleLicenseDepartment.TheoreticalTests (TheoreticalTestID),
    FOREIGN KEY (DrivingTestID) REFERENCES DriverAndVehicleLicenseDepartment.DrivingTests (DrivingTestID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.LicenseIssuances
(
    LicenseIssuanceID   TINYINT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseIssuanceName NVARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE DriverAndVehicleLicenseDepartment.LicenseTypes
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
    FOREIGN KEY (LicenseIssuanceID) REFERENCES DriverAndVehicleLicenseDepartment.LicenseIssuances (LicenseIssuanceID),
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Licenses
(
    LicenseID     INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseTypeID INT NOT NULL,
    ClientID      INT NOT NULL,
    FOREIGN KEY (LicenseTypeID) REFERENCES DriverAndVehicleLicenseDepartment.LicenseTypes (LicenseTypeID),
    FOREIGN KEY (ClientID) REFERENCES DriverAndVehicleLicenseDepartment.Clients (ClientID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Retests
(
    RetestID      INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LastRequestID INT NOT NULL UNIQUE,
    NewRequestID  INT NOT NULL UNIQUE,
    FOREIGN KEY (LastRequestID) REFERENCES DriverAndVehicleLicenseDepartment.Requests (RequestID),
    FOREIGN KEY (NewRequestID) REFERENCES DriverAndVehicleLicenseDepartment.Requests (RequestID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.OfficialDrivers
(
    OfficialDriverID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    RequestID        INT NOT NULL UNIQUE,
    FOREIGN KEY (RequestID) REFERENCES DriverAndVehicleLicenseDepartment.Requests (RequestID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.LockedLicenses
(
    LockedLicenseID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID       INT NOT NULL UNIQUE,
    FOREIGN KEY (LicenseID) REFERENCES DriverAndVehicleLicenseDepartment.Licenses (LicenseID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.UnlockLicenses
(
    UnlockLicenseID INT      NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID       INT      NOT NULL UNIQUE,
    DateTimeUnlock  DATETIME NOT NULL,
    PaymentID       INT      NOT NULL,
    FOREIGN KEY (LicenseID) REFERENCES DriverAndVehicleLicenseDepartment.Licenses (LicenseID),
    FOREIGN KEY (PaymentID) REFERENCES DriverAndVehicleLicenseDepartment.Payments (PaymentID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.LostLicenseReplacements
(
    LostLicenseReplacementID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID                INT NOT NULL UNIQUE,
    FOREIGN KEY (LicenseID) REFERENCES DriverAndVehicleLicenseDepartment.Licenses (LicenseID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.DamagedLicenseReplacements
(
    DamagedLicenseReplacementID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    LicenseID                   INT NOT NULL UNIQUE,
    FOREIGN KEY (LicenseID) REFERENCES DriverAndVehicleLicenseDepartment.Licenses (LicenseID)
)

CREATE TABLE DriverAndVehicleLicenseDepartment.Fees
(
    RequestFeesID                   TINYINT NOT NULL,
    EyeTestFeesID                   TINYINT NOT NULL,
    TheoreticalTestFeesID           TINYINT NOT NULL,
    RetestFeesID                    TINYINT NOT NULL,
    LicenseRenewalFeesID            TINYINT NOT NULL,
    LostLicenseReplacementFeesID    TINYINT NOT NULL,
    DamagedLicenseReplacementFeesID TINYINT NOT NULL,
    InternationalLicenseFeesID      TINYINT NOT NULL,
    FOREIGN KEY (RequestFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
    FOREIGN KEY (EyeTestFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
    FOREIGN KEY (TheoreticalTestFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
    FOREIGN KEY (RetestFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
    FOREIGN KEY (LicenseRenewalFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
    FOREIGN KEY (LostLicenseReplacementFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
    FOREIGN KEY (DamagedLicenseReplacementFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
    FOREIGN KEY (InternationalLicenseFeesID) REFERENCES DriverAndVehicleLicenseDepartment.Currencies (CurrencyID),
)