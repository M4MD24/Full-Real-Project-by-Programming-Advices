using System;
using System.Windows.Forms;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Login : Form {
    public Login() {
        InitializeComponent();
    }

    private void ShowPassword_CheckedChanged(
        object    sender,
        EventArgs e
    ) => PasswordAnswer.UseSystemPasswordChar = ShowPassword.Checked;

    private void Submit_Click(
        object    sender,
        EventArgs e
    ) {}

    private void disableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );
}