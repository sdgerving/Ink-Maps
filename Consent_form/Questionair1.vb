Public Class Questionair1
    Public saveinfo(12) As String
    Public mindate As Integer




    Private Sub Questionair1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = DateString
        statedropbox.SelectedIndex = 6
        monthcb.SelectedIndex = 0
        yearcb.SelectedIndex = 0
        daycb.SelectedIndex = 0
        Start_Page.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        checkerror()


    End Sub
    Private Sub colorwhite()
        FNameTxtBx.BackColor = Color.White
        lastnametxtbox.BackColor = Color.White


        Addresstxtbox.BackColor = Color.White
        citytextbox.BackColor = Color.White
        statedropbox.BackColor = Color.White
        zipcodetextbox.BackColor = Color.White

        Hometxtbox.BackColor = Color.White
        worktxtbox.BackColor = Color.White
        emailtextbox.BackColor = Color.White
        monthcb.BackColor = Color.White
        daycb.BackColor = Color.White
        yearcb.BackColor = Color.White
    End Sub
    Private Sub checkerror()
        colorwhite()
        If FNameTxtBx.Text <> "" And lastnametxtbox.Text <> "" And Addresstxtbox.Text <> "" And emailtextbox.Text <> "" _
        And lastnametxtbox.Text <> "" And citytextbox.Text <> "" And statedropbox.Text <> "" And zipcodetextbox.Text <> "" _
        And Hometxtbox.Text <> "" And (Math.Abs(Today.Year - Val(yearcb.SelectedItem)) >= 17) Then
            captureinfo()
        End If
        If (Math.Abs(Today.Year - Val(yearcb.SelectedItem)) <= 17) Then
            warningtxt.Text = "You must be 18 years of age to recieve a tatoo."
            warningtxt.BackColor = Color.Red
            yearcb.BackColor = Color.Yellow
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        End If


        If FNameTxtBx.Text = "" Then
            FNameTxtBx.BackColor = Color.Yellow
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            warningtxt.BackColor = Color.Red
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        End If
        If lastnametxtbox.Text = "" Then
            lastnametxtbox.BackColor = Color.Yellow
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        End If

        If Addresstxtbox.Text = "" Then
            Addresstxtbox.BackColor = Color.Yellow
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        End If
            If citytextbox.Text = "" Then
            citytextbox.BackColor = Color.Yellow
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)

        End If
            If statedropbox.Text = "" Then
            statedropbox.BackColor = Color.Yellow
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        End If
            If zipcodetextbox.Text = "" Then
            zipcodetextbox.BackColor = Color.Yellow
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        End If
            If Hometxtbox.Text = "" Then
            Hometxtbox.BackColor = Color.Yellow
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)

        End If
        'If worktxtbox.Text = "" Then
        'worktxtbox.BackColor = Color.Yellow
        'warningtxt.Text = " Please fill in all the shaded yellow areas."
        'warningtxt.Show()
        'My.Computer.Audio.PlaySystemSound(
        'System.Media.SystemSounds.Asterisk)
        'End If
        If emailtextbox.Text = "" Then
            emailtextbox.BackColor = Color.Red
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        End If





        Label12.Text = Today.Date()



    End Sub
    Public Sub captureinfo()

        saveinfo(0) = "artist"
        saveinfo(1) = FNameTxtBx.Text
        saveinfo(2) = lastnametxtbox.Text
        saveinfo(3) = monthcb.SelectedItem
        saveinfo(4) = daycb.SelectedItem
        saveinfo(5) = yearcb.SelectedItem


        saveinfo(6) = Addresstxtbox.Text
        saveinfo(7) = citytextbox.Text
        saveinfo(8) = statedropbox.SelectedItem
        saveinfo(9) = zipcodetextbox.Text

        saveinfo(10) = Hometxtbox.Text.ToString
        saveinfo(11) = worktxtbox.Text.ToString
        saveinfo(12) = emailtextbox.Text.ToString

        Questionair2.Show()

    End Sub

    Private Sub GoButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoButton.MouseEnter
        GoButton.BackColor = Color.Tan
    End Sub
    Private Sub GoButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoButton.MouseLeave
        GoButton.BackColor = Color.Black

    End Sub

    Private Sub Clearformbtn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Clearformbtn.MouseEnter
        Clearformbtn.BackColor = Color.Tan
        Clearformbtn.ForeColor = Color.White

    End Sub
    Private Sub Clearformbtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Clearformbtn.MouseLeave
        Clearformbtn.BackColor = Color.Black
        Clearformbtn.ForeColor = Color.Tan

    End Sub

    Private Sub BackButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackButton.MouseEnter
        BackButton.BackColor = Color.Tan

    End Sub
    Private Sub BackButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackButton.MouseLeave
        BackButton.BackColor = Color.Black

    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        quest1check.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        captureinfo()
    End Sub

    Private Sub Clearformbtn_Click(sender As Object, e As EventArgs) Handles Clearformbtn.Click
        FNameTxtBx.Clear()
        lastnametxtbox.Clear()


        Addresstxtbox.Clear()
        citytextbox.Clear()
        statedropbox.SelectedIndex = 6
        zipcodetextbox.Clear()

        Hometxtbox.Clear()
        worktxtbox.Clear()
        emailtextbox.Clear()
    End Sub

    Private Sub warningtxt_Click(sender As Object, e As EventArgs) Handles warningtxt.Click

    End Sub
End Class