Public Class Processing
    Dim Clicked As Boolean = False
    Dim ProjectFolderPath()

    Function RelativePath()
        'Retrieve Relative Path
        Dim ProjectPath = Split(My.Application.Info.DirectoryPath, "\")
        Array.Clear(ProjectPath, UBound(ProjectPath) - 2, 3)
        ReDim ProjectFolderPath(UBound(ProjectPath) - 2)
        Array.Copy(ProjectPath, ProjectFolderPath, UBound(ProjectPath) - 2)
    End Function

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RelativePath()
        MsgBox(ProjectFolderPath)
    End Sub
End Class