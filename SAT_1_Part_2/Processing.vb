Public Class Processing
    'Define Global Variables:
    Dim Clicked As Boolean = False
    Dim ProjectFolderPath()
    Dim ProjectPath As String
    Dim FileToRead As String = ""
    Dim bigArray(1000, 1000)

    'This Function Retrieves the Relative Path of the Program
    Function RelativePath()
        'Retrieve Relative Path
        Dim RealPath = Split(My.Application.Info.DirectoryPath, "\")
        ReDim ProjectFolderPath(UBound(RealPath) - 2)
        Array.Copy(RealPath, ProjectFolderPath, UBound(RealPath) - 2)
        ProjectPath = Join(ProjectFolderPath, "\")
    End Function

    'This Function Reads the User's Selected File and Store it as Useful Data.
    Function ReadFile()
        Try
            'STORES THE CSV IN A PROGRAM-READABLE FORMAT:
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(FileToRead)

                'Set Up Indicator Variables
                Dim cellTicker As Integer = 0
                Dim rowTicker As Integer = 0

                'Define Row Reader
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim row As String()

                'Loop Through Cells and Store Data
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
        Catch ex As Exception
            'Display Error Message to User
            MsgBox($"There was an error!{vbNewLine}{ex.Message}.{vbNewLine}Please try again.", vbCritical)
        End Try
    End Function

    'This Function Returns and Stores the Average Value for Each Row of Data in the Data File.
    Function AnswerAverage(maxX, maxY)
        'Set Up Indicator Variables
        Dim columnTotal As Integer = 0
        Dim columnAverages(0)
        columnAverages(0) = "COLUMN AVERAGES"
        Try
            'Loop Through Array
            For row = 1 To maxY
                For cell = 1 To maxX
                    'Add Cell Values to Total
                    columnTotal += bigArray(cell, row)
                Next
                'Resize Specialized Array and Save Data
                ReDim Preserve columnAverages(UBound(columnAverages) + 1)
                columnAverages(UBound(columnAverages)) = columnTotal / (maxY - 1)
                columnTotal = 0
            Next

            'Write to CSV
            RelativePath()
            My.Computer.FileSystem.WriteAllText($"{ProjectPath}output.CSV", $"{DateTime.Now},{Join(columnAverages, ",")},{vbNewLine}", True)
            MsgBox("Averages per Column Calculated and saved!")

        Catch ex As Exception
            'Display Error Message
            MsgBox($"There was an error!{vbNewLine}{ex.Message}{vbNewLine}Please try again.", vbCritical)
        End Try
    End Function

    'This Function Returns and Stores the Average Value for Each Row of Data in the Data File.
    Function ResponseAverage(maxX, maxY)
        'Set Up Indicator Variables
        Dim rowTotal As Integer = 0
        Dim rowAverages(0)
        rowAverages(0) = "ROW AVERAGES"
        Try
            'Loop Through Boundaries
            For row = 1 To maxY
                For cell = 1 To maxX
                    'Add Cell Values to Total
                    rowTotal += bigArray(cell, row)
                Next
                'Resize Specialized Array and Save Data
                ReDim Preserve rowAverages(UBound(rowAverages) + 1)
                rowAverages(UBound(rowAverages)) = (rowTotal / (maxX - 1))
                rowTotal = 0
            Next

            'Write to CSV
            My.Computer.FileSystem.WriteAllText($"{ProjectPath}output.CSV", $"{DateTime.Now},{Join(rowAverages, ",")},{vbNewLine}", True)
            MsgBox("Averages per Row Calculated and Saved!")
        Catch ex As Exception
            'Display Error Message to User
            MsgBox($"There was an error!{vbNewLine}{ex.Message}{vbNewLine}Please try again.", vbCritical)
        End Try

    End Function

    'This Function Averages Data for each Row, then Scales it and Stores the Scaled Numbers.
    Function AnswerScale(maxX, maxY)
        'Set Up Indicator Variables
        Dim columnTotal As Integer = 0
        Dim columnAverages(0)
        columnAverages(0) = "SCALED COLUMN AVERAGES"

        Try
            'Loop Through Boundaries
            For row = 1 To maxY
                For cell = 1 To maxX
                    columnTotal += bigArray(cell, row)
                Next
                'Resize Specialized Array and Save Data
                ReDim Preserve columnAverages(UBound(columnAverages) + 1)
                columnAverages(UBound(columnAverages)) = columnTotal / (maxY - 1)
                columnTotal = 0
            Next

            'Locate Highest Raw Score:
            Dim currentHighest As Double
            For i = 1 To UBound(columnAverages)
                If columnAverages(i) > currentHighest Then
                    currentHighest = columnAverages(i)
                    MsgBox($"New Highest: {currentHighest}")
                End If
            Next

            'Get Highest Possible Score
            Dim highestPossible As Double
            highestPossible = InputBox("Please enter the highest possible result to scale to (e.g. 10)", "USER INPUT")

            'Scale Averages and Combine To Form Entry
            For i = 1 To UBound(columnAverages)
                columnAverages(i) = (columnAverages(i) * (highestPossible / currentHighest))
            Next

            'Write to CSV
            My.Computer.FileSystem.WriteAllText($"{ProjectPath}output.csv", $"{DateTime.Now},{Join(columnAverages, ",")},{vbNewLine}", True)
            MsgBox("Scaled Averages per Column Calculated and saved!")

        Catch ex As Exception
            MsgBox($"There was an error!{vbNewLine}{ex.Message}{vbNewLine}Please try again.", vbCritical)
        End Try
    End Function

    'This Function Averages Data for each Column then Scales it and Stores the Scaled Numbers.
    Function ResponseScale(maxX, maxY)
        'Set Up Indicator Variables
        Dim rowTotal As Integer = 0
        Dim rowAverages(0)
        Dim entry = "SCALED ROW AVERAGES"

        Try
            'Loop Through Boundaries
            For row = 1 To maxY
                For cell = 1 To maxX
                    rowTotal += bigArray(cell, row)
                Next
                'Resize Specialized Array and Save Data
                ReDim Preserve rowAverages(UBound(rowAverages) + 1)
                rowAverages(UBound(rowAverages)) = rowTotal / (maxY - 1)
                rowTotal = 0
            Next

            'Get Highest Raw Score
            Dim currentHighest As Double
            For i = 1 To UBound(rowAverages)
                If rowAverages(i) > currentHighest Then
                    currentHighest = rowAverages(i)
                    MsgBox($"New Highest: {currentHighest}")
                End If
            Next

            'Get Highest Possible Score
            Dim highestPossible As Double
            highestPossible = InputBox("Please enter the highest possible result to scale to (e.g. 10)", "USER INPUT")

            'Calculate Scale
            For i = 1 To UBound(rowAverages)
                entry += (rowAverages(i) * (highestPossible / currentHighest)) & ","
            Next

            'Write to CSV
            My.Computer.FileSystem.WriteAllText($"{DateTime.Now},{ProjectPath}output.csv", entry & vbNewLine, True)
            MsgBox("Scaled Averages per Row Calculated and Saved!")
        Catch ex As Exception
            MsgBox($"There was an error!{vbNewLine}{ex.Message}{vbNewLine}Please try again.", vbCritical)
        End Try
    End Function

    'This Function Activates the Other Functions
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        RelativePath()
        'Existence Check
        If Not FileToRead = "" Then
            ReadFile()
            ''CALCULATE BOUNDARIES
            Dim maxX As Integer = 0
            Dim maxY As Integer = 0
            While Not IsNothing(bigArray(maxX, 0))
                maxX += 1
            End While
            While Not String.IsNullOrEmpty(bigArray(0, maxY))
                maxY += 1
            End While

            'Array Range Check
            If maxX < 1000 And maxY < 1000 Then
                'Data Existence Check
                If chklstSelection.CheckedItems Is Nothing Then
                    MsgBox("Please specify a function using the checkboxes on the left!")
                    Exit Sub
                End If
                'Check Selections
                If chklstSelection.CheckedItems.Contains("Average Answer for each Column") Then
                    AnswerAverage(maxX, maxY)
                End If
                If chklstSelection.CheckedItems.Contains("Scaled Averages for each Column") Then
                    AnswerScale(maxX, maxY)
                End If
                If chklstSelection.CheckedItems.Contains("Average Answer for each Row") Then
                    ResponseAverage(maxX, maxY)
                End If
                If chklstSelection.CheckedItems.Contains("Scaled Averages for each Row") Then
                    ResponseScale(maxX, maxY)
                End If
            Else
                MsgBox($"Your array is too large for the program to process.{vbNewLine}The largest array size accepted is 1000 x 1000. Please use different data.")
            End If
        Else
            MsgBox("Please enter a path to read from!")
        End If
    End Sub

    'This Function Removes the Reminder Text from the Input Box.
    Private Sub txtFileToRead_Clicked(sender As Object, e As EventArgs) Handles txtFileToRead.Click
        If Clicked = False Then
            txtFileToRead.Text = ""
            txtFileToRead.ForeColor = Color.Black
        End If
    End Sub

    'This Function Opens the File Browser
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Initiate File Browsing
        Dim FileBrowser As New OpenFileDialog
        FileBrowser.Title = "Open File..."
        FileBrowser.Multiselect = False
        FileBrowser.Filter = "All Files|*.*"
        FileBrowser.ShowDialog()
        'Save Selected File Path
        lblFilePicked.Text = FileBrowser.FileName
        FileToRead = FileBrowser.FileName
    End Sub

    'This Function Navigates to the Home Form
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class