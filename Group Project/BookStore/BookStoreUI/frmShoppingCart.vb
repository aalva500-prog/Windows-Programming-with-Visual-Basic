Option Strict On
Imports System.Globalization
Imports System.Windows.Forms
Imports BookStoreBO
Imports BookStoreDO

Public Class frmShoppingCart

    Private adapter As New BookStoreDataSetTableAdapters.salesTableAdapter

    Public Shared Property LastError As String

    ' Declare classes
    Private mStores As New StoreBO
    Public mTitle As TitleBO
    Private mDiscount As New DiscountBO
    Private mSaleDO As New SalesDO

    ' Variables
    Dim decSubTotal As Decimal = 0
    Dim decTotal As Decimal = 0
    Dim decTax As Decimal = 0
    Dim decDiscount As Decimal = 0
    Dim strDiscountType As String
    Private formLoading As Boolean = True
    Private bolStoreDiscount As Boolean = False

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If lstTitlesToOrder.Items.Count <> 0 Then
            Dim dlgResult As DialogResult
            dlgResult = MessageBox.Show(Me, "Pending changes, sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo)
            If dlgResult = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Create an instance of frmFindTitle
        Dim frmFind As New frmFindTitle

        ' Display the form
        frmFind.ShowDialog()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtTitle.Text = "" Or mtbQuantity.Text = "" Then
            MessageBox.Show(Me, "Please Search a Title and Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If VerifyTitleExistence(mTitle.ID) = False Then
                ' Declare local variables
                Dim decPrice As Decimal
                Dim intQuantity As Integer
                Dim decCost As Decimal


                ' Assign values to variables
                decPrice = mTitle.Price
                intQuantity = CInt(mtbQuantity.Text)
                decCost = decPrice * intQuantity

                ' add Item to List
                lstTitlesToOrder.Items.Insert(0, mTitle.ID + " - " + mTitle.Title + " --- Qty: " + intQuantity.ToString +
                                          " --- Price: " + decPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")) +
                                            " --- Cost: " + decCost.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")))

                'Clear Title and Quantity fields
                txtTitle.Text = ""
                mtbQuantity.Text = ""

                ' Populate Variables
                decSubTotal = CalculateSubtotal()
                decTax = CalculateTax()
                decTotal = CalculateTotal()

                ' Display Calculations in labels
                lblSubTotal.Text = decSubTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
                lblTax.Text = decTax.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
                lblTotal.Text = decTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            Else
                MessageBox.Show(Me, "This Title has already been inserted in the shopping cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTitle.Text = ""
                mtbQuantity.Text = ""
            End If
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        Dim intIndex As Integer

        intIndex = lstTitlesToOrder.SelectedIndex

        If intIndex <> -1 Then
            ' remove selected Item
            lstTitlesToOrder.Items.RemoveAt(intIndex)

            ' Populate Variables
            decSubTotal = CalculateSubtotal()
            decTax = CalculateTax()
            decTotal = CalculateTotal()

            ' Display Calculations in labels
            lblSubTotal.Text = decSubTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblTax.Text = decTax.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblTotal.Text = decTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        Else
            MessageBox.Show(Me, "No Item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTitle.Text = ""
        mtbQuantity.Text = ""
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If cboPayTerms.SelectedIndex <> -1 And cboStore.SelectedIndex <> -1 Then
            If lstTitlesToOrder.Items.Count = 0 Then
                MessageBox.Show(Me, "There are no Items in the Order List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dlgResult As DialogResult
                dlgResult = MessageBox.Show(Me, "Are you ready to place this order?", "Confirmation", MessageBoxButtons.YesNo)
                If dlgResult = System.Windows.Forms.DialogResult.Yes Then

                    For Each strTitle In lstTitlesToOrder.Items
                        Dim arrTitleDetails() As String = Split(strTitle.ToString, " --- ")
                        Dim shtQty As Short = CShort(arrTitleDetails(1).Substring(4))
                        Dim arrTitleID() As String = Split(arrTitleDetails(0), " - ")
                        Dim strTitleID As String = arrTitleID(0)

                        Try
                            LastError = String.Empty
                            adapter.Insert(cboStore.SelectedValue.ToString, lblOrderNum.Text, dtpOrderDate.Value, shtQty, cboPayTerms.SelectedItem.ToString, strTitleID)
                        Catch ex As Exception
                            LastError = ex.Message
                            MessageBox.Show(LastError)
                        End Try
                    Next
                    Dim frmReceipt As New frmInvoice
                    frmReceipt.ShowDialog()
                End If
            End If
        Else
            MessageBox.Show(Me, "You must select a Store and Pay Term", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmShoppingCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill Store ComboBox
        cboStore.DataSource = mStores.Items
        cboStore.DisplayMember = "stor_name"
        cboStore.ValueMember = "stor_id"
        cboStore.SelectedIndex = -1
        formLoading = False

        ' Clear Screen
        txtTitle.Text = ""
        mtbQuantity.Text = ""
        cboPayTerms.SelectedIndex = -1
        chkInitialCustomer.Checked = False
        lstTitlesToOrder.Items.Clear()
        cboStore.SelectedIndex = -1
        lblDiscounts.Text = "$0.00"
        lblSubTotal.Text = "$0.00"
        lblTax.Text = "$0.00"
        lblTotal.Text = "$0.00"
        dtpOrderDate.Value = Date.Today
        lblOrderNum.Text = GenerateOrderNum()
    End Sub

    Private Sub chkInitialCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles chkInitialCustomer.CheckedChanged
        'Get the desired Discount Type
        strDiscountType = "Initial Customer"
        Dim row As BookStoreDO.BookStoreDataSet.discountsRow = mDiscount.FindByDiscountType(strDiscountType)

        If chkInitialCustomer.Checked = True Then
            decDiscount = 0 - (CDec(Replace(lblDiscounts.Text.Substring(2), ")", "")) + row.discount)
            lblDiscounts.Text = decDiscount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            MessageBox.Show(Me, "Discount of $" & row.discount & " applied for being a New Customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            decDiscount = 0 - (CDec(Replace(lblDiscounts.Text.Substring(2), ")", "")) - row.discount)
            lblDiscounts.Text = decDiscount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        End If

        ' Populate Variables
        decSubTotal = CalculateSubtotal()
        decTax = CalculateTax()
        decTotal = CalculateTotal()

        ' Display Calculations in labels
        lblSubTotal.Text = decSubTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        lblTax.Text = decTax.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        lblTotal.Text = decTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
    End Sub

    Private Sub cboStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStore.SelectedIndexChanged
        If Not formLoading Then
            'Get the desired Discount Type
            strDiscountType = "Customer Discount"
            Dim row As BookStoreDO.BookStoreDataSet.discountsRow = mDiscount.FindByDiscountType(strDiscountType)

            If cboStore.SelectedIndex = 5 Then
                If bolStoreDiscount = False Then
                    decDiscount = 0 - (CDec(Replace(lblDiscounts.Text.Substring(2), ")", "")) + row.discount)
                    lblDiscounts.Text = decDiscount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
                    bolStoreDiscount = True
                    MessageBox.Show(Me, "Discount of $" & row.discount & " applied for buying in this store.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If bolStoreDiscount = True Then
                    decDiscount = 0 - (CDec(Replace(lblDiscounts.Text.Substring(2), ")", "")) - row.discount)
                    lblDiscounts.Text = decDiscount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
                    bolStoreDiscount = False
                End If
            End If

            ' Populate Variables
            decSubTotal = CalculateSubtotal()
            decTax = CalculateTax()
            decTotal = CalculateTotal()

            ' Display Calculations in labels
            lblSubTotal.Text = decSubTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblTax.Text = decTax.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblTotal.Text = decTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        End If
    End Sub
End Class