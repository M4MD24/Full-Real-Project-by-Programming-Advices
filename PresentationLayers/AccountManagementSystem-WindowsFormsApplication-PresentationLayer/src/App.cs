using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class App : Form,
                           Loader {
    private static readonly(
            Image PersonAdd,
            Image Lists,
            Image Toll,
            Image Flag2,
            Image Help,
            Image Shortcuts,
            Image ContactSupport,
            Image Call,
            Image Mail,
            Image Telegram
            ) menuStripIcons = loadMenuStripIcons();

    public App() {
        InitializeComponent();
        loadDataSources();
        setIcon();
        initializeMenuStrip();
        loadIconButtons();
        createFolders();
        loadAccountListMenuStrip();
    }

    public void loadDataSources() { loadAccounts(); }

    private void loadAccounts() => Loader.loadDataSource(
        AccountList,
        AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.getAll()
    );

    private void loadIconButtons() {
        setIconButton(
            ConfirmSearch,
            "Search",
            20,
            20
        );
        setIconButton(
            RefreshList,
            "Refresh",
            20,
            20
        );
    }

    private void setIconButton(
        Button button,
        string iconName,
        int    width,
        int    height
    ) => button.Image = loadIcon(
             iconName,
             width,
             height
         );

    private void createFolders() { createImageFolder(); }

    private static void createImageFolder() {
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

    private void loadAccountListMenuStrip() {
        AccountList.ContextMenuStrip = AccountListMenuStrip;

        AccountInformationOption.Image = loadIcon(
            "Person"
        );

        AccountUpdateOption.Image = loadIcon(
            "PersonEdit"
        );

        AccountDeleteOption.Image = loadIcon(
            "PersonRemove"
        );
    }

    private void setIcon() {
        Assembly assembly = Assembly.GetExecutingAssembly();
        using Stream? iconStream = assembly.GetManifestResourceStream(
            Constants.RESOURCES_ICONS_PATH + ".ManageAccounts.ico"
        );
        Icon = new Icon(
            iconStream!
        );
    }

    private void initializeMenuStrip() {
        MenuStrip menuStrip = new MenuStrip();

        ToolStripMenuItem newAccount = createMenuItem(
                              "&New Account",
                              menuStripIcons.PersonAdd
                          ),
                          lists = createMenuItem(
                              "&Lists",
                              menuStripIcons.Lists
                          ),
                          countries = createMenuItem(
                              "Cou&ntries",
                              menuStripIcons.Flag2
                          ),
                          currencies = createMenuItem(
                              "Cu&rrencies",
                              menuStripIcons.Toll
                          ),
                          help = createMenuItem(
                              "&Help",
                              menuStripIcons.Help
                          ),
                          shortcuts = createMenuItem(
                              "&Shortcuts",
                              menuStripIcons.Shortcuts
                          ),
                          contactUs = createMenuItem(
                              "&Contact Us",
                              menuStripIcons.ContactSupport
                          ),
                          mobileNumber = createMenuItem(
                              "&Mobile Number",
                              menuStripIcons.Call
                          ),
                          mail = createMenuItem(
                              "&Mail",
                              menuStripIcons.Mail
                          ),
                          telegram = createMenuItem(
                              "&Telegram",
                              menuStripIcons.Telegram
                          );

        contactUs.DropDownItems.AddRange(
            mobileNumber,
            mail,
            telegram
        );
        help.DropDownItems.AddRange(
            shortcuts,
            contactUs
        );
        lists.DropDownItems.AddRange(
            countries,
            currencies
        );
        menuStrip.Items.AddRange(
            newAccount,
            lists,
            help
        );

        MainMenuStrip = menuStrip;
        Controls.Add(
            menuStrip
        );

        newAccount.Click   += newAccount_Click!;
        countries.Click    += countries_Click!;
        currencies.Click   += currencies_Click!;
        shortcuts.Click    += shortcuts_Click!;
        mobileNumber.Click += mobileNumber_Click!;
        mail.Click         += mail_Click!;
        telegram.Click     += telegram_Click!;
    }

    private static ToolStripMenuItem createMenuItem(
        string text,
        Image  icon
    ) => new(
        text,
        icon
    );

    private static(
            Image PersonAdd,
            Image Lists,
            Image Toll,
            Image Flag2,
            Image Help,
            Image Shortcuts,
            Image ContactSupport,
            Image Call,
            Image Mail,
            Image Telegram
            ) loadMenuStripIcons() => (
                                          PersonAdd : loadIcon(
                                              "PersonAdd"
                                          ),
                                          Lists : loadIcon(
                                              "Lists"
                                          ),
                                          Toll : loadIcon(
                                              "Toll"
                                          ),
                                          Flag2 : loadIcon(
                                              "Flag2"
                                          ),
                                          Help : loadIcon(
                                              "Help"
                                          ),
                                          Shortcuts : loadIcon(
                                              "ActionKey"
                                          ),
                                          ContactSupport : loadIcon(
                                              "ContactSupport"
                                          ),
                                          Call : loadIcon(
                                              "Call"
                                          ),
                                          Mail : loadIcon(
                                              "Mail"
                                          ),
                                          Telegram : loadIcon(
                                              "TelegramLogo"
                                          )
                                      );

    private static Image loadIcon(
        string name,
        int    width  = 48,
        int    height = 48
    ) => Tools.loadEmbeddedSvg(
        Constants.RESOURCES_ICONS_PATH + $".{name}.svg",
        width,
        height
    );

    private void searchBox_KeyDown(
        object       sender,
        KeyEventArgs e
    ) => Tools.disableNewLine(
        e
    );

    private void newAccount_Click(
        object    sender,
        EventArgs e
    ) {
        AddAndEditAccount addAndEditAccount = new AddAndEditAccount(
            AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants.Mode.Add
        );
        addAndEditAccount.FormClosed += addAndEditAccount_FormClosed!;
        addAndEditAccount.Show();
    }

    private void addAndEditAccount_FormClosed(
        object              sender,
        FormClosedEventArgs e
    ) => loadAccounts();

    private static void countries_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            @"Countries"
        );
    }

    private static void currencies_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            @"Currencies"
        );
    }

    private static void shortcuts_Click(
        object    sender,
        EventArgs e
    ) {
        new Shortcuts().Show();
    }

    private static void mobileNumber_Click(
        object    sender,
        EventArgs e
    ) => MessageBox.Show(
        @"+201555400034",
        @"Mobile Number",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );

    private static void mail_Click(
        object    sender,
        EventArgs e
    ) => MessageBox.Show(
        @"m4md24@gmail.com",
        @"Mail",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );

    private static void telegram_Click(
        object    sender,
        EventArgs e
    ) => MessageBox.Show(
        @"@m4md24",
        @"Telegram",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );

    private void confirmSearch_Click(
        object    sender,
        EventArgs e
    ) {}

    private void App_KeyDown(
        object       sender,
        KeyEventArgs e
    ) {
        if (
            e is {
                Control: true,
                Shift  : true,
                KeyCode: Keys.N
            }
        )
            countries_Click(
                this,
                EventArgs.Empty
            );
        else if (
            e is {
                Control: true,
                KeyCode: Keys.N
            }
        )
            newAccount_Click(
                this,
                EventArgs.Empty
            );
        else if (
            e is {
                Control: true,
                Shift  : true,
                KeyCode: Keys.R
            }
        )
            currencies_Click(
                this,
                EventArgs.Empty
            );
        else if (
            e is {
                Control: true,
                Shift  : true,
                KeyCode: Keys.S
            }
        )
            shortcuts_Click(
                this,
                EventArgs.Empty
            );
    }

    private void RefreshList_Click(
        object    sender,
        EventArgs e
    ) => loadAccounts();

    private int getAccountID_FromSelectedRow() {
        if (AccountList.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = AccountList.SelectedRows[0];
            return Convert.ToInt32(
                selectedRow.Cells[0].Value
            );
        }

        if (AccountList.SelectedCells.Count > 0) {
            DataGridViewCell selectedCell = AccountList.SelectedCells[0];
            int columnIndex = selectedCell.ColumnIndex,
                rowIndex    = selectedCell.RowIndex;

            if (columnIndex == 0)
                return Convert.ToInt32(
                    selectedCell.Value
                );

            return Convert.ToInt32(
                AccountList.Rows[rowIndex]
                           .Cells[0]
                           .Value
            );
        }

        accountNotSelectedWarning();

        return -1;
    }

    private Account getAccount_FromSelectedRow() {
        if (AccountList.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = AccountList.SelectedRows[0];
            return new Account(
                Convert.ToInt32(
                    selectedRow.Cells["accountID"].Value
                ),
                Convert.ToInt32(
                    selectedRow.Cells["personID"].Value
                ),
                Convert.ToString(
                    selectedRow.Cells["username"].Value
                ),
                Convert.ToString(
                    selectedRow.Cells["password"].Value
                ),
                Convert.ToBoolean(
                    selectedRow.Cells["isActive"].Value
                ),
                Convert.ToByte(
                    selectedRow.Cells["accountTypeID"].Value
                )
            );
        }

        if (AccountList.SelectedCells.Count > 0) {
            DataGridViewCell selectedCell = AccountList.SelectedCells[0];
            int              rowIndex     = selectedCell.RowIndex;
            DataGridViewRow  selectedRow  = AccountList.Rows[rowIndex];

            return new Account(
                Convert.ToInt32(
                    selectedRow.Cells["accountID"].Value
                ),
                Convert.ToInt32(
                    selectedRow.Cells["personID"].Value
                ),
                Convert.ToString(
                    selectedRow.Cells["username"].Value
                ),
                Convert.ToString(
                    selectedRow.Cells["password"].Value
                ),
                Convert.ToBoolean(
                    selectedRow.Cells["isActive"].Value
                ),
                Convert.ToByte(
                    selectedRow.Cells["accountTypeID"].Value
                )
            );
        }

        accountNotSelectedWarning();

        return null!;
    }

    private static void accountNotSelectedWarning() => MessageBox.Show(
        @"You Must Select Thing!",
        @"Account isn't Selected",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
    );

    private void AccountInformationOption_Click(
        object    sender,
        EventArgs e
    ) {
        int? accountID = getAccountID_FromSelectedRow();

        if (accountID == -1)
            return;

        new AccountInformation(
            ref accountID
        ).Show();
    }

    private void AccountUpdateOption_Click(
        object    sender,
        EventArgs e
    ) {
        Account account = getAccount_FromSelectedRow();

        if (account is null)
            return;

        AddAndEditAccount addAndEditAccount = new AddAndEditAccount(
            AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants.Mode.Update,
            account
        );
        addAndEditAccount.FormClosed += addAndEditAccount_FormClosed!;
        addAndEditAccount.Show();
        loadAccounts();
    }

    private void AccountDeleteOption_Click(
        object    sender,
        EventArgs e
    ) {
        Account? account = getAccount_FromSelectedRow();

        if (account is null)
            return;

        int? accountID = account.accountID;

        if (accountID == -1)
            return;

        DialogResult result = MessageBox.Show(
            @$"Are you delete {accountID}?",
            @"Delete Account",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );

        if (result == DialogResult.OK)
            deleteSelectedAccount(
                ref account
            );
    }

    private void deleteSelectedAccount(
        ref Account account
    ) {
        FullAccounts.delete(
            ref account
        );
        loadAccounts();
    }
}