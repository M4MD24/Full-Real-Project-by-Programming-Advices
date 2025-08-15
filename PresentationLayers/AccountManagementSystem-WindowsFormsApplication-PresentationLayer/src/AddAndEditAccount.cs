using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_BusinessLayer;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using Constants = AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AddAndEditAccount : Form,
                                         Loader {
    private static          string?           selectedImagePath;
    private static readonly List<Permission>? permissions = Permissions.getAll();

    public AddAndEditAccount(
        Constants.Mode mode,
        Account?       account = null
    ) {
        InitializeComponent();

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

    private void initializeFields() => clearAllFields();

    private void clearAllFields() {
        clearField(
            ref NationalNumberAnswer
        );
        clearFullNameField();
        clearField(
            ref DateOfBirthAnswer
        );
        clearField(
            ref AddressAnswer
        );
        clearContactInformationField();
        clearField(
            ref CountryNameAnswer
        );
        clearAccountField();
    }

    private void clearAccountField() {
        clearField(
            ref UsernameAnswer
        );
        clearField(
            ref PasswordAnswer
        );
        clearField(
            ref PermissionsQuestion
        );
        clearField(
            ref AccountTypeAnswer
        );
        clearImageField();
        clearField(
            ref AccountTypeAnswer
        );
    }

    private void clearImageField() {
        clearField(
            ref OpenFileDialog
        );
        clearField(
            ref BrowseImageAnswerDetails
        );
    }

    private static void clearField(
        ref OpenFileDialog openFileDialog
    ) => openFileDialog = new OpenFileDialog();

    private static void clearField(
        ref Label label
    ) => label.Text = @"None";

    private static void clearField(
        ref GroupBox groupBox
    ) {
        foreach (Control control in groupBox.Controls)
            if (control is CheckBox checkBox)
                checkBox.Checked = false;
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
        initializeFields();
    }

    private void DisableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );

    public static string copyImageToImageDirectory(
        int? personID
    ) {
        string extension = Path.GetExtension(
            selectedImagePath!
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
                selectedImagePath!,
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

        string   nationalNumber          = NationalNumberAnswer.Text;
        string   firstName               = FirstNameAnswer.Text;
        string   secondName              = SecondNameAnswer.Text;
        string   thirdName               = ThirdNameAnswer.Text;
        string   fourthName              = FourthNameAnswer.Text;
        DateTime dateOfBirth             = DateOfBirthAnswer.Value;
        string   address                 = AddressAnswer.Text;
        string   countryNameMobileNumber = CountryNameMobileNumberAnswer.Text;
        string   contactNumber           = ContactNumberAnswer.Text;
        string   email                   = EmailAnswer.Text;
        string   countryName             = CountryNameAnswer.Text;
        string   imageURL                = selectedImagePath!;
        string   username                = UsernameAnswer.Text!;
        string   password                = PasswordAnswer.Text;
        string   accountTypeName         = AccountTypeAnswer.Text;

        FullAccounts.addFullAccount(
            ref nationalNumber,
            ref firstName,
            ref secondName,
            ref thirdName,
            ref fourthName,
            ref dateOfBirth,
            ref address,
            ref countryNameMobileNumber,
            ref contactNumber,
            ref email,
            ref countryName,
            ref imageURL,
            ref username,
            ref password,
            ref accountTypeName
        );


        MessageBox.Show(
            @"A new account has been created",
            @"Create New Account",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    public static List<byte> getPermissionIDsFromSelectedPermissions() {
        List<byte> permissionIDs = new();

        if (PermissionsQuestion == null)
            return permissionIDs;

        foreach (Control control in PermissionsQuestion.Controls) {
            if (control is CheckBox {Checked: true} checkBox) {
                string permissionName = checkBox.Text;
                Permission? permission = Permissions.get(
                    ref permissionName
                );
                byte? permissionID = permission?.permissionID;

                if (permissionID is not null)
                    permissionIDs.Add(
                        permissionID.Value
                    );
            }
        }

        return permissionIDs;
    }

    private bool isValidData() {
        bool isValid = true;

        isValid &= checkUniqueField(
            NationalNumberAnswer,
            Persons.isExist(
                NationalNumberAnswer.Text
            )
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
        isValid &= checkUniqueField(
            UsernameAnswer,
            Accounts.isExist(
                UsernameAnswer.Text
            )
        );
        isValid &= checkField(
            PasswordAnswer
        );
        isValid &= checkField(
            AccountTypeAnswer
        );
        isValid &= checkField(
            selectedImagePath!
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

    private bool checkUniqueField(
        TextBox textBox,
        bool    targetFound
    ) {
        bool isValid = checkField(
            textBox
        );

        if (!isValid)
            return false;

        if (targetFound) {
            ErrorProvider.SetError(
                textBox,
                Utilities.Constants.ErrorMessages.NOT_UNIQUE
            );
            isValid = false;
        } else {
            ErrorProvider.SetError(
                textBox,
                string.Empty
            );
        }

        return isValid;
    }

    private bool checkField(
        TextBox textBox
    ) {
        bool isValid = isFieldNotEmpty(
            textBox
        );

        return isValid;
    }

    private bool isFieldNotEmpty(
        TextBox textBox
    ) {
        bool isValid = true;
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
        if (
            !isFieldNotEmpty(
                NationalNumberAnswer
            )
        ) {
            MessageBox.Show(
                @"Enter National Number",
                @"Browse Image",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

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
            Countries.getAllCountryNames()
        );
        Loader.loadDataSource(
            CountryNameAnswer,
            Countries.getAllCountryNames()
        );
        Loader.loadDataSource(
            AccountTypeAnswer,
            AccountTypes.getAllAccountTypeNames()
        );
    }

    private void ClearFields_Click(
        object    sender,
        EventArgs e
    ) {
        clearAllFields();
        clearAllErrors(
            this
        );
    }

    private void clearAllErrors(
        Control parent
    ) {
        foreach (Control control in parent.Controls) {
            ErrorProvider.SetError(
                control,
                string.Empty
            );

            if (control.HasChildren)
                clearAllErrors(
                    control
                );
        }
    }

    private void clearContactInformationField() {
        clearMobileNumberField();
        clearField(
            ref EmailAnswer
        );
    }

    private void clearMobileNumberField() {
        clearField(
            ref ContactNumberAnswer
        );
        clearField(
            ref CountryNameMobileNumberAnswer
        );
    }

    private void clearFullNameField() {
        clearField(
            ref FirstNameAnswer
        );
        clearField(
            ref SecondNameAnswer
        );
        clearField(
            ref ThirdNameAnswer
        );
        clearField(
            ref FourthNameAnswer
        );
    }

    private static void clearField(
        ref DateTimePicker dateTimePicker
    ) => dateTimePicker.Value = DateTime.Now;

    private static void clearField(
        ref ComboBox comboBox
    ) => comboBox.SelectedIndex = -1;

    private static void clearField(
        ref TextBox textBox
    ) => textBox.Clear();
}