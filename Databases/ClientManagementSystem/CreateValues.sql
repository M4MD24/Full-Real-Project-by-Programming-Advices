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

INSERT INTO ClientManagementSystem.Coverages (CoverageName)
VALUES ('Local'),
       ('International');

INSERT INTO ClientManagementSystem.LicenseTypes (LicenseName, LicenseDescription, MinimumAge, LicenseDuration)
VALUES ('Small Motorcycle', 'Allows the driver to drive small motorcycles.', 10, 5),
       ('Heavy Motorcycle', 'Allows the driver to drive large and powerful motorcycles.', 12, 5),
       ('Regular', 'Allows the driver to drive light vehicles and personal cars.', 10, 10),
       ('Commercial', 'Allows the driver to drive taxis or limousines.', 12, 10),
       ('Agricultural', 'Allows the driver to drive all agricultural vehicles.', 12, 10),
       ('Small and Medium', 'Allows the driver to drive small and medium buses.', 12, 10),
       ('Truck and Heavy Vehicle', 'Allows the driver to drive trucks and heavy vehicles such as buses and large trucks.', 12, 10);