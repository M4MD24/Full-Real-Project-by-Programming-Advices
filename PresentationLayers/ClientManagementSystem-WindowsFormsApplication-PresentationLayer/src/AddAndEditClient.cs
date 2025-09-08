using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_BusinessLayer;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using Constants = ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AddAndEditClient : Form,
                                        Loader {
    private          string?                  selectedImagePath;
    private readonly Constants.Mode           selectedMode;
    private          FullClient.FullClientIDs fullClientIDs;

    public AddAndEditClient(
        Constants.Mode mode,
        FullClient?    fullClient = null
    ) {
        InitializeComponent();

        selectedMode = mode;

        switch (mode) {
            case Constants.Mode.Add:
                initializeAdditionForm();
            break;
            case Constants.Mode.Update:
                initializeModificationForm(
                    ref fullClient!
                );
            break;
        }
    }

    private void initializeFields() => clearAllFields();

    private void clearAllFields() => clearPersonField();

    private void clearPersonField() {
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
        clearImageField();
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
        selectedImagePath = null;
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
        ref FullClient fullClient
    ) {
        Text = @$"Update {fullClient.clientID}";
        setIcon(
            Constants.Mode.Update
        );
        loadDataSources();
        setFullClientDataFields(
            ref fullClient
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
        Text = @"Create New Client";
        setIcon(
            Constants.Mode.Add
        );
        loadDataSources();
        initializeFields();
        selectedImagePath = null;
    }

    private void disableNewLine_KeyDown(
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

        FullClient.FullClientFields fullClientFields = new FullClient.FullClientFields(
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
            selectedImagePath!
        );

        switch (selectedMode) {
            case Constants.Mode.Add:
                FullClients.add(
                    ref fullClientFields
                );

                MessageBox.Show(
                    @"A new client has been created",
                    @"Create New Client",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            break;
            case Constants.Mode.Update:
                clearField(
                    ref ImageAnswer
                );

                FullClients.update(
                    ref fullClientIDs,
                    ref fullClientFields
                );

                MessageBox.Show(
                    @"The client has been updated",
                    @"Update Client",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            break;
        }

        Close();
    }

    private bool isValidData() {
        bool isValid = true;

        isValid &= selectedMode == Constants.Mode.Update
                           ? checkField(
                               NationalNumberAnswer
                           )
                           : checkUniqueField(
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
            MobileNumberCountryNameAnswer
        );
        isValid &= checkField(
            EmailAnswer
        );
        isValid &= checkField(
            CountryNameAnswer
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

    private void loadDataSources() {
        Loader.loadDataSource(
            MobileNumberCountryNameAnswer,
            ClientManagementSystem_ClassLibrary_BusinessLayer.Countries.getAllCountryNames()
        );
        Loader.loadDataSource(
            CountryNameAnswer,
            ClientManagementSystem_ClassLibrary_BusinessLayer.Countries.getAllCountryNames()
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

    private void setFullClientDataFields(
        ref FullClient fullClient
    ) {
        fullClientIDs = new FullClient.FullClientIDs(
            fullClient.clientID,
            fullClient.personID,
            fullClient.fullNameID,
            fullClient.contactInformationID,
            fullClient.mobileNumberID,
            fullClient.mobileNumberCountryID,
            fullClient.countryID
        );

        NationalNumberAnswer.Text          = fullClient.nationalNumber;
        FirstNameAnswer.Text               = fullClient.firstName;
        SecondNameAnswer.Text              = fullClient.secondName;
        ThirdNameAnswer.Text               = fullClient.thirdName;
        FourthNameAnswer.Text              = fullClient.fourthName;
        DateOfBirthAnswer.Value            = (DateTime) fullClient.dateOfBirth!;
        AddressAnswer.Text                 = fullClient.address;
        MobileNumberCountryNameAnswer.Text = fullClient.countryName;
        ContactNumberAnswer.Text           = fullClient.contactNumber;
        EmailAnswer.Text                   = fullClient.email;
        CountryNameAnswer.Text             = fullClient.countryName;

        clearField(
            ref ImageAnswer
        );

        selectedImagePath = fullClient.imageURL;

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