﻿Imports System.Windows.Forms
Imports BookStoreDO
Public Class frmAddTitle
    Dim strTitlePublisher As String
    Private mPublisher As New PublishersDO
    Private Sub frmAddTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fill Publishers comboBox
        cboTitlePublisher.DataSource = mPublisher.Items
        cboTitlePublisher.DisplayMember = "pub_name"
        cboTitlePublisher.ValueMember = "pub_id"
        mtxtTitlePrice.Text = "000000"
        mtxtTitleAdvance.Text = "000000"
        mtxtRoyalty.Text = "0000"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear screen
        txtTitleName.Text = ""
        mtxtRoyalty.Text = "0000"
        txtNotes.Text = ""
        mtxtTitleAdvance.Text = "000000"
        cboTitleType.SelectedIndex = -1
        mtxtTitlePrice.Text = "000000"
        dtpDatePublished.Value = Date.Today
        cboTitlePublisher.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtTitleName.Text = "" Then
            MessageBox.Show(Me, "Please enter a Title Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf mtxtTitleID.Text = "" Then
            MessageBox.Show(Me, "Please enter a Title ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim strTitleType As String
            Dim decPrice As Decimal
            Dim decAdvance As Decimal
            Dim intRoyalty As Integer

            If strTitlePublisher = String.Empty Then
                MessageBox.Show(Me, "Please pick a publisher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cboTitleType.SelectedIndex = -1 Then
                strTitleType = ""
            Else
                strTitleType = cboTitleType.SelectedItem.ToString
            End If

            If Not Decimal.TryParse(mtxtTitlePrice.Text, decPrice) Then
                MessageBox.Show(Me, "Please enter a valid price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Decimal.TryParse(mtxtTitleAdvance.Text, decAdvance) Then
                MessageBox.Show(Me, "Please enter a valid advance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Integer.TryParse(mtxtRoyalty.Text, intRoyalty) Then
                MessageBox.Show(Me, "Please enter a valid royalty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' MessageBox.Show(mtxtTitleID.Text + vbNewLine + txtTitleName.Text + vbNewLine + strTitleType + vbNewLine + strTitlePublisher + vbNewLine + decPrice.ToString + vbNewLine + decAdvance.ToString + vbNewLine + intRoyalty.ToString + vbNewLine + 0.ToString + vbNewLine + txtNotes.Text + vbNewLine + dtpDatePublished.Value.ToString)

            frmTitlesMaintenance.TitlesTableAdapter.Insert(mtxtTitleID.Text,
                                                           txtTitleName.Text,
                                                           strTitleType,
                                                           strTitlePublisher,
                                                           decPrice,
                                                           decAdvance,
                                                           intRoyalty,
                                                           0,
                                                           txtNotes.Text,
                                                           dtpDatePublished.Value)

            Me.Close()
        End If
    End Sub

    Private Sub cboTitlePublisher_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTitlePublisher.SelectionChangeCommitted
        strTitlePublisher = cboTitlePublisher.SelectedValue.ToString
    End Sub
End Class
