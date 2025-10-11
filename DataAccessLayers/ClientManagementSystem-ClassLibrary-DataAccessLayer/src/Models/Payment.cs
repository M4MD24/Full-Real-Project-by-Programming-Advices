using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Payment(
    int?      paymentID,
    decimal?  amount,
    byte?     currencyID,
    DateTime? paymentDateTime,
    byte?     paymentMethodID
) {
    public int?      paymentID       { get; set; } = paymentID;
    public decimal?  amount          { get; set; } = amount;
    public byte?     currencyID      { get; set; } = currencyID;
    public DateTime? paymentDateTime { get; set; } = paymentDateTime;
    public byte?     paymentMethodID { get; set; } = paymentMethodID;

    public Payment(
        decimal?  amount,
        byte?     currencyID,
        DateTime? paymentDateTime,
        byte?     paymentMethodID
    ) : this(
        null,
        amount,
        currencyID,
        paymentDateTime,
        paymentMethodID
    ) {}
}