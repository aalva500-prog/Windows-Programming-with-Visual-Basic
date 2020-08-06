Imports ContactBO
Public Class frmEnterContactInfo
    Private mPerson As New PersonBO

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear textFields and set comboBox to -1
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        cboType.SelectedIndex = -1
        mtbTelephone.Text = ""
        txtExtension.Text = ""
        txtEmail.Text = ""

        ' set Focus
        txtFirstName.Focus()
    End Sub

    Private Sub frmEnterContactInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' disable and initialize ID with next ID from the database
        txtID.Enabled = False
        txtID.Text = PersonTableAdapter.GetNextPersonByID().ToString().PadLeft(4, "0"c)
    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        ' Verify that First Name and Last Name are not empty
        If txtFirstName.Text = "" Or txtLastName.Text = "" Then
            txtFirstName.Focus()
            MessageBox.Show(Me, "Error: Fisrt Name and Last Name cannot be empty", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Verify that a Type is selected
            If cboType.SelectedIndex <> -1 Then
                ' Verify that Telephone has a correct Length
                If mtbTelephone.Text.Length < 14 Then
                    MessageBox.Show(Me, "Error: Enter a correct Telephone Number", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    ' Verify that Email has a correct format
                    If txtEmail.Text.Length > 0 And mPerson.VerifyEmail(txtEmail.Text) = True Then

                        Dim shrtID As Short = PersonTableAdapter.GetNextPersonByID()
                        Dim strType As String = cboType.SelectedItem.ToString

                        If mPerson.Insert(shrtID, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                                              strType, mtbTelephone.Text, txtExtension.Text, txtEmail.Text) Then

                            ' Clear textFields and set comboBox to -1
                            txtFirstName.Text = ""
                            txtMiddleName.Text = ""
                            txtLastName.Text = ""
                            cboType.SelectedIndex = -1
                            mtbTelephone.Text = ""
                            txtExtension.Text = ""
                            txtEmail.Text = ""

                            ' Close Form
                            Me.Close()
                        Else
                            MessageBox.Show(Me, "Error: " & PersonBO.LastError, "Save",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show(Me, "Error: Please enter a correct Email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show(Me, "Error: Please select a Type", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close Form
        Me.Close()
    End Sub

End Class