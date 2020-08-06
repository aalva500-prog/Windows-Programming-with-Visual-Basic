Imports System.Windows.Forms
Imports BookStoreDO

Public Class frmAuthorsMaintenance
    Public mAuthors As New AuthorsDO

    Public ReadOnly Property Items As DataTable
        Get
            Return AuthorsTableAdapter.GetData()
        End Get
    End Property

    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)
    End Sub

    Private Sub frmAuthorsMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim frmAuthor As New frmAddAuthor
        frmAuthor.ShowDialog()
        Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim frmModiAuthor As New frmModifyAuthor
        frmModiAuthor.ShowDialog()
        Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dvgAuthors.SelectedRows.Count > 0 Then
            Dim authorId As String = dvgAuthors.SelectedRows(0).Cells(0).Value.ToString
            Dim authorFirstName As String = dvgAuthors.SelectedRows(0).Cells(1).Value.ToString
            Dim authorLastName As String = dvgAuthors.SelectedRows(0).Cells(2).Value.ToString
            Dim authorPhone As String = dvgAuthors.SelectedRows(0).Cells(3).Value.ToString
            Dim authorAddress As String = dvgAuthors.SelectedRows(0).Cells(4).Value.ToString
            Dim authorCity As String = dvgAuthors.SelectedRows(0).Cells(5).Value.ToString
            Dim authorState As String = dvgAuthors.SelectedRows(0).Cells(6).Value.ToString
            Dim authorZip As String = dvgAuthors.SelectedRows(0).Cells(7).Value.ToString
            Dim authorContract As Boolean = CBool(dvgAuthors.SelectedRows(0).Cells(8).Value.ToString)
            Try
                If mAuthors.Delete(authorId, authorFirstName, authorLastName, authorPhone, authorAddress,
                               authorCity, authorState, authorZip, authorContract) Then
                    dvgAuthors.DataSource = mAuthors.Items
                Else
                    MessageBox.Show("Unable to delete the Author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Unable to delete the Author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select the Author to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class