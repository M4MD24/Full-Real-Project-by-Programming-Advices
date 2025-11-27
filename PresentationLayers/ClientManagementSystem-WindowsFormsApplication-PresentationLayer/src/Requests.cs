using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Requests : Form {
    private readonly List<string>  searchChoices        = [];
    private readonly BindingSource requestBindingSource = new();
    private int? clientID,
                 licenseID;

    private static Image loadIcon(
        string name,
        int    width  = 48,
        int    height = 48
    ) => Tools.loadEmbeddedSvg(
        Constants.RESOURCES_IMAGES_PATH + $".{name}.svg",
        width,
        height
    );

    public Requests(
        int? clientID,
        int? licenseID
    ) {
        this.clientID  = clientID;
        this.licenseID = licenseID;

        InitializeComponent();
        Tools.setIcon(
            this,
            "Contacts"
        );
        loadIconButtons();
        createFolders();
        loadRequests();
        setSearchFilterChoices();
        loadDataSources();
    }

    private void loadDataSources() {
        Loader.loadDataSource(
            SearchFilter,
            searchChoices
        );
        loadRequests();
    }

    private void setSearchFilterChoices() {}

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

    private void loadIconButtons() {
        Tools.setIconButton(
            RefreshList,
            "Refresh",
            20,
            20
        );
    }

    private void SearchBox_TextChanged(
        object?   sender,
        EventArgs e
    ) {}

    private void disableNewLine_KeyDown(
        object?      sender,
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
        loadRequests();
        SearchBox_TextChanged(
            sender,
            e
        );
    }

    private void loadRequests() {
        List<Request>? allRequests = ClientManagementSystem_ClassLibrary_BusinessLayer.Requests.getAll(
            ref clientID,
            ref licenseID
        );

        requestBindingSource.DataSource = allRequests;
        RequestList.DataSource          = requestBindingSource;

        if (
            RequestList.Columns.Contains(
                "clientID"
            )
        )
            RequestList.Columns["clientID"]!.Visible = false;

        if (
            RequestList.Columns.Contains(
                "licenseID"
            )
        )
            RequestList.Columns["licenseID"]!.Visible = false;
    }

    private void Requests_KeyDown(
        object?      sender,
        KeyEventArgs e
    ) {}

    private void TheoreticalTestOption_Click(
        object    sender,
        EventArgs e
    ) {}

    private void EyeTestOption_Click(
        object    sender,
        EventArgs e
    ) {}

    private void DrivingTestOption_Click(
        object?   sender,
        EventArgs e
    ) {}
}