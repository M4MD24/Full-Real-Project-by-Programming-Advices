using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Test(
    int?      testID,
    int?      licenseID,
    byte?     currencyID,
    DateTime? testDateTime,
    bool?     isSucceed
) {
    public int?      testID       { get; set; } = testID;
    public int?      licenseID    { get; set; } = licenseID;
    public byte?     currencyID   { get; set; } = currencyID;
    public DateTime? testDateTime { get; set; } = testDateTime;
    public bool?     isSucceed    { get; set; } = isSucceed;

    public Test(
        int?      licenseID,
        byte?     currencyID,
        DateTime? testDateTime
    ) : this(
        null,
        licenseID,
        currencyID,
        testDateTime,
        null
    ) {}
}