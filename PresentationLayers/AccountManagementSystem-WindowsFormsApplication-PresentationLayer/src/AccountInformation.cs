using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_BusinessLayer.Models;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities.FullAccount;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AccountInformation : Form {
    public AccountInformation(
        ref int? accountID
    ) {
        InitializeComponent();

        setIcon();

        FullAccount fullAccount = FullAccounts.get(
            ref accountID
        );

        loadData(
            ref fullAccount!
        );
    }

    private void loadData(
        ref FullAccount? fullAccount
    ) {
        NationalNumberAnswer.Text = fullAccount!.nationalNumber;
        FirstNameAnswer.Text      = fullAccount.firstName;
        SecondNameAnswer.Text     = fullAccount.secondName;
        ThirdNameAnswer.Text      = fullAccount.thirdName;
        FourthNameAnswer.Text     = fullAccount.fourthName;
        DateOfBirthAnswer.Text = fullAccount.dateOfBirth!.Value.ToString(
            CultureInfo.CurrentCulture
        );
        AddressAnswer.Text                 = fullAccount.address;
        ContactNumberAnswer.Text           = fullAccount.contactNumber;
        MobileNumberCountryNameAnswer.Text = fullAccount.mobileNumberCountryName;
        EmailAnswer.Text                   = fullAccount.email;
        CountryNameAnswer.Text             = fullAccount.countryName;
        UsernameAnswer.Text                = fullAccount.username;
        PasswordAnswer.Text                = fullAccount.password;
        loadPermissions(
            fullAccount.permissions
        );
        AccountTypeAnswer.Text = fullAccount.accountTypeName;
        using (
            Image image = Image.FromFile(
                fullAccount.imageURL!
            )
        )
            ImageAnswer.Image = new Bitmap(
                image
            );

        BrowseImageAnswerDetails.Text = Path.GetFileName(
            fullAccount.imageURL!
        );
    }

    private void loadPermissions(
        List<Permission>? fullAccountPermissions
    ) {
        foreach (Control control in PermissionsQuestion.Controls)
            if (
                control is CheckBox checkBox &&
                fullAccountPermissions!.Any(
                    permission => permission.permissionName == control.Text
                )
            )
                checkBox.Checked = true;
    }

    private void setIcon() {
        Assembly assembly = Assembly.GetExecutingAssembly();
        using Stream? iconStream = assembly.GetManifestResourceStream(
            Utilities.Constants.RESOURCES_ICONS_PATH + ".Person.ico"
        );
        Icon = new Icon(
            iconStream!
        );
    }
}