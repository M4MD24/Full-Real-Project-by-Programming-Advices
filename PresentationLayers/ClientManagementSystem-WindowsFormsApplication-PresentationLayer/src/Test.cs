using System;
using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class Test : Form {
    private readonly ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees testFees;

    public Test(
        ref ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Fees testFees
    ) {
        InitializeComponent();
        this.testFees = testFees;
        Text          = testFees.feesName;
        Tools.setIcon(
            this,
            "Assignment"
        );
        initializeFields();
    }

    private void initializeFields() => clearAllFields();

    private static void clearField(
        ref DateTimePicker dateTimePicker
    ) => dateTimePicker.Value = DateTime.Now;

    private void clearAllFields() {
        clearField(
            ref TestDateTimeAnswer
        );
    }

    private void Submit_Click(
        object    sender,
        EventArgs e
    ) {
        Currency? currency = ClientManagementSystem_ClassLibrary_BusinessLayer.Currencies.get(
            1
        );

        DialogResult submit = MessageBox.Show(
            @$"Fees = {testFees.amount} {currency!.currencyName}{'\n'}Are you submit?",
            @"Delete License",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );

        if (submit != DialogResult.OK)
            return;

        ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Test test = new ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.Test(
            TestDateTimeAnswer.Value,
            currency.currencyID
        );

        int? testID = ClientManagementSystem_ClassLibrary_BusinessLayer.Tests.add(
            test
        );

        switch (testFees.feesID) {
            case 15:
                EyeTest eyeTest = new EyeTest(
                    testID
                );
                ClientManagementSystem_ClassLibrary_BusinessLayer.EyeTests.add(
                    eyeTest
                );
            break;
            case 16:
                TheoreticalTest theoreticalTest = new TheoreticalTest(
                    testID
                );
                ClientManagementSystem_ClassLibrary_BusinessLayer.TheoreticalTests.add(
                    theoreticalTest
                );
            break;
            case 17:
                DrivingTest drivingTest = new DrivingTest(
                    testID
                );
                ClientManagementSystem_ClassLibrary_BusinessLayer.DrivingTests.add(
                    drivingTest
                );
            break;
        }

        clearAllFields();
        clearAllErrors(
            this
        );

        Close();
    }

    private void clearAllErrors(
        Control parent
    ) {
        foreach (Control control in parent.Controls) {
            ErrorProvider.SetError(
                control,
                string.Empty
            );

            if (control.HasChildren)
                clearAllErrors(
                    control
                );
        }
    }

    private void Clear_Click(
        object    sender,
        EventArgs e
    ) => clearAllFields();
}