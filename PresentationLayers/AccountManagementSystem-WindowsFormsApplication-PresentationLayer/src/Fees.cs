using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Fees : Form {
    private readonly List<string>  searchChoices     = [];
    private readonly BindingSource feesBindingSource = new();

    public Fees() {
        InitializeComponent();
        loadDataSources();
        Tools.setIcon(
            this,
            "Toll"
        );
        setSearchFilterChoices();
        loadIconButtons();
    }

    private void loadDataSources() {
        loadCountries();
    }

    private void loadIconButtons() {
        Loader.loadDataSource(
            SearchFilter,
            searchChoices
        );
        Tools.setIconButton(
            RefreshList,
            "Refresh",
            20,
            20
        );
    }

    private void setSearchFilterChoices() {
        foreach (DataGridViewColumn column in FeesList.Columns)
            searchChoices.Add(
                column.HeaderText
            );
    }

    private void RefreshList_Click(
        object?   sender,
        EventArgs e
    ) {
        loadCountries();
        SearchBox_TextChanged(
            sender,
            e
        );
    }

    private void SearchBox_TextChanged(
        object?   sender,
        EventArgs eventArgs
    ) {
        string targetText = SearchBox.Text
                                     .Trim()
                                     .Replace(
                                         "'",
                                         "''"
                                     ),
               selectedFilter = SearchFilter.Text;

        if (feesBindingSource.DataSource is DataTable)
            feesBindingSource.Filter = $"{selectedFilter} LIKE '%{targetText}%'";
        else {
            List<ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees> allFees = ClientManagementSystem_ClassLibrary_BusinessLayer.Fees.getAll()!;
            allFees = allFees.Where(
                                 fees => {
                                     if (selectedFilter == searchChoices[0]) {
                                         return fees.feesID
                                                    .ToString()!
                                                    .Contains(
                                                        targetText
                                                    );
                                     }

                                     if (selectedFilter == searchChoices[1]) {
                                         return fees.feesName!
                                                    .Contains(
                                                        targetText,
                                                        StringComparison.OrdinalIgnoreCase
                                                    );
                                     }

                                     if (selectedFilter == searchChoices[2]) {
                                         return fees.amount!
                                                    .ToString()!
                                                    .Contains(
                                                        targetText
                                                    );
                                     }

                                     if (selectedFilter == searchChoices[3]) {
                                         return fees.currencyID!
                                                    .ToString()!
                                                    .Contains(
                                                        targetText
                                                    );
                                     }

                                     return false;
                                 }
                             )
                             .ToList();

            feesBindingSource.DataSource = allFees;
        }
    }

    private void SearchFilter_SelectedIndexChanged(
        object    sender,
        EventArgs e
    ) => SearchBox_TextChanged(
        sender,
        e
    );

    private void loadCountries() {
        List<ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees>? allFees = ClientManagementSystem_ClassLibrary_BusinessLayer.Fees.getAll();
        feesBindingSource.DataSource = allFees;
        FeesList.DataSource          = feesBindingSource;
    }

    private void disableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );
}