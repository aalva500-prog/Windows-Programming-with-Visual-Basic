Imports System.Windows.Forms
Imports System.IO
Imports System.Globalization

Public Class frmReport
    ' dimension file variable
    Public objWriteFile As StreamWriter

    Private Sub btnCreateReport_Click(sender As Object, e As EventArgs) Handles btnCreateReport.Click
        Try
            Me.ReportTableTableAdapter.Fill(Me.BookStoreDataSet.ReportTable, mtbInitialDate.Text, mtbEndDate.Text)
        Catch ex As System.Exception
            MessageBox.Show(Me, "Please insert a correct Initial and End Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Create File in Default Directory
        objWriteFile = File.CreateText("Sales Report.txt")

        If dgvReport.Rows.Count <> 0 Then
            ' Write File Header
            objWriteFile.WriteLine("------------------------------------")
            objWriteFile.WriteLine("------------------------------------")
            objWriteFile.Write("Sales from: " & mtbInitialDate.Text & " to " & mtbEndDate.Text)
            objWriteFile.WriteLine("")
            objWriteFile.WriteLine("------------------------------------")
            objWriteFile.WriteLine("------------------------------------")
            objWriteFile.WriteLine("")
            objWriteFile.WriteLine("")

            ' Write each row of the DataGriedView
            For i As Integer = 0 To dgvReport.Rows.Count - 1
                objWriteFile.Write(dgvReport.Rows(i).Cells(0).Value.ToString() & " --- ")
                objWriteFile.Write("Order Num: " & dgvReport.Rows(i).Cells(1).Value.ToString() & " --- ")
                objWriteFile.Write("Title ID: " & dgvReport.Rows(i).Cells(2).Value.ToString() & " --- ")
                objWriteFile.Write("Title: " & dgvReport.Rows(i).Cells(3).Value.ToString() & " --- ")
                objWriteFile.Write("Qty: " & dgvReport.Rows(i).Cells(4).Value.ToString() & " --- ")
                objWriteFile.Write("Price: $" & dgvReport.Rows(i).Cells(5).Value.ToString() & " --- ")
                objWriteFile.Write("Total Value: $" & dgvReport.Rows(i).Cells(6).Value.ToString())
                objWriteFile.WriteLine("")
                objWriteFile.WriteLine("--------------------------------------------------------------------------------------------------------------")
            Next
            MessageBox.Show(Me, "Report exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Close File
            objWriteFile.Close()
        Else
            MessageBox.Show(Me, "There are no items in the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class