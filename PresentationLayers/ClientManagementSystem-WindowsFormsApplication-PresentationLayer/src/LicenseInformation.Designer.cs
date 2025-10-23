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
        LicenseQuestion             = new System.Windows.Forms.GroupBox();
        LicenseCoverageQuestion     = new System.Windows.Forms.GroupBox();
        LicenseCoverageNameAnswer   = new System.Windows.Forms.Label();
        LicenseCoverageNameQuestion = new System.Windows.Forms.Label();
        LicenseIssuanceQuestion     = new System.Windows.Forms.GroupBox();
        LicenseIssuanceNameAnswer   = new System.Windows.Forms.Label();
        LicenseIssuanceNameQuestion = new System.Windows.Forms.Label();
        LicenseTypeQuestion         = new System.Windows.Forms.GroupBox();
        LicenseDurationAnswer       = new System.Windows.Forms.Label();
        LicenseDurationQuestion     = new System.Windows.Forms.Label();
        LicenseMinimumAgeAnswer     = new System.Windows.Forms.Label();
        LicenseMinimumAgeQuestion   = new System.Windows.Forms.Label();
        LicenseDescriptionAnswer    = new System.Windows.Forms.Label();
        LicenseDescriptionQuestion  = new System.Windows.Forms.Label();
        LicenseNameAnswer           = new System.Windows.Forms.Label();
        LicenseNameQuestion         = new System.Windows.Forms.Label();
        label1                      = new System.Windows.Forms.Label();
        label2                      = new System.Windows.Forms.Label();
        label3                      = new System.Windows.Forms.Label();
        label4                      = new System.Windows.Forms.Label();
        label6                      = new System.Windows.Forms.Label();
        label5                      = new System.Windows.Forms.Label();
        LicenseQuestion.SuspendLayout();
        LicenseCoverageQuestion.SuspendLayout();
        LicenseIssuanceQuestion.SuspendLayout();
        LicenseTypeQuestion.SuspendLayout();
        SuspendLayout();
        // 
        // LicenseQuestion
        // 
        LicenseQuestion.Controls.Add(
            label5
        );
        LicenseQuestion.Controls.Add(
            label6
        );
        LicenseQuestion.Controls.Add(
            label3
        );
        LicenseQuestion.Controls.Add(
            label4
        );
        LicenseQuestion.Controls.Add(
            label1
        );
        LicenseQuestion.Controls.Add(
            LicenseCoverageQuestion
        );
        LicenseQuestion.Controls.Add(
            label2
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
            LicenseDurationAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseDurationQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseMinimumAgeAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseMinimumAgeQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseDescriptionAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseDescriptionQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseNameAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            LicenseNameQuestion
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
        // LicenseDurationAnswer
        // 
        LicenseDurationAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseDurationAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseDurationAnswer.Location = new System.Drawing.Point(
            430,
            290
        );
        LicenseDurationAnswer.Name = "LicenseDurationAnswer";
        LicenseDurationAnswer.Size = new System.Drawing.Size(
            110,
            30
        );
        LicenseDurationAnswer.TabIndex  = 7;
        LicenseDurationAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseDurationQuestion
        // 
        LicenseDurationQuestion.Location = new System.Drawing.Point(
            315,
            290
        );
        LicenseDurationQuestion.Name = "LicenseDurationQuestion";
        LicenseDurationQuestion.Size = new System.Drawing.Size(
            105,
            30
        );
        LicenseDurationQuestion.TabIndex  = 6;
        LicenseDurationQuestion.Text      = "Duration:";
        LicenseDurationQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseMinimumAgeAnswer
        // 
        LicenseMinimumAgeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseMinimumAgeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseMinimumAgeAnswer.Location = new System.Drawing.Point(
            185,
            290
        );
        LicenseMinimumAgeAnswer.Name = "LicenseMinimumAgeAnswer";
        LicenseMinimumAgeAnswer.Size = new System.Drawing.Size(
            110,
            30
        );
        LicenseMinimumAgeAnswer.TabIndex  = 5;
        LicenseMinimumAgeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseMinimumAgeQuestion
        // 
        LicenseMinimumAgeQuestion.Location = new System.Drawing.Point(
            20,
            290
        );
        LicenseMinimumAgeQuestion.Name = "LicenseMinimumAgeQuestion";
        LicenseMinimumAgeQuestion.Size = new System.Drawing.Size(
            155,
            30
        );
        LicenseMinimumAgeQuestion.TabIndex  = 4;
        LicenseMinimumAgeQuestion.Text      = "Minimum Age:";
        LicenseMinimumAgeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseDescriptionAnswer
        // 
        LicenseDescriptionAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseDescriptionAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseDescriptionAnswer.Location = new System.Drawing.Point(
            160,
            80
        );
        LicenseDescriptionAnswer.Name = "LicenseDescriptionAnswer";
        LicenseDescriptionAnswer.Size = new System.Drawing.Size(
            380,
            200
        );
        LicenseDescriptionAnswer.TabIndex  = 3;
        LicenseDescriptionAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseDescriptionQuestion
        // 
        LicenseDescriptionQuestion.Location = new System.Drawing.Point(
            20,
            80
        );
        LicenseDescriptionQuestion.Name = "LicenseDescriptionQuestion";
        LicenseDescriptionQuestion.Size = new System.Drawing.Size(
            130,
            30
        );
        LicenseDescriptionQuestion.TabIndex  = 2;
        LicenseDescriptionQuestion.Text      = "Description:";
        LicenseDescriptionQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseNameAnswer
        // 
        LicenseNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        LicenseNameAnswer.Location = new System.Drawing.Point(
            160,
            40
        );
        LicenseNameAnswer.Name = "LicenseNameAnswer";
        LicenseNameAnswer.Size = new System.Drawing.Size(
            380,
            30
        );
        LicenseNameAnswer.TabIndex  = 1;
        LicenseNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseNameQuestion
        // 
        LicenseNameQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        LicenseNameQuestion.Name = "LicenseNameQuestion";
        LicenseNameQuestion.Size = new System.Drawing.Size(
            75,
            30
        );
        LicenseNameQuestion.TabIndex  = 0;
        LicenseNameQuestion.Text      = "Name:";
        LicenseNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label1.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        label1.Location = new System.Drawing.Point(
            95,
            390
        );
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(
            185,
            30
        );
        label1.TabIndex  = 3;
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(
            20,
            390
        );
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(
            65,
            30
        );
        label2.TabIndex  = 2;
        label2.Text      = "Issue:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label3.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        label3.Location = new System.Drawing.Point(
            395,
            390
        );
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(
            185,
            30
        );
        label3.TabIndex  = 11;
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(
            300,
            390
        );
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(
            85,
            30
        );
        label4.TabIndex  = 10;
        label4.Text      = "Expirty:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(
            600,
            390
        );
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(
            100,
            30
        );
        label6.TabIndex  = 12;
        label6.Text      = "Is Active:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label5.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        label5.Location = new System.Drawing.Point(
            710,
            390
        );
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(
            100,
            30
        );
        label5.TabIndex  = 13;
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        Text = "License Information";
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

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox LicenseCoverageQuestion;
    private System.Windows.Forms.Label    LicenseCoverageNameAnswer;
    private System.Windows.Forms.Label    LicenseCoverageNameQuestion;
    private System.Windows.Forms.GroupBox LicenseIssuanceQuestion;
    private System.Windows.Forms.Label    LicenseIssuanceNameAnswer;
    private System.Windows.Forms.Label    LicenseIssuanceNameQuestion;
    private System.Windows.Forms.GroupBox LicenseQuestion;
    private System.Windows.Forms.GroupBox LicenseTypeQuestion;
    private System.Windows.Forms.Label    LicenseNameQuestion;
    private System.Windows.Forms.Label    LicenseNameAnswer;
    private System.Windows.Forms.Label    LicenseDescriptionQuestion;
    private System.Windows.Forms.Label    LicenseDescriptionAnswer;
    private System.Windows.Forms.Label    LicenseMinimumAgeAnswer;
    private System.Windows.Forms.Label    LicenseMinimumAgeQuestion;
    private System.Windows.Forms.Label    LicenseDurationQuestion;
    private System.Windows.Forms.Label    LicenseDurationAnswer;

    #endregion
}