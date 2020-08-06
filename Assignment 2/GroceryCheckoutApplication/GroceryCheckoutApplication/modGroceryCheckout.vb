Module modGroceryCheckout
    ' Constants Declaration
    Public Const TAX As Double = 0.06
    Public Const SHIPPING_RATE As Integer = 2
    Public Const BREAD_PRICE As Double = 3.95
    Public Const MILK_PRICE As Double = 4.5
    Public Const SUGAR_PRICE As Double = 2.5
    Public Const COFFEE_PRICE As Double = 4.95
    Public Const MILK_COUPON As Double = 0.75
    Public Const SUGAR_COUPON As Double = 0.55
    Public Const COFFEE_COUPON As Double = 1.85

    ' Global Variables
    Public dblItemPrice As Double = 0
    Public strItemName As String = ""

    Function Calculate_Shipping() As Double
        Dim dblShipping As Double = 0
        Dim intCount As Integer = 0

        ' Verify that Delivery CheckBox is Checked
        If (frmShopList.chkDelivery.Checked = True) Then
            ' Loop through List of Shopping Items
            For Each strProduct In frmShopList.lstShoppingList.Items
                ' Verify that item is a PRODUCT
                If strProduct.ToString().Contains("PRODUCT") Then
                    intCount += 1
                End If
            Next
            ' Calculate shipping cost
            dblShipping = intCount * SHIPPING_RATE
        End If

        ' Return calculated shipping
        Return dblShipping
    End Function

    Function CalculateProductsSum() As Double
        Dim dblProducts As Double = 0

        For Each strProduct In frmShopList.lstShoppingList.Items
            ' Verify that item is a PRODUCT
            If strProduct.ToString().Contains("PRODUCT") Then
                If (strProduct.ToString().Contains("Bread")) Then
                    dblProducts = dblProducts + BREAD_PRICE
                ElseIf (strProduct.ToString().Contains("Milk")) Then
                    dblProducts = dblProducts + MILK_PRICE
                ElseIf (strProduct.ToString().Contains("Sugar")) Then
                    dblProducts = dblProducts + SUGAR_PRICE
                Else
                    dblProducts = dblProducts + COFFEE_PRICE
                End If
            End If
        Next

        ' Return Products Sum
        Return dblProducts
    End Function

    Function CalculateCouponsSum() As Double
        Dim dblCoupons As Double = 0

        For Each strProduct In frmShopList.lstShoppingList.Items
            ' Verify that item is a PRODUCT
            If strProduct.ToString().Contains("COUPON") Then
                If (strProduct.ToString().Contains("Milk")) Then
                    dblCoupons = dblCoupons + MILK_COUPON
                ElseIf (strProduct.ToString().Contains("Sugar")) Then
                    dblCoupons = dblCoupons + SUGAR_COUPON
                Else
                    dblCoupons = dblCoupons + COFFEE_COUPON
                End If
            End If
        Next

        ' Return Coupons Sum
        Return dblCoupons
    End Function

    Function CalculateTax() As Double
        Dim subTotal As Double
        ' Calculate SubTotal
        subTotal = CalculateProductsSum()
        ' Return Tax
        Return subTotal * TAX
    End Function

    Function CalculateTotal() As Double
        ' Variables
        Dim dblProducts As Double
        Dim dblCoupons As Double
        Dim dblShipping As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        ' Calculations
        dblProducts = CalculateProductsSum()
        dblCoupons = CalculateCouponsSum()
        dblShipping = Calculate_Shipping()
        dblTax = CalculateTax()

        ' Calculate Total
        dblTotal = (dblProducts - dblCoupons) + dblTax + dblShipping

        ' Return Total
        Return dblTotal
    End Function

End Module
