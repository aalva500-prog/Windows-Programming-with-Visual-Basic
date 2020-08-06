Imports System.Windows.Forms
Imports BookStoreDO

Public Class frmModifyPublisher
    Private mPublishers As New PublishersDO
    Private adapter As New _
    BookStoreDataSetTableAdapters.publishersTableAdapter
    Public Property PublisherID As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ' Clear Screen
        txtCity.Text = ""
        txtCountry.Text = ""
        txtName.Text = ""
        cboState.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Or txtCity.Text = "" Or txtCountry.Text = "" Then
            MessageBox.Show(Me, "Please enter all the corresponding data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cboState.SelectedIndex <> -1 Then
                mPublishers.adapter.UpdateQuery(txtName.Text, txtCity.Text, cboState.SelectedItem.ToString, txtCountry.Text, PublisherID)
                frmPublishersMaintenance.dvgPublishers.DataSource = mPublishers.Items
                Me.Close()
            Else
                MessageBox.Show(Me, "Please select a State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub frmModifyPublisher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the selected Publisher and display in the form's controls
        Dim table As BookStoreDataSet.publishersDataTable
        Dim row As BookStoreDataSet.publishersRow
        table = adapter.GetData()
        row = table.FindById(PublisherID)
        txtName.Text = row.pub_name
        txtCity.Text = row.city
        txtCountry.Text = row.country
        If row.IsNull("State") Then
            cboState.SelectedIndex = -1
        Else
            cboState.SelectedItem = row.state
        End If

    End Sub
End Class