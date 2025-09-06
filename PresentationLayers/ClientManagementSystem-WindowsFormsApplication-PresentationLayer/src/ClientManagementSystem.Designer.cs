using System.ComponentModel;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class ClientManagementSystem {
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
        ClientList   = new System.Windows.Forms.DataGridView();
        RefreshList  = new System.Windows.Forms.Button();
        ClientListMenuStrip = new System.Windows.Forms.ContextMenuStrip(
            components
        );
        ClientInformationOption = new System.Windows.Forms.ToolStripMenuItem();
        ClientUpdateOption      = new System.Windows.Forms.ToolStripMenuItem();
        ClientDeleteOption      = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize) ClientList).BeginInit();
        ClientListMenuStrip.SuspendLayout();
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
        // ClientList
        //
        ClientList.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        ClientList.BackgroundColor             = System.Drawing.Color.Gray;
        ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ClientList.Location = new System.Drawing.Point(
            20,
            90
        );
        ClientList.MultiSelect = false;
        ClientList.Name        = "ClientList";
        ClientList.ReadOnly    = true;
        ClientList.Size = new System.Drawing.Size(
            940,
            550
        );
        ClientList.TabIndex = 3;
        ClientList.Text     = "Client List";
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
        // ClientListMenuStrip
        //
        ClientListMenuStrip.Items.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                ClientInformationOption,
                ClientUpdateOption,
                ClientDeleteOption
            }
        );
        ClientListMenuStrip.Name = "ClientListMenuStrip";
        ClientListMenuStrip.Size = new System.Drawing.Size(
            138,
            70
        );
        //
        // ClientInformationOption
        //
        ClientInformationOption.Name = "ClientInformationOption";
        ClientInformationOption.Size = new System.Drawing.Size(
            137,
            22
        );
        ClientInformationOption.Text  =  "Information";
        ClientInformationOption.Click += ClientInformationOption_Click;
        //
        // ClientUpdateOption
        //
        ClientUpdateOption.Name = "ClientUpdateOption";
        ClientUpdateOption.Size = new System.Drawing.Size(
            137,
            22
        );
        ClientUpdateOption.Text  =  "Update";
        ClientUpdateOption.Click += ClientUpdateOption_Click;
        //
        // ClientDeleteOption
        //
        ClientDeleteOption.Name = "ClientDeleteOption";
        ClientDeleteOption.Size = new System.Drawing.Size(
            137,
            22
        );
        ClientDeleteOption.Text  =  "Delete";
        ClientDeleteOption.Click += ClientDeleteOption_Click;
        //
        // ClientManagementSystem
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
            ClientList
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
        Text          =  "Client Management System";
        FormClosing   += ClientManagementSystem_FormClosing;
        KeyDown       += ClientManagementSystem_KeyDown;
        ((System.ComponentModel.ISupportInitialize) ClientList).EndInit();
        ClientListMenuStrip.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem ClientInformationOption;
    private System.Windows.Forms.ToolStripMenuItem ClientUpdateOption;
    private System.Windows.Forms.ToolStripMenuItem ClientDeleteOption;
    private System.Windows.Forms.ContextMenuStrip  ClientListMenuStrip;
    private System.Windows.Forms.Button            RefreshList;
    private System.Windows.Forms.DataGridView      ClientList;
    private System.Windows.Forms.ComboBox          SearchFilter;
    private System.Windows.Forms.TextBox           SearchBox;
    private System.Windows.Forms.MenuStrip         MenuStrip;

    #endregion
}