<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoupons
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
        Me.grbSelectCoupon = New System.Windows.Forms.GroupBox()
        Me.lstCoupon = New System.Windows.Forms.ListBox()
        Me.btnAddCoupon = New System.Windows.Forms.Button()
        Me.btnCloseCoupons = New System.Windows.Forms.Button()
        Me.grbSelectCoupon.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbSelectCoupon
        '
        Me.grbSelectCoupon.Controls.Add(Me.lstCoupon)
        Me.grbSelectCoupon.Location = New System.Drawing.Point(13, 13)
        Me.grbSelectCoupon.Name = "grbSelectCoupon"
        Me.grbSelectCoupon.Size = New System.Drawing.Size(267, 126)
        Me.grbSelectCoupon.TabIndex = 0
        Me.grbSelectCoupon.TabStop = False
        Me.grbSelectCoupon.Text = "Select an Item"
        '
        'lstCoupon
        '
        Me.lstCoupon.FormattingEnabled = True
        Me.lstCoupon.Location = New System.Drawing.Point(6, 19)
        Me.lstCoupon.Name = "lstCoupon"
        Me.lstCoupon.Size = New System.Drawing.Size(254, 95)
        Me.lstCoupon.TabIndex = 0
        '
        'btnAddCoupon
        '
        Me.btnAddCoupon.Location = New System.Drawing.Point(65, 151)
        Me.btnAddCoupon.Name = "btnAddCoupon"
        Me.btnAddCoupon.Size = New System.Drawing.Size(75, 48)
        Me.btnAddCoupon.TabIndex = 1
        Me.btnAddCoupon.Text = "Add to List"
        Me.btnAddCoupon.UseVisualStyleBackColor = True
        '
        'btnCloseCoupons
        '
        Me.btnCloseCoupons.Location = New System.Drawing.Point(146, 151)
        Me.btnCloseCoupons.Name = "btnCloseCoupons"
        Me.btnCloseCoupons.Size = New System.Drawing.Size(75, 48)
        Me.btnCloseCoupons.TabIndex = 2
        Me.btnCloseCoupons.Text = "Close"
        Me.btnCloseCoupons.UseVisualStyleBackColor = True
        '
        'frmCoupons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 211)
        Me.Controls.Add(Me.btnCloseCoupons)
        Me.Controls.Add(Me.btnAddCoupon)
        Me.Controls.Add(Me.grbSelectCoupon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCoupons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Coupons"
        Me.grbSelectCoupon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbSelectCoupon As GroupBox
    Friend WithEvents lstCoupon As ListBox
    Friend WithEvents btnAddCoupon As Button
    Friend WithEvents btnCloseCoupons As Button
End Class
