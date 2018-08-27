Imports System.IO
Public Class manageappointment
    Dim max As Integer = 100
    Dim timer As Stopwatch
    Dim backbuffer As Image
    Dim graphics As Graphics
    Dim clientwidth As Integer
    Dim clientheight As Integer
    Dim boardrects(max, max)
    Dim isrunning As Boolean = True
    Dim mousex As Integer
    Dim mousey As Integer
    Dim datenum(42) As Integer
    Dim days(6) As Rectangle
    Dim rect(42)
    Dim daterec(42) As Rectangle
    Public daynumb(42) As Integer
    Dim daystot As Integer
    Dim daymax As Integer
    Dim startday As Integer
    Dim datevalue As Date = Date.Today
    Public monthvar As String
    Public yearvar As String
    Public monthtext As String
    Dim monthX As Integer
    Dim redpen As New Pen(Color.Red, 3)
    Dim orangepen As New Pen(Color.DarkOrange, 3)
    Dim yellowpen As New Pen(Color.Yellow, 1)
    Dim greenpen As New Pen(Color.Green, 3)
    Dim bluepen As New Pen(Color.Blue, 1)
    Dim redBrush As New SolidBrush(Color.Red)
    Dim orangeBrush As New SolidBrush(Color.DarkOrange)
    Dim yellowBrush As New SolidBrush(Color.Yellow)
    Dim greenBrush As New SolidBrush(Color.Green)
    Dim blueBrush As New SolidBrush(Color.Blue)
    Dim tanBrush As New SolidBrush(Color.Tan)
    Dim tan As New SolidBrush(Color.FromArgb(255, 192, 128))
    Dim arial As Font = New Font(New FontFamily("Papyrus"), 14)
    Dim arial2 As Font = New Font(New FontFamily("Papyrus"), 18)
    Dim Monthtitle As Font = New Font(New FontFamily("Papyrus"), 30)
    Dim arial3 As Font = New Font(New FontFamily("Papyrus"), 8)
    Public calendarlocation As Integer
    Dim theyear As Integer
    Dim themonth(42) As Integer
    Dim theday(42) As Integer
    Dim thehourstart(42) As Integer
    Dim artist As String
    Dim thehourend(42) As Integer
    Public saveinfo2(28) As String
    Dim i As Integer
    Dim day As Integer
    Dim passname As String
    Public strDir As String
    Public artistsign As Integer
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
        Public reservedd As String
    End Structure
    Dim s As stype

    Public Sub DrawnCalendar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer = 0
        Dim y As Integer = 0
        Me.Invalidate()
        Me.Update()
        Me.Refresh()
        strDir = artistlogin.strDir
        monthvar = datevalue.Month
        yearvar = datevalue.Year
        daystot = System.DateTime.DaysInMonth(yearvar, monthvar)
        passname = artistlogin.passname
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        clientwidth = 1000
        clientheight = 1000
        Me.ClientSize = New Size(clientwidth, clientheight)
        For i As Integer = 0 To 41
            daterec(i) = New Rectangle(60 + x, 105 + y, 30, 25)
            rect(i) = New Rectangle(60 + x, 105 + y, 125, 125)
            If i = 6 Or i = 13 Or i = 20 Or i = 27 Or i = 34 Then
                y += 125
                x = 0
            Else
                x += 125
            End If
        Next
        populatecalendar()
        artistlogin.close()

    End Sub

    Private Sub DirSearch()
        Dim strDir As String = ""
        strDir = passname
        Dim d As String
        Dim f As String
        Dim currentrow As String()
        i = 0
        Try
            For Each d In Directory.GetDirectories(strDir)
                For Each f In Directory.GetFiles(d, "filename.Txt")
                    Using myreader As New Microsoft.VisualBasic.FileIO.TextFieldParser(f)
                        myreader.TextFieldType = FileIO.FieldType.Delimited
                        myreader.SetDelimiters("|")
                        While Not myreader.EndOfData
                            currentrow = myreader.ReadFields()
                            s.artist = currentrow(0)
                            s.fname = currentrow(1)
                            s.lname = currentrow(2)
                            s.dobmonth = currentrow(3)
                            s.dobday = currentrow(4)
                            s.dobyear = currentrow(5)
                            s.address = currentrow(6)
                            s.city = currentrow(7)
                            s.state = currentrow(8)
                            s.zipcode = currentrow(9)
                            s.homephone = currentrow(10)
                            s.workphone = currentrow(11)
                            s.email = currentrow(12)
                            s.howmanytat = currentrow(13)
                            s.lasttat = currentrow(14)
                            s.thistat = currentrow(15)
                            s.tatsize = currentrow(16)
                            s.tatcolor = currentrow(17)
                            s.tatprice = currentrow(18)
                            s.tatloc1 = currentrow(19)
                            s.tatloc2 = currentrow(20)
                            s.tatloc3 = currentrow(21)
                            s.tatloc4 = currentrow(22)
                            s.tatloc5 = currentrow(23)
                            s.year = currentrow(24)
                            s.month = currentrow(25)
                            s.day = currentrow(26)
                            s.hourstart = currentrow(27)
                            s.hourend = currentrow(28)
                            s.reservedd = currentrow(29)
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
        For x As Integer = 1 To daymax
            If s.month = monthvar Then
                If s.day = x Then
                    themonth(x) = s.month
                    theday(x) = s.day
                    thehourend(x) = s.hourend
                    thehourstart(x) = s.hourstart
                End If
            End If
        Next
    End Sub

    Public Sub checkcal()

        If calendarlocation <> 0 Then
            artistsign = 1
            artisthp.Show()
        End If



    End Sub
    Private Sub DrawnCalendar_Click(sender As Object, e As EventArgs) Handles Me.Click
        If mousex >= 60 And mousex <= 184 And mousey >= 105 And mousey <= 230 Then 'Sundar
            calendarlocation = daynumb(0)
            checkcal()
        End If
        If mousex >= 185 And mousex <= 310 And mousey >= 105 And mousey <= 230 Then 'monday
            calendarlocation = daynumb(1)
            checkcal()

        End If
        If mousex >= 311 And mousex <= 435 And mousey >= 105 And mousey <= 230 Then 'tuesday
            calendarlocation = daynumb(2)
            checkcal()

        End If
        If mousex >= 436 And mousex <= 560 And mousey >= 105 And mousey <= 230 Then 'wednesday
            calendarlocation = daynumb(3)
            checkcal()

        End If
        If mousex >= 561 And mousex <= 685 And mousey >= 105 And mousey <= 230 Then 'thursday
            calendarlocation = daynumb(4)
            checkcal()

        End If
        If mousex >= 686 And mousex <= 810 And mousey >= 105 And mousey <= 230 Then 'friday
            calendarlocation = daynumb(5)
            checkcal()

        End If
        If mousex >= 811 And mousex <= 935 And mousey >= 105 And mousey <= 230 Then 'Saturday
            calendarlocation = daynumb(6)
            checkcal()
        End If

        'week 2
        If mousex >= 60 And mousex <= 184 And mousey >= 231 And mousey <= 355 Then 'Sundar
            calendarlocation = daynumb(7)
            checkcal()
        End If
        If mousex >= 185 And mousex <= 310 And mousey >= 231 And mousey <= 355 Then 'monday
            calendarlocation = daynumb(8)
            checkcal()
        End If
        If mousex >= 311 And mousex <= 435 And mousey >= 231 And mousey <= 355 Then 'tuesday
            calendarlocation = daynumb(9)
            checkcal()
        End If
        If mousex >= 436 And mousex <= 560 And mousey >= 231 And mousey <= 355 Then 'wednesday
            calendarlocation = daynumb(10)
            checkcal()
        End If
        If mousex >= 561 And mousex <= 685 And mousey >= 231 And mousey <= 355 Then 'thursday
            calendarlocation = daynumb(11)
            checkcal()
        End If
        If mousex >= 686 And mousex <= 810 And mousey >= 231 And mousey <= 355 Then 'friday
            calendarlocation = daynumb(12)
            checkcal()
        End If
        If mousex >= 811 And mousex <= 935 And mousey >= 231 And mousey <= 355 Then 'Saturday
            calendarlocation = daynumb(13)
            checkcal()
        End If

        'week 3
        If mousex >= 60 And mousex <= 184 And mousey >= 356 And mousey <= 480 Then 'Sundar
            calendarlocation = daynumb(14)
            checkcal()
        End If
        If mousex >= 185 And mousex <= 310 And mousey >= 356 And mousey <= 480 Then 'monday
            calendarlocation = daynumb(15)
            checkcal()
        End If
        If mousex >= 311 And mousex <= 435 And mousey >= 356 And mousey <= 480 Then 'tuesday
            calendarlocation = daynumb(16)
            checkcal()
        End If
        If mousex >= 436 And mousex <= 560 And mousey >= 356 And mousey <= 480 Then 'wednesday
            calendarlocation = daynumb(17)
            checkcal()
        End If
        If mousex >= 561 And mousex <= 685 And mousey >= 356 And mousey <= 480 Then 'thursday
            calendarlocation = daynumb(18)
            checkcal()
        End If
        If mousex >= 686 And mousex <= 810 And mousey >= 356 And mousey <= 480 Then 'friday
            calendarlocation = daynumb(19)
            checkcal()
        End If
        If mousex >= 811 And mousex <= 935 And mousey >= 356 And mousey <= 480 Then 'Saturday
            calendarlocation = daynumb(20)
            checkcal()
        End If

        'week 4
        If mousex >= 60 And mousex <= 184 And mousey >= 481 And mousey <= 605 Then 'Sundar
            calendarlocation = daynumb(21)
            checkcal()
        End If
        If mousex >= 185 And mousex <= 310 And mousey >= 481 And mousey <= 605 Then 'monday
            calendarlocation = daynumb(22)
            checkcal()
        End If
        If mousex >= 311 And mousex <= 435 And mousey >= 481 And mousey <= 605 Then 'tuesday
            calendarlocation = daynumb(23)
            checkcal()
        End If
        If mousex >= 436 And mousex <= 560 And mousey >= 481 And mousey <= 605 Then 'wednesday
            calendarlocation = daynumb(24)
            checkcal()
        End If
        If mousex >= 561 And mousex <= 685 And mousey >= 481 And mousey <= 605 Then 'thursday
            calendarlocation = daynumb(25)
            checkcal()
        End If
        If mousex >= 686 And mousex <= 810 And mousey >= 481 And mousey <= 605 Then 'friday
            calendarlocation = daynumb(26)
            checkcal()
        End If
        If mousex >= 811 And mousex <= 935 And mousey >= 481 And mousey <= 605 Then 'Saturday
            calendarlocation = daynumb(27)
            checkcal()
        End If

        'week 5
        If mousex >= 60 And mousex <= 184 And mousey >= 606 And mousey <= 730 Then 'Sundar
            calendarlocation = daynumb(28)
            checkcal()
        End If
        If mousex >= 185 And mousex <= 310 And mousey >= 606 And mousey <= 730 Then 'monday
            calendarlocation = daynumb(29)
            checkcal()
        End If
        If mousex >= 311 And mousex <= 435 And mousey >= 606 And mousey <= 730 Then 'tuesday
            calendarlocation = daynumb(30)
            checkcal()
        End If
        If mousex >= 436 And mousex <= 560 And mousey >= 606 And mousey <= 730 Then 'wednesday
            calendarlocation = daynumb(31)
            checkcal()
        End If
        If mousex >= 561 And mousex <= 685 And mousey >= 606 And mousey <= 730 Then 'thursday
            calendarlocation = daynumb(32)
            checkcal()
        End If
        If mousex >= 686 And mousex <= 810 And mousey >= 606 And mousey <= 730 Then 'friday
            calendarlocation = daynumb(33)
            checkcal()
        End If
        If mousex >= 811 And mousex <= 935 And mousey >= 606 And mousey <= 730 Then 'Saturday
            calendarlocation = daynumb(34)
            checkcal()
        End If

        'week 6
        If mousex >= 60 And mousex <= 184 And mousey >= 731 And mousey <= 855 Then 'Sundar
            calendarlocation = daynumb(35)
            checkcal()
        End If
        If mousex >= 185 And mousex <= 310 And mousey >= 731 And mousey <= 855 Then 'monday
            calendarlocation = daynumb(36)
            checkcal()
        End If
        If mousex >= 311 And mousex <= 435 And mousey >= 731 And mousey <= 855 Then 'tuesday
            calendarlocation = daynumb(37)
            checkcal()
        End If
        If mousex >= 436 And mousex <= 560 And mousey >= 731 And mousey <= 855 Then 'wednesday
            calendarlocation = daynumb(38)
            checkcal()
        End If
        If mousex >= 561 And mousex <= 685 And mousey >= 731 And mousey <= 855 Then 'thursday
            calendarlocation = daynumb(39)
            checkcal()
        End If
        If mousex >= 686 And mousex <= 810 And mousey >= 731 And mousey <= 855 Then 'friday
            calendarlocation = daynumb(40)
            checkcal()
        End If
        If mousex >= 811 And mousex <= 935 And mousey >= 731 And mousey <= 855 Then 'Saturday
            calendarlocation = daynumb(41)
            checkcal()
        End If



    End Sub

    Private Sub GameLoop()
        backbuffer = New Bitmap(clientwidth, clientheight)
        graphics = Graphics.FromImage(backbuffer)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        timer = New Stopwatch()
        clientwidth = 1000
        clientheight = 800
        Do While isrunning = True
            Application.DoEvents()
            Me.Invalidate()
            Me.Update()
            Me.Refresh()
        Loop
    End Sub

    Private Sub DrawnCalendar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        mousex = e.X
        mousey = e.Y
    End Sub
    Private Sub populatecalendar()
        If monthvar = 1 Then
            monthtext = "January"
            prevmonthbtn.Text = "December"
            nextmonthbtn.Text = "Feburary"
            daymax = 31
        ElseIf monthvar = 2 Then
            monthtext = "Febuary"
            prevmonthbtn.Text = "January"
            nextmonthbtn.Text = "March"
            daymax = 28
        ElseIf monthvar = 3 Then
            monthtext = "March"
            prevmonthbtn.Text = "Feburary"
            nextmonthbtn.Text = "April"
            daymax = 31
        ElseIf monthvar = 4 Then
            monthtext = "April"
            prevmonthbtn.Text = "March"
            nextmonthbtn.Text = "May"
            daymax = 30
        ElseIf monthvar = 5 Then
            monthtext = "May"
            prevmonthbtn.Text = "April"
            nextmonthbtn.Text = "June"
            daymax = 31
        ElseIf monthvar = 6 Then
            monthtext = "June"
            prevmonthbtn.Text = "May"
            nextmonthbtn.Text = "July"
            daymax = 30
        ElseIf monthvar = 7 Then
            monthtext = "July"
            prevmonthbtn.Text = "June"
            nextmonthbtn.Text = "August"
            daymax = 31
        ElseIf monthvar = 8 Then
            monthtext = "August"
            prevmonthbtn.Text = "July"
            nextmonthbtn.Text = "September"
            daymax = 31
        ElseIf monthvar = 9 Then
            monthtext = "September"
            prevmonthbtn.Text = "August"
            nextmonthbtn.Text = "October"
            daymax = 30
        ElseIf monthvar = 10 Then
            monthtext = "October"
            prevmonthbtn.Text = "September"
            nextmonthbtn.Text = "November"
            daymax = 31
        ElseIf monthvar = 11 Then
            monthtext = "November"
            prevmonthbtn.Text = "October"
            nextmonthbtn.Text = "December"
            daymax = 30
        ElseIf monthvar = 12 Then
            monthtext = "December"
            prevmonthbtn.Text = "November"
            nextmonthbtn.Text = "January"
            daymax = 31
        End If
        dayofweek()
        DirSearch()

    End Sub

    Private Sub dayofweek()
        Dim datevalue2 As New Date(yearvar, monthvar, 1)
        If datevalue2.DayOfWeek.ToString.Equals("Sunday") Then
            startday = 0
        ElseIf datevalue2.DayOfWeek.ToString.Equals("Monday") Then
            startday = 1
        ElseIf datevalue2.DayOfWeek.ToString.Equals("Tuesday") Then
            startday = 2
        ElseIf datevalue2.DayOfWeek.ToString.Equals("Wednesday") Then
            startday = 3
        ElseIf datevalue2.DayOfWeek.ToString.Equals("Thursday") Then
            startday = 4
        ElseIf datevalue2.DayOfWeek.ToString.Equals("Friday") Then
            startday = 5
        ElseIf datevalue2.DayOfWeek.ToString.Equals("Saturday") Then
            startday = 6
        End If
    End Sub


    Private Sub DrawnCalendar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'e.Graphics.DrawString(timer.ElapsedMilliseconds, Me.Font, Brushes.Green, 0, 25)
        'e.Graphics.DrawString("X." & mousex & vbCrLf & "Y." & mousey, Me.Font, Brushes.Green, 0, 0)
        e.Graphics.DrawString(monthtext & " " & yearvar, Monthtitle, Brushes.Tan, (clientwidth / 2) - (Len(monthtext) + 96), 10)
        e.Graphics.DrawString("Sunday", arial, tan, 85, 80)
        e.Graphics.DrawString("Monday", arial, tan, 205, 80)
        e.Graphics.DrawString("Tuesday", arial, tan, 325, 80)
        e.Graphics.DrawString("Wednesday", arial, tan, 442, 80)
        e.Graphics.DrawString("Thursday", arial, tan, 575, 80)
        e.Graphics.DrawString("Friday", arial, tan, 710, 80)
        e.Graphics.DrawString("Saturday", arial, tan, 830, 80)
        Dim x As Integer
        Dim y As Integer

        Dim daynum As Integer = 1

        For i As Integer = 0 To 41
            If i < startday And i <= 6 Then
                e.Graphics.DrawString("", arial, tan, 60 + x, 105 + y)
            ElseIf daynum > daymax Then
                e.Graphics.DrawString("", arial, tan, 60 + x, 105 + y)
            Else

                e.Graphics.DrawString(daynum, arial, tan, 60 + x, 105 + y)
                If thehourstart(daynum) <> 0 Then



                    e.Graphics.DrawString("Reserved time start: " & thehourstart(daynum), arial3, tan, 65 + x, 145 + y)
                    e.Graphics.DrawString("Reserved time end: " & thehourend(daynum), arial3, tan, 65 + x, 165 + y)
                End If
                daynumb(i) = daynum

                            daynum += 1

                        End If

            If i = 6 Or i = 13 Or i = 20 Or i = 27 Or i = 34 Then
                y += 125
                x = 0
            Else
                x += 125
            End If
        Next

        For i As Integer = 0 To 41
            e.Graphics.DrawRectangle(Pens.White, rect(i))
            e.Graphics.DrawRectangle(Pens.White, daterec(i))
        Next
    End Sub

    Private Sub prevmonthbtn_Click(sender As Object, e As EventArgs) Handles prevmonthbtn.Click
        If monthvar = 1 Then
            monthvar = 12

            yearvar -= 1
        Else
            monthvar -= 1
        End If
        populatecalendar()

        Me.Invalidate()
        Me.Update()
        Me.Refresh()
    End Sub

    Private Sub nextmonthbtn_Click(sender As Object, e As EventArgs) Handles nextmonthbtn.Click
        If monthvar = 12 Then
            monthvar = 1
            yearvar += 1
        Else
            monthvar += 1
        End If
        populatecalendar()
        Me.Invalidate()
        Me.Update()
        Me.Refresh()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Start_Page.Show()
        Me.Close()
    End Sub
End Class