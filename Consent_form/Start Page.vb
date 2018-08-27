Public Class Start_Page
    Private Sub StartHereButton_Click(sender As Object, e As EventArgs) Handles StartHereButton.Click
        Questionair1.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        artistlogin.Show()
    End Sub

    Private Sub Start_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class