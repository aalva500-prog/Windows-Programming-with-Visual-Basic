Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddTitle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddTitle))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblRoyalty = New System.Windows.Forms.Label()
        Me.lblAdvanced = New System.Windows.Forms.Label()
        Me.mtxtTitleAdvance = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDatePublished = New System.Windows.Forms.DateTimePicker()
        Me.lblPublicationDate = New System.Windows.Forms.Label()
        Me.cboTitlePublisher = New System.Windows.Forms.ComboBox()
        Me.mtxtTitlePrice = New System.Windows.Forms.MaskedTextBox()
        Me.cboTitleType = New System.Windows.Forms.ComboBox()
        Me.txtTitleName = New System.Windows.Forms.TextBox()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.mtxtRoyalty = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxtTitleID = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(394, 338)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 44)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(122, 338)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 44)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(82, 180)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNotes.MaxLength = 200
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(470, 123)
        Me.txtNotes.TabIndex = 8
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(79, 161)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(49, 16)
        Me.lblNotes.TabIndex = 51
        Me.lblNotes.Text = "Notes"
        '
        'lblRoyalty
        '
        Me.lblRoyalty.AutoSize = True
        Me.lblRoyalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoyalty.Location = New System.Drawing.Point(495, 80)
        Me.lblRoyalty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoyalty.Name = "lblRoyalty"
        Me.lblRoyalty.Size = New System.Drawing.Size(61, 16)
        Me.lblRoyalty.TabIndex = 49
        Me.lblRoyalty.Text = "Royalty"
        '
        'lblAdvanced
        '
        Me.lblAdvanced.AutoSize = True
        Me.lblAdvanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvanced.Location = New System.Drawing.Point(362, 80)
        Me.lblAdvanced.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdvanced.Name = "lblAdvanced"
        Me.lblAdvanced.Size = New System.Drawing.Size(69, 16)
        Me.lblAdvanced.TabIndex = 48
        Me.lblAdvanced.Text = "Advance"
        '
        'mtxtTitleAdvance
        '
        Me.mtxtTitleAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTitleAdvance.Location = New System.Drawing.Point(362, 101)
        Me.mtxtTitleAdvance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtTitleAdvance.Mask = "0000.00"
        Me.mtxtTitleAdvance.Name = "mtxtTitleAdvance"
        Me.mtxtTitleAdvance.Size = New System.Drawing.Size(116, 23)
        Me.mtxtTitleAdvance.TabIndex = 6
        '
        'dtpDatePublished
        '
        Me.dtpDatePublished.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePublished.Location = New System.Drawing.Point(220, 100)
        Me.dtpDatePublished.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDatePublished.Name = "dtpDatePublished"
        Me.dtpDatePublished.Size = New System.Drawing.Size(116, 23)
        Me.dtpDatePublished.TabIndex = 5
        '
        'lblPublicationDate
        '
        Me.lblPublicationDate.AutoSize = True
        Me.lblPublicationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicationDate.Location = New System.Drawing.Point(219, 80)
        Me.lblPublicationDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicationDate.Name = "lblPublicationDate"
        Me.lblPublicationDate.Size = New System.Drawing.Size(122, 16)
        Me.lblPublicationDate.TabIndex = 45
        Me.lblPublicationDate.Text = "Publication Date"
        '
        'cboTitlePublisher
        '
        Me.cboTitlePublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTitlePublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTitlePublisher.FormattingEnabled = True
        Me.cboTitlePublisher.Location = New System.Drawing.Point(18, 99)
        Me.cboTitlePublisher.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTitlePublisher.MaxLength = 40
        Me.cboTitlePublisher.Name = "cboTitlePublisher"
        Me.cboTitlePublisher.Size = New System.Drawing.Size(175, 24)
        Me.cboTitlePublisher.TabIndex = 4
        '
        'mtxtTitlePrice
        '
        Me.mtxtTitlePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTitlePrice.Location = New System.Drawing.Point(495, 35)
        Me.mtxtTitlePrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtTitlePrice.Mask = "0000.00"
        Me.mtxtTitlePrice.Name = "mtxtTitlePrice"
        Me.mtxtTitlePrice.Size = New System.Drawing.Size(116, 23)
        Me.mtxtTitlePrice.TabIndex = 3
        '
        'cboTitleType
        '
        Me.cboTitleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTitleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTitleType.FormattingEnabled = True
        Me.cboTitleType.Items.AddRange(New Object() {"business", "mod_cook", "popular_comp", "psychology", "trad_cook"})
        Me.cboTitleType.Location = New System.Drawing.Point(360, 35)
        Me.cboTitleType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTitleType.MaxLength = 12
        Me.cboTitleType.Name = "cboTitleType"
        Me.cboTitleType.Size = New System.Drawing.Size(116, 24)
        Me.cboTitleType.TabIndex = 2
        '
        'txtTitleName
        '
        Me.txtTitleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleName.Location = New System.Drawing.Point(122, 35)
        Me.txtTitleName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTitleName.MaxLength = 80
        Me.txtTitleName.Name = "txtTitleName"
        Me.txtTitleName.Size = New System.Drawing.Size(224, 23)
        Me.txtTitleName.TabIndex = 1
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.Location = New System.Drawing.Point(16, 78)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(73, 16)
        Me.lblPublisher.TabIndex = 40
        Me.lblPublisher.Text = "Publisher"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(491, 14)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 16)
        Me.lblPrice.TabIndex = 39
        Me.lblPrice.Text = "Price"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(358, 14)
        Me.lblType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(44, 16)
        Me.lblType.TabIndex = 38
        Me.lblType.Text = "Type"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(120, 14)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 16)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "Title"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(258, 338)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 44)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'mtxtRoyalty
        '
        Me.mtxtRoyalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtRoyalty.Location = New System.Drawing.Point(495, 99)
        Me.mtxtRoyalty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtRoyalty.Mask = "0000"
        Me.mtxtRoyalty.Name = "mtxtRoyalty"
        Me.mtxtRoyalty.Size = New System.Drawing.Size(116, 23)
        Me.mtxtRoyalty.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Title ID"
        '
        'mtxtTitleID
        '
        Me.mtxtTitleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTitleID.Location = New System.Drawing.Point(18, 35)
        Me.mtxtTitleID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtTitleID.Mask = "AA0000"
        Me.mtxtTitleID.Name = "mtxtTitleID"
        Me.mtxtTitleID.Size = New System.Drawing.Size(92, 23)
        Me.mtxtTitleID.TabIndex = 0
        '
        'frmAddTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(631, 418)
        Me.Controls.Add(Me.mtxtTitleID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxtRoyalty)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblRoyalty)
        Me.Controls.Add(Me.lblAdvanced)
        Me.Controls.Add(Me.mtxtTitleAdvance)
        Me.Controls.Add(Me.dtpDatePublished)
        Me.Controls.Add(Me.lblPublicationDate)
        Me.Controls.Add(Me.cboTitlePublisher)
        Me.Controls.Add(Me.mtxtTitlePrice)
        Me.Controls.Add(Me.cboTitleType)
        Me.Controls.Add(Me.txtTitleName)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddTitle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Title"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents lblRoyalty As Label
    Friend WithEvents lblAdvanced As Label
    Friend WithEvents mtxtTitleAdvance As MaskedTextBox
    Friend WithEvents dtpDatePublished As DateTimePicker
    Friend WithEvents lblPublicationDate As Label
    Friend WithEvents cboTitlePublisher As ComboBox
    Friend WithEvents mtxtTitlePrice As MaskedTextBox
    Friend WithEvents cboTitleType As ComboBox
    Friend WithEvents txtTitleName As TextBox
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents mtxtRoyalty As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxtTitleID As MaskedTextBox
End Class
