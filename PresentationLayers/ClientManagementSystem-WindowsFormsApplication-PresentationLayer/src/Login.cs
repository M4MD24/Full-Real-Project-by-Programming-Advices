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
    ) {
        if (!isValidData())
            return;

        if (
            !AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.isExist(
                UsernameAnswer.Text
            )
        ) {
            ErrorProvider.SetError(
                UsernameAnswer,
                Constants.ErrorMessages.NOT_EXIST
            );
            return;
        }

        ErrorProvider.SetError(
            UsernameAnswer,
            string.Empty
        );

        if (
            !AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.isCorrect(
                UsernameAnswer.Text,
                PasswordAnswer.Text
            )
        ) {
            ErrorProvider.SetError(
                PasswordAnswer,
                Constants.ErrorMessages.PASSWORD_WRONG
            );
            return;
        }

        ErrorProvider.SetError(
            PasswordAnswer,
            string.Empty
        );

        new ClientManagementSystem().Show();

        Hide();
    }

    private bool isValidData() {
        bool isValid = true;

        isValid &= checkField(
            UsernameAnswer
        );

        isValid &= checkField(
            PasswordAnswer
        );

        return isValid;
    }

    private bool checkField(
        TextBox textBox
    ) {
        bool isValid = isFieldNotEmpty(
            textBox
        );

        return isValid;
    }

    private bool isFieldNotEmpty(
        TextBox textBox
    ) {
        bool isValid = true;
        if (
            string.IsNullOrWhiteSpace(
                textBox.Text
            )
        ) {
            ErrorProvider.SetError(
                textBox,
                Constants.ErrorMessages.EMPTY
            );
            isValid = false;
        } else
            ErrorProvider.SetError(
                textBox,
                string.Empty
            );

        return isValid;
    }

    private void disableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );

    private void UsernameAnswer_TextChanged(
        object    sender,
        EventArgs e
    ) => checkField(
        UsernameAnswer
    );

    private void PasswordAnswer_TextChanged(
        object    sender,
        EventArgs e
    ) => checkField(
        PasswordAnswer
    );

    private void Login_FormClosing(
        object               sender,
        FormClosingEventArgs e
    ) => Application.Exit();
}