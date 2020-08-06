Public Class frmProducts
    Private Sub btnCloseProducts_Click(sender As Object, e As EventArgs) Handles btnCloseProducts.Click
        ' Clear Item Selected
        strItemName = String.Empty
        dblItemPrice = 0

        ' Close form Products
        Me.Close()
    End Sub

    Private Sub frmProducts_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Populate Products ListBox
        lstProduct.Items.Clear()
        lstProduct.Items.Add("Bread (PRODUCT)")
        lstProduct.Items.Add("Milk (PRODUCT)")
        lstProduct.Items.Add("Sugar (PRODUCT)")
        lstProduct.Items.Add("Coffee (PRODUCT)")
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            ' Get selected Item Name
            strItemName = lstProduct.SelectedItem.ToString

            ' Get selected Item Price
            If strItemName = "Bread (PRODUCT)" Then
                dblItemPrice = BREAD_PRICE
            ElseIf strItemName = "Milk (PRODUCT)" Then
                dblItemPrice = MILK_PRICE
            ElseIf strItemName = "Sugar (PRODUCT)" Then
                dblItemPrice = SUGAR_PRICE
            Else
                dblItemPrice = COFFEE_PRICE
            End If

            'Close Form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please select an Item")
        End Try
    End Sub
End Class