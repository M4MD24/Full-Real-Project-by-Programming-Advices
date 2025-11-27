using System.ComponentModel;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class Requests {
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
        RequestList  = new System.Windows.Forms.DataGridView();
        RefreshList  = new System.Windows.Forms.Button();
        RequestListMenuStrip = new System.Windows.Forms.ContextMenuStrip(
            components
        );
        TestsOption           = new System.Windows.Forms.ToolStripMenuItem();
        TheoreticalTestOption = new System.Windows.Forms.ToolStripMenuItem();
        EyeTestOption         = new System.Windows.Forms.ToolStripMenuItem();
        DrivingTestOption     = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize) RequestList).BeginInit();
        RequestListMenuStrip.SuspendLayout();
        SuspendLayout();
        //
        // MenuStrip
        //
        MenuStrip.AutoSize = false;
        MenuStrip.ImageScalingSize = new System.Drawing.Size(
            20,
            20
        );
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
            31
        );
        SearchFilter.TabIndex             =  1;
        SearchFilter.SelectedIndexChanged += SearchFilter_SelectedIndexChanged;
        //
        // RequestList
        //
        RequestList.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        RequestList.BackgroundColor             = System.Drawing.Color.Gray;
        RequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        RequestList.Location = new System.Drawing.Point(
            20,
            90
        );
        RequestList.MultiSelect     = false;
        RequestList.Name            = "RequestList";
        RequestList.ReadOnly        = true;
        RequestList.RowHeadersWidth = 51;
        RequestList.Size = new System.Drawing.Size(
            940,
            550
        );
        RequestList.TabIndex = 3;
        RequestList.Text     = "Client List";
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
        // RequestListMenuStrip
        //
        RequestListMenuStrip.ImageScalingSize = new System.Drawing.Size(
            20,
            20
        );
        RequestListMenuStrip.Items.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                TestsOption
            }
        );
        RequestListMenuStrip.Name = "RequestListMenuStrip";
        RequestListMenuStrip.Size = new System.Drawing.Size(
            117,
            32
        );
        //
        // TestsOption
        //
        TestsOption.DropDownItems.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                TheoreticalTestOption,
                EyeTestOption,
                DrivingTestOption
            }
        );
        TestsOption.Name = "TestsOption";
        TestsOption.Size = new System.Drawing.Size(
            116,
            28
        );
        TestsOption.Text = "Tests";
        //
        // TheoreticalTestOption
        //
        TheoreticalTestOption.Enabled = false;
        TheoreticalTestOption.Name    = "TheoreticalTestOption";
        TheoreticalTestOption.Size = new System.Drawing.Size(
            224,
            28
        );
        TheoreticalTestOption.Text  =  "Theoretical";
        TheoreticalTestOption.Click += TheoreticalTestOption_Click;
        //
        // EyeTestOption
        //
        EyeTestOption.Enabled = false;
        EyeTestOption.Name    = "EyeTestOption";
        EyeTestOption.Size = new System.Drawing.Size(
            224,
            28
        );
        EyeTestOption.Text  =  "Eye";
        EyeTestOption.Click += EyeTestOption_Click;
        //
        // DrivingTestOption
        //
        DrivingTestOption.Enabled = false;
        DrivingTestOption.Name    = "DrivingTestOption";
        DrivingTestOption.Size = new System.Drawing.Size(
            224,
            28
        );
        DrivingTestOption.Text  =  "Driving";
        DrivingTestOption.Click += DrivingTestOption_Click;
        //
        // Requests
        //
        AutoScaleDimensions = new System.Drawing.SizeF(
            9F,
            23F
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
            RequestList
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
        KeyPreview    = true;
        MainMenuStrip = MenuStrip;
        Margin = new System.Windows.Forms.Padding(
            4,
            5,
            4,
            5
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "Requests";
        KeyDown       += Requests_KeyDown;
        ((System.ComponentModel.ISupportInitialize) RequestList).EndInit();
        RequestListMenuStrip.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem EyeTestOption;
    private System.Windows.Forms.ToolStripMenuItem DrivingTestOption;

    private System.Windows.Forms.ToolStripMenuItem TheoreticalTestOption;

    private System.Windows.Forms.ToolStripMenuItem TestsOption;

    private System.Windows.Forms.ContextMenuStrip RequestListMenuStrip;

    private System.Windows.Forms.Button            RefreshList;
    private System.Windows.Forms.DataGridView      RequestList;
    private System.Windows.Forms.ComboBox          SearchFilter;
    private System.Windows.Forms.TextBox           SearchBox;
    private System.Windows.Forms.MenuStrip         MenuStrip;

    #endregion
}