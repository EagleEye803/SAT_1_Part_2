﻿Public Class Scaling
    Dim Clicked As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.ForeColor = Color.LightGray
        txtInput.Text = "e.g. 12, 3.4, 567..."
    End Sub

    Private Sub txtInput_Click(sender As Object, e As EventArgs) Handles txtInput.Click
        If Clicked = False Then
            txtInput.ForeColor = Color.Black
            txtInput.Text = ""
            Clicked = True
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnScale_Click(sender As Object, e As EventArgs) Handles btnScale.Click
        If Clicked = True Then
            Try
                ''Save Input Data

            Catch ex As Exception

            End Try
        Else
            MsgBox("Please enter valid data before it can be processed!" & vbNewLine & "Just click the text box on the left and enter your numbers, separated by commas.", vbCritical, "ERROR")
        End If
    End Sub

    Private Sub chkDirectFactor_Clicked(sender As Object, e As EventArgs) Handles chkDirectFactor.Click
        ''Uncheck and Enable Other Checkbox, Check and Disable Self
        chkAuto.Checked = False
        chkAuto.Enabled = True
        chkDirectFactor.Checked = True
        chkDirectFactor.Enabled = False
        nudMin.Enabled = True
        nudMax.Enabled = True
        ''Change Visuals
        nudMin.ForeColor = Color.Black
        nudMax.ForeColor = Color.Black
        lblArrow.ForeColor = Color.LightSkyBlue
        lblMin.ForeColor = Color.LightSkyBlue
        lblMax.ForeColor = Color.LightSkyBlue
    End Sub

    Private Sub chkAuto_Clicked(sender As Object, e As EventArgs) Handles chkAuto.Click
        ''Uncheck and Enable Other Checkbox, Disable Self
        chkDirectFactor.Checked = False
        chkDirectFactor.Enabled = True
        chkAuto.Checked = True
        chkAuto.Enabled = False
        nudMin.Enabled = False
        nudMax.Enabled = False
        nudMin.Value = 0
        nudMax.Value = 0
        ''Change Visuals
        nudMin.ForeColor = SystemColors.InactiveCaption
        nudMax.ForeColor = SystemColors.InactiveCaption
        lblArrow.ForeColor = SystemColors.InactiveCaption
        lblMin.ForeColor = SystemColors.InactiveCaption
        lblMax.ForeColor = SystemColors.InactiveCaption
    End Sub

End Class