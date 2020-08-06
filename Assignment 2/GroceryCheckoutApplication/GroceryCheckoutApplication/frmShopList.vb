'Affirmation of Authorship:

'Name: Aaron Alvarez

'Date: 06/05/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by anyone else.

Option Strict On
Imports System.Globalization

Public Class frmShopList
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close Form
        Me.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ' Clear the list box
        lstShoppingList.Items.Clear()

        ' Clear labels
        lblProducts.Text = String.Empty
        lblCoupons.Text = String.Empty
        lblTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Unckeked Delivery CheckBox
        chkDelivery.Checked = False
    End Sub

    Private Sub CouponsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouponsToolStripMenuItem.Click
        ' Display Coupons Form
        frmCoupons.ShowDialog()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        ' Display Products Form
        frmProducts.ShowDialog()
    End Sub

    Private Sub frmShopList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' populate Contains ComboBox using with
        With cboContains
            .Items.Add("(COUPON)")
            .Items.Add("(PRODUCT)")
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display message about the Application
        MessageBox.Show(" Grocery Checkout Application ---------- Version: 1.2 ", "About")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Variables
        Dim dblProducts As Double
        Dim dblCoupons As Double
        Dim dblTax As Double
        Dim dblShipping As Double
        Dim dblTotal As Double
        Dim intIndex As Integer

        ' remove selected item  
        intIndex = lstShoppingList.SelectedIndex
        If intIndex <> -1 Then
            lstShoppingList.Items.RemoveAt(intIndex)
        Else
            MessageBox.Show("No Item selected.")
        End If

        ' Populate Variables
        dblProducts = CalculateProductsSum()
        dblCoupons = 0 - CalculateCouponsSum()
        dblTax = CalculateTax()
        dblShipping = Calculate_Shipping()
        dblTotal = CalculateTotal()

        ' Display calculations in labels
        lblProducts.Text = dblProducts.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        lblCoupons.Text = dblCoupons.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        lblTax.Text = dblTax.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        lblShipping.Text = dblShipping.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        lblTotal.Text = dblTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
    End Sub

    Private Sub frmShopList_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Variables
        Dim dblProducts As Double
        Dim dblCoupons As Double
        Dim dblTax As Double
        Dim dblShipping As Double
        Dim dblTotal As Double

        ' Verify that Item is selected
        If strItemName <> String.Empty And dblItemPrice > 0 Then
            ' Add Item to ListBox Shopping
            lstShoppingList.Items.Add(strItemName)

            ' Populate Variables
            dblProducts = CalculateProductsSum()
            dblCoupons = 0 - CalculateCouponsSum()
            dblTax = CalculateTax()
            dblShipping = Calculate_Shipping()
            dblTotal = CalculateTotal()

            ' Display calculations in labels
            lblProducts.Text = dblProducts.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblCoupons.Text = dblCoupons.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblTax.Text = dblTax.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblShipping.Text = dblShipping.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            lblTotal.Text = dblTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))

            ' Clear Selected Item
            strItemName = String.Empty
            dblItemPrice = 0
        End If
    End Sub

    Private Sub cboContains_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContains.SelectedIndexChanged
        ' Boolean Variables
        Dim blnContainsProduct As Boolean = False
        Dim blnContainsCoupon As Boolean = False

        ' Verify if List is Empty or Not
        If lstShoppingList.Items.Count > 0 Then
            ' Verify if COUPON is selected in Contains ComboBox
            If cboContains.SelectedItem.ToString.Contains("COUPON") Then

                ' Verify that Shopping List has at least a COUPON
                For Each strItems In lstShoppingList.Items
                    If strItems.ToString.Contains("COUPON") Then
                        blnContainsCoupon = True
                        Exit For
                    End If
                Next

                ' Display messages
                If blnContainsCoupon = True Then
                    MessageBox.Show("Contains")
                Else
                    MessageBox.Show("Does Not Contain")
                End If

                ' Verify if PRODUCT is selected in Contains ComboBox
            Else cboContains.SelectedItem.ToString.Contains("PRODUCT")
                ' Verify that Shopping List has at least a PRODUCT
                For Each strItems In lstShoppingList.Items
                        If strItems.ToString.Contains("PRODUCT") Then
                            blnContainsProduct = True
                            Exit For
                        End If
                    Next

                ' Display messages
                If blnContainsProduct = True Then
                    MessageBox.Show("Contains")
                Else
                    MessageBox.Show("Does Not Contain")
                End If
            End If
        Else
            MessageBox.Show("The List is Empty")
        End If
    End Sub
End Class
