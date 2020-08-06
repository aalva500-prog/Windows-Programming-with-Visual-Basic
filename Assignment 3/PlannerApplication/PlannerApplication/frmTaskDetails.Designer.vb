<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTaskDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTask = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.mtbTime = New System.Windows.Forms.MaskedTextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lstTask = New System.Windows.Forms.ListBox()
        Me.datDate = New System.Windows.Forms.DateTimePicker()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(354, 56)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 16)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'lblTask
        '
        Me.lblTask.AutoSize = True
        Me.lblTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask.Location = New System.Drawing.Point(354, 5)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(42, 16)
        Me.lblTask.TabIndex = 1
        Me.lblTask.Text = "Task:"
        '
        'txtTask
        '
        Me.txtTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask.Location = New System.Drawing.Point(357, 23)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(139, 22)
        Me.txtTask.TabIndex = 1
        '
        'mtbTime
        '
        Me.mtbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbTime.Location = New System.Drawing.Point(357, 129)
        Me.mtbTime.Mask = "00:00"
        Me.mtbTime.Name = "mtbTime"
        Me.mtbTime.Size = New System.Drawing.Size(139, 22)
        Me.mtbTime.TabIndex = 3
        Me.mtbTime.ValidatingType = GetType(Date)
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(354, 111)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(95, 16)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time (HH:MM)"
        '
        'chkComplete
        '
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComplete.Location = New System.Drawing.Point(357, 170)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(92, 20)
        Me.chkComplete.TabIndex = 4
        Me.chkComplete.Text = "Complete?"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(354, 214)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(66, 16)
        Me.lblCategory.TabIndex = 7
        Me.lblCategory.Text = "Category:"
        '
        'btnColor
        '
        Me.btnColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColor.Location = New System.Drawing.Point(421, 271)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 28)
        Me.btnColor.TabIndex = 5
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(357, 335)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(139, 29)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(357, 375)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(139, 29)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(357, 433)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(139, 29)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(357, 470)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(139, 29)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lstTask
        '
        Me.lstTask.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTask.FormattingEnabled = True
        Me.lstTask.ItemHeight = 16
        Me.lstTask.Location = New System.Drawing.Point(0, 0)
        Me.lstTask.Name = "lstTask"
        Me.lstTask.Size = New System.Drawing.Size(343, 524)
        Me.lstTask.TabIndex = 14
        '
        'datDate
        '
        Me.datDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDate.Location = New System.Drawing.Point(357, 75)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(139, 22)
        Me.datDate.TabIndex = 2
        '
        'dlgColor
        '
        Me.dlgColor.AllowFullOpen = False
        Me.dlgColor.SolidColorOnly = True
        '
        'lblColor
        '
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(378, 236)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(118, 23)
        Me.lblColor.TabIndex = 16
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTaskDetails
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 524)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.lstTask)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.mtbTime)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.lblTask)
        Me.Controls.Add(Me.lblDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTaskDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblTask As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents mtbTime As MaskedTextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents chkComplete As CheckBox
    Friend WithEvents lblCategory As Label

    Friend WithEvents btnColor As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lstTask As ListBox
    Friend WithEvents datDate As DateTimePicker
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents lblColor As Label
End Class
