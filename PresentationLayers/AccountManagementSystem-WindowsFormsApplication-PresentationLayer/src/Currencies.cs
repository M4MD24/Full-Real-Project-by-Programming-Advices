using System.Windows.Forms;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Currencies : Form {
    public Currencies() {
        InitializeComponent();
    }

    private void disableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );
}