using System;
using System.Windows.Forms;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

internal static class Program {
    [STAThread] private static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(
            false
        );
        Application.Run(
            new AccountManagementSystem()
        );
    }
}