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

public partial class LicenseManagement : Form,
                                         Loader {
    private readonly List<string>  searchChoices        = [];
    private readonly BindingSource licenseBindingSource = new();
    private          int?          clientID;

    private static(
            Image AddLicense,
            Image licenseTypes
            ) menuStripIcons() => (
                                      AddLicense : loadIcon(
                                          "Add"
                                      ),
                                      licenseTypes : loadIcon(
                                          "Category"
                                      )
                                  );

    private static(
            Image Local,
            Image International
            ) licensesMenuStripIcons() => (
                                              Local : loadIcon(
                                                  "Home"
                                              ),
                                              International : loadIcon(
                                                  "Globe"
                                              )
                                          );

    private static(
            Image Information,
            Image Edit,
            Image Remove,
            Image Renew,
            Image Replace
            ) licenseListMenuStripIcons() => (
                                                 Information : loadIcon(
                                                     "ID_Card",
                                                     20,
                                                     20
                                                 ),
                                                 Edit : loadIcon(
                                                     "Edit",
                                                     20,
                                                     20
                                                 ),
                                                 Remove : loadIcon(
                                                     "Remove",
                                                     20,
                                                     20
                                                 ),
                                                 Renew : loadIcon(
                                                     "AutoRenew",
                                                     20,
                                                     20
                                                 ),
                                                 Replace : loadIcon(
                                                     "SyncProblem",
                                                     20,
                                                     20
                                                 )
                                             );

    public LicenseManagement(
        ref int? clientID
    ) {
        this.clientID = clientID;

        InitializeComponent();
        Tools.setIcon(
            this,
            "Contacts"
        );
        initializeMenuStrip();
        loadIconButtons();
        createFolders();
        loadLicenses();
        setSearchFilterChoices();
        loadDataSources();
        loadLicenseListMenuStrip();
    }

    private void loadLicenseListMenuStrip() {
        LicenseList.ContextMenuStrip = LicenseListMenuStrip;

        LicenseInformationOption.Image = licenseListMenuStripIcons()
                .Information;

        LicenseUpdateOption.Image = licenseListMenuStripIcons()
                .Edit;

        LicenseDeleteOption.Image = licenseListMenuStripIcons()
                .Remove;

        LicenseRenewOption.Image = licenseListMenuStripIcons()
                .Renew;

        LicenseReplaceOption.Image = licenseListMenuStripIcons()
                .Replace;
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

        ToolStripMenuItem newLicense = createMenuItem(
                              "&New License",
                              menuStripIcons()
                                      .AddLicense
                          ),
                          local = createMenuItem(
                              "&Local",
                              licensesMenuStripIcons()
                                      .Local
                          ),
                          international = createMenuItem(
                              "&International",
                              licensesMenuStripIcons()
                                      .International
                          ),
                          licenseTypes = createMenuItem(
                              "&License Types",
                              menuStripIcons()
                                      .licenseTypes
                          );

        newLicense.DropDownItems.AddRange(
            local,
            international
        );

        menuStrip.Items.AddRange(
            newLicense,
            licenseTypes
        );

        MainMenuStrip = menuStrip;
        Controls.Add(
            menuStrip
        );

        local.Click         += createNewLocalLicense_Click;
        international.Click += createNewInternationalLicense_Click;
        licenseTypes.Click  += licenseTypes_Click;
    }

    private void licenseTypes_Click(
        object?   sender,
        EventArgs e
    ) => new LicenseTypes().Show();

    private void createNewInternationalLicense_Click(
        object?   sender,
        EventArgs e
    ) {
        CreateNewInternationalLicense newInternationalLicense = new CreateNewInternationalLicense();
        newInternationalLicense.FormClosed += RefreshList_Click;
        newInternationalLicense.Show();
    }

    private void createNewLocalLicense_Click(
        object?   sender,
        EventArgs e
    ) {
        CreateNewLocalLicense addAndEditClient = new CreateNewLocalLicense();
        addAndEditClient.FormClosed += RefreshList_Click;
        addAndEditClient.Show();
    }

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
        loadLicenses();
    }

    private void setSearchFilterChoices() {
        foreach (DataGridViewColumn column in LicenseList.Columns)
            searchChoices.Add(
                column.HeaderText
            );
    }

    private void LicenseManagement_FormClosing(
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

    private void LicenseManagement_KeyDown(
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

        if (licenseBindingSource.DataSource is DataTable)
            licenseBindingSource.Filter = $"{selectedFilter} LIKE '%{targetText}%'";
        else {
            List<License> licenses = Licenses.getAll(
                ref clientID
            )!;
            licenses = licenses.Where(
                                   license => {
                                       if (selectedFilter == searchChoices[0]) {
                                           return license.licenseID
                                                         .ToString()!
                                                         .Contains(
                                                             targetText
                                                         );
                                       }

                                       if (selectedFilter == searchChoices[1]) {
                                           return license.licenseTypeID!
                                                         .ToString()!
                                                         .Contains(
                                                             targetText
                                                         );
                                       }

                                       if (selectedFilter == searchChoices[2]) {
                                           return license.clientID!
                                                         .ToString()!
                                                         .Contains(
                                                             targetText
                                                         );
                                       }

                                       return false;
                                   }
                               )
                               .ToList();

            licenseBindingSource.DataSource = licenses;
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
        loadLicenses();
        SearchBox_TextChanged(
            sender,
            e
        );
    }

    private void loadLicenses() {
        List<License>? allLicenses = Licenses.getAll(
            ref clientID
        );
        licenseBindingSource.DataSource = allLicenses;
        LicenseList.DataSource          = licenseBindingSource;
    }

    private void LicenseInformationOption_Click(
        object?   sender,
        EventArgs e
    ) {
        int? licenseID = getLicenseID_FromSelectedRow();

        if (licenseID == -1)
            return;

        new ClientInformation(
            ref licenseID
        ).Show();
    }

    private void LicenseUpdateOption_Click(
        object?   sender,
        EventArgs e
    ) {
        int? licenseID = getLicenseID_FromSelectedRow();

        if (licenseID == -1)
            return;

        FullLicense fullLicense = FullLicenses.get(
            ref licenseID
        );

        EditLicense editLicense = new EditLicense(
            ClientManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants.EditMode.Local,
            fullLicense
        );
        editLicense.FormClosed += RefreshList_Click;
        editLicense.Show();
        loadLicenses();
    }

    private int? getLicenseID_FromSelectedRow() {
        if (LicenseList.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = LicenseList.SelectedRows[0];
            return Convert.ToInt32(
                selectedRow.Cells[0].Value
            );
        }

        if (LicenseList.SelectedCells.Count > 0) {
            DataGridViewCell selectedCell = LicenseList.SelectedCells[0];
            int columnIndex = selectedCell.ColumnIndex,
                rowIndex    = selectedCell.RowIndex;

            if (columnIndex == 0)
                return Convert.ToInt32(
                    selectedCell.Value
                );

            return Convert.ToInt32(
                LicenseList.Rows[rowIndex]
                           .Cells[0]
                           .Value
            );
        }

        licenseNotSelectedWarning();

        return -1;
    }

    private void LicenseDeleteOption_Click(
        object?   sender,
        EventArgs e
    ) {
        License? license = getLicense_FromSelectedRow();

        if (license is null)
            return;

        int? licenseID = license.licenseID;

        if (licenseID == -1)
            return;

        DialogResult result = MessageBox.Show(
            @$"Are you delete {licenseID}?",
            @"Delete License",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );

        if (result == DialogResult.OK)
            deleteSelectedLicense(
                ref license
            );
    }

    private License getLicense_FromSelectedRow() {
        if (LicenseList.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = LicenseList.SelectedRows[0];
            return new License(
                Convert.ToInt32(
                    selectedRow.Cells["licenseID"].Value
                ),
                Convert.ToByte(
                    selectedRow.Cells["licenseTypeID"].Value
                ),
                Convert.ToInt32(
                    selectedRow.Cells["clientID"].Value
                )
            );
        }

        if (LicenseList.SelectedCells.Count > 0) {
            DataGridViewCell selectedCell = LicenseList.SelectedCells[0];
            int              rowIndex     = selectedCell.RowIndex;
            DataGridViewRow  selectedRow  = LicenseList.Rows[rowIndex];

            return new License(
                Convert.ToInt32(
                    selectedRow.Cells["licenseID"].Value
                ),
                Convert.ToByte(
                    selectedRow.Cells["licenseTypeID"].Value
                ),
                Convert.ToInt32(
                    selectedRow.Cells["clientID"].Value
                )
            );
        }

        licenseNotSelectedWarning();

        return null!;
    }

    private void licenseNotSelectedWarning() => MessageBox.Show(
        @"You Must Select Thing!",
        @"License isn't Selected",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
    );

    private void deleteSelectedLicense(
        ref License license
    ) {
        Licenses.delete(
            license.licenseID
        );
        loadLicenses();
    }

    private static Image loadIcon(
        string name,
        int    width  = 48,
        int    height = 48
    ) => Tools.loadEmbeddedSvg(
        Constants.RESOURCES_ICONS_PATH + $".{name}.svg",
        width,
        height
    );

    private void LicenseRenewOption_Click(
        object?   sender,
        EventArgs e
    ) {
        License? license = getLicense_FromSelectedRow();

        if (license is null)
            return;

        int? licenseID = license.licenseID;

        if (licenseID == -1)
            return;

        DialogResult result = MessageBox.Show(
            @$"Are you renew {licenseID}?",
            @"Renew License",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );

        if (result == DialogResult.OK)
            renewSelectedLicense(
                ref license
            );
    }

    private void renewSelectedLicense(
        ref License license
    ) {
        Licenses.renew(
            license.licenseID
        );
        loadLicenses();
    }

    private void LicenseReplaceOption_Click(
        object?   sender,
        EventArgs e
    ) {
        License? license = getLicense_FromSelectedRow();

        if (license is null)
            return;

        int? licenseID = license.licenseID;

        if (licenseID == -1)
            return;

        DialogResult result = MessageBox.Show(
            @$"Are you replace {licenseID}?",
            @"Replace License",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );

        if (result == DialogResult.OK)
            replaceSelectedLicense(
                ref license
            );
    }

    private void replaceSelectedLicense(
        ref License license
    ) {
        Licenses.replace(
            license.licenseID
        );
        loadLicenses();
    }
}