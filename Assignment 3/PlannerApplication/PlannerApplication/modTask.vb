Module modTask
    ' Definition of TaskInfo Structure
    Public Structure TaskInfo
        Dim strName As String
        Dim dtDate As Date
        Dim dtTime As Date
        Dim blnComplete As Boolean
        Dim strCategory As String
    End Structure

    ' Create List of TaskInfo
    Public lstTaskInfo As New List(Of TaskInfo)

End Module
