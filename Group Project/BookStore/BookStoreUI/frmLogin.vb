Imports System.Windows.Forms

Public Class frmLogin
    Private adapter As New _
    BookStoreDataSetTableAdapters.employeeTableAdapter
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If txtEmployeeID.Text = "" Then
            MessageBox.Show(Me, "Please enter your Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Get the desired Employee and display info in the main form
            Dim row As BookStoreDataSet.employeeRow
            Dim table As BookStoreDataSet.employeeDataTable
            table = adapter.GetData()
            row = table.FindByemp_id(txtEmployeeID.Text)

            If row Is Nothing Then
                MessageBox.Show(Me, "An Employee with ID: " & txtEmployeeID.Text & " does not exist in the Database. Try again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                frmBookStoreApplication.gpbLoginCredentials.Visible = True
                frmBookStoreApplication.lblEmployeeID.Text = row.emp_id
                frmBookStoreApplication.lblFirstName.Text = row.fname
                frmBookStoreApplication.lblLastName.Text = row.lname
                frmBookStoreApplication.OrdersToolStripMenuItem.Enabled = True
                frmBookStoreApplication.MaintenanceToolStripMenuItem.Enabled = True
                frmBookStoreApplication.ReportToolStripMenuItem1.Enabled = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class