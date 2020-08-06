Imports BookStoreDO

Public Class SaleBO

    Public Shared Property LastError As String

    Public Function Insert(ByVal adapter As BookStoreDataSetTableAdapters.salesTableAdapter, ByVal chaStoreID As Char, ByVal strOrderNum As String,
                           ByVal datOrderDate As Date, ByVal shtQty As Short,
                           ByVal strPayTerm As String, ByVal strTitleID As String) As Boolean
        ' Insert a new row into the Sales table. Return 
        ' True if successful. If an exception is thrown, 
        ' LastError will hold an error message.
        Try
            LastError = String.Empty
            adapter.Insert(chaStoreID, strOrderNum, datOrderDate,
              shtQty, strPayTerm, strTitleID)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

End Class
