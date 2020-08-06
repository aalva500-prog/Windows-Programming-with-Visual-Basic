'Affirmation of Authorship:

'Name: Alexander Alfonso, Aaron Alvarez, Matthew Bovarnick, Brian Hurtado

'Date: 07/13/2020

'We affirm that this program was created by us. It is solely our work and ‘does not include any work done by anyone else.
Public Class frmBookStoreApplication
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FindTitleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmFindTitle.ShowDialog()
    End Sub

    Private Sub AddTitleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmAddTitle.ShowDialog()
    End Sub

    Private Sub frmBookStoreApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TitlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitlesToolStripMenuItem.Click
        frmTitlesMaintenance.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim frmLog As New frmLogin
        frmLog.ShowDialog()
    End Sub

    Private Sub lblEmployeeID_Click(sender As Object, e As EventArgs) Handles lblEmployeeIDText.Click

    End Sub

    Private Sub AddNewOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewOrderToolStripMenuItem.Click
        frmShoppingCart.ShowDialog()
    End Sub

    Private Sub AuthorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorsToolStripMenuItem.Click
        Dim frmAuthors As New frmAuthorsMaintenance
        frmAuthors.ShowDialog()
    End Sub

    Private Sub PublishersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublishersToolStripMenuItem.Click
        frmPublishersMaintenance.ShowDialog()
    End Sub

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        Dim frmRep As New frmReport
        frmRep.ShowDialog()
    End Sub
End Class