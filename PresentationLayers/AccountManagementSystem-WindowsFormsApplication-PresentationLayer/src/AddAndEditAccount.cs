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
    ) {
        Text = $@"Update {account.accountID}";
    }

    private void initializeAdditionForm() {
        Text = @"Create New Account";
    }

    private void DisableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );

    private void Submit_Click(
        object    sender,
        EventArgs e
    ) {}
    ) {
        FullName fullName = new FullName(
            FirstNameAnswer.Text,
            SecondNameAnswer.Text,
            ThirdNameAnswer.Text,
            FourthNameAnswer.Text
        );
        int fullNameID = AccountManagementSystem_ClassLibrary_BusinessLayer.FullNames.add(
            ref fullName
        );

        string countryName = CountryNameMobileNumberAnswer.Text;
        byte? countryID = AccountManagementSystem_ClassLibrary_BusinessLayer.Countries.get(
                                                                                ref countryName
                                                                            )!
                                                                            .countryID;
        MobileNumber mobileNumber = new MobileNumber(
            ContactNumberAnswer.Text,
            countryID
        );
        int mobileNumberID = AccountManagementSystem_ClassLibrary_BusinessLayer.MobileNumbers.add(
            ref mobileNumber
        );

        ContactInformation contactInformation = new ContactInformation(
            mobileNumberID,
            EmailAnswer.Text
        );
        int contactInformationID = AccountManagementSystem_ClassLibrary_BusinessLayer.ContactInformation.add(
            ref contactInformation
        );

        countryName = CountryNameAnswer.Text;
        countryID = AccountManagementSystem_ClassLibrary_BusinessLayer.Countries.get(
                                                                          ref countryName
                                                                      )!
                                                                      .countryID;

        Person person = new Person(
            NationalNumberAnswer.Text,
            fullNameID,
            DateOfBirthAnswer.Value,
            AddressAnswer.Text,
            contactInformationID,
            countryID,
            ""
        );
        int personID = AccountManagementSystem_ClassLibrary_BusinessLayer.Persons.add(
            ref person
        );

        string accountTypeName = AccountTypeAnswer.Text;
        byte? accountTypeID = AccountManagementSystem_ClassLibrary_BusinessLayer.AccountTypes.get(
            ref accountTypeName
        )!.accountTypeID;

        Account account = new Account(
            personID,
            UsernameAnswer.Text,
            PasswordAnswer.Text,
            true,
            accountTypeID
        );
        AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.add(
            ref account
        );
    }
}