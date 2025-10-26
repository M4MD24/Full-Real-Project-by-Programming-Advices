using System.ComponentModel;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class LicenseInformation {
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
        LicenseQuestion                = new System.Windows.Forms.GroupBox();
        LicenseIsActiveAnswer          = new System.Windows.Forms.Label();
        LicenseIsActiveQuestion        = new System.Windows.Forms.Label();
        LicenseExpiryAnswer            = new System.Windows.Forms.Label();
        LicenseExpiryQuestion          = new System.Windows.Forms.Label();
        LicenseIssueAnswer             = new System.Windows.Forms.Label();
        LicenseCoverageQuestion        = new System.Windows.Forms.GroupBox();
        LicenseCoverageNameAnswer      = new System.Windows.Forms.Label();
        LicenseCoverageNameQuestion    = new System.Windows.Forms.Label();
        LicenseIssueQuestion           = new System.Windows.Forms.Label();
        LicenseIssuanceQuestion        = new System.Windows.Forms.GroupBox();
        LicenseIssuanceNameAnswer      = new System.Windows.Forms.Label();
        LicenseIssuanceNameQuestion    = new System.Windows.Forms.Label();
        LicenseTypeQuestion            = new System.Windows.Forms.GroupBox();
        LicenseTypeDurationAnswer      = new System.Windows.Forms.Label();
        LicenseTypeDurationQuestion    = new System.Windows.Forms.Label();
        LicenseTypeMinimumAgeAnswer    = new System.Windows.Forms.Label();
        LicenseTypeMinimumAgeQuestion  = new System.Windows.Forms.Label();
        LicenseTypeDescriptionAnswer   = new System.Windows.Forms.Label();
        LicenseTypeDescriptionQuestion = new System.Windows.Forms.Label();
        LicenseTypeNameAnswer          = new System.Windows.Forms.Label();
        LicenseTypeNameQuestion        = new System.Windows.Forms.Label();
        LicenseQuestion.SuspendLayout();
        LicenseCoverageQuestion.SuspendLayout();
        LicenseIssuanceQuestion.SuspendLayout();
        LicenseTypeQuestion.SuspendLayout();
        SuspendLayout();
        // 
        // LicenseQuestion
        // 
        LicenseQuestion.Controls.Add(
            LicenseIsActiveAnswer
        );
        LicenseQuestion.Controls.Add(
            LicenseIsActiveQuestion
        );
        LicenseQuestion.Controls.Add(
            LicenseExpiryAnswer
        );
        LicenseQuestion.Controls.Add(
            LicenseExpiryQuestion
        );
        LicenseQuestion.Controls.Add(
            LicenseIssueAnswer
        );
        LicenseQuestion.Controls.Add(
            LicenseCoverageQuestion
        );
        LicenseQuestion.Controls.Add(
            LicenseIssueQuestion
        );
        LicenseQuestion.Controls.Add(
            LicenseIssuanceQuestion
        );
        LicenseQuestion.Controls.Add(
            LicenseTypeQuestion
        );
        LicenseQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseQuestion.Location = new System.Drawing.Point(
            20,
            20
        );
        LicenseQuestion.Name = "LicenseQuestion";
        LicenseQuestion.Size = new System.Drawing.Size(
            1045,
            440
        );
        LicenseQuestion.TabIndex = 0;
        LicenseQuestion.TabStop  = false;
        LicenseQuestion.Text     = "License";
        // 
        // LicenseIsActiveAnswer
        // 
        LicenseIsActiveAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseIsActiveAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseIsActiveAnswer.Location = new System.Drawing.Point(
            710,
            390
        );
        LicenseIsActiveAnswer.Name = "LicenseIsActiveAnswer";
        LicenseIsActiveAnswer.Size = new System.Drawing.Size(
            100,
            30
        );
        LicenseIsActiveAnswer.TabIndex  = 13;
        LicenseIsActiveAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseIsActiveQuestion
        // 
        LicenseIsActiveQuestion.Location = new System.Drawing.Point(
            600,
            390
        );
        LicenseIsActiveQuestion.Name = "LicenseIsActiveQuestion";
        LicenseIsActiveQuestion.Size = new System.Drawing.Size(
            100,
            30
        );
        LicenseIsActiveQuestion.TabIndex  = 12;
        LicenseIsActiveQuestion.Text      = "Is Active:";
        LicenseIsActiveQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseExpiryAnswer
        // 
        LicenseExpiryAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseExpiryAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseExpiryAnswer.Location = new System.Drawing.Point(
            395,
            390
        );
        LicenseExpiryAnswer.Name = "LicenseExpiryAnswer";
        LicenseExpiryAnswer.Size = new System.Drawing.Size(
            185,
            30
        );
        LicenseExpiryAnswer.TabIndex  = 11;
        LicenseExpiryAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseExpiryQuestion
        // 
        LicenseExpiryQuestion.Location = new System.Drawing.Point(
            305,
            390
        );
        LicenseExpiryQuestion.Name = "LicenseExpiryQuestion";
        LicenseExpiryQuestion.Size = new System.Drawing.Size(
            80,
            30
        );
        LicenseExpiryQuestion.TabIndex  = 10;
        LicenseExpiryQuestion.Text      = "Expiry:";
        LicenseExpiryQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseIssueAnswer
        // 
        LicenseIssueAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseIssueAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseIssueAnswer.Location = new System.Drawing.Point(
            95,
            390
        );
        LicenseIssueAnswer.Name = "LicenseIssueAnswer";
        LicenseIssueAnswer.Size = new System.Drawing.Size(
            185,
            30
        );
        LicenseIssueAnswer.TabIndex  = 3;
        LicenseIssueAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseCoverageQuestion
        // 
        LicenseCoverageQuestion.Controls.Add(
            LicenseCoverageNameAnswer
        );
        LicenseCoverageQuestion.Controls.Add(
            LicenseCoverageNameQuestion
        );
        LicenseCoverageQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseCoverageQuestion.Location = new System.Drawing.Point(
            600,
            140
        );
        LicenseCoverageQuestion.Name = "LicenseCoverageQuestion";
        LicenseCoverageQuestion.Size = new System.Drawing.Size(
            425,
            90
        );
        LicenseCoverageQuestion.TabIndex = 9;
        LicenseCoverageQuestion.TabStop  = false;
        LicenseCoverageQuestion.Text     = "Coverage";
        // 
        // LicenseCoverageNameAnswer
        // 
        LicenseCoverageNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseCoverageNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseCoverageNameAnswer.Location = new System.Drawing.Point(
            105,
            40
        );
        LicenseCoverageNameAnswer.Name = "LicenseCoverageNameAnswer";
        LicenseCoverageNameAnswer.Size = new System.Drawing.Size(
            300,
            30
        );
        LicenseCoverageNameAnswer.TabIndex  = 1;
        LicenseCoverageNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseCoverageNameQuestion
        // 
        LicenseCoverageNameQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        LicenseCoverageNameQuestion.Name = "LicenseCoverageNameQuestion";
        LicenseCoverageNameQuestion.Size = new System.Drawing.Size(
            75,
            30
        );
        LicenseCoverageNameQuestion.TabIndex  = 0;
        LicenseCoverageNameQuestion.Text      = "Name:";
        LicenseCoverageNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseIssueQuestion
        // 
        LicenseIssueQuestion.Location = new System.Drawing.Point(
            20,
            390
        );
        LicenseIssueQuestion.Name = "LicenseIssueQuestion";
        LicenseIssueQuestion.Size = new System.Drawing.Size(
            65,
            30
        );
        LicenseIssueQuestion.TabIndex  = 2;
        LicenseIssueQuestion.Text      = "Issue:";
        LicenseIssueQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseIssuanceQuestion
        // 
        LicenseIssuanceQuestion.Controls.Add(
            LicenseIssuanceNameAnswer
        );
        LicenseIssuanceQuestion.Controls.Add(
            LicenseIssuanceNameQuestion
        );
        LicenseIssuanceQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseIssuanceQuestion.Location = new System.Drawing.Point(
            600,
            40
        );
        LicenseIssuanceQuestion.Name = "LicenseIssuanceQuestion";
        LicenseIssuanceQuestion.Size = new System.Drawing.Size(
            425,
            90
        );
        LicenseIssuanceQuestion.TabIndex = 8;
        LicenseIssuanceQuestion.TabStop  = false;
        LicenseIssuanceQuestion.Text     = "Issuance";
        // 
        // LicenseIssuanceNameAnswer
        // 
        LicenseIssuanceNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseIssuanceNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseIssuanceNameAnswer.Location = new System.Drawing.Point(
            105,
            40
        );
        LicenseIssuanceNameAnswer.Name = "LicenseIssuanceNameAnswer";
        LicenseIssuanceNameAnswer.Size = new System.Drawing.Size(
            300,
            30
        );
        LicenseIssuanceNameAnswer.TabIndex  = 1;
        LicenseIssuanceNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseIssuanceNameQuestion
        // 
        LicenseIssuanceNameQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        LicenseIssuanceNameQuestion.Name = "LicenseIssuanceNameQuestion";
        LicenseIssuanceNameQuestion.Size = new System.Drawing.Size(
            75,
            30
        );
        LicenseIssuanceNameQuestion.TabIndex  = 0;
        LicenseIssuanceNameQuestion.Text      = "Name:";
        LicenseIssuanceNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeQuestion
        // 
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeDurationAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeDurationQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeMinimumAgeAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeMinimumAgeQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeDescriptionAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeDescriptionQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeNameAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseTypeNameQuestion
        );
        LicenseTypeQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseTypeQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        LicenseTypeQuestion.Name = "LicenseTypeQuestion";
        LicenseTypeQuestion.Size = new System.Drawing.Size(
            560,
            340
        );
        LicenseTypeQuestion.TabIndex = 2;
        LicenseTypeQuestion.TabStop  = false;
        LicenseTypeQuestion.Text     = "Type";
        // 
        // LicenseTypeDurationAnswer
        // 
        LicenseTypeDurationAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseTypeDurationAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseTypeDurationAnswer.Location = new System.Drawing.Point(
            430,
            290
        );
        LicenseTypeDurationAnswer.Name = "LicenseTypeDurationAnswer";
        LicenseTypeDurationAnswer.Size = new System.Drawing.Size(
            110,
            30
        );
        LicenseTypeDurationAnswer.TabIndex  = 7;
        LicenseTypeDurationAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeDurationQuestion
        // 
        LicenseTypeDurationQuestion.Location = new System.Drawing.Point(
            315,
            290
        );
        LicenseTypeDurationQuestion.Name = "LicenseTypeDurationQuestion";
        LicenseTypeDurationQuestion.Size = new System.Drawing.Size(
            105,
            30
        );
        LicenseTypeDurationQuestion.TabIndex  = 6;
        LicenseTypeDurationQuestion.Text      = "Duration:";
        LicenseTypeDurationQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeMinimumAgeAnswer
        // 
        LicenseTypeMinimumAgeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseTypeMinimumAgeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseTypeMinimumAgeAnswer.Location = new System.Drawing.Point(
            185,
            290
        );
        LicenseTypeMinimumAgeAnswer.Name = "LicenseTypeMinimumAgeAnswer";
        LicenseTypeMinimumAgeAnswer.Size = new System.Drawing.Size(
            110,
            30
        );
        LicenseTypeMinimumAgeAnswer.TabIndex  = 5;
        LicenseTypeMinimumAgeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeMinimumAgeQuestion
        // 
        LicenseTypeMinimumAgeQuestion.Location = new System.Drawing.Point(
            20,
            290
        );
        LicenseTypeMinimumAgeQuestion.Name = "LicenseTypeMinimumAgeQuestion";
        LicenseTypeMinimumAgeQuestion.Size = new System.Drawing.Size(
            155,
            30
        );
        LicenseTypeMinimumAgeQuestion.TabIndex  = 4;
        LicenseTypeMinimumAgeQuestion.Text      = "Minimum Age:";
        LicenseTypeMinimumAgeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeDescriptionAnswer
        // 
        LicenseTypeDescriptionAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseTypeDescriptionAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseTypeDescriptionAnswer.Location = new System.Drawing.Point(
            160,
            80
        );
        LicenseTypeDescriptionAnswer.Name = "LicenseTypeDescriptionAnswer";
        LicenseTypeDescriptionAnswer.Size = new System.Drawing.Size(
            380,
            200
        );
        LicenseTypeDescriptionAnswer.TabIndex = 3;
        // 
        // LicenseTypeDescriptionQuestion
        // 
        LicenseTypeDescriptionQuestion.Location = new System.Drawing.Point(
            20,
            80
        );
        LicenseTypeDescriptionQuestion.Name = "LicenseTypeDescriptionQuestion";
        LicenseTypeDescriptionQuestion.Size = new System.Drawing.Size(
            130,
            30
        );
        LicenseTypeDescriptionQuestion.TabIndex  = 2;
        LicenseTypeDescriptionQuestion.Text      = "Description:";
        LicenseTypeDescriptionQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeNameAnswer
        // 
        LicenseTypeNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseTypeNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseTypeNameAnswer.Location = new System.Drawing.Point(
            160,
            40
        );
        LicenseTypeNameAnswer.Name = "LicenseTypeNameAnswer";
        LicenseTypeNameAnswer.Size = new System.Drawing.Size(
            380,
            30
        );
        LicenseTypeNameAnswer.TabIndex  = 1;
        LicenseTypeNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeNameQuestion
        // 
        LicenseTypeNameQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        LicenseTypeNameQuestion.Name = "LicenseTypeNameQuestion";
        LicenseTypeNameQuestion.Size = new System.Drawing.Size(
            75,
            30
        );
        LicenseTypeNameQuestion.TabIndex  = 0;
        LicenseTypeNameQuestion.Text      = "Name:";
        LicenseTypeNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseInformation
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            9F,
            23F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            1082,
            478
        );
        Controls.Add(
            LicenseQuestion
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "License Information";
        LicenseQuestion.ResumeLayout(
            false
        );
        LicenseCoverageQuestion.ResumeLayout(
            false
        );
        LicenseIssuanceQuestion.ResumeLayout(
            false
        );
        LicenseTypeQuestion.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label LicenseIsActiveAnswer;

    private System.Windows.Forms.Label LicenseIsActiveQuestion;

    private System.Windows.Forms.Label LicenseExpiryAnswer;
    private System.Windows.Forms.Label LicenseExpiryQuestion;

    private System.Windows.Forms.Label LicenseIssueAnswer;
    private System.Windows.Forms.Label LicenseIssueQuestion;

    private System.Windows.Forms.GroupBox LicenseCoverageQuestion;
    private System.Windows.Forms.Label    LicenseCoverageNameAnswer;
    private System.Windows.Forms.Label    LicenseCoverageNameQuestion;
    private System.Windows.Forms.GroupBox LicenseIssuanceQuestion;
    private System.Windows.Forms.Label    LicenseIssuanceNameAnswer;
    private System.Windows.Forms.Label    LicenseIssuanceNameQuestion;
    private System.Windows.Forms.GroupBox LicenseQuestion;
    private System.Windows.Forms.GroupBox LicenseTypeQuestion;
    private System.Windows.Forms.Label    LicenseTypeNameQuestion;
    private System.Windows.Forms.Label    LicenseTypeNameAnswer;
    private System.Windows.Forms.Label    LicenseTypeDescriptionQuestion;
    private System.Windows.Forms.Label    LicenseTypeDescriptionAnswer;
    private System.Windows.Forms.Label    LicenseTypeMinimumAgeAnswer;
    private System.Windows.Forms.Label    LicenseTypeMinimumAgeQuestion;
    private System.Windows.Forms.Label    LicenseTypeDurationQuestion;
    private System.Windows.Forms.Label    LicenseTypeDurationAnswer;

    #endregion
}