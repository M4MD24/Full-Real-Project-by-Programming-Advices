using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AccountInformation : Form {
    public AccountInformation(
        ref int accountID
    ) {
        InitializeComponent();

        Account account = AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.get(
            ref accountID
        )!;
    }
}