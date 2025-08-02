using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class App : Form {
    public App() {
        InitializeComponent();
        setIcon();
        initializeMenuStrip();
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

        var icons = loadIcons();

        ToolStripMenuItem newAccount = createMenuItem(
                              "New Account",
                              icons.PersonAdd
                          ),
                          lists = createMenuItem(
                              "Lists",
                              icons.Lists
                          ),
                          countries = createMenuItem(
                              "Countries",
                              icons.Flag2
                          ),
                          currencies = createMenuItem(
                              "Currencies",
                              icons.Toll
                          ),
                          help = createMenuItem(
                              "Help",
                              icons.Help
                          ),
                          shortcuts = createMenuItem(
                              "Shortcuts",
                              icons.Shortcuts
                          ),
                          contactUs = createMenuItem(
                              "Contact Us",
                              icons.ContactSupport
                          ),
                          mobileNumber = createMenuItem(
                              "Mobile Number",
                              icons.Call
                          ),
                          mail = createMenuItem(
                              "Mail",
                              icons.Mail
                          ),
                          telegram = createMenuItem(
                              "Telegram",
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
        string name
    ) => Tools.loadEmbeddedSvg(
        Constants.RESOURCES_ICONS_PATH + $".{name}.svg",
        48,
        48
    );
}