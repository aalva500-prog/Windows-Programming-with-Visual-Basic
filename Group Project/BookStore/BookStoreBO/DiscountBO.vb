Imports BookStoreDO

Public Class DiscountBO
    Private adapterDiscounts As New _
    BookStoreDataSetTableAdapters.discountsTableAdapter

    Public Function FindByDiscountType(ByVal strType As String) _
     As BookStoreDataSet.discountsRow

        Dim table As BookStoreDataSet.discountsDataTable
        table = adapterDiscounts.FindDiscountsByType(strType)
        Return table.Rows(0)
    End Function

    Public Function FindByStoreID(ByVal strID As String) _
     As BookStoreDataSet.discountsRow

        Dim table As BookStoreDataSet.discountsDataTable
        table = adapterDiscounts.FindDiscountByStoreID(strID)
        Return table.Rows(0)
    End Function
End Class
