<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.gbItems = New System.Windows.Forms.GroupBox()
        Me.lstItemsOrdered = New System.Windows.Forms.ListBox()
        Me.gbCostSummary = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
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
        Me.gbItems.SuspendLayout()
        Me.gbCostSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(377, 427)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(157, 53)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(394, 21)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(157, 24)
        Me.lblOrder.TabIndex = 1
        Me.lblOrder.Text = "Order Summary"
        '
        'gbItems
        '
        Me.gbItems.Controls.Add(Me.lstItemsOrdered)
        Me.gbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbItems.Location = New System.Drawing.Point(12, 62)
        Me.gbItems.Name = "gbItems"
        Me.gbItems.Size = New System.Drawing.Size(522, 339)
        Me.gbItems.TabIndex = 2
        Me.gbItems.TabStop = False
        Me.gbItems.Text = "Items Ordered"
        '
        'lstItemsOrdered
        '
        Me.lstItemsOrdered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItemsOrdered.FormattingEnabled = True
        Me.lstItemsOrdered.HorizontalScrollbar = True
        Me.lstItemsOrdered.ItemHeight = 16
        Me.lstItemsOrdered.Location = New System.Drawing.Point(6, 21)
        Me.lstItemsOrdered.Name = "lstItemsOrdered"
        Me.lstItemsOrdered.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstItemsOrdered.Size = New System.Drawing.Size(504, 308)
        Me.lstItemsOrdered.TabIndex = 3
        '
        'gbCostSummary
        '
        Me.gbCostSummary.Controls.Add(Me.lblDate)
        Me.gbCostSummary.Controls.Add(Me.lblOrderNum)
        Me.gbCostSummary.Controls.Add(Me.lblOrderNumText)
        Me.gbCostSummary.Controls.Add(Me.lblTotal)
        Me.gbCostSummary.Controls.Add(Me.lblTax)
        Me.gbCostSummary.Controls.Add(Me.lblSubTotal)
        Me.gbCostSummary.Controls.Add(Me.lblDiscounts)
        Me.gbCostSummary.Controls.Add(Me.lblTotalText)
        Me.gbCostSummary.Controls.Add(Me.lblTaxText)
        Me.gbCostSummary.Controls.Add(Me.lblSubTotalText)
        Me.gbCostSummary.Controls.Add(Me.lblDiscountsText)
        Me.gbCostSummary.Controls.Add(Me.lblOrderDate)
        Me.gbCostSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCostSummary.Location = New System.Drawing.Point(540, 62)
        Me.gbCostSummary.Name = "gbCostSummary"
        Me.gbCostSummary.Size = New System.Drawing.Size(371, 339)
        Me.gbCostSummary.TabIndex = 3
        Me.gbCostSummary.TabStop = False
        Me.gbCostSummary.Text = "Order Details"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(221, 63)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(128, 22)
        Me.lblDate.TabIndex = 30
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderNum
        '
        Me.lblOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderNum.Location = New System.Drawing.Point(59, 63)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(128, 22)
        Me.lblOrderNum.TabIndex = 29
        Me.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderNumText
        '
        Me.lblOrderNumText.AutoSize = True
        Me.lblOrderNumText.Location = New System.Drawing.Point(59, 44)
        Me.lblOrderNumText.Name = "lblOrderNumText"
        Me.lblOrderNumText.Size = New System.Drawing.Size(86, 16)
        Me.lblOrderNumText.TabIndex = 28
        Me.lblOrderNumText.Text = "Order Num:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(118, 280)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(186, 34)
        Me.lblTotal.TabIndex = 27
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(118, 228)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(186, 34)
        Me.lblTax.TabIndex = 26
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(117, 176)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(186, 34)
        Me.lblSubTotal.TabIndex = 25
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiscounts
        '
        Me.lblDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscounts.Location = New System.Drawing.Point(117, 123)
        Me.lblDiscounts.Name = "lblDiscounts"
        Me.lblDiscounts.Size = New System.Drawing.Size(186, 34)
        Me.lblDiscounts.TabIndex = 24
        Me.lblDiscounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalText
        '
        Me.lblTotalText.Location = New System.Drawing.Point(23, 280)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(89, 34)
        Me.lblTotalText.TabIndex = 23
        Me.lblTotalText.Text = "Total:"
        Me.lblTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxText
        '
        Me.lblTaxText.Location = New System.Drawing.Point(23, 228)
        Me.lblTaxText.Name = "lblTaxText"
        Me.lblTaxText.Size = New System.Drawing.Size(89, 34)
        Me.lblTaxText.TabIndex = 22
        Me.lblTaxText.Text = "Tax:"
        Me.lblTaxText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotalText
        '
        Me.lblSubTotalText.Location = New System.Drawing.Point(22, 176)
        Me.lblSubTotalText.Name = "lblSubTotalText"
        Me.lblSubTotalText.Size = New System.Drawing.Size(89, 34)
        Me.lblSubTotalText.TabIndex = 21
        Me.lblSubTotalText.Text = "Sub-Total:"
        Me.lblSubTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscountsText
        '
        Me.lblDiscountsText.Location = New System.Drawing.Point(22, 123)
        Me.lblDiscountsText.Name = "lblDiscountsText"
        Me.lblDiscountsText.Size = New System.Drawing.Size(89, 34)
        Me.lblDiscountsText.TabIndex = 19
        Me.lblDiscountsText.Text = "Discounts:"
        Me.lblDiscountsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(218, 43)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(88, 16)
        Me.lblOrderDate.TabIndex = 20
        Me.lblOrderDate.Text = "Order Date:"
        '
        'frmInvoice
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(923, 503)
        Me.Controls.Add(Me.gbCostSummary)
        Me.Controls.Add(Me.gbItems)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnConfirm)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice/Receipt"
        Me.gbItems.ResumeLayout(False)
        Me.gbCostSummary.ResumeLayout(False)
        Me.gbCostSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirm As Windows.Forms.Button
    Friend WithEvents lblOrder As Windows.Forms.Label
    Friend WithEvents gbItems As Windows.Forms.GroupBox
    Friend WithEvents lstItemsOrdered As Windows.Forms.ListBox
    Friend WithEvents gbCostSummary As Windows.Forms.GroupBox
    Friend WithEvents lblOrderNum As Windows.Forms.Label
    Friend WithEvents lblOrderNumText As Windows.Forms.Label
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents lblTax As Windows.Forms.Label
    Friend WithEvents lblSubTotal As Windows.Forms.Label
    Friend WithEvents lblDiscounts As Windows.Forms.Label
    Friend WithEvents lblTotalText As Windows.Forms.Label
    Friend WithEvents lblTaxText As Windows.Forms.Label
    Friend WithEvents lblSubTotalText As Windows.Forms.Label
    Friend WithEvents lblDiscountsText As Windows.Forms.Label
    Friend WithEvents lblOrderDate As Windows.Forms.Label
    Friend WithEvents lblDate As Windows.Forms.Label
End Class
