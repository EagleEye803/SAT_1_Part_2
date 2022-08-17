Public Class Form1
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add Prompt Text to Text Box
        txtInput.ForeColor = Color.LightGray
        txtInput.Text = "e.g. 12, 3.4, 567..."
    End Sub

    Private Sub txtInput_Click(sender As Object, e As EventArgs) Handles txtInput.Click
        'Check if text box has been clicked
        If Clicked = False Then
            'Remove Prompt Text and change color
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
            'Type Check Number
            Try
                For Each Number In txtInput.Text.Split(",")
                    'Add Numbers Together
                    Total += Number
                    Divisor += 1
                Next
                'Average Input Data
                Dim Average As Double = Total / Divisor

                RelativePath()
                ''OUTPUT:
                MsgBox($"Your average is: {Average}")
                Dim ProcessPath = ProjectPath & "Output.csv"
                Dim CSVsave = MsgBox($"Save to file {ProcessPath}?", vbYesNo, "Save to CSV?")
                If CSVsave = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.WriteAllText(ProcessPath, $"Average, {Average},{vbNewLine}", True)
                Else
                    MsgBox("Alright then.")
                End If
            Catch ex As Exception
                MsgBox("Please remove all non-numerical values (except commas) from the input box and try again!", vbCritical, "ERROR")
            End Try
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

    Private Sub btnFileOpen_Click(sender As Object, e As EventArgs) Handles btnFileOpen.Click
        RelativePath()
        Dim FileBrowser As New OpenFileDialog
        FileBrowser.Title = "Open File..."
        FileBrowser.InitialDirectory = ProjectPath
        FileBrowser.Multiselect = False
        FileBrowser.Filter = "All Files|*.*"
        FileBrowser.ShowDialog()
        If Not FileBrowser.FileName = "" Then
            FileSystem.FileOpen(FileSystem.FreeFile(), FileBrowser.FileName, OpenMode.Input)
        Else
            Dim Noah As Integer = 69420
            MsgBox($"Noah is {Noah} years old.")
        End If
    End Sub
End Class
