Public Class Averaging
    Dim Clicked As Boolean = False
    Dim ProjectFolderPath()
    Dim ProjectPath As String
    Dim bigArray(1000, 1000)

    Function RelativePath()
        'Retrieve Relative Path
        Dim RealPath = Split(My.Application.Info.DirectoryPath, "\")
        ReDim ProjectFolderPath(UBound(RealPath) - 2)
        Array.Copy(RealPath, ProjectFolderPath, UBound(RealPath) - 2)
        ProjectPath = Join(ProjectFolderPath, "\")
    End Function

    'This function reads the user's selected file and store it as useful data.
    Function ReadFile()
        'Retrieve File Data
        RelativePath()
        Try
            'STORES THE CSV IN A PROGRAM-READABLE FORMAT:
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(ProjectPath & "output.csv")

                'Set Up Indicator Variables
                Dim cellTicker As Integer = 0
                Dim rowTicker As Integer = 0

                'Define Row Reader
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim row As String()

                ''Loop Through Cells and Store Data
                While Not MyReader.EndOfData
                    row = MyReader.ReadFields()
                    'Loop Through Cells and Add Values to Table
                    For Each cell In row
                        bigArray(rowTicker, cellTicker) = cell
                        cellTicker += 1
                    Next
                    cellTicker = 0
                    rowTicker += 1
                End While
            End Using
            'Trigger on Error
        Catch ex As Exception
            'Display Error Message to User
            MsgBox($"There was an error!{vbNewLine}{ex.Message}.{vbNewLine}Please try again.", vbCritical)
        End Try
    End Function

    'Adds Reminder Text to Input Box
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add Prompt Text to Text Box
        txtInput.ForeColor = Color.LightGray
        txtInput.Text = "e.g. 12, 3.4, 567..."
    End Sub

    'Removes Reminder Text from Input Box
    Private Sub txtInput_Click(sender As Object, e As EventArgs) Handles txtInput.Click
        'Check if text box has been clicked
        If Clicked = False Then
            'Remove Prompt Text and change color
            txtInput.ForeColor = Color.Black
            txtInput.Text = ""
            Clicked = True
        End If
    End Sub

    'The Primary Function: Averages Inputted Numbers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Check if user has inputted data
        If Clicked = True Then
            'Save Input Data
            Dim Total As Double = 0
            Dim Divisor As Integer = 0
            'Type Check Numbers:
            Try
                For Each Number In txtInput.Text.Split(",")
                    'Add Numbers Together
                    Total += Number
                    Divisor += 1
                Next
                'Average Input Data
                Dim Average As Double = Total / Divisor

                RelativePath()
                'OUTPUT:   
                MsgBox($"Your average is: {Average}")
                Dim CSVsave = MsgBox($"Save to file {ProjectPath}output.csv?", vbYesNo, "Save to CSV?")
                If CSVsave = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.WriteAllText($"{ProjectPath}output.csv", $"{DateTime.Now},AVERAGE,{Average},{vbNewLine}", True)
                Else
                    MsgBox("Alright then.")
                End If
            Catch ex As Exception
                MsgBox($"Please remove all non-numerical values (except commas) from the input box and try again!", vbCritical, "ERROR")
            End Try
        Else
            MsgBox("Please enter valid data before it can be processed!" & vbNewLine & "Just click the text box on the left and enter your numbers, separated by commas.", vbCritical, "ERROR")
        End If
    End Sub

    'This Function Opens the Program Folder
    Private Sub btnFileOpen_Click(sender As Object, e As EventArgs) Handles btnFileOpen.Click
        'Clarify Program Paths
        RelativePath()
        'Open Output File
        Process.Start($"{ProjectPath}")
    End Sub

    'This Function Searches the Output File for a Key Term.
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Clarify Program Paths and Initiate Array
        RelativePath()
        ReadFile()
        'Call User to Enter Search Term
        Dim SearchTerm = InputBox("Please enter a term to search for:", "ENTER SEARCH TERM")
        Dim Count As Integer = 0
        Dim ResultArray(1)
        For Each Element In bigArray
            'Existence Check
            If Not Element = "" Then
                If Element.Contains(SearchTerm) Then
                    Count += 1
                    ResultArray(UBound(ResultArray)) = Element
                    ReDim Preserve ResultArray(UBound(ResultArray) + 1)
                End If
            End If
        Next
        'Display Searched Results to User
        Select Case Count
            Case = 0
                MsgBox("There were no results found!")
            Case = 1
                MsgBox($"There was 1 result found!")
                MsgBox($"{ResultArray(1)}")
            Case > 1
                MsgBox($"There were {Count} results found!")
                MsgBox($"{Join(ResultArray, vbNewLine)}")
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clarify Program Paths
        RelativePath()
        'Double-Check Action
        Dim CSVclear = MsgBox($"Are you sure you want to DELETE ALL CONTENTS of the file:{vbNewLine & ProjectPath}output.csv?", vbYesNo, "ARE YOU SURE?")
        If CSVclear = MsgBoxResult.Yes Then
            Try
                'Clear Output File
                My.Computer.FileSystem.WriteAllText(ProjectPath & "output.csv", "", False)
                MsgBox("Output CSV Cleared!")
            Catch ex As Exception
                MsgBox($"There was an error!{vbNewLine}{ex.Message}")
            End Try
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
