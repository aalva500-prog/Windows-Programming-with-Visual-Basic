<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterContactInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim ExtensionLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grbDisplayContactInfo = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactInfoDataSet1 = New ContactInfo.ContactInfoDataSet()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.mtbTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.PersonTableAdapter = New ContactInfo.ContactInfoDataSetTableAdapters.PersonTableAdapter()
        Me.TableAdapterManager = New ContactInfo.ContactInfoDataSetTableAdapters.TableAdapterManager()
        IdLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        ExtensionLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.grbDisplayContactInfo.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactInfoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.Location = New System.Drawing.Point(23, 33)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(92, 16)
        IdLabel.TabIndex = 0
        IdLabel.Text = "ID:"
        IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'First_NameLabel
        '
        First_NameLabel.Location = New System.Drawing.Point(23, 61)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(92, 16)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        First_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.Location = New System.Drawing.Point(23, 89)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(92, 16)
        Middle_NameLabel.TabIndex = 4
        Middle_NameLabel.Text = "Middle Name:"
        Middle_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Last_NameLabel
        '
        Last_NameLabel.Location = New System.Drawing.Point(23, 117)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(92, 16)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        Last_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TypeLabel
        '
        TypeLabel.Location = New System.Drawing.Point(23, 145)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(92, 21)
        TypeLabel.TabIndex = 8
        TypeLabel.Text = "Type:"
        TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TelephoneLabel
        '
        TelephoneLabel.Location = New System.Drawing.Point(23, 175)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(92, 16)
        TelephoneLabel.TabIndex = 10
        TelephoneLabel.Text = "Telephone:"
        TelephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExtensionLabel
        '
        ExtensionLabel.Location = New System.Drawing.Point(23, 203)
        ExtensionLabel.Name = "ExtensionLabel"
        ExtensionLabel.Size = New System.Drawing.Size(92, 16)
        ExtensionLabel.TabIndex = 12
        ExtensionLabel.Text = "Extension:"
        ExtensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailLabel
        '
        EmailLabel.Location = New System.Drawing.Point(8, 231)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(107, 16)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "Email Address:"
        EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(237, 283)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 57)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRecord.Location = New System.Drawing.Point(13, 283)
        Me.btnSaveRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(101, 57)
        Me.btnSaveRecord.TabIndex = 8
        Me.btnSaveRecord.Text = "Save Record"
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(125, 283)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 57)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grbDisplayContactInfo
        '
        Me.grbDisplayContactInfo.Controls.Add(IdLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.txtID)
        Me.grbDisplayContactInfo.Controls.Add(First_NameLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.txtFirstName)
        Me.grbDisplayContactInfo.Controls.Add(Middle_NameLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.txtMiddleName)
        Me.grbDisplayContactInfo.Controls.Add(Last_NameLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.txtLastName)
        Me.grbDisplayContactInfo.Controls.Add(TypeLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.cboType)
        Me.grbDisplayContactInfo.Controls.Add(TelephoneLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.mtbTelephone)
        Me.grbDisplayContactInfo.Controls.Add(ExtensionLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.txtExtension)
        Me.grbDisplayContactInfo.Controls.Add(EmailLabel)
        Me.grbDisplayContactInfo.Controls.Add(Me.txtEmail)
        Me.grbDisplayContactInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDisplayContactInfo.Location = New System.Drawing.Point(10, 14)
        Me.grbDisplayContactInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.grbDisplayContactInfo.Name = "grbDisplayContactInfo"
        Me.grbDisplayContactInfo.Padding = New System.Windows.Forms.Padding(5)
        Me.grbDisplayContactInfo.Size = New System.Drawing.Size(331, 260)
        Me.grbDisplayContactInfo.TabIndex = 28
        Me.grbDisplayContactInfo.TabStop = False
        Me.grbDisplayContactInfo.Text = "Enter Contact Info"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Id", True))
        Me.txtID.Location = New System.Drawing.Point(121, 30)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(202, 22)
        Me.txtID.TabIndex = 1
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.ContactInfoDataSet1
        '
        'ContactInfoDataSet1
        '
        Me.ContactInfoDataSet1.DataSetName = "ContactInfoDataSet1"
        Me.ContactInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "First_Name", True))
        Me.txtFirstName.Location = New System.Drawing.Point(121, 58)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(202, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'txtMiddleName
        '
        Me.txtMiddleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Middle_Name", True))
        Me.txtMiddleName.Location = New System.Drawing.Point(121, 86)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(202, 22)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Last_Name", True))
        Me.txtLastName.Location = New System.Drawing.Point(121, 114)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 22)
        Me.txtLastName.TabIndex = 3
        '
        'cboType
        '
        Me.cboType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Type", True))
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Friend", "Family", "School", "Work", "Other"})
        Me.cboType.Location = New System.Drawing.Point(121, 142)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(202, 24)
        Me.cboType.TabIndex = 4
        '
        'mtbTelephone
        '
        Me.mtbTelephone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Telephone", True))
        Me.mtbTelephone.Location = New System.Drawing.Point(121, 172)
        Me.mtbTelephone.Mask = "(999) 000-0000"
        Me.mtbTelephone.Name = "mtbTelephone"
        Me.mtbTelephone.Size = New System.Drawing.Size(202, 22)
        Me.mtbTelephone.TabIndex = 5
        '
        'txtExtension
        '
        Me.txtExtension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Extension", True))
        Me.txtExtension.Location = New System.Drawing.Point(121, 200)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(202, 22)
        Me.txtExtension.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(121, 228)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(202, 22)
        Me.txtEmail.TabIndex = 7
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
        'frmEnterContactInfo
        '
        Me.AcceptButton = Me.btnSaveRecord
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(350, 351)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grbDisplayContactInfo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEnterContactInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Contact Record"
        Me.grbDisplayContactInfo.ResumeLayout(False)
        Me.grbDisplayContactInfo.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactInfoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnSaveRecord As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grbDisplayContactInfo As GroupBox
    Friend WithEvents PersonBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PersonBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ContactInfoDataSet1 As ContactInfoDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As ContactInfoDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TableAdapterManager As ContactInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonBindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PersonBindingNavigator1SaveItem As ToolStripButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents mtbTelephone As MaskedTextBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents txtEmail As TextBox
End Class
