<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkSpeci1 = New System.Windows.Forms.CheckBox()
        Me.chkSpeci2 = New System.Windows.Forms.CheckBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.btnScaling = New System.Windows.Forms.Button()
        Me.btnProcessing = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(520, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(465, 42)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "AVERAGING PROGRAM"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(792, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 93)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "AVERAGE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkSpeci1
        '
        Me.chkSpeci1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkSpeci1.AutoSize = True
        Me.chkSpeci1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpeci1.Location = New System.Drawing.Point(578, 133)
        Me.chkSpeci1.Name = "chkSpeci1"
        Me.chkSpeci1.Size = New System.Drawing.Size(153, 22)
        Me.chkSpeci1.TabIndex = 3
        Me.chkSpeci1.Text = "Specification 1"
        Me.chkSpeci1.UseVisualStyleBackColor = True
        '
        'chkSpeci2
        '
        Me.chkSpeci2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkSpeci2.AutoSize = True
        Me.chkSpeci2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpeci2.Location = New System.Drawing.Point(578, 173)
        Me.chkSpeci2.Name = "chkSpeci2"
        Me.chkSpeci2.Size = New System.Drawing.Size(153, 22)
        Me.chkSpeci2.TabIndex = 4
        Me.chkSpeci2.Text = "Specification 2"
        Me.chkSpeci2.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.AllowDrop = True
        Me.txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtInput.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(578, 273)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(373, 263)
        Me.txtInput.TabIndex = 5
        '
        'lblInput
        '
        Me.lblInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(671, 250)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(180, 20)
        Me.lblInput.TabIndex = 6
        Me.lblInput.Text = "Input Number Set"
        '
        'btnScaling
        '
        Me.btnScaling.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnScaling.ForeColor = System.Drawing.Color.DimGray
        Me.btnScaling.Location = New System.Drawing.Point(578, 586)
        Me.btnScaling.Name = "btnScaling"
        Me.btnScaling.Size = New System.Drawing.Size(153, 34)
        Me.btnScaling.TabIndex = 7
        Me.btnScaling.Tag = ""
        Me.btnScaling.Text = "SCALING"
        Me.btnScaling.UseVisualStyleBackColor = True
        '
        'btnProcessing
        '
        Me.btnProcessing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnProcessing.ForeColor = System.Drawing.Color.DimGray
        Me.btnProcessing.Location = New System.Drawing.Point(792, 586)
        Me.btnProcessing.Name = "btnProcessing"
        Me.btnProcessing.Size = New System.Drawing.Size(153, 34)
        Me.btnProcessing.TabIndex = 8
        Me.btnProcessing.Tag = ""
        Me.btnProcessing.Text = "PROCESSING"
        Me.btnProcessing.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1549, 675)
        Me.Controls.Add(Me.btnProcessing)
        Me.Controls.Add(Me.btnScaling)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.chkSpeci2)
        Me.Controls.Add(Me.chkSpeci1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkSpeci1 As CheckBox
    Friend WithEvents chkSpeci2 As CheckBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInput As Label
    Friend WithEvents btnScaling As Button
    Friend WithEvents btnProcessing As Button
End Class
