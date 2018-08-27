Public Class artistselect
    Dim strDir As String
    Dim j As Integer = 1
    Dim pic(100) As PictureBox
    Dim wid As Int32
    Dim hid As Int32
    Dim i As Integer
    Dim selectedartist As Integer
    Private logo As Image = My.Resources.FossilLogoBlackback1
    Public saveinfo2(23) As String
    Public Sub loadimages()
        Dim i As Integer
        Dim img As String

        Dim extensions As String = ".jpg.bmp.png.gif.jpeg.tiff"
        For Each img In IO.Directory.GetFiles(strDir)
            If extensions.Contains(IO.Path.GetExtension(img).ToLower) Then
                pic(j) = New PictureBox
                pic(j).Image = Image.FromFile(img)
                pic(j).SizeMode = PictureBoxSizeMode.Zoom
                pic(j).SetBounds(wid + 100, hid + 435, 150, 150)
                wid += 200

                If i Mod 4 = 3 Then
                    hid = 180
                    wid = 10
                End If
            End If
            Me.Controls.Add(pic(j))
            i += 1
            j += 1
        Next
    End Sub
    Private Sub removeimages()
        Do While j >= 0
            Me.Controls.Remove(pic(j))
            j -= 1
        Loop
        j = 1
        wid = 20
        hid = 10
    End Sub

    Private Sub plpicbox_Click(sender As Object, e As EventArgs) Handles plpicbox.Click
        strDir = "c:\appointment\paullunetta\images"
        removeimages()
        loadimages()
        saveinfo2(0) = 1

    End Sub
    Private Sub pllabel_Click(sender As Object, e As EventArgs) Handles pllabel.Click
        strDir = "c:\appointment\paullunetta\images"
        removeimages()
        loadimages()
        saveinfo2(0) = 1
    End Sub
    Private Sub jwpicbox_Click(sender As Object, e As EventArgs) Handles jwpicbox.Click
        strDir = "c:\appointment\jazminwebb\images"
        removeimages()
        loadimages()
        saveinfo2(0) = 2
    End Sub
    Private Sub jwlabel_Click(sender As Object, e As EventArgs) Handles jwlabel.Click
        strDir = "c:\appointment\jazminwebb\images"
        removeimages()
        loadimages()
        saveinfo2(0) = 2
    End Sub

    Private Sub crpicbox_Click(sender As Object, e As EventArgs) Handles crpicbox.Click
        strDir = "c:\appointment\coltrichardson\images"
        removeimages()
        loadimages()
        saveinfo2(0) = 3
    End Sub

    Private Sub crlabel_Click(sender As Object, e As EventArgs) Handles crlabel.Click
        strDir = "c:\appointment\coltrichardson\images"
        removeimages()
        loadimages()
        saveinfo2(0) = 3
    End Sub
    Public Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawImage(logo, 225, 10, 550, 200)
        e.Graphics.DrawRectangle(Pens.Silver, 225, 10, 550, 185)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        painmap.Show()
        Me.Hide()
    End Sub

    Private Sub artistselect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saveinfo2(0) = painmap.saveinfo2(0)
        saveinfo2(1) = painmap.saveinfo2(1)
        saveinfo2(2) = painmap.saveinfo2(2)
        saveinfo2(3) = painmap.saveinfo2(3)
        saveinfo2(4) = painmap.saveinfo2(4)
        saveinfo2(5) = painmap.saveinfo2(5)
        saveinfo2(6) = painmap.saveinfo2(6)
        saveinfo2(7) = painmap.saveinfo2(7)
        saveinfo2(8) = painmap.saveinfo2(8)
        saveinfo2(9) = painmap.saveinfo2(9)
        saveinfo2(10) = painmap.saveinfo2(10)
        saveinfo2(11) = painmap.saveinfo2(11)
        saveinfo2(12) = painmap.saveinfo2(12)
        saveinfo2(13) = painmap.saveinfo2(13)
        saveinfo2(14) = painmap.saveinfo2(14)
        saveinfo2(15) = painmap.saveinfo2(15)
        saveinfo2(16) = painmap.saveinfo2(16)
        saveinfo2(17) = painmap.saveinfo2(17)
        saveinfo2(18) = painmap.saveinfo2(18)
        saveinfo2(19) = painmap.saveinfo2(19)
        saveinfo2(20) = painmap.saveinfo2(20)
        saveinfo2(21) = painmap.saveinfo2(21)
        saveinfo2(22) = painmap.saveinfo2(22)
        saveinfo2(23) = painmap.saveinfo2(23)
        painmap.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If saveinfo2(0) = "0" Then
            warningtxt.BackColor = Color.Red
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        Else
            Calendar.Show()

        End If

    End Sub
    Private Sub GoButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoButton.MouseEnter
        GoButton.BackColor = Color.Tan
    End Sub
    Private Sub GoButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoButton.MouseLeave
        GoButton.BackColor = Color.Black

    End Sub
    Private Sub BackButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackButton.MouseEnter
        BackButton.BackColor = Color.Tan

    End Sub
    Private Sub BackButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackButton.MouseLeave
        BackButton.BackColor = Color.Black

    End Sub

End Class