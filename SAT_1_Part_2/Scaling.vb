Public Class Scaling
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
            ''Save Input Data
            Dim 
        Else

        End If
    End Sub
End Class