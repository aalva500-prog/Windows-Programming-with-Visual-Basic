<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShopList))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouponsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstShoppingList = New System.Windows.Forms.ListBox()
        Me.grbShoppingList = New System.Windows.Forms.GroupBox()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblCoupons = New System.Windows.Forms.Label()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblShippingText = New System.Windows.Forms.Label()
        Me.lblContains = New System.Windows.Forms.Label()
        Me.lblTaxText = New System.Windows.Forms.Label()
        Me.cboContains = New System.Windows.Forms.ComboBox()
        Me.lblCouponsText = New System.Windows.Forms.Label()
        Me.lblProductsText = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grbShoppingList.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShopToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShopToolStripMenuItem
        '
        Me.ShopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouponsToolStripMenuItem, Me.ProductsToolStripMenuItem})
        Me.ShopToolStripMenuItem.Name = "ShopToolStripMenuItem"
        Me.ShopToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ShopToolStripMenuItem.Text = "Shop"
        '
        'CouponsToolStripMenuItem
        '
        Me.CouponsToolStripMenuItem.Name = "CouponsToolStripMenuItem"
        Me.CouponsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CouponsToolStripMenuItem.Text = "Coupons"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lstShoppingList
        '
        Me.lstShoppingList.FormattingEnabled = True
        Me.lstShoppingList.Location = New System.Drawing.Point(6, 19)
        Me.lstShoppingList.Name = "lstShoppingList"
        Me.lstShoppingList.Size = New System.Drawing.Size(262, 160)
        Me.lstShoppingList.TabIndex = 1
        '
        'grbShoppingList
        '
        Me.grbShoppingList.Controls.Add(Me.chkDelivery)
        Me.grbShoppingList.Controls.Add(Me.lblTotal)
        Me.grbShoppingList.Controls.Add(Me.lblShipping)
        Me.grbShoppingList.Controls.Add(Me.lblTax)
        Me.grbShoppingList.Controls.Add(Me.lblCoupons)
        Me.grbShoppingList.Controls.Add(Me.lblProducts)
        Me.grbShoppingList.Controls.Add(Me.lblTotalText)
        Me.grbShoppingList.Controls.Add(Me.btnRemove)
        Me.grbShoppingList.Controls.Add(Me.lblShippingText)
        Me.grbShoppingList.Controls.Add(Me.lblContains)
        Me.grbShoppingList.Controls.Add(Me.lblTaxText)
        Me.grbShoppingList.Controls.Add(Me.cboContains)
        Me.grbShoppingList.Controls.Add(Me.lblCouponsText)
        Me.grbShoppingList.Controls.Add(Me.lstShoppingList)
        Me.grbShoppingList.Controls.Add(Me.lblProductsText)
        Me.grbShoppingList.Location = New System.Drawing.Point(12, 37)
        Me.grbShoppingList.Name = "grbShoppingList"
        Me.grbShoppingList.Size = New System.Drawing.Size(440, 233)
        Me.grbShoppingList.TabIndex = 2
        Me.grbShoppingList.TabStop = False
        Me.grbShoppingList.Text = "Shopping List"
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(352, 195)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(70, 17)
        Me.chkDelivery.TabIndex = 12
        Me.chkDelivery.Text = "Delivery?"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(353, 137)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 23)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShipping
        '
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipping.Location = New System.Drawing.Point(353, 107)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(76, 23)
        Me.lblShipping.TabIndex = 10
        Me.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(353, 78)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(76, 23)
        Me.lblTax.TabIndex = 9
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCoupons
        '
        Me.lblCoupons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCoupons.Location = New System.Drawing.Point(353, 48)
        Me.lblCoupons.Name = "lblCoupons"
        Me.lblCoupons.Size = New System.Drawing.Size(76, 23)
        Me.lblCoupons.TabIndex = 8
        Me.lblCoupons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProducts
        '
        Me.lblProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProducts.Location = New System.Drawing.Point(353, 19)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(76, 23)
        Me.lblProducts.TabIndex = 3
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalText
        '
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Location = New System.Drawing.Point(302, 137)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalText.TabIndex = 7
        Me.lblTotalText.Text = "Total:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(193, 189)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 31)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblShippingText
        '
        Me.lblShippingText.AutoSize = True
        Me.lblShippingText.Location = New System.Drawing.Point(286, 107)
        Me.lblShippingText.Name = "lblShippingText"
        Me.lblShippingText.Size = New System.Drawing.Size(51, 13)
        Me.lblShippingText.TabIndex = 6
        Me.lblShippingText.Text = "Shipping:"
        '
        'lblContains
        '
        Me.lblContains.AutoSize = True
        Me.lblContains.Location = New System.Drawing.Point(6, 198)
        Me.lblContains.Name = "lblContains"
        Me.lblContains.Size = New System.Drawing.Size(54, 13)
        Me.lblContains.TabIndex = 3
        Me.lblContains.Text = "Contains?"
        '
        'lblTaxText
        '
        Me.lblTaxText.AutoSize = True
        Me.lblTaxText.Location = New System.Drawing.Point(308, 78)
        Me.lblTaxText.Name = "lblTaxText"
        Me.lblTaxText.Size = New System.Drawing.Size(28, 13)
        Me.lblTaxText.TabIndex = 5
        Me.lblTaxText.Text = "Tax:"
        '
        'cboContains
        '
        Me.cboContains.FormattingEnabled = True
        Me.cboContains.Location = New System.Drawing.Point(66, 195)
        Me.cboContains.Name = "cboContains"
        Me.cboContains.Size = New System.Drawing.Size(121, 21)
        Me.cboContains.TabIndex = 2
        '
        'lblCouponsText
        '
        Me.lblCouponsText.AutoSize = True
        Me.lblCouponsText.Location = New System.Drawing.Point(286, 48)
        Me.lblCouponsText.Name = "lblCouponsText"
        Me.lblCouponsText.Size = New System.Drawing.Size(52, 13)
        Me.lblCouponsText.TabIndex = 4
        Me.lblCouponsText.Text = "Coupons:"
        '
        'lblProductsText
        '
        Me.lblProductsText.AutoSize = True
        Me.lblProductsText.Location = New System.Drawing.Point(285, 19)
        Me.lblProductsText.Name = "lblProductsText"
        Me.lblProductsText.Size = New System.Drawing.Size(52, 13)
        Me.lblProductsText.TabIndex = 3
        Me.lblProductsText.Text = "Products:"
        '
        'frmShopList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 282)
        Me.Controls.Add(Me.grbShoppingList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmShopList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shop List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbShoppingList.ResumeLayout(False)
        Me.grbShoppingList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CouponsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstShoppingList As ListBox
    Friend WithEvents grbShoppingList As GroupBox
    Friend WithEvents lblContains As Label
    Friend WithEvents cboContains As ComboBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblTotalText As Label
    Friend WithEvents lblShippingText As Label
    Friend WithEvents lblTaxText As Label
    Friend WithEvents lblCouponsText As Label
    Friend WithEvents lblProductsText As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblCoupons As Label
    Friend WithEvents lblProducts As Label
    Friend WithEvents chkDelivery As CheckBox
End Class
