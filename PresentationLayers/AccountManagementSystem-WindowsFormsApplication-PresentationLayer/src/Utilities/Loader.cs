using System.Collections.Generic;
using System.Windows.Forms;
using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

public interface Loader {
    public void loadDataSources();

    public static void loadDataSource(
        ComboBox      comboBox,
        List<string>? elements
    ) => comboBox.DataSource = elements;

    public static void loadDataSource(
        DataGridView   dataGridView,
        List<Account>? elements
    ) => dataGridView.DataSource = elements;
}