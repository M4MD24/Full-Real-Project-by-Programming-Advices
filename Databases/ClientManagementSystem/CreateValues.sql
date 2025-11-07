USE DriverAndVehicleLicenseDepartment;

INSERT INTO ClientManagementSystem.Countries (CountryName, CountryCode)
VALUES (N'Egypt', 'EGY');

INSERT INTO ClientManagementSystem.Currencies (CurrencyName, CountryID)
VALUES (N'جنيه', 1);

INSERT INTO ClientManagementSystem.Fees (FeesName, Amount, CurrencyID)
VALUES (N'Request', 20, 1),
       (N'First Time', 10, 1),
       (N'Renew', 20, 1),
       (N'Lost License Replacement', 10, 1),
       (N'Damaged License Replacement', 50, 1),
       (N'Local', 20, 1),
       (N'International', 100, 1),
       (N'Small Motorcycle', 15, 1),
       (N'Heavy Motorcycle', 30, 1),
       (N'Regular', 20, 1),
       (N'Commercial', 200, 1),
       (N'Agricultural', 50, 1),
       (N'Small and Medium Bus', 250, 1),
       (N'Truck and Heavy Vehicle', 300, 1),
       (N'Eye Test', 40, 1),
       (N'Theoretical Test', 60, 1),
       (N'Driving Test', 80, 1);

INSERT INTO ClientManagementSystem.LicenseIssuances (LicenseIssuanceName)
VALUES ('First Time'),
       ('Renew'),
       ('Replace Lost'),
       ('Replace Damaged'),
       ('Unlock');

INSERT INTO ClientManagementSystem.Coverages (CoverageName)
VALUES ('Local'),
       ('International');

INSERT INTO ClientManagementSystem.LicenseTypes (Name, Description, MinimumAge, Duration)
VALUES ('Small Motorcycle', 'Allows the driver to drive small motorcycles.', 10, 5),
       ('Heavy Motorcycle', 'Allows the driver to drive large and powerful motorcycles.', 12, 5),
       ('Regular', 'Allows the driver to drive light vehicles and personal cars.', 10, 10),
       ('Commercial', 'Allows the driver to drive taxis or limousines.', 12, 10),
       ('Agricultural', 'Allows the driver to drive all agricultural vehicles.', 12, 10),
       ('Small and Medium Bus', 'Allows the driver to drive small and medium buses.', 12, 10),
       ('Truck and Heavy Vehicle', 'Allows the driver to drive trucks and heavy vehicles such as buses and large trucks.', 12, 10);

INSERT INTO ClientManagementSystem.PaymentMethods (PaymentMethodName)
VALUES ('Cash'),
       ('Online');

INSERT INTO ClientManagementSystem.FullNames (FirstName, SecondName, ThirdName, FourthName)
VALUES (2, 3, 4, 5),
       (22, 33, 44, 55),
       (222, 333, 444, 555)

INSERT INTO ClientManagementSystem.MobileNumbers (ContactNumber, CountryID)
VALUES (7, 1),
       (77, 1),
       (777, 1)

INSERT INTO ClientManagementSystem.ContactInformation (MobileNumberID, Email)
VALUES (1, 88),
       (2, 88),
       (3, 88)

INSERT INTO ClientManagementSystem.Persons (NationalNumber, FullNameID, DateOfBirth, Address, ContactInformationID, CountryID, ImageURL)
VALUES (1, 1, '2003-06-09', 6, 1, 1, 'D:\Projects\Learn\ProgrammingAdvices\Full-Real-Project-by-Programming-Advices\PresentationLayers\ClientManagementSystem-WindowsFormsApplication-PresentationLayer\bin\Debug\net9.0-windows\Data\Images\1.png'),
       (11, 2, '2003-06-09', 66, 2, 1, 'D:\Projects\Learn\ProgrammingAdvices\Full-Real-Project-by-Programming-Advices\PresentationLayers\ClientManagementSystem-WindowsFormsApplication-PresentationLayer\bin\Debug\net9.0-windows\Data\Images\11.png'),
       (111, 3, '2003-06-09', 666, 3, 1, 'D:\Projects\Learn\ProgrammingAdvices\Full-Real-Project-by-Programming-Advices\PresentationLayers\ClientManagementSystem-WindowsFormsApplication-PresentationLayer\bin\Debug\net9.0-windows\Data\Images\111.png')

INSERT INTO ClientManagementSystem.EyeDoctors (PersonID)
VALUES (1)

INSERT INTO ClientManagementSystem.Supervisors (PersonID)
VALUES (2)

INSERT INTO ClientManagementSystem.DrivingExaminers (PersonID)
VALUES (3)