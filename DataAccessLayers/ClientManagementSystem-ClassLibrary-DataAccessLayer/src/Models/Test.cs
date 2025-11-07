using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Test(
    int?      testID,
    int?      licenseID,
    byte?     currencyID,
    DateOnly? testDate,
    bool?     isSucceed
) {
    public int?      testID     { get; set; } = testID;
    public int?      licenseID  { get; set; } = licenseID;
    public byte?     currencyID { get; set; } = currencyID;
    public DateOnly? testDate   { get; set; } = testDate;
    public bool?     isSucceed  { get; set; } = isSucceed;

    public Test(
        int?      licenseID,
        byte?     currencyID,
        DateOnly? testDateTime
    ) : this(
        null,
        licenseID,
        currencyID,
        testDateTime,
        null
    ) {}
}