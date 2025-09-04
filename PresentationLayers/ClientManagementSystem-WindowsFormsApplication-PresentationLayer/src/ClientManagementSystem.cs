using System.Windows.Forms;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class ClientManagementSystem : Form {
    public ClientManagementSystem() {
        InitializeComponent();
    }

    private void ClientManagementSystem_FormClosing(
        object               sender,
        FormClosingEventArgs e
    ) {
        DialogResult result = MessageBox.Show(
            @"Do you want Close?",
            @"Close",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes) {
            new Login().Show();
            Hide();
        } else
            e.Cancel = true;
    }
}