<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDisplayContactInfo
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
        Me.components = New System.ComponentModel.Container()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.lblIDText = New System.Windows.Forms.Label()
        Me.lblFirstNameText = New System.Windows.Forms.Label()
        Me.lblMiddleNameText = New System.Windows.Forms.Label()
        Me.lblLastNameText = New System.Windows.Forms.Label()
        Me.lblTypeText = New System.Windows.Forms.Label()
        Me.lblTelephoneText = New System.Windows.Forms.Label()
        Me.lblExtensionText = New System.Windows.Forms.Label()
        Me.lblEmailText = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.grbDisplayContactInfo = New System.Windows.Forms.GroupBox()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactInfoDataSet1 = New ContactInfo.ContactInfoDataSet()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New ContactInfo.ContactInfoDataSetTableAdapters.PersonTableAdapter()
        Me.TableAdapterManager = New ContactInfo.ContactInfoDataSetTableAdapters.TableAdapterManager()
        Me.grbDisplayContactInfo.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        CType(Me.ContactInfoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousRecord.Location = New System.Drawing.Point(48, 402)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(138, 56)
        Me.btnPreviousRecord.TabIndex = 2
        Me.btnPreviousRecord.Text = "Previous Record"
        Me.btnPreviousRecord.UseVisualStyleBackColor = True
        '
        'btnNextRecord
        '
        Me.btnNextRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextRecord.Location = New System.Drawing.Point(204, 402)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(138, 56)
        Me.btnNextRecord.TabIndex = 1
        Me.btnNextRecord.Text = "Next Record"
        Me.btnNextRecord.UseVisualStyleBackColor = True
        '
        'lblIDText
        '
        Me.lblIDText.Location = New System.Drawing.Point(10, 19)
        Me.lblIDText.Name = "lblIDText"
        Me.lblIDText.Size = New System.Drawing.Size(138, 31)
        Me.lblIDText.TabIndex = 10
        Me.lblIDText.Text = "ID:"
        Me.lblIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstNameText
        '
        Me.lblFirstNameText.Location = New System.Drawing.Point(10, 60)
        Me.lblFirstNameText.Name = "lblFirstNameText"
        Me.lblFirstNameText.Size = New System.Drawing.Size(138, 31)
        Me.lblFirstNameText.TabIndex = 11
        Me.lblFirstNameText.Text = "First Name:"
        Me.lblFirstNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMiddleNameText
        '
        Me.lblMiddleNameText.Location = New System.Drawing.Point(10, 101)
        Me.lblMiddleNameText.Name = "lblMiddleNameText"
        Me.lblMiddleNameText.Size = New System.Drawing.Size(138, 31)
        Me.lblMiddleNameText.TabIndex = 12
        Me.lblMiddleNameText.Text = "Middle Name:"
        Me.lblMiddleNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastNameText
        '
        Me.lblLastNameText.Location = New System.Drawing.Point(10, 142)
        Me.lblLastNameText.Name = "lblLastNameText"
        Me.lblLastNameText.Size = New System.Drawing.Size(138, 31)
        Me.lblLastNameText.TabIndex = 13
        Me.lblLastNameText.Text = "Last Name:"
        Me.lblLastNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTypeText
        '
        Me.lblTypeText.Location = New System.Drawing.Point(10, 184)
        Me.lblTypeText.Name = "lblTypeText"
        Me.lblTypeText.Size = New System.Drawing.Size(138, 31)
        Me.lblTypeText.TabIndex = 14
        Me.lblTypeText.Text = "Type:"
        Me.lblTypeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelephoneText
        '
        Me.lblTelephoneText.Location = New System.Drawing.Point(10, 225)
        Me.lblTelephoneText.Name = "lblTelephoneText"
        Me.lblTelephoneText.Size = New System.Drawing.Size(138, 31)
        Me.lblTelephoneText.TabIndex = 15
        Me.lblTelephoneText.Text = "Telephone:"
        Me.lblTelephoneText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExtensionText
        '
        Me.lblExtensionText.Location = New System.Drawing.Point(10, 266)
        Me.lblExtensionText.Name = "lblExtensionText"
        Me.lblExtensionText.Size = New System.Drawing.Size(138, 31)
        Me.lblExtensionText.TabIndex = 16
        Me.lblExtensionText.Text = "Extension:"
        Me.lblExtensionText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmailText
        '
        Me.lblEmailText.Location = New System.Drawing.Point(10, 307)
        Me.lblEmailText.Name = "lblEmailText"
        Me.lblEmailText.Size = New System.Drawing.Size(138, 31)
        Me.lblEmailText.TabIndex = 17
        Me.lblEmailText.Text = "E-mail Address:"
        Me.lblEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Location = New System.Drawing.Point(157, 19)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(199, 31)
        Me.lblID.TabIndex = 2
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstName.Location = New System.Drawing.Point(157, 60)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(199, 31)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMiddleName
        '
        Me.lblMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMiddleName.Location = New System.Drawing.Point(157, 101)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(199, 31)
        Me.lblMiddleName.TabIndex = 4
        Me.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Location = New System.Drawing.Point(157, 142)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(199, 31)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblType
        '
        Me.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblType.Location = New System.Drawing.Point(157, 184)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(199, 31)
        Me.lblType.TabIndex = 6
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelephone
        '
        Me.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTelephone.Location = New System.Drawing.Point(157, 225)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(199, 31)
        Me.lblTelephone.TabIndex = 7
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExtension
        '
        Me.lblExtension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExtension.Location = New System.Drawing.Point(157, 266)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(199, 31)
        Me.lblExtension.TabIndex = 8
        Me.lblExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmail.Location = New System.Drawing.Point(157, 307)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(199, 31)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbDisplayContactInfo
        '
        Me.grbDisplayContactInfo.Controls.Add(Me.lblIDText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblFirstNameText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblMiddleNameText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblLastNameText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblTypeText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblTelephoneText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblExtensionText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblEmailText)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblID)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblFirstName)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblMiddleName)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblLastName)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblType)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblTelephone)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblExtension)
        Me.grbDisplayContactInfo.Controls.Add(Me.lblEmail)
        Me.grbDisplayContactInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDisplayContactInfo.Location = New System.Drawing.Point(13, 40)
        Me.grbDisplayContactInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grbDisplayContactInfo.Name = "grbDisplayContactInfo"
        Me.grbDisplayContactInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grbDisplayContactInfo.Size = New System.Drawing.Size(367, 355)
        Me.grbDisplayContactInfo.TabIndex = 20
        Me.grbDisplayContactInfo.TabStop = False
        Me.grbDisplayContactInfo.Text = "Display Contact Info"
        '
        'mnuMenu
        '
        Me.mnuMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.SearchToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(394, 25)
        Me.mnuMenu.TabIndex = 23
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(105, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(105, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecordToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddRecordToolStripMenuItem
        '
        Me.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem"
        Me.AddRecordToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AddRecordToolStripMenuItem.Text = "Add Record"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContactInfoDataSet1
        '
        Me.ContactInfoDataSet1.DataSetName = "ContactInfoDataSet1"
        Me.ContactInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.ContactInfoDataSet1
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.UpdateOrder = ContactInfo.ContactInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmDisplayContactInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 467)
        Me.Controls.Add(Me.mnuMenu)
        Me.Controls.Add(Me.btnPreviousRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.grbDisplayContactInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDisplayContactInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Info"
        Me.grbDisplayContactInfo.ResumeLayout(False)
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        CType(Me.ContactInfoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPreviousRecord As Button
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents lblIDText As Label
    Friend WithEvents lblFirstNameText As Label
    Friend WithEvents lblMiddleNameText As Label
    Friend WithEvents lblLastNameText As Label
    Friend WithEvents lblTypeText As Label
    Friend WithEvents lblTelephoneText As Label
    Friend WithEvents lblExtensionText As Label
    Friend WithEvents lblEmailText As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblExtension As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents grbDisplayContactInfo As GroupBox
    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactInfoDataSet1 As ContactInfoDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As ContactInfoDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TableAdapterManager As ContactInfoDataSetTableAdapters.TableAdapterManager
End Class
