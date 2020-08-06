Imports System.Windows.Forms
Imports BookStoreDO

Public Class frmAddPublisher
    Private mPublisher As New PublishersDO
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear Screen
        txtCity.Text = ""
        txtCountry.Text = ""
        txtName.Text = ""
        cboState.SelectedIndex = -1
        txtID.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Or txtCity.Text = "" Or txtCountry.Text = "" Or txtID.Text = "" Then
            MessageBox.Show(Me, "Please enter all the corresponding data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cboState.SelectedIndex <> -1 Then
                If IsNumeric(txtID.Text) Then
                    If mPublisher.Insert("99" + txtID.Text, txtName.Text, txtCity.Text, cboState.SelectedItem.ToString, txtCountry.Text) Then
                        frmPublishersMaintenance.dvgPublishers.DataSource = frmPublishersMaintenance.mPublishers.Items
                        Me.Close()
                    Else
                        MessageBox.Show(Me, PublishersDO.LastError & "Unable to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                        MessageBox.Show(Me, "ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                    MessageBox.Show(Me, "Please select a State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        End If
    End Sub

    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmAddPublisher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.BookStoreDataSet.publishers)

    End Sub
End Class