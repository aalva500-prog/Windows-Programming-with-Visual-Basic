Imports ContactDO

Public Class frmSearchContact
    Private adapter As New _
    ContactInfoDataSetTableAdapters.PersonTableAdapter

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If mtbID.Text = "" Or mtbID.Text = "0000" Or mtbID.Text.Length < 4 Then
            MessageBox.Show(Me, "Please enter a valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim shortID As Short = CShort(mtbID.Text)

            'Get the desired Person and display info in the main form
            Dim row As ContactInfoDataSet.PersonRow
            Dim table As ContactInfoDataSet.PersonDataTable
            table = adapter.GetData()
            row = table.FindById(shortID)
            If row Is Nothing Then
                MessageBox.Show(Me, "A Contact with ID: " & mtbID.Text & " does not exist in the Database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                frmDisplayContactInfo.lblID.Text = row.Id.ToString.PadLeft(4, "0"c)
                frmDisplayContactInfo.lblFirstName.Text = row.First_Name
                If row.IsNull("Middle_Name") Then
                    frmDisplayContactInfo.lblMiddleName.Text = ""
                Else
                    frmDisplayContactInfo.lblMiddleName.Text = row.Middle_Name
                End If
                frmDisplayContactInfo.lblLastName.Text = row.Last_Name
                frmDisplayContactInfo.lblType.Text = row.Type
                frmDisplayContactInfo.lblTelephone.Text = row.Telephone
                If row.IsNull("Extension") Then
                    frmDisplayContactInfo.lblExtension.Text = ""
                Else
                    frmDisplayContactInfo.lblExtension.Text = row.Extension
                End If
                frmDisplayContactInfo.lblEmail.Text = row.Email
                mtbID.Text = ""

                frmDisplayContactInfo.mPerson = New PersonDO(shortID)
                ' Close form
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' close form
        Me.Close()
    End Sub
End Class