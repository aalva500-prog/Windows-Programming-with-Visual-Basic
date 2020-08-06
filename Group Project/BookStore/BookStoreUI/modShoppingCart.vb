Module modShoppingCart
    ' Constants Declaration
    Public Const TAX As Double = 0.06

    Function CalculateSubtotal() As Decimal
        Dim decSubTotal As Decimal = 0
        Dim strCost As String

        For Each strItem In frmShoppingCart.lstTitlesToOrder.Items
            ' Separate the info using the comma as delimiter between them
            Dim arrTitleDetails() As String = Split(strItem, " --- ")
            strCost = arrTitleDetails(3)
            decSubTotal = decSubTotal + CDec(strCost.Substring(6))
        Next

        Return decSubTotal
    End Function

    Function CalculateTax() As Decimal
        Dim subTotal As Decimal
        ' Calculate SubTotal
        subTotal = CalculateSubtotal()
        ' Return Tax
        Return subTotal * TAX
    End Function

    Function CalculateTotal() As Decimal
        ' Local variables
        Dim decTax As Decimal
        Dim decSubTotal As Decimal
        Dim decTotal As Decimal
        Dim strDiscounts As String

        ' Calculations
        decSubTotal = CalculateSubtotal()
        decTax = CalculateTax()
        strDiscounts = frmShoppingCart.lblDiscounts.Text.Substring(2)
        decTotal = (decSubTotal - CDec(Replace(strDiscounts, ")", ""))) + decTax

        ' Return total
        Return decTotal
    End Function

    Function GenerateOrderNum() As String
        Dim strOrderNum As String = ""
        Dim rdm As New Random()
        strOrderNum = "O" + rdm.Next(0, 10000000).ToString
        Return strOrderNum
    End Function

    Function VerifyTitleExistence(ByVal strTitleID) As Boolean
        Dim blnFound As Boolean = False
        Dim strID As String

        For Each strItem In frmShoppingCart.lstTitlesToOrder.Items
            Dim arrTitleDetails() As String = Split(strItem, " --- ")
            Dim arrTitleID() As String = Split(arrTitleDetails(0), " - ")

            strID = arrTitleID(0)
            If strID = strTitleID Then
                blnFound = True
                Exit For
            Else
                blnFound = False
            End If
        Next

        Return blnFound
    End Function
End Module
