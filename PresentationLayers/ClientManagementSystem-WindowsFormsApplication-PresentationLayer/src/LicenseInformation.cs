using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class LicenseInformation : Form {
    public LicenseInformation(
        ref int? licenseID
    ) {
        InitializeComponent();

        Utilities.Tools.setIcon(
            this,
            "ID_Card"
        );

        FullLicense fullLicense = FullLicenses.get(
            ref licenseID
        );

        loadData(
            ref fullLicense!
        );
    }

    private void loadData(
        ref FullLicense? fullLicense
    ) {
        LicenseTypeNameAnswer.Text        = fullLicense!.licenseType!.name;
        LicenseTypeDescriptionAnswer.Text = fullLicense.licenseType!.description;
        LicenseTypeMinimumAgeAnswer.Text  = fullLicense.licenseType!.minimumAge.ToString();
        LicenseTypeDurationAnswer.Text    = fullLicense.licenseType!.duration.ToString();
        LicenseIssueAnswer.Text           = fullLicense.license!.issueDateTime.ToString();
        LicenseExpiryAnswer.Text          = fullLicense.license!.expiryDateTime.ToString();
        LicenseIssuanceNameAnswer.Text    = fullLicense.licenseIssuance!.licenseIssuanceName;
        LicenseCoverageNameAnswer.Text    = fullLicense.licenseCoverage!.coverageName;
        LicenseIsActiveAnswer.Text        = fullLicense.license!.isActive.ToString();
    }
}