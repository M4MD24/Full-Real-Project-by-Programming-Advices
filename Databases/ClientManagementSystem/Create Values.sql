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