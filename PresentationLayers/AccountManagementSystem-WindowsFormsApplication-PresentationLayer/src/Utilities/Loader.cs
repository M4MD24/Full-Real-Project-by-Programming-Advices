using System.Collections.Generic;
using System.Windows.Forms;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

public interface Loader {
    public static void loadDataSource(
        ComboBox      comboBox,
        List<string>? elements
    ) => comboBox.DataSource = elements;
}