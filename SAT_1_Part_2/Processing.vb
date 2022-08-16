Public Class Processing
    'Define Global Variables:
    Dim Clicked As Boolean = False
    Dim ProjectFolderPath As String
    Dim FileToRead As String = ""
    Dim bigArray(1000, 1000)

    Function RelativePath()
        'Retrieve Relative Path
        Dim ProjectPath = Split(My.Application.Info.DirectoryPath, "\")
        ReDim Preserve ProjectPath(UBound(ProjectPath) - 2)
        ProjectFolderPath = Join(ProjectPath, "\")
    End Function

    'This function reads the user's selected file and store it as useful data.
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
            ''Return to Home Form
            'Me.Hide()
            'Form1.Show()
        End Try
    End Function

    'This function returns and stores the average value for each row of data in the data file.
    Function AnswerAverage(maxX, maxY)

        'Set Up Indicator Variables
        Dim columnTotal As Integer = 0
        Dim columnAverages(0)
        Dim entry As String = "QUESTION AVERAGES,"
        Try
            'Loop Through Array
            For x = 1 To maxX
                For y = 1 To maxY
                    'Add Cell Values to Total
                    columnTotal += bigArray(y, x)
                Next
                'Resize Specialized Array and Save Data
                ReDim Preserve columnAverages(UBound(columnAverages) + 1)
                columnAverages(UBound(columnAverages)) = columnTotal / (maxY - 1)
                columnTotal = 0
            Next

            entry += Join(columnAverages, ",")

            'Write to CSV
            RelativePath()
            My.Computer.FileSystem.WriteAllText($"{ProjectFolderPath}Processing.CSV", vbNewLine & entry, True)
            MsgBox("Averages per Question Calculated and saved!")
        Catch ex As Exception
            'Display Error Message
            MsgBox($"There was an error!{vbNewLine}{ex.Message}{vbNewLine}Please try again.", vbCritical)
        End Try
    End Function

    'This function returns and stores the average value for each row of data in the data file.
    Function ResponseAverage(maxX, maxY)

        'Set Up Indicator Variables
        Dim rowTotal As Integer = 0
        Dim rowAverages(0)
        Dim entry = ""
        Try
            'Loop Through Boundaries
            For y = 1 To maxY
                For x = 1 To maxX
                    'Add Cell Values to Total
                    rowTotal += bigArray(y, x)
                Next
                'Resize Specialized Array and Save Data
                ReDim Preserve rowAverages(UBound(rowAverages) + 1)
                rowAverages(UBound(rowAverages)) = (rowTotal / (maxX - 1))
                rowTotal = 0
            Next

            ''Set Up Entry
            'rowAverages(0) = "RESULT AVERAGES"
            'entry = Join(rowAverages, ",")

            ''Write to CSV
            'My.Computer.FileSystem.WriteAllText($"{ProjectFolderPath}Processing.CSV", vbNewLine & entry, True)

            'Write to CSV
            My.Computer.FileSystem.WriteAllText($"{ProjectFolderPath}Processing.CSV", $"{vbNewLine}RESULT AVERAGES,{Join(rowAverages, ",")}", True)
            MsgBox("Averages per Result Calculated and Saved!")
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
        Dim entry = "SCALED QUESTION AVERAGES,"

        Try
            'Loop Through Boundaries
            For x = 1 To maxX
                For y = 1 To maxY
                    columnTotal += bigArray(y, x)
                Next
                'Resize Specialized Array and Save Data
                ReDim Preserve columnAverages(UBound(columnAverages) + 1)
                columnAverages(UBound(columnAverages)) = columnTotal / (maxY - 1)
                columnTotal = 0
            Next

            ''Locate Highest Raw Score:
            Dim currentHighest As Double = columnAverages(0)
            For i = 1 To UBound(columnAverages)
                If columnAverages(i) > currentHighest Then
                    currentHighest = columnAverages(i)
                    MsgBox($"New Highest: {currentHighest}")
                End If
            Next

            ''Get Highest Possible Score
            Dim highestPossible As Double
            highestPossible = InputBox("Please enter the highest possible result to scale to (e.g. 10)")

            ''Scale Averages and Combine To Form Entry
            For i = 1 To UBound(columnAverages)
                entry += (columnAverages(i) * (highestPossible / currentHighest)) & ","
            Next

            ''Write to CSV
            My.Computer.FileSystem.WriteAllText($"{ProjectFolderPath}Processing.CSV", vbNewLine & entry, True)
            MsgBox("Scaled Averages per Question Calculated and saved!")

        Catch ex As Exception
            MsgBox($"There was an error!{vbNewLine}{ex.Message}{vbNewLine}Please try again.", vbCritical)
        End Try

    End Function

    'This Function Averages Data for each Column then Scales it and Stores the Scaled Numbers.
    Function ResponseScale(maxX, maxY)

        'Set Up Indicator Variables
        Dim rowTotal As Integer = 0
        Dim rowAverages(0)
        Dim entry = "SCALED RESULT AVERAGES"

        ''Calculate Averages
        Try
            ''Get Highest Raw Score
            Dim currentHighest As Double = rowAverages(0)
            For i = 1 To UBound(rowAverages)
                If rowAverages(i) > currentHighest Then
                    currentHighest = rowAverages(i)
                    MsgBox($"New Highest: {currentHighest}")
                End If
            Next

            ''Get Highest Possible Score
            Dim highestPossible As Integer
            highestPossible = InputBox("Please enter the highest possible result to scale to (e.g. 10)")

            'Calculate Scale
            For i = 1 To UBound(rowAverages)
                entry += (rowAverages(i) * (highestPossible / currentHighest)) & ","
            Next

            'Write to CSV
            My.Computer.FileSystem.WriteAllText($"{ProjectFolderPath}Processing.CSV", vbNewLine & entry, True)
            MsgBox("Scaled Averages per Result Calculated and Saved!")
        Catch ex As Exception
            MsgBox($"There was an error!{vbNewLine}{ex.Message}{vbNewLine}Please try again.", vbCritical)
        End Try
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ''Data Validity Check
        RelativePath()
        If Not FileToRead = "" Then
            ReadFile()
            ''CALCULATE BOUNDARIES
            Dim maxX As Integer = 0
            Dim maxY As Integer = 0
            While Not IsNothing(bigArray(maxY, 0))
                maxY += 1
            End While
            While Not String.IsNullOrEmpty(bigArray(0, maxX))
                maxX += 1
            End While
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
            MsgBox("Please enter a path to read from!")
        End If
    End Sub

    Private Sub txtFileToRead_Clicked(sender As Object, e As EventArgs) Handles txtFileToRead.Click
        If Clicked = False Then
            txtFileToRead.Text = ""
            txtFileToRead.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim FileBrowser As New OpenFileDialog
        FileBrowser.Title = "Open File..."
        FileBrowser.Multiselect = False
        FileBrowser.Filter = "All Files|*.*"
        FileBrowser.ShowDialog()
        lblFilePicked.Text = FileBrowser.FileName
        FileToRead = FileBrowser.FileName
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class