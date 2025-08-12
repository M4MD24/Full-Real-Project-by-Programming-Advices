using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using Constants = AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants;
using ContactInformation = AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AddAndEditAccount : Form,
                                         Loader {
    private string selectedImagePath;

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
        setIcon(
            Constants.Mode.Update
        );
    }

    private void setIcon(
        Constants.Mode mode
    ) {
        Assembly assembly = Assembly.GetExecutingAssembly();
        using Stream? iconStream = assembly.GetManifestResourceStream(
            Utilities.Constants.RESOURCES_ICONS_PATH + '.' + (
                                                                 mode == Constants.Mode.Update
                                                                         ? "PersonAdd"
                                                                         : "PersonEdit"
                                                             ) + ".ico"
        );

        Icon = new Icon(
            iconStream!
        );
    }

    private void initializeAdditionForm() {
        Text = @"Create New Account";
        setIcon(
            Constants.Mode.Add
        );
        loadDataSources();
    }

    private void DisableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );

    private string copyImageToImageDirectory(
        int? personID
    ) {
        string extension = Path.GetExtension(
            selectedImagePath
        );
        string fileName = $"{personID}{extension}";

        string destinationFolder = Path.Combine(
            Utilities.Constants.baseDirectory,
            @"Data\Images"
        );
        if (
            !Directory.Exists(
                destinationFolder
            )
        )
            Directory.CreateDirectory(
                destinationFolder
            );

        string destinationFile = Path.Combine(
            destinationFolder,
            fileName
        );

        try {
            File.Copy(
                selectedImagePath,
                destinationFile,
                overwrite : true
            );
        } catch (Exception exception) {
            MessageBox.Show(
                exception.Message,
                @"Can't Copy to Image Directory",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error
            );
            return null!;
        }

        return destinationFile;
    }

    private void Submit_Click(
        object    sender,
        EventArgs e
    ) {
        if (!isValidData())
            return;
        MessageBox.Show(
            @"Nice"
        );
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
            selectedImagePath
        );

        person.personID = AccountManagementSystem_ClassLibrary_BusinessLayer.Persons.add(
            ref person
        );

        person.imageURL = copyImageToImageDirectory(
            person.personID
        );

        AccountManagementSystem_ClassLibrary_BusinessLayer.Persons.update(
            ref person
        );

        string accountTypeName = AccountTypeAnswer.Text;
        byte? accountTypeID = AccountManagementSystem_ClassLibrary_BusinessLayer.AccountTypes.get(
            ref accountTypeName
        )!.accountTypeID;

        Account account = new Account(
            person.personID,
            UsernameAnswer.Text,
            PasswordAnswer.Text,
            true,
            accountTypeID
        );
        AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.add(
            ref account
        );
    }

    private bool isValidData() {
        bool isValid = true;

        isValid &= checkField(
            NationalNumberAnswer
        );
        isValid &= checkField(
            FirstNameAnswer
        );
        isValid &= checkField(
            SecondNameAnswer
        );
        isValid &= checkField(
            ThirdNameAnswer
        );
        isValid &= checkField(
            FourthNameAnswer
        );
        isValid &= checkField(
            DateOfBirthAnswer
        );
        isValid &= checkField(
            AddressAnswer
        );
        isValid &= checkField(
            ContactNumberAnswer
        );
        isValid &= checkField(
            CountryNameMobileNumberAnswer
        );
        isValid &= checkField(
            EmailAnswer
        );
        isValid &= checkField(
            CountryNameAnswer
        );
        isValid &= checkField(
            UsernameAnswer
        );
        isValid &= checkField(
            PasswordAnswer
        );
        isValid &= checkField(
            AccountTypeAnswer
        );
        isValid &= checkField(
            selectedImagePath
        );

        return isValid;
    }

    private bool checkField(
        string selectedFile,
        bool   isValid = true
    ) {
        if (
            !File.Exists(
                selectedFile
            )
        ) {
            ErrorProvider.SetError(
                ImageQuestion,
                Utilities.Constants.ErrorMessages.EMPTY
            );
            isValid = false;
        } else
            ErrorProvider.SetError(
                ImageQuestion,
                string.Empty
            );

        return isValid;
    }

    private bool checkField(
        ComboBox comboBox,
        bool     isValid = true
    ) {
        if (
            string.IsNullOrWhiteSpace(
                comboBox.Text
            )
        ) {
            ErrorProvider.SetError(
                comboBox,
                Utilities.Constants.ErrorMessages.EMPTY
            );
            isValid = false;
        } else
            ErrorProvider.SetError(
                comboBox,
                string.Empty
            );

        return isValid;
    }

    private bool checkField(
        DateTimePicker dateTimePicker,
        bool           isValid = true
    ) {
        DateTime selectedDate = dateTimePicker.Value;
        int      age          = DateTime.Now.Year - selectedDate.Year;


        if (
            selectedDate.Date > DateTime.Now.AddYears(
                -age
            )
        )
            age--;

        if (
            age < 5
        ) {
            ErrorProvider.SetError(
                dateTimePicker,
                Utilities.Constants.ErrorMessages.lessThanTargetAge
            );
            isValid = false;
        } else
            ErrorProvider.SetError(
                dateTimePicker,
                string.Empty
            );

        return isValid;
    }

    private bool checkField(
        TextBox textBox,
        bool    isValid = true
    ) {
        if (
            string.IsNullOrWhiteSpace(
                textBox.Text
            )
        ) {
            ErrorProvider.SetError(
                textBox,
                Utilities.Constants.ErrorMessages.EMPTY
            );
            isValid = false;
        } else
            ErrorProvider.SetError(
                textBox,
                string.Empty
            );

        return isValid;
    }

    private void BrowseImageAnswer_Click(
        object    sender,
        EventArgs e
    ) {
        using OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @$"Image Files|*.{
            string.Join(
                ";*.",
                Utilities.Constants.imageExtensions
            )
        }|All Files|*.*";

        openFileDialog.Title = @"Select an Image";
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;

        string filePath = openFileDialog.FileName;

        BrowseImageAnswerDetails.Text = Path.GetFileName(
            filePath
        );

        selectedImagePath = filePath;
    }

    public void loadDataSources() {
        Loader.loadDataSource(
            CountryNameMobileNumberAnswer,
            AccountManagementSystem_ClassLibrary_BusinessLayer.Countries.getAllCountryNames()
        );
        Loader.loadDataSource(
            CountryNameAnswer,
            AccountManagementSystem_ClassLibrary_BusinessLayer.Countries.getAllCountryNames()
        );
        Loader.loadDataSource(
            AccountTypeAnswer,
            AccountManagementSystem_ClassLibrary_BusinessLayer.AccountTypes.getAllAccountTypeNames()
        );
    }
}