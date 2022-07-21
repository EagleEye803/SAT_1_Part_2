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
                MsgBox(ex.Message & vbNewLine & "Please remove all non-numerical values from the input box!")
            End Try
        Next
        'Average Input Data
        Dim Average As Double = Total / Divisor
        'Retrieve Relative Path
        Dim ProjectPath = Application.StartupPath.Split("/")
        ProjectPath(ProjectPath.Length - 2 = "")
        ProjectPath
        MsgBox("Your average is: " & Average & vbNewLine & Join(ProjectPath, "/"))
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
