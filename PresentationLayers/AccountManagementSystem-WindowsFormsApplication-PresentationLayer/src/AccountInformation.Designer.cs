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
        Permissions = new System.Windows.Forms.GroupBox();
        FullName    = new System.Windows.Forms.GroupBox();
        SuspendLayout();
        // 
        // Permissions
        // 
        Permissions.Location = new System.Drawing.Point(
            49,
            377
        );
        Permissions.Name = "Permissions";
        Permissions.Size = new System.Drawing.Size(
            200,
            100
        );
        Permissions.TabIndex = 1;
        Permissions.TabStop  = false;
        Permissions.Text     = "Permissions";
        // 
        // FullName
        // 
        FullName.Location = new System.Drawing.Point(
            32,
            92
        );
        FullName.Name = "FullName";
        FullName.Size = new System.Drawing.Size(
            529,
            100
        );
        FullName.TabIndex = 2;
        FullName.TabStop  = false;
        FullName.Text     = "Full Name";
        // 
        // AccountInformation
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
            FullName
        );
        Controls.Add(
            Permissions
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Account Information";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.GroupBox FullName;

    private System.Windows.Forms.GroupBox Permissions;

    #endregion
}