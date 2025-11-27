using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Countries : Form {
    private readonly List<string>  searchChoices        = [];
    private readonly BindingSource countryBindingSource = new();

    public Countries() {
        InitializeComponent();
        loadDataSources();
        Tools.setIcon(
            this,
            "Flag2"
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
        foreach (DataGridViewColumn column in CountryList.Columns)
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

        if (countryBindingSource.DataSource is DataTable)
            countryBindingSource.Filter = $"{selectedFilter} LIKE '%{targetText}%'";
        else {
            List<ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Country> countries = ClientManagementSystem_ClassLibrary_BusinessLayer.Countries.getAll()!;
            countries = countries.Where(
                                     country => {
                                         if (selectedFilter == searchChoices[0]) {
                                             return country.countryID
                                                           .ToString()!
                                                           .Contains(
                                                               targetText
                                                           );
                                         }

                                         if (selectedFilter == searchChoices[1]) {
                                             return country.countryName!
                                                           .Contains(
                                                               targetText,
                                                               StringComparison.OrdinalIgnoreCase
                                                           );
                                         }

                                         if (selectedFilter == searchChoices[2]) {
                                             return country.countryCode!
                                                           .Contains(
                                                               targetText,
                                                               StringComparison.OrdinalIgnoreCase
                                                           );
                                         }

                                         return false;
                                     }
                                 )
                                 .ToList();

            countryBindingSource.DataSource = countries;
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
        List<ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Country>? allCountries = ClientManagementSystem_ClassLibrary_BusinessLayer.Countries.getAll();
        countryBindingSource.DataSource = allCountries;
        CountryList.DataSource          = countryBindingSource;
    }

    private void disableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );
}