using System.ComponentModel;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class AddAndEditAccount {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        PermissionsQuestion    = new System.Windows.Forms.GroupBox();
        FullNameQuestion       = new System.Windows.Forms.GroupBox();
        FirstNameAnswer        = new System.Windows.Forms.TextBox();
        FirstNameQuestion      = new System.Windows.Forms.Label();
        NationalNumberQuestion = new System.Windows.Forms.Label();
        colorDialog1           = new System.Windows.Forms.ColorDialog();
        NationalNumberAnswer   = new System.Windows.Forms.TextBox();
        SecondNameAnswer       = new System.Windows.Forms.TextBox();
        SecondNameQuestion     = new System.Windows.Forms.Label();
        ThirdNameAnswer        = new System.Windows.Forms.TextBox();
        ThirdNameQuestion      = new System.Windows.Forms.Label();
        FourthNameAnswer       = new System.Windows.Forms.TextBox();
        FourthNameQuestion     = new System.Windows.Forms.Label();
        FullNameQuestion.SuspendLayout();
        SuspendLayout();
        // 
        // PermissionsQuestion
        // 
        PermissionsQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        PermissionsQuestion.Location = new System.Drawing.Point(
            24,
            348
        );
        PermissionsQuestion.Name = "PermissionsQuestion";
        PermissionsQuestion.Size = new System.Drawing.Size(
            530,
            167
        );
        PermissionsQuestion.TabIndex = 0;
        PermissionsQuestion.TabStop  = false;
        PermissionsQuestion.Text     = "Permissions";
        // 
        // FullNameQuestion
        // 
        FullNameQuestion.Controls.Add(
            FourthNameAnswer
        );
        FullNameQuestion.Controls.Add(
            FourthNameQuestion
        );
        FullNameQuestion.Controls.Add(
            ThirdNameAnswer
        );
        FullNameQuestion.Controls.Add(
            ThirdNameQuestion
        );
        FullNameQuestion.Controls.Add(
            SecondNameAnswer
        );
        FullNameQuestion.Controls.Add(
            SecondNameQuestion
        );
        FullNameQuestion.Controls.Add(
            FirstNameAnswer
        );
        FullNameQuestion.Controls.Add(
            FirstNameQuestion
        );
        FullNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        FullNameQuestion.Location = new System.Drawing.Point(
            20,
            55
        );
        FullNameQuestion.Name = "FullNameQuestion";
        FullNameQuestion.Size = new System.Drawing.Size(
            540,
            180
        );
        FullNameQuestion.TabIndex = 1;
        FullNameQuestion.TabStop  = false;
        FullNameQuestion.Text     = "Full Name";
        // 
        // FirstNameAnswer
        // 
        FirstNameAnswer.Location = new System.Drawing.Point(
            175,
            30
        );
        FirstNameAnswer.Multiline = true;
        FirstNameAnswer.Name      = "FirstNameAnswer";
        FirstNameAnswer.Size = new System.Drawing.Size(
            345,
            25
        );
        FirstNameAnswer.TabIndex    =  5;
        // 
        // FirstNameQuestion
        // 
        FirstNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14.25F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        FirstNameQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        FirstNameQuestion.Name = "FirstNameQuestion";
        FirstNameQuestion.Size = new System.Drawing.Size(
            115,
            25
        );
        FirstNameQuestion.TabIndex = 4;
        FirstNameQuestion.Text     = "First Name:";
        // 
        // NationalNumberQuestion
        // 
        NationalNumberQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14.25F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        NationalNumberQuestion.Location = new System.Drawing.Point(
            20,
            20
        );
        NationalNumberQuestion.Name = "NationalNumberQuestion";
        NationalNumberQuestion.Size = new System.Drawing.Size(
            170,
            25
        );
        NationalNumberQuestion.TabIndex = 2;
        NationalNumberQuestion.Text     = "NationalNumber:";
        // 
        // NationalNumberAnswer
        // 
        NationalNumberAnswer.Location = new System.Drawing.Point(
            195,
            20
        );
        NationalNumberAnswer.Multiline = true;
        NationalNumberAnswer.Name      = "NationalNumberAnswer";
        NationalNumberAnswer.Size = new System.Drawing.Size(
            345,
            25
        );
        NationalNumberAnswer.TabIndex =  3;
        NationalNumberAnswer.KeyDown  += NationalNumberAnswer_KeyDown;
        // 
        // SecondNameAnswer
        // 
        SecondNameAnswer.Location = new System.Drawing.Point(
            175,
            65
        );
        SecondNameAnswer.Multiline = true;
        SecondNameAnswer.Name      = "SecondNameAnswer";
        SecondNameAnswer.Size = new System.Drawing.Size(
            345,
            25
        );
        SecondNameAnswer.TabIndex = 7;
        // 
        // SecondNameQuestion
        // 
        SecondNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14.25F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        SecondNameQuestion.Location = new System.Drawing.Point(
            20,
            65
        );
        SecondNameQuestion.Name = "SecondNameQuestion";
        SecondNameQuestion.Size = new System.Drawing.Size(
            140,
            25
        );
        SecondNameQuestion.TabIndex = 6;
        SecondNameQuestion.Text     = "Second Name:";
        // 
        // ThirdNameAnswer
        // 
        ThirdNameAnswer.Location = new System.Drawing.Point(
            175,
            100
        );
        ThirdNameAnswer.Multiline = true;
        ThirdNameAnswer.Name      = "ThirdNameAnswer";
        ThirdNameAnswer.Size = new System.Drawing.Size(
            345,
            25
        );
        ThirdNameAnswer.TabIndex = 9;
        // 
        // ThirdNameQuestion
        // 
        ThirdNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14.25F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        ThirdNameQuestion.Location = new System.Drawing.Point(
            20,
            100
        );
        ThirdNameQuestion.Name = "ThirdNameQuestion";
        ThirdNameQuestion.Size = new System.Drawing.Size(
            125,
            25
        );
        ThirdNameQuestion.TabIndex = 8;
        ThirdNameQuestion.Text     = "Third Name:";
        // 
        // FourthNameAnswer
        // 
        FourthNameAnswer.Location = new System.Drawing.Point(
            175,
            135
        );
        FourthNameAnswer.Multiline = true;
        FourthNameAnswer.Name      = "FourthNameAnswer";
        FourthNameAnswer.Size = new System.Drawing.Size(
            345,
            25
        );
        FourthNameAnswer.TabIndex = 11;
        // 
        // FourthNameQuestion
        // 
        FourthNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            14.25F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        FourthNameQuestion.Location = new System.Drawing.Point(
            20,
            135
        );
        FourthNameQuestion.Name = "FourthNameQuestion";
        FourthNameQuestion.Size = new System.Drawing.Size(
            135,
            25
        );
        FourthNameQuestion.TabIndex = 10;
        FourthNameQuestion.Text     = "Fourth Name:";
        // 
        // AddAndEditAccount
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            584,
            561
        );
        Controls.Add(
            NationalNumberAnswer
        );
        Controls.Add(
            NationalNumberQuestion
        );
        Controls.Add(
            FullNameQuestion
        );
        Controls.Add(
            PermissionsQuestion
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "AddAndEditAccount";
        FullNameQuestion.ResumeLayout(
            false
        );
        FullNameQuestion.PerformLayout();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.TextBox SecondNameAnswer;
    private System.Windows.Forms.Label   SecondNameQuestion;
    private System.Windows.Forms.TextBox ThirdNameAnswer;
    private System.Windows.Forms.Label   ThirdNameQuestion;
    private System.Windows.Forms.TextBox FourthNameAnswer;
    private System.Windows.Forms.Label   FourthNameQuestion;

    private System.Windows.Forms.TextBox FirstNameAnswer;
    private System.Windows.Forms.Label   FirstNameQuestion;

    private System.Windows.Forms.TextBox NationalNumberAnswer;

    private System.Windows.Forms.ColorDialog colorDialog1;

    private System.Windows.Forms.Label NationalNumberQuestion;

    private System.Windows.Forms.GroupBox PermissionsQuestion;
    private System.Windows.Forms.GroupBox FullNameQuestion;

    #endregion
}