using System.ComponentModel;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class AddRequest {
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
        components              = new System.ComponentModel.Container();
        LicenseTypeNameAnswer   = new System.Windows.Forms.ComboBox();
        LicenseTypeNameQuestion = new System.Windows.Forms.Label();
        CoverageNameAnswer      = new System.Windows.Forms.ComboBox();
        CoverageNameQuestion    = new System.Windows.Forms.Label();
        Submit                  = new System.Windows.Forms.Button();
        ErrorProvider = new System.Windows.Forms.ErrorProvider(
            components
        );
        PaymentMethodQuestion           = new System.Windows.Forms.Label();
        PaymentMethodAnswer             = new System.Windows.Forms.ComboBox();
        ClearFields                     = new System.Windows.Forms.Button();
        LicenseTypeAmountAnswer         = new System.Windows.Forms.Label();
        LicenseTypeAmountCodeAnswer     = new System.Windows.Forms.Label();
        CoverageAmountCodeAnswer        = new System.Windows.Forms.Label();
        CoverageAmountAnswer            = new System.Windows.Forms.Label();
        LicenseIssuanceAmountCodeAnswer = new System.Windows.Forms.Label();
        LicenseIssuanceAmountAnswer     = new System.Windows.Forms.Label();
        FeesQuestion                    = new System.Windows.Forms.GroupBox();
        RequestAmountCodeAnswer         = new System.Windows.Forms.Label();
        RequestAmountAnswer             = new System.Windows.Forms.Label();
        RequestAmountQuestion           = new System.Windows.Forms.Label();
        TotalAmountQuestion             = new System.Windows.Forms.Label();
        LicenseIssuanceAmountQuestion   = new System.Windows.Forms.Label();
        CoverageAmountQuestion          = new System.Windows.Forms.Label();
        LicenseTypeAmountQuestion       = new System.Windows.Forms.Label();
        TotalAmountCodeAnswer           = new System.Windows.Forms.Label();
        TotalAmountAnswer               = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).BeginInit();
        FeesQuestion.SuspendLayout();
        SuspendLayout();
        // 
        // LicenseTypeNameAnswer
        // 
        LicenseTypeNameAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        LicenseTypeNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        LicenseTypeNameAnswer.FormattingEnabled = true;
        LicenseTypeNameAnswer.Location = new System.Drawing.Point(
            230,
            51
        );
        LicenseTypeNameAnswer.Name = "LicenseTypeNameAnswer";
        LicenseTypeNameAnswer.Size = new System.Drawing.Size(
            285,
            28
        );
        LicenseTypeNameAnswer.TabIndex             =  1;
        LicenseTypeNameAnswer.SelectedIndexChanged += LicenseTypeNameAnswer_SelectedIndexChanged;
        // 
        // LicenseTypeNameQuestion
        // 
        LicenseTypeNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        LicenseTypeNameQuestion.Location = new System.Drawing.Point(
            20,
            50
        );
        LicenseTypeNameQuestion.Name = "LicenseTypeNameQuestion";
        LicenseTypeNameQuestion.Size = new System.Drawing.Size(
            200,
            30
        );
        LicenseTypeNameQuestion.TabIndex = 0;
        LicenseTypeNameQuestion.Text     = "License Type Name:";
        // 
        // CoverageNameAnswer
        // 
        CoverageNameAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CoverageNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        CoverageNameAnswer.FormattingEnabled = true;
        CoverageNameAnswer.Location = new System.Drawing.Point(
            230,
            91
        );
        CoverageNameAnswer.Name = "CoverageNameAnswer";
        CoverageNameAnswer.Size = new System.Drawing.Size(
            285,
            28
        );
        CoverageNameAnswer.TabIndex             =  3;
        CoverageNameAnswer.SelectedIndexChanged += CoverageNameAnswer_SelectedIndexChanged;
        // 
        // CoverageNameQuestion
        // 
        CoverageNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        CoverageNameQuestion.Location = new System.Drawing.Point(
            20,
            90
        );
        CoverageNameQuestion.Name = "CoverageNameQuestion";
        CoverageNameQuestion.Size = new System.Drawing.Size(
            170,
            30
        );
        CoverageNameQuestion.TabIndex = 2;
        CoverageNameQuestion.Text     = "Coverage Name:";
        // 
        // Submit
        // 
        Submit.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        Submit.Location = new System.Drawing.Point(
            160,
            220
        );
        Submit.Name = "Submit";
        Submit.Size = new System.Drawing.Size(
            100,
            30
        );
        Submit.TabIndex                =  23;
        Submit.Text                    =  "Submit";
        Submit.UseVisualStyleBackColor =  true;
        Submit.Click                   += Submit_Click;
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // PaymentMethodQuestion
        // 
        PaymentMethodQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        PaymentMethodQuestion.Location = new System.Drawing.Point(
            20,
            130
        );
        PaymentMethodQuestion.Name = "PaymentMethodQuestion";
        PaymentMethodQuestion.Size = new System.Drawing.Size(
            180,
            30
        );
        PaymentMethodQuestion.TabIndex = 4;
        PaymentMethodQuestion.Text     = "Payment Method:";
        // 
        // PaymentMethodAnswer
        // 
        PaymentMethodAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        PaymentMethodAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        PaymentMethodAnswer.FormattingEnabled = true;
        PaymentMethodAnswer.Location = new System.Drawing.Point(
            230,
            131
        );
        PaymentMethodAnswer.Name = "PaymentMethodAnswer";
        PaymentMethodAnswer.Size = new System.Drawing.Size(
            285,
            28
        );
        PaymentMethodAnswer.TabIndex = 5;
        // 
        // ClearFields
        // 
        ClearFields.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        ClearFields.Location = new System.Drawing.Point(
            280,
            220
        );
        ClearFields.Name = "ClearFields";
        ClearFields.Size = new System.Drawing.Size(
            100,
            30
        );
        ClearFields.TabIndex                =  22;
        ClearFields.Text                    =  "Clear";
        ClearFields.UseVisualStyleBackColor =  true;
        ClearFields.Click                   += ClearFields_Click;
        // 
        // LicenseTypeAmountAnswer
        // 
        LicenseTypeAmountAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseTypeAmountAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        LicenseTypeAmountAnswer.Location = new System.Drawing.Point(
            210,
            30
        );
        LicenseTypeAmountAnswer.Name = "LicenseTypeAmountAnswer";
        LicenseTypeAmountAnswer.Size = new System.Drawing.Size(
            180,
            30
        );
        LicenseTypeAmountAnswer.TabIndex  = 8;
        LicenseTypeAmountAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseTypeAmountCodeAnswer
        // 
        LicenseTypeAmountCodeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseTypeAmountCodeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        LicenseTypeAmountCodeAnswer.Location = new System.Drawing.Point(
            395,
            30
        );
        LicenseTypeAmountCodeAnswer.Name = "LicenseTypeAmountCodeAnswer";
        LicenseTypeAmountCodeAnswer.Size = new System.Drawing.Size(
            65,
            30
        );
        LicenseTypeAmountCodeAnswer.TabIndex  = 9;
        LicenseTypeAmountCodeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // CoverageAmountCodeAnswer
        // 
        CoverageAmountCodeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        CoverageAmountCodeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        CoverageAmountCodeAnswer.Location = new System.Drawing.Point(
            395,
            70
        );
        CoverageAmountCodeAnswer.Name = "CoverageAmountCodeAnswer";
        CoverageAmountCodeAnswer.Size = new System.Drawing.Size(
            65,
            30
        );
        CoverageAmountCodeAnswer.TabIndex  = 12;
        CoverageAmountCodeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // CoverageAmountAnswer
        // 
        CoverageAmountAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        CoverageAmountAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        CoverageAmountAnswer.Location = new System.Drawing.Point(
            210,
            70
        );
        CoverageAmountAnswer.Name = "CoverageAmountAnswer";
        CoverageAmountAnswer.Size = new System.Drawing.Size(
            180,
            30
        );
        CoverageAmountAnswer.TabIndex  = 11;
        CoverageAmountAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // LicenseIssuanceAmountCodeAnswer
        // 
        LicenseIssuanceAmountCodeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseIssuanceAmountCodeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        LicenseIssuanceAmountCodeAnswer.Location = new System.Drawing.Point(
            395,
            110
        );
        LicenseIssuanceAmountCodeAnswer.Name = "LicenseIssuanceAmountCodeAnswer";
        LicenseIssuanceAmountCodeAnswer.Size = new System.Drawing.Size(
            65,
            30
        );
        LicenseIssuanceAmountCodeAnswer.TabIndex  = 15;
        LicenseIssuanceAmountCodeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // LicenseIssuanceAmountAnswer
        // 
        LicenseIssuanceAmountAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        LicenseIssuanceAmountAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        LicenseIssuanceAmountAnswer.Location = new System.Drawing.Point(
            210,
            110
        );
        LicenseIssuanceAmountAnswer.Name = "LicenseIssuanceAmountAnswer";
        LicenseIssuanceAmountAnswer.Size = new System.Drawing.Size(
            180,
            30
        );
        LicenseIssuanceAmountAnswer.TabIndex  = 14;
        LicenseIssuanceAmountAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FeesQuestion
        // 
        FeesQuestion.Controls.Add(
            RequestAmountCodeAnswer
        );
        FeesQuestion.Controls.Add(
            RequestAmountAnswer
        );
        FeesQuestion.Controls.Add(
            RequestAmountQuestion
        );
        FeesQuestion.Controls.Add(
            TotalAmountQuestion
        );
        FeesQuestion.Controls.Add(
            LicenseIssuanceAmountQuestion
        );
        FeesQuestion.Controls.Add(
            CoverageAmountQuestion
        );
        FeesQuestion.Controls.Add(
            LicenseTypeAmountQuestion
        );
        FeesQuestion.Controls.Add(
            TotalAmountCodeAnswer
        );
        FeesQuestion.Controls.Add(
            TotalAmountAnswer
        );
        FeesQuestion.Controls.Add(
            LicenseTypeAmountAnswer
        );
        FeesQuestion.Controls.Add(
            LicenseIssuanceAmountCodeAnswer
        );
        FeesQuestion.Controls.Add(
            CoverageAmountCodeAnswer
        );
        FeesQuestion.Controls.Add(
            CoverageAmountAnswer
        );
        FeesQuestion.Controls.Add(
            LicenseTypeAmountCodeAnswer
        );
        FeesQuestion.Controls.Add(
            LicenseIssuanceAmountAnswer
        );
        FeesQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        FeesQuestion.Location = new System.Drawing.Point(
            540,
            20
        );
        FeesQuestion.Name = "FeesQuestion";
        FeesQuestion.Size = new System.Drawing.Size(
            480,
            240
        );
        FeesQuestion.TabIndex = 6;
        FeesQuestion.TabStop  = false;
        FeesQuestion.Text     = "Fees";
        // 
        // RequestAmountCodeAnswer
        // 
        RequestAmountCodeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        RequestAmountCodeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        RequestAmountCodeAnswer.Location = new System.Drawing.Point(
            395,
            150
        );
        RequestAmountCodeAnswer.Name = "RequestAmountCodeAnswer";
        RequestAmountCodeAnswer.Size = new System.Drawing.Size(
            65,
            30
        );
        RequestAmountCodeAnswer.TabIndex  = 18;
        RequestAmountCodeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // RequestAmountAnswer
        // 
        RequestAmountAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        RequestAmountAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        RequestAmountAnswer.Location = new System.Drawing.Point(
            210,
            150
        );
        RequestAmountAnswer.Name = "RequestAmountAnswer";
        RequestAmountAnswer.Size = new System.Drawing.Size(
            180,
            30
        );
        RequestAmountAnswer.TabIndex  = 17;
        RequestAmountAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // RequestAmountQuestion
        // 
        RequestAmountQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        RequestAmountQuestion.Location = new System.Drawing.Point(
            15,
            150
        );
        RequestAmountQuestion.Name = "RequestAmountQuestion";
        RequestAmountQuestion.Size = new System.Drawing.Size(
            95,
            30
        );
        RequestAmountQuestion.TabIndex = 16;
        RequestAmountQuestion.Text     = "Request:";
        // 
        // TotalAmountQuestion
        // 
        TotalAmountQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        TotalAmountQuestion.Location = new System.Drawing.Point(
            15,
            190
        );
        TotalAmountQuestion.Name = "TotalAmountQuestion";
        TotalAmountQuestion.Size = new System.Drawing.Size(
            65,
            30
        );
        TotalAmountQuestion.TabIndex = 19;
        TotalAmountQuestion.Text     = "Total:";
        // 
        // LicenseIssuanceAmountQuestion
        // 
        LicenseIssuanceAmountQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        LicenseIssuanceAmountQuestion.Location = new System.Drawing.Point(
            15,
            111
        );
        LicenseIssuanceAmountQuestion.Name = "LicenseIssuanceAmountQuestion";
        LicenseIssuanceAmountQuestion.Size = new System.Drawing.Size(
            175,
            30
        );
        LicenseIssuanceAmountQuestion.TabIndex = 13;
        LicenseIssuanceAmountQuestion.Text     = "License Issuance:";
        // 
        // CoverageAmountQuestion
        // 
        CoverageAmountQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        CoverageAmountQuestion.Location = new System.Drawing.Point(
            15,
            71
        );
        CoverageAmountQuestion.Name = "CoverageAmountQuestion";
        CoverageAmountQuestion.Size = new System.Drawing.Size(
            105,
            30
        );
        CoverageAmountQuestion.TabIndex = 10;
        CoverageAmountQuestion.Text     = "Coverage:";
        // 
        // LicenseTypeAmountQuestion
        // 
        LicenseTypeAmountQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        LicenseTypeAmountQuestion.Location = new System.Drawing.Point(
            15,
            31
        );
        LicenseTypeAmountQuestion.Name = "LicenseTypeAmountQuestion";
        LicenseTypeAmountQuestion.Size = new System.Drawing.Size(
            140,
            30
        );
        LicenseTypeAmountQuestion.TabIndex = 7;
        LicenseTypeAmountQuestion.Text     = "License Type:";
        // 
        // TotalAmountCodeAnswer
        // 
        TotalAmountCodeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TotalAmountCodeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        TotalAmountCodeAnswer.Location = new System.Drawing.Point(
            395,
            190
        );
        TotalAmountCodeAnswer.Name = "TotalAmountCodeAnswer";
        TotalAmountCodeAnswer.Size = new System.Drawing.Size(
            65,
            30
        );
        TotalAmountCodeAnswer.TabIndex  = 21;
        TotalAmountCodeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TotalAmountAnswer
        // 
        TotalAmountAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TotalAmountAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        TotalAmountAnswer.Location = new System.Drawing.Point(
            210,
            190
        );
        TotalAmountAnswer.Name = "TotalAmountAnswer";
        TotalAmountAnswer.Size = new System.Drawing.Size(
            180,
            30
        );
        TotalAmountAnswer.TabIndex  = 20;
        TotalAmountAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // AddRequest
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            9F,
            23F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            1082,
            288
        );
        Controls.Add(
            FeesQuestion
        );
        Controls.Add(
            ClearFields
        );
        Controls.Add(
            PaymentMethodAnswer
        );
        Controls.Add(
            PaymentMethodQuestion
        );
        Controls.Add(
            Submit
        );
        Controls.Add(
            CoverageNameAnswer
        );
        Controls.Add(
            CoverageNameQuestion
        );
        Controls.Add(
            LicenseTypeNameQuestion
        );
        Controls.Add(
            LicenseTypeNameAnswer
        );
        Margin = new System.Windows.Forms.Padding(
            3,
            4,
            3,
            4
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Add Request";
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).EndInit();
        FeesQuestion.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label RequestAmountQuestion;
    private System.Windows.Forms.Label RequestAmountCodeAnswer;
    private System.Windows.Forms.Label RequestAmountAnswer;

    private System.Windows.Forms.Label LicenseIssuanceAmountQuestion;
    private System.Windows.Forms.Label CoverageAmountQuestion;
    private System.Windows.Forms.Label LicenseTypeAmountQuestion;
    private System.Windows.Forms.Label TotalAmountQuestion;

    private System.Windows.Forms.Label TotalAmountCodeAnswer;
    private System.Windows.Forms.Label TotalAmountAnswer;

    private System.Windows.Forms.GroupBox FeesQuestion;

    private System.Windows.Forms.Label CoverageAmountCodeAnswer;
    private System.Windows.Forms.Label CoverageAmountAnswer;
    private System.Windows.Forms.Label LicenseIssuanceAmountCodeAnswer;
    private System.Windows.Forms.Label LicenseIssuanceAmountAnswer;

    private System.Windows.Forms.Label LicenseTypeAmountCodeAnswer;

    private System.Windows.Forms.Label LicenseTypeAmountAnswer;

    private System.Windows.Forms.Button        ClearFields;
    private System.Windows.Forms.Label         PaymentMethodQuestion;
    private System.Windows.Forms.ComboBox      PaymentMethodAnswer;
    private System.Windows.Forms.ErrorProvider ErrorProvider;
    private System.Windows.Forms.Button        Submit;
    private System.Windows.Forms.ComboBox      CoverageNameAnswer;
    private System.Windows.Forms.Label         CoverageNameQuestion;
    private System.Windows.Forms.ComboBox      LicenseTypeNameAnswer;
    private System.Windows.Forms.Label         LicenseTypeNameQuestion;

    #endregion
}