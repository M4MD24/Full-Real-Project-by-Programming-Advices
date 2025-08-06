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
        components                      = new System.ComponentModel.Container();
        PermissionsQuestion             = new System.Windows.Forms.GroupBox();
        TestPermission                  = new System.Windows.Forms.CheckBox();
        RetestPermission                = new System.Windows.Forms.CheckBox();
        UnlockLicensesPermission        = new System.Windows.Forms.CheckBox();
        ReadAndSearchPermission         = new System.Windows.Forms.CheckBox();
        DeletePermission                = new System.Windows.Forms.CheckBox();
        EditPermission                  = new System.Windows.Forms.CheckBox();
        CreatePermission                = new System.Windows.Forms.CheckBox();
        FullNameQuestion                = new System.Windows.Forms.GroupBox();
        FourthNameAnswer                = new System.Windows.Forms.TextBox();
        FourthNameQuestion              = new System.Windows.Forms.Label();
        ThirdNameAnswer                 = new System.Windows.Forms.TextBox();
        ThirdNameQuestion               = new System.Windows.Forms.Label();
        SecondNameAnswer                = new System.Windows.Forms.TextBox();
        SecondNameQuestion              = new System.Windows.Forms.Label();
        FirstNameAnswer                 = new System.Windows.Forms.TextBox();
        FirstNameQuestion               = new System.Windows.Forms.Label();
        NationalNumberQuestion          = new System.Windows.Forms.Label();
        DataOfBirthDialog               = new System.Windows.Forms.ColorDialog();
        NationalNumberAnswer            = new System.Windows.Forms.TextBox();
        DateOfBirthAnswer               = new System.Windows.Forms.DateTimePicker();
        DateOfBirthQuestion             = new System.Windows.Forms.Label();
        AddressQuestion                 = new System.Windows.Forms.Label();
        AddressAnswer                   = new System.Windows.Forms.TextBox();
        ContactInformationQuestion      = new System.Windows.Forms.GroupBox();
        MobileNumberQuestion            = new System.Windows.Forms.GroupBox();
        CountryNameMobileNumberQuestion = new System.Windows.Forms.Label();
        CountryNameMobileNumberAnswer   = new System.Windows.Forms.ComboBox();
        ContactNumberAnswer             = new System.Windows.Forms.TextBox();
        ContactNumberQuestion           = new System.Windows.Forms.Label();
        EmailAnswer                     = new System.Windows.Forms.TextBox();
        EmailQuestion                   = new System.Windows.Forms.Label();
        CountryNameQuestion             = new System.Windows.Forms.Label();
        CountryNameAnswer               = new System.Windows.Forms.ComboBox();
        AccountQuestion                 = new System.Windows.Forms.GroupBox();
        AccountTypeQuestion             = new System.Windows.Forms.Label();
        PasswordAnswer                  = new System.Windows.Forms.TextBox();
        AccountTypeAnswer               = new System.Windows.Forms.ComboBox();
        PasswordQuestion                = new System.Windows.Forms.Label();
        UsernameAnswer                  = new System.Windows.Forms.TextBox();
        UsernameQuestion                = new System.Windows.Forms.Label();
        Submit                          = new System.Windows.Forms.Button();
        ErrorProvider = new System.Windows.Forms.ErrorProvider(
            components
        );
        PermissionsQuestion.SuspendLayout();
        FullNameQuestion.SuspendLayout();
        ContactInformationQuestion.SuspendLayout();
        MobileNumberQuestion.SuspendLayout();
        AccountQuestion.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).BeginInit();
        SuspendLayout();
        //
        // PermissionsQuestion
        //
        PermissionsQuestion.Controls.Add(
            TestPermission
        );
        PermissionsQuestion.Controls.Add(
            RetestPermission
        );
        PermissionsQuestion.Controls.Add(
            UnlockLicensesPermission
        );
        PermissionsQuestion.Controls.Add(
            ReadAndSearchPermission
        );
        PermissionsQuestion.Controls.Add(
            DeletePermission
        );
        PermissionsQuestion.Controls.Add(
            EditPermission
        );
        PermissionsQuestion.Controls.Add(
            CreatePermission
        );
        PermissionsQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        PermissionsQuestion.Location = new System.Drawing.Point(
            20,
            100
        );
        PermissionsQuestion.Name = "PermissionsQuestion";
        PermissionsQuestion.Size = new System.Drawing.Size(
            400,
            95
        );
        PermissionsQuestion.TabIndex = 30;
        PermissionsQuestion.TabStop  = false;
        PermissionsQuestion.Text     = "Permissions";
        //
        // TestPermission
        //
        TestPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        TestPermission.Location = new System.Drawing.Point(
            20,
            60
        );
        TestPermission.Name = "TestPermission";
        TestPermission.Size = new System.Drawing.Size(
            50,
            20
        );
        TestPermission.TabIndex                = 35;
        TestPermission.Text                    = "Test";
        TestPermission.UseVisualStyleBackColor = true;
        //
        // RetestPermission
        //
        RetestPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        RetestPermission.Location = new System.Drawing.Point(
            80,
            60
        );
        RetestPermission.Name = "RetestPermission";
        RetestPermission.Size = new System.Drawing.Size(
            65,
            20
        );
        RetestPermission.TabIndex                = 36;
        RetestPermission.Text                    = "Retest";
        RetestPermission.UseVisualStyleBackColor = true;
        //
        // UnlockLicensesPermission
        //
        UnlockLicensesPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        UnlockLicensesPermission.Location = new System.Drawing.Point(
            155,
            60
        );
        UnlockLicensesPermission.Name = "UnlockLicensesPermission";
        UnlockLicensesPermission.Size = new System.Drawing.Size(
            120,
            20
        );
        UnlockLicensesPermission.TabIndex                = 37;
        UnlockLicensesPermission.Text                    = "Unlock Licenses";
        UnlockLicensesPermission.UseVisualStyleBackColor = true;
        //
        // ReadAndSearchPermission
        //
        ReadAndSearchPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        ReadAndSearchPermission.Location = new System.Drawing.Point(
            95,
            30
        );
        ReadAndSearchPermission.Name = "ReadAndSearchPermission";
        ReadAndSearchPermission.Size = new System.Drawing.Size(
            110,
            20
        );
        ReadAndSearchPermission.TabIndex                = 32;
        ReadAndSearchPermission.Text                    = "Read && Search";
        ReadAndSearchPermission.UseVisualStyleBackColor = true;
        //
        // DeletePermission
        //
        DeletePermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        DeletePermission.Location = new System.Drawing.Point(
            275,
            30
        );
        DeletePermission.Name = "DeletePermission";
        DeletePermission.Size = new System.Drawing.Size(
            65,
            20
        );
        DeletePermission.TabIndex                = 34;
        DeletePermission.Text                    = "Delete";
        DeletePermission.UseVisualStyleBackColor = true;
        //
        // EditPermission
        //
        EditPermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        EditPermission.Location = new System.Drawing.Point(
            215,
            30
        );
        EditPermission.Name = "EditPermission";
        EditPermission.Size = new System.Drawing.Size(
            50,
            20
        );
        EditPermission.TabIndex                = 33;
        EditPermission.Text                    = "Edit";
        EditPermission.UseVisualStyleBackColor = true;
        //
        // CreatePermission
        //
        CreatePermission.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        CreatePermission.Location = new System.Drawing.Point(
            20,
            30
        );
        CreatePermission.Name = "CreatePermission";
        CreatePermission.Size = new System.Drawing.Size(
            65,
            20
        );
        CreatePermission.TabIndex                = 31;
        CreatePermission.Text                    = "Create";
        CreatePermission.UseVisualStyleBackColor = true;
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
            55
        );
        FullNameQuestion.Name = "FullNameQuestion";
        FullNameQuestion.Size = new System.Drawing.Size(
            480,
            180
        );
        FullNameQuestion.TabIndex = 2;
        FullNameQuestion.TabStop  = false;
        FullNameQuestion.Text     = "Full Name";
        //
        // FourthNameAnswer
        //
        FourthNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        FourthNameAnswer.Location = new System.Drawing.Point(
            160,
            135
        );
        FourthNameAnswer.MaxLength = 20;
        FourthNameAnswer.Multiline = true;
        FourthNameAnswer.Name      = "FourthNameAnswer";
        FourthNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        FourthNameAnswer.TabIndex =  10;
        FourthNameAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // FourthNameQuestion
        //
        FourthNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        FourthNameQuestion.Location = new System.Drawing.Point(
            20,
            135
        );
        FourthNameQuestion.Name = "FourthNameQuestion";
        FourthNameQuestion.Size = new System.Drawing.Size(
            115,
            25
        );
        FourthNameQuestion.TabIndex = 9;
        FourthNameQuestion.Text     = "Fourth Name:";
        //
        // ThirdNameAnswer
        //
        ThirdNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        ThirdNameAnswer.Location = new System.Drawing.Point(
            160,
            100
        );
        ThirdNameAnswer.MaxLength = 20;
        ThirdNameAnswer.Multiline = true;
        ThirdNameAnswer.Name      = "ThirdNameAnswer";
        ThirdNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        ThirdNameAnswer.TabIndex =  8;
        ThirdNameAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // ThirdNameQuestion
        //
        ThirdNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        ThirdNameQuestion.Location = new System.Drawing.Point(
            20,
            100
        );
        ThirdNameQuestion.Name = "ThirdNameQuestion";
        ThirdNameQuestion.Size = new System.Drawing.Size(
            105,
            25
        );
        ThirdNameQuestion.TabIndex = 7;
        ThirdNameQuestion.Text     = "Third Name:";
        //
        // SecondNameAnswer
        //
        SecondNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        SecondNameAnswer.Location = new System.Drawing.Point(
            160,
            65
        );
        SecondNameAnswer.MaxLength = 20;
        SecondNameAnswer.Multiline = true;
        SecondNameAnswer.Name      = "SecondNameAnswer";
        SecondNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        SecondNameAnswer.TabIndex =  6;
        SecondNameAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // SecondNameQuestion
        //
        SecondNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        SecondNameQuestion.Location = new System.Drawing.Point(
            20,
            65
        );
        SecondNameQuestion.Name = "SecondNameQuestion";
        SecondNameQuestion.Size = new System.Drawing.Size(
            120,
            25
        );
        SecondNameQuestion.TabIndex = 5;
        SecondNameQuestion.Text     = "Second Name:";
        //
        // FirstNameAnswer
        //
        FirstNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        FirstNameAnswer.Location = new System.Drawing.Point(
            160,
            30
        );
        FirstNameAnswer.MaxLength = 20;
        FirstNameAnswer.Multiline = true;
        FirstNameAnswer.Name      = "FirstNameAnswer";
        FirstNameAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        FirstNameAnswer.TabIndex =  4;
        FirstNameAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // FirstNameQuestion
        //
        FirstNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        FirstNameQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        FirstNameQuestion.Name = "FirstNameQuestion";
        FirstNameQuestion.Size = new System.Drawing.Size(
            100,
            25
        );
        FirstNameQuestion.TabIndex = 3;
        FirstNameQuestion.Text     = "First Name:";
        //
        // NationalNumberQuestion
        //
        NationalNumberQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        NationalNumberQuestion.Location = new System.Drawing.Point(
            20,
            20
        );
        NationalNumberQuestion.Name = "NationalNumberQuestion";
        NationalNumberQuestion.Size = new System.Drawing.Size(
            150,
            25
        );
        NationalNumberQuestion.TabIndex = 0;
        NationalNumberQuestion.Text     = "National Number:";
        //
        // NationalNumberAnswer
        //
        NationalNumberAnswer.Location = new System.Drawing.Point(
            180,
            20
        );
        NationalNumberAnswer.MaxLength = 30;
        NationalNumberAnswer.Multiline = true;
        NationalNumberAnswer.Name      = "NationalNumberAnswer";
        NationalNumberAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        NationalNumberAnswer.TabIndex =  1;
        NationalNumberAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // DateOfBirthAnswer
        //
        DateOfBirthAnswer.Location = new System.Drawing.Point(
            180,
            246
        );
        DateOfBirthAnswer.Name = "DateOfBirthAnswer";
        DateOfBirthAnswer.Size = new System.Drawing.Size(
            300,
            23
        );
        DateOfBirthAnswer.TabIndex = 12;
        //
        // DateOfBirthQuestion
        //
        DateOfBirthQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        DateOfBirthQuestion.Location = new System.Drawing.Point(
            20,
            245
        );
        DateOfBirthQuestion.Name = "DateOfBirthQuestion";
        DateOfBirthQuestion.Size = new System.Drawing.Size(
            135,
            25
        );
        DateOfBirthQuestion.TabIndex = 11;
        DateOfBirthQuestion.Text     = "Date of Birth:";
        //
        // AddressQuestion
        //
        AddressQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        AddressQuestion.Location = new System.Drawing.Point(
            20,
            280
        );
        AddressQuestion.Name = "AddressQuestion";
        AddressQuestion.Size = new System.Drawing.Size(
            90,
            25
        );
        AddressQuestion.TabIndex = 13;
        AddressQuestion.Text     = "Address:";
        //
        // AddressAnswer
        //
        AddressAnswer.Location = new System.Drawing.Point(
            180,
            280
        );
        AddressAnswer.MaxLength = 200;
        AddressAnswer.Multiline = true;
        AddressAnswer.Name      = "AddressAnswer";
        AddressAnswer.Size = new System.Drawing.Size(
            300,
            80
        );
        AddressAnswer.TabIndex =  14;
        AddressAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // ContactInformationQuestion
        //
        ContactInformationQuestion.Controls.Add(
            MobileNumberQuestion
        );
        ContactInformationQuestion.Controls.Add(
            EmailAnswer
        );
        ContactInformationQuestion.Controls.Add(
            EmailQuestion
        );
        ContactInformationQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        ContactInformationQuestion.Location = new System.Drawing.Point(
            20,
            370
        );
        ContactInformationQuestion.Name = "ContactInformationQuestion";
        ContactInformationQuestion.Size = new System.Drawing.Size(
            480,
            195
        );
        ContactInformationQuestion.TabIndex = 15;
        ContactInformationQuestion.TabStop  = false;
        ContactInformationQuestion.Text     = "Contact Information";
        //
        // MobileNumberQuestion
        //
        MobileNumberQuestion.Controls.Add(
            CountryNameMobileNumberQuestion
        );
        MobileNumberQuestion.Controls.Add(
            CountryNameMobileNumberAnswer
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
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        MobileNumberQuestion.Location = new System.Drawing.Point(
            20,
            28
        );
        MobileNumberQuestion.Name = "MobileNumberQuestion";
        MobileNumberQuestion.Size = new System.Drawing.Size(
            440,
            110
        );
        MobileNumberQuestion.TabIndex = 16;
        MobileNumberQuestion.TabStop  = false;
        MobileNumberQuestion.Text     = "Mobile Number";
        //
        // CountryNameMobileNumberQuestion
        //
        CountryNameMobileNumberQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        CountryNameMobileNumberQuestion.Location = new System.Drawing.Point(
            20,
            65
        );
        CountryNameMobileNumberQuestion.Name = "CountryNameMobileNumberQuestion";
        CountryNameMobileNumberQuestion.Size = new System.Drawing.Size(
            130,
            25
        );
        CountryNameMobileNumberQuestion.TabIndex = 19;
        CountryNameMobileNumberQuestion.Text     = "Country Name:";
        //
        // CountryNameMobileNumberAnswer
        //
        CountryNameMobileNumberAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        CountryNameMobileNumberAnswer.FormattingEnabled = true;
        CountryNameMobileNumberAnswer.Location = new System.Drawing.Point(
            175,
            66
        );
        CountryNameMobileNumberAnswer.Name = "CountryNameMobileNumberAnswer";
        CountryNameMobileNumberAnswer.Size = new System.Drawing.Size(
            245,
            23
        );
        CountryNameMobileNumberAnswer.TabIndex = 20;
        //
        // ContactNumberAnswer
        //
        ContactNumberAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        ContactNumberAnswer.Location = new System.Drawing.Point(
            175,
            30
        );
        ContactNumberAnswer.MaxLength = 20;
        ContactNumberAnswer.Multiline = true;
        ContactNumberAnswer.Name      = "ContactNumberAnswer";
        ContactNumberAnswer.Size = new System.Drawing.Size(
            245,
            25
        );
        ContactNumberAnswer.TabIndex =  18;
        ContactNumberAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // ContactNumberQuestion
        //
        ContactNumberQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        ContactNumberQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        ContactNumberQuestion.Name = "ContactNumberQuestion";
        ContactNumberQuestion.Size = new System.Drawing.Size(
            145,
            25
        );
        ContactNumberQuestion.TabIndex = 17;
        ContactNumberQuestion.Text     = "Contact Number:";
        //
        // EmailAnswer
        //
        EmailAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        EmailAnswer.Location = new System.Drawing.Point(
            160,
            150
        );
        EmailAnswer.MaxLength = 40;
        EmailAnswer.Multiline = true;
        EmailAnswer.Name      = "EmailAnswer";
        EmailAnswer.Size = new System.Drawing.Size(
            300,
            25
        );
        EmailAnswer.TabIndex =  22;
        EmailAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // EmailQuestion
        //
        EmailQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        EmailQuestion.Location = new System.Drawing.Point(
            20,
            150
        );
        EmailQuestion.Name = "EmailQuestion";
        EmailQuestion.Size = new System.Drawing.Size(
            60,
            25
        );
        EmailQuestion.TabIndex = 21;
        EmailQuestion.Text     = "Email:";
        //
        // CountryNameQuestion
        //
        CountryNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        CountryNameQuestion.Location = new System.Drawing.Point(
            20,
            575
        );
        CountryNameQuestion.Name = "CountryNameQuestion";
        CountryNameQuestion.Size = new System.Drawing.Size(
            130,
            25
        );
        CountryNameQuestion.TabIndex = 23;
        CountryNameQuestion.Text     = "Country Name:";
        //
        // CountryNameAnswer
        //
        CountryNameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        CountryNameAnswer.FormattingEnabled = true;
        CountryNameAnswer.Location = new System.Drawing.Point(
            180,
            576
        );
        CountryNameAnswer.Name = "CountryNameAnswer";
        CountryNameAnswer.Size = new System.Drawing.Size(
            300,
            23
        );
        CountryNameAnswer.TabIndex = 24;
        //
        // AccountQuestion
        //
        AccountQuestion.Controls.Add(
            AccountTypeQuestion
        );
        AccountQuestion.Controls.Add(
            PasswordAnswer
        );
        AccountQuestion.Controls.Add(
            AccountTypeAnswer
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
        AccountQuestion.Controls.Add(
            PermissionsQuestion
        );
        AccountQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        AccountQuestion.Location = new System.Drawing.Point(
            520,
            20
        );
        AccountQuestion.Name = "AccountQuestion";
        AccountQuestion.Size = new System.Drawing.Size(
            440,
            250
        );
        AccountQuestion.TabIndex = 25;
        AccountQuestion.TabStop  = false;
        AccountQuestion.Text     = "Account";
        //
        // AccountTypeQuestion
        //
        AccountTypeQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        AccountTypeQuestion.Location = new System.Drawing.Point(
            20,
            205
        );
        AccountTypeQuestion.Name = "AccountTypeQuestion";
        AccountTypeQuestion.Size = new System.Drawing.Size(
            120,
            25
        );
        AccountTypeQuestion.TabIndex = 35;
        AccountTypeQuestion.Text     = "Account Type:";
        //
        // PasswordAnswer
        //
        PasswordAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        PasswordAnswer.Location = new System.Drawing.Point(
            150,
            65
        );
        PasswordAnswer.MaxLength = 30;
        PasswordAnswer.Multiline = true;
        PasswordAnswer.Name      = "PasswordAnswer";
        PasswordAnswer.Size = new System.Drawing.Size(
            270,
            25
        );
        PasswordAnswer.TabIndex =  29;
        PasswordAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // AccountTypeAnswer
        //
        AccountTypeAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        AccountTypeAnswer.FormattingEnabled = true;
        AccountTypeAnswer.Location = new System.Drawing.Point(
            150,
            206
        );
        AccountTypeAnswer.Name = "AccountTypeAnswer";
        AccountTypeAnswer.Size = new System.Drawing.Size(
            270,
            23
        );
        AccountTypeAnswer.TabIndex = 36;
        //
        // PasswordQuestion
        //
        PasswordQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        PasswordQuestion.Location = new System.Drawing.Point(
            20,
            65
        );
        PasswordQuestion.Name = "PasswordQuestion";
        PasswordQuestion.Size = new System.Drawing.Size(
            95,
            25
        );
        PasswordQuestion.TabIndex = 28;
        PasswordQuestion.Text     = "Passowrd:";
        //
        // UsernameAnswer
        //
        UsernameAnswer.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        UsernameAnswer.Location = new System.Drawing.Point(
            150,
            30
        );
        UsernameAnswer.MaxLength = 30;
        UsernameAnswer.Multiline = true;
        UsernameAnswer.Name      = "UsernameAnswer";
        UsernameAnswer.Size = new System.Drawing.Size(
            270,
            25
        );
        UsernameAnswer.TabIndex =  27;
        UsernameAnswer.KeyDown  += DisableNewLine_KeyDown;
        //
        // UsernameQuestion
        //
        UsernameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        UsernameQuestion.Location = new System.Drawing.Point(
            20,
            30
        );
        UsernameQuestion.Name = "UsernameQuestion";
        UsernameQuestion.Size = new System.Drawing.Size(
            95,
            25
        );
        UsernameQuestion.TabIndex = 26;
        UsernameQuestion.Text     = "Username:";
        //
        // Submit
        //
        Submit.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        Submit.Location = new System.Drawing.Point(
            670,
            290
        );
        Submit.Name = "Submit";
        Submit.Size = new System.Drawing.Size(
            140,
            50
        );
        Submit.TabIndex                =  37;
        Submit.Text                    =  "Submit";
        Submit.UseVisualStyleBackColor =  true;
        Submit.Click                   += Submit_Click;
        //
        // ErrorProvider
        //
        ErrorProvider.ContainerControl = this;
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
            984,
            621
        );
        Controls.Add(
            Submit
        );
        Controls.Add(
            AccountQuestion
        );
        Controls.Add(
            CountryNameQuestion
        );
        Controls.Add(
            CountryNameAnswer
        );
        Controls.Add(
            ContactInformationQuestion
        );
        Controls.Add(
            AddressAnswer
        );
        Controls.Add(
            AddressQuestion
        );
        Controls.Add(
            DateOfBirthQuestion
        );
        Controls.Add(
            DateOfBirthAnswer
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
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        PermissionsQuestion.ResumeLayout(
            false
        );
        FullNameQuestion.ResumeLayout(
            false
        );
        FullNameQuestion.PerformLayout();
        ContactInformationQuestion.ResumeLayout(
            false
        );
        ContactInformationQuestion.PerformLayout();
        MobileNumberQuestion.ResumeLayout(
            false
        );
        MobileNumberQuestion.PerformLayout();
        AccountQuestion.ResumeLayout(
            false
        );
        AccountQuestion.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).EndInit();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ErrorProvider  ErrorProvider;
    private System.Windows.Forms.CheckBox       TestPermission;
    private System.Windows.Forms.CheckBox       RetestPermission;
    private System.Windows.Forms.CheckBox       UnlockLicensesPermission;
    private System.Windows.Forms.Label          AccountTypeQuestion;
    private System.Windows.Forms.ComboBox       AccountTypeAnswer;
    private System.Windows.Forms.Button         Submit;
    private System.Windows.Forms.CheckBox       ReadAndSearchPermission;
    private System.Windows.Forms.CheckBox       DeletePermission;
    private System.Windows.Forms.CheckBox       CreatePermission;
    private System.Windows.Forms.TextBox        PasswordAnswer;
    private System.Windows.Forms.Label          PasswordQuestion;
    private System.Windows.Forms.GroupBox       AccountQuestion;
    private System.Windows.Forms.TextBox        UsernameAnswer;
    private System.Windows.Forms.Label          UsernameQuestion;
    private System.Windows.Forms.Label          CountryNameQuestion;
    private System.Windows.Forms.ComboBox       CountryNameAnswer;
    private System.Windows.Forms.Label          CountryNameMobileNumberQuestion;
    private System.Windows.Forms.ComboBox       CountryNameMobileNumberAnswer;
    private System.Windows.Forms.GroupBox       MobileNumberQuestion;
    private System.Windows.Forms.TextBox        ContactNumberAnswer;
    private System.Windows.Forms.Label          ContactNumberQuestion;
    private System.Windows.Forms.TextBox        EmailAnswer;
    private System.Windows.Forms.Label          EmailQuestion;
    private System.Windows.Forms.GroupBox       ContactInformationQuestion;
    private System.Windows.Forms.TextBox        AddressAnswer;
    private System.Windows.Forms.Label          AddressQuestion;
    private System.Windows.Forms.CheckBox       EditPermission;
    private System.Windows.Forms.Label          DateOfBirthQuestion;
    private System.Windows.Forms.DateTimePicker DateOfBirthAnswer;
    private System.Windows.Forms.TextBox        SecondNameAnswer;
    private System.Windows.Forms.Label          SecondNameQuestion;
    private System.Windows.Forms.TextBox        ThirdNameAnswer;
    private System.Windows.Forms.Label          ThirdNameQuestion;
    private System.Windows.Forms.TextBox        FourthNameAnswer;
    private System.Windows.Forms.Label          FourthNameQuestion;
    private System.Windows.Forms.TextBox        FirstNameAnswer;
    private System.Windows.Forms.Label          FirstNameQuestion;
    private System.Windows.Forms.TextBox        NationalNumberAnswer;
    private System.Windows.Forms.ColorDialog    DataOfBirthDialog;
    private System.Windows.Forms.Label          NationalNumberQuestion;
    private System.Windows.Forms.GroupBox       PermissionsQuestion;
    private System.Windows.Forms.GroupBox       FullNameQuestion;

    #endregion
}