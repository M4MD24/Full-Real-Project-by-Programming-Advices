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

public partial class ClientManagementSystem : Form {
    private readonly List<string>  searchChoices       = [];
    private readonly BindingSource clientBindingSource = new();

    private static(
            Image AddClient,
            Image Lists,
            Image Fees
            ) menuStripIcons() => (
                                      AddClient : loadIcon(
                                          "PersonAdd"
                                      ),
                                      Lists : loadIcon(
                                          "Lists"
                                      ),
                                      Fees : loadIcon(
                                          "Toll"
                                      )
                                  );

    private static(
            Image Currencies,
            Image Countries
            ) listMenuStripIcons() => (
                                          Currencies : loadIcon(
                                              "UniversalCurrencyAlt"
                                          ),
                                          Countries : loadIcon(
                                              "Flag2"
                                          )
                                      );

    private static(
            Image Information,
            Image Edit,
            Image Remove,
            Image Licenses
            ) clientListMenuStripIcons() => (
                                                Information : loadIcon(
                                                    "Person",
                                                    20,
                                                    20
                                                ),
                                                Edit : loadIcon(
                                                    "PersonEdit",
                                                    20,
                                                    20
                                                ),
                                                Remove : loadIcon(
                                                    "PersonRemove",
                                                    20,
                                                    20
                                                ),
                                                Licenses : loadIcon(
                                                    "Contacts",
                                                    20,
                                                    20
                                                )
                                            );

    public ClientManagementSystem() {
        InitializeComponent();
        Tools.setIcon(
            this,
            "ManageAccounts"
        );
        initializeMenuStrip();
        loadIconButtons();
        createFolders();
        loadClients();
        setSearchFilterChoices();
        loadDataSources();
        loadClientListMenuStrip();
    }

    private void loadClientListMenuStrip() {
        ClientList.ContextMenuStrip = ClientListMenuStrip;

        ClientInformationOption.Image = clientListMenuStripIcons()
                .Information;

        ClientUpdateOption.Image = clientListMenuStripIcons()
                .Edit;

        ClientDeleteOption.Image = clientListMenuStripIcons()
                .Remove;

        ClientLicensesOption.Image = clientListMenuStripIcons()
                .Licenses;
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
                                      .AddClient
                          ),
                          lists = createMenuItem(
                              "&Lists",
                              menuStripIcons()
                                      .Lists
                          ),
                          countries = createMenuItem(
                              "Cou&ntries",
                              listMenuStripIcons()
                                      .Countries
                          ),
                          currencies = createMenuItem(
                              "Cu&rrencies",
                              listMenuStripIcons()
                                      .Currencies
                          ),
                          fees = createMenuItem(
                              "&Fees",
                              menuStripIcons()
                                      .Fees
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
        AddAndEditClient addAndEditClient = new AddAndEditClient(
            ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants.Mode.Add
        );
        addAndEditClient.FormClosed += addAndEditClient_FormClosed;
        addAndEditClient.Show();
    }

    private void addAndEditClient_FormClosed(
        object?             sender,
        FormClosedEventArgs e
    ) => RefreshList_Click(
        sender,
        e
    );

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

    private void setSearchFilterChoices() {
        foreach (DataGridViewColumn column in ClientList.Columns)
            searchChoices.Add(
                column.HeaderText
            );
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
            List<Client> allClients = Clients.getAll()!;
            allClients = allClients.Where(
                                       client => {
                                           if (selectedFilter == searchChoices[0]) {
                                               return client.clientID
                                                            .ToString()!
                                                            .Contains(
                                                                targetText
                                                            );
                                           }

                                           if (selectedFilter == searchChoices[1]) {
                                               return client.personID!
                                                            .ToString()!
                                                            .Contains(
                                                                targetText
                                                            );
                                           }

                                           return false;
                                       }
                                   )
                                   .ToList();

            clientBindingSource.DataSource = allClients;
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
    ) => SearchBox_TextChanged(
        sender,
        e
    );

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
    ) {
        int? clientID = getClientID_FromSelectedRow();

        if (clientID == -1)
            return;

        new ClientInformation(
            ref clientID
        ).Show();
    }

    private void ClientUpdateOption_Click(
        object?   sender,
        EventArgs e
    ) {
        int? clientID = getClientID_FromSelectedRow();

        if (clientID == -1)
            return;

        FullClient fullClient = FullClients.get(
            ref clientID
        );

        AddAndEditClient addAndEditClient = new AddAndEditClient(
            ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants.Mode.Update,
            fullClient
        );
        addAndEditClient.FormClosed += addAndEditClient_FormClosed;
        addAndEditClient.Show();
        loadClients();
    }

    private int? getClientID_FromSelectedRow() {
        if (ClientList.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = ClientList.SelectedRows[0];
            return Convert.ToInt32(
                selectedRow.Cells[0].Value
            );
        }

        if (ClientList.SelectedCells.Count > 0) {
            DataGridViewCell selectedCell = ClientList.SelectedCells[0];
            int columnIndex = selectedCell.ColumnIndex,
                rowIndex    = selectedCell.RowIndex;

            if (columnIndex == 0)
                return Convert.ToInt32(
                    selectedCell.Value
                );

            return Convert.ToInt32(
                ClientList.Rows[rowIndex]
                          .Cells[0]
                          .Value
            );
        }

        clientNotSelectedWarning();

        return -1;
    }

    private void ClientDeleteOption_Click(
        object?   sender,
        EventArgs e
    ) {
        Client? client = getClient_FromSelectedRow();

        if (client is null)
            return;

        int? clientID = client.clientID;

        if (clientID == -1)
            return;

        DialogResult result = MessageBox.Show(
            @$"Are you delete {clientID}?",
            @"Delete Client",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );

        if (result == DialogResult.OK)
            deleteSelectedClient(
                ref client
            );
    }

    private Client getClient_FromSelectedRow() {
        if (ClientList.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = ClientList.SelectedRows[0];
            return new Client(
                Convert.ToInt32(
                    selectedRow.Cells["clientID"].Value
                ),
                Convert.ToInt32(
                    selectedRow.Cells["personID"].Value
                )
            );
        }

        if (ClientList.SelectedCells.Count > 0) {
            DataGridViewCell selectedCell = ClientList.SelectedCells[0];
            int              rowIndex     = selectedCell.RowIndex;
            DataGridViewRow  selectedRow  = ClientList.Rows[rowIndex];

            return new Client(
                Convert.ToInt32(
                    selectedRow.Cells["clientID"].Value
                ),
                Convert.ToInt32(
                    selectedRow.Cells["personID"].Value
                )
            );
        }

        clientNotSelectedWarning();

        return null!;
    }

    private void clientNotSelectedWarning() => MessageBox.Show(
        @"You Must Select Thing!",
        @"Client isn't Selected",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
    );

    private void deleteSelectedClient(
        ref Client client
    ) {
        FullClients.delete(
            ref client
        );
        loadClients();
    }

    private void ClientLicensesOption_Click(
        object?   sender,
        EventArgs e
    ) {
        Client? client = getClient_FromSelectedRow();

        if (client is null)
            return;

        int? clientID = client.clientID;

        if (clientID == -1)
            return;

        new Licenses(
            ref clientID
        ).Show();
    }

    private static Image loadIcon(
        string name,
        int    width  = 48,
        int    height = 48
    ) => Tools.loadEmbeddedSvg(
        Constants.RESOURCES_IMAGES_PATH + $".{name}.svg",
        width,
        height
    );
}