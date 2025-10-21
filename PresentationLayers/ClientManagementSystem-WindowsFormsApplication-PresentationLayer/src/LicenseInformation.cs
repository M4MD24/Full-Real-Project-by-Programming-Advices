using System.Windows.Forms;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class LicenseInformation : Form {
    public LicenseInformation(
        ref int? licenseID
    ) {
        Utilities.Tools.setIcon(
            this,
            "ID_Card"
        );
        InitializeComponent();
    }
}