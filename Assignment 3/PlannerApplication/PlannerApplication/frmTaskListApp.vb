' import libraries
Imports System.IO

Public Class frmTaskListApp
    ' dimension file variables
    Public objWriteFile As StreamWriter
    Public objReadFile As StreamReader

    ' Dimension File Name
    Public strFileName As String

    Public blnOpenFile As Boolean = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close application
        Me.Close()
    End Sub

    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        Dim blnExist As Boolean = False

        If txtFileName.Text = "" Then
            MessageBox.Show("File name cannot be empty", "Error")
        Else
            ' Verify if File has already been created or opened
            For Each strName As String In lstTaskFiles.Items
                If strName = txtFileName.Text Then
                    blnExist = True
                    Exit For
                End If
            Next

            If blnExist = False Then
                ' Create File
                strFileName = txtFileName.Text
                objWriteFile = File.CreateText(strFileName + ".txt")

                ' Insert File Name at the Head of List of Files
                lstTaskFiles.Items.Insert(0, strFileName)

                ' Show Task Details Form
                frmTaskDetails.Show()

                ' Hide main form
                Me.Hide()
            Else
                MessageBox.Show("There is a File with the same name.", "Error")
            End If
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim blnExist As Boolean = False

        ' Open selected file
        Dim objDialog As DialogResult
        dlgOpenFile.Filter = "txt Files (Text Files)|*.txt"
        objDialog = dlgOpenFile.ShowDialog
        If objDialog = Windows.Forms.DialogResult.OK Then
            strFileName = System.IO.Path.GetFileName(dlgOpenFile.FileName)

            If File.Exists(strFileName) Then
                ' Open the file.
                objReadFile = File.OpenText(strFileName)

                txtFileName.Text = strFileName.Substring(0, strFileName.Length - 4)

                ' Verify if File Name is already in the List of Files
                For Each strName As String In lstTaskFiles.Items
                    If strName = txtFileName.Text Then
                        blnExist = True
                        Exit For
                    End If
                Next

                ' If File is not in the List, add it
                If blnExist = False Then
                    ' Add File to List of Files
                    lstTaskFiles.Items.Insert(0, txtFileName.Text)
                Else
                    ' Remove File Name from List of Files
                    lstTaskFiles.Items.Remove(txtFileName.Text)
                    ' Insert File Name at the Head of List of Files
                    lstTaskFiles.Items.Insert(0, txtFileName.Text)
                End If

                ' Read until end of file
                Dim strInput As String
                Do Until objReadFile.EndOfStream
                    strInput = objReadFile.ReadLine()
                    frmTaskDetails.lstTask.Items.Add(strInput)
                Loop

                ' close and save the file
                objReadFile.Close()

                ' Show Task Details Form
                frmTaskDetails.Show()

                blnOpenFile = True

                ' Hide main form
                Me.Hide()
            End If
        End If
    End Sub
End Class
