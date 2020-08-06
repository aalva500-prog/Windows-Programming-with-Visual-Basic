<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShoppingCart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShoppingCart))
        Me.gpbStoreDetails = New System.Windows.Forms.GroupBox()
        Me.cboStore = New System.Windows.Forms.ComboBox()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.gpbTitleDetails = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.mtbQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gpbOrderDetails = New System.Windows.Forms.GroupBox()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.lblOrderNumText = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblDiscounts = New System.Windows.Forms.Label()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.lblTaxText = New System.Windows.Forms.Label()
        Me.lblSubTotalText = New System.Windows.Forms.Label()
        Me.lblDiscountsText = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.lstTitlesToOrder = New System.Windows.Forms.ListBox()
        Me.chkInitialCustomer = New System.Windows.Forms.CheckBox()
        Me.cboPayTerms = New System.Windows.Forms.ComboBox()
        Me.lblPayTerms = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbpAdditionalDetails = New System.Windows.Forms.GroupBox()
        Me.gpbStoreDetails.SuspendLayout()
        Me.gpbTitleDetails.SuspendLayout()
        Me.gpbOrderDetails.SuspendLayout()
        Me.gbpAdditionalDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbStoreDetails
        '
        Me.gpbStoreDetails.Controls.Add(Me.cboStore)
        Me.gpbStoreDetails.Controls.Add(Me.lblStore)
        Me.gpbStoreDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbStoreDetails.Location = New System.Drawing.Point(12, 12)
        Me.gpbStoreDetails.Name = "gpbStoreDetails"
        Me.gpbStoreDetails.Size = New System.Drawing.Size(332, 98)
        Me.gpbStoreDetails.TabIndex = 0
        Me.gpbStoreDetails.TabStop = False
        Me.gpbStoreDetails.Text = "Store Details"
        '
        'cboStore
        '
        Me.cboStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStore.FormattingEnabled = True
        Me.cboStore.Location = New System.Drawing.Point(13, 47)
        Me.cboStore.Name = "cboStore"
        Me.cboStore.Size = New System.Drawing.Size(298, 24)
        Me.cboStore.TabIndex = 0
        '
        'lblStore
        '
        Me.lblStore.AutoSize = True
        Me.lblStore.Location = New System.Drawing.Point(16, 28)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(97, 16)
        Me.lblStore.TabIndex = 3
        Me.lblStore.Text = "Select Store:"
        '
        'gpbTitleDetails
        '
        Me.gpbTitleDetails.Controls.Add(Me.btnClear)
        Me.gpbTitleDetails.Controls.Add(Me.mtbQuantity)
        Me.gpbTitleDetails.Controls.Add(Me.btnAddItem)
        Me.gpbTitleDetails.Controls.Add(Me.btnRemoveItem)
        Me.gpbTitleDetails.Controls.Add(Me.lblQuantity)
        Me.gpbTitleDetails.Controls.Add(Me.btnSearch)
        Me.gpbTitleDetails.Controls.Add(Me.txtTitle)
        Me.gpbTitleDetails.Controls.Add(Me.lblTitle)
        Me.gpbTitleDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbTitleDetails.Location = New System.Drawing.Point(365, 12)
        Me.gpbTitleDetails.Name = "gpbTitleDetails"
        Me.gpbTitleDetails.Size = New System.Drawing.Size(546, 205)
        Me.gpbTitleDetails.TabIndex = 1
        Me.gpbTitleDetails.TabStop = False
        Me.gpbTitleDetails.Text = "Title Details"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(378, 120)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'mtbQuantity
        '
        Me.mtbQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbQuantity.Location = New System.Drawing.Point(466, 47)
        Me.mtbQuantity.Mask = "00000"
        Me.mtbQuantity.Name = "mtbQuantity"
        Me.mtbQuantity.Size = New System.Drawing.Size(62, 22)
        Me.mtbQuantity.TabIndex = 4
        Me.mtbQuantity.ValidatingType = GetType(Integer)
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(41, 120)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(140, 36)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(211, 120)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(140, 36)
        Me.btnRemoveItem.TabIndex = 6
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(463, 28)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 16)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(371, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(17, 47)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(351, 22)
        Me.txtTitle.TabIndex = 11
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(20, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 16)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Title Name:"
        '
        'gpbOrderDetails
        '
        Me.gpbOrderDetails.Controls.Add(Me.lblOrderNum)
        Me.gpbOrderDetails.Controls.Add(Me.lblOrderNumText)
        Me.gpbOrderDetails.Controls.Add(Me.lblTotal)
        Me.gpbOrderDetails.Controls.Add(Me.lblTax)
        Me.gpbOrderDetails.Controls.Add(Me.lblSubTotal)
        Me.gpbOrderDetails.Controls.Add(Me.lblDiscounts)
        Me.gpbOrderDetails.Controls.Add(Me.lblTotalText)
        Me.gpbOrderDetails.Controls.Add(Me.lblTaxText)
        Me.gpbOrderDetails.Controls.Add(Me.lblSubTotalText)
        Me.gpbOrderDetails.Controls.Add(Me.lblDiscountsText)
        Me.gpbOrderDetails.Controls.Add(Me.lblOrderDate)
        Me.gpbOrderDetails.Controls.Add(Me.dtpOrderDate)
        Me.gpbOrderDetails.Controls.Add(Me.lstTitlesToOrder)
        Me.gpbOrderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbOrderDetails.Location = New System.Drawing.Point(12, 236)
        Me.gpbOrderDetails.Name = "gpbOrderDetails"
        Me.gpbOrderDetails.Size = New System.Drawing.Size(899, 328)
        Me.gpbOrderDetails.TabIndex = 2
        Me.gpbOrderDetails.TabStop = False
        Me.gpbOrderDetails.Text = " Order Details"
        '
        'lblOrderNum
        '
        Me.lblOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderNum.Location = New System.Drawing.Point(602, 51)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(128, 22)
        Me.lblOrderNum.TabIndex = 18
        Me.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderNumText
        '
        Me.lblOrderNumText.AutoSize = True
        Me.lblOrderNumText.Location = New System.Drawing.Point(602, 32)
        Me.lblOrderNumText.Name = "lblOrderNumText"
        Me.lblOrderNumText.Size = New System.Drawing.Size(86, 16)
        Me.lblOrderNumText.TabIndex = 17
        Me.lblOrderNumText.Text = "Order Num:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(661, 268)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(186, 34)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(661, 216)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(186, 34)
        Me.lblTax.TabIndex = 15
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(660, 164)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(186, 34)
        Me.lblSubTotal.TabIndex = 14
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiscounts
        '
        Me.lblDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscounts.Location = New System.Drawing.Point(660, 111)
        Me.lblDiscounts.Name = "lblDiscounts"
        Me.lblDiscounts.Size = New System.Drawing.Size(186, 34)
        Me.lblDiscounts.TabIndex = 13
        Me.lblDiscounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalText
        '
        Me.lblTotalText.Location = New System.Drawing.Point(566, 268)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(89, 34)
        Me.lblTotalText.TabIndex = 12
        Me.lblTotalText.Text = "Total:"
        Me.lblTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxText
        '
        Me.lblTaxText.Location = New System.Drawing.Point(566, 216)
        Me.lblTaxText.Name = "lblTaxText"
        Me.lblTaxText.Size = New System.Drawing.Size(89, 34)
        Me.lblTaxText.TabIndex = 11
        Me.lblTaxText.Text = "Tax:"
        Me.lblTaxText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotalText
        '
        Me.lblSubTotalText.Location = New System.Drawing.Point(565, 164)
        Me.lblSubTotalText.Name = "lblSubTotalText"
        Me.lblSubTotalText.Size = New System.Drawing.Size(89, 34)
        Me.lblSubTotalText.TabIndex = 10
        Me.lblSubTotalText.Text = "Sub-Total:"
        Me.lblSubTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscountsText
        '
        Me.lblDiscountsText.Location = New System.Drawing.Point(565, 111)
        Me.lblDiscountsText.Name = "lblDiscountsText"
        Me.lblDiscountsText.Size = New System.Drawing.Size(89, 34)
        Me.lblDiscountsText.TabIndex = 5
        Me.lblDiscountsText.Text = "Discounts:"
        Me.lblDiscountsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(761, 31)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(88, 16)
        Me.lblOrderDate.TabIndex = 6
        Me.lblOrderDate.Text = "Order Date:"
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(758, 51)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(134, 22)
        Me.dtpOrderDate.TabIndex = 8
        '
        'lstTitlesToOrder
        '
        Me.lstTitlesToOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTitlesToOrder.FormattingEnabled = True
        Me.lstTitlesToOrder.HorizontalScrollbar = True
        Me.lstTitlesToOrder.ItemHeight = 16
        Me.lstTitlesToOrder.Location = New System.Drawing.Point(6, 21)
        Me.lstTitlesToOrder.Name = "lstTitlesToOrder"
        Me.lstTitlesToOrder.Size = New System.Drawing.Size(553, 292)
        Me.lstTitlesToOrder.TabIndex = 3
        '
        'chkInitialCustomer
        '
        Me.chkInitialCustomer.AutoSize = True
        Me.chkInitialCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInitialCustomer.Location = New System.Drawing.Point(18, 40)
        Me.chkInitialCustomer.Name = "chkInitialCustomer"
        Me.chkInitialCustomer.Size = New System.Drawing.Size(133, 20)
        Me.chkInitialCustomer.TabIndex = 1
        Me.chkInitialCustomer.Text = "Initial Customer"
        Me.chkInitialCustomer.UseVisualStyleBackColor = True
        '
        'cboPayTerms
        '
        Me.cboPayTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPayTerms.FormattingEnabled = True
        Me.cboPayTerms.Items.AddRange(New Object() {"ON Invoice", "Net 30", "Net 60"})
        Me.cboPayTerms.Location = New System.Drawing.Point(171, 38)
        Me.cboPayTerms.Name = "cboPayTerms"
        Me.cboPayTerms.Size = New System.Drawing.Size(140, 24)
        Me.cboPayTerms.TabIndex = 2
        '
        'lblPayTerms
        '
        Me.lblPayTerms.AutoSize = True
        Me.lblPayTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayTerms.Location = New System.Drawing.Point(174, 18)
        Me.lblPayTerms.Name = "lblPayTerms"
        Me.lblPayTerms.Size = New System.Drawing.Size(87, 16)
        Me.lblPayTerms.TabIndex = 5
        Me.lblPayTerms.Text = "Pay Terms:"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(295, 586)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(133, 42)
        Me.btnPlaceOrder.TabIndex = 9
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(456, 586)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 42)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbpAdditionalDetails
        '
        Me.gbpAdditionalDetails.Controls.Add(Me.lblPayTerms)
        Me.gbpAdditionalDetails.Controls.Add(Me.cboPayTerms)
        Me.gbpAdditionalDetails.Controls.Add(Me.chkInitialCustomer)
        Me.gbpAdditionalDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpAdditionalDetails.Location = New System.Drawing.Point(12, 130)
        Me.gbpAdditionalDetails.Name = "gbpAdditionalDetails"
        Me.gbpAdditionalDetails.Size = New System.Drawing.Size(332, 87)
        Me.gbpAdditionalDetails.TabIndex = 5
        Me.gbpAdditionalDetails.TabStop = False
        Me.gbpAdditionalDetails.Text = "Additional Details"
        '
        'frmShoppingCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(922, 636)
        Me.Controls.Add(Me.gbpAdditionalDetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.gpbOrderDetails)
        Me.Controls.Add(Me.gpbTitleDetails)
        Me.Controls.Add(Me.gpbStoreDetails)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShoppingCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart"
        Me.gpbStoreDetails.ResumeLayout(False)
        Me.gpbStoreDetails.PerformLayout()
        Me.gpbTitleDetails.ResumeLayout(False)
        Me.gpbTitleDetails.PerformLayout()
        Me.gpbOrderDetails.ResumeLayout(False)
        Me.gpbOrderDetails.PerformLayout()
        Me.gbpAdditionalDetails.ResumeLayout(False)
        Me.gbpAdditionalDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbStoreDetails As Windows.Forms.GroupBox
    Friend WithEvents gpbTitleDetails As Windows.Forms.GroupBox
    Friend WithEvents gpbOrderDetails As Windows.Forms.GroupBox
    Friend WithEvents cboStore As Windows.Forms.ComboBox
    Friend WithEvents lblStore As Windows.Forms.Label
    Friend WithEvents txtTitle As Windows.Forms.TextBox
    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents btnSearch As Windows.Forms.Button
    Friend WithEvents btnAddItem As Windows.Forms.Button
    Friend WithEvents btnRemoveItem As Windows.Forms.Button
    Friend WithEvents lblQuantity As Windows.Forms.Label
    Friend WithEvents lstTitlesToOrder As Windows.Forms.ListBox
    Friend WithEvents btnPlaceOrder As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents cboPayTerms As Windows.Forms.ComboBox
    Friend WithEvents lblPayTerms As Windows.Forms.Label
    Friend WithEvents lblOrderDate As Windows.Forms.Label
    Friend WithEvents dtpOrderDate As Windows.Forms.DateTimePicker
    Friend WithEvents chkInitialCustomer As Windows.Forms.CheckBox
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents lblTax As Windows.Forms.Label
    Friend WithEvents lblSubTotal As Windows.Forms.Label
    Friend WithEvents lblDiscounts As Windows.Forms.Label
    Friend WithEvents lblTotalText As Windows.Forms.Label
    Friend WithEvents lblTaxText As Windows.Forms.Label
    Friend WithEvents lblSubTotalText As Windows.Forms.Label
    Friend WithEvents lblDiscountsText As Windows.Forms.Label
    Friend WithEvents mtbQuantity As Windows.Forms.MaskedTextBox
    Friend WithEvents btnClear As Windows.Forms.Button
    Friend WithEvents gbpAdditionalDetails As Windows.Forms.GroupBox
    Friend WithEvents lblOrderNumText As Windows.Forms.Label
    Friend WithEvents lblOrderNum As Windows.Forms.Label
End Class
