Imports System.Windows.Forms

Public Class frmModifyAuthor
    Private Sub frmModifyAuthor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Me.AuthorsTableAdapter.Update(BookStoreDataSet.authors)
    End Sub


    Private Sub btnOk_Click_1(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtID.Text.Length >= 11 Then
            Me.AuthorsTableAdapter.GetAuthor(Me.BookStoreDataSet.authors, txtID.Text)
        Else
            MessageBox.Show("Enter Valid ID")
        End If
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = ""
        Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)
    End Sub

    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.AuthorsTableAdapter.Update(Me.BookStoreDataSet.authors)
    End Sub
End Class
