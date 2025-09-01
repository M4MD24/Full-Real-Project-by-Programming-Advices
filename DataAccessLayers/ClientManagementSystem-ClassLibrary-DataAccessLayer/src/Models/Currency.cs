namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Currency(
    byte?   currencyID,
    string? currencyName,
    byte?   countryID
) {
    public byte?   currencyID   { get; } = currencyID;
    public string? currencyName { get; } = currencyName;
    public byte?   countryID    { get; } = countryID;

    public Currency(
        string? CurrencyName,
        byte?   countryID
    ) : this(
        null,
        CurrencyName,
        countryID
    ) {}
}