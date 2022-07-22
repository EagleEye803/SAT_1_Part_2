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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnScale = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
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
        Me.btnScale.Location = New System.Drawing.Point(843, 291)
        Me.btnScale.Name = "btnScale"
        Me.btnScale.Size = New System.Drawing.Size(211, 125)
        Me.btnScale.TabIndex = 10
        Me.btnScale.Text = "SCALE"
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
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Scaling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1549, 675)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnScale As Button
    Friend WithEvents btnHome As Button
End Class
