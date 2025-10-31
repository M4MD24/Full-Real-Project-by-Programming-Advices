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
        Submit           = new System.Windows.Forms.Button();
        comboBox1        = new System.Windows.Forms.ComboBox();
        TestTypeQuestion = new System.Windows.Forms.Label();
        dateTimePicker1  = new System.Windows.Forms.DateTimePicker();
        label1           = new System.Windows.Forms.Label();
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
            230,
            110
        );
        Submit.Name = "Submit";
        Submit.Size = new System.Drawing.Size(
            100,
            40
        );
        Submit.TabIndex                = 0;
        Submit.Text                    = "Submit";
        Submit.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(
            140,
            20
        );
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(
            400,
            31
        );
        comboBox1.TabIndex = 1;
        // 
        // TestTypeQuestion
        // 
        TestTypeQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        TestTypeQuestion.Location = new System.Drawing.Point(
            20,
            20
        );
        TestTypeQuestion.Name = "TestTypeQuestion";
        TestTypeQuestion.Size = new System.Drawing.Size(
            65,
            30
        );
        TestTypeQuestion.TabIndex = 2;
        TestTypeQuestion.Text     = "Type:";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new System.Drawing.Point(
            140,
            60
        );
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(
            400,
            30
        );
        dateTimePicker1.TabIndex = 3;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        label1.Location = new System.Drawing.Point(
            20,
            60
        );
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(
            110,
            30
        );
        label1.TabIndex = 4;
        label1.Text     = "DateTime:";
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
            168
        );
        Controls.Add(
            label1
        );
        Controls.Add(
            dateTimePicker1
        );
        Controls.Add(
            TestTypeQuestion
        );
        Controls.Add(
            comboBox1
        );
        Controls.Add(
            Submit
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Test";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.Label TestTypeQuestion;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Button Submit;

    #endregion
}