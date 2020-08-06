<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculator))
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnRest = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnExponential = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnModulo = New System.Windows.Forms.Button()
        Me.btnNegative = New System.Windows.Forms.Button()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.btnLogarithm = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnMC = New System.Windows.Forms.Button()
        Me.btnMR = New System.Windows.Forms.Button()
        Me.btnMS = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResultLabel = New System.Windows.Forms.Label()
        Me.lblEquationLabel = New System.Windows.Forms.Label()
        Me.lblMemoryLabel = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(47, 31)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(50, 20)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input:"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(103, 28)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(200, 26)
        Me.txtInput.TabIndex = 1
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(104, 79)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(57, 41)
        Me.btnPlus.TabIndex = 2
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnRest
        '
        Me.btnRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRest.Location = New System.Drawing.Point(176, 79)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(57, 41)
        Me.btnRest.TabIndex = 3
        Me.btnRest.Text = "-"
        Me.btnRest.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.Location = New System.Drawing.Point(247, 79)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(57, 41)
        Me.btnMultiplication.TabIndex = 4
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnExponential
        '
        Me.btnExponential.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExponential.Location = New System.Drawing.Point(104, 130)
        Me.btnExponential.Name = "btnExponential"
        Me.btnExponential.Size = New System.Drawing.Size(57, 41)
        Me.btnExponential.TabIndex = 5
        Me.btnExponential.Text = "^"
        Me.btnExponential.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(176, 130)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(57, 41)
        Me.btnDivision.TabIndex = 6
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnModulo
        '
        Me.btnModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModulo.Location = New System.Drawing.Point(247, 130)
        Me.btnModulo.Name = "btnModulo"
        Me.btnModulo.Size = New System.Drawing.Size(57, 41)
        Me.btnModulo.TabIndex = 7
        Me.btnModulo.Text = "Mod"
        Me.btnModulo.UseVisualStyleBackColor = True
        '
        'btnNegative
        '
        Me.btnNegative.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNegative.Location = New System.Drawing.Point(104, 177)
        Me.btnNegative.Name = "btnNegative"
        Me.btnNegative.Size = New System.Drawing.Size(57, 41)
        Me.btnNegative.TabIndex = 8
        Me.btnNegative.Text = "±"
        Me.btnNegative.UseVisualStyleBackColor = True
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquareRoot.Location = New System.Drawing.Point(176, 177)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(57, 41)
        Me.btnSquareRoot.TabIndex = 9
        Me.btnSquareRoot.Text = "√"
        Me.btnSquareRoot.UseVisualStyleBackColor = True
        '
        'btnLogarithm
        '
        Me.btnLogarithm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogarithm.Location = New System.Drawing.Point(247, 179)
        Me.btnLogarithm.Name = "btnLogarithm"
        Me.btnLogarithm.Size = New System.Drawing.Size(57, 37)
        Me.btnLogarithm.TabIndex = 10
        Me.btnLogarithm.Text = "Log"
        Me.btnLogarithm.UseVisualStyleBackColor = True
        '
        'btnCE
        '
        Me.btnCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.Location = New System.Drawing.Point(104, 224)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(57, 41)
        Me.btnCE.TabIndex = 11
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(176, 224)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(57, 41)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(247, 224)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(57, 41)
        Me.btnResult.TabIndex = 13
        Me.btnResult.Text = "="
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnMC
        '
        Me.btnMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMC.Location = New System.Drawing.Point(104, 283)
        Me.btnMC.Name = "btnMC"
        Me.btnMC.Size = New System.Drawing.Size(57, 41)
        Me.btnMC.TabIndex = 14
        Me.btnMC.Text = "MC"
        Me.btnMC.UseVisualStyleBackColor = True
        '
        'btnMR
        '
        Me.btnMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMR.Location = New System.Drawing.Point(176, 283)
        Me.btnMR.Name = "btnMR"
        Me.btnMR.Size = New System.Drawing.Size(57, 41)
        Me.btnMR.TabIndex = 15
        Me.btnMR.Text = "MR"
        Me.btnMR.UseVisualStyleBackColor = True
        '
        'btnMS
        '
        Me.btnMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMS.Location = New System.Drawing.Point(247, 283)
        Me.btnMS.Name = "btnMS"
        Me.btnMS.Size = New System.Drawing.Size(57, 41)
        Me.btnMS.TabIndex = 16
        Me.btnMS.Text = "MS"
        Me.btnMS.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(101, 501)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(202, 37)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResultLabel
        '
        Me.lblResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultLabel.Location = New System.Drawing.Point(26, 451)
        Me.lblResultLabel.Name = "lblResultLabel"
        Me.lblResultLabel.Size = New System.Drawing.Size(73, 23)
        Me.lblResultLabel.TabIndex = 18
        Me.lblResultLabel.Text = "Result:"
        Me.lblResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEquationLabel
        '
        Me.lblEquationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquationLabel.Location = New System.Drawing.Point(22, 398)
        Me.lblEquationLabel.Name = "lblEquationLabel"
        Me.lblEquationLabel.Size = New System.Drawing.Size(77, 23)
        Me.lblEquationLabel.TabIndex = 19
        Me.lblEquationLabel.Text = "Equation:"
        Me.lblEquationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMemoryLabel
        '
        Me.lblMemoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoryLabel.Location = New System.Drawing.Point(26, 342)
        Me.lblMemoryLabel.Name = "lblMemoryLabel"
        Me.lblMemoryLabel.Size = New System.Drawing.Size(73, 21)
        Me.lblMemoryLabel.TabIndex = 20
        Me.lblMemoryLabel.Text = "Memory:"
        Me.lblMemoryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(101, 441)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(202, 40)
        Me.lblResult.TabIndex = 21
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEquation
        '
        Me.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEquation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquation.Location = New System.Drawing.Point(101, 386)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(202, 40)
        Me.lblEquation.TabIndex = 22
        Me.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMemory
        '
        Me.lblMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemory.Location = New System.Drawing.Point(101, 332)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(202, 40)
        Me.lblMemory.TabIndex = 23
        Me.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCalculator
        '
        Me.AcceptButton = Me.btnResult
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(334, 554)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.lblEquation)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblMemoryLabel)
        Me.Controls.Add(Me.lblEquationLabel)
        Me.Controls.Add(Me.lblResultLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMS)
        Me.Controls.Add(Me.btnMR)
        Me.Controls.Add(Me.btnMC)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btnLogarithm)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.btnNegative)
        Me.Controls.Add(Me.btnModulo)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnExponential)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnRest)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnRest As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnExponential As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnModulo As Button
    Friend WithEvents btnNegative As Button
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents btnLogarithm As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnResult As Button
    Friend WithEvents btnMC As Button
    Friend WithEvents btnMR As Button
    Friend WithEvents btnMS As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResultLabel As Label
    Friend WithEvents lblEquationLabel As Label
    Friend WithEvents lblMemoryLabel As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblEquation As Label
    Friend WithEvents lblMemory As Label
End Class
