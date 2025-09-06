using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_BusinessLayer;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class ClientManagementSystem : Form,
                                              Loader {
    private readonly List<string>  searchChoices       = [];
    private readonly BindingSource clientBindingSource = new();

    private static(
            Image PersonAdd,
            Image Lists,
            Image UniversalCurrencyAlt,
            Image Flag2,
            Image Toll
            ) menuStripIcons() => (
                                      PersonAdd : loadIcon(
                                          "PersonAdd"
                                      ),
                                      Lists : loadIcon(
                                          "Lists"
                                      ),
                                      UniversalCurrencyAlt : loadIcon(
                                          "UniversalCurrencyAlt"
                                      ),
                                      Flag2 : loadIcon(
                                          "Flag2"
                                      ),
                                      Toll : loadIcon(
                                          "Toll"
                                      )
                                  );

    private static(
            Image Person,
            Image PersonEdit,
            Image PersonRemove,
            Image SwapHorizontal
            ) clientListMenuStripIcons() => (
                                                Person : loadIcon(
                                                    "Person",
                                                    20,
                                                    20
                                                ),
                                                PersonEdit : loadIcon(
                                                    "PersonEdit",
                                                    20,
                                                    20
                                                ),
                                                PersonRemove : loadIcon(
                                                    "PersonRemove",
                                                    20,
                                                    20
                                                ),
                                                SwapHorizontal : loadIcon(
                                                    "SwapHorizontal",
                                                    20,
                                                    20
                                                )
                                            );

    public ClientManagementSystem() {
        InitializeComponent();
        loadDataSources();
        Tools.setIcon(
            this,
            "ManageAccounts"
        );
        initializeMenuStrip();
        loadIconButtons();
        createFolders();
        loadClientListMenuStrip();
    }

    private void loadClientListMenuStrip() {
        ClientList.ContextMenuStrip = ClientListMenuStrip;

        ClientInformationOption.Image = clientListMenuStripIcons()
                .Person;

        ClientUpdateOption.Image = clientListMenuStripIcons()
                .PersonEdit;

        ClientDeleteOption.Image = clientListMenuStripIcons()
                .PersonRemove;
    }

    private void loadIconButtons() {
        Tools.setIconButton(
            RefreshList,
            "Refresh",
            20,
            20
        );
    }

    private void createFolders() { createImageFolder(); }

    private void createImageFolder() {
        string imageDirectory = Path.Combine(
            Constants.baseDirectory,
            Constants.IMAGE_FOLDER_RELATIVE_PATH
        );

        if (
            !Directory.Exists(
                imageDirectory
            )
        )
            Directory.CreateDirectory(
                imageDirectory
            );
    }

    private void initializeMenuStrip() {
        MenuStrip menuStrip = new MenuStrip();

        ToolStripMenuItem newClient = createMenuItem(
                              "&New Client",
                              menuStripIcons()
                                      .PersonAdd
                          ),
                          lists = createMenuItem(
                              "&Lists",
                              menuStripIcons()
                                      .Lists
                          ),
                          countries = createMenuItem(
                              "Cou&ntries",
                              menuStripIcons()
                                      .Flag2
                          ),
                          currencies = createMenuItem(
                              "Cu&rrencies",
                              menuStripIcons()
                                      .UniversalCurrencyAlt
                          ),
                          fees = createMenuItem(
                              "&Fees",
                              menuStripIcons()
                                      .Toll
                          );

        lists.DropDownItems.AddRange(
            countries,
            currencies
        );
        menuStrip.Items.AddRange(
            newClient,
            lists,
            fees
        );

        MainMenuStrip = menuStrip;
        Controls.Add(
            menuStrip
        );

        newClient.Click  += newClient_Click;
        countries.Click  += countries_Click;
        currencies.Click += currencies_Click;
        fees.Click       += fees_Click;
    }

    private void currencies_Click(
        object?   sender,
        EventArgs e
    ) => new Currencies().Show();

    private void countries_Click(
        object?   sender,
        EventArgs e
    ) => new Countries().Show();

    private void newClient_Click(
        object?   sender,
        EventArgs e
    ) {
        throw new NotImplementedException();
    }

    private void fees_Click(
        object?   sender,
        EventArgs e
    ) => new Fees().Show();

    private static ToolStripMenuItem createMenuItem(
        string text,
        Image  icon
    ) => new(
        text,
        icon
    );

    private void loadDataSources() {
        Loader.loadDataSource(
            SearchFilter,
            searchChoices
        );
        loadClients();
    }

    private void ClientManagementSystem_FormClosing(
        object               sender,
        FormClosingEventArgs e
    ) {
        DialogResult result = MessageBox.Show(
            @"Do you want Close?",
            @"Close",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes) {
            new Login().Show();
            Hide();
        } else
            e.Cancel = true;
    }

    private void ClientManagementSystem_KeyDown(
        object?      sender,
        KeyEventArgs e
    ) {}

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

        if (clientBindingSource.DataSource is DataTable)
            clientBindingSource.Filter = $"{selectedFilter} LIKE '%{targetText}%'";
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

            clientBindingSource.DataSource = allFees;
        }
    }

    private void disableNewLine_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );

    private void SearchFilter_SelectedIndexChanged(
        object?   sender,
        EventArgs e
    ) {}

    private void RefreshList_Click(
        object?   sender,
        EventArgs e
    ) {
        loadClients();
        SearchBox_TextChanged(
            sender,
            e
        );
    }

    private void loadClients() {
        List<Client>? allClients = Clients.getAll();
        clientBindingSource.DataSource = allClients;
        ClientList.DataSource          = clientBindingSource;
    }

    private void ClientInformationOption_Click(
        object?   sender,
        EventArgs e
    ) {}

    private void ClientUpdateOption_Click(
        object?   sender,
        EventArgs e
    ) {}

    private void ClientDeleteOption_Click(
        object?   sender,
        EventArgs e
    ) {}

    private static Image loadIcon(
        string name,
        int    width  = 48,
        int    height = 48
    ) => Tools.loadEmbeddedSvg(
        Constants.RESOURCES_ICONS_PATH + $".{name}.svg",
        width,
        height
    );
}