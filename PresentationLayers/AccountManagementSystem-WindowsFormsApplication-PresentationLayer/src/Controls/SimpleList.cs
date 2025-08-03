using System.Windows.Forms;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Controls;

public partial class SimpleList : UserControl {
    public SimpleList() {
        InitializeComponent();
    }

    private void searchBox_KeyDown(
        object       sender,
        KeyEventArgs e
    ) {
        if (e.KeyCode != Keys.Enter)
            return;
        e.SuppressKeyPress = true;
        e.Handled          = true;
    }
}