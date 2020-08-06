<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.grbSelectProduct = New System.Windows.Forms.GroupBox()
        Me.lstProduct = New System.Windows.Forms.ListBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnCloseProducts = New System.Windows.Forms.Button()
        Me.grbSelectProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbSelectProduct
        '
        Me.grbSelectProduct.Controls.Add(Me.lstProduct)
        Me.grbSelectProduct.Location = New System.Drawing.Point(13, 13)
        Me.grbSelectProduct.Name = "grbSelectProduct"
        Me.grbSelectProduct.Size = New System.Drawing.Size(284, 138)
        Me.grbSelectProduct.TabIndex = 0
        Me.grbSelectProduct.TabStop = False
        Me.grbSelectProduct.Text = "Select an Item"
        '
        'lstProduct
        '
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.Location = New System.Drawing.Point(7, 20)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(271, 108)
        Me.lstProduct.TabIndex = 0
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(77, 157)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 44)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Add to List"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnCloseProducts
        '
        Me.btnCloseProducts.Location = New System.Drawing.Point(158, 157)
        Me.btnCloseProducts.Name = "btnCloseProducts"
        Me.btnCloseProducts.Size = New System.Drawing.Size(75, 44)
        Me.btnCloseProducts.TabIndex = 2
        Me.btnCloseProducts.Text = "Close"
        Me.btnCloseProducts.UseVisualStyleBackColor = True
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 214)
        Me.Controls.Add(Me.btnCloseProducts)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.grbSelectProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Products"
        Me.grbSelectProduct.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbSelectProduct As GroupBox
    Friend WithEvents lstProduct As ListBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnCloseProducts As Button
End Class
