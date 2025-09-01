using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Currencies : Form {
    private readonly List<string>  searchChoices         = [];
    private readonly BindingSource currencyBindingSource = new();

    public Currencies() {
        InitializeComponent();
        loadDataSources();
        Tools.setIcon(
            this,
            "UniversalCurrencyAlt"
        );
        setSearchFilterChoices();
        loadIconButtons();
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

    private void loadDataSources() {
        loadCurrencies();
    }

    private void loadCurrencies() {
        List<Currency>? allCurrencies = ClientManagementSystem_ClassLibrary_BusinessLayer.Currencies.getAll();
        currencyBindingSource.DataSource = allCurrencies;
        CountryList.DataSource           = currencyBindingSource;
    }

    private void disableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );

    private void SearchBox_TextChanged(
        object?   sender,
        EventArgs e
    ) {
        string targetText = SearchBox.Text
                                     .Trim()
                                     .Replace(
                                         "'",
                                         "''"
                                     ),
               selectedFilter = SearchFilter.Text;

        if (currencyBindingSource.DataSource is DataTable)
            currencyBindingSource.Filter = $"{selectedFilter} LIKE '%{targetText}%'";
        else {
            List<Currency> currencies = ClientManagementSystem_ClassLibrary_BusinessLayer.Currencies.getAll()!;
            currencies = currencies.Where(
                                       currency => {
                                           if (selectedFilter == searchChoices[0]) {
                                               return currency.currencyID!
                                                              .ToString()!
                                                              .Contains(
                                                                  targetText
                                                              );
                                           }

                                           if (selectedFilter == searchChoices[1]) {
                                               return currency.currencyName!
                                                              .Contains(
                                                                  targetText,
                                                                  StringComparison.OrdinalIgnoreCase
                                                              );
                                           }

                                           if (selectedFilter == searchChoices[2]) {
                                               return currency.countryID
                                                              .ToString()!
                                                              .Contains(
                                                                  targetText
                                                              );
                                           }

                                           return false;
                                       }
                                   )
                                   .ToList();

            currencyBindingSource.DataSource = currencies;
        }
    }

    private void SearchFilter_SelectedIndexChanged(
        object?   sender,
        EventArgs e
    ) => SearchBox_TextChanged(
        sender,
        e
    );

    private void RefreshList_Click(
        object?   sender,
        EventArgs e
    ) {
        loadCurrencies();
        SearchBox_TextChanged(
            sender,
            e
        );
    }
}