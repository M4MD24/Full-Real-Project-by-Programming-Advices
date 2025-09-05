using System.Drawing;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class AccountManagementSystem {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        AccountList  = new System.Windows.Forms.DataGridView();
        RefreshList  = new System.Windows.Forms.Button();
        AccountListMenuStrip = new System.Windows.Forms.ContextMenuStrip(
            components
        );
        AccountInformationOption = new System.Windows.Forms.ToolStripMenuItem();
        AccountUpdateOption      = new System.Windows.Forms.ToolStripMenuItem();
        AccountDeleteOption      = new System.Windows.Forms.ToolStripMenuItem();
        ChangeStatusOption       = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize) AccountList).BeginInit();
        AccountListMenuStrip.SuspendLayout();
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
        SearchBox.TabIndex    =  1;
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
        SearchFilter.TabIndex             =  2;
        SearchFilter.SelectedIndexChanged += SearchFilter_SelectedIndexChanged;
        // 
        // AccountList
        // 
        AccountList.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        AccountList.BackgroundColor             = System.Drawing.Color.Gray;
        AccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AccountList.Location = new System.Drawing.Point(
            20,
            90
        );
        AccountList.MultiSelect = false;
        AccountList.Name        = "AccountList";
        AccountList.ReadOnly    = true;
        AccountList.Size = new System.Drawing.Size(
            940,
            550
        );
        AccountList.TabIndex = 4;
        AccountList.Text     = "Account List";
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
        RefreshList.TabIndex                =  5;
        RefreshList.TextAlign               =  System.Drawing.ContentAlignment.MiddleLeft;
        RefreshList.UseVisualStyleBackColor =  true;
        RefreshList.Click                   += RefreshList_Click;
        // 
        // AccountListMenuStrip
        // 
        AccountListMenuStrip.Items.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                AccountInformationOption,
                AccountUpdateOption,
                AccountDeleteOption,
                ChangeStatusOption
            }
        );
        AccountListMenuStrip.Name = "AccountListMenuStrip";
        AccountListMenuStrip.Size = new System.Drawing.Size(
            151,
            92
        );
        // 
        // AccountInformationOption
        // 
        AccountInformationOption.Name = "AccountInformationOption";
        AccountInformationOption.Size = new System.Drawing.Size(
            150,
            22
        );
        AccountInformationOption.Text  =  "Information";
        AccountInformationOption.Click += AccountInformationOption_Click;
        // 
        // AccountUpdateOption
        // 
        AccountUpdateOption.Name = "AccountUpdateOption";
        AccountUpdateOption.Size = new System.Drawing.Size(
            150,
            22
        );
        AccountUpdateOption.Text  =  "Update";
        AccountUpdateOption.Click += AccountUpdateOption_Click;
        // 
        // AccountDeleteOption
        // 
        AccountDeleteOption.Name = "AccountDeleteOption";
        AccountDeleteOption.Size = new System.Drawing.Size(
            150,
            22
        );
        AccountDeleteOption.Text  =  "Delete";
        AccountDeleteOption.Click += AccountDeleteOption_Click;
        // 
        // ChangeStatusOption
        // 
        ChangeStatusOption.Name = "ChangeStatusOption";
        ChangeStatusOption.Size = new System.Drawing.Size(
            150,
            22
        );
        ChangeStatusOption.Text  =  "Change Status";
        ChangeStatusOption.Click += ChangeStatusOption_Click;
        // 
        // AccountManagementSystem
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
            AccountList
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
        Text          =  "Account Management System";
        KeyDown       += AccountManagementSystem_KeyDown;
        ((System.ComponentModel.ISupportInitialize) AccountList).EndInit();
        AccountListMenuStrip.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem ChangeStatusOption;

    private System.Windows.Forms.ToolStripMenuItem AccountInformationOption;
    private System.Windows.Forms.ToolStripMenuItem AccountUpdateOption;
    private System.Windows.Forms.ToolStripMenuItem AccountDeleteOption;
    private System.Windows.Forms.ContextMenuStrip  AccountListMenuStrip;
    private System.Windows.Forms.Button            RefreshList;
    private System.Windows.Forms.DataGridView      AccountList;
    private System.Windows.Forms.ComboBox          SearchFilter;
    private System.Windows.Forms.TextBox           SearchBox;
    private System.Windows.Forms.MenuStrip         MenuStrip;

    #endregion
}