Imports System.IO
Public Class artisthp
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
    Dim strDir As String
    Dim mark As Integer
    Dim mark2 As Integer
    Public artist As String
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

    Dim Monthtitle As Font = New Font(New FontFamily("Papyrus"), 25)
    Dim labeling As Font = New Font(New FontFamily("Papyrus"), 12)
    Dim resstring As Font = New Font(New FontFamily("Arial"), 12)
    Dim tan As New SolidBrush(Color.FromArgb(255, 192, 128))
    Dim yellowBrush As New SolidBrush(Color.Yellow)
    Dim blackBrush As New SolidBrush(Color.Gray)
    Public saveinfo(30) As String
    Public saveinfo2(30) As String
    Private Sub DirSearch()
        Dim d As String
        Dim f As String
        Dim currentrow As String()
        i = 0
        Try
            For Each d In Directory.GetDirectories(strDir)
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
                            If s(i).year = yearvar Then
                                If s(i).month = monthvar Then
                                    If s(i).day = calendarlocation Then
                                        checkinfo()
                                    End If
                                End If
                            End If
                            i += 1
                        End While
                    End Using
                Next
            Next

        Catch excpt As System.Exception
            Debug.WriteLine(excpt.Message)
        End Try
    End Sub
    Public Sub delapp()
        Dim d As String
        Dim f As String
        Dim currentrow As String()
        i = 0
        Try
            For Each d In Directory.GetDirectories(strDir)
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
                            If s(i).year = yearvar Then
                                If s(i).month = monthvar Then
                                    If s(i).day = calendarlocation Then
                                        Dim linesList As New List(Of String)(File.ReadAllLines(strDir & "\images\" & "filename.txt"))
                                        linesList.RemoveAt(1)
                                        File.WriteAllLines(strDir & "\images\" & "filename.txt", linesList.ToArray())
                                    End If
                                End If

                            Else

                            End If
                            i += 1
                        End While
                    End Using
                Next
            Next
        Catch excpt As System.Exception
            Debug.WriteLine(excpt.Message)
        End Try
    End Sub

    Public Sub checkinfo()
        If mark = 1 Then
            saveinfo2(0) = s(i).artist
            saveinfo2(1) = s(i).fname
            saveinfo2(2) = s(i).lname
            saveinfo2(3) = s(i).dobmonth
            saveinfo2(4) = s(i).dobday
            saveinfo2(5) = s(i).dobyear
            saveinfo2(6) = s(i).address
            saveinfo2(7) = s(i).city
            saveinfo2(8) = s(i).state
            saveinfo2(9) = s(i).zipcode
            saveinfo2(10) = s(i).homephone
            saveinfo2(11) = s(i).workphone
            saveinfo2(12) = s(i).email
            saveinfo2(13) = s(i).howmanytat
            saveinfo2(14) = s(i).lasttat
            saveinfo2(15) = s(i).thistat
            saveinfo2(16) = s(i).tatsize
            saveinfo2(17) = s(i).tatcolor
            saveinfo2(18) = s(i).tatprice
            saveinfo2(19) = s(i).tatloc1
            saveinfo2(20) = s(i).tatloc2
            saveinfo2(21) = s(i).tatloc3
            saveinfo2(22) = s(i).tatloc4
            saveinfo2(23) = s(i).tatloc5
            saveinfo2(24) = s(i).year
            saveinfo2(25) = s(i).month
            saveinfo2(26) = s(i).day
            saveinfo2(27) = s(i).hourstart
            saveinfo2(28) = s(i).hourend
            saveinfo2(29) = s(i).reservedd
            mark2 = 1
        ElseIf mark = 0 Then
            saveinfo(0) = s(i).artist
            saveinfo(1) = s(i).fname
            saveinfo(2) = s(i).lname
            saveinfo(3) = s(i).dobmonth
            saveinfo(4) = s(i).dobday
            saveinfo(5) = s(i).dobyear
            saveinfo(6) = s(i).address
            saveinfo(7) = s(i).city
            saveinfo(8) = s(i).state
            saveinfo(9) = s(i).zipcode
            saveinfo(10) = s(i).homephone
            saveinfo(11) = s(i).workphone
            saveinfo(12) = s(i).email
            saveinfo(13) = s(i).howmanytat
            saveinfo(14) = s(i).lasttat
            saveinfo(15) = s(i).thistat
            saveinfo(16) = s(i).tatsize
            saveinfo(17) = s(i).tatcolor
            saveinfo(18) = s(i).tatprice
            saveinfo(19) = s(i).tatloc1
            saveinfo(20) = s(i).tatloc2
            saveinfo(21) = s(i).tatloc3
            saveinfo(22) = s(i).tatloc4
            saveinfo(23) = s(i).tatloc5
            saveinfo(24) = s(i).year
            saveinfo(25) = s(i).month
            saveinfo(26) = s(i).day
            saveinfo(27) = s(i).hourstart
            saveinfo(28) = s(i).hourend
            saveinfo(29) = s(i).reservedd
            mark = 1
        End If

    End Sub


    Private Sub hourplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        clientwidth = 500
        clientheight = 600
        Me.ClientSize = New Size(clientwidth, clientheight)
        monthvar = manageappointment.monthvar
        yearvar = manageappointment.yearvar
        monthtxt = manageappointment.monthtext
        strDir = manageappointment.strDir
        calendarlocation = manageappointment.calendarlocation
        choosendate = monthvar & "/" & calendarlocation & "/" & yearvar
        manageappointment.Close()
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

    Private Sub hourplan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        mousex = e.X
        mousey = e.Y
    End Sub


    Public Sub hourplan_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' e.Graphics.DrawString("X." & mousex & vbCrLf & "Y." & mousey, Me.Font, Brushes.Yellow, 0, 0)
        'e.Graphics.DrawString(monthtxt & " " & calendarlocation & ", " & yearvar, Monthtitle, Brushes.Tan, (clientwidth / 2) - (Len(monthtxt)) - 140, 52)
        If mark = 1 Then
            e.Graphics.DrawString(saveinfo(1), labeling, tan, 15, 140)
            e.Graphics.DrawString(saveinfo(2), labeling, tan, 15, 180)
            e.Graphics.DrawString(saveinfo(10), labeling, tan, 15, 230)
            e.Graphics.DrawString(saveinfo(18), labeling, tan, 15, 280)
            If saveinfo2(27) = 10 Or saveinfo2(27) = 11 Then
                e.Graphics.DrawString(saveinfo(27) & "AM", labeling, tan, 15, 325)
            Else
                e.Graphics.DrawString(saveinfo(27) & "PM", labeling, tan, 15, 325)
            End If
            If saveinfo2(28) = 10 Or saveinfo2(28) = 11 Then
                e.Graphics.DrawString(saveinfo(28) & "AM", labeling, tan, 15, 375)
            Else
                e.Graphics.DrawString(saveinfo(28) & "PM", labeling, tan, 15, 375)
            End If

        End If
        If mark2 = 1 Then
            e.Graphics.DrawString(saveinfo2(1), labeling, tan, 293, 140)
            e.Graphics.DrawString(saveinfo2(2), labeling, tan, 293, 180)
            e.Graphics.DrawString(saveinfo2(10), labeling, tan, 293, 230)
            e.Graphics.DrawString(saveinfo2(18), labeling, tan, 293, 280)
            If saveinfo2(27) = 10 Or saveinfo2(27) = 11 Then
                e.Graphics.DrawString(saveinfo2(27) & "AM", labeling, tan, 293, 325)
            Else
                e.Graphics.DrawString(saveinfo2(27) & "PM", labeling, tan, 293, 325)
            End If
            If saveinfo2(28) = 10 Or saveinfo2(28) = 11 Then
                e.Graphics.DrawString(saveinfo2(28) & "AM", labeling, tan, 293, 375)
            Else
                e.Graphics.DrawString(saveinfo2(28) & "PM", labeling, tan, 293, 375)
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        manageappointment.Show()
        manageappointment.Activate()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        delapp()

        Start_Page.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delapp()

        Start_Page.Show()
        Me.Close()
    End Sub
End Class