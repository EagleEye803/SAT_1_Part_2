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
        Me.SuspendLayout()
        '
        'lblTitle
        '
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
        Me.txtInput.Location = New System.Drawing.Point(578, 245)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(368, 263)
        Me.txtInput.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1549, 675)
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
End Class
