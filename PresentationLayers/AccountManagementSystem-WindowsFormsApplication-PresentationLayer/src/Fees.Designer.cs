using System.ComponentModel;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

partial class Fees {
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
        FeesList  = new System.Windows.Forms.DataGridView();
        SearchBox    = new System.Windows.Forms.TextBox();
        SearchFilter = new System.Windows.Forms.ComboBox();
        RefreshList  = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize) FeesList).BeginInit();
        SuspendLayout();
        //
        // FeesList
        //
        FeesList.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        FeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FeesList.Location = new System.Drawing.Point(
            20,
            60
        );
        FeesList.MultiSelect = false;
        FeesList.Name        = "FeesList";
        FeesList.ReadOnly    = true;
        FeesList.Size = new System.Drawing.Size(
            545,
            380
        );
        FeesList.TabIndex = 3;
        FeesList.Text     = "dataGridView1";
        //
        // SearchBox
        //
        SearchBox.Location = new System.Drawing.Point(
            20,
            20
        );
        SearchBox.Multiline = true;
        SearchBox.Name      = "SearchBox";
        SearchBox.Size = new System.Drawing.Size(
            380,
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
            410,
            21
        );
        SearchFilter.Name = "SearchFilter";
        SearchFilter.Size = new System.Drawing.Size(
            121,
            23
        );
        SearchFilter.TabIndex             =  1;
        SearchFilter.SelectedIndexChanged += SearchFilter_SelectedIndexChanged;
        //
        // RefreshList
        //
        RefreshList.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        RefreshList.Location = new System.Drawing.Point(
            540,
            20
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
        // Fees
        //
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(
            584,
            461
        );
        Controls.Add(
            RefreshList
        );
        Controls.Add(
            SearchFilter
        );
        Controls.Add(
            SearchBox
        );
        Controls.Add(
            FeesList
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Countries";
        ((System.ComponentModel.ISupportInitialize) FeesList).EndInit();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.Button RefreshList;

    private System.Windows.Forms.ComboBox SearchFilter;

    private System.Windows.Forms.TextBox SearchBox;

    private System.Windows.Forms.DataGridView FeesList;

    #endregion
}