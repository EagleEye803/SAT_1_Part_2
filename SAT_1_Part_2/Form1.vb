Public Class Form1
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Check if user has inputted data
        If Clicked = True Then
            ''Save Input Data
            Dim Total As Double = 0
            Dim Divisor As Integer = 0
            For Each Number In txtInput.Text.Split(",")
                'Type Check Number
                Try
                    'Add Numbers Together
                    Total += Number
                    Divisor += 1
                Catch ex As Exception
                    MsgBox("Please remove all non-numerical values (except commas) from the input box and try again!", vbCritical, "ERROR")
                End Try
            Next
            'Average Input Data
            Dim Average As Double = Total / Divisor
            'Retrieve Relative Path
            Dim ProjectPath = Split(My.Application.Info.DirectoryPath, "\")
            Array.Clear(ProjectPath, UBound(ProjectPath) - 2, 3)
            Dim ProjectFolderPath(UBound(ProjectPath) - 2)
            Array.Copy(ProjectPath, ProjectFolderPath, UBound(ProjectPath) - 2)
            'Testing Line: MsgBox(Join(ProjectFolderPath, "\"), vbOK, "Testing Output!")
            MsgBox($"Your average is: {Average}")
        Else
            MsgBox("Please enter valid data before it can be processed!" & vbNewLine & "Just click the text box on the left and enter your numbers, separated by commas.", vbCritical, "ERROR")
        End If
    End Sub

    Private Sub btnScaling_Click(sender As Object, e As EventArgs) Handles btnScaling.Click
        Me.Hide()
        Scaling.Show()
    End Sub

    Private Sub btnProcessing_Click(sender As Object, e As EventArgs) Handles btnProcessing.Click
        Me.Hide()
        Processing.Show()
    End Sub
End Class
