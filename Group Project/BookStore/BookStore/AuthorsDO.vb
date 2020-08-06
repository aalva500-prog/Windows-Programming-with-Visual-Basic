Public Class AuthorsDO
    Private adapter As New _
     BookStoreDataSetTableAdapters.authorsTableAdapter

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function Delete(ByVal Id As String, ByVal lastName As String,
                           ByVal firstName As String, ByVal phone As String,
                           ByVal address As String, ByVal city As String, ByVal state As String,
                           ByVal zip As String, ByVal contract As Boolean) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(Id, lastName, firstName, phone, address, city, state, zip, contract)
        Return rowsAffected > 0
    End Function


End Class
