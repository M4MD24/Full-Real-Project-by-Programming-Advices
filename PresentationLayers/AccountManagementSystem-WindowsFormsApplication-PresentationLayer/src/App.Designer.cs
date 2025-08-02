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
        searchBox     = new System.Windows.Forms.TextBox();
        confirmSearch = new System.Windows.Forms.Button();
        searchFilter  = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // MenuStrip
        // 
        MenuStrip.Location = new System.Drawing.Point(
            0,
            0
        );
        MenuStrip.Name = "MenuStrip";
        MenuStrip.Size = new System.Drawing.Size(
            984,
            24
        );
        MenuStrip.TabIndex = 0;
        MenuStrip.Text     = "MenuStrip";
        // 
        // searchBox
        // 
        searchBox.Location = new System.Drawing.Point(
            20,
            50
        );
        searchBox.Multiline = true;
        searchBox.Name      = "searchBox";
        searchBox.Size = new System.Drawing.Size(
            580,
            25
        );
        searchBox.TabIndex = 1;
        // 
        // confirmSearch
        // 
        confirmSearch.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        confirmSearch.Location = new System.Drawing.Point(
            800,
            50
        );
        confirmSearch.Name = "confirmSearch";
        confirmSearch.Size = new System.Drawing.Size(
            160,
            25
        );
        confirmSearch.TabIndex                = 3;
        confirmSearch.Text                    = "Search";
        confirmSearch.UseVisualStyleBackColor = true;
        // 
        // searchFilter
        // 
        searchFilter.FormattingEnabled = true;
        searchFilter.Location = new System.Drawing.Point(
            620,
            51
        );
        searchFilter.Name = "searchFilter";
        searchFilter.Size = new System.Drawing.Size(
            160,
            23
        );
        searchFilter.TabIndex = 2;
        // 
        // App
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            984,
            661
        );
        Controls.Add(
            searchFilter
        );
        Controls.Add(
            confirmSearch
        );
        Controls.Add(
            searchBox
        );
        Controls.Add(
            MenuStrip
        );
        MainMenuStrip = MenuStrip;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Main";
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox searchFilter;

    private System.Windows.Forms.Button confirmSearch;

    private System.Windows.Forms.TextBox searchBox;

    private System.Windows.Forms.MenuStrip MenuStrip;

    #endregion
}