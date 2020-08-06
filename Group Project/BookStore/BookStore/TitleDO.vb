Public Class TitleDO
    Public adapter As New _
    BookStoreDataSetTableAdapters.titlesTableAdapter

    Public Function FindById(ByVal Id As String) _
     As BookStoreDataSet.titlesRow

        Dim table As BookStoreDataSet.titlesDataTable
        table = adapter.GetData()
        Return table.FindById(Id)
    End Function
End Class
