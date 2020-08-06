Public Class frmInvoice
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = frmShoppingCart.dtpOrderDate.Value
        lblOrderNum.Text = frmShoppingCart.lblOrderNum.Text
        lblDiscounts.Text = frmShoppingCart.lblDiscounts.Text
        lblSubTotal.Text = frmShoppingCart.lblSubTotal.Text
        lblTax.Text = frmShoppingCart.lblTax.Text
        lblTotal.Text = frmShoppingCart.lblTotal.Text
        For Each strItem In frmShoppingCart.lstTitlesToOrder.Items
            lstItemsOrdered.Items.Add(strItem)
        Next
    End Sub

    Private Sub frmInvoice_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmShoppingCart.Close()
    End Sub
End Class