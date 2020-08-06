Imports System.IO
Imports System.Drawing
Public Class frmTaskDetails
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ' Allow user to specify font color
        If dlgColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblColor.Text = dlgColor.Color.ToString
            lblColor.ForeColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Verify that Task Name, Time, and Color were correctly inserted
        If txtTask.Text = "" Or lblColor.Text = "" Then
            MessageBox.Show("Task and Category cannot be empty", "Error")
        Else
            Dim dtVerifyTime As Date

            ' Validate Time is in correct format
            If Date.TryParseExact(mtbTime.Text, "HH:mm", Nothing, Globalization.DateTimeStyles.NoCurrentDateDefault, dtVerifyTime) Then
                Dim blnExistTask As Boolean = False

                ' Get Color from label
                Dim strColor As String = lblColor.Text.Substring(7)

                ' Dimension a TaskInfo Structure
                Dim stTask As TaskInfo

                ' Fill TaskInfo Structure with the data entered by user
                With stTask
                    .strName = txtTask.Text
                    .dtDate = CDate(datDate.Value)
                    .dtTime = dtVerifyTime
                    .blnComplete = chkComplete.Checked
                    .strCategory = strColor.Substring(0, strColor.Length - 1)
                End With

                ' Add Task Info to List of Tasks
                lstTaskInfo.Add(stTask)

                ' Verify if the Task is already in the List of Tasks
                For Each strTask As String In lstTask.Items
                    ' Separate the info using the comma as delimiter between them
                    Dim arrInfo() As String = Split(strTask, ",")
                    If arrInfo(0) = stTask.strName And arrInfo(1) = stTask.dtDate.ToShortDateString And arrInfo(2) = stTask.dtTime.ToString("HH:mm") Then
                        blnExistTask = True
                        Exit For
                    End If
                Next

                If blnExistTask = False Then
                    ' Add Task Info to lstTask
                    lstTask.Items.Add(stTask.strName + "," + stTask.dtDate.ToShortDateString + "," + stTask.dtTime.ToString("HH:mm") + "," + stTask.blnComplete.ToString + "," + stTask.strCategory)

                    ' Clear the values from TextBoxes, Label and uncheck Complete
                    txtTask.Text = String.Empty
                    lblColor.Text = String.Empty
                    mtbTime.Text = String.Empty
                    chkComplete.Checked = False
                    datDate.Text = Date.Today

                    ' Deselect list
                    lstTask.SelectedIndex = -1

                    ' Enable Save and Cancel buttons
                    btnSave.Enabled = True
                    btnCancel.Enabled = True
                Else
                    MessageBox.Show("There is already a Task with the same Name, Date, and Time.", "Error")
                End If
            Else
                    MessageBox.Show("Enter a valid time e.g: 09:09 or 12:15.", "Error")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim dlgResult As DialogResult

        dlgResult = MessageBox.Show("Pending changes, sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo)

        If dlgResult = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmTaskListApp.Show()
        End If
    End Sub

    Private Sub lstTask_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTask.SelectedIndexChanged
        ' Get selected Item from List of Tasks
        Dim strItem As String = lstTask.SelectedItem

        Dim intIndex As Integer = lstTask.SelectedIndex

        If intIndex <> -1 Then
            ' Separate the info using the comma as delimiter between them
            Dim arrInfo() As String = Split(strItem, ",")

            ' Populate the corresponding fields in the form
            txtTask.Text = arrInfo(0)
            datDate.Text = CDate(arrInfo(1))
            mtbTime.Text = arrInfo(2)
            If arrInfo(3) = False Then
                chkComplete.Checked = False
            Else
                chkComplete.Checked = True
            End If
            lblColor.Text = "Color [" & arrInfo(4) & "]"
            ' Set Color to Category
            If arrInfo(4) = "Green" Then
                lblColor.ForeColor = Color.Green
            ElseIf arrInfo(4) = "Red" Then
                lblColor.ForeColor = Color.Red
            ElseIf arrInfo(4) = "Blue" Then
                lblColor.ForeColor = Color.Blue
            ElseIf arrInfo(4) = "Yellow" Then
                lblColor.ForeColor = Color.Yellow
            ElseIf arrInfo(4) = "Black" Then
                lblColor.ForeColor = Color.Black
            ElseIf arrInfo(4) = "White" Then
                lblColor.ForeColor = Color.White
            ElseIf arrInfo(4) = "Purple" Then
                lblColor.ForeColor = Color.Purple
            ElseIf arrInfo(4) = "Aqua" Then
                lblColor.ForeColor = Color.Aqua
            ElseIf arrInfo(4) = "Fuchsia" Then
                lblColor.ForeColor = Color.Fuchsia
            ElseIf arrInfo(4) = "Lime" Then
                lblColor.ForeColor = Color.Lime
            ElseIf arrInfo(4) = "Teal" Then
                lblColor.ForeColor = Color.Teal
            ElseIf arrInfo(4) = "Maroon" Then
                lblColor.ForeColor = Color.Maroon
            ElseIf arrInfo(4) = "Navy" Then
                lblColor.ForeColor = Color.Navy
            ElseIf arrInfo(4) = "Olive" Then
                lblColor.ForeColor = Color.Olive
            ElseIf arrInfo(4) = "Gray" Then
                lblColor.ForeColor = Color.Gray
            ElseIf arrInfo(4) = "Silver" Then
                lblColor.ForeColor = Color.Silver
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim intIndex As Integer

        ' Remove selected Task        
        intIndex = lstTask.SelectedIndex
        If intIndex <> -1 Then
            lstTask.Items.RemoveAt(intIndex)

            ' Deselect list
            lstTask.SelectedIndex = -1

            ' Clear the values from TextBoxes, Label and uncheck Complete
            txtTask.Text = String.Empty
            lblColor.Text = String.Empty
            mtbTime.Text = String.Empty
            chkComplete.Checked = False
            datDate.Text = Date.Today

            ' Enable Save and Cancel buttons
            btnSave.Enabled = True
            btnCancel.Enabled = True
        Else
            MessageBox.Show("No Task selected.", "Error")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If frmTaskListApp.blnOpenFile = True Then
            frmTaskListApp.objWriteFile = File.CreateText(frmTaskListApp.txtFileName.Text + ".txt")
            frmTaskListApp.blnOpenFile = False
        End If

        ' Save List of Tasks to file
        For Each strItem As String In lstTask.Items
            frmTaskListApp.objWriteFile.WriteLine(strItem)
        Next

        ' Close and save the file
        frmTaskListApp.objWriteFile.Close()

        ' Close Form
        Me.Close()
    End Sub

    Private Sub frmTaskDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Show Task List Frame
        frmTaskListApp.Show()

        ' Clear File Name
        frmTaskListApp.txtFileName.Text = ""

        frmTaskListApp.blnOpenFile = False

        If frmTaskListApp.objWriteFile IsNot Nothing Then
            frmTaskListApp.objWriteFile.Close()
        End If

        If frmTaskListApp.objReadFile IsNot Nothing Then
            frmTaskListApp.objReadFile.Close()
        End If
    End Sub

    Private Sub frmTaskDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Task List of File: " + frmTaskListApp.txtFileName.Text
    End Sub
End Class