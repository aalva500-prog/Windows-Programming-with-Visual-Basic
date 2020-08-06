Imports System.Windows.Forms
Imports BookStoreBO

Public Class frmFindTitle
    Private adapter As New _
    BookStoreDataSetTableAdapters.titlesTableAdapter

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If txtPartialTitle.Text.Length = 0 Then
            MessageBox.Show("Please enter a partial Title Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Perform a wildcard search for Title Name.
            Me.TitlesTableAdapter.FillByName(Me.BookStoreDataSet.titles, txtPartialTitle.Text)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSelectItem_Click(sender As Object, e As EventArgs) Handles btnSelectItem.Click
        If dgvTitles.SelectedRows.Count > 0 Then
            Dim decPrice As Decimal
            Dim row As BookStoreDataSet.titlesRow
            Dim table As BookStoreDataSet.titlesDataTable
            table = adapter.GetData
            row = table.FindBytitle_id(dgvTitles.SelectedRows(0).Cells(0).Value)

            Dim strID As String = CStr(dgvTitles.SelectedRows(0).Cells(0).Value)
            Dim strTitle As String = CStr(dgvTitles.SelectedRows(0).Cells(1).Value)

            If row.IsNull("Price") Then
                decPrice = 0
            Else
                decPrice = CDec(dgvTitles.SelectedRows(0).Cells(4).Value)
            End If

            frmShoppingCart.mTitle = New TitleBO(strID, strTitle, decPrice)
            frmShoppingCart.txtTitle.Text = strTitle
            Me.Close()
        Else
            MessageBox.Show("Please select the Title from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmFindTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPartialTitle.Text = ""
    End Sub

    Private Sub TitlesBindingNavigator1SaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub
End Class