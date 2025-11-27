using System.ComponentModel;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class ClientInformation {
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
        PersonQuestion                  = new System.Windows.Forms.GroupBox();
        ImageQuestion                   = new System.Windows.Forms.GroupBox();
        BrowseImageAnswerDetails        = new System.Windows.Forms.Label();
        ImageAnswer                     = new System.Windows.Forms.PictureBox();
        CountryNameAnswer               = new System.Windows.Forms.Label();
        CountryNameQuestion             = new System.Windows.Forms.Label();
        ContactInformationQuestion      = new System.Windows.Forms.GroupBox();
        EmailAnswer                     = new System.Windows.Forms.Label();
        MobileNumberQuestion            = new System.Windows.Forms.GroupBox();
        MobileNumberCountryNameAnswer   = new System.Windows.Forms.Label();
        MobileNumberCountryNameQuestion = new System.Windows.Forms.Label();
        ContactNumberAnswer             = new System.Windows.Forms.Label();
        ContactNumberQuestion           = new System.Windows.Forms.Label();
        EmailQuestion                   = new System.Windows.Forms.Label();
        AddressAnswer                   = new System.Windows.Forms.Label();
        AddressQuestion                 = new System.Windows.Forms.Label();
        DateOfBirthAnswer               = new System.Windows.Forms.Label();
        DateOfBirthQuestion             = new System.Windows.Forms.Label();
        NationalNumberAnswer            = new System.Windows.Forms.Label();
        NationalNumberQuestion          = new System.Windows.Forms.Label();
        FullNameQuestion                = new System.Windows.Forms.GroupBox();
        FourthNameAnswer                = new System.Windows.Forms.Label();
        FourthNameQuestion              = new System.Windows.Forms.Label();
        ThirdNameAnswer                 = new System.Windows.Forms.Label();
        ThirdNameQuestion               = new System.Windows.Forms.Label();
        SecondNameAnswer                = new System.Windows.Forms.Label();
        SecondNameQuestion              = new System.Windows.Forms.Label();
        FirstNameAnswer                 = new System.Windows.Forms.Label();
        FirstNameQuestion               = new System.Windows.Forms.Label();
        PersonQuestion.SuspendLayout();
        ImageQuestion.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) ImageAnswer).BeginInit();
        ContactInformationQuestion.SuspendLayout();
        MobileNumberQuestion.SuspendLayout();
        FullNameQuestion.SuspendLayout();
        SuspendLayout();
        //
        // PersonQuestion
        //
        PersonQuestion.Controls.Add(
            ImageQuestion
        );
        PersonQuestion.Controls.Add(
            CountryNameAnswer
        );
        PersonQuestion.Controls.Add(
            CountryNameQuestion
        );
        PersonQuestion.Controls.Add(
            ContactInformationQuestion
        );
        PersonQuestion.Controls.Add(
            AddressAnswer
        );
        PersonQuestion.Controls.Add(
            AddressQuestion
        );
        PersonQuestion.Controls.Add(
            DateOfBirthAnswer
        );
        PersonQuestion.Controls.Add(
            DateOfBirthQuestion
        );
        PersonQuestion.Controls.Add(
            NationalNumberAnswer
        );
        PersonQuestion.Controls.Add(
            NationalNumberQuestion
        );
        PersonQuestion.Controls.Add(
            FullNameQuestion
        );
        PersonQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        PersonQuestion.Location = new System.Drawing.Point(
            20,
            20
        );
        PersonQuestion.Name = "PersonQuestion";
        PersonQuestion.Size = new System.Drawing.Size(
            1025,
            525
        );
        PersonQuestion.TabIndex = 0;
        PersonQuestion.TabStop  = false;
        PersonQuestion.Text     = "Person";
        //
        // ImageQuestion
        //
        ImageQuestion.Controls.Add(
            BrowseImageAnswerDetails
        );
        ImageQuestion.Controls.Add(
            ImageAnswer
        );
        ImageQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        ImageQuestion.Location = new System.Drawing.Point(
            525,
            270
        );
        ImageQuestion.Name = "ImageQuestion";
        ImageQuestion.Size = new System.Drawing.Size(
            480,
            230
        );
        ImageQuestion.TabIndex = 13;
        ImageQuestion.TabStop  = false;
        ImageQuestion.Text     = "Image";
        //
        // BrowseImageAnswerDetails
        //
        BrowseImageAnswerDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        BrowseImageAnswerDetails.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        BrowseImageAnswerDetails.Location = new System.Drawing.Point(
            220,
            100
        );
        BrowseImageAnswerDetails.Name = "BrowseImageAnswerDetails";
        BrowseImageAnswerDetails.Size = new System.Drawing.Size(
            240,
            110
        );
        BrowseImageAnswerDetails.TabIndex = 26;
        //
        // ImageAnswer
        //
        ImageAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        ImageAnswer.Location = new System.Drawing.Point(
            20,
            30
        );
        ImageAnswer.Name = "ImageAnswer";
        ImageAnswer.Size = new System.Drawing.Size(
            180,
            180
        );
        ImageAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        ImageAnswer.TabIndex = 0;
        ImageAnswer.TabStop  = false;
        //
        // CountryNameAnswer
        //
        CountryNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        CountryNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        CountryNameAnswer.Location = new System.Drawing.Point(
            685,
            235
        );
        CountryNameAnswer.Name = "CountryNameAnswer";
        CountryNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        CountryNameAnswer.TabIndex  = 19;
        CountryNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // CountryNameQuestion
        //
        CountryNameQuestion.Location = new System.Drawing.Point(
            525,
            235
        );
        CountryNameQuestion.Name = "CountryNameQuestion";
        CountryNameQuestion.Size = new System.Drawing.Size(
            130,
            25
        );
        CountryNameQuestion.TabIndex  = 18;
        CountryNameQuestion.Text      = "Country Name:";
        CountryNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // ContactInformationQuestion
        //
        ContactInformationQuestion.Controls.Add(
            EmailAnswer
        );
        ContactInformationQuestion.Controls.Add(
            MobileNumberQuestion
        );
        ContactInformationQuestion.Controls.Add(
            EmailQuestion
        );
        ContactInformationQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        ContactInformationQuestion.Location = new System.Drawing.Point(
            525,
            30
        );
        ContactInformationQuestion.Name = "ContactInformationQuestion";
        ContactInformationQuestion.Size = new System.Drawing.Size(
            480,
            195
        );
        ContactInformationQuestion.TabIndex = 12;
        ContactInformationQuestion.TabStop  = false;
        ContactInformationQuestion.Text     = "Contact Information";
        //
        // EmailAnswer
        //
        EmailAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        EmailAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        EmailAnswer.Location = new System.Drawing.Point(
            160,
            150
        );
        EmailAnswer.Name = "EmailAnswer";
        EmailAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        EmailAnswer.TabIndex  = 17;
        EmailAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // MobileNumberQuestion
        //
        MobileNumberQuestion.Controls.Add(
            MobileNumberCountryNameAnswer
        );
        MobileNumberQuestion.Controls.Add(
            MobileNumberCountryNameQuestion
        );
        MobileNumberQuestion.Controls.Add(
            ContactNumberAnswer
        );
        MobileNumberQuestion.Controls.Add(
            ContactNumberQuestion
        );
        MobileNumberQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        MobileNumberQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        MobileNumberQuestion.Name = "MobileNumberQuestion";
        MobileNumberQuestion.Size = new System.Drawing.Size(
            440,
            110
        );
        MobileNumberQuestion.TabIndex = 13;
        MobileNumberQuestion.TabStop  = false;
        MobileNumberQuestion.Text     = "Mobile Number";
        //
        // MobileNumberCountryNameAnswer
        //
        MobileNumberCountryNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        MobileNumberCountryNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        MobileNumberCountryNameAnswer.Location = new System.Drawing.Point(
            175,
            65
        );
        MobileNumberCountryNameAnswer.Name = "MobileNumberCountryNameAnswer";
        MobileNumberCountryNameAnswer.Size = new System.Drawing.Size(
            245,
            25
        );
        MobileNumberCountryNameAnswer.TabIndex  = 15;
        MobileNumberCountryNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // MobileNumberCountryNameQuestion
        //
        MobileNumberCountryNameQuestion.Location = new System.Drawing.Point(
            20,
            65
        );
        MobileNumberCountryNameQuestion.Name = "MobileNumberCountryNameQuestion";
        MobileNumberCountryNameQuestion.Size = new System.Drawing.Size(
            130,
            25
        );
        MobileNumberCountryNameQuestion.TabIndex  = 14;
        MobileNumberCountryNameQuestion.Text      = "Country Name:";
        MobileNumberCountryNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // ContactNumberAnswer
        //
        ContactNumberAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        ContactNumberAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        ContactNumberAnswer.Location = new System.Drawing.Point(
            175,
            30
        );
        ContactNumberAnswer.Name = "ContactNumberAnswer";
        ContactNumberAnswer.Size = new System.Drawing.Size(
            245,
            25
        );
        ContactNumberAnswer.TabIndex  = 13;
        ContactNumberAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // ContactNumberQuestion
        //
        ContactNumberQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        ContactNumberQuestion.Name = "ContactNumberQuestion";
        ContactNumberQuestion.Size = new System.Drawing.Size(
            145,
            25
        );
        ContactNumberQuestion.TabIndex  = 12;
        ContactNumberQuestion.Text      = "Contact Number:";
        ContactNumberQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // EmailQuestion
        //
        EmailQuestion.Location = new System.Drawing.Point(
            20,
            150
        );
        EmailQuestion.Name = "EmailQuestion";
        EmailQuestion.Size = new System.Drawing.Size(
            60,
            25
        );
        EmailQuestion.TabIndex  = 16;
        EmailQuestion.Text      = "Email:";
        EmailQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // AddressAnswer
        //
        AddressAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        AddressAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        AddressAnswer.Location = new System.Drawing.Point(
            180,
            290
        );
        AddressAnswer.Name = "AddressAnswer";
        AddressAnswer.Size = new System.Drawing.Size(
            300,
            80
        );
        AddressAnswer.TabIndex = 7;
        //
        // AddressQuestion
        //
        AddressQuestion.Location = new System.Drawing.Point(
            20,
            290
        );
        AddressQuestion.Name = "AddressQuestion";
        AddressQuestion.Size = new System.Drawing.Size(
            75,
            25
        );
        AddressQuestion.TabIndex  = 6;
        AddressQuestion.Text      = "Address:";
        AddressQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // DateOfBirthAnswer
        //
        DateOfBirthAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        DateOfBirthAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        DateOfBirthAnswer.Location = new System.Drawing.Point(
            180,
            256
        );
        DateOfBirthAnswer.Name = "DateOfBirthAnswer";
        DateOfBirthAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        DateOfBirthAnswer.TabIndex  = 5;
        DateOfBirthAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // DateOfBirthQuestion
        //
        DateOfBirthQuestion.Location = new System.Drawing.Point(
            20,
            255
        );
        DateOfBirthQuestion.Name = "DateOfBirthQuestion";
        DateOfBirthQuestion.Size = new System.Drawing.Size(
            115,
            25
        );
        DateOfBirthQuestion.TabIndex  = 4;
        DateOfBirthQuestion.Text      = "Date of Birth:";
        DateOfBirthQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // NationalNumberAnswer
        //
        NationalNumberAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        NationalNumberAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        NationalNumberAnswer.Location = new System.Drawing.Point(
            180,
            31
        );
        NationalNumberAnswer.Name = "NationalNumberAnswer";
        NationalNumberAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        NationalNumberAnswer.TabIndex  = 3;
        NationalNumberAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // NationalNumberQuestion
        //
        NationalNumberQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        NationalNumberQuestion.Name = "NationalNumberQuestion";
        NationalNumberQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        NationalNumberQuestion.TabIndex  = 2;
        NationalNumberQuestion.Text      = "National Number:";
        NationalNumberQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            System.Drawing.FontStyle.Bold
        );
        FullNameQuestion.Location = new System.Drawing.Point(
            20,
            65
        );
        FullNameQuestion.Name = "FullNameQuestion";
        FullNameQuestion.Size = new System.Drawing.Size(
            480,
            180
        );
        FullNameQuestion.TabIndex = 1;
        FullNameQuestion.TabStop  = false;
        FullNameQuestion.Text     = "Full Name";
        //
        // FourthNameAnswer
        //
        FourthNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        FourthNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        FourthNameAnswer.Location = new System.Drawing.Point(
            160,
            136
        );
        FourthNameAnswer.Name = "FourthNameAnswer";
        FourthNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        FourthNameAnswer.TabIndex  = 11;
        FourthNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // FourthNameQuestion
        //
        FourthNameQuestion.Location = new System.Drawing.Point(
            20,
            135
        );
        FourthNameQuestion.Name = "FourthNameQuestion";
        FourthNameQuestion.Size = new System.Drawing.Size(
            115,
            25
        );
        FourthNameQuestion.TabIndex  = 10;
        FourthNameQuestion.Text      = "Fourth Name:";
        FourthNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // ThirdNameAnswer
        //
        ThirdNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        ThirdNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        ThirdNameAnswer.Location = new System.Drawing.Point(
            160,
            101
        );
        ThirdNameAnswer.Name = "ThirdNameAnswer";
        ThirdNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        ThirdNameAnswer.TabIndex  = 9;
        ThirdNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // ThirdNameQuestion
        //
        ThirdNameQuestion.Location = new System.Drawing.Point(
            20,
            100
        );
        ThirdNameQuestion.Name = "ThirdNameQuestion";
        ThirdNameQuestion.Size = new System.Drawing.Size(
            105,
            25
        );
        ThirdNameQuestion.TabIndex  = 8;
        ThirdNameQuestion.Text      = "Third Name:";
        ThirdNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // SecondNameAnswer
        //
        SecondNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        SecondNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        SecondNameAnswer.Location = new System.Drawing.Point(
            160,
            66
        );
        SecondNameAnswer.Name = "SecondNameAnswer";
        SecondNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        SecondNameAnswer.TabIndex  = 7;
        SecondNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // SecondNameQuestion
        //
        SecondNameQuestion.Location = new System.Drawing.Point(
            20,
            65
        );
        SecondNameQuestion.Name = "SecondNameQuestion";
        SecondNameQuestion.Size = new System.Drawing.Size(
            120,
            25
        );
        SecondNameQuestion.TabIndex  = 6;
        SecondNameQuestion.Text      = "Second Name:";
        SecondNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // FirstNameAnswer
        //
        FirstNameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        FirstNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        FirstNameAnswer.Location = new System.Drawing.Point(
            160,
            31
        );
        FirstNameAnswer.Name = "FirstNameAnswer";
        FirstNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        FirstNameAnswer.TabIndex  = 5;
        FirstNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // FirstNameQuestion
        //
        FirstNameQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        FirstNameQuestion.Name = "FirstNameQuestion";
        FirstNameQuestion.Size = new System.Drawing.Size(
            100,
            25
        );
        FirstNameQuestion.TabIndex  = 4;
        FirstNameQuestion.Text      = "First Name:";
        FirstNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // ClientInformation
        //
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            1064,
            571
        );
        Controls.Add(
            PersonQuestion
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Client Information";
        PersonQuestion.ResumeLayout(
            false
        );
        ImageQuestion.ResumeLayout(
            false
        );
        ((System.ComponentModel.ISupportInitialize) ImageAnswer).EndInit();
        ContactInformationQuestion.ResumeLayout(
            false
        );
        MobileNumberQuestion.ResumeLayout(
            false
        );
        FullNameQuestion.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label      BrowseImageAnswerDetails;
    private System.Windows.Forms.PictureBox ImageAnswer;
    private System.Windows.Forms.GroupBox   ImageQuestion;
    private System.Windows.Forms.Label      MobileNumberCountryNameAnswer;
    private System.Windows.Forms.Label      EmailAnswer;
    private System.Windows.Forms.Label      EmailQuestion;
    private System.Windows.Forms.Label      CountryNameAnswer;
    private System.Windows.Forms.Label      CountryNameQuestion;
    private System.Windows.Forms.Label      MobileNumberCountryNameQuestion;
    private System.Windows.Forms.GroupBox   ContactInformationQuestion;
    private System.Windows.Forms.GroupBox   MobileNumberQuestion;
    private System.Windows.Forms.Label      ContactNumberAnswer;
    private System.Windows.Forms.Label      ContactNumberQuestion;
    private System.Windows.Forms.Label      AddressAnswer;
    private System.Windows.Forms.Label      AddressQuestion;
    private System.Windows.Forms.Label      DateOfBirthAnswer;
    private System.Windows.Forms.Label      DateOfBirthQuestion;
    private System.Windows.Forms.Label      FirstNameQuestion;
    private System.Windows.Forms.Label      SecondNameAnswer;
    private System.Windows.Forms.Label      SecondNameQuestion;
    private System.Windows.Forms.Label      ThirdNameAnswer;
    private System.Windows.Forms.Label      ThirdNameQuestion;
    private System.Windows.Forms.Label      FourthNameAnswer;
    private System.Windows.Forms.Label      FourthNameQuestion;
    private System.Windows.Forms.Label      NationalNumberAnswer;
    private System.Windows.Forms.Label      FirstNameAnswer;
    private System.Windows.Forms.Label      NationalNumberQuestion;
    private System.Windows.Forms.GroupBox   FullNameQuestion;
    private System.Windows.Forms.GroupBox   PersonQuestion;

    #endregion
}