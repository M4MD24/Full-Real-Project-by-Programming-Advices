namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Fees(
    byte?    feesID,
    string?  feesName,
    decimal? amount,
    byte?    currencyID
) {
    public byte?    feesID     { get; set; } = feesID;
    public string?  feesName   { get; set; } = feesName;
    public decimal? amount     { get; set; } = amount;
    public byte?    currencyID { get; set; } = currencyID;

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