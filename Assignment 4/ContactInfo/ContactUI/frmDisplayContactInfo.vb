'Affirmation of Authorship:

'Name: Aaron Alvarez

'Date: 07/12/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by anyone else.

Imports ContactDO

Public Class frmDisplayContactInfo
    ' Instantiate Data Object
    Public mPerson As New PersonDO()

    Public Property ContactID As Short

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' Initialize Object of Type PersoDO
        mPerson = New PersonDO

        ' Display the first Contact record
        Dim strID As String = mPerson.items().Rows(0)("Id").ToString
        lblID.Text = strID.PadLeft(4, "0"c)
        lblFirstName.Text = mPerson.items().Rows(0)("First_Name").ToString
        lblMiddleName.Text = mPerson.items().Rows(0)("Middle_Name").ToString
        lblLastName.Text = mPerson.items().Rows(0)("Last_Name").ToString
        lblType.Text = mPerson.items().Rows(0)("Type").ToString
        Dim strPhone As String = mPerson.items().Rows(0)("Telephone").ToString
        lblTelephone.Text = strPhone
        lblExtension.Text = mPerson.items().Rows(0)("Extension").ToString
        lblEmail.Text = mPerson.items().Rows(0)("Email").ToString
    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        ' Verify if there is some information in the form
        If lblID.Text.Length > 0 Then
            ' display the next data record
            Dim intIndex As Integer = mPerson.GetNext()
            Dim strID As String = mPerson.items().Rows(intIndex)("Id").ToString
            lblID.Text = strID.PadLeft(4, "0"c)
            lblFirstName.Text = mPerson.items().Rows(intIndex)("First_Name").ToString
            lblMiddleName.Text = mPerson.items().Rows(intIndex)("Middle_Name").ToString
            lblLastName.Text = mPerson.items().Rows(intIndex)("Last_Name").ToString
            lblType.Text = mPerson.items().Rows(intIndex)("Type").ToString
            Dim strPhone As String = mPerson.items().Rows(intIndex)("Telephone").ToString
            lblTelephone.Text = strPhone
            lblExtension.Text = mPerson.items().Rows(intIndex)("Extension").ToString
            lblEmail.Text = mPerson.items().Rows(intIndex)("Email").ToString
        End If
    End Sub

    Private Sub btnPreviousRecord_Click(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click
        ' Verify if there is some information in the form
        If lblID.Text.Length > 0 Then
            ' display the previous data record
            Dim intIndex As Integer = mPerson.GetPrev()
            Dim strID As String = mPerson.items().Rows(intIndex)("Id").ToString
            lblID.Text = strID.PadLeft(4, "0"c)
            lblFirstName.Text = mPerson.items().Rows(intIndex)("First_Name").ToString
            lblMiddleName.Text = mPerson.items().Rows(intIndex)("Middle_Name").ToString
            lblLastName.Text = mPerson.items().Rows(intIndex)("Last_Name").ToString
            lblType.Text = mPerson.items().Rows(intIndex)("Type").ToString
            Dim strPhone As String = mPerson.items().Rows(intIndex)("Telephone").ToString
            lblTelephone.Text = strPhone
            lblExtension.Text = mPerson.items().Rows(intIndex)("Extension").ToString
            lblEmail.Text = mPerson.items().Rows(intIndex)("Email").ToString
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close form and end application
        Me.Close()
    End Sub

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click
        ' show form to Enter Contact Info
        Dim frmEnterInfo As New frmEnterContactInfo
        frmEnterInfo.ShowDialog()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        ' Open Search Form
        Dim frmSearch As New frmSearchContact
        frmSearch.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show(Me, "Contact Info Application - - Version 1.2", "Help",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
