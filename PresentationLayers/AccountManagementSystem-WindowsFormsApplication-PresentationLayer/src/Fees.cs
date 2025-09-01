using System.Windows.Forms;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Fees : Form {
    public Fees() {
        InitializeComponent();
        Tools.setIcon(
            this,
            "Toll"
        );
    }
}