namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Fees(
    byte?    feesID,
    string?  feesName,
    decimal? amount,
    byte?    currencyID
) {
    public byte?    feesID     { get; } = feesID;
    public string?  feesName   { get; } = feesName;
    public decimal? amount     { get; } = amount;
    public byte?    currencyID { get; } = currencyID;

    public Fees(
        string?  feesName,
        decimal? amount,
        byte?    currencyID
    ) : this(
        null,
        feesName,
        amount,
        currencyID
    ) {}
}