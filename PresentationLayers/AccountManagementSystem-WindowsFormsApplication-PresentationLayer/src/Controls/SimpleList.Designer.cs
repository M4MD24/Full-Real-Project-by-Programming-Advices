using System.ComponentModel;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Controls;

partial class SimpleList {
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        searchBox     = new System.Windows.Forms.TextBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        searchFilter  = new System.Windows.Forms.ComboBox();
        confirmSearch = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize) dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // searchBox
        // 
        searchBox.Location = new System.Drawing.Point(
            0,
            0
        );
        searchBox.Multiline = true;
        searchBox.Name      = "searchBox";
        searchBox.Size = new System.Drawing.Size(
            335,
            25
        );
        searchBox.TabIndex =  0;
        searchBox.WordWrap =  false;
        searchBox.KeyDown  += searchBox_KeyDown;
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor             = System.Drawing.Color.Gray;
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(
            0,
            30
        );
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(
            550,
            520
        );
        dataGridView1.TabIndex = 1;
        dataGridView1.Text     = "dataGridView1";
        // 
        // searchFilter
        // 
        searchFilter.FormattingEnabled = true;
        searchFilter.Location = new System.Drawing.Point(
            340,
            1
        );
        searchFilter.Name = "searchFilter";
        searchFilter.Size = new System.Drawing.Size(
            121,
            23
        );
        searchFilter.TabIndex = 2;
        // 
        // confirmSearch
        // 
        confirmSearch.Location = new System.Drawing.Point(
            465,
            0
        );
        confirmSearch.Name = "confirmSearch";
        confirmSearch.Size = new System.Drawing.Size(
            85,
            25
        );
        confirmSearch.TabIndex                = 3;
        confirmSearch.Text                    = "button1";
        confirmSearch.UseVisualStyleBackColor = true;
        // 
        // SimpleList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.Color.DimGray;
        Controls.Add(
            confirmSearch
        );
        Controls.Add(
            searchFilter
        );
        Controls.Add(
            dataGridView1
        );
        Controls.Add(
            searchBox
        );
        Size = new System.Drawing.Size(
            550,
            550
        );
        ((System.ComponentModel.ISupportInitialize) dataGridView1).EndInit();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.Button confirmSearch;

    private System.Windows.Forms.ComboBox searchFilter;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.TextBox searchBox;

    #endregion
}