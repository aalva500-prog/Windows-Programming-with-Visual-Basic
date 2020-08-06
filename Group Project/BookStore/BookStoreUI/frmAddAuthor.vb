Imports System.Windows.Forms

Public Class frmAddAuthor
    Private Sub frmAddTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)

    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear screen
        txtFirstName.Text = ""
        txtLastName.Text = ""
        mtxtPhone.Text = ""
        mtbZip.Text = ""
        cboState.SelectedIndex = -1
        txtAddress.Text = ""
        txtCity.Text = ""
        chkContract.CheckState = Windows.Forms.CheckState.Unchecked
        txtID.Text = ""
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtID.Text = "" Or mtbZip.Text = "" _
            Or txtAddress.Text = "" Or txtCity.Text = "" Then
            MessageBox.Show(Me, "Please enter all the corresponding fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If mtxtPhone.Text.Length < 12 Or cboState.SelectedIndex = -1 Then
                MessageBox.Show(Me, "Please enter a correct Telephone Number and Select a State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Me.AuthorsTableAdapter.CheckID().Contains(txtID.Text) Then
                    MessageBox.Show(Me, "ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    AuthorsTableAdapter.Insert(txtID.Text, txtLastName.Text, txtFirstName.Text, mtxtPhone.Text, txtAddress.Text, txtCity.Text, cboState.SelectedItem, mtbZip.Text, chkContract.CheckState)
                    txtID.Clear()
                    txtFirstName.Clear()
                    txtLastName.Clear()
                    mtxtPhone.Clear()
                    txtAddress.Clear()
                    txtCity.Clear()
                    cboState.SelectedIndex = -1
                    mtbZip.Clear()
                    chkContract.CheckState.Equals(0)
                    frmAuthorsMaintenance.dvgAuthors.DataSource = frmAuthorsMaintenance.mAuthors.Items
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)
    End Sub


End Class
