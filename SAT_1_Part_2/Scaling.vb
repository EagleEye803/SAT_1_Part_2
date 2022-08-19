Public Class Scaling
    Dim Clicked As Boolean = False
    Dim ProjectFolderPath()
    Dim ProjectPath As String

    Function RelativePath()
        'Retrieve Relative Path
        Dim RealPath = Split(My.Application.Info.DirectoryPath, "\")
        ReDim ProjectFolderPath(UBound(RealPath) - 2)
        Array.Copy(RealPath, ProjectFolderPath, UBound(RealPath) - 2)
        ProjectPath = Join(ProjectFolderPath, "\")
    End Function

    'Loads Reminder Text Into Input Box
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.ForeColor = Color.LightGray
        txtInput.Text = "e.g. 12, 3.4, 567..."
        chkAuto.ForeColor = Color.LightSkyBlue
    End Sub

    'Removes Reminder Text from Input Box on Click
    Private Sub txtInput_Click(sender As Object, e As EventArgs) Handles txtInput.Click
        If Clicked = False Then
            txtInput.ForeColor = Color.Black
            txtInput.Text = ""
            Clicked = True
        End If
    End Sub

    'The Primary Function: Scales Inputted Numbers
    Private Sub btnScale_Click(sender As Object, e As EventArgs) Handles btnScale.Click
        If Clicked = True Then
            Try
                RelativePath()
                ''Determine Factor
                If chkAuto.Checked Then
                    Dim currentHighest As Double = 0
                    'Input Highest Possible
                    Dim highestPossible = InputBox("What is the highest possible number to scale to?")
                    'Automatically Locate Maximum and Minimum
                    For Each Number In txtInput.Text.Split(",")
                        If Number > currentHighest Then
                            currentHighest = Number
                        End If
                    Next
                    Dim Factor = highestPossible / currentHighest
                    'Calculate Scaled Number Set
                    Dim Entry(txtInput.Text.Split(",").Length)
                    Dim cellTicker = 0
                    For Each Number In txtInput.Text.Split(",")
                        Entry(cellTicker) = Number * Factor
                    Next
                    'Write Info to CSV
                    Dim ProcessPath = ProjectPath & "output.csv"
                    My.Computer.FileSystem.WriteAllText($"{DateTime.Now},{Join(Entry, ",")}", ProcessPath, True)
                ElseIf chkDirectFactor.Checked Then
                    Dim Factor = nudMax.Value / nudMin.Value
                    'Calculate Scaled Number Set
                    Dim Entry(txtInput.Text.Split(",").Length)
                    Dim cellTicker = 0
                    For Each Number In txtInput.Text.Split(",")
                        Entry(cellTicker) = Number * Factor
                    Next
                    'Write Info to CSV
                    My.Computer.FileSystem.WriteAllText($"{DateTime.Now},{Join(Entry, ",")}", $"{ProjectPath}output.csv", True)
                End If
            Catch ex As Exception
                MsgBox("Please enter valid data before it can be processed!" & vbNewLine & "Just click the text box on the left and enter your numbers, separated by commas.", vbCritical, "ERROR")
            End Try
        Else
            MsgBox("Please enter valid data before it can be processed!" & vbNewLine & "Just click the text box on the left and enter your numbers, separated by commas.", vbCritical, "ERROR")
        End If
    End Sub

    'Enable Manual Scaling
    Private Sub chkDirectFactor_Clicked(sender As Object, e As EventArgs) Handles chkDirectFactor.Click
        'Uncheck and Enable Other Checkbox, Check and Disable Self
        chkAuto.Checked = False
        chkAuto.Enabled = True
        chkDirectFactor.Checked = True
        chkDirectFactor.Enabled = False
        chkDirectFactor.ForeColor = Color.LightSkyBlue
        nudMin.Enabled = True
        nudMax.Enabled = True
        'Change Visuals
        nudMin.ForeColor = Color.Black
        nudMax.ForeColor = Color.Black
        lblArrow.ForeColor = Color.LightSkyBlue
        lblMin.ForeColor = Color.LightSkyBlue
        lblMax.ForeColor = Color.LightSkyBlue
    End Sub

    'Enable Auto Scaling
    Private Sub chkAuto_Clicked(sender As Object, e As EventArgs) Handles chkAuto.Click
        'Uncheck and Enable Other Checkbox, Disable Self
        chkDirectFactor.Checked = False
        chkDirectFactor.Enabled = True
        chkAuto.Checked = True
        chkAuto.Enabled = False
        chkAuto.ForeColor = Color.LightSkyBlue
        nudMin.Enabled = False
        nudMax.Enabled = False
        nudMin.Value = 0
        nudMax.Value = 0
        'Change Visuals
        nudMin.ForeColor = SystemColors.InactiveCaption
        nudMax.ForeColor = SystemColors.InactiveCaption
        lblArrow.ForeColor = SystemColors.InactiveCaption
        lblMin.ForeColor = SystemColors.InactiveCaption
        lblMax.ForeColor = SystemColors.InactiveCaption
    End Sub


    'Navigates to Home Form
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class