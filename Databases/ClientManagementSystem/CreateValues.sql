USE DriverAndVehicleLicenseDepartment;

-- INSERT INTO ClientManagementSystem.Countries (CountryName, CountryCode)
-- VALUES (N'Egypt', 'EGY');
--
-- INSERT INTO ClientManagementSystem.Currencies (CurrencyName, CountryID)
-- VALUES (N'جنيه', 1);

INSERT INTO ClientManagementSystem.Fees (FeesName, Amount, CurrencyID)
VALUES (N'Request', 20, 1),
       (N'Eye Test', 40, 1),
       (N'Theoretical Test', 60, 1),
       (N'Retest', 70, 1),
       (N'License Renewal', 20, 1),
       (N'Lost License Replacement', 10, 1),
       (N'Damaged License Replacement', 50, 1),
       (N'International License', 100, 1);

INSERT INTO ClientManagementSystem.LicenseIssuances (LicenseIssuanceName)
VALUES ('First Time'),
       ('Renew'),
       ('Replace Lost'),
       ('Replace Damaged'),
       ('Unlock');

INSERT INTO ClientManagementSystem.LicenseTypeNames (LicenseTypeName)
VALUES ('Local'),
       ('International');

INSERT INTO ClientManagementSystem.LicenseTypes (LicenseDescription, MinimumAge, LicenseFees, CurrencyID, LicenseDuration, LicenseConditionsNotes)
VALUES ('Small Motorcycle', 10, 15, 1, 5, 'Allows the driver to drive small motorcycles.'),
       ('Heavy Motorcycle', 12, 30, 1, 5, 'Allows the driver to drive large and powerful motorcycles.'),
       ('Regular', 10, 20, 1, 10, 'Allows the driver to drive light vehicles and personal cars.'),
       ('Commercial', 12, 200, 1, 10, 'Allows the driver to drive taxis or limousines.'),
       ('Agricultural', 12, 50, 1, 10, 'Allows the driver to drive all agricultural vehicles.'),
       ('Small and Medium', 12, 250, 1, 10, 'Allows the driver to drive small and medium buses.'),
       ('Truck and Heavy Vehicle', 12, 300, 1, 10, 'Allows the driver to drive trucks and heavy vehicles such as buses and large trucks.');