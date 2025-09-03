using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class LicenseType(
    byte?     licenseTypeID,
    string?   licenseTypeName,
    string?   licenseDescription,
    byte?     minimumAge,
    decimal?  licenseFees,
    byte?     licenseDuration,
    string?   licenseConditionsNotes,
    byte?     licenseIssuanceID,
    DateTime? issueDateTime,
    DateTime? expiryDateTime,
    bool?     isActive
) {
    public byte?     licenseTypeID          { get; set; } = licenseTypeID;
    public string?   licenseTypeName        { get; set; } = licenseTypeName;
    public string?   licenseDescription     { get; set; } = licenseDescription;
    public byte?     minimumAge             { get; set; } = minimumAge;
    public decimal?  licenseFees            { get; set; } = licenseFees;
    public byte?     licenseDuration        { get; set; } = licenseDuration;
    public string?   licenseConditionsNotes { get; set; } = licenseConditionsNotes;
    public byte?     licenseIssuanceID      { get; set; } = licenseIssuanceID;
    public DateTime? issueDateTime          { get; set; } = issueDateTime;
    public DateTime? expiryDateTime         { get; set; } = expiryDateTime;
    public bool?     isActive               { get; set; } = isActive;
}