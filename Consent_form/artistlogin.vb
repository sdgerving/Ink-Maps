Public Class artistlogin
    Public passname As String
    Public strDir As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        strDir = "c:\appointment\" & UserNameTextBox.Text & PasswordTextBox.Text
        If My.Computer.FileSystem.DirectoryExists(strDir) Then
            passname = "c:\appointment\" & UserNameTextBox.Text & PasswordTextBox.Text
            manageappointment.Show()

        Else
            System.Windows.Forms.MessageBox.Show("Invalid pass")
        End If
    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start_Page.Close()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Start_Page.Show()
        Me.Close()
    End Sub

    Private Sub UserNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged

    End Sub
End Class