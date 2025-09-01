using System.ComponentModel;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class Shortcuts {
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
        ShortcutList = new System.Windows.Forms.ListView();
        SuspendLayout();
        // 
        // ShortcutList
        // 
        ShortcutList.BackColor     = System.Drawing.Color.Silver;
        ShortcutList.Dock          = System.Windows.Forms.DockStyle.Fill;
        ShortcutList.ForeColor     = System.Drawing.Color.Black;
        ShortcutList.FullRowSelect = true;
        ShortcutList.GridLines     = true;
        ShortcutList.HeaderStyle   = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        ShortcutList.HideSelection = true;
        ShortcutList.Location = new System.Drawing.Point(
            0,
            0
        );
        ShortcutList.MultiSelect = false;
        ShortcutList.Name        = "ShortcutList";
        ShortcutList.Size = new System.Drawing.Size(
            384,
            361
        );
        ShortcutList.TabIndex                        = 0;
        ShortcutList.TabStop                         = false;
        ShortcutList.UseCompatibleStateImageBehavior = false;
        ShortcutList.View                            = System.Windows.Forms.View.Details;
        // 
        // Shortcuts
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DimGray;
        ClientSize = new System.Drawing.Size(
            384,
            361
        );
        Controls.Add(
            ShortcutList
        );
        MaximumSize = new System.Drawing.Size(
            400,
            400
        );
        MinimumSize = new System.Drawing.Size(
            400,
            400
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Shortcuts";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.ListView ShortcutList;

    #endregion
}