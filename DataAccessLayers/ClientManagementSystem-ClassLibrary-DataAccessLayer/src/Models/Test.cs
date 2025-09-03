using System;

namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class Test(
    int?      testID,
    DateTime? testDateTime,
    byte?     currencyID,
    bool?     isSucceed
) {
    public int?      testID       { get; set; } = testID;
    public DateTime? testDateTime { get; set; } = testDateTime;
    public byte?     currencyID   { get; set; } = currencyID;
    public bool?     isSucceed    { get; set; } = isSucceed;
}