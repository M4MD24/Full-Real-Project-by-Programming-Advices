using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class EditLicense : Form {
    public EditLicense(
        Constants.EditMode editMode,
        FullLicense        fullLicense
    ) {
        InitializeComponent();
    }
}