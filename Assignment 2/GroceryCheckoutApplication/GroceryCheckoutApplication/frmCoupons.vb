Public Class frmCoupons
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCloseCoupons.Click
        ' Clear Item Selected
        strItemName = String.Empty
        dblItemPrice = 0

        ' Close form Coupons
        Me.Close()
    End Sub

    Private Sub frmCoupons_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Populate Coupons ListBox
        lstCoupon.Items.Clear()
        lstCoupon.Items.Add("Milk (COUPON)")
        lstCoupon.Items.Add("Sugar (COUPON)")
        lstCoupon.Items.Add("Coffee (COUPON)")
    End Sub

    Private Sub btnAddCoupon_Click(sender As Object, e As EventArgs) Handles btnAddCoupon.Click
        Try
            ' Get selected Item Name
            strItemName = lstCoupon.SelectedItem.ToString

            ' Get selected Item Price
            If strItemName = "Milk (COUPON)" Then
                dblItemPrice = MILK_COUPON
            ElseIf strItemName = "Sugar (COUPON)" Then
                dblItemPrice = SUGAR_COUPON
            Else
                dblItemPrice = COFFEE_COUPON
            End If

            'Close Form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please select an Item")
        End Try
    End Sub
End Class