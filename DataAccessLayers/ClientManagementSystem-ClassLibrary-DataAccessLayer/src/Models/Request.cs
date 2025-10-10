using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Request(
    int?      requestID,
    DateTime? requestDateTime,
    int?      clientID,
    int?      paymentID,
    int?      eyeTestID,
    int?      theoreticalTestID,
    int?      drivingTestID,
    int?      licenseID
) {
    public int?      requestID         { get; set; } = requestID;
    public DateTime? requestDateTime   { get; set; } = requestDateTime;
    public int?      clientID          { get; set; } = clientID;
    public int?      paymentID         { get; set; } = paymentID;
    public int?      eyeTestID         { get; set; } = eyeTestID;
    public int?      theoreticalTestID { get; set; } = theoreticalTestID;
    public int?      drivingTestID     { get; set; } = drivingTestID;
    public int?      licenseID         { get; set; } = licenseID;

    public Request(
        DateTime? requestDateTime,
        int?      clientID,
        int?      paymentID,
        int?      licenseID
    ) : this(
        null,
        requestDateTime,
        clientID,
        paymentID,
        null,
        null,
        null,
        licenseID
    ) {}
}