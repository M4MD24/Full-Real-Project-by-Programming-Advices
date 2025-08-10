using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class App : Form {
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
            ) icons = loadIcons();

    public App() {
        InitializeComponent();
        setIcon();
        initializeMenuStrip();
        loadIconButtons();
        createFolders();
        loadAccountListMenuStrip();
    }

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
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string imageDirectory = Path.Combine(
            baseDirectory,
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

    private void loadAccountListMenuStrip() {}

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
                              icons.PersonAdd
                          ),
                          lists = createMenuItem(
                              "&Lists",
                              icons.Lists
                          ),
                          countries = createMenuItem(
                              "Cou&ntries",
                              icons.Flag2
                          ),
                          currencies = createMenuItem(
                              "Cu&rrencies",
                              icons.Toll
                          ),
                          help = createMenuItem(
                              "&Help",
                              icons.Help
                          ),
                          shortcuts = createMenuItem(
                              "&Shortcuts",
                              icons.Shortcuts
                          ),
                          contactUs = createMenuItem(
                              "&Contact Us",
                              icons.ContactSupport
                          ),
                          mobileNumber = createMenuItem(
                              "&Mobile Number",
                              icons.Call
                          ),
                          mail = createMenuItem(
                              "&Mail",
                              icons.Mail
                          ),
                          telegram = createMenuItem(
                              "&Telegram",
                              icons.Telegram
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
            ) loadIcons() => (
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

    private static void newAccount_Click(
        object    sender,
        EventArgs e
    ) {
        new AddAndEditAccount(
            AccountManagementSystem_ClassLibrary_DataAccessLayer.Utilities.Constants.Mode.Add
        ).Show();
    }

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

    private void App_Load(
        object    sender,
        EventArgs e
    ) => loadAccounts();

    private void loadAccounts() {
        AccountList.DataSource = AccountManagementSystem_ClassLibrary_BusinessLayer.Accounts.getAll();
    }
}