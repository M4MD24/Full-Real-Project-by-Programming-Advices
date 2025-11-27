using System.ComponentModel;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class Test {
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
        components           = new System.ComponentModel.Container();
        Submit               = new System.Windows.Forms.Button();
        TestDateTimeAnswer   = new System.Windows.Forms.DateTimePicker();
        TestDateTimeQuestion = new System.Windows.Forms.Label();
        Clear                = new System.Windows.Forms.Button();
        ErrorProvider = new System.Windows.Forms.ErrorProvider(
            components
        );
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // Submit
        // 
        Submit.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        Submit.Location = new System.Drawing.Point(
            180,
            70
        );
        Submit.Name = "Submit";
        Submit.Size = new System.Drawing.Size(
            100,
            40
        );
        Submit.TabIndex                =  0;
        Submit.Text                    =  "Submit";
        Submit.UseVisualStyleBackColor =  true;
        Submit.Click                   += Submit_Click;
        // 
        // TestDateTimeAnswer
        // 
        TestDateTimeAnswer.Location = new System.Drawing.Point(
            140,
            20
        );
        TestDateTimeAnswer.Name = "TestDateTimeAnswer";
        TestDateTimeAnswer.Size = new System.Drawing.Size(
            400,
            30
        );
        TestDateTimeAnswer.TabIndex = 3;
        // 
        // TestDateTimeQuestion
        // 
        TestDateTimeQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        TestDateTimeQuestion.Location = new System.Drawing.Point(
            20,
            20
        );
        TestDateTimeQuestion.Name = "TestDateTimeQuestion";
        TestDateTimeQuestion.Size = new System.Drawing.Size(
            110,
            30
        );
        TestDateTimeQuestion.TabIndex = 4;
        TestDateTimeQuestion.Text     = "DateTime:";
        // 
        // Clear
        // 
        Clear.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        Clear.Location = new System.Drawing.Point(
            300,
            70
        );
        Clear.Name = "Clear";
        Clear.Size = new System.Drawing.Size(
            100,
            40
        );
        Clear.TabIndex                =  5;
        Clear.Text                    =  "Clear";
        Clear.UseVisualStyleBackColor =  true;
        Clear.Click                   += Clear_Click;
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // Test
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            9F,
            23F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            562,
            128
        );
        Controls.Add(
            Clear
        );
        Controls.Add(
            TestDateTimeQuestion
        );
        Controls.Add(
            TestDateTimeAnswer
        );
        Controls.Add(
            Submit
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize) ErrorProvider).EndInit();
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.ErrorProvider ErrorProvider;

    private System.Windows.Forms.Button Clear;

    private System.Windows.Forms.Label TestDateTimeQuestion;

    private System.Windows.Forms.DateTimePicker TestDateTimeAnswer;

    private System.Windows.Forms.Button Submit;

    #endregion
}