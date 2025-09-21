USE DriverAndVehicleLicenseDepartment;

-- INSERT INTO ClientManagementSystem.Countries (CountryName, CountryCode)
-- VALUES (N'Egypt', 'EGY');
--
-- INSERT INTO ClientManagementSystem.Currencies (CurrencyName, CountryID)
-- VALUES (N'جنيه', 1);

INSERT INTO ClientManagementSystem.Fees (FeesName, Amount, CurrencyID)
VALUES (N'Request', 20, 1),
       (N'First Time', 10, 1),
       (N'Retest', 70, 1),
       (N'License Renewal', 20, 1),
       (N'Lost License Replacement', 10, 1),
       (N'Damaged License Replacement', 50, 1),
       (N'Local License', 20, 1),
       (N'International License', 100, 1),
       (N'Small Motorcycle', 15, 1),
       (N'Heavy Motorcycle', 30, 1),
       (N'Regular', 20, 1),
       (N'Commercial', 200, 1),
       (N'Agricultural', 50, 1),
       (N'Small and Medium', 250, 1),
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

INSERT INTO ClientManagementSystem.LicenseTypeNames (LicenseTypeName)
VALUES ('Local'),
       ('International');

INSERT INTO ClientManagementSystem.LicenseTypes (LicenseDescription, MinimumAge, LicenseDuration, LicenseConditionsNotes)
VALUES ('Small Motorcycle', 10, 5, 'Allows the driver to drive small motorcycles.'),
       ('Heavy Motorcycle', 12, 5, 'Allows the driver to drive large and powerful motorcycles.'),
       ('Regular', 10, 10, 'Allows the driver to drive light vehicles and personal cars.'),
       ('Commercial', 12, 10, 'Allows the driver to drive taxis or limousines.'),
       ('Agricultural', 12, 10, 'Allows the driver to drive all agricultural vehicles.'),
       ('Small and Medium', 12, 10, 'Allows the driver to drive small and medium buses.'),
       ('Truck and Heavy Vehicle', 12, 10, 'Allows the driver to drive trucks and heavy vehicles such as buses and large trucks.');