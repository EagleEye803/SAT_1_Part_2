<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processing
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.chklstSelection = New System.Windows.Forms.CheckedListBox()
        Me.txtFileToRead = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHome.Location = New System.Drawing.Point(733, 595)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(855, 208)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 118)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Process!"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'chklstSelection
        '
        Me.chklstSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chklstSelection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chklstSelection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstSelection.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.chklstSelection.FormattingEnabled = True
        Me.chklstSelection.Items.AddRange(New Object() {"Average Answer for each Column", "Average Answer for each Row", "Scaled Averages for each Column", "Scaled Averages for each Row"})
        Me.chklstSelection.Location = New System.Drawing.Point(514, 262)
        Me.chklstSelection.Name = "chklstSelection"
        Me.chklstSelection.Size = New System.Drawing.Size(294, 72)
        Me.chklstSelection.TabIndex = 3
        '
        'txtFileToRead
        '
        Me.txtFileToRead.Location = New System.Drawing.Point(514, 208)
        Me.txtFileToRead.Name = "txtFileToRead"
        Me.txtFileToRead.Size = New System.Drawing.Size(215, 20)
        Me.txtFileToRead.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(571, 85)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(404, 42)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "SCALING PROGRAM"
        '
        'lblInput
        '
        Me.lblInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblInput.Location = New System.Drawing.Point(523, 185)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(207, 20)
        Me.lblInput.TabIndex = 11
        Me.lblInput.Text = "Input File to Process"
        '
        'Processing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1549, 675)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtFileToRead)
        Me.Controls.Add(Me.chklstSelection)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnHome)
        Me.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Name = "Processing"
        Me.Text = "Processing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents chklstSelection As CheckedListBox
    Friend WithEvents txtFileToRead As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInput As Label
End Class
