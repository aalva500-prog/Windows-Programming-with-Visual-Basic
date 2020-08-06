Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookStoreApplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookStoreApplication))
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublishersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblEmployeeFirstNameText = New System.Windows.Forms.Label()
        Me.lblEmployeeIDText = New System.Windows.Forms.Label()
        Me.lblLastNameText = New System.Windows.Forms.Label()
        Me.gpbLoginCredentials = New System.Windows.Forms.GroupBox()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.mnuMainMenu.SuspendLayout()
        Me.gpbLoginCredentials.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mnuMainMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.ReportToolStripMenuItem1})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.mnuMainMenu.Size = New System.Drawing.Size(735, 24)
        Me.mnuMainMenu.TabIndex = 0
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(42, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewOrderToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Enabled = False
        Me.OrdersToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'AddNewOrderToolStripMenuItem
        '
        Me.AddNewOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AddNewOrderToolStripMenuItem.Name = "AddNewOrderToolStripMenuItem"
        Me.AddNewOrderToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddNewOrderToolStripMenuItem.Text = "Add New Order"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitlesToolStripMenuItem, Me.AuthorsToolStripMenuItem, Me.PublishersToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Enabled = False
        Me.MaintenanceToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'TitlesToolStripMenuItem
        '
        Me.TitlesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TitlesToolStripMenuItem.Name = "TitlesToolStripMenuItem"
        Me.TitlesToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TitlesToolStripMenuItem.Text = "Titles"
        Me.TitlesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AuthorsToolStripMenuItem
        '
        Me.AuthorsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.AuthorsToolStripMenuItem.Name = "AuthorsToolStripMenuItem"
        Me.AuthorsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AuthorsToolStripMenuItem.Text = "Authors"
        '
        'PublishersToolStripMenuItem
        '
        Me.PublishersToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PublishersToolStripMenuItem.Name = "PublishersToolStripMenuItem"
        Me.PublishersToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PublishersToolStripMenuItem.Text = "Publishers"
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.Enabled = False
        Me.ReportToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(61, 22)
        Me.ReportToolStripMenuItem1.Text = "Report"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(218, 332)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(256, 24)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Book Store Application 3.1"
        '
        'lblEmployeeFirstNameText
        '
        Me.lblEmployeeFirstNameText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeFirstNameText.Location = New System.Drawing.Point(18, 78)
        Me.lblEmployeeFirstNameText.Name = "lblEmployeeFirstNameText"
        Me.lblEmployeeFirstNameText.Size = New System.Drawing.Size(115, 27)
        Me.lblEmployeeFirstNameText.TabIndex = 2
        Me.lblEmployeeFirstNameText.Text = "First Name:"
        Me.lblEmployeeFirstNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeIDText
        '
        Me.lblEmployeeIDText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeIDText.Location = New System.Drawing.Point(18, 34)
        Me.lblEmployeeIDText.Name = "lblEmployeeIDText"
        Me.lblEmployeeIDText.Size = New System.Drawing.Size(115, 26)
        Me.lblEmployeeIDText.TabIndex = 3
        Me.lblEmployeeIDText.Text = "Employee ID:"
        Me.lblEmployeeIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastNameText
        '
        Me.lblLastNameText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameText.Location = New System.Drawing.Point(18, 120)
        Me.lblLastNameText.Name = "lblLastNameText"
        Me.lblLastNameText.Size = New System.Drawing.Size(115, 28)
        Me.lblLastNameText.TabIndex = 4
        Me.lblLastNameText.Text = "Last Name:"
        Me.lblLastNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpbLoginCredentials
        '
        Me.gpbLoginCredentials.Controls.Add(Me.lblEmployeeID)
        Me.gpbLoginCredentials.Controls.Add(Me.lblLastName)
        Me.gpbLoginCredentials.Controls.Add(Me.lblFirstName)
        Me.gpbLoginCredentials.Controls.Add(Me.lblEmployeeIDText)
        Me.gpbLoginCredentials.Controls.Add(Me.lblLastNameText)
        Me.gpbLoginCredentials.Controls.Add(Me.lblEmployeeFirstNameText)
        Me.gpbLoginCredentials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbLoginCredentials.Location = New System.Drawing.Point(153, 83)
        Me.gpbLoginCredentials.Name = "gpbLoginCredentials"
        Me.gpbLoginCredentials.Size = New System.Drawing.Size(407, 181)
        Me.gpbLoginCredentials.TabIndex = 5
        Me.gpbLoginCredentials.TabStop = False
        Me.gpbLoginCredentials.Text = "     You have logged in with the following credentials:    "
        Me.gpbLoginCredentials.Visible = False
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeID.Location = New System.Drawing.Point(146, 33)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(206, 26)
        Me.lblEmployeeID.TabIndex = 6
        Me.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(146, 119)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(206, 28)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(146, 77)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(206, 27)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmBookStoreApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(735, 430)
        Me.Controls.Add(Me.gpbLoginCredentials)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmBookStoreApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Store Application"
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.gpbLoginCredentials.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublishersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblEmployeeFirstNameText As Label
    Friend WithEvents lblEmployeeIDText As Label
    Friend WithEvents lblLastNameText As Label
    Friend WithEvents gpbLoginCredentials As GroupBox
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents AddNewOrderToolStripMenuItem As ToolStripMenuItem
End Class
