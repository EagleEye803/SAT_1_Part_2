<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scaling
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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnScale = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.chkDirectFactor = New System.Windows.Forms.CheckBox()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.tipScaling = New System.Windows.Forms.ToolTip(Me.components)
        Me.nudMin = New System.Windows.Forms.NumericUpDown()
        Me.nudMax = New System.Windows.Forms.NumericUpDown()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblArrow = New System.Windows.Forms.Label()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblInput.Location = New System.Drawing.Point(481, 199)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(180, 20)
        Me.lblInput.TabIndex = 8
        Me.lblInput.Text = "Input Number Set"
        '
        'txtInput
        '
        Me.txtInput.AllowDrop = True
        Me.txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtInput.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(391, 237)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(373, 263)
        Me.txtInput.TabIndex = 7
        Me.tipScaling.SetToolTip(Me.txtInput, "Will Only Accept Numeric Values Separated by Commas, e.g. ""1, 2.34, 567""")
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(603, 83)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(404, 42)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "SCALING PROGRAM"
        '
        'btnScale
        '
        Me.btnScale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnScale.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnScale.FlatAppearance.BorderSize = 100
        Me.btnScale.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScale.ForeColor = System.Drawing.Color.Black
        Me.btnScale.Location = New System.Drawing.Point(825, 375)
        Me.btnScale.Name = "btnScale"
        Me.btnScale.Size = New System.Drawing.Size(211, 125)
        Me.btnScale.TabIndex = 10
        Me.btnScale.Text = "SCALE"
        Me.tipScaling.SetToolTip(Me.btnScale, "Scale Your Data!")
        Me.btnScale.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.DimGray
        Me.btnHome.Location = New System.Drawing.Point(722, 559)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(153, 34)
        Me.btnHome.TabIndex = 11
        Me.btnHome.Tag = ""
        Me.btnHome.Text = "HOME"
        Me.tipScaling.SetToolTip(Me.btnHome, "Navigate Home")
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'chkDirectFactor
        '
        Me.chkDirectFactor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkDirectFactor.AutoSize = True
        Me.chkDirectFactor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDirectFactor.Location = New System.Drawing.Point(836, 266)
        Me.chkDirectFactor.Name = "chkDirectFactor"
        Me.chkDirectFactor.Size = New System.Drawing.Size(141, 22)
        Me.chkDirectFactor.TabIndex = 12
        Me.chkDirectFactor.Text = "Manual Scale"
        Me.tipScaling.SetToolTip(Me.chkDirectFactor, "Manually Input Maximum and Minimums for Data")
        Me.chkDirectFactor.UseVisualStyleBackColor = True
        '
        'chkAuto
        '
        Me.chkAuto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Checked = True
        Me.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAuto.Enabled = False
        Me.chkAuto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuto.Location = New System.Drawing.Point(836, 214)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(166, 22)
        Me.chkAuto.TabIndex = 13
        Me.chkAuto.Text = "Automatic Scale"
        Me.tipScaling.SetToolTip(Me.chkAuto, "Automatically Locates Maximum and Minimum from Data")
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'nudMin
        '
        Me.nudMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nudMin.BackColor = System.Drawing.Color.White
        Me.nudMin.Enabled = False
        Me.nudMin.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.nudMin.Location = New System.Drawing.Point(836, 317)
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(57, 20)
        Me.nudMin.TabIndex = 14
        '
        'nudMax
        '
        Me.nudMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nudMax.BackColor = System.Drawing.Color.White
        Me.nudMax.Enabled = False
        Me.nudMax.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.nudMax.Location = New System.Drawing.Point(967, 317)
        Me.nudMax.Name = "nudMax"
        Me.nudMax.Size = New System.Drawing.Size(57, 20)
        Me.nudMax.TabIndex = 15
        '
        'lblMin
        '
        Me.lblMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblMin.Location = New System.Drawing.Point(836, 301)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(48, 13)
        Me.lblMin.TabIndex = 16
        Me.lblMin.Text = "Minimum"
        '
        'lblMax
        '
        Me.lblMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMax.AutoSize = True
        Me.lblMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMax.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblMax.Location = New System.Drawing.Point(964, 301)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(51, 13)
        Me.lblMax.TabIndex = 17
        Me.lblMax.Text = "Maximum"
        '
        'lblArrow
        '
        Me.lblArrow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblArrow.AutoSize = True
        Me.lblArrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblArrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrow.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblArrow.Location = New System.Drawing.Point(916, 314)
        Me.lblArrow.Name = "lblArrow"
        Me.lblArrow.Size = New System.Drawing.Size(25, 20)
        Me.lblArrow.TabIndex = 18
        Me.lblArrow.Text = "→"
        '
        'Scaling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1549, 675)
        Me.Controls.Add(Me.lblArrow)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.nudMax)
        Me.Controls.Add(Me.nudMin)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.chkDirectFactor)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnScale)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txtInput)
        Me.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Name = "Scaling"
        Me.RightToLeftLayout = True
        Me.Text = "Scaling"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnScale As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents chkDirectFactor As CheckBox
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents tipScaling As ToolTip
    Friend WithEvents nudMin As NumericUpDown
    Friend WithEvents nudMax As NumericUpDown
    Friend WithEvents lblMin As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents lblArrow As Label
End Class
