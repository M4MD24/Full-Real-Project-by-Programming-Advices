using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ClientManagementSystem_ClassLibrary_DataAccessLayer;
using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;
using ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;
using Coverages = ClientManagementSystem_ClassLibrary_BusinessLayer.Coverages;
using Payments = ClientManagementSystem_ClassLibrary_BusinessLayer.Payments;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer;

public partial class AddRequest : Form {
    private readonly int?    clientID;
    private          decimal totalAmounts;

    public AddRequest(
        int? clientID
    ) {
        this.clientID = clientID;
        InitializeComponent();
        Tools.setIcon(
            this,
            "Add"
        );
        loadDataSources();
        initializeFields();
    }

    private void initializeFields() {
        clearAllFields();
        setTotal();
    }

    private void clearAllFields() {
        clearField(
            ref LicenseTypeNameAnswer
        );
        clearField(
            ref CoverageNameAnswer
        );
        clearField(
            ref PaymentMethodAnswer
        );
        clearFees();
    }

    private void clearFees() {
        clearField(
            ref LicenseTypeAmountAnswer
        );
        clearField(
            ref CoverageAmountAnswer
        );
    }

    private static void clearField(
        ref Label label
    ) => label.Text = "";

    private static void clearField(
        ref ComboBox comboBox
    ) => comboBox.SelectedIndex = -1;

    private void loadDataSources() {
        Loader.loadDataSource(
            LicenseTypeNameAnswer,
            ClientManagementSystem_ClassLibrary_BusinessLayer.LicenseTypes.getAllLicenseTypeNames()
        );
        Loader.loadDataSource(
            CoverageNameAnswer,
            Coverages.getAllCoverageNames()
        );
        Loader.loadDataSource(
            PaymentMethodAnswer,
            PaymentMethods.getAllPaymentMethodNames()
        );

        const byte CURRENCY_ID = 1;

        string? currencyName = ClientManagementSystem_ClassLibrary_BusinessLayer.Currencies.get(
            CURRENCY_ID
        )!.currencyName;

        LicenseTypeAmountCodeAnswer.Text     = currencyName;
        CoverageAmountCodeAnswer.Text        = currencyName;
        LicenseIssuanceAmountCodeAnswer.Text = currencyName;
        RequestAmountCodeAnswer.Text         = currencyName;
        TotalAmountCodeAnswer.Text           = currencyName;

        LicenseIssuanceAmountAnswer.Text = ClientManagementSystem_ClassLibrary_BusinessLayer.Fees.get(
            2
        )!.amount.ToString();

        RequestAmountAnswer.Text = ClientManagementSystem_ClassLibrary_BusinessLayer.Fees.get(
            1
        )!.amount.ToString();
    }

    private void ClearFields_Click(
        object    sender,
        EventArgs e
    ) {
        DialogResult clear = MessageBox.Show(
            @"Do you want clear all fields?",
            @"Clear Fields",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        );

        if (clear != DialogResult.Yes)
            return;

        clearAllFields();
        clearAllErrors(
            this
        );

        setTotal();
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

    private void Submit_Click(
        object    sender,
        EventArgs e
    ) {
        if (!isValidData())
            return;

        DialogResult submit = MessageBox.Show(
            @"Do you want submit?",
            @"Submit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        );

        if (submit != DialogResult.Yes)
            return;

        DateTime currentDateTime = DateTime.Now;

        byte? paymentMethodID = PaymentMethods.getPaymentMethodByPaymentMethodName(
                                                  PaymentMethodAnswer.Text
                                              )!
                                              .paymentMethodID;

        Payment payment = new Payment(
            totalAmounts,
            1,
            currentDateTime,
            paymentMethodID
        );

        byte? licenseTypeID = ClientManagementSystem_ClassLibrary_BusinessLayer.LicenseTypes.get(
            LicenseTypeNameAnswer.Text
        )!.licenseTypeID;

        int? paymentID = Payments.add(
            payment
        );

        byte? coverageID = Coverages.get(
                                        CoverageNameAnswer.Text
                                    )!
                                    .coverageID;

        byte licenseIssuanceID = 1;

        License license = new License(
            licenseTypeID,
            clientID,
            coverageID,
            licenseIssuanceID,
            false
        );

        int? licenseID = ClientManagementSystem_ClassLibrary_BusinessLayer.Licenses.add(
            license
        );

        Request request = new Request(
            currentDateTime,
            clientID,
            paymentID,
            licenseID
        );

        ClientManagementSystem_ClassLibrary_BusinessLayer.Requests.add(
            request
        );

        MessageBox.Show(
            @"A new request has been created",
            @"Create New Request",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );

        Close();
    }

    private bool isValidData() {
        bool isValid = true;

        isValid &= checkField(
            LicenseTypeNameAnswer
        );
        isValid &= checkField(
            CoverageNameAnswer
        );
        isValid &= checkField(
            PaymentMethodAnswer
        );

        return isValid;
    }

    private bool checkField(
        ComboBox comboBox,
        bool     isValid = true
    ) {
        if (
            string.IsNullOrWhiteSpace(
                comboBox.Text
            )
        ) {
            ErrorProvider.SetError(
                comboBox,
                Constants.ErrorMessages.EMPTY
            );
            isValid = false;
        } else
            ErrorProvider.SetError(
                comboBox,
                string.Empty
            );

        return isValid;
    }

    private void LicenseTypeNameAnswer_SelectedIndexChanged(
        object    sender,
        EventArgs e
    ) {
        if (
            !string.IsNullOrWhiteSpace(
                LicenseTypeNameAnswer.Text
            )
        ) {
            LicenseTypeAmountAnswer.Text = ClientManagementSystem_ClassLibrary_BusinessLayer.Fees.get(
                LicenseTypeNameAnswer.Text
            )!.amount.ToString();

            setTotal();
        }
    }

    private void CoverageNameAnswer_SelectedIndexChanged(
        object    sender,
        EventArgs e
    ) {
        if (
            !string.IsNullOrWhiteSpace(
                CoverageNameAnswer.Text
            )
        ) {
            CoverageAmountAnswer.Text = ClientManagementSystem_ClassLibrary_BusinessLayer.Fees.get(
                CoverageNameAnswer.Text
            )!.amount.ToString();

            setTotal();
        }
    }

    private void setTotal() {
        totalAmounts = Convert.ToDecimal(
                           RequestAmountAnswer.Text
                       ) + Convert.ToDecimal(
                           LicenseIssuanceAmountAnswer.Text
                       );

        string licenseTypeAmountText = LicenseTypeAmountAnswer.Text;

        if (
            !String.IsNullOrWhiteSpace(
                licenseTypeAmountText
            )
        )
            totalAmounts += Convert.ToDecimal(
                licenseTypeAmountText
            );

        string coverageAmountText = CoverageAmountAnswer.Text;

        if (
            !String.IsNullOrWhiteSpace(
                coverageAmountText
            )
        )
            totalAmounts += Convert.ToDecimal(
                coverageAmountText
            );

        TotalAmountAnswer.Text = totalAmounts.ToString(
            CultureInfo.CurrentCulture
        );
    }
}