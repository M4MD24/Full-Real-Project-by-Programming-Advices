namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Currency(
    byte?   currencyID,
    string? currencyName,
    byte?   countryID
) {
    public byte?   currencyID   { get; set; } = currencyID;
    public string? currencyName { get; set; } = currencyName;
    public byte?   countryID    { get; set; } = countryID;

    public Currency(
        string? CurrencyName,
        byte?   countryID
    ) : this(
        null,
        CurrencyName,
        countryID
    ) {}
}