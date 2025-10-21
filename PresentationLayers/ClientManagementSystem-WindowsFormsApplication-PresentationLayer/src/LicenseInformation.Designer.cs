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
        LicenseQuestion     = new System.Windows.Forms.GroupBox();
        LicenseTypeQuestion = new System.Windows.Forms.GroupBox();
        NameQuestion        = new System.Windows.Forms.Label();
        NameAnswer          = new System.Windows.Forms.Label();
        DescriptionQuestion = new System.Windows.Forms.Label();
        DescriptionAnswer   = new System.Windows.Forms.Label();
        MinimumAgeQuestion  = new System.Windows.Forms.Label();
        MinimumAgeAnswer    = new System.Windows.Forms.Label();
        DurationQuestion    = new System.Windows.Forms.Label();
        DurationAnswer      = new System.Windows.Forms.Label();
        LicenseQuestion.SuspendLayout();
        LicenseTypeQuestion.SuspendLayout();
        SuspendLayout();
        // 
        // LicenseQuestion
        // 
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
            600,
            500
        );
        LicenseQuestion.TabIndex = 0;
        LicenseQuestion.TabStop  = false;
        LicenseQuestion.Text     = "License";
        // 
        // LicenseTypeQuestion
        // 
        LicenseTypeQuestion.Controls.Add(
            DurationAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            DurationQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            MinimumAgeAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            MinimumAgeQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            DescriptionAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            DescriptionQuestion
        );
        LicenseTypeQuestion.Controls.Add(
            NameAnswer
        );
        LicenseTypeQuestion.Controls.Add(
            NameQuestion
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
            360
        );
        LicenseTypeQuestion.TabIndex = 2;
        LicenseTypeQuestion.TabStop  = false;
        LicenseTypeQuestion.Text     = "License Type";
        // 
        // NameAnswer
        // 
        NameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        NameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        NameAnswer.Location = new System.Drawing.Point(
            160,
            40
        );
        NameAnswer.Name = "NameAnswer";
        NameAnswer.Size = new System.Drawing.Size(
            380,
            30
        );
        NameAnswer.TabIndex  = 1;
        NameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // NameQuestion
        // 
        NameQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        NameQuestion.Name = "NameQuestion";
        NameQuestion.Size = new System.Drawing.Size(
            75,
            30
        );
        NameQuestion.TabIndex  = 0;
        NameQuestion.Text      = "Name:";
        NameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // DescriptionAnswer
        // 
        DescriptionAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        DescriptionAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        DescriptionAnswer.Location = new System.Drawing.Point(
            160,
            80
        );
        DescriptionAnswer.Name = "DescriptionAnswer";
        DescriptionAnswer.Size = new System.Drawing.Size(
            380,
            200
        );
        DescriptionAnswer.TabIndex  = 3;
        DescriptionAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // DescriptionQuestion
        // 
        DescriptionQuestion.Location = new System.Drawing.Point(
            20,
            80
        );
        DescriptionQuestion.Name = "DescriptionQuestion";
        DescriptionQuestion.Size = new System.Drawing.Size(
            130,
            30
        );
        DescriptionQuestion.TabIndex  = 2;
        DescriptionQuestion.Text      = "Description:";
        DescriptionQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // MinimumAgeAnswer
        // 
        MinimumAgeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        MinimumAgeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        MinimumAgeAnswer.Location = new System.Drawing.Point(
            185,
            290
        );
        MinimumAgeAnswer.Name = "MinimumAgeAnswer";
        MinimumAgeAnswer.Size = new System.Drawing.Size(
            105,
            30
        );
        MinimumAgeAnswer.TabIndex  = 5;
        MinimumAgeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // MinimumAgeQuestion
        // 
        MinimumAgeQuestion.Location = new System.Drawing.Point(
            20,
            290
        );
        MinimumAgeQuestion.Name = "MinimumAgeQuestion";
        MinimumAgeQuestion.Size = new System.Drawing.Size(
            155,
            30
        );
        MinimumAgeQuestion.TabIndex  = 4;
        MinimumAgeQuestion.Text      = "Minimum Age:";
        MinimumAgeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // DurationAnswer
        // 
        DurationAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        DurationAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        DurationAnswer.Location = new System.Drawing.Point(
            430,
            290
        );
        DurationAnswer.Name = "label1";
        DurationAnswer.Size = new System.Drawing.Size(
            105,
            30
        );
        DurationAnswer.TabIndex  = 7;
        DurationAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // DurationQuestion
        // 
        DurationQuestion.Location = new System.Drawing.Point(
            315,
            290
        );
        DurationQuestion.Name = "DurationQuestion";
        DurationQuestion.Size = new System.Drawing.Size(
            105,
            30
        );
        DurationQuestion.TabIndex  = 6;
        DurationQuestion.Text      = "Duration:";
        DurationQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            1182,
            553
        );
        Controls.Add(
            LicenseQuestion
        );
        Location = new System.Drawing.Point(
            19,
            19
        );
        Text = "License Information";
        LicenseQuestion.ResumeLayout(
            false
        );
        LicenseTypeQuestion.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.GroupBox LicenseQuestion;
    private System.Windows.Forms.GroupBox LicenseTypeQuestion;
    private System.Windows.Forms.Label    NameQuestion;
    private System.Windows.Forms.Label    NameAnswer;
    private System.Windows.Forms.Label    DescriptionQuestion;
    private System.Windows.Forms.Label    DescriptionAnswer;
    private System.Windows.Forms.Label    MinimumAgeAnswer;
    private System.Windows.Forms.Label    MinimumAgeQuestion;
    private System.Windows.Forms.Label    DurationQuestion;
    private System.Windows.Forms.Label    DurationAnswer;


    #endregion
}