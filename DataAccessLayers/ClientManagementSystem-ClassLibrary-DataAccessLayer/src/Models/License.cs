using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class License(
    int?      licenseID,
    byte?     licenseTypeID,
    int?      clientID,
    byte?     licenseIssuanceID,
    byte?     licenseCoverageID,
    DateTime? issueDateTime,
    DateTime? expiryDateTime,
    bool?     isActive
) {
    public int?      licenseID         { get; set; } = licenseID;
    public byte?     licenseTypeID     { get; set; } = licenseTypeID;
    public int?      clientID          { get; set; } = clientID;
    public byte?     licenseIssuanceID { get; set; } = licenseIssuanceID;
    public byte?     licenseCoverageID { get; set; } = licenseCoverageID;
    public DateTime? issueDateTime     { get; set; } = issueDateTime;
    public DateTime? expiryDateTime    { get; set; } = expiryDateTime;
    public bool?     isActive          { get; set; } = isActive;

    public License(
        byte? licenseTypeID,
        int?  clientID,
        byte? licenseIssuanceID,
        byte? licenseCoverageID,
        bool? isActive
    ) : this(
        null,
        licenseTypeID,
        clientID,
        licenseIssuanceID,
        licenseCoverageID,
        null,
        null,
        isActive
    ) {}

    public License(
        byte?     licenseTypeID,
        int?      clientID,
        byte?     licenseIssuanceID,
        byte?     licenseCoverageID,
        DateTime? issueDateTime,
        DateTime? expiryDateTime,
        bool?     isActive
    ) : this(
        null,
        licenseTypeID,
        clientID,
        licenseIssuanceID,
        licenseCoverageID,
        issueDateTime,
        expiryDateTime,
        isActive
    ) {}
}