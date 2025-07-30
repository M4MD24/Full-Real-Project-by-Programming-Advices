namespace DriverAndVehicleLicenseDepartment.Models;

public class Currency(
    byte?    currencyID,
    decimal? amount,
    byte?    countryID
) {
    public byte?    currencyID { get; set; } = currencyID;
    public decimal? amount     { get; set; } = amount;
    public byte?    countryID  { get; set; } = countryID;

    public Currency(
        decimal? amount,
        byte?    countryID
    ) : this(
        null,
        amount,
        countryID
    ) {}
}