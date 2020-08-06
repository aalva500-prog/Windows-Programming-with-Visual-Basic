
Public Class TitleBO
    Public Property ID As String
    Public Property Title As String
    Public Property Type As String
    Public Property Price As Decimal
    Public Shared Property LastError As String

    Public Sub New(ByVal pID As String, ByVal pTitle As String, ByVal pPrice As Decimal)
        ID = pID
        Title = pTitle
        Price = pPrice
    End Sub

End Class
