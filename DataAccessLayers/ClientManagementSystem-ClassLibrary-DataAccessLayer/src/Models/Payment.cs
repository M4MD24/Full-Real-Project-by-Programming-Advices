using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Payment(
    int?      paymentID,
    decimal?  amount,
    byte?     currencyID,
    DateTime? paymentDateTime,
    String?   paymentMethod
) {
    public int?      paymentID       { get; set; } = paymentID;
    public decimal?  amount          { get; set; } = amount;
    public byte?     currencyID      { get; set; } = currencyID;
    public DateTime? paymentDateTime { get; set; } = paymentDateTime;
    public String?   paymentMethod   { get; set; } = paymentMethod;
}