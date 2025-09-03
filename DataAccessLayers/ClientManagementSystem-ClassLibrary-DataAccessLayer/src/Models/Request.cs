using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Request(
    int?      requestID,
    DateTime? requestDateTime,
    int?      clientID,
    byte?     requestTypeID,
    byte?     requestCaseID,
    int?      paymentID,
    int?      eyeTestID,
    int?      theoreticalTestID,
    int?      drivingTestID
) {
    public int?      requestID         { get; set; } = requestID;
    public DateTime? requestDateTime   { get; set; } = requestDateTime;
    public int?      clientID          { get; set; } = clientID;
    public byte?     requestTypeID     { get; set; } = requestTypeID;
    public byte?     requestCaseID     { get; set; } = requestCaseID;
    public int?      paymentID         { get; set; } = paymentID;
    public int?      eyeTestID         { get; set; } = eyeTestID;
    public int?      theoreticalTestID { get; set; } = theoreticalTestID;
    public int?      drivingTestID     { get; set; } = drivingTestID;
}