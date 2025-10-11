namespace ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

public class PaymentMethod(
    byte?   paymentMethodID,
    string? paymentMethodName
) {
    public byte?   paymentMethodID   { get; set; } = paymentMethodID;
    public string? paymentMethodName { get; set; } = paymentMethodName;
}