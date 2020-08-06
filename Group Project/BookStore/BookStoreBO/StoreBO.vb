Imports BookStoreDO

Public Class StoreBO
    Private adapter As New _
     BookStoreDataSetTableAdapters.storesTableAdapter

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property
End Class
