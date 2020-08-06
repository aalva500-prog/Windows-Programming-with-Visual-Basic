Public Class PublishersDO
    Public adapter As New _
    BookStoreDataSetTableAdapters.publishersTableAdapter

    Public Shared Property LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function Insert(ByVal publisherId As String,
     ByVal publisherName As String, ByVal city As String,
     ByVal state As String, ByVal country As String) As Boolean
        ' Insert a new row into the Publisher table. Return 
        ' True if successful. If an exception is thrown, 
        ' LastError will hold an error message.
        Try
            LastError = String.Empty
            adapter.Insert(publisherId, publisherName,
              city, state, country)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    Public Function FindById(ByVal Id As String) _
     As BookStoreDataSet.publishersRow

        Dim table As BookStoreDataSet.publishersDataTable
        table = adapter.GetData()
        Return table.FindById(Id)
    End Function

    Public Function Update(ByVal publisherId As String,
     ByVal publisherName As String, ByVal city As String,
     ByVal state As String, ByVal country As String) As Boolean
        ' Insert a new row into the Publisher table. Return 
        ' True if successful. If an exception is thrown, 
        ' LastError will hold an error message.
        Try
            LastError = String.Empty
            adapter.Update(publisherId, publisherName,
              city, state, country)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    Public Function Delete(ByVal Id As String, ByVal name As String,
                          ByVal city As String, ByVal state As String, ByVal country As String) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(Id, name, city, state, country)
        Return rowsAffected > 0
    End Function

End Class
