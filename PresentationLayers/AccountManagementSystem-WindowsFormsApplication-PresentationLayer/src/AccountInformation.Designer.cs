using System.ComponentModel;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class AccountInformation {
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
        AccountQuestion                 = new System.Windows.Forms.GroupBox();
        AccountTypeAnswer               = new System.Windows.Forms.Label();
        AccountTypeQuestion             = new System.Windows.Forms.Label();
        PermissionsQuestion             = new System.Windows.Forms.GroupBox();
        UnlockLicensesPermission        = new System.Windows.Forms.CheckBox();
        TestPermission                  = new System.Windows.Forms.CheckBox();
        DeletePermission                = new System.Windows.Forms.CheckBox();
        EditPermission                  = new System.Windows.Forms.CheckBox();
        ReadAndSearchPermission         = new System.Windows.Forms.CheckBox();
        CreatePermission                = new System.Windows.Forms.CheckBox();
        PasswordAnswer                  = new System.Windows.Forms.Label();
        PasswordQuestion                = new System.Windows.Forms.Label();
        UsernameAnswer                  = new System.Windows.Forms.Label();
        UsernameQuestion                = new System.Windows.Forms.Label();
        PersonQuestion.SuspendLayout();
        ImageQuestion.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) ImageAnswer).BeginInit();
        ContactInformationQuestion.SuspendLayout();
        MobileNumberQuestion.SuspendLayout();
        FullNameQuestion.SuspendLayout();
        AccountQuestion.SuspendLayout();
        PermissionsQuestion.SuspendLayout();
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
            1340,
            625
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
            690,
            325
        );
        ImageQuestion.Name = "ImageQuestion";
        ImageQuestion.Size = new System.Drawing.Size(
            630,
            280
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
            250,
            125
        );
        BrowseImageAnswerDetails.Name = "BrowseImageAnswerDetails";
        BrowseImageAnswerDetails.Size = new System.Drawing.Size(
            360,
            135
        );
        BrowseImageAnswerDetails.TabIndex = 26;
        // 
        // ImageAnswer
        // 
        ImageAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        ImageAnswer.Location = new System.Drawing.Point(
            20,
            40
        );
        ImageAnswer.Name = "ImageAnswer";
        ImageAnswer.Size = new System.Drawing.Size(
            220,
            220
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
            905,
            283
        );
        CountryNameAnswer.Name = "CountryNameAnswer";
        CountryNameAnswer.Size = new System.Drawing.Size(
            365,
            30
        );
        CountryNameAnswer.TabIndex  = 19;
        CountryNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CountryNameQuestion
        // 
        CountryNameQuestion.Location = new System.Drawing.Point(
            690,
            280
        );
        CountryNameQuestion.Name = "CountryNameQuestion";
        CountryNameQuestion.Size = new System.Drawing.Size(
            155,
            30
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
            690,
            40
        );
        ContactInformationQuestion.Name = "ContactInformationQuestion";
        ContactInformationQuestion.Size = new System.Drawing.Size(
            630,
            230
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
            215,
            180
        );
        EmailAnswer.Name = "EmailAnswer";
        EmailAnswer.Size = new System.Drawing.Size(
            365,
            30
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
            40
        );
        MobileNumberQuestion.Name = "MobileNumberQuestion";
        MobileNumberQuestion.Size = new System.Drawing.Size(
            590,
            130
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
            195,
            80
        );
        MobileNumberCountryNameAnswer.Name = "MobileNumberCountryNameAnswer";
        MobileNumberCountryNameAnswer.Size = new System.Drawing.Size(
            365,
            30
        );
        MobileNumberCountryNameAnswer.TabIndex  = 15;
        MobileNumberCountryNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // MobileNumberCountryNameQuestion
        // 
        MobileNumberCountryNameQuestion.Location = new System.Drawing.Point(
            20,
            80
        );
        MobileNumberCountryNameQuestion.Name = "MobileNumberCountryNameQuestion";
        MobileNumberCountryNameQuestion.Size = new System.Drawing.Size(
            155,
            30
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
            195,
            40
        );
        ContactNumberAnswer.Name = "ContactNumberAnswer";
        ContactNumberAnswer.Size = new System.Drawing.Size(
            365,
            30
        );
        ContactNumberAnswer.TabIndex  = 13;
        ContactNumberAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ContactNumberQuestion
        // 
        ContactNumberQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        ContactNumberQuestion.Name = "ContactNumberQuestion";
        ContactNumberQuestion.Size = new System.Drawing.Size(
            175,
            30
        );
        ContactNumberQuestion.TabIndex  = 12;
        ContactNumberQuestion.Text      = "Contact Number:";
        ContactNumberQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // EmailQuestion
        // 
        EmailQuestion.Location = new System.Drawing.Point(
            20,
            180
        );
        EmailQuestion.Name = "EmailQuestion";
        EmailQuestion.Size = new System.Drawing.Size(
            70,
            30
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
            200,
            340
        );
        AddressAnswer.Name = "AddressAnswer";
        AddressAnswer.Size = new System.Drawing.Size(
            430,
            163
        );
        AddressAnswer.TabIndex = 7;
        // 
        // AddressQuestion
        // 
        AddressQuestion.Location = new System.Drawing.Point(
            20,
            340
        );
        AddressQuestion.Name = "AddressQuestion";
        AddressQuestion.Size = new System.Drawing.Size(
            95,
            30
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
            200,
            300
        );
        DateOfBirthAnswer.Name = "DateOfBirthAnswer";
        DateOfBirthAnswer.Size = new System.Drawing.Size(
            430,
            30
        );
        DateOfBirthAnswer.TabIndex  = 5;
        DateOfBirthAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // DateOfBirthQuestion
        // 
        DateOfBirthQuestion.Location = new System.Drawing.Point(
            20,
            300
        );
        DateOfBirthQuestion.Name = "DateOfBirthQuestion";
        DateOfBirthQuestion.Size = new System.Drawing.Size(
            145,
            30
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
            215,
            40
        );
        NationalNumberAnswer.Name = "NationalNumberAnswer";
        NationalNumberAnswer.Size = new System.Drawing.Size(
            415,
            30
        );
        NationalNumberAnswer.TabIndex  = 3;
        NationalNumberAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // NationalNumberQuestion
        // 
        NationalNumberQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        NationalNumberQuestion.Name = "NationalNumberQuestion";
        NationalNumberQuestion.Size = new System.Drawing.Size(
            185,
            30
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
            80
        );
        FullNameQuestion.Name = "FullNameQuestion";
        FullNameQuestion.Size = new System.Drawing.Size(
            630,
            210
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
            180,
            160
        );
        FourthNameAnswer.Name = "FourthNameAnswer";
        FourthNameAnswer.Size = new System.Drawing.Size(
            430,
            30
        );
        FourthNameAnswer.TabIndex  = 11;
        FourthNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FourthNameQuestion
        // 
        FourthNameQuestion.Location = new System.Drawing.Point(
            20,
            160
        );
        FourthNameQuestion.Name = "FourthNameQuestion";
        FourthNameQuestion.Size = new System.Drawing.Size(
            145,
            30
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
            180,
            120
        );
        ThirdNameAnswer.Name = "ThirdNameAnswer";
        ThirdNameAnswer.Size = new System.Drawing.Size(
            430,
            30
        );
        ThirdNameAnswer.TabIndex  = 9;
        ThirdNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ThirdNameQuestion
        // 
        ThirdNameQuestion.Location = new System.Drawing.Point(
            20,
            120
        );
        ThirdNameQuestion.Name = "ThirdNameQuestion";
        ThirdNameQuestion.Size = new System.Drawing.Size(
            130,
            30
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
            180,
            80
        );
        SecondNameAnswer.Name = "SecondNameAnswer";
        SecondNameAnswer.Size = new System.Drawing.Size(
            430,
            30
        );
        SecondNameAnswer.TabIndex  = 7;
        SecondNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // SecondNameQuestion
        // 
        SecondNameQuestion.Location = new System.Drawing.Point(
            20,
            80
        );
        SecondNameQuestion.Name = "SecondNameQuestion";
        SecondNameQuestion.Size = new System.Drawing.Size(
            150,
            30
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
            180,
            40
        );
        FirstNameAnswer.Name = "FirstNameAnswer";
        FirstNameAnswer.Size = new System.Drawing.Size(
            430,
            30
        );
        FirstNameAnswer.TabIndex  = 5;
        FirstNameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FirstNameQuestion
        // 
        FirstNameQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        FirstNameQuestion.Name = "FirstNameQuestion";
        FirstNameQuestion.Size = new System.Drawing.Size(
            120,
            30
        );
        FirstNameQuestion.TabIndex  = 4;
        FirstNameQuestion.Text      = "First Name:";
        FirstNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // AccountQuestion
        // 
        AccountQuestion.Controls.Add(
            AccountTypeAnswer
        );
        AccountQuestion.Controls.Add(
            AccountTypeQuestion
        );
        AccountQuestion.Controls.Add(
            PermissionsQuestion
        );
        AccountQuestion.Controls.Add(
            PasswordAnswer
        );
        AccountQuestion.Controls.Add(
            PasswordQuestion
        );
        AccountQuestion.Controls.Add(
            UsernameAnswer
        );
        AccountQuestion.Controls.Add(
            UsernameQuestion
        );
        AccountQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        AccountQuestion.Location = new System.Drawing.Point(
            20,
            665
        );
        AccountQuestion.Name = "AccountQuestion";
        AccountQuestion.Size = new System.Drawing.Size(
            1340,
            230
        );
        AccountQuestion.TabIndex = 20;
        AccountQuestion.TabStop  = false;
        AccountQuestion.Text     = "Account";
        // 
        // AccountTypeAnswer
        // 
        AccountTypeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        AccountTypeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        AccountTypeAnswer.Location = new System.Drawing.Point(
            905,
            40
        );
        AccountTypeAnswer.Name = "AccountTypeAnswer";
        AccountTypeAnswer.Size = new System.Drawing.Size(
            395,
            30
        );
        AccountTypeAnswer.TabIndex  = 25;
        AccountTypeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // AccountTypeQuestion
        // 
        AccountTypeQuestion.Location = new System.Drawing.Point(
            690,
            40
        );
        AccountTypeQuestion.Name = "AccountTypeQuestion";
        AccountTypeQuestion.Size = new System.Drawing.Size(
            150,
            30
        );
        AccountTypeQuestion.TabIndex  = 24;
        AccountTypeQuestion.Text      = "Account Type:";
        AccountTypeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // PermissionsQuestion
        // 
        PermissionsQuestion.Controls.Add(
            UnlockLicensesPermission
        );
        PermissionsQuestion.Controls.Add(
            TestPermission
        );
        PermissionsQuestion.Controls.Add(
            DeletePermission
        );
        PermissionsQuestion.Controls.Add(
            EditPermission
        );
        PermissionsQuestion.Controls.Add(
            ReadAndSearchPermission
        );
        PermissionsQuestion.Controls.Add(
            CreatePermission
        );
        PermissionsQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        PermissionsQuestion.Location = new System.Drawing.Point(
            20,
            120
        );
        PermissionsQuestion.Name = "PermissionsQuestion";
        PermissionsQuestion.Size = new System.Drawing.Size(
            1300,
            90
        );
        PermissionsQuestion.TabIndex = 12;
        PermissionsQuestion.TabStop  = false;
        PermissionsQuestion.Text     = "Permissions";
        // 
        // UnlockLicensesPermission
        // 
        UnlockLicensesPermission.Enabled = false;
        UnlockLicensesPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        UnlockLicensesPermission.Location = new System.Drawing.Point(
            550,
            40
        );
        UnlockLicensesPermission.Name = "UnlockLicensesPermission";
        UnlockLicensesPermission.Size = new System.Drawing.Size(
            80,
            25
        );
        UnlockLicensesPermission.TabIndex                = 6;
        UnlockLicensesPermission.Text                    = "Unlock Licenses";
        UnlockLicensesPermission.UseVisualStyleBackColor = true;
        // 
        // TestPermission
        // 
        TestPermission.Enabled = false;
        TestPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        TestPermission.Location = new System.Drawing.Point(
            470,
            40
        );
        TestPermission.Name = "TestPermission";
        TestPermission.Size = new System.Drawing.Size(
            60,
            25
        );
        TestPermission.TabIndex                = 4;
        TestPermission.Text                    = "Test";
        TestPermission.UseVisualStyleBackColor = true;
        // 
        // DeletePermission
        // 
        DeletePermission.Enabled = false;
        DeletePermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        DeletePermission.Location = new System.Drawing.Point(
            370,
            40
        );
        DeletePermission.Name = "DeletePermission";
        DeletePermission.Size = new System.Drawing.Size(
            80,
            25
        );
        DeletePermission.TabIndex                = 3;
        DeletePermission.Text                    = "Delete";
        DeletePermission.UseVisualStyleBackColor = true;
        // 
        // EditPermission
        // 
        EditPermission.Enabled = false;
        EditPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        EditPermission.Location = new System.Drawing.Point(
            290,
            40
        );
        EditPermission.Name = "EditPermission";
        EditPermission.Size = new System.Drawing.Size(
            60,
            25
        );
        EditPermission.TabIndex                = 2;
        EditPermission.Text                    = "Edit";
        EditPermission.UseVisualStyleBackColor = true;
        // 
        // ReadAndSearchPermission
        // 
        ReadAndSearchPermission.Enabled = false;
        ReadAndSearchPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        ReadAndSearchPermission.Location = new System.Drawing.Point(
            120,
            40
        );
        ReadAndSearchPermission.Name = "ReadAndSearchPermission";
        ReadAndSearchPermission.Size = new System.Drawing.Size(
            150,
            25
        );
        ReadAndSearchPermission.TabIndex                = 1;
        ReadAndSearchPermission.Text                    = "Read and Search";
        ReadAndSearchPermission.UseVisualStyleBackColor = true;
        // 
        // CreatePermission
        // 
        CreatePermission.Enabled = false;
        CreatePermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        CreatePermission.Location = new System.Drawing.Point(
            20,
            40
        );
        CreatePermission.Name = "CreatePermission";
        CreatePermission.Size = new System.Drawing.Size(
            80,
            25
        );
        CreatePermission.TabIndex                = 0;
        CreatePermission.Text                    = "Create";
        CreatePermission.UseVisualStyleBackColor = true;
        // 
        // PasswordAnswer
        // 
        PasswordAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PasswordAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        PasswordAnswer.Location = new System.Drawing.Point(
            250,
            80
        );
        PasswordAnswer.Name = "PasswordAnswer";
        PasswordAnswer.Size = new System.Drawing.Size(
            370,
            30
        );
        PasswordAnswer.TabIndex  = 23;
        PasswordAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // PasswordQuestion
        // 
        PasswordQuestion.Location = new System.Drawing.Point(
            20,
            80
        );
        PasswordQuestion.Name = "PasswordQuestion";
        PasswordQuestion.Size = new System.Drawing.Size(
            120,
            30
        );
        PasswordQuestion.TabIndex  = 22;
        PasswordQuestion.Text      = "Passowrd:";
        PasswordQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // UsernameAnswer
        // 
        UsernameAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        UsernameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        UsernameAnswer.Location = new System.Drawing.Point(
            250,
            40
        );
        UsernameAnswer.Name = "UsernameAnswer";
        UsernameAnswer.Size = new System.Drawing.Size(
            370,
            30
        );
        UsernameAnswer.TabIndex  = 21;
        UsernameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // UsernameQuestion
        // 
        UsernameQuestion.Location = new System.Drawing.Point(
            20,
            40
        );
        UsernameQuestion.Name = "UsernameQuestion";
        UsernameQuestion.Size = new System.Drawing.Size(
            195,
            30
        );
        UsernameQuestion.TabIndex  = 20;
        UsernameQuestion.Text      = "Username:";
        UsernameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // AccountInformation
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            9F,
            23F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            1382,
            913
        );
        Controls.Add(
            AccountQuestion
        );
        Controls.Add(
            PersonQuestion
        );
        Margin = new System.Windows.Forms.Padding(
            4,
            5,
            4,
            5
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Account Information";
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
        AccountQuestion.ResumeLayout(
            false
        );
        PermissionsQuestion.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label      BrowseImageAnswerDetails;
    private System.Windows.Forms.PictureBox ImageAnswer;
    private System.Windows.Forms.GroupBox   ImageQuestion;
    private System.Windows.Forms.Label      AccountTypeAnswer;
    private System.Windows.Forms.Label      AccountTypeQuestion;
    private System.Windows.Forms.CheckBox   ReadAndSearchPermission;
    private System.Windows.Forms.CheckBox   EditPermission;
    private System.Windows.Forms.CheckBox   DeletePermission;
    private System.Windows.Forms.CheckBox   TestPermission;
    private System.Windows.Forms.CheckBox   UnlockLicensesPermission;
    private System.Windows.Forms.CheckBox   CreatePermission;
    private System.Windows.Forms.GroupBox   PermissionsQuestion;
    private System.Windows.Forms.Label      PasswordAnswer;
    private System.Windows.Forms.Label      PasswordQuestion;
    private System.Windows.Forms.Label      UsernameAnswer;
    private System.Windows.Forms.Label      UsernameQuestion;
    private System.Windows.Forms.GroupBox   AccountQuestion;
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