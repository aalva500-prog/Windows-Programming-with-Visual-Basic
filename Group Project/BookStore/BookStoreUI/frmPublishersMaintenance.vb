Imports System.Windows.Forms
Imports BookStoreDO

Public Class frmPublishersMaintenance
    Public mPublishers As New PublishersDO

    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmPublishersMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.BookStoreDataSet.publishers)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dvgPublishers.SelectedRows.Count > 0 Then
            Dim Id As String = dvgPublishers.SelectedRows(0).Cells(0).Value.ToString
            Dim Name As String = dvgPublishers.SelectedRows(0).Cells(1).Value.ToString
            Dim city As String = dvgPublishers.SelectedRows(0).Cells(2).Value.ToString
            Dim state As String = dvgPublishers.SelectedRows(0).Cells(3).Value.ToString
            Dim country As String = dvgPublishers.SelectedRows(0).Cells(4).Value.ToString

            Try
                If mPublishers.Delete(Id, Name, city, state, country) Then
                    dvgPublishers.DataSource = mPublishers.Items
                Else
                    MessageBox.Show("Unable to delete the Publisher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Unable to delete the Publisher because it is referenced by another Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select the Publisher to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If dvgPublishers.SelectedRows.Count > 0 Then
            Dim Id As String = dvgPublishers.SelectedRows(0).Cells(0).Value.ToString
            Dim frm As New frmModifyPublisher
            frm.PublisherID = Id
            frm.ShowDialog()
            dvgPublishers.DataSource = mPublishers.Items
        Else
            MessageBox.Show("Please select the Publisher to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim frmPublisher As New frmAddPublisher
        frmPublisher.ShowDialog()
    End Sub
End Class