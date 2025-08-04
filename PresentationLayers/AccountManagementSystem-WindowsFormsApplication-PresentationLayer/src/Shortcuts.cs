using System.Windows.Forms;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Shortcuts : Form {
    public Shortcuts() {
        InitializeComponent();
        initializeShortcutList();
    }

    private void initializeShortcutList() {
        ShortcutList.Columns.Add(
            "Key/s",
            130,
            HorizontalAlignment.Left
        );
        ShortcutList.Columns.Add(
            "Description",
            250,
            HorizontalAlignment.Left
        );

        ShortcutList.Items.Add(
            new ListViewItem(
                [
                    "CTRL + N",
                    "Create New Account"
                ]
            )
        );
        ShortcutList.Items.Add(
            new ListViewItem(
                [
                    "CTRL + SHIFT + N",
                    "Show Country List"
                ]
            )
        );
        ShortcutList.Items.Add(
            new ListViewItem(
                [
                    "CTRL + SHIFT + R",
                    "Show Currency List"
                ]
            )
        );
        ShortcutList.Items.Add(
            new ListViewItem(
                [
                    "CTRL + SHIFT + S",
                    "Show Shortcut List"
                ]
            )
        );
    }
}