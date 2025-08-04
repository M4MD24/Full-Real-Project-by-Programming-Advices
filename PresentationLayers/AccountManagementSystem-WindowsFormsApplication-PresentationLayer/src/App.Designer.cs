using System.Drawing;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class App {
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
        MenuStrip     = new System.Windows.Forms.MenuStrip();
        SearchBox     = new System.Windows.Forms.TextBox();
        ConfirmSearch = new System.Windows.Forms.Button();
        SearchFilter  = new System.Windows.Forms.ComboBox();
        AccountList   = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize) AccountList).BeginInit();
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
            580,
            25
        );
        SearchBox.TabIndex =  1;
        SearchBox.KeyDown  += searchBox_KeyDown;
        // 
        // ConfirmSearch
        // 
        ConfirmSearch.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        ConfirmSearch.Location = new System.Drawing.Point(
            800,
            50
        );
        ConfirmSearch.Name = "ConfirmSearch";
        ConfirmSearch.Size = new System.Drawing.Size(
            160,
            25
        );
        ConfirmSearch.TabIndex                =  3;
        ConfirmSearch.Text                    =  "Search";
        ConfirmSearch.UseVisualStyleBackColor =  true;
        ConfirmSearch.Click                   += confirmSearch_Click;
        // 
        // SearchFilter
        // 
        SearchFilter.FormattingEnabled = true;
        SearchFilter.Location = new System.Drawing.Point(
            620,
            51
        );
        SearchFilter.Name = "SearchFilter";
        SearchFilter.Size = new System.Drawing.Size(
            160,
            23
        );
        SearchFilter.TabIndex = 2;
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
        AccountList.Name = "AccountList";
        AccountList.Size = new System.Drawing.Size(
            940,
            550
        );
        AccountList.TabIndex = 4;
        AccountList.Text     = "Account List";
        // 
        // App
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
            AccountList
        );
        Controls.Add(
            SearchFilter
        );
        Controls.Add(
            ConfirmSearch
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
        Text          =  "Main";
        Load          += App_Load;
        KeyDown       += App_KeyDown;
        ((System.ComponentModel.ISupportInitialize) AccountList).EndInit();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView AccountList;

    private System.Windows.Forms.ComboBox SearchFilter;

    private System.Windows.Forms.Button ConfirmSearch;

    private System.Windows.Forms.TextBox SearchBox;

    private System.Windows.Forms.MenuStrip MenuStrip;

    #endregion
}