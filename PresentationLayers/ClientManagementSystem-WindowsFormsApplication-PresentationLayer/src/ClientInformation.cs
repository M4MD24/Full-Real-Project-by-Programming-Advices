using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class ClientInformation : Form {
    public ClientInformation(
        ref int? accountID
    ) {
        InitializeComponent();

        setIcon();

        FullClient fullClient = FullClients.get(
            ref accountID
        );

        loadData(
            ref fullClient!
        );
    }

    private void loadData(
        ref FullClient? fullClient
    ) {
        NationalNumberAnswer.Text = fullClient!.nationalNumber;
        FirstNameAnswer.Text      = fullClient.firstName;
        SecondNameAnswer.Text     = fullClient.secondName;
        ThirdNameAnswer.Text      = fullClient.thirdName;
        FourthNameAnswer.Text     = fullClient.fourthName;
        DateOfBirthAnswer.Text = fullClient.dateOfBirth!.Value.ToString(
            CultureInfo.CurrentCulture
        );
        AddressAnswer.Text                 = fullClient.address;
        ContactNumberAnswer.Text           = fullClient.contactNumber;
        MobileNumberCountryNameAnswer.Text = fullClient.mobileNumberCountryName;
        EmailAnswer.Text                   = fullClient.email;
        CountryNameAnswer.Text             = fullClient.countryName;
        using (
            Image image = Image.FromFile(
                fullClient.imageURL!
            )
        )
            ImageAnswer.Image = new Bitmap(
                image
            );

        BrowseImageAnswerDetails.Text = Path.GetFileName(
            fullClient.imageURL!
        );
    }

    private void setIcon() {
        Assembly assembly = Assembly.GetExecutingAssembly();
        using Stream? iconStream = assembly.GetManifestResourceStream(
            Constants.RESOURCES_ICONS_PATH + ".Person.ico"
        );
        Icon = new Icon(
            iconStream!
        );
    }
}