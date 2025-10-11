using System.ComponentModel;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class Licenses {
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
        components   = new System.ComponentModel.Container();
        MenuStrip    = new System.Windows.Forms.MenuStrip();
        SearchBox    = new System.Windows.Forms.TextBox();
        SearchFilter = new System.Windows.Forms.ComboBox();
        LicenseList  = new System.Windows.Forms.DataGridView();
        RefreshList  = new System.Windows.Forms.Button();
        LicenseListMenuStrip = new System.Windows.Forms.ContextMenuStrip(
            components
        );
        LicenseInformationOption = new System.Windows.Forms.ToolStripMenuItem();
        LicenseUpdateOption      = new System.Windows.Forms.ToolStripMenuItem();
        LicenseDeleteOption      = new System.Windows.Forms.ToolStripMenuItem();
        LicenseRenewOption       = new System.Windows.Forms.ToolStripMenuItem();
        LicenseReplaceOption     = new System.Windows.Forms.ToolStripMenuItem();
        ReplaceDamageOption  = new System.Windows.Forms.ToolStripMenuItem();
        ReplaceLostOption    = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize) LicenseList).BeginInit();
        LicenseListMenuStrip.SuspendLayout();
        SuspendLayout();
        //
        // MenuStrip
        //
        MenuStrip.AutoSize = false;
        MenuStrip.Location = new System.Drawing.Point(
            0,
            0
        );
        MenuStrip.Name = "MenuStrip";
        MenuStrip.Size = new System.Drawing.Size(
            984,
            0
        );
        MenuStrip.TabIndex = 0;
        MenuStrip.Text     = "MenuStrip";
        //
        // SearchBox
        //
        SearchBox.Location = new System.Drawing.Point(
            20,
            50
        );
        SearchBox.Multiline = true;
        SearchBox.Name      = "SearchBox";
        SearchBox.Size = new System.Drawing.Size(
            700,
            25
        );
        SearchBox.TabIndex    =  0;
        SearchBox.TextChanged += SearchBox_TextChanged;
        SearchBox.KeyDown     += disableNewLine_KeyDown;
        //
        // SearchFilter
        //
        SearchFilter.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
        SearchFilter.FormattingEnabled = true;
        SearchFilter.Location = new System.Drawing.Point(
            730,
            51
        );
        SearchFilter.Name = "SearchFilter";
        SearchFilter.Size = new System.Drawing.Size(
            195,
            23
        );
        SearchFilter.TabIndex             =  1;
        SearchFilter.SelectedIndexChanged += SearchFilter_SelectedIndexChanged;
        //
        // LicenseList
        //
        LicenseList.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        LicenseList.BackgroundColor             = System.Drawing.Color.Gray;
        LicenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        LicenseList.Location = new System.Drawing.Point(
            20,
            90
        );
        LicenseList.MultiSelect = false;
        LicenseList.Name        = "LicenseList";
        LicenseList.ReadOnly    = true;
        LicenseList.Size = new System.Drawing.Size(
            940,
            550
        );
        LicenseList.TabIndex = 3;
        LicenseList.Text     = "Client List";
        //
        // RefreshList
        //
        RefreshList.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        RefreshList.Location = new System.Drawing.Point(
            935,
            50
        );
        RefreshList.Name = "RefreshList";
        RefreshList.Size = new System.Drawing.Size(
            25,
            25
        );
        RefreshList.TabIndex                =  2;
        RefreshList.TextAlign               =  System.Drawing.ContentAlignment.MiddleLeft;
        RefreshList.UseVisualStyleBackColor =  true;
        RefreshList.Click                   += RefreshList_Click;
        //
        // LicenseListMenuStrip
        //
        LicenseListMenuStrip.Items.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                LicenseInformationOption,
                LicenseUpdateOption,
                LicenseDeleteOption,
                LicenseRenewOption,
                LicenseReplaceOption
            }
        );
        LicenseListMenuStrip.Name = "LicenseListMenuStrip";
        LicenseListMenuStrip.Size = new System.Drawing.Size(
            181,
            136
        );
        //
        // LicenseInformationOption
        //
        LicenseInformationOption.Name = "LicenseInformationOption";
        LicenseInformationOption.Size = new System.Drawing.Size(
            180,
            22
        );
        LicenseInformationOption.Text  =  "Information";
        LicenseInformationOption.Click += LicenseInformationOption_Click;
        //
        // LicenseUpdateOption
        //
        LicenseUpdateOption.Name = "LicenseUpdateOption";
        LicenseUpdateOption.Size = new System.Drawing.Size(
            180,
            22
        );
        LicenseUpdateOption.Text  =  "Update";
        LicenseUpdateOption.Click += LicenseUpdateOption_Click;
        //
        // LicenseDeleteOption
        //
        LicenseDeleteOption.Name = "LicenseDeleteOption";
        LicenseDeleteOption.Size = new System.Drawing.Size(
            180,
            22
        );
        LicenseDeleteOption.Text  =  "Delete";
        LicenseDeleteOption.Click += LicenseDeleteOption_Click;
        //
        // LicenseRenewOption
        //
        LicenseRenewOption.Name = "LicenseRenewOption";
        LicenseRenewOption.Size = new System.Drawing.Size(
            180,
            22
        );
        LicenseRenewOption.Text  =  "Renew";
        LicenseRenewOption.Click += LicenseRenewOption_Click;
        //
        // LicenseReplaceOption
        //
        LicenseReplaceOption.DropDownItems.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                ReplaceDamageOption,
                ReplaceLostOption
            }
        );
        LicenseReplaceOption.Name = "LicenseReplaceOption";
        LicenseReplaceOption.Size = new System.Drawing.Size(
            180,
            22
        );
        LicenseReplaceOption.Text  =  "Replace";
        //
        // ReplaceDamageOption
        //
        ReplaceDamageOption.Name = "ReplaceDamageOption";
        ReplaceDamageOption.Size = new System.Drawing.Size(
            180,
            22
        );
        ReplaceDamageOption.Text  =  "Damage";
        ReplaceDamageOption.Click += ReplaceDamageOption_Click;
        //
        // ReplaceLostOption
        //
        ReplaceLostOption.Name = "ReplaceLostOption";
        ReplaceLostOption.Size = new System.Drawing.Size(
            180,
            22
        );
        ReplaceLostOption.Text = "Lost";
        ReplaceLostOption.Click += ReplaceLostOption_Click;
        //
        // Licenses
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DimGray;
        ClientSize = new System.Drawing.Size(
            984,
            661
        );
        Controls.Add(
            RefreshList
        );
        Controls.Add(
            LicenseList
        );
        Controls.Add(
            SearchFilter
        );
        Controls.Add(
            SearchBox
        );
        Controls.Add(
            MenuStrip
        );
        KeyPreview    =  true;
        MainMenuStrip =  MenuStrip;
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "License Management";
        KeyDown       += Licenses_KeyDown;
        ((System.ComponentModel.ISupportInitialize) LicenseList).EndInit();
        LicenseListMenuStrip.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem ReplaceDamageOption;
    private System.Windows.Forms.ToolStripMenuItem ReplaceLostOption;
    private System.Windows.Forms.ToolStripMenuItem LicenseReplaceOption;
    private System.Windows.Forms.ToolStripMenuItem LicenseInformationOption;
    private System.Windows.Forms.ToolStripMenuItem LicenseUpdateOption;
    private System.Windows.Forms.ToolStripMenuItem LicenseDeleteOption;
    private System.Windows.Forms.ToolStripMenuItem LicenseRenewOption;
    private System.Windows.Forms.ContextMenuStrip  LicenseListMenuStrip;
    private System.Windows.Forms.Button            RefreshList;
    private System.Windows.Forms.DataGridView      LicenseList;
    private System.Windows.Forms.ComboBox          SearchFilter;
    private System.Windows.Forms.TextBox           SearchBox;
    private System.Windows.Forms.MenuStrip         MenuStrip;

    #endregion
}