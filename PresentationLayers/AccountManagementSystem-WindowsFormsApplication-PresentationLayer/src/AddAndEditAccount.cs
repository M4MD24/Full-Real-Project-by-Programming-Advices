using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_BusinessLayer;
using AccountManagementSystem_ClassLibrary_BusinessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities.FullAccount;
using Constants = AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AddAndEditAccount : Form,
                                         Loader {
    private static   string?                    selectedImagePath;
    private readonly Constants.Mode             selectedMode;
    private          FullAccount.FullAccountIDs fullAccountIDs;
    private static   bool?                      isActive;

    public AddAndEditAccount(
        Constants.Mode mode,
        FullAccount?   fullAccount = null
    ) {
        InitializeComponent();

        selectedMode = mode;

        switch (mode) {
            case Constants.Mode.Add:
                initializeAdditionForm();
            break;
            case Constants.Mode.Update:
                initializeModificationForm(
                    ref fullAccount!
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
        clearField(
            ref ImageAnswer
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
        ref FullAccount fullAccount
    ) {
        Text = $@"Update {fullAccount.accountID}";
        setIcon(
            Constants.Mode.Update
        );
        loadDataSources();
        setFullAccountDataFields(
            ref fullAccount
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

    private void Submit_Click(
        object    sender,
        EventArgs e
    ) {
        if (!isValidData())
            return;

        DialogResult submit = MessageBox.Show(
            @"Do you want submit?",
            @"Submit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        );

        if (submit != DialogResult.Yes)
            return;

        FullAccount.FullAccountFields fullAccountFields = new FullAccount.FullAccountFields(
            NationalNumberAnswer.Text,
            FirstNameAnswer.Text,
            SecondNameAnswer.Text,
            ThirdNameAnswer.Text,
            FourthNameAnswer.Text,
            DateOfBirthAnswer.Value,
            AddressAnswer.Text,
            MobileNumberCountryNameAnswer.Text,
            ContactNumberAnswer.Text,
            EmailAnswer.Text,
            CountryNameAnswer.Text,
            selectedImagePath!,
            UsernameAnswer.Text,
            PasswordAnswer.Text,
            getPermissionIDsFromSelectedPermissions(),
            AccountTypeAnswer.Text
        );

        switch (selectedMode) {
            case Constants.Mode.Add:
                FullAccounts.add(
                    ref fullAccountFields
                );

                MessageBox.Show(
                    @"A new account has been created",
                    @"Create New Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            break;
            case Constants.Mode.Update:
                clearField(
                    ref ImageAnswer
                );

                FullAccounts.update(
                    ref fullAccountIDs,
                    ref fullAccountFields,
                    ref isActive
                );

                MessageBox.Show(
                    @"The account has been updated",
                    @"Update Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            break;
        }

        Close();
    }

    private static List<byte> getPermissionIDsFromSelectedPermissions() {
        List<byte> permissionIDs = [];

        if (PermissionsQuestion == null)
            return permissionIDs;

        foreach (Control control in PermissionsQuestion.Controls) {
            if (
                control is not CheckBox {
                    Checked: true
                } checkBox
            )
                continue;
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

        return permissionIDs;
    }

    private bool isValidData() {
        bool isValid = true;

        isValid &= selectedMode == Constants.Mode.Update
                           ? checkField(
                               NationalNumberAnswer
                           )
                           : checkUniqueField(
                               NationalNumberAnswer,
                               Accounts.isExist(
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
            MobileNumberCountryNameAnswer
        );
        isValid &= checkField(
            EmailAnswer
        );
        isValid &= checkField(
            CountryNameAnswer
        );
        isValid &= selectedMode == Constants.Mode.Update
                           ? checkField(
                               UsernameAnswer
                           )
                           : checkUniqueField(
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
        } else
            ErrorProvider.SetError(
                textBox,
                string.Empty
            );

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
        if (!isFieldNotEmpty(
                NationalNumberAnswer
            )) {
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

        clearField(
            ref ImageAnswer
        );

        BrowseImageAnswerDetails.Text = Path.GetFileName(
            filePath
        );
        selectedImagePath = filePath;

        using Image image = Image.FromFile(
            filePath
        );
        ImageAnswer.Image = new Bitmap(
            image
        );
    }

    public void loadDataSources() {
        Loader.loadDataSource(
            MobileNumberCountryNameAnswer,
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
        DialogResult clear = MessageBox.Show(
            @"Do you want clear all fields?",
            @"Clear Fields",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        );

        if (clear != DialogResult.Yes)
            return;

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
            ref MobileNumberCountryNameAnswer
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
        ref PictureBox pictureBox
    ) {
        if (pictureBox.Image == null)
            return;
        pictureBox.Image.Dispose();
        pictureBox.Image = null;
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

    private void setFullAccountDataFields(
        ref FullAccount fullAccount
    ) {
        fullAccountIDs = new FullAccount.FullAccountIDs(
            fullAccount.accountID,
            fullAccount.personID,
            fullAccount.fullNameID,
            fullAccount.contactInformationID,
            fullAccount.mobileNumberID,
            fullAccount.mobileNumberCountryID,
            fullAccount.countryID,
            fullAccount.accountTypeID
        );

        isActive = fullAccount.isActive;

        NationalNumberAnswer.Text          = fullAccount.nationalNumber;
        FirstNameAnswer.Text               = fullAccount.firstName;
        SecondNameAnswer.Text              = fullAccount.secondName;
        ThirdNameAnswer.Text               = fullAccount.thirdName;
        FourthNameAnswer.Text              = fullAccount.fourthName;
        DateOfBirthAnswer.Value            = (DateTime) fullAccount.dateOfBirth!;
        AddressAnswer.Text                 = fullAccount.address;
        MobileNumberCountryNameAnswer.Text = fullAccount.countryName;
        ContactNumberAnswer.Text           = fullAccount.contactNumber;
        EmailAnswer.Text                   = fullAccount.email;
        CountryNameAnswer.Text             = fullAccount.countryName;
        UsernameAnswer.Text                = fullAccount.username;
        PasswordAnswer.Text                = fullAccount.password;

        foreach (Control control in PermissionsQuestion.Controls)
            if (
                control is CheckBox checkBox &&
                fullAccount.permissions!.Any(
                    permission => permission.permissionName == control.Text
                )
            )
                checkBox.Checked = true;

        AccountTypeAnswer.Text = fullAccount.accountTypeName;

        clearField(
            ref ImageAnswer
        );

        selectedImagePath = fullAccount.imageURL;

        if (
            string.IsNullOrWhiteSpace(
                selectedImagePath
            ) ||
            !File.Exists(
                selectedImagePath
            )
        )
            return;
        using (
            Image image = Image.FromFile(
                selectedImagePath
            )
        )
            ImageAnswer.Image = new Bitmap(
                image
            );

        BrowseImageAnswerDetails.Text = Path.GetFileName(
            selectedImagePath
        );
    }
}