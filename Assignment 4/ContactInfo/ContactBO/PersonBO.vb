Imports ContactDO

Public Class PersonBO
    Private adapter As New _
    ContactInfoDataSetTableAdapters.PersonTableAdapter
    Public Shared Property LastError As String

    Public Property ID As Short
    Public Property FirstName As String
    Public Property LastName As String
    Public Property MiddleName As String
    Public Property Type As String
    Public Property Telephone As String
    Public Property Extension As String
    Public Property Email As String

    Public Function Insert(ByVal Id As Short,
     ByVal first_name As String, ByVal middle_name As String,
     ByVal last_name As String, ByVal type As String,
     ByVal telephone As String, ByVal extension As String,
                         ByVal email As String) As Boolean
        ' Insert a new row into the Person table. Return 
        ' True if successful. If an exception is thrown, 
        ' LastError will hold an error message.
        Try
            LastError = String.Empty
            adapter.Insert(Id, first_name, middle_name, last_name,
              type, telephone, extension, email)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function VerifyEmail(ByVal strEmail) As Boolean
        Dim blnContains As Boolean = False

        If strEmail.ToString.Contains("@") Then
            If strEmail.ToString.Contains(".com") Or strEmail.ToString.Contains(".edu") _
                Or strEmail.ToString.Contains(".net") Then
                blnContains = True
            Else
                blnContains = False
            End If
        End If

        Return blnContains
    End Function

End Class
