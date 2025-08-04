using System;
using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using Constants = AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AddAndEditAccount : Form {
    public AddAndEditAccount(
        Constants.Mode mode,
        int            accountID = -1
    ) {
        InitializeComponent();

        Account? account = null;
        if (accountID != -1)
            account = AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.get(
                ref accountID
            )!;

        switch (mode) {
            case Constants.Mode.Add:
                initializeAdditionForm();
            break;
            case Constants.Mode.Update:
                initializeModificationForm(
                    ref account!
                );
            break;
        }
    }

    private void initializeModificationForm(
        ref Account account
    ) {}

    private void initializeAdditionForm() {}

    private void initializeInformationForm(
        ref Account account
    ) {}

    private void NationalNumberAnswer_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );
}