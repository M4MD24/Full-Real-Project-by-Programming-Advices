namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class Login {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(
        bool disposing
    ) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(
            disposing
        );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        components       = new System.ComponentModel.Container();
        UsernameAnswer   = new System.Windows.Forms.TextBox();
        UsernameQuestion = new System.Windows.Forms.Label();
        PasswordQuestion = new System.Windows.Forms.Label();
        PasswordAnswer   = new System.Windows.Forms.TextBox();
        Submit           = new System.Windows.Forms.Button();
        ShowPassword     = new System.Windows.Forms.CheckBox();
        ErrorProvider = new System.Windows.Forms.ErrorProvider(
            components
        );
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // UsernameAnswer
        // 
        UsernameAnswer.Location = new System.Drawing.Point(
            125,
            20
        );
        UsernameAnswer.MaxLength = 30;
        UsernameAnswer.Multiline = true;
        UsernameAnswer.Name      = "UsernameAnswer";
        UsernameAnswer.Size = new System.Drawing.Size(
            290,
            25
        );
        UsernameAnswer.TabIndex    =  1;
        UsernameAnswer.TextChanged += UsernameAnswer_TextChanged;
        UsernameAnswer.KeyDown     += disableNewLine_KeyDown;
        // 
        // UsernameQuestion
        // 
        UsernameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        UsernameQuestion.Location = new System.Drawing.Point(
            20,
            20
        );
        UsernameQuestion.Name = "UsernameQuestion";
        UsernameQuestion.Size = new System.Drawing.Size(
            95,
            25
        );
        UsernameQuestion.TabIndex  = 0;
        UsernameQuestion.Text      = "Username:";
        UsernameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // PasswordQuestion
        // 
        PasswordQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        PasswordQuestion.Location = new System.Drawing.Point(
            20,
            55
        );
        PasswordQuestion.Name = "PasswordQuestion";
        PasswordQuestion.Size = new System.Drawing.Size(
            90,
            25
        );
        PasswordQuestion.TabIndex  = 2;
        PasswordQuestion.Text      = "Password:";
        PasswordQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // PasswordAnswer
        // 
        PasswordAnswer.Location = new System.Drawing.Point(
            125,
            55
        );
        PasswordAnswer.MaxLength    = 30;
        PasswordAnswer.Multiline    = true;
        PasswordAnswer.Name         = "PasswordAnswer";
        PasswordAnswer.PasswordChar = '*';
        PasswordAnswer.Size = new System.Drawing.Size(
            290,
            25
        );
        PasswordAnswer.TabIndex    =  3;
        PasswordAnswer.TextChanged += PasswordAnswer_TextChanged;
        PasswordAnswer.KeyDown     += disableNewLine_KeyDown;
        // 
        // Submit
        // 
        Submit.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        Submit.Location = new System.Drawing.Point(
            180,
            140
        );
        Submit.Name = "Submit";
        Submit.Size = new System.Drawing.Size(
            100,
            25
        );
        Submit.TabIndex                =  4;
        Submit.Text                    =  "Login";
        Submit.UseVisualStyleBackColor =  true;
        Submit.Click                   += Submit_Click;
        // 
        // ShowPassword
        // 
        ShowPassword.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        ShowPassword.Location = new System.Drawing.Point(
            300,
            90
        );
        ShowPassword.Name = "ShowPassword";
        ShowPassword.Size = new System.Drawing.Size(
            115,
            25
        );
        ShowPassword.TabIndex                =  5;
        ShowPassword.Text                    =  "Show Password";
        ShowPassword.UseVisualStyleBackColor =  true;
        ShowPassword.CheckedChanged          += ShowPassword_CheckedChanged;
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // Login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            434,
            181
        );
        Controls.Add(
            ShowPassword
        );
        Controls.Add(
            Submit
        );
        Controls.Add(
            PasswordQuestion
        );
        Controls.Add(
            PasswordAnswer
        );
        Controls.Add(
            UsernameQuestion
        );
        Controls.Add(
            UsernameAnswer
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Login";
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).EndInit();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ErrorProvider ErrorProvider;

    private System.Windows.Forms.CheckBox ShowPassword;
    private System.Windows.Forms.Button   Submit;
    private System.Windows.Forms.Label    PasswordQuestion;
    private System.Windows.Forms.TextBox  PasswordAnswer;
    private System.Windows.Forms.TextBox  UsernameAnswer;
    private System.Windows.Forms.Label    UsernameQuestion;

    #endregion
}