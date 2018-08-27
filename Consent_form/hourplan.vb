Imports System.IO
Public Class hourplan
    Dim timer As Stopwatch
    Dim backbuffer As Image
    Dim graphics As Graphics
    Dim clientwidth As Integer
    Dim clientheight As Integer
    Dim isrunning As Boolean = True
    Dim mousex As Integer
    Dim mousey As Integer
    Dim s(100) As stype
    Dim calendarlocation As Integer
    Dim monthvar As Integer
    Dim yearvar As Integer
    Dim choosendate As Date
    Dim monthtxt As String
    Dim i As Integer = 0
    Private paper As Image = My.Resources.paper2
    Dim block As Integer = 0
    Dim block2 As Integer = 0
    Dim block3 As Integer = 0

    Dim rblock As Integer = 0
    Dim rblock2 As Integer = 0
    Dim rblock3 As Integer = 0

    Dim srblock As Integer = 0
    Dim srblock2 As Integer = 0
    Dim srblock3 As Integer = 0

    Dim timeslotbgn As Integer
    Dim timeslotend As Integer

    Dim reserved As Integer = 0
    Dim theday As Integer
    Dim thehourstart As Integer
    Dim thehourend As Integer

    Dim theday2 As Integer
    Dim thehourstart2 As Integer
    Dim thehourend2 As Integer
    Dim reserved2 As Integer

    Dim theday3 As Integer
    Dim thehourstart3 As Integer
    Dim thehourend3 As Integer
    Dim reserved3 As Integer
    Dim strDir As String
    Dim strDir2 As String
    Dim mark As Integer
    Public artist As String
    Dim check As Integer
    Dim resclick10 As Integer
    Dim resclick11 As Integer
    Dim resclick12 As Integer
    Dim resclick1 As Integer
    Dim resclick2 As Integer
    Dim resclick3 As Integer
    Dim resclick4 As Integer
    Dim resclick5 As Integer
    Public closetag As Integer
    Public Structure stype
        Public artist As String
        Public fname As String
        Public lname As String
        Public dobmonth As String
        Public dobday As String
        Public dobyear As String
        Public address As String
        Public city As String
        Public state As String
        Public zipcode As String
        Public homephone As String
        Public workphone As String
        Public email As String
        Public howmanytat As String
        Public lasttat As String
        Public thistat As String
        Public tatsize As String
        Public tatcolor As String
        Public tatprice As String
        Public tatloc1 As String
        Public tatloc2 As String
        Public tatloc3 As String
        Public tatloc4 As String
        Public tatloc5 As String
        Public year As String
        Public month As String
        Public day As String
        Public hourstart As String
        Public hourend As String
        Public reservedd As Integer
    End Structure

    Dim Monthtitle As Font = New Font(New FontFamily("Arial"), 25)
    Dim resstring As Font = New Font(New FontFamily("Arial"), 12)
    Dim tan As New SolidBrush(Color.FromArgb(255, 192, 128))
    Dim yellowBrush As New SolidBrush(Color.Yellow)
    Dim blackBrush As New SolidBrush(Color.Gray)
    Public saveinfo2(29) As String
    Private Sub DirSearch()
        Dim d As String
        Dim f As String
        Dim currentrow As String()
        i = 0
        Try
            For Each d In Directory.GetDirectories(strDir2)
                For Each f In Directory.GetFiles(d, "filename.txt")
                    Using myreader As New Microsoft.VisualBasic.FileIO.TextFieldParser(f)
                        myreader.TextFieldType = FileIO.FieldType.Delimited
                        myreader.SetDelimiters("|")
                        While Not myreader.EndOfData
                            currentrow = myreader.ReadFields()
                            s(i).artist = currentrow(0)
                            s(i).fname = currentrow(1)
                            s(i).lname = currentrow(2)
                            s(i).dobmonth = currentrow(3)
                            s(i).dobday = currentrow(4)
                            s(i).dobyear = currentrow(5)
                            s(i).address = currentrow(6)
                            s(i).city = currentrow(7)
                            s(i).state = currentrow(8)
                            s(i).zipcode = currentrow(9)
                            s(i).homephone = currentrow(10)
                            s(i).workphone = currentrow(11)
                            s(i).email = currentrow(12)
                            s(i).howmanytat = currentrow(13)
                            s(i).lasttat = currentrow(14)
                            s(i).thistat = currentrow(15)
                            s(i).tatsize = currentrow(16)
                            s(i).tatcolor = currentrow(17)
                            s(i).tatprice = currentrow(18)
                            s(i).tatloc1 = currentrow(19)
                            s(i).tatloc2 = currentrow(20)
                            s(i).tatloc3 = currentrow(21)
                            s(i).tatloc4 = currentrow(22)
                            s(i).tatloc5 = currentrow(23)
                            s(i).year = currentrow(24)
                            s(i).month = currentrow(25)
                            s(i).day = currentrow(26)
                            s(i).hourstart = currentrow(27)
                            s(i).hourend = currentrow(28)
                            s(i).reservedd = currentrow(29)
                            checkdate()
                            i += 1
                        End While
                    End Using
                Next
            Next

        Catch excpt As System.Exception
            Debug.WriteLine(excpt.Message)
        End Try
    End Sub
    Public Sub checkdate()
        If s(i).year = yearvar Then
            If s(i).month = monthvar Then
                If s(i).day = calendarlocation Then
                    If mark = 1 Then
                        theday2 = s(i).day
                        thehourend2 = s(i).hourend
                        thehourstart2 = s(i).hourstart
                        reserved2 = s(i).reservedd
                        appointmentblackout2()
                        mark = 2
                        If mark = 2 Then
                            theday3 = s(i).day
                            thehourend3 = s(i).hourend
                            thehourstart3 = s(i).hourstart
                            reserved3 = s(i).reservedd
                            appointmentblackout()
                            mark = 3
                        End If
                    Else
                        theday = s(i).day
                        thehourend = s(i).hourend
                        thehourstart = s(i).hourstart
                        reserved = s(i).reservedd
                        appointmentblackout()
                        mark = 1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub hourplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        clientwidth = 500
        clientheight = 600
        Me.ClientSize = New Size(clientwidth, clientheight)
        monthvar = Calendar.monthvar
        yearvar = Calendar.yearvar
        monthtxt = Calendar.monthtext
        calendarlocation = Calendar.calendarlocation
        saveinfo2(0) = Calendar.saveinfo2(0)
        saveinfo2(1) = Calendar.saveinfo2(1)
        saveinfo2(2) = Calendar.saveinfo2(2)
        saveinfo2(3) = Calendar.saveinfo2(3)
        saveinfo2(4) = Calendar.saveinfo2(4)
        saveinfo2(5) = Calendar.saveinfo2(5)
        saveinfo2(6) = Calendar.saveinfo2(6)
        saveinfo2(7) = Calendar.saveinfo2(7)
        saveinfo2(8) = Calendar.saveinfo2(8)
        saveinfo2(9) = Calendar.saveinfo2(9)
        saveinfo2(10) = Calendar.saveinfo2(10)
        saveinfo2(11) = Calendar.saveinfo2(11)
        saveinfo2(12) = Calendar.saveinfo2(12)
        saveinfo2(13) = Calendar.saveinfo2(13)
        saveinfo2(14) = Calendar.saveinfo2(14)
        saveinfo2(15) = Calendar.saveinfo2(15)
        saveinfo2(16) = Calendar.saveinfo2(16)
        saveinfo2(17) = Calendar.saveinfo2(17)
        saveinfo2(18) = Calendar.saveinfo2(18)
        saveinfo2(19) = Calendar.saveinfo2(19)
        saveinfo2(20) = Calendar.saveinfo2(20)
        saveinfo2(21) = Calendar.saveinfo2(21)
        saveinfo2(22) = Calendar.saveinfo2(22)
        saveinfo2(23) = Calendar.saveinfo2(23)
        saveinfo2(24) = "0"
        saveinfo2(25) = "0"
        saveinfo2(26) = "0"
        saveinfo2(27) = "0"
        saveinfo2(28) = "0"
        artist = saveinfo2(0)
        Calendar.Close()
        If artist = 1 Then
            strDir = "c:\appointment\paullunetta\images\"
            strDir2 = "c:\appointment\paullunetta"
        End If
        If artist = 2 Then
            strDir = "c:\appointment\jazminwebb\images\"
            strDir2 = "c:\appointment\jazminwebb"
        End If
        If artist = 3 Then
            strDir = "c:\appointment\coltrichardson\images\"
            strDir2 = "c:\appointment\coltrichardson"
        End If



        Label1.Location = New Point(35, 528)
        Label1.Text = "Please select the time you would like you appointment to start"
        Calendar.Close()
        DirSearch()

        mainLoop()
    End Sub

    Private Sub mainLoop()
        backbuffer = New Bitmap(clientwidth, clientheight)
        graphics = Graphics.FromImage(backbuffer)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        timer = New Stopwatch()
        Do While isrunning = True
            Application.DoEvents()
            Me.Invalidate()
            Me.Update()
            Me.Refresh()
        Loop
    End Sub
    Private Sub writedatafields()
        If My.Computer.FileSystem.DirectoryExists(strDir) Then
            Dim path As String = strDir & "filename.txt"
            Dim writer As New System.IO.StreamWriter(path, True)
            writer.WriteLine(saveinfo2(0) & "|" & saveinfo2(1) & "|" & saveinfo2(2) & "|" & saveinfo2(3) & "|" &
saveinfo2(4) & "|" & saveinfo2(5) & "|" & saveinfo2(6) & "|" & saveinfo2(7) & "|" &
saveinfo2(8) & "|" & saveinfo2(9) & "|" & saveinfo2(10) & "|" & saveinfo2(11) & "|" &
saveinfo2(12) & "|" & saveinfo2(13) & "|" & saveinfo2(14) & "|" & saveinfo2(15) & "|" &
saveinfo2(16) & "|" & saveinfo2(17) & "|" & saveinfo2(18) & "|" & saveinfo2(19) & "|" &
saveinfo2(20) & "|" & saveinfo2(21) & "|" & saveinfo2(22) & "|" & saveinfo2(23) & "|" &
yearvar & "|" & monthvar & "|" & calendarlocation & "|" & timeslotbgn & "|" & timeslotend & "|" & reserved)
            writer.Flush()
            writer.Close()
        Else
            MkDir(Trim(strDir))
            Dim path As String = strDir & "filename.txt"
            Dim writer As New System.IO.StreamWriter(path, True)
            writer.WriteLine(saveinfo2(0) & "|" & saveinfo2(1) & "|" & saveinfo2(2) & "|" & saveinfo2(3) & "|" &
saveinfo2(4) & "|" & saveinfo2(5) & "|" & saveinfo2(6) & "|" & saveinfo2(7) & "|" &
saveinfo2(8) & "|" & saveinfo2(9) & "|" & saveinfo2(10) & "|" & saveinfo2(11) & "|" &
saveinfo2(12) & "|" & saveinfo2(13) & "|" & saveinfo2(14) & "|" & saveinfo2(15) & "|" &
saveinfo2(16) & "|" & saveinfo2(17) & "|" & saveinfo2(18) & "|" & saveinfo2(19) & "|" &
saveinfo2(20) & "|" & saveinfo2(21) & "|" & saveinfo2(22) & "|" & saveinfo2(23) & "|" &
yearvar & "|" & monthvar & "|" & calendarlocation & "|" & timeslotbgn & "|" & timeslotend & "|" & reserved)
            writer.Flush()
            writer.Close()
        End If
    End Sub
    Private Sub hourplan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        mousex = e.X
        mousey = e.Y
    End Sub
    Private Sub confirm()
        If timeslotbgn > 0 Then
            If timeslotbgn = 10 Or timeslotbgn = 11 Then
                Label1.Location = New Point(60, 477)
                Label1.Text = "Would you like your set your appointment for: " & timeslotbgn & ":00 AM" & vbCrLf &
                                "Please select confirm to set your appointment start time"
            Else
                Label1.Location = New Point(60, 477)
                Label1.Text = "Would you like your set your appointment for: " & timeslotbgn & ":00 PM" & vbCrLf &
                                "Please select confirm to set your appointment start time"
            End If
            confirmbtn.Show()

            confirmbtn3.Show()

        End If
    End Sub
    Private Sub confirmtwo()
        If hour1rad.Checked = True Then
            timeslotend = timeslotbgn + 1
            reserved = 1
            If timeslotend > 12 Then
                reserved = 1
                timeslotend = timeslotend - 12
            End If
            confirmbtn.Hide()
            confirmbtn2.Show()
        ElseIf hour2rad.Checked = True Then
            reserved = 2
            timeslotend = timeslotbgn + 2
            If timeslotend > 12 Then
                reserved = 2
                timeslotend = timeslotend - 12
            End If
            confirmbtn.Hide()
            confirmbtn2.Show()
        ElseIf hour3rad.Checked = True Then
            reserved = 3
            timeslotend = timeslotbgn + 3
            If timeslotend > 12 Then
                reserved = 3
                timeslotend = timeslotend - 12
            End If
            confirmbtn.Hide()
            confirmbtn2.Show()
        End If
    End Sub

    Private Sub appointmentblackout2()
        If thehourstart2 = 10 Then
            If reserved2 = 1 Then
                srblock = 1
                resclick10 = 1
                srblock = 1
                resclick10 = 1
            ElseIf reserved2 = 2 Then
                srblock = 1
                srblock2 = 2
                resclick10 = 1
                resclick11 = 1
            ElseIf reserved2 = 3 Then
                srblock = 1
                srblock2 = 2
                srblock3 = 3
                resclick10 = 1
                resclick11 = 1
                resclick12 = 1
            End If
        End If
        If thehourstart2 = 11 Then
            If reserved2 = 1 Then
                srblock = 2
                resclick11 = 1
            ElseIf reserved2 = 2 Then
                srblock = 2
                srblock2 = 3
                resclick11 = 1
                resclick12 = 1
            ElseIf reserved2 = 3 Then
                srblock = 2
                srblock2 = 3
                srblock3 = 4
                resclick11 = 1
                resclick12 = 1
                resclick1 = 1
            End If
        End If
        If thehourstart2 = 12 Then
            If reserved2 = 1 Then
                srblock = 3
                resclick12 = 1
            ElseIf reserved2 = 2 Then
                srblock = 3
                srblock2 = 4
                resclick12 = 1
                resclick1 = 1
            ElseIf reserved2 = 3 Then
                srblock = 3
                srblock2 = 4
                srblock3 = 5
                resclick12 = 1
                resclick1 = 1
                resclick2 = 1
            End If
        End If
        If thehourstart2 = 1 Then
            If reserved2 = 1 Then
                srblock = 4
                resclick1 = 1
            ElseIf reserved = 2 Then
                rblock = 4
                rblock2 = 5
                resclick1 = 1
                resclick2 = 1
            ElseIf reserved2 = 3 Then
                srblock = 4
                srblock2 = 5
                srblock3 = 6
                resclick1 = 1
                resclick2 = 1
                resclick3 = 1
            End If
        End If
        If thehourstart2 = 2 Then
            If reserved2 = 1 Then
                srblock = 5
                resclick2 = 1
            ElseIf reserved2 = 2 Then
                srblock = 5
                srblock2 = 6
                resclick2 = 1
                resclick3 = 1
            ElseIf reserved2 = 3 Then
                srblock = 5
                srblock2 = 6
                srblock3 = 7
                resclick2 = 1
                resclick3 = 1
                resclick3 = 1
            End If
        End If
        If thehourstart2 = 3 Then
            If reserved2 = 1 Then
                srblock = 6
                resclick3 = 1
            ElseIf reserved2 = 2 Then
                srblock = 6
                srblock2 = 7
                resclick3 = 1
                resclick4 = 1
            ElseIf reserved2 = 3 Then
                srblock = 6
                srblock2 = 7
                srblock3 = 8
                resclick3 = 1
                resclick4 = 1
                resclick5 = 1
            End If
        End If
        If thehourstart2 = 7 Then
            If reserved2 = 1 Then
                srblock = 7
                resclick4 = 1
            ElseIf reserved2 = 2 Then
                srblock = 7
                srblock2 = 8
                resclick4 = 1
                resclick4 = 1
            ElseIf reserved2 = 3 Then
                srblock = 7
                srblock2 = 8
                resclick4 = 1
                resclick5 = 1
            End If
        End If
        If thehourstart2 = 8 Then
            If reserved2 = 1 Then
                srblock = 8
                resclick5 = 1
            ElseIf reserved2 = 2 Then
                srblock = 8
                resclick5 = 1
            ElseIf reserved2 = 3 Then
                srblock = 8
                resclick5 = 1
            End If
        End If
    End Sub

    Private Sub appointmentblackout()
        If thehourstart = 10 Then
            If reserved = 1 Then
                rblock = 1
                resclick10 = 1
                rblock = 1
                resclick10 = 1
            ElseIf reserved = 2 Then
                rblock = 1
                rblock2 = 2
                resclick10 = 1
                resclick11 = 1
            ElseIf reserved = 3 Then
                rblock = 1
                rblock2 = 2
                rblock3 = 3
                resclick10 = 1
                resclick11 = 1
                resclick12 = 1
            End If
        End If
        If thehourstart = 11 Then
            If reserved = 1 Then
                rblock = 2
                resclick11 = 1
            ElseIf reserved = 2 Then
                rblock = 2
                rblock2 = 3
                resclick11 = 1
                resclick12 = 1
            ElseIf reserved = 3 Then
                rblock = 2
                rblock2 = 3
                rblock3 = 4
                resclick11 = 1
                resclick12 = 1
                resclick1 = 1
            End If
        End If
        If thehourstart = 12 Then
            If reserved = 1 Then
                rblock = 3
                resclick12 = 1
            ElseIf reserved = 2 Then
                rblock = 3
                rblock2 = 4
                resclick12 = 1
                resclick1 = 1
            ElseIf reserved = 3 Then
                rblock = 3
                rblock2 = 4
                rblock3 = 5
                resclick12 = 1
                resclick1 = 1
                resclick2 = 1
            End If
        End If
        If thehourstart = 1 Then
            If reserved = 1 Then
                rblock = 4
                resclick1 = 1
            ElseIf reserved = 2 Then
                rblock = 4
                rblock2 = 5
                resclick1 = 1
                resclick2 = 1
            ElseIf reserved = 3 Then
                rblock = 4
                rblock2 = 5
                rblock3 = 6
                resclick1 = 1
                resclick2 = 1
                resclick3 = 1
            End If
        End If
        If thehourstart = 2 Then
            If reserved = 1 Then
                rblock = 5
                resclick2 = 1
            ElseIf reserved = 2 Then
                rblock = 5
                rblock2 = 6
                resclick2 = 1
                resclick3 = 1
            ElseIf reserved = 3 Then
                rblock = 5
                rblock2 = 6
                rblock3 = 7
                resclick2 = 1
                resclick3 = 1
                resclick3 = 1
            End If
        End If
        If thehourstart = 3 Then
            If reserved = 1 Then
                rblock = 6
                resclick3 = 1
            ElseIf reserved = 2 Then
                rblock = 6
                rblock2 = 7
                resclick3 = 1
                resclick4 = 1
            ElseIf reserved = 3 Then
                rblock = 6
                rblock2 = 7
                rblock3 = 8
                resclick3 = 1
                resclick4 = 1
                resclick5 = 1
            End If
        End If
        If thehourstart = 7 Then
            If reserved = 1 Then
                rblock = 7
                resclick4 = 1
            ElseIf reserved = 2 Then
                rblock = 7
                rblock2 = 8
                resclick4 = 1
                resclick4 = 1
            ElseIf reserved = 3 Then
                rblock = 7
                rblock2 = 8
                resclick4 = 1
                resclick5 = 1
            End If
        End If
        If thehourstart = 8 Then
            If reserved = 1 Then
                rblock = 8
                resclick5 = 1
            ElseIf reserved = 2 Then
                rblock = 8
                resclick5 = 1
            ElseIf reserved = 3 Then
                rblock = 8
                resclick5 = 1
            End If
        End If
    End Sub
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If mousex >= 100 And mousex <= 400 And mousey >= 88 And mousey <= 134 And check <> 1 Then
            If resclick10 <> 1 Then
                timeslotbgn = 10
                block = 1
                confirm()
            End If
        ElseIf mousex >= 100 And mousex <= 400 And mousey >= 135 And mousey <= 181 And check <> 1 Then
            If resclick11 <> 1 Then
                timeslotbgn = 11
                block = 2
                confirm()
            End If
        ElseIf mousex >= 100 And mousex <= 400 And mousey >= 182 And mousey <= 229 And check <> 1 Then
            If resclick12 <> 1 Then
                timeslotbgn = 12
                block = 3
                confirm()
            End If
        ElseIf mousex >= 100 And mousex <= 400 And mousey >= 230 And mousey <= 274 And check <> 1 Then
            If resclick1 <> 1 Then
                timeslotbgn = 1
                block = 4
                confirm()
            End If
        ElseIf mousex >= 100 And mousex <= 400 And mousey >= 275 And mousey <= 323 And check <> 1 Then
            If resclick2 <> 1 Then
                timeslotbgn = 2
                block = 5
                confirm()
            End If
        ElseIf mousex >= 100 And mousex <= 400 And mousey >= 324 And mousey <= 370 And check <> 1 Then
            If resclick3 <> 1 Then
                timeslotbgn = 3
                block = 6
                confirm()
            End If
        ElseIf mousex >= 100 And mousex <= 400 And mousey >= 371 And mousey <= 416 And check <> 1 Then
            If resclick4 <> 1 Then
                timeslotbgn = 4
                block = 7
                confirm()
            End If
        ElseIf mousex >= 100 And mousex <= 400 And mousey >= 417 And mousey <= 464 And check <> 1 Then
            If resclick5 <> 1 Then
                timeslotbgn = 5
                block = 8
                confirm()
            End If
        End If
    End Sub
    Public Sub hourplan_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'e.Graphics.DrawString("X." & mousex & vbCrLf & "Y." & mousey, Me.Font, Brushes.Yellow, 0, 0)
        e.Graphics.DrawImage(paper, 100, 20, 300, 445)
        e.Graphics.DrawString(choosendate, Me.Font, Brushes.Yellow, 30, 0)
        e.Graphics.DrawString(monthtxt & " " & calendarlocation & ", " & yearvar, Monthtitle, Brushes.Black, (clientwidth / 2) - (Len(monthtxt)) - 140, 52)
        'e.Graphics.DrawRectangle(Pens.Red, 100, 20, 300, 35)
        e.Graphics.DrawString("10:00-11:00", Me.Font, Brushes.Black, 100, 105)
        e.Graphics.DrawString("11:00-12:00", Me.Font, Brushes.Black, 100, 155)
        e.Graphics.DrawString("12:00-1:00", Me.Font, Brushes.Black, 105, 200)
        e.Graphics.DrawString("1:00-2:00", Me.Font, Brushes.Black, 110, 244)
        e.Graphics.DrawString("2:00-3:00", Me.Font, Brushes.Black, 110, 293)
        e.Graphics.DrawString("3:00-4:00", Me.Font, Brushes.Black, 110, 340)
        e.Graphics.DrawString("4:00-5:00", Me.Font, Brushes.Black, 110, 387)
        e.Graphics.DrawString("5:00-6:00", Me.Font, Brushes.Black, 110, 435)
        If block >= 1 Then
            closebtn1.Hide()
        End If
        If block = 1 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 88, 300, 48)
            e.Graphics.DrawString("10:00-11:00", Me.Font, Brushes.Blue, 100, 105)
        End If
        If block = 2 Or block2 = 2 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 135, 300, 48)
            e.Graphics.DrawString("11:00-12:00", Me.Font, Brushes.Black, 100, 155)
        End If
        If block = 3 Or block2 = 3 Or block3 = 3 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 182, 300, 46)
            e.Graphics.DrawString("12:00-1:00", Me.Font, Brushes.Black, 105, 200)
        End If
        If block = 4 Or block2 = 4 Or block3 = 4 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 230, 300, 48)
            e.Graphics.DrawString("1:00-2:00", Me.Font, Brushes.Black, 110, 244)
        End If
        If block = 5 Or block2 = 5 Or block3 = 5 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 276, 300, 48)
            e.Graphics.DrawString("2:00-3:00", Me.Font, Brushes.Black, 110, 293)
        End If
        If block = 6 Or block2 = 6 Or block3 = 6 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 324, 300, 48)
            e.Graphics.DrawString("3:00-4:00", Me.Font, Brushes.Black, 110, 340)
        End If
        If block = 7 Or block2 = 7 Or block3 = 7 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 370, 300, 48)
            e.Graphics.DrawString("4:00-5:00", Me.Font, Brushes.Black, 110, 387)
        End If
        If block = 8 Or block2 = 8 Or block3 = 8 Then
            e.Graphics.FillRectangle(yellowBrush, 100, 417, 300, 48)
            e.Graphics.DrawString("5:00-6:00", Me.Font, Brushes.Black, 110, 435)
        End If

        If rblock = 1 Then
            e.Graphics.FillRectangle(blackBrush, 100, 88, 300, 48)
            e.Graphics.DrawString("10:00 - 11:00 - This time slot is reserved", resstring, Brushes.Blue, 100, 105)
        End If
        If rblock = 2 Or rblock2 = 2 Then
            e.Graphics.FillRectangle(blackBrush, 100, 135, 300, 48)
            e.Graphics.DrawString("11:00-12:00- This time slot is reserved", resstring, Brushes.Blue, 100, 155)
        End If
        If rblock = 3 Or rblock2 = 3 Or rblock3 = 3 Then
            e.Graphics.FillRectangle(blackBrush, 100, 182, 300, 48)
            e.Graphics.DrawString("12:00-1:00- This time slot is reserved", resstring, Brushes.Blue, 105, 200)
        End If
        If rblock = 4 Or rblock2 = 4 Or rblock3 = 4 Then
            e.Graphics.FillRectangle(blackBrush, 100, 230, 300, 48)
            e.Graphics.DrawString("1:00-2:00- This time slot is reserved", resstring, Brushes.Blue, 110, 244)
        End If
        If rblock = 5 Or rblock2 = 5 Or rblock3 = 5 Then
            e.Graphics.FillRectangle(blackBrush, 100, 276, 300, 48)
            e.Graphics.DrawString("2:00-3:00- This time slot is reserved", resstring, Brushes.Blue, 110, 293)
        End If
        If rblock = 6 Or rblock2 = 6 Or rblock3 = 6 Then
            e.Graphics.FillRectangle(blackBrush, 100, 324, 300, 48)
            e.Graphics.DrawString("3:00-4:00- This time slot is reserved", resstring, Brushes.Blue, 110, 340)
        End If
        If rblock = 7 Or rblock2 = 7 Or rblock3 = 7 Then
            e.Graphics.FillRectangle(blackBrush, 100, 370, 300, 48)
            e.Graphics.DrawString("4:00-5:00- This time slot is reserved", resstring, Brushes.Blue, 110, 387)
        End If
        If rblock = 8 Or rblock2 = 8 Or rblock3 = 8 Then
            e.Graphics.FillRectangle(blackBrush, 100, 417, 300, 48)
            e.Graphics.DrawString("5:00-6:00- This time slot is reserved", resstring, Brushes.Blue, 110, 435)
        End If

        If srblock = 1 Then
            e.Graphics.FillRectangle(blackBrush, 100, 88, 300, 48)
            e.Graphics.DrawString("10:00 - 11:00 - This time slot is reserved", resstring, Brushes.Blue, 100, 105)
        End If
        If srblock = 2 Or srblock2 = 2 Then
            e.Graphics.FillRectangle(blackBrush, 100, 135, 300, 48)
            e.Graphics.DrawString("11:00-12:00- This time slot is reserved", resstring, Brushes.Blue, 100, 155)
        End If
        If srblock = 3 Or srblock2 = 3 Or srblock3 = 3 Then
            e.Graphics.FillRectangle(blackBrush, 100, 182, 300, 48)
            e.Graphics.DrawString("12:00-1:00- This time slot is reserved", resstring, Brushes.Blue, 105, 200)
        End If
        If srblock = 4 Or srblock2 = 4 Or srblock3 = 4 Then
            e.Graphics.FillRectangle(blackBrush, 100, 230, 300, 48)
            e.Graphics.DrawString("1:00-2:00- This time slot is reserved", resstring, Brushes.Blue, 110, 244)
        End If
        If srblock = 5 Or srblock2 = 5 Or srblock3 = 5 Then
            e.Graphics.FillRectangle(blackBrush, 100, 276, 300, 48)
            e.Graphics.DrawString("2:00-3:00- This time slot is reserved", resstring, Brushes.Blue, 110, 293)
        End If
        If srblock = 6 Or srblock2 = 6 Or srblock3 = 6 Then
            e.Graphics.FillRectangle(blackBrush, 100, 324, 300, 48)
            e.Graphics.DrawString("3:00-4:00- This time slot is reserved", resstring, Brushes.Blue, 110, 340)
        End If
        If srblock = 7 Or srblock2 = 7 Or srblock3 = 7 Then
            e.Graphics.FillRectangle(blackBrush, 100, 370, 300, 48)
            e.Graphics.DrawString("4:00-5:00- This time slot is reserved", resstring, Brushes.Blue, 110, 387)
        End If
        If srblock = 8 Or srblock2 = 8 Or srblock3 = 8 Then
            e.Graphics.FillRectangle(blackBrush, 100, 417, 300, 48)
            e.Graphics.DrawString("5:00-6:00- This time slot is reserved", resstring, Brushes.Blue, 110, 435)
        End If
    End Sub


    Private Sub closebtn1_Click_1(sender As Object, e As EventArgs) Handles closebtn1.Click

        Calendar.Show()
        closetag = 1
        Me.Close()
    End Sub

    Private Sub confirmbtn_Click(sender As Object, e As EventArgs) Handles confirmbtn.Click
        check = 1
        Label1.Text = "Please select the number of hours you expect the job to last "
        hour1rad.Show()
        hour2rad.Show()
        hour3rad.Show()
        confirmtwo()
    End Sub


    Private Sub blockcheck()
        If block2 > 0 Or block3 > 0 Then
            block2 = 0
            block3 = 0
        End If
        If hour2rad.Checked = True Then
            block2 = block + 1
        ElseIf hour3rad.Checked = True Then
            block2 = block + 1
            block3 = block2 + 1
        End If
    End Sub

    Private Sub confirmbtn2_Click(sender As Object, e As EventArgs) Handles confirmbtn2.Click
        hour1rad.Hide()
        hour2rad.Hide()
        hour3rad.Hide()
        confirmbtn.Hide()
        confirmbtn2.Hide()
        finalconfirm.Show()

        If timeslotbgn = 10 Or timeslotbgn = 11 Then
            Label1.Location = New Point(60, 475)
            Label1.Text = "You have selected for your appointment to: " & vbCrLf _
                & "          " & "Begin:" & timeslotbgn & ":00 AM" & vbCrLf &
                  "          " & "End: " & timeslotend & ":00 PM"
        Else
            Label1.Location = New Point(60, 475)
            Label1.Text = "You have selected for your appointment to: " & vbCrLf _
                & "          " & "Begin: " & timeslotbgn & ":00 PM" & vbCrLf &
                 "          " & "End: " & timeslotend & ":00 PM"
        End If

    End Sub

    Private Sub hour1rad_CheckedChanged(sender As Object, e As EventArgs) Handles hour1rad.CheckedChanged
        confirmtwo()
    End Sub

    Private Sub hour2rad_CheckedChanged(sender As Object, e As EventArgs) Handles hour2rad.CheckedChanged
        blockcheck()
        confirmtwo()
    End Sub

    Private Sub hour3rad_CheckedChanged(sender As Object, e As EventArgs) Handles hour3rad.CheckedChanged
        blockcheck()
        confirmtwo()
    End Sub

    Private Sub confirmbtn3_Click(sender As Object, e As EventArgs) Handles confirmbtn3.Click
        block = 0
        check = 0
        block2 = 0
        block3 = 0
        confirmbtn.Hide()
        confirmbtn2.Hide()
        confirmbtn3.Hide()

        closebtn1.Show()
        hour1rad.Hide()
        hour2rad.Hide()
        hour3rad.Hide()
        hour1rad.Checked = False
        hour2rad.Checked = False
        hour3rad.Checked = False
        Label1.Location = New Point(35, 530)
        Label1.Text = "Please select the time you would like you appointment to start"
    End Sub

    Private Sub finalconfirm_Click(sender As Object, e As EventArgs) Handles finalconfirm.Click

        writedatafields()
        artistselect.Close()
        Calendar.Close()
        painmap.Close()
        quest1check.Close()
        quest2check.Close()
        Questionair1.Close()
        Questionair2.Close()
        Start_Page.Show()
        Me.Close()
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class