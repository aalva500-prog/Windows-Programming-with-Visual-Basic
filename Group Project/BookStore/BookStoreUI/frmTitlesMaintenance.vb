Imports System.Windows.Forms

Public Class frmTitlesMaintenance
    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmTitlesMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim frmAdTitle As New frmAddTitle
        frmAdTitle.ShowDialog()
        Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If dvgTitles.SelectedRows.Count > 0 Then
            Dim frmModiTitle As New frmModifyTitle
            frmModiTitle.ShowDialog()
            Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)
        Else
            MessageBox.Show("Please select the Title to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dvgTitles.SelectedRows.Count > 0 Then
            TitlesTableAdapter.DeleteQuery(dvgTitles.SelectedRows(0).Cells(0).Value)
            Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)
        Else
            MessageBox.Show("Please select the Title to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class