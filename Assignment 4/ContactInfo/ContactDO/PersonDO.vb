Public Class PersonDO
    Private adapter As New ContactInfoDataSetTableAdapters.PersonTableAdapter
    Private current As Integer

    Public ReadOnly Property items As DataTable
        Get
            Return adapter.GetData
        End Get
    End Property

    Public Sub New()
        current = 0
    End Sub

    Public Sub New(ByVal ID)
        current = ID - 1
    End Sub

    Public Function GetNext() As Integer
        If current < items.Rows.Count - 1 Then
            current = current + 1
        End If
        Return current
    End Function

    Public Function GetPrev() As Integer
        If current > 0 Then
            current = current - 1
        End If
        Return current
    End Function
End Class
