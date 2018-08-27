Public Class painmap
    Dim timer As Stopwatch
    Dim backbuffer As Image
    Dim graphics As Graphics
    Dim clientwidth As Integer
    Dim clientheight As Integer
    Dim isrunning As Boolean = True
    Dim mousex As Integer
    Dim mousey As Integer
    Dim pb As New PictureBox
    Dim reccheck As Integer
    Dim redpen As New Pen(Color.Tan, 3)
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
    Dim arial As Font = New Font(New FontFamily("Papyrus"), 14)
    Dim arial2 As Font = New Font(New FontFamily("Papyrus"), 18)
    Private humanoutline As Image = My.Resources.humanoutlinered
    Private painlevel1 As Image = My.Resources.face1
    Private painlevel2 As Image = My.Resources.face2
    Private painlevel3 As Image = My.Resources.face3
    Private painlevel4 As Image = My.Resources.face4
    Private painlevel5 As Image = My.Resources.face5

    Dim location11 As String
    Dim locchoice As Integer
    Dim fclick As Integer
    Dim reccheck2 As Integer
    Dim buttonclick As Boolean = True
    Dim staylab1 As Integer
    Dim staylab2 As Integer
    Dim staylab3 As Integer
    Dim staylab4 As Integer
    Dim staylab5 As Integer
    Dim checkloc As Integer
    Dim locationyn As Integer

    Dim memcheck1 As Integer
    Dim memcheck2 As Integer
    Dim memcheck3 As Integer
    Dim memcheck4 As Integer
    Dim memcheck5 As Integer
    Dim memloccheck1 As Integer
    Dim memloccheck2 As Integer
    Dim memloccheck3 As Integer
    Dim memloccheck4 As Integer
    Dim memloccheck5 As Integer

    Public saveinfo2(23) As String
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            mainLoop()
        End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        clientwidth = 1000
        clientheight = 1000
        Me.ClientSize = New Size(clientwidth, clientheight)

        saveinfo2(0) = Questionair2.saveinfo2(0)
        saveinfo2(1) = Questionair2.saveinfo2(1)
        saveinfo2(2) = Questionair2.saveinfo2(2)
        saveinfo2(3) = Questionair2.saveinfo2(3)
        saveinfo2(4) = Questionair2.saveinfo2(4)
        saveinfo2(5) = Questionair2.saveinfo2(5)
        saveinfo2(6) = Questionair2.saveinfo2(6)
        saveinfo2(7) = Questionair2.saveinfo2(7)
        saveinfo2(8) = Questionair2.saveinfo2(8)
        saveinfo2(9) = Questionair2.saveinfo2(9)
        saveinfo2(10) = Questionair2.saveinfo2(10)
        saveinfo2(11) = Questionair2.saveinfo2(11)
        saveinfo2(12) = Questionair2.saveinfo2(12)
        saveinfo2(13) = Questionair2.saveinfo2(13)
        saveinfo2(14) = Questionair2.saveinfo2(14)
        saveinfo2(15) = Questionair2.saveinfo2(15)
        saveinfo2(16) = Questionair2.saveinfo2(16)
        saveinfo2(17) = Questionair2.saveinfo2(17)
        saveinfo2(18) = Questionair2.saveinfo2(18)

        saveinfo2(19) = "0"
        saveinfo2(20) = "0"
        saveinfo2(21) = "0"
        saveinfo2(22) = "0"
        saveinfo2(23) = "0"




        Questionair2.Close()
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
                checklocation()
            Loop
        End Sub

        Public Sub unpopulate()
            If staylab5 = 5 Then
                Staylabel5.Text = ""
                staylab5 = 0
            ElseIf staylab4 = 4 Then
                Staylabel4.Text = ""
                staylab4 = 0
            ElseIf staylab3 = 3 Then
                Staylabel3.Text = ""
                staylab3 = 0
            ElseIf staylab2 = 2 Then
                Staylabel2.Text = ""
                staylab2 = 0
            ElseIf staylab1 = 1 Then
                Staylabel1.Text = ""
                staylab1 = 0
                undoBtn.Hide()
            End If
        End Sub
        Public Sub checklocation()
        If mousex >= 210 And mousex <= 270 And mousey >= 8 And mousey <= 19 _
                Or mousex >= 200 And mousex <= 280 And mousey >= 20 And mousey <= 30 _
                Or mousex >= 195 And mousex <= 286 And mousey >= 29 And mousey <= 47 Then
            test.Text = "Top of the skull (rear)"
            test.Location = New Point(340, 30)
            reccheck = 1
            pb.Image = painlevel2

            displaypain()
        ElseIf mousex >= 185 And mousex <= 293 And mousey >= 48 And mousey <= 79 Then
            test.Text = "back of the skull (rear)"
            test.Location = New Point(330, 30)
            pb.Image = painlevel3
            reccheck = 2
            displaypain()
        ElseIf mousex >= 183 And mousex <= 196 And mousey >= 81 And mousey <= 117 Or
                mousex >= 278 And mousex <= 294 And mousey >= 80 And mousey <= 118 Then
            test.Text = "Ears"
            test.Location = New Point(455, 30)
            pb.Image = painlevel2
            reccheck = 3
            displaypain()
        ElseIf mousex >= 202 And mousex <= 269 And mousey >= 80 And mousey <= 118 Then
            test.Text = "Skull Base"
            test.Location = New Point(410, 30)
            pb.Image = painlevel4
            reccheck = 4
            displaypain()
        ElseIf mousex >= 207 And mousex <= 271 And mousey >= 119 And mousey <= 150 Then
            test.Text = "Neck"
            test.Location = New Point(448, 30)
            pb.Image = painlevel5
            reccheck = 5
            displaypain()
        ElseIf mousex >= 221 And mousex <= 266 And mousey >= 151 And mousey <= 438 Then
            test.Text = "Spine"
            test.Location = New Point(449, 30)
            pb.Image = painlevel1
            reccheck = 6
            displaypain()
        ElseIf mousex >= 149 And mousex <= 210 And mousey >= 164 And mousey <= 264 Or
                mousex >= 276 And mousex <= 332 And mousey >= 164 And mousey <= 261 Then
            test.Text = "Shoulder"
            test.Location = New Point(430, 30)
            pb.Image = painlevel4
            reccheck = 7
            displaypain()
        ElseIf mousex >= 103 And mousex <= 147 And mousey >= 185 And mousey <= 214 Or
               mousex >= 94 And mousex <= 148 And mousey >= 215 And mousey <= 267 Or
               mousex >= 335 And mousex <= 362 And mousey >= 188 And mousey <= 211 Or
               mousex >= 337 And mousex <= 378 And mousey >= 212 And mousey <= 262 Then
            test.Text = "Deltoid"
            test.Location = New Point(437, 30)
            pb.Image = painlevel5
            reccheck = 8
            displaypain()
        ElseIf mousex >= 95 And mousex <= 153 And mousey >= 268 And mousey <= 370 _
                Or mousex >= 325 And mousex <= 386 And mousey >= 263 And mousey <= 373 Then
            test.Text = "Elbow"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 9
            displaypain()
        ElseIf mousex >= 70 And mousex <= 125 And mousey >= 371 And mousey <= 415 _
                Or mousex >= 65 And mousex <= 115 And mousey >= 416 And mousey <= 465 Or
                mousex >= 347 And mousex <= 407 And mousey >= 374 And mousey <= 424 Or
                mousex >= 363 And mousex <= 416 And mousey >= 425 And mousey <= 470 Then
            test.Text = "Fore Arm (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 10
            displaypain()
        ElseIf mousex >= 55 And mousex <= 95 And mousey >= 466 And mousey <= 483 Or
               mousex >= 385 And mousex <= 434 And mousey >= 472 And mousey <= 496 Then
            test.Text = "wrist (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 11
            displaypain()
        ElseIf mousex >= 45 And mousex <= 91 And mousey >= 490 And mousey <= 541 Or
                    mousex >= 388 And mousex <= 440 And mousey >= 497 And mousey <= 544 Then
            test.Text = "Hand"
            test.Location = New Point(438, 30)
            pb.Image = painlevel4
            reccheck = 12
            displaypain()
        ElseIf mousex >= 22 And mousex <= 44 And mousey >= 495 And mousey <= 519 Or
               mousex >= 5 And mousex <= 33 And mousey >= 519 And mousey <= 542 Or
               mousex >= 20 And mousex <= 80 And mousey >= 542 And mousey <= 588 Or
               mousex >= 442 And mousex <= 458 And mousey >= 496 And mousey <= 521 Or
               mousex >= 459 And mousex <= 476 And mousey >= 511 And mousey <= 531 Or
               mousex >= 397 And mousex <= 462 And mousey >= 544 And mousey <= 592 Then
            test.Text = "fingers"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 13
            displaypain()
        ElseIf mousex >= 151 And mousex <= 211 And mousey >= 265 And mousey <= 343 Or
               mousex >= 157 And mousex <= 512 And mousey >= 344 And mousey <= 384 Or
               mousex >= 271 And mousex <= 321 And mousey >= 262 And mousey <= 343 Or
               mousex >= 275 And mousex <= 314 And mousey >= 344 And mousey <= 384 Then
            test.Text = "mid back"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 14
            displaypain()
        ElseIf mousex >= 161 And mousex <= 220 And mousey >= 285 And mousey <= 439 Or
                mousex >= 267 And mousex <= 317 And mousey >= 385 And mousey <= 439 Then
            test.Text = "lower back"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 15
            displaypain()
        ElseIf mousex >= 141 And mousex <= 338 And mousey >= 440 And mousey <= 545 Then
            test.Text = "buttocks"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 16
            displaypain()
        ElseIf mousex >= 206 And mousex <= 280 And mousey >= 549 And mousey <= 640 Then
            test.Text = "inner thigh"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 17
            displaypain()
        ElseIf mousex >= 151 And mousex <= 205 And mousey >= 549 And mousey <= 695 Or
            mousex >= 151 And mousex <= 319 And mousey >= 549 And mousey <= 695 Or
            mousex >= 280 And mousex <= 335 And mousey >= 549 And mousey <= 695 Then
            test.Text = "Thigh (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel4
            reccheck = 18
            displaypain()
        ElseIf mousex >= 160 And mousex <= 322 And mousey >= 696 And mousey <= 830 Then
            test.Text = "Knee (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 19
            displaypain()
        ElseIf mousex >= 172 And mousex <= 310 And mousey >= 831 And mousey <= 900 Then
            test.Text = " Shin (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 20
            displaypain()
        ElseIf mousex >= 170 And mousex <= 312 And mousey >= 901 And mousey <= 950 Then
            test.Text = "Ankle (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 21
            displaypain()
        ElseIf mousex >= 152 And mousex <= 333 And mousey >= 951 And mousey <= 990 Then
            test.Text = "foot (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 22
            displaypain()
        ElseIf mousex >= 710 And mousex <= 800 And mousey >= 0 And mousey <= 30 Then
            test.Text = "foot (rear)"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 23
            displaypain()
        ElseIf mousex >= 733 And mousex <= 785 And mousey >= 31 And mousey <= 80 Or
                    mousex >= 734 And mousex <= 784 And mousey >= 81 And mousey <= 120 Or
                    mousex >= 731 And mousex <= 777 And mousey >= 121 And mousey <= 139 Or
                    mousex >= 707 And mousex <= 733 And mousey >= 31 And mousey <= 120 Or
                    mousex >= 786 And mousex <= 806 And mousey >= 31 And mousey <= 67 Then
            test.Text = "Face"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 24
            displaypain()
        ElseIf mousex >= 690 And mousex <= 706 And mousey >= 65 And mousey <= 107 Or
                    mousex >= 786 And mousex <= 809 And mousey >= 68 And mousey <= 108 Then
            test.Text = "ears"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 25
            displaypain()
        ElseIf mousex >= 714 And mousex <= 730 And mousey >= 121 And mousey <= 140 Or
                    mousex >= 714 And mousex <= 788 And mousey >= 141 And mousey <= 190 Or
                mousex >= 778 And mousex <= 787 And mousey >= 121 And mousey <= 140 Then
            test.Text = "neck"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 26
            displaypain()
        ElseIf mousex >= 666 And mousex <= 689 And mousey >= 160 And mousey <= 190 Or
                mousex >= 690 And mousex <= 713 And mousey >= 140 And mousey <= 190 Or
                mousex >= 789 And mousex <= 815 And mousey >= 140 And mousey <= 190 Or
            mousex >= 816 And mousex <= 835 And mousey >= 160 And mousey <= 190 Then
            test.Text = "Clavical"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 27
            displaypain()
        ElseIf mousex >= 650 And mousex <= 680 And mousey >= 238 And mousey <= 297 Or
            mousex >= 835 And mousex <= 864 And mousey >= 238 And mousey <= 298 Then
            test.Text = "Armpit"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 28
            displaypain()
        ElseIf mousex >= 636 And mousex <= 665 And mousey >= 299 And mousey <= 326 Or
                    mousex >= 636 And mousex <= 650 And mousey >= 327 And mousey <= 357 Or
                    mousex >= 838 And mousex <= 869 And mousey >= 298 And mousey <= 327 Or
                    mousex >= 844 And mousex <= 869 And mousey >= 328 And mousey <= 356 Then
            test.Text = "inner arm"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 29
            displaypain()
        ElseIf mousex >= 604 And mousex <= 665 And mousey >= 176 And mousey <= 237 Or
                mousex >= 841 And mousex <= 890 And mousey >= 176 And mousey <= 237 Then
            test.Text = "Shoulder"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 30
            displaypain()
        ElseIf mousex >= 605 And mousex <= 649 And mousey >= 238 And mousey <= 295 Or
                mousex >= 595 And mousex <= 635 And mousey >= 296 And mousey <= 357 Or
                mousex >= 870 And mousex <= 909 And mousey >= 295 And mousey <= 357 Or
                mousex >= 865 And mousex <= 894 And mousey >= 238 And mousey <= 294 Then
            test.Text = "Bicept"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 31
            displaypain()
        ElseIf mousex >= 585 And mousex <= 645 And mousey >= 358 And mousey <= 406 Or
                mousex >= 858 And mousex <= 923 And mousey >= 358 And mousey <= 406 Then
            test.Text = "elbow front"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 32
            displaypain()
        ElseIf mousex >= 573 And mousex <= 635 And mousey >= 407 And mousey <= 455 Or
            mousex >= 870 And mousex <= 930 And mousey >= 407 And mousey <= 455 Then
            test.Text = "fore arm front"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 33
            displaypain()
        ElseIf mousex >= 565 And mousex <= 615 And mousey >= 456 And mousey <= 475 Or
                 mousex >= 888 And mousex <= 944 And mousey >= 456 And mousey <= 475 Then
            test.Text = "Wrist"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 34
            displaypain()
        ElseIf mousex >= 520 And mousex <= 610 And mousey >= 477 And mousey <= 580 Or
             mousex >= 899 And mousex <= 995 And mousey >= 477 And mousey <= 580 Then
            test.Text = "Hand"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 35
            displaypain()
        ElseIf mousex >= 666 And mousex <= 840 And mousey >= 191 And mousey <= 237 Or
            mousex >= 681 And mousex <= 834 And mousey >= 238 And mousey <= 296 Or
            mousex >= 715 And mousex <= 785 And mousey >= 297 And mousey <= 348 Or
            mousex >= 715 And mousex <= 734 And mousey >= 349 And mousey <= 379 Or
            mousex >= 766 And mousex <= 785 And mousey >= 349 And mousey <= 379 Then
            test.Text = "Chest Sternum"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 36
            displaypain()
        ElseIf mousex >= 735 And mousex <= 765 And mousey >= 344 And mousey <= 379 Then
            test.Text = "Xiphoid process"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 37
            displaypain()
        ElseIf mousex >= 666 And mousex <= 714 And mousey >= 297 And mousey <= 379 Or
                mousex >= 786 And mousex <= 835 And mousey >= 297 And mousey <= 379 Then
            test.Text = "Outer Ribs"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 38
            displaypain()
        ElseIf mousex >= 666 And mousex <= 835 And mousey >= 380 And mousey <= 435 Then
            test.Text = "Abdomen"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 39
            displaypain()
        ElseIf mousex >= 713 And mousex <= 791 And mousey >= 436 And mousey <= 476 Then
            test.Text = "Middriff"
            test.Location = New Point(438, 30)
            pb.Image = painlevel4
            reccheck = 40
            displaypain()
        ElseIf mousex >= 657 And mousex <= 712 And mousey >= 436 And mousey <= 518 Or
            mousex >= 792 And mousex <= 852 And mousey >= 436 And mousey <= 518 Then
            test.Text = "Hips"
            test.Location = New Point(438, 30)
            pb.Image = painlevel3
            reccheck = 41
            displaypain()
        ElseIf mousex >= 713 And mousex <= 728 And mousey >= 477 And mousey <= 529 Or
                    mousex >= 779 And mousex <= 792 And mousey >= 477 And mousey <= 529 Or
                mousex >= 713 And mousex <= 791 And mousey >= 529 And mousey <= 593 Then
            test.Text = "innerthigh"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 42
            displaypain()
        ElseIf mousex >= 729 And mousex <= 778 And mousey >= 477 And mousey <= 528 Then
            test.Text = "crotch"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 43
            displaypain()
        ElseIf mousex >= 658 And mousex <= 711 And mousey >= 519 And mousey <= 682 Or
        mousex >= 711 And mousex <= 746 And mousey >= 594 And mousey <= 682 Or
        mousex >= 794 And mousex <= 854 And mousey >= 519 And mousey <= 682 Or
        mousex >= 761 And mousex <= 793 And mousey >= 594 And mousey <= 682 Then
            test.Text = "thigh"
            test.Location = New Point(438, 30)
            pb.Image = painlevel5
            reccheck = 44
            displaypain()
        ElseIf mousex >= 675 And mousex <= 745 And mousey >= 683 And mousey <= 737 Or
                mousex >= 764 And mousex <= 831 And mousey >= 683 And mousey <= 737 Then
            test.Text = "knee"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 45
            displaypain()
        ElseIf mousex >= 673 And mousex <= 744 And mousey >= 738 And mousey <= 853 Or
            mousex >= 765 And mousex <= 836 And mousey >= 738 And mousey <= 853 Or
                mousex >= 687 And mousex <= 732 And mousey >= 854 And mousey <= 909 Or
        mousex >= 778 And mousex <= 820 And mousey >= 854 And mousey <= 909 Then
            test.Text = "Shin"
            test.Location = New Point(438, 30)
            pb.Image = painlevel4
            reccheck = 46
            displaypain()
        ElseIf mousex >= 685 And mousex <= 730 And mousey >= 910 And mousey <= 938 Or
            mousex >= 779 And mousex <= 824 And mousey >= 910 And mousey <= 938 Then
            test.Text = "Ankle"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 47
            displaypain()
        ElseIf mousex >= 673 And mousex <= 731 And mousey >= 939 And mousey <= 959 Or
        mousex >= 779 And mousex <= 829 And mousey >= 939 And mousey <= 959 Then
            test.Text = "Feet"
            test.Location = New Point(438, 30)
            pb.Image = painlevel2
            reccheck = 48
            displaypain()

        ElseIf mousex >= 668 And mousex <= 736 And mousey >= 960 And mousey <= 979 Or
        mousex >= 778 And mousex <= 845 And mousey >= 960 And mousey <= 979 Then
            test.Text = "toes"
            test.Location = New Point(438, 30)
            pb.Image = painlevel1
            reccheck = 49
            displaypain()

        Else
            test.Text = ""
                pb.Visible = False
                reccheck = 0
            End If

        End Sub
        Private Sub displaypain()
            Controls.Add(pb)
            pb.Location = New Point(410, 70)
            pb.Size = New Size(150, 150)
            pb.Visible = True
        End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If buttonclick = True Then
            buttonclick = False
            reccheck2 = 50

        ElseIf buttonclick = False Then
            buttonclick = True
            reccheck2 = 0
        End If

    End Sub

    Public Sub populate()

        If staylab1 = 0 And locchoice = 1 Then
            Staylabel1.Show()
            Staylabel1.Text = location11
            staylab1 = 1
            locchoice = 0
            undoBtn.Show()
        ElseIf staylab2 = 0 And locchoice = 1 Then
            Staylabel2.Show()
            Staylabel2.Text = location11
            staylab2 = 2
            locchoice = 0
            locationyn = 0
        ElseIf staylab3 = 0 And locchoice = 1 Then
            Staylabel3.Show()
            Staylabel3.Text = location11
            staylab3 = 3
            locchoice = 0
        ElseIf staylab4 = 0 And locchoice = 1 Then
            Staylabel4.Show()
            Staylabel4.Text = location11
            staylab4 = 4
            locchoice = 0
        ElseIf staylab5 = 0 And locchoice = 1 Then
            Staylabel5.Show()
            Staylabel5.Text = location11
            staylab5 = 5
            locchoice = 0
        End If
    End Sub
    Private Sub messbox()
        locationyn = 1
        locchoice = 1
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If mousex >= 210 And mousex <= 270 And mousey >= 8 And mousey <= 19 _
                Or mousex >= 200 And mousex <= 280 And mousey >= 20 And mousey <= 30 _
                Or mousex >= 195 And mousex <= 286 And mousey >= 29 And mousey <= 47 Then
            location11 = "Top of the skull (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 185 And mousex <= 293 And mousey >= 48 And mousey <= 79 Then
            location11 = "back of the skull (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 183 And mousex <= 196 And mousey >= 81 And mousey <= 117 Or
                mousex >= 278 And mousex <= 294 And mousey >= 80 And mousey <= 118 Then
            location11 = "Ears"
            savelocation()
            messbox()
        ElseIf mousex >= 202 And mousex <= 269 And mousey >= 80 And mousey <= 118 Then
            location11 = "Skull Base"
            savelocation()
            messbox()
        ElseIf mousex >= 207 And mousex <= 271 And mousey >= 119 And mousey <= 150 Then
            location11 = "Neck"
            savelocation()
            messbox()
        ElseIf mousex >= 221 And mousex <= 266 And mousey >= 151 And mousey <= 438 Then
            location11 = "Spine"
            savelocation()
            messbox()
        ElseIf mousex >= 149 And mousex <= 210 And mousey >= 164 And mousey <= 264 Or
            mousex >= 276 And mousex <= 332 And mousey >= 164 And mousey <= 261 Then
            location11 = "Shoulder"
            savelocation()
            messbox()
        ElseIf mousex >= 103 And mousex <= 147 And mousey >= 185 And mousey <= 214 Or
                mousex >= 94 And mousex <= 148 And mousey >= 215 And mousey <= 267 Or
                mousex >= 335 And mousex <= 362 And mousey >= 188 And mousey <= 211 Or
                mousex >= 337 And mousex <= 378 And mousey >= 212 And mousey <= 262 Then
            location11 = "Deltoid"
            savelocation()
            messbox()
        ElseIf mousex >= 95 And mousex <= 153 And mousey >= 268 And mousey <= 370 _
            Or mousex >= 325 And mousex <= 386 And mousey >= 263 And mousey <= 373 Then
            location11 = "Elbow"
            savelocation()
            messbox()
        ElseIf mousex >= 70 And mousex <= 125 And mousey >= 371 And mousey <= 415 _
            Or mousex >= 65 And mousex <= 115 And mousey >= 416 And mousey <= 465 Or
            mousex >= 347 And mousex <= 407 And mousey >= 374 And mousey <= 424 Or
            mousex >= 363 And mousex <= 416 And mousey >= 425 And mousey <= 470 Then
            location11 = "Fore Arm (rear)"
            messbox()
        ElseIf mousex >= 55 And mousex <= 95 And mousey >= 466 And mousey <= 483 Or
                mousex >= 385 And mousex <= 434 And mousey >= 472 And mousey <= 496 Then
            location11 = "wrist (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 45 And mousex <= 91 And mousey >= 490 And mousey <= 541 Or
                mousex >= 388 And mousex <= 440 And mousey >= 497 And mousey <= 544 Then
            location11 = "Hand"
            savelocation()
            messbox()
        ElseIf mousex >= 22 And mousex <= 44 And mousey >= 495 And mousey <= 519 Or
                mousex >= 5 And mousex <= 33 And mousey >= 519 And mousey <= 542 Or
                mousex >= 20 And mousex <= 80 And mousey >= 542 And mousey <= 588 Or
                mousex >= 442 And mousex <= 458 And mousey >= 496 And mousey <= 521 Or
                mousex >= 459 And mousex <= 476 And mousey >= 511 And mousey <= 531 Or
                mousex >= 397 And mousex <= 462 And mousey >= 544 And mousey <= 592 Then
            location11 = "fingers"
            savelocation()
            messbox()
        ElseIf mousex >= 151 And mousex <= 211 And mousey >= 265 And mousey <= 343 Or
                mousex >= 157 And mousex <= 512 And mousey >= 344 And mousey <= 384 Or
                mousex >= 271 And mousex <= 321 And mousey >= 262 And mousey <= 343 Or
                mousex >= 275 And mousex <= 314 And mousey >= 344 And mousey <= 384 Then
            location11 = "mid back"
            savelocation()
            messbox()
        ElseIf mousex >= 161 And mousex <= 220 And mousey >= 285 And mousey <= 439 Or
            mousex >= 267 And mousex <= 317 And mousey >= 385 And mousey <= 439 Then
            location11 = "lower back"
            savelocation()
            messbox()
        ElseIf mousex >= 141 And mousex <= 338 And mousey >= 440 And mousey <= 545 Then
            location11 = "buttocks"
            savelocation()
            messbox()
        ElseIf mousex >= 206 And mousex <= 280 And mousey >= 549 And mousey <= 640 Then
            location11 = "inner thigh"
            savelocation()
            messbox()
        ElseIf mousex >= 151 And mousex <= 205 And mousey >= 549 And mousey <= 695 Or
        mousex >= 151 And mousex <= 319 And mousey >= 549 And mousey <= 695 Or
        mousex >= 280 And mousex <= 335 And mousey >= 549 And mousey <= 695 Then
            location11 = "Thigh (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 160 And mousex <= 322 And mousey >= 696 And mousey <= 830 Then
            location11 = "Knee (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 172 And mousex <= 310 And mousey >= 831 And mousey <= 900 Then
            location11 = " Shin (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 170 And mousex <= 312 And mousey >= 901 And mousey <= 950 Then
            location11 = "Ankle (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 152 And mousex <= 333 And mousey >= 951 And mousey <= 990 Then
            location11 = "foot (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 710 And mousex <= 800 And mousey >= 0 And mousey <= 30 Then
            location11 = "foot (rear)"
            savelocation()
            messbox()
        ElseIf mousex >= 733 And mousex <= 785 And mousey >= 31 And mousey <= 80 Or
                mousex >= 734 And mousex <= 784 And mousey >= 81 And mousey <= 120 Or
                mousex >= 731 And mousex <= 777 And mousey >= 121 And mousey <= 139 Or
                mousex >= 707 And mousex <= 733 And mousey >= 31 And mousey <= 120 Or
                mousex >= 786 And mousex <= 806 And mousey >= 31 And mousey <= 67 Then
            location11 = "Face"
            savelocation()
            messbox()
        ElseIf mousex >= 690 And mousex <= 706 And mousey >= 65 And mousey <= 107 Or
                mousex >= 786 And mousex <= 809 And mousey >= 68 And mousey <= 108 Then
            location11 = "ears"
            savelocation()
            messbox()
        ElseIf mousex >= 714 And mousex <= 730 And mousey >= 121 And mousey <= 140 Or
                mousex >= 714 And mousex <= 788 And mousey >= 141 And mousey <= 190 Or
            mousex >= 778 And mousex <= 787 And mousey >= 121 And mousey <= 140 Then
            location11 = "neck"
            savelocation()
            messbox()
        ElseIf mousex >= 666 And mousex <= 689 And mousey >= 160 And mousey <= 190 Or
            mousex >= 690 And mousex <= 713 And mousey >= 140 And mousey <= 190 Or
            mousex >= 789 And mousex <= 815 And mousey >= 140 And mousey <= 190 Or
        mousex >= 816 And mousex <= 835 And mousey >= 160 And mousey <= 190 Then
            location11 = "Clavical"
            savelocation()
            messbox()
        ElseIf mousex >= 650 And mousex <= 680 And mousey >= 238 And mousey <= 297 Or
        mousex >= 835 And mousex <= 864 And mousey >= 238 And mousey <= 298 Then
            location11 = "Armpit"
            savelocation()
            messbox()
        ElseIf mousex >= 636 And mousex <= 665 And mousey >= 299 And mousey <= 326 Or
                mousex >= 636 And mousex <= 650 And mousey >= 327 And mousey <= 357 Or
                mousex >= 838 And mousex <= 869 And mousey >= 298 And mousey <= 327 Or
                mousex >= 844 And mousex <= 869 And mousey >= 328 And mousey <= 356 Then
            messbox()
        ElseIf mousex >= 604 And mousex <= 665 And mousey >= 176 And mousey <= 237 Or
            mousex >= 841 And mousex <= 890 And mousey >= 176 And mousey <= 237 Then
            location11 = "Shoulder"
            savelocation()
            messbox()
        ElseIf mousex >= 605 And mousex <= 649 And mousey >= 238 And mousey <= 295 Or
            mousex >= 595 And mousex <= 635 And mousey >= 296 And mousey <= 357 Or
            mousex >= 870 And mousex <= 909 And mousey >= 295 And mousey <= 357 Or
            mousex >= 865 And mousex <= 894 And mousey >= 238 And mousey <= 294 Then
            location11 = "Bicept"
            savelocation()
            messbox()
        ElseIf mousex >= 585 And mousex <= 645 And mousey >= 358 And mousey <= 406 Or
            mousex >= 858 And mousex <= 923 And mousey >= 358 And mousey <= 406 Then
            location11 = "elbow front"
            savelocation()
            messbox()
        ElseIf mousex >= 573 And mousex <= 635 And mousey >= 407 And mousey <= 455 Or
        mousex >= 870 And mousex <= 930 And mousey >= 407 And mousey <= 455 Then
            location11 = "fore arm front"
            savelocation()
            messbox()
        ElseIf mousex >= 565 And mousex <= 615 And mousey >= 456 And mousey <= 475 Or
             mousex >= 888 And mousex <= 944 And mousey >= 456 And mousey <= 475 Then
            location11 = "Wrist"
            savelocation()
            messbox()
        ElseIf mousex >= 520 And mousex <= 610 And mousey >= 477 And mousey <= 580 Or
         mousex >= 899 And mousex <= 995 And mousey >= 477 And mousey <= 580 Then
            location11 = "Hand"
            savelocation()
            messbox()
        ElseIf mousex >= 666 And mousex <= 840 And mousey >= 191 And mousey <= 237 Or
        mousex >= 681 And mousex <= 834 And mousey >= 238 And mousey <= 296 Or
        mousex >= 715 And mousex <= 785 And mousey >= 297 And mousey <= 348 Or
        mousex >= 715 And mousex <= 734 And mousey >= 349 And mousey <= 379 Or
        mousex >= 766 And mousex <= 785 And mousey >= 349 And mousey <= 379 Then
            location11 = "Chest Sternum"
            savelocation()
            messbox()
        ElseIf mousex >= 735 And mousex <= 765 And mousey >= 344 And mousey <= 379 Then
            location11 = "Xiphoid process"
            savelocation()
            messbox()
        ElseIf mousex >= 666 And mousex <= 714 And mousey >= 297 And mousey <= 379 Or
            mousex >= 786 And mousex <= 835 And mousey >= 297 And mousey <= 379 Then
            location11 = "Outer Ribs"
            savelocation()
            messbox()
        ElseIf mousex >= 666 And mousex <= 835 And mousey >= 380 And mousey <= 435 Then
            location11 = "Abdomen"
            savelocation()
            messbox()
        ElseIf mousex >= 713 And mousex <= 791 And mousey >= 436 And mousey <= 476 Then
            location11 = "Middriff"
            savelocation()
            messbox()
        ElseIf mousex >= 657 And mousex <= 712 And mousey >= 436 And mousey <= 518 Or
        mousex >= 792 And mousex <= 852 And mousey >= 436 And mousey <= 518 Then
            location11 = "Hips"
            savelocation()
            messbox()
        ElseIf mousex >= 713 And mousex <= 728 And mousey >= 477 And mousey <= 529 Or
                mousex >= 779 And mousex <= 792 And mousey >= 477 And mousey <= 529 Or
            mousex >= 713 And mousex <= 791 And mousey >= 529 And mousey <= 593 Then
            location11 = "innerthigh"
            savelocation()
            messbox()
        ElseIf mousex >= 729 And mousex <= 778 And mousey >= 477 And mousey <= 528 Then
            location11 = "crotch"
            savelocation()
            messbox()
        ElseIf mousex >= 658 And mousex <= 711 And mousey >= 519 And mousey <= 682 Or
            mousex >= 711 And mousex <= 746 And mousey >= 594 And mousey <= 682 Or
            mousex >= 794 And mousex <= 854 And mousey >= 519 And mousey <= 682 Or
            mousex >= 761 And mousex <= 793 And mousey >= 594 And mousey <= 682 Then
            location11 = "thigh"
            savelocation()
            messbox()
        ElseIf mousex >= 675 And mousex <= 745 And mousey >= 683 And mousey <= 737 Or
                mousex >= 764 And mousex <= 831 And mousey >= 683 And mousey <= 737 Then
            location11 = "knee"
            savelocation()
            messbox()
        ElseIf mousex >= 673 And mousex <= 744 And mousey >= 738 And mousey <= 853 Or
                    mousex >= 765 And mousex <= 836 And mousey >= 738 And mousey <= 853 Or
                    mousex >= 687 And mousex <= 732 And mousey >= 854 And mousey <= 909 Or
                    mousex >= 778 And mousex <= 820 And mousey >= 854 And mousey <= 909 Then
            location11 = "Shin"
            savelocation()
            messbox()
        ElseIf mousex >= 685 And mousex <= 730 And mousey >= 910 And mousey <= 938 Or
                mousex >= 779 And mousex <= 824 And mousey >= 910 And mousey <= 938 Then
            location11 = "Ankle"
            savelocation()
            messbox()
        ElseIf mousex >= 673 And mousex <= 731 And mousey >= 939 And mousey <= 959 Or
                mousex >= 779 And mousex <= 829 And mousey >= 939 And mousey <= 959 Then
            location11 = "Feet"
            savelocation()
            messbox()
        ElseIf mousex >= 668 And mousex <= 736 And mousey >= 960 And mousey <= 979 Or
                    mousex >= 778 And mousex <= 845 And mousey >= 960 And mousey <= 979 Then
            location11 = "toes"
            savelocation()
            messbox()
        ElseIf mousex > 415 And mousex <= 485 And mousey >= 905 And mousey <= 935 And locationyn = 1 Then
            populate()

            locationyn = 0
        ElseIf mousex > 535 And mousex <= 605 And mousey >= 905 And mousey <= 935 And locationyn = 1 Then
            locationyn = 0
            checkloc = 0
        Else
            location11 = ""
            pb.Visible = False
            reccheck = 0
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        mousex = e.X
        mousey = e.Y

    End Sub
    Public Sub savelocation()

        If memcheck1 = 0 Then
            memloccheck1 = reccheck
            memcheck1 = 1
        ElseIf memcheck2 = 0 And memcheck1 <> 0 Then
            memloccheck2 = reccheck
            memcheck2 = 1
        ElseIf memcheck3 = 0 And memcheck1 <> 0 And memcheck2 <> 0 Then
            memloccheck3 = reccheck
            memcheck3 = 1
        ElseIf memcheck4 = 0 And memcheck1 <> 0 And memcheck2 <> 0 And memcheck3 <> 0 Then
            memloccheck4 = reccheck
            memcheck4 = 1
        ElseIf memcheck5 = 0 And memcheck1 <> 0 And memcheck2 <> 0 And memcheck3 <> 0 And memcheck4 <> 0 Then
            memloccheck5 = reccheck
            memcheck5 = 1
        End If
    End Sub
    Public Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim x As Integer
        e.Graphics.DrawImage(humanoutline, 0, 0, 1000, 1000)
        'e.Graphics.DrawString("X." & mousex & vbCrLf & "Y." & mousey, Me.Font, Brushes.Yellow, 0, 0)
        e.Graphics.DrawString("Click on the locations" & vbCrLf & "  you would like your" & vbCrLf & "  tatoo to be located. ", arial, Brushes.Tan, 400, 325)
        If locationyn = 1 Then
            e.Graphics.DrawRectangle(Pens.Yellow, 410, 830, 200, 110)
            e.Graphics.FillRectangle(tanBrush, 411, 831, 199, 109)

            e.Graphics.DrawRectangle(Pens.Brown, 415, 905, 70, 30)
            e.Graphics.FillRectangle(yellowBrush, 415, 905, 70, 30)
            e.Graphics.DrawString("Yes ", arial2, Brushes.Red, 425, 905)

            e.Graphics.DrawRectangle(Pens.Brown, 535, 905, 70, 30)
            e.Graphics.FillRectangle(yellowBrush, 535, 905, 70, 30)
            e.Graphics.DrawString("No ", arial2, Brushes.Red, 550, 905)



            e.Graphics.DrawString("You have chosen: ", arial, Brushes.Red, 430, 830)
            If Len(location11) = 4 Then
                e.Graphics.DrawString(location11, arial, Brushes.Blue, 475, 850)
            ElseIf Len(location11) <= 15 And Len(location11) >= 11 Then
                e.Graphics.DrawString(location11, arial, Brushes.Blue, 440, 850)
            ElseIf Len(location11) = 24 Or Len(location11) = 23 Then
                e.Graphics.DrawString(location11, arial, Brushes.Blue, 415, 850)
            Else
                x = Len(location11)
                e.Graphics.DrawString(location11, arial, Brushes.Blue, 480 - x, 850)

            End If
            e.Graphics.DrawString("Is this correct?", arial, Brushes.Red, 450, 870)

        End If


        e.Graphics.DrawRectangle(Pens.DarkGoldenrod, 350, 600, 300, 350)
        e.Graphics.DrawRectangle(Pens.DarkGoldenrod, 351, 601, 298, 349)
        e.Graphics.DrawRectangle(Pens.DarkGoldenrod, 352, 602, 297, 349)

        e.Graphics.DrawRectangle(Pens.Gold, 353, 603, 296, 347)
        e.Graphics.DrawRectangle(Pens.Gold, 354, 604, 295, 346)
        e.Graphics.DrawRectangle(Pens.Gold, 355, 605, 294, 345)

        e.Graphics.DrawRectangle(Pens.LightGoldenrodYellow, 356, 606, 293, 344)
        e.Graphics.DrawRectangle(Pens.LightGoldenrodYellow, 357, 607, 292, 343)
        e.Graphics.DrawRectangle(Pens.LightGoldenrodYellow, 358, 608, 291, 342)

        e.Graphics.DrawRectangle(Pens.PaleGoldenrod, 359, 609, 290, 341)
        e.Graphics.DrawRectangle(Pens.PaleGoldenrod, 360, 610, 289, 340)
        e.Graphics.DrawRectangle(Pens.PaleGoldenrod, 361, 611, 287, 339)

        Dim forehead1 As New Point(740, 7)
        Dim forehead2 As New Point(728, 14)
        Dim forehead3 As New Point(728, 12)
        Dim forehead4 As New Point(716, 30)
        Dim forehead5 As New Point(793, 30)
        Dim forehead6 As New Point(787, 20)
        Dim forehead7 As New Point(772, 8)
        Dim forehead8 As New Point(758, 5)
        Dim forehead As Point() = {forehead1, forehead2, forehead3, forehead4, forehead5, forehead6, forehead7, forehead8}

        Dim face1 As New Point(714, 31)
        Dim face2 As New Point(708, 45)
        Dim face3 As New Point(708, 98)
        Dim face4 As New Point(719, 109)
        Dim face5 As New Point(740, 134)
        Dim face6 As New Point(756, 139)
        Dim face7 As New Point(770, 134)
        Dim face8 As New Point(783, 116)
        Dim face9 As New Point(783, 104)
        Dim face10 As New Point(799, 67)
        Dim face11 As New Point(798, 47)
        Dim face12 As New Point(799, 48)
        Dim face13 As New Point(792, 31)
        Dim face As Point() = {face1, face2, face3, face4, face5, face6, face7, face8, face9, face10, face12, face12, face13}

        Dim rear1 As New Point(706, 68)
        Dim rear2 As New Point(704, 72)
        Dim rear3 As New Point(696, 76)
        Dim rear4 As New Point(697, 83)
        Dim rear5 As New Point(707, 99)
        Dim rear As Point() = {rear1, rear2, rear3, rear4, rear5}

        Dim lear1 As New Point(800, 68)
        Dim lear2 As New Point(786, 106)
        Dim lear3 As New Point(799, 103)
        Dim lear4 As New Point(803, 85)
        Dim lear5 As New Point(806, 79)
        Dim lear6 As New Point(802, 68)
        Dim lear As Point() = {lear1, lear2, lear3, lear4, lear5, lear6}

        Dim neck1 As New Point(722, 122)
        Dim neck2 As New Point(720, 141)
        Dim neck3 As New Point(715, 147)
        Dim neck4 As New Point(715, 190)
        Dim neck5 As New Point(791, 190)
        Dim neck6 As New Point(791, 148)
        Dim neck7 As New Point(783, 134)
        Dim neck8 As New Point(782, 129)
        Dim neck9 As New Point(776, 140)
        Dim neck10 As New Point(766, 145)
        Dim neck11 As New Point(750, 147)
        Dim neck12 As New Point(750, 147)
        Dim neck13 As New Point(732, 134)
        Dim neck14 As New Point(723, 122)
        Dim neck As Point() = {neck1, neck2, neck3, neck4, neck5, neck6, neck7, neck8, neck9, neck10, neck11, neck12, neck13, neck14}

        Dim clavicalr1 As New Point(712, 150)
        Dim clavicalr2 As New Point(678, 169)
        Dim clavicalr3 As New Point(666, 174)
        Dim clavicalr4 As New Point(666, 190)
        Dim clavicalr5 As New Point(713, 190)
        Dim clavicalr6 As New Point(713, 151)
        Dim clavicalr As Point() = {clavicalr1, clavicalr2, clavicalr3, clavicalr4, clavicalr5, clavicalr6}

        Dim clavicall1 As New Point(792, 150)
        Dim clavicall2 As New Point(792, 190)
        Dim clavicall3 As New Point(839, 190)
        Dim clavicall4 As New Point(839, 176)
        Dim clavicall5 As New Point(793, 150)
        Dim clavicall As Point() = {clavicall1, clavicall2, clavicall3, clavicall4, clavicall5}

        Dim armpitr1 As New Point(650, 237)
        Dim armpitr2 As New Point(650, 297)
        Dim armpitr3 As New Point(680, 297)
        Dim armpitr4 As New Point(680, 237)
        Dim armpitr As Point() = {armpitr1, armpitr2, armpitr3, armpitr4}

        Dim armpitl1 As New Point(835, 238)
        Dim armpitl2 As New Point(835, 296)
        Dim armpitl3 As New Point(865, 296)
        Dim armpitl4 As New Point(865, 238)
        Dim armpitl As Point() = {armpitl1, armpitl2, armpitl3, armpitl4}

        Dim innerarmr1 As New Point(639, 355)
        Dim innerarmr2 As New Point(635, 355)
        Dim innerarmr3 As New Point(635, 298)
        Dim innerarmr4 As New Point(662, 298)
        Dim innerarmr5 As New Point(660, 304)
        Dim innerarmr6 As New Point(638, 354)
        Dim innerarmr As Point() = {innerarmr1, innerarmr2, innerarmr3, innerarmr4, innerarmr5, innerarmr6}

        Dim innerarml1 As New Point(858, 356)
        Dim innerarml2 As New Point(868, 356)
        Dim innerarml3 As New Point(869, 297)
        Dim innerarml4 As New Point(840, 297)
        Dim innerarml5 As New Point(840, 303)
        Dim innerarml6 As New Point(857, 356)
        Dim innerarml As Point() = {innerarml1, innerarml2, innerarml3, innerarml4, innerarml5, innerarml6}

        Dim shoulder1r As New Point(656, 177)
        Dim shoulder2r As New Point(634, 192)
        Dim shoulder3r As New Point(625, 202)
        Dim shoulder4r As New Point(611, 237)
        Dim shoulder5r As New Point(666, 237)
        Dim shoulder6r As New Point(666, 173)
        Dim shoulderr As Point() = {shoulder1r, shoulder2r, shoulder3r, shoulder4r, shoulder5r, shoulder6r}

        Dim shoulder1l As New Point(840, 177)
        Dim shoulder2l As New Point(854, 184)
        Dim shoulder3l As New Point(877, 209)
        Dim shoulder4l As New Point(884, 237)
        Dim shoulder5l As New Point(840, 237)
        Dim shoulderl As Point() = {shoulder1l, shoulder2l, shoulder3l, shoulder4l, shoulder5l}

        Dim bicept1r As New Point(612, 237)
        Dim bicept2r As New Point(613, 287)
        Dim bicept3r As New Point(596, 355)
        Dim bicept4r As New Point(635, 355)
        Dim bicept5r As New Point(635, 297)
        Dim bicept6r As New Point(649, 297)
        Dim bicept7r As New Point(648, 237)
        Dim biceptr As Point() = {bicept1r, bicept2r, bicept3r, bicept4r, bicept5r, bicept6r, bicept7r}

        Dim bicept1l As New Point(883, 237)
        Dim bicept2l As New Point(885, 252)
        Dim bicept3l As New Point(886, 274)
        Dim bicept4l As New Point(898, 336)
        Dim bicept5l As New Point(906, 355)
        Dim bicept6l As New Point(869, 355)
        Dim bicept7l As New Point(869, 296)
        Dim bicept8l As New Point(865, 295)
        Dim bicept9l As New Point(865, 237)
        Dim biceptl As Point() = {bicept1l, bicept2l, bicept3l, bicept4l, bicept5l, bicept6l, bicept7l, bicept8l, bicept9l}

        Dim felbow1r As New Point(597, 357)
        Dim felbow2r As New Point(586, 405)
        Dim felbow3r As New Point(631, 405)
        Dim felbow4r As New Point(638, 386)
        Dim felbow5r As New Point(640, 368)
        Dim felbow6r As New Point(639, 357)
        Dim felbowr As Point() = {felbow1r, felbow2r, felbow3r, felbow4r, felbow5r, felbow6r}

        Dim felbow1l As New Point(859, 357)
        Dim felbow2l As New Point(860, 377)
        Dim felbow3l As New Point(871, 405)
        Dim felbow4l As New Point(918, 405)
        Dim felbow5l As New Point(916, 384)
        Dim felbow6l As New Point(906, 357)
        Dim felbowl As Point() = {felbow1l, felbow2l, felbow3l, felbow4l, felbow5l, felbow6l}

        Dim forarmr1 As New Point(585, 406)
        Dim forarmr2 As New Point(583, 434)
        Dim forarmr3 As New Point(576, 455)
        Dim forarmr4 As New Point(607, 455)
        Dim forarmr5 As New Point(618, 427)
        Dim forarmr6 As New Point(631, 406)
        Dim forarmr As Point() = {forarmr1, forarmr2, forarmr3, forarmr4, forarmr5, forarmr6}

        Dim forarm1l As New Point(871, 406)
        Dim forarm2l As New Point(878, 424)
        Dim forarm3l As New Point(882, 435)
        Dim forarm4l As New Point(893, 455)
        Dim forarm5l As New Point(931, 455)
        Dim forarm6l As New Point(929, 446)
        Dim forarm7l As New Point(923, 430)
        Dim forarm8l As New Point(919, 412)
        Dim forarm9l As New Point(918, 406)
        Dim forarml As Point() = {forarm1l, forarm2l, forarm3l, forarm4l, forarm5l, forarm6l, forarm7l, forarm8l, forarm9l}

        Dim wristr1 As New Point(575, 456)
        Dim wristr2 As New Point(568, 475)
        Dim wristr3 As New Point(602, 475)
        Dim wristr4 As New Point(608, 456)
        Dim wristr As Point() = {wristr1, wristr2, wristr3, wristr4}

        Dim wristl1 As New Point(894, 456)
        Dim wristl2 As New Point(903, 475)
        Dim wristl3 As New Point(942, 475)
        Dim wristl4 As New Point(937, 469)
        Dim wristl5 As New Point(932, 456)
        Dim wristl As Point() = {wristl1, wristl2, wristl3, wristl4, wristl5}

        Dim handr1 As New Point(564, 476)
        Dim handr2 As New Point(540, 497)
        Dim handr3 As New Point(533, 512)
        Dim handr4 As New Point(525, 517)
        Dim handr5 As New Point(525, 529)
        Dim handr6 As New Point(538, 519)
        Dim handr7 As New Point(547, 510)
        Dim handr8 As New Point(554, 498)
        Dim handr9 As New Point(556, 497)
        Dim handr10 As New Point(556, 490)
        Dim handr11 As New Point(558, 520)
        Dim handr12 As New Point(536, 564)
        Dim handr13 As New Point(542, 564)
        Dim handr14 As New Point(558, 532)
        Dim handr15 As New Point(563, 532)
        Dim handr16 As New Point(555, 566)
        Dim handr17 As New Point(560, 576)
        Dim handr18 As New Point(560, 555)
        Dim handr19 As New Point(572, 534)
        Dim handr20 As New Point(574, 533)
        Dim handr21 As New Point(570, 565)
        Dim handr22 As New Point(577, 570)
        Dim handr23 As New Point(575, 564)
        Dim handr24 As New Point(585, 564)
        Dim handr25 As New Point(585, 536)
        Dim handr26 As New Point(588, 536)
        Dim handr27 As New Point(586, 561)
        Dim handr28 As New Point(589, 562)
        Dim handr29 As New Point(591, 547)
        Dim handr30 As New Point(595, 541)
        Dim handr31 As New Point(598, 517)
        Dim handr32 As New Point(604, 491)
        Dim handr33 As New Point(602, 482)
        Dim handr34 As New Point(602, 476)
        Dim thumbr As Point() = {handr1, handr2, handr3, handr4, handr5, handr6, handr7, handr8, handr9, handr10,
                handr11, handr12, handr13, handr14, handr15, handr16, handr17, handr18, handr19, handr20, handr21, handr22,
                handr23, handr24, handr25, handr26, handr27, handr28, handr29, handr30, handr31, handr32, handr33, handr34}
        Dim handl1 As New Point(904, 476)
        Dim handl2 As New Point(907, 485)
        Dim handl3 As New Point(906, 511)
        Dim handl4 As New Point(918, 543)
        Dim handl5 As New Point(917, 563)
        Dim handl6 As New Point(923, 556)
        Dim handl7 As New Point(926, 539)
        Dim handl8 As New Point(933, 552)
        Dim handl9 As New Point(930, 571)
        Dim handl10 As New Point(933, 572)
        Dim handl11 As New Point(939, 566)
        Dim handl12 As New Point(942, 546)
        Dim handl13 As New Point(945, 546)
        Dim handl14 As New Point(945, 559)
        Dim handl15 As New Point(948, 562)
        Dim handl16 As New Point(950, 573)
        Dim handl17 As New Point(953, 575)
        Dim handl18 As New Point(956, 556)
        Dim handl19 As New Point(951, 534)
        Dim handl20 As New Point(955, 534)
        Dim handl21 As New Point(964, 567)
        Dim handl22 As New Point(971, 565)
        Dim handl23 As New Point(971, 548)
        Dim handl24 As New Point(963, 535)
        Dim handl25 As New Point(963, 526)
        Dim handl26 As New Point(953, 507)
        Dim handl27 As New Point(954, 504)
        Dim handl28 As New Point(985, 518)
        Dim handl29 As New Point(988, 514)
        Dim handl30 As New Point(942, 476)
        Dim thumbl As Point() = {handl1, handl2, handl3, handl4, handl5, handl6, handl7, handl8, handl9, handl10,
                handl11, handl12, handl13, handl14, handl15, handl16, handl17, handl18, handl19, handl20, handl21, handl22,
                handl23, handl24, handl25, handl26, handl27, handl28, handl29, handl30}

        Dim innerribr1 As New Point(667, 299)
        Dim innerribr2 As New Point(675, 377)
        Dim innerribr3 As New Point(713, 377)
        Dim innerribr4 As New Point(713, 297)

        Dim innerribr As Point() = {innerribr1, innerribr2, innerribr3, innerribr4}

        Dim innerribl1 As New Point(786, 298)
        Dim innerribl2 As New Point(786, 377)
        Dim innerribl3 As New Point(826, 377)
        Dim innerribl4 As New Point(825, 377)
        Dim innerribl5 As New Point(824, 363)
        Dim innerribl6 As New Point(822, 356)
        Dim innerribl7 As New Point(822, 340)
        Dim innerribl8 As New Point(824, 327)
        Dim innerribl9 As New Point(835, 298)

        Dim innerribl As Point() = {innerribl1, innerribl2, innerribl3, innerribl4, innerribl5, innerribl6, innerribl7, innerribl8, innerribl9}

        Dim abdomen1 As New Point(674, 379)
        Dim abdomen2 As New Point(677, 400)
        Dim abdomen3 As New Point(670, 437)
        Dim abdomen4 As New Point(836, 437)
        Dim abdomen5 As New Point(829, 418)
        Dim abdomen6 As New Point(826, 401)
        Dim abdomen7 As New Point(826, 379)
        Dim abdomen As Point() = {abdomen1, abdomen2, abdomen3, abdomen4, abdomen5, abdomen6, abdomen7}

        Dim hipr1 As New Point(670, 438)
        Dim hipr2 As New Point(664, 473)
        Dim hipr3 As New Point(665, 485)
        Dim hipr4 As New Point(660, 497)
        Dim hipr5 As New Point(658, 517)
        Dim hipr6 As New Point(712, 518)
        Dim hipr7 As New Point(712, 438)
        Dim hipr As Point() = {hipr1, hipr2, hipr3, hipr4, hipr5, hipr5, hipr6, hipr7}

        Dim hipl1 As New Point(792, 438)
        Dim hipl2 As New Point(792, 518)
        Dim hipl3 As New Point(850, 518)
        Dim hipl4 As New Point(850, 485)
        Dim hipl5 As New Point(841, 466)
        Dim hipl6 As New Point(838, 438)
        Dim hipl As Point() = {hipl1, hipl2, hipl3, hipl4, hipl5, hipl6}

        Dim inthigh1 As New Point(713, 479)
        Dim inthigh2 As New Point(713, 593)
        Dim inthigh3 As New Point(792, 593)
        Dim inthigh4 As New Point(792, 479)
        Dim inthigh5 As New Point(778, 479)
        Dim inthigh6 As New Point(778, 527)
        Dim inthigh7 As New Point(727, 527)
        Dim inthigh8 As New Point(727, 479)
        Dim inthigh As Point() = {inthigh1, inthigh2, inthigh3, inthigh4, inthigh5, inthigh6, inthigh7, inthigh8}

        Dim rtthigh1 As New Point(659, 517)
        Dim rtthigh2 As New Point(667, 551)
        Dim rtthigh3 As New Point(679, 636)
        Dim rtthigh4 As New Point(679, 658)
        Dim rtthigh5 As New Point(678, 658)
        Dim rtthigh6 As New Point(679, 680)
        Dim rtthigh7 As New Point(739, 680)
        Dim rtthigh8 As New Point(745, 662)
        Dim rtthigh9 As New Point(743, 659)
        Dim rtthigh10 As New Point(742, 630)
        Dim rtthigh11 As New Point(744, 620)
        Dim rtthigh12 As New Point(748, 595)
        Dim rtthigh13 As New Point(711, 595)
        Dim rtthigh14 As New Point(711, 517)
        Dim rtthigh As Point() = {rtthigh1, rtthigh2, rtthigh3, rtthigh4, rtthigh5, rtthigh6, rtthigh7, rtthigh8, rtthigh9, rtthigh10, rtthigh11, rtthigh12, rtthigh13, rtthigh14}

        Dim ltthigh1 As New Point(793, 517)
        Dim ltthigh2 As New Point(793, 594)
        Dim ltthigh3 As New Point(760, 594)
        Dim ltthigh4 As New Point(765, 621)
        Dim ltthigh5 As New Point(767, 638)
        Dim ltthigh6 As New Point(764, 659)
        Dim ltthigh7 As New Point(765, 680)
        Dim ltthigh8 As New Point(827, 680)
        Dim ltthigh9 As New Point(828, 647)
        Dim ltthigh10 As New Point(825, 636)
        Dim ltthigh11 As New Point(826, 628)
        Dim ltthigh12 As New Point(846, 561)
        Dim ltthigh13 As New Point(850, 517)
        Dim ltthigh As Point() = {ltthigh1, ltthigh2, ltthigh3, ltthigh4, ltthigh5, ltthigh6, ltthigh7, ltthigh8, ltthigh9, ltthigh10, ltthigh11, ltthigh12, ltthigh13}

        Dim rtknee1 As New Point(681, 683)
        Dim rtknee2 As New Point(684, 692)
        Dim rtknee3 As New Point(684, 717)
        Dim rtknee4 As New Point(679, 737)
        Dim rtknee5 As New Point(730, 737)
        Dim rtknee6 As New Point(730, 720)
        Dim rtknee7 As New Point(736, 709)
        Dim rtknee8 As New Point(737, 693)
        Dim rtknee9 As New Point(738, 683)
        Dim rtknee As Point() = {rtknee1, rtknee2, rtknee3, rtknee4, rtknee5, rtknee6, rtknee7, rtknee8, rtknee9}

        Dim ltknee1 As New Point(766, 683)
        Dim ltknee2 As New Point(767, 689)
        Dim ltknee3 As New Point(775, 709)
        Dim ltknee4 As New Point(773, 725)
        Dim ltknee5 As New Point(773, 737)
        Dim ltknee6 As New Point(830, 739)
        Dim ltknee7 As New Point(830, 714)
        Dim ltknee8 As New Point(825, 705)
        Dim ltknee9 As New Point(828, 683)
        Dim ltknee As Point() = {ltknee1, ltknee2, ltknee3, ltknee4, ltknee5, ltknee6, ltknee7, ltknee8, ltknee9}

        Dim rshin1 As New Point(679, 741)
        Dim rshin2 As New Point(678, 757)
        Dim rshin3 As New Point(683, 778)
        Dim rshin4 As New Point(687, 810)
        Dim rshin5 As New Point(693, 838)
        Dim rshin6 As New Point(693, 852)
        Dim rshin7 As New Point(729, 852)
        Dim rshin8 As New Point(732, 831)
        Dim rshin9 As New Point(738, 805)
        Dim rshin10 As New Point(738, 769)
        Dim rshin11 As New Point(730, 741)

        Dim rshin As Point() = {rshin1, rshin2, rshin3, rshin4, rshin5, rshin6, rshin7, rshin8, rshin9, rshin10, rshin11}

        Dim lshin1 As New Point(774, 741)
        Dim lshin2 As New Point(774, 748)
        Dim lshin3 As New Point(771, 785)
        Dim lshin4 As New Point(776, 794)
        Dim lshin5 As New Point(784, 819)
        Dim lshin6 As New Point(786, 836)
        Dim lshin7 As New Point(785, 854)
        Dim lshin8 As New Point(816, 854)
        Dim lshin9 As New Point(821, 831)
        Dim lshin10 As New Point(832, 782)
        Dim lshin11 As New Point(832, 752)
        Dim lshin12 As New Point(830, 741)
        Dim lshin As Point() = {lshin1, lshin2, lshin3, lshin4, lshin5, lshin6, lshin7, lshin8, lshin9, lshin10, lshin11, lshin12}

        Dim rlshin1 As New Point(693, 854)
        Dim rlshin2 As New Point(693, 885)
        Dim rlshin3 As New Point(690, 890)
        Dim rlshin4 As New Point(694, 908)
        Dim rlshin5 As New Point(726, 908)
        Dim rlshin6 As New Point(729, 903)
        Dim rlshin7 As New Point(729, 854)
        Dim rlshin As Point() = {rlshin1, rlshin2, rlshin3, rlshin4, rlshin5, rlshin6, rlshin7}


        Dim llshin1 As New Point(785, 854)
        Dim llshin2 As New Point(785, 880)
        Dim llshin3 As New Point(781, 887)
        Dim llshin4 As New Point(781, 908)
        Dim llshin5 As New Point(819, 908)
        Dim llshin6 As New Point(819, 896)
        Dim llshin7 As New Point(815, 886)
        Dim llshin8 As New Point(813, 867)
        Dim llshin9 As New Point(816, 854)
        Dim llshin As Point() = {llshin1, llshin2, llshin3, llshin4, llshin5, llshin6, llshin7, llshin8, llshin9}

        Dim rankle1 As New Point(694, 910)
        Dim rankle2 As New Point(695, 912)
        Dim rankle3 As New Point(693, 933)
        Dim rankle4 As New Point(691, 939)
        Dim rankle5 As New Point(722, 939)
        Dim rankle6 As New Point(720, 926)
        Dim rankle7 As New Point(727, 910)
        Dim rankle As Point() = {rankle1, rankle2, rankle3, rankle4, rankle5, rankle6, rankle7}

        Dim lankle1 As New Point(781, 910)
        Dim lankle2 As New Point(783, 912)
        Dim lankle3 As New Point(786, 929)
        Dim lankle4 As New Point(785, 939)
        Dim lankle5 As New Point(824, 939)
        Dim lankle6 As New Point(816, 928)
        Dim lankle7 As New Point(816, 910)
        Dim lankle8 As New Point(819, 910)
        Dim lankle As Point() = {lankle1, lankle2, lankle3, lankle4, lankle5, lankle6, lankle7}

        Dim rfoot1 As New Point(691, 939)
        Dim rfoot2 As New Point(688, 944)
        Dim rfoot3 As New Point(685, 947)
        Dim rfoot4 As New Point(677, 959)
        Dim rfoot5 As New Point(730, 959)
        Dim rfoot6 As New Point(724, 951)
        Dim rfoot7 As New Point(723, 939)
        Dim rfoot As Point() = {rfoot1, rfoot2, rfoot3, rfoot4, rfoot5, rfoot6, rfoot7}

        Dim lfoot1 As New Point(785, 939)
        Dim lfoot2 As New Point(785, 958)
        Dim lfoot3 As New Point(829, 958)
        Dim lfoot4 As New Point(825, 949)
        Dim lfoot5 As New Point(824, 939)
        Dim lfoot As Point() = {lfoot1, lfoot2, lfoot3, lfoot4, lfoot5}

        Dim rtoes1 As New Point(677, 960)
        Dim rtoes2 As New Point(677, 970)
        Dim rtoes3 As New Point(681, 973)
        Dim rtoes4 As New Point(703, 972)
        Dim rtoes5 As New Point(721, 970)
        Dim rtoes6 As New Point(729, 969)
        Dim rtoes7 As New Point(729, 960)
        Dim rtoes As Point() = {rtoes1, rtoes2, rtoes3, rtoes4, rtoes5, rtoes6, rtoes7}

        Dim ltoes1 As New Point(786, 960)
        Dim ltoes2 As New Point(786, 970)
        Dim ltoes3 As New Point(792, 974)
        Dim ltoes4 As New Point(818, 973)
        Dim ltoes5 As New Point(825, 975)
        Dim ltoes6 As New Point(834, 970)
        Dim ltoes7 As New Point(830, 960)
        Dim ltoes As Point() = {ltoes1, ltoes2, ltoes3, ltoes4, ltoes5, ltoes6, ltoes7}



        If reccheck = 1 Then
            e.Graphics.DrawPolygon(orangepen, thp) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, thp) 'top of head back
        End If
        If reccheck = 2 Then
            e.Graphics.FillRectangle(redBrush, 196, 49, 89, 10)
            e.Graphics.FillRectangle(redBrush, 194, 59, 93, 20)
        End If
        If reccheck = 3 Then
            e.Graphics.DrawPolygon(orangepen, leftear) 'ear
            e.Graphics.FillPolygon(orangeBrush, leftear) 'ear
            e.Graphics.DrawPolygon(orangepen, rightear) 'ear
            e.Graphics.FillPolygon(orangeBrush, rightear) 'ear
        End If
        If reccheck = 4 Then
            e.Graphics.DrawPolygon(greenpen, basskul) 'base of skull
            e.Graphics.FillPolygon(greenBrush, basskul) 'base of skull
        End If
        If reccheck = 5 Then
            e.Graphics.FillRectangle(blueBrush, 205, 117, 67, 37) 'neck
        End If
        If reccheck = 6 Then
            e.Graphics.DrawPolygon(redpen, spine) 'spine
            e.Graphics.FillPolygon(redBrush, spine) 'spine
        End If
        If reccheck = 7 Then
            e.Graphics.DrawPolygon(greenpen, rtshoulder) 'rtshoulderblade
            e.Graphics.FillPolygon(greenBrush, rtshoulder) 'rtshoulderblade
            e.Graphics.DrawPolygon(greenpen, ltshoulder) 'ltshoulderblade
            e.Graphics.FillPolygon(greenBrush, ltshoulder) 'ltshoulderblade
        End If
        If reccheck = 8 Then
            e.Graphics.DrawPolygon(bluepen, rtdel) 'deltoid
            e.Graphics.FillPolygon(blueBrush, rtdel) 'deltoid
            e.Graphics.DrawPolygon(bluepen, ltdel) 'deltoid
            e.Graphics.FillPolygon(blueBrush, ltdel) 'deltoid
        End If
        If reccheck = 9 Then
            e.Graphics.DrawPolygon(yellowpen, rtelbow) 'deltoid
            e.Graphics.FillPolygon(yellowBrush, rtelbow) 'deltoid
            e.Graphics.DrawPolygon(yellowpen, ltelbow) 'deltoid
            e.Graphics.FillPolygon(yellowBrush, ltelbow) 'deltoid
        End If
        If reccheck = 10 Then
            e.Graphics.DrawPolygon(bluepen, ltforearmrear) 'fore arm rear
            e.Graphics.FillPolygon(blueBrush, ltforearmrear) 'fore arm rear
            e.Graphics.DrawPolygon(bluepen, rtforearmrear) 'fore arm rear
            e.Graphics.FillPolygon(blueBrush, rtforearmrear) 'fore arm rear
        End If
        If reccheck = 11 Then
            e.Graphics.DrawPolygon(yellowpen, rtwrist) 'rt wrist
            e.Graphics.FillPolygon(yellowBrush, rtwrist) 'rt wrist

            e.Graphics.DrawPolygon(yellowpen, ltwrist) 'lt wrist
            e.Graphics.FillPolygon(yellowBrush, ltwrist) 'lt wrist
        End If
        If reccheck = 12 Then
            e.Graphics.DrawPolygon(greenpen, rthand) 'rt hand
            e.Graphics.FillPolygon(greenBrush, rthand) 'rthand
            e.Graphics.DrawPolygon(greenpen, lthand) 'lt hand
            e.Graphics.FillPolygon(greenBrush, lthand) 'lt hand
        End If
        If reccheck = 13 Then
            e.Graphics.DrawPolygon(orangepen, rtthumb) 'rt thumb
            e.Graphics.FillPolygon(orangeBrush, rtthumb) 'rt thumb
            e.Graphics.DrawPolygon(orangepen, rtpointfinger) 'pointer finger
            e.Graphics.FillPolygon(orangeBrush, rtpointfinger) 'Pointer finger
            e.Graphics.DrawPolygon(orangepen, rtmiddlefinger) 'pointer finger
            e.Graphics.FillPolygon(orangeBrush, rtmiddlefinger) 'Pointer finger
            e.Graphics.DrawPolygon(orangepen, rtindexfinger) 'index finger
            e.Graphics.FillPolygon(orangeBrush, rtindexfinger) 'index finger
            e.Graphics.DrawPolygon(orangepen, rtpinkyfinger) 'pinky finger
            e.Graphics.FillPolygon(orangeBrush, rtpinkyfinger) 'pinky finger
            e.Graphics.DrawPolygon(orangepen, ltpinkyfinger) 'pinky finger
            e.Graphics.FillPolygon(orangeBrush, ltpinkyfinger) 'pinky finger
            e.Graphics.DrawPolygon(orangepen, ltindexfinger) 'index finger
            e.Graphics.FillPolygon(orangeBrush, ltindexfinger) 'index finger
            e.Graphics.DrawPolygon(orangepen, ltmiddlefinger) 'middlefinger
            e.Graphics.FillPolygon(orangeBrush, ltmiddlefinger) 'middle finger
            e.Graphics.DrawPolygon(orangepen, ltpointfinger) 'point finger
            e.Graphics.FillPolygon(orangeBrush, ltpointfinger) 'point finger
            e.Graphics.DrawPolygon(orangepen, ltthumb) 'thumb
            e.Graphics.FillPolygon(orangeBrush, ltthumb) 'thumb
        End If
        If reccheck = 14 Then
            e.Graphics.DrawPolygon(yellowpen, rtmidback) 'mid back
            e.Graphics.FillPolygon(yellowBrush, rtmidback) 'mid back
            e.Graphics.DrawPolygon(yellowpen, ltmidback) 'mid back
            e.Graphics.FillPolygon(yellowBrush, ltmidback) 'mid back
        End If
        If reccheck = 15 Then
            e.Graphics.DrawPolygon(orangepen, rtlowback) 'low back
            e.Graphics.FillPolygon(orangeBrush, rtlowback) 'low back
            e.Graphics.DrawPolygon(orangepen, ltlowback) 'low back
            e.Graphics.FillPolygon(orangeBrush, ltlowback) 'low back
        End If
        If reccheck = 16 Then
            e.Graphics.DrawPolygon(bluepen, buttocks) 'buttocks
            e.Graphics.FillPolygon(blueBrush, buttocks) 'buttocks
            e.Graphics.DrawPolygon(bluepen, buttocksa) 'buttocks
            e.Graphics.FillPolygon(blueBrush, buttocksa) 'buttocks
            e.Graphics.DrawPolygon(bluepen, buttocksb) 'top of head back
            e.Graphics.FillPolygon(blueBrush, buttocksb) 'top of head back
            e.Graphics.DrawPolygon(bluepen, buttocksc) 'top of head back
            e.Graphics.FillPolygon(blueBrush, buttocksc) 'top of head back
        End If
        If reccheck = 17 Then
            e.Graphics.DrawPolygon(orangepen, linnerthigh) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, linnerthigh) 'top of head back
            e.Graphics.DrawPolygon(orangepen, rinnerthigh) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, rinnerthigh) 'top of head back
        End If
        If reccheck = 18 Then

            e.Graphics.DrawPolygon(greenpen, rtthighr) 'top of head back
            e.Graphics.FillPolygon(greenBrush, rtthighr) 'top of head back
            e.Graphics.DrawPolygon(greenpen, ltthighr) 'top of head back
            e.Graphics.FillPolygon(greenBrush, ltthighr) 'top of head back
        End If
        If reccheck = 19 Then
            e.Graphics.DrawPolygon(redpen, rkneerear) 'knee rear
            e.Graphics.FillPolygon(redBrush, rkneerear) 'knee rear
            e.Graphics.DrawPolygon(redpen, lkneerear) 'knee rear
            e.Graphics.FillPolygon(redBrush, lkneerear) 'knee rear
        End If
        If reccheck = 20 Then
            e.Graphics.DrawPolygon(bluepen, shinbackl) 'left shin rear
            e.Graphics.FillPolygon(blueBrush, shinbackl) 'left shin rear
            e.Graphics.DrawPolygon(bluepen, shinbackr) 'right shin rear
            e.Graphics.FillPolygon(blueBrush, shinbackr) 'right shin rear
        End If
        If reccheck = 21 Then
            e.Graphics.DrawPolygon(yellowpen, anklel) 'left ankle
            e.Graphics.FillPolygon(yellowBrush, anklel) 'left ankle
            e.Graphics.DrawPolygon(yellowpen, ankler) 'right ankle
            e.Graphics.FillPolygon(yellowBrush, ankler) 'right ankle
        End If
        If reccheck = 22 Then
            e.Graphics.DrawPolygon(orangepen, footr) 'rt foot rear
            e.Graphics.FillPolygon(orangeBrush, footr) 'rtfoot rear
            e.Graphics.DrawPolygon(orangepen, footl) 'ltfoot rear
            e.Graphics.FillPolygon(orangeBrush, footl) 'lt foot rear
        End If
        If reccheck = 23 Then
            e.Graphics.FillPolygon(orangeBrush, forehead) 'forehead
        End If
        If reccheck = 24 Then
            e.Graphics.DrawPolygon(redpen, face) 'top of head back
            e.Graphics.FillPolygon(redBrush, face) 'top of head back
        End If
        If reccheck = 25 Then
            e.Graphics.DrawPolygon(orangepen, rear) 'r rear
            e.Graphics.FillPolygon(orangeBrush, rear) 'r rear

            e.Graphics.DrawPolygon(orangepen, lear) 'l rear
            e.Graphics.FillPolygon(orangeBrush, lear) 'l rear
        End If
        If reccheck = 26 Then
            e.Graphics.DrawPolygon(orangepen, neck) 'neck
            e.Graphics.FillPolygon(orangeBrush, neck) 'neck
        End If
        If reccheck = 27 Then
            e.Graphics.DrawPolygon(yellowpen, clavicall) 'clavical r
            e.Graphics.FillPolygon(yellowBrush, clavicall) 'clavical r
            e.Graphics.DrawPolygon(yellowpen, clavicalr) 'clavical l
            e.Graphics.FillPolygon(yellowBrush, clavicalr) 'clavical l
        End If
        If reccheck = 28 Then
            e.Graphics.DrawPolygon(redpen, armpitr) 'shoulder r 
            e.Graphics.FillPolygon(redBrush, armpitr) 'shoulder r
            e.Graphics.DrawPolygon(redpen, armpitl) 'shoulder l
            e.Graphics.FillPolygon(redBrush, armpitl) 'shoulder l
        End If
        If reccheck = 29 Then
            e.Graphics.DrawPolygon(yellowpen, innerarmr) 'inner arm right
            e.Graphics.FillPolygon(yellowBrush, innerarmr) 'inner arm right
            e.Graphics.DrawPolygon(yellowpen, innerarml) 'inner arm left
            e.Graphics.FillPolygon(yellowBrush, innerarml) 'inner arm left
        End If
        If reccheck = 30 Then
            e.Graphics.DrawPolygon(bluepen, shoulderr) 'right shoulder
            e.Graphics.FillPolygon(blueBrush, shoulderr) 'right shoulder
            e.Graphics.DrawPolygon(bluepen, shoulderl) 'left shoulder
            e.Graphics.FillPolygon(blueBrush, shoulderl) 'left shoulder
        End If
        If reccheck = 31 Then
            e.Graphics.DrawPolygon(bluepen, biceptr) 'bicept right
            e.Graphics.FillPolygon(blueBrush, biceptr) 'bicept right
            e.Graphics.DrawPolygon(bluepen, biceptl) 'bicept left
            e.Graphics.FillPolygon(blueBrush, biceptl) 'bicept left
        End If
        If reccheck = 32 Then
            e.Graphics.DrawPolygon(orangepen, felbowr) 'elbow front right
            e.Graphics.FillPolygon(orangeBrush, felbowr) 'elbow front right
            e.Graphics.DrawPolygon(orangepen, felbowl) 'elbow front left
            e.Graphics.FillPolygon(orangeBrush, felbowl) 'elbow front left
        End If
        If reccheck = 33 Then
            e.Graphics.DrawPolygon(bluepen, forarmr) 'fore arm front right
            e.Graphics.FillPolygon(blueBrush, forarmr) 'fore arm front right
            e.Graphics.DrawPolygon(bluepen, forarml) 'fore arm front left
            e.Graphics.FillPolygon(blueBrush, forarml) 'fore arm front left
        End If
        If reccheck = 34 Then
            e.Graphics.DrawPolygon(yellowpen, wristr) 'wrist right
            e.Graphics.FillPolygon(yellowBrush, wristr) 'wrist right
            e.Graphics.DrawPolygon(yellowpen, wristl) 'wrist left
            e.Graphics.FillPolygon(yellowBrush, wristl) 'wrist left
        End If
        If reccheck = 35 Then
            e.Graphics.DrawPolygon(redpen, thumbl) ' hand right
            e.Graphics.FillPolygon(redBrush, thumbl) 'hand right
            e.Graphics.DrawPolygon(redpen, thumbr) 'hand left
            e.Graphics.FillPolygon(redBrush, thumbr) 'hand left
        End If
        If reccheck = 36 Then
            e.Graphics.FillRectangle(yellowBrush, 670, 191, 175, 46) 'sternum 1
            e.Graphics.FillRectangle(yellowBrush, 680, 237, 155, 60) 'sternum 2
            e.Graphics.FillRectangle(yellowBrush, 715, 297, 70, 52) 'sternum 3

            e.Graphics.FillRectangle(yellowBrush, 715, 349, 19, 31) 'sternum r 
            e.Graphics.FillRectangle(yellowBrush, 765, 349, 20, 31) 'sternum l
        End If
        If reccheck = 37 Then
            e.Graphics.FillRectangle(redBrush, 734, 349, 31, 30) 'sternum bottom
        End If
        If reccheck = 38 Then
            e.Graphics.DrawPolygon(orangepen, innerribr) 'inner rib right
            e.Graphics.FillPolygon(orangeBrush, innerribr) 'inner rib right
            e.Graphics.DrawPolygon(orangepen, innerribl) 'inner rib left
            e.Graphics.FillPolygon(orangeBrush, innerribl) 'inner rib left
        End If
        If reccheck = 39 Then
            e.Graphics.DrawPolygon(yellowpen, abdomen) 'abdomen
            e.Graphics.FillPolygon(yellowBrush, abdomen) 'abdomen
        End If
        If reccheck = 40 Then
            e.Graphics.FillRectangle(greenBrush, 712, 438, 80, 40) 'Middriff
        End If
        If reccheck = 41 Then
            e.Graphics.DrawPolygon(yellowpen, hipr) 'hip right
            e.Graphics.FillPolygon(yellowBrush, hipr) 'hip right
            e.Graphics.DrawPolygon(yellowpen, hipl) 'hip left
            e.Graphics.FillPolygon(yellowBrush, hipl) 'hip left
        End If
        If reccheck = 42 Then
            e.Graphics.DrawPolygon(orangepen, inthigh) 'inner thigh
            e.Graphics.FillPolygon(orangeBrush, inthigh) 'inner thigh
        End If
        If reccheck = 43 Then
            e.Graphics.FillRectangle(redBrush, 728, 478, 50, 50) 'crotch
        End If
        If reccheck = 44 Then
            e.Graphics.DrawPolygon(bluepen, rtthigh) 'rt thigh
            e.Graphics.FillPolygon(blueBrush, rtthigh) 'rt thigh
            e.Graphics.DrawPolygon(bluepen, ltthigh) ' lt thigh
            e.Graphics.FillPolygon(blueBrush, ltthigh) 'lt thigh
        End If
        If reccheck = 45 Then
            e.Graphics.DrawPolygon(orangepen, rtknee) 'rt knee
            e.Graphics.FillPolygon(orangeBrush, rtknee) 'rt kneee
            e.Graphics.DrawPolygon(orangepen, ltknee) 'lt knee
            e.Graphics.FillPolygon(orangeBrush, ltknee) 'lt knee
        End If
        If reccheck = 46 Then
            e.Graphics.DrawPolygon(greenpen, rshin) 'shin right 1
            e.Graphics.FillPolygon(greenBrush, rshin) 'shin right 2
            e.Graphics.DrawPolygon(greenpen, rlshin) 'shin right 3
            e.Graphics.FillPolygon(greenBrush, rlshin) 'shin right 4
            e.Graphics.DrawPolygon(greenpen, lshin) 'shin left
            e.Graphics.FillPolygon(greenBrush, lshin) 'shin left
            e.Graphics.DrawPolygon(greenpen, llshin) 'shin left
            e.Graphics.FillPolygon(greenBrush, llshin) 'shin left
        End If
        If reccheck = 47 Then
            e.Graphics.DrawPolygon(redpen, rankle) ' r ankle
            e.Graphics.FillPolygon(redBrush, rankle) 'r ankle
            e.Graphics.DrawPolygon(redpen, lankle) 'l ankle
            e.Graphics.FillPolygon(redBrush, lankle) 'l ankle
        End If
        If reccheck = 48 Then
            e.Graphics.DrawPolygon(orangepen, rfoot) 'r foot
            e.Graphics.FillPolygon(orangeBrush, rfoot) ' r foot
            e.Graphics.DrawPolygon(orangepen, lfoot) 'l foot
            e.Graphics.FillPolygon(orangeBrush, lfoot) 'l foot
        End If
        If reccheck = 49 Then
            e.Graphics.DrawPolygon(redpen, rtoes) 'r toes
            e.Graphics.FillPolygon(redBrush, rtoes) 'r toes
            e.Graphics.DrawPolygon(redpen, ltoes) 'l toes
            e.Graphics.FillPolygon(redBrush, ltoes) 'l toes
        End If
        If reccheck2 = 50 Then
            e.Graphics.DrawPolygon(redpen, rtoes) 'r toes
            e.Graphics.FillPolygon(redBrush, rtoes) 'r toes
            e.Graphics.DrawPolygon(redpen, ltoes) 'l toes
            e.Graphics.FillPolygon(redBrush, ltoes) 'l toes
            e.Graphics.DrawPolygon(orangepen, rfoot) 'r foot
            e.Graphics.FillPolygon(orangeBrush, rfoot) ' r foot
            e.Graphics.DrawPolygon(orangepen, lfoot) 'l foot
            e.Graphics.FillPolygon(orangeBrush, lfoot) 'l foot
            e.Graphics.DrawPolygon(redpen, rankle) ' r ankle
            e.Graphics.FillPolygon(redBrush, rankle) 'r ankle
            e.Graphics.DrawPolygon(redpen, lankle) 'l ankle
            e.Graphics.FillPolygon(redBrush, lankle) 'l ankle
            e.Graphics.DrawPolygon(greenpen, rshin) 'shin right 1
            e.Graphics.FillPolygon(greenBrush, rshin) 'shin right 2
            e.Graphics.DrawPolygon(greenpen, rlshin) 'shin right 3
            e.Graphics.FillPolygon(greenBrush, rlshin) 'shin right 4
            e.Graphics.DrawPolygon(greenpen, lshin) 'shin left
            e.Graphics.FillPolygon(greenBrush, lshin) 'shin left
            e.Graphics.DrawPolygon(greenpen, llshin) 'shin left
            e.Graphics.FillPolygon(greenBrush, llshin) 'shin left
            e.Graphics.DrawPolygon(orangepen, rtknee) 'rt knee
            e.Graphics.FillPolygon(orangeBrush, rtknee) 'rt kneee
            e.Graphics.DrawPolygon(orangepen, ltknee) 'lt knee
            e.Graphics.FillPolygon(orangeBrush, ltknee) 'lt knee
            e.Graphics.DrawPolygon(bluepen, rtthigh) 'rt thigh
            e.Graphics.FillPolygon(blueBrush, rtthigh) 'rt thigh
            e.Graphics.DrawPolygon(bluepen, ltthigh) ' lt thigh
            e.Graphics.FillPolygon(blueBrush, ltthigh) 'lt thigh
            e.Graphics.FillRectangle(redBrush, 728, 478, 50, 50) 'crotch
            e.Graphics.DrawPolygon(orangepen, thp) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, thp) 'top of head back
            e.Graphics.FillRectangle(redBrush, 196, 49, 89, 10)
            e.Graphics.FillRectangle(redBrush, 194, 59, 93, 20)
            e.Graphics.DrawPolygon(orangepen, leftear) 'ear
            e.Graphics.FillPolygon(orangeBrush, leftear) 'ear
            e.Graphics.DrawPolygon(orangepen, rightear) 'ear
            e.Graphics.FillPolygon(orangeBrush, rightear) 'ear
            e.Graphics.DrawPolygon(greenpen, basskul) 'base of skull
            e.Graphics.FillPolygon(greenBrush, basskul) 'base of skull
            e.Graphics.FillRectangle(blueBrush, 205, 117, 66, 37) 'neck
            e.Graphics.DrawPolygon(redpen, spine) 'spine
            e.Graphics.FillPolygon(redBrush, spine) 'spine
            e.Graphics.DrawPolygon(greenpen, rtshoulder) 'rtshoulderblade
            e.Graphics.FillPolygon(greenBrush, rtshoulder) 'rtshoulderblade
            e.Graphics.DrawPolygon(greenpen, ltshoulder) 'ltshoulderblade
            e.Graphics.FillPolygon(greenBrush, ltshoulder) 'ltshoulderblade
            e.Graphics.DrawPolygon(bluepen, rtdel) 'deltoid
            e.Graphics.FillPolygon(blueBrush, rtdel) 'deltoid
            e.Graphics.DrawPolygon(bluepen, ltdel) 'deltoid
            e.Graphics.FillPolygon(blueBrush, ltdel) 'deltoid
            e.Graphics.DrawPolygon(yellowpen, rtelbow) 'deltoid
            e.Graphics.FillPolygon(yellowBrush, rtelbow) 'deltoid
            e.Graphics.DrawPolygon(yellowpen, ltelbow) 'deltoid
            e.Graphics.FillPolygon(yellowBrush, ltelbow) 'deltoid
            e.Graphics.DrawPolygon(bluepen, ltforearmrear) 'fore arm rear
            e.Graphics.FillPolygon(blueBrush, ltforearmrear) 'fore arm rear
            e.Graphics.DrawPolygon(bluepen, rtforearmrear) 'fore arm rear
            e.Graphics.FillPolygon(blueBrush, rtforearmrear) 'fore arm rear
            e.Graphics.DrawPolygon(yellowpen, rtwrist) 'rt wrist
            e.Graphics.FillPolygon(yellowBrush, rtwrist) 'rt wrist
            e.Graphics.DrawPolygon(yellowpen, ltwrist) 'lt wrist
            e.Graphics.FillPolygon(yellowBrush, ltwrist) 'lt wrist
            e.Graphics.DrawPolygon(greenpen, rthand) 'rt hand
            e.Graphics.FillPolygon(greenBrush, rthand) 'rthand
            e.Graphics.DrawPolygon(greenpen, lthand) 'lt hand
            e.Graphics.FillPolygon(greenBrush, lthand) 'lt hand
            e.Graphics.DrawPolygon(orangepen, rtthumb) 'rt thumb
            e.Graphics.FillPolygon(orangeBrush, rtthumb) 'rt thumb
            e.Graphics.DrawPolygon(orangepen, rtpointfinger) 'pointer finger
            e.Graphics.FillPolygon(orangeBrush, rtpointfinger) 'Pointer finger
            e.Graphics.DrawPolygon(orangepen, rtmiddlefinger) 'pointer finger
            e.Graphics.FillPolygon(orangeBrush, rtmiddlefinger) 'Pointer finger
            e.Graphics.DrawPolygon(orangepen, rtindexfinger) 'index finger
            e.Graphics.FillPolygon(orangeBrush, rtindexfinger) 'index finger
            e.Graphics.DrawPolygon(orangepen, rtpinkyfinger) 'pinky finger
            e.Graphics.FillPolygon(orangeBrush, rtpinkyfinger) 'pinky finger
            e.Graphics.DrawPolygon(orangepen, ltpinkyfinger) 'pinky finger
            e.Graphics.FillPolygon(orangeBrush, ltpinkyfinger) 'pinky finger
            e.Graphics.DrawPolygon(orangepen, ltindexfinger) 'index finger
            e.Graphics.FillPolygon(orangeBrush, ltindexfinger) 'index finger
            e.Graphics.DrawPolygon(orangepen, ltmiddlefinger) 'middlefinger
            e.Graphics.FillPolygon(orangeBrush, ltmiddlefinger) 'middle finger
            e.Graphics.DrawPolygon(orangepen, ltpointfinger) 'point finger
            e.Graphics.FillPolygon(orangeBrush, ltpointfinger) 'point finger
            e.Graphics.DrawPolygon(orangepen, ltthumb) 'thumb
            e.Graphics.FillPolygon(orangeBrush, ltthumb) 'thumb
            e.Graphics.DrawPolygon(yellowpen, rtmidback) 'mid back
            e.Graphics.FillPolygon(yellowBrush, rtmidback) 'mid back
            e.Graphics.DrawPolygon(yellowpen, ltmidback) 'mid back
            e.Graphics.FillPolygon(yellowBrush, ltmidback) 'mid back
            e.Graphics.DrawPolygon(orangepen, rtlowback) 'low back
            e.Graphics.FillPolygon(orangeBrush, rtlowback) 'low back
            e.Graphics.DrawPolygon(orangepen, ltlowback) 'low back
            e.Graphics.FillPolygon(orangeBrush, ltlowback) 'low back
            e.Graphics.DrawPolygon(bluepen, buttocks) 'buttocks
            e.Graphics.FillPolygon(blueBrush, buttocks) 'buttocks
            e.Graphics.DrawPolygon(bluepen, buttocksa) 'buttocks
            e.Graphics.FillPolygon(blueBrush, buttocksa) 'buttocks
            e.Graphics.DrawPolygon(bluepen, buttocksb) 'top of head back
            e.Graphics.FillPolygon(blueBrush, buttocksb) 'top of head back
            e.Graphics.DrawPolygon(bluepen, buttocksc) 'top of head back
            e.Graphics.FillPolygon(blueBrush, buttocksc) 'top of head back
            e.Graphics.DrawPolygon(orangepen, linnerthigh) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, linnerthigh) 'top of head back
            e.Graphics.DrawPolygon(orangepen, rinnerthigh) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, rinnerthigh) 'top of head back
            e.Graphics.DrawPolygon(greenpen, rtthighr) 'top of head back
            e.Graphics.FillPolygon(greenBrush, rtthighr) 'top of head back
            e.Graphics.DrawPolygon(greenpen, ltthighr) 'top of head back
            e.Graphics.FillPolygon(greenBrush, ltthighr) 'top of head back
            e.Graphics.DrawPolygon(redpen, rkneerear) 'knee rear
            e.Graphics.FillPolygon(redBrush, rkneerear) 'knee rear
            e.Graphics.DrawPolygon(redpen, lkneerear) 'knee rear
            e.Graphics.FillPolygon(redBrush, lkneerear) 'knee rear
            e.Graphics.DrawPolygon(bluepen, shinbackl) 'left shin rear
            e.Graphics.FillPolygon(blueBrush, shinbackl) 'left shin rear
            e.Graphics.DrawPolygon(bluepen, shinbackr) 'right shin rear
            e.Graphics.FillPolygon(blueBrush, shinbackr) 'right shin rear
            e.Graphics.DrawPolygon(yellowpen, anklel) 'left ankle
            e.Graphics.FillPolygon(yellowBrush, anklel) 'left ankle
            e.Graphics.DrawPolygon(yellowpen, ankler) 'right ankle
            e.Graphics.FillPolygon(yellowBrush, ankler) 'right ankle
            e.Graphics.DrawPolygon(orangepen, footr) 'rt foot rear
            e.Graphics.FillPolygon(orangeBrush, footr) 'rtfoot rear
            e.Graphics.DrawPolygon(orangepen, footl) 'ltfoot rear
            e.Graphics.FillPolygon(orangeBrush, footl) 'lt foot rear
            e.Graphics.FillPolygon(orangeBrush, forehead) 'forehead
            e.Graphics.DrawPolygon(redpen, face) 'top of head back
            e.Graphics.FillPolygon(redBrush, face) 'top of head back
            e.Graphics.DrawPolygon(orangepen, rear) 'r rear
            e.Graphics.FillPolygon(orangeBrush, rear) 'r rear
            e.Graphics.DrawPolygon(orangepen, lear) 'l rear
            e.Graphics.FillPolygon(orangeBrush, lear) 'l rear
            e.Graphics.DrawPolygon(orangepen, neck) 'neck
            e.Graphics.FillPolygon(orangeBrush, neck) 'neck
            e.Graphics.DrawPolygon(yellowpen, clavicall) 'clavical r
            e.Graphics.FillPolygon(yellowBrush, clavicall) 'clavical r
            e.Graphics.DrawPolygon(yellowpen, clavicalr) 'clavical l
            e.Graphics.FillPolygon(yellowBrush, clavicalr) 'clavical l
            e.Graphics.DrawPolygon(redpen, armpitr) 'shoulder r 
            e.Graphics.FillPolygon(redBrush, armpitr) 'shoulder r
            e.Graphics.DrawPolygon(redpen, armpitl) 'shoulder l
            e.Graphics.FillPolygon(redBrush, armpitl) 'shoulder l
            e.Graphics.DrawPolygon(yellowpen, innerarmr) 'inner arm right
            e.Graphics.FillPolygon(yellowBrush, innerarmr) 'inner arm right
            e.Graphics.DrawPolygon(yellowpen, innerarml) 'inner arm left
            e.Graphics.FillPolygon(yellowBrush, innerarml) 'inner arm left
            e.Graphics.DrawPolygon(bluepen, shoulderr) 'right shoulder
            e.Graphics.FillPolygon(blueBrush, shoulderr) 'right shoulder
            e.Graphics.DrawPolygon(bluepen, shoulderl) 'left shoulder
            e.Graphics.FillPolygon(blueBrush, shoulderl) 'left shoulder
            e.Graphics.DrawPolygon(bluepen, biceptr) 'bicept right
            e.Graphics.FillPolygon(blueBrush, biceptr) 'bicept right
            e.Graphics.DrawPolygon(bluepen, biceptl) 'bicept left
            e.Graphics.FillPolygon(blueBrush, biceptl) 'bicept left
            e.Graphics.DrawPolygon(orangepen, felbowr) 'elbow front right
            e.Graphics.FillPolygon(orangeBrush, felbowr) 'elbow front right
            e.Graphics.DrawPolygon(orangepen, felbowl) 'elbow front left
            e.Graphics.FillPolygon(orangeBrush, felbowl) 'elbow front left
            e.Graphics.DrawPolygon(bluepen, forarmr) 'fore arm front right
            e.Graphics.FillPolygon(blueBrush, forarmr) 'fore arm front right
            e.Graphics.DrawPolygon(bluepen, forarml) 'fore arm front left
            e.Graphics.FillPolygon(blueBrush, forarml) 'fore arm front left
            e.Graphics.DrawPolygon(yellowpen, wristr) 'wrist right
            e.Graphics.FillPolygon(yellowBrush, wristr) 'wrist right
            e.Graphics.DrawPolygon(yellowpen, wristl) 'wrist left
            e.Graphics.FillPolygon(yellowBrush, wristl) 'wrist left
            e.Graphics.DrawPolygon(redpen, thumbl) ' hand right
            e.Graphics.FillPolygon(redBrush, thumbl) 'hand right
            e.Graphics.DrawPolygon(redpen, thumbr) 'hand left
            e.Graphics.FillPolygon(redBrush, thumbr) 'hand left
            e.Graphics.FillRectangle(yellowBrush, 667, 191, 173, 46) 'sternum 1
            e.Graphics.FillRectangle(yellowBrush, 680, 237, 155, 60) 'sternum 2
            e.Graphics.FillRectangle(yellowBrush, 715, 297, 70, 52) 'sternum 3
            e.Graphics.FillRectangle(yellowBrush, 715, 349, 19, 31) 'sternum r 
            e.Graphics.FillRectangle(yellowBrush, 765, 349, 20, 31) 'sternum l
            e.Graphics.FillRectangle(redBrush, 734, 349, 31, 30) 'sternum bottom
            e.Graphics.DrawPolygon(orangepen, innerribr) 'inner rib right
            e.Graphics.FillPolygon(orangeBrush, innerribr) 'inner rib right
            e.Graphics.DrawPolygon(orangepen, innerribl) 'inner rib left
            e.Graphics.FillPolygon(orangeBrush, innerribl) 'inner rib left
            e.Graphics.DrawPolygon(yellowpen, abdomen) 'abdomen
            e.Graphics.FillPolygon(yellowBrush, abdomen) 'abdomen
            e.Graphics.FillRectangle(greenBrush, 712, 438, 80, 40) 'Middriff
            e.Graphics.DrawPolygon(yellowpen, hipr) 'hip right
            e.Graphics.FillPolygon(yellowBrush, hipr) 'hip right
            e.Graphics.DrawPolygon(yellowpen, hipl) 'hip left
            e.Graphics.FillPolygon(yellowBrush, hipl) 'hip left
            e.Graphics.DrawPolygon(orangepen, inthigh) 'inner thigh
            e.Graphics.FillPolygon(orangeBrush, inthigh) 'inner thigh
        End If

        If memloccheck1 = 1 Or memloccheck2 = 1 Or memloccheck3 = 1 Or memloccheck4 = 1 Or memloccheck5 = 1 Then
            e.Graphics.DrawPolygon(orangepen, thp) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, thp) 'top of head back
        End If
        If memloccheck1 = 2 Or memloccheck2 = 2 Or memloccheck3 = 2 Or memloccheck4 = 2 Or memloccheck5 = 2 Then
            e.Graphics.FillRectangle(redBrush, 196, 49, 89, 10)
            e.Graphics.FillRectangle(redBrush, 194, 59, 93, 20)
        End If
        If memloccheck1 = 3 Or memloccheck2 = 3 Or memloccheck3 = 3 Or memloccheck4 = 3 Or memloccheck5 = 3 Then
            e.Graphics.DrawPolygon(orangepen, leftear) 'ear
            e.Graphics.FillPolygon(orangeBrush, leftear) 'ear
            e.Graphics.DrawPolygon(orangepen, rightear) 'ear
            e.Graphics.FillPolygon(orangeBrush, rightear) 'ear
        End If
        If memloccheck1 = 4 Or memloccheck2 = 4 Or memloccheck3 = 4 Or memloccheck4 = 4 Or memloccheck5 = 4 Then
            e.Graphics.DrawPolygon(greenpen, basskul) 'base of skull
            e.Graphics.FillPolygon(greenBrush, basskul) 'base of skull
        End If
        If memloccheck1 = 5 Or memloccheck2 = 5 Or memloccheck3 = 5 Or memloccheck4 = 5 Or memloccheck5 = 5 Then
            e.Graphics.FillRectangle(blueBrush, 205, 117, 67, 37) 'neck
        End If
        If memloccheck1 = 6 Or memloccheck2 = 6 Or memloccheck3 = 6 Or memloccheck4 = 6 Or memloccheck5 = 6 Then
            e.Graphics.DrawPolygon(redpen, spine) 'spine
            e.Graphics.FillPolygon(redBrush, spine) 'spine
        End If
        If memloccheck1 = 7 Or memloccheck2 = 7 Or memloccheck3 = 7 Or memloccheck4 = 7 Or memloccheck5 = 7 Then
            e.Graphics.DrawPolygon(greenpen, rtshoulder) 'rtshoulderblade
            e.Graphics.FillPolygon(greenBrush, rtshoulder) 'rtshoulderblade
            e.Graphics.DrawPolygon(greenpen, ltshoulder) 'ltshoulderblade
            e.Graphics.FillPolygon(greenBrush, ltshoulder) 'ltshoulderblade
        End If
        If memloccheck1 = 8 Or memloccheck2 = 8 Or memloccheck3 = 8 Or memloccheck4 = 8 Or memloccheck5 = 8 Then
            e.Graphics.DrawPolygon(bluepen, rtdel) 'deltoid
            e.Graphics.FillPolygon(blueBrush, rtdel) 'deltoid
            e.Graphics.DrawPolygon(bluepen, ltdel) 'deltoid
            e.Graphics.FillPolygon(blueBrush, ltdel) 'deltoid
        End If
        If memloccheck1 = 9 Or memloccheck2 = 9 Or memloccheck3 = 9 Or memloccheck4 = 9 Or memloccheck5 = 9 Then
            e.Graphics.DrawPolygon(yellowpen, rtelbow) 'deltoid
            e.Graphics.FillPolygon(yellowBrush, rtelbow) 'deltoid
            e.Graphics.DrawPolygon(yellowpen, ltelbow) 'deltoid
            e.Graphics.FillPolygon(yellowBrush, ltelbow) 'deltoid
        End If
        If memloccheck1 = 10 Or memloccheck2 = 10 Or memloccheck3 = 10 Or memloccheck4 = 10 Or memloccheck5 = 10 Then
            e.Graphics.DrawPolygon(bluepen, ltforearmrear) 'fore arm rear
            e.Graphics.FillPolygon(blueBrush, ltforearmrear) 'fore arm rear
            e.Graphics.DrawPolygon(bluepen, rtforearmrear) 'fore arm rear
            e.Graphics.FillPolygon(blueBrush, rtforearmrear) 'fore arm rear
        End If
        If memloccheck1 = 11 Or memloccheck2 = 11 Or memloccheck3 = 11 Or memloccheck4 = 11 Or memloccheck5 = 11 Then
            e.Graphics.DrawPolygon(yellowpen, rtwrist) 'rt wrist
            e.Graphics.FillPolygon(yellowBrush, rtwrist) 'rt wrist

            e.Graphics.DrawPolygon(yellowpen, ltwrist) 'lt wrist
            e.Graphics.FillPolygon(yellowBrush, ltwrist) 'lt wrist
        End If
        If memloccheck1 = 12 Or memloccheck2 = 12 Or memloccheck3 = 12 Or memloccheck4 = 12 Or memloccheck5 = 12 Then
            e.Graphics.DrawPolygon(greenpen, rthand) 'rt hand
            e.Graphics.FillPolygon(greenBrush, rthand) 'rthand
            e.Graphics.DrawPolygon(greenpen, lthand) 'lt hand
            e.Graphics.FillPolygon(greenBrush, lthand) 'lt hand
        End If
        If memloccheck1 = 13 Or memloccheck2 = 13 Or memloccheck3 = 13 Or memloccheck4 = 13 Or memloccheck5 = 13 Then
            e.Graphics.DrawPolygon(orangepen, rtthumb) 'rt thumb
            e.Graphics.FillPolygon(orangeBrush, rtthumb) 'rt thumb
            e.Graphics.DrawPolygon(orangepen, rtpointfinger) 'pointer finger
            e.Graphics.FillPolygon(orangeBrush, rtpointfinger) 'Pointer finger
            e.Graphics.DrawPolygon(orangepen, rtmiddlefinger) 'pointer finger
            e.Graphics.FillPolygon(orangeBrush, rtmiddlefinger) 'Pointer finger
            e.Graphics.DrawPolygon(orangepen, rtindexfinger) 'index finger
            e.Graphics.FillPolygon(orangeBrush, rtindexfinger) 'index finger
            e.Graphics.DrawPolygon(orangepen, rtpinkyfinger) 'pinky finger
            e.Graphics.FillPolygon(orangeBrush, rtpinkyfinger) 'pinky finger
            e.Graphics.DrawPolygon(orangepen, ltpinkyfinger) 'pinky finger
            e.Graphics.FillPolygon(orangeBrush, ltpinkyfinger) 'pinky finger
            e.Graphics.DrawPolygon(orangepen, ltindexfinger) 'index finger
            e.Graphics.FillPolygon(orangeBrush, ltindexfinger) 'index finger
            e.Graphics.DrawPolygon(orangepen, ltmiddlefinger) 'middlefinger
            e.Graphics.FillPolygon(orangeBrush, ltmiddlefinger) 'middle finger
            e.Graphics.DrawPolygon(orangepen, ltpointfinger) 'point finger
            e.Graphics.FillPolygon(orangeBrush, ltpointfinger) 'point finger
            e.Graphics.DrawPolygon(orangepen, ltthumb) 'thumb
            e.Graphics.FillPolygon(orangeBrush, ltthumb) 'thumb
        End If
        If memloccheck1 = 14 Or memloccheck2 = 14 Or memloccheck3 = 14 Or memloccheck4 = 14 Or memloccheck5 = 14 Then
            e.Graphics.DrawPolygon(yellowpen, rtmidback) 'mid back
            e.Graphics.FillPolygon(yellowBrush, rtmidback) 'mid back
            e.Graphics.DrawPolygon(yellowpen, ltmidback) 'mid back
            e.Graphics.FillPolygon(yellowBrush, ltmidback) 'mid back
        End If
        If memloccheck1 = 15 Or memloccheck2 = 15 Or memloccheck3 = 15 Or memloccheck4 = 15 Or memloccheck5 = 15 Then
            e.Graphics.DrawPolygon(orangepen, rtlowback) 'low back
            e.Graphics.FillPolygon(orangeBrush, rtlowback) 'low back
            e.Graphics.DrawPolygon(orangepen, ltlowback) 'low back
            e.Graphics.FillPolygon(orangeBrush, ltlowback) 'low back
        End If
        If memloccheck1 = 16 Or memloccheck2 = 16 Or memloccheck3 = 16 Or memloccheck4 = 16 Or memloccheck5 = 16 Then
            e.Graphics.DrawPolygon(bluepen, buttocks) 'buttocks
            e.Graphics.FillPolygon(blueBrush, buttocks) 'buttocks
            e.Graphics.DrawPolygon(bluepen, buttocksa) 'buttocks
            e.Graphics.FillPolygon(blueBrush, buttocksa) 'buttocks
            e.Graphics.DrawPolygon(bluepen, buttocksb) 'top of head back
            e.Graphics.FillPolygon(blueBrush, buttocksb) 'top of head back
            e.Graphics.DrawPolygon(bluepen, buttocksc) 'top of head back
            e.Graphics.FillPolygon(blueBrush, buttocksc) 'top of head back
        End If
        If memloccheck1 = 17 Or memloccheck2 = 17 Or memloccheck3 = 17 Or memloccheck4 = 17 Or memloccheck5 = 17 Then
            e.Graphics.DrawPolygon(orangepen, linnerthigh) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, linnerthigh) 'top of head back
            e.Graphics.DrawPolygon(orangepen, rinnerthigh) 'top of head back
            e.Graphics.FillPolygon(orangeBrush, rinnerthigh) 'top of head back
        End If
        If memloccheck1 = 18 Or memloccheck2 = 18 Or memloccheck3 = 18 Or memloccheck4 = 18 Or memloccheck5 = 18 Then

            e.Graphics.DrawPolygon(greenpen, rtthighr) 'top of head back
            e.Graphics.FillPolygon(greenBrush, rtthighr) 'top of head back
            e.Graphics.DrawPolygon(greenpen, ltthighr) 'top of head back
            e.Graphics.FillPolygon(greenBrush, ltthighr) 'top of head back
        End If
        If memloccheck1 = 19 Or memloccheck2 = 19 Or memloccheck3 = 19 Or memloccheck4 = 19 Or memloccheck5 = 19 Then
            e.Graphics.DrawPolygon(redpen, rkneerear) 'knee rear
            e.Graphics.FillPolygon(redBrush, rkneerear) 'knee rear
            e.Graphics.DrawPolygon(redpen, lkneerear) 'knee rear
            e.Graphics.FillPolygon(redBrush, lkneerear) 'knee rear
        End If
        If memloccheck1 = 20 Or memloccheck2 = 20 Or memloccheck3 = 1 Or memloccheck4 = 20 Or memloccheck5 = 10 Then
            e.Graphics.DrawPolygon(bluepen, shinbackl) 'left shin rear
            e.Graphics.FillPolygon(blueBrush, shinbackl) 'left shin rear
            e.Graphics.DrawPolygon(bluepen, shinbackr) 'right shin rear
            e.Graphics.FillPolygon(blueBrush, shinbackr) 'right shin rear
        End If
        If memloccheck1 = 21 Or memloccheck2 = 21 Or memloccheck3 = 21 Or memloccheck4 = 21 Or memloccheck5 = 21 Then
            e.Graphics.DrawPolygon(yellowpen, anklel) 'left ankle
            e.Graphics.FillPolygon(yellowBrush, anklel) 'left ankle
            e.Graphics.DrawPolygon(yellowpen, ankler) 'right ankle
            e.Graphics.FillPolygon(yellowBrush, ankler) 'right ankle
        End If
        If memloccheck1 = 22 Or memloccheck2 = 22 Or memloccheck3 = 22 Or memloccheck4 = 22 Or memloccheck5 = 22 Then
            e.Graphics.DrawPolygon(orangepen, footr) 'rt foot rear
            e.Graphics.FillPolygon(orangeBrush, footr) 'rtfoot rear
            e.Graphics.DrawPolygon(orangepen, footl) 'ltfoot rear
            e.Graphics.FillPolygon(orangeBrush, footl) 'lt foot rear
        End If
        If memloccheck1 = 23 Or memloccheck2 = 23 Or memloccheck3 = 23 Or memloccheck4 = 23 Or memloccheck5 = 23 Then
            e.Graphics.FillPolygon(orangeBrush, forehead) 'forehead
        End If
        If memloccheck1 = 24 Or memloccheck2 = 24 Or memloccheck3 = 24 Or memloccheck4 = 24 Or memloccheck5 = 24 Then
            e.Graphics.DrawPolygon(redpen, face) 'top of head back
            e.Graphics.FillPolygon(redBrush, face) 'top of head back
        End If
        If memloccheck1 = 25 Or memloccheck2 = 25 Or memloccheck3 = 25 Or memloccheck4 = 25 Or memloccheck5 = 25 Then
            e.Graphics.DrawPolygon(orangepen, rear) 'r rear
            e.Graphics.FillPolygon(orangeBrush, rear) 'r rear

            e.Graphics.DrawPolygon(orangepen, lear) 'l rear
            e.Graphics.FillPolygon(orangeBrush, lear) 'l rear
        End If
        If memloccheck1 = 26 Or memloccheck2 = 26 Or memloccheck3 = 26 Or memloccheck4 = 26 Or memloccheck5 = 26 Then
            e.Graphics.DrawPolygon(orangepen, neck) 'neck
            e.Graphics.FillPolygon(orangeBrush, neck) 'neck
        End If
        If memloccheck1 = 27 Or memloccheck2 = 27 Or memloccheck3 = 27 Or memloccheck4 = 27 Or memloccheck5 = 27 Then
            e.Graphics.DrawPolygon(yellowpen, clavicall) 'clavical r
            e.Graphics.FillPolygon(yellowBrush, clavicall) 'clavical r
            e.Graphics.DrawPolygon(yellowpen, clavicalr) 'clavical l
            e.Graphics.FillPolygon(yellowBrush, clavicalr) 'clavical l
        End If
        If memloccheck1 = 28 Or memloccheck2 = 28 Or memloccheck3 = 28 Or memloccheck4 = 28 Or memloccheck5 = 28 Then
            e.Graphics.DrawPolygon(redpen, armpitr) 'shoulder r 
            e.Graphics.FillPolygon(redBrush, armpitr) 'shoulder r
            e.Graphics.DrawPolygon(redpen, armpitl) 'shoulder l
            e.Graphics.FillPolygon(redBrush, armpitl) 'shoulder l
        End If
        If memloccheck1 = 29 Or memloccheck2 = 29 Or memloccheck3 = 29 Or memloccheck4 = 29 Or memloccheck5 = 29 Then
            e.Graphics.DrawPolygon(yellowpen, innerarmr) 'inner arm right
            e.Graphics.FillPolygon(yellowBrush, innerarmr) 'inner arm right
            e.Graphics.DrawPolygon(yellowpen, innerarml) 'inner arm left
            e.Graphics.FillPolygon(yellowBrush, innerarml) 'inner arm left
        End If
        If memloccheck1 = 30 Or memloccheck2 = 30 Or memloccheck3 = 30 Or memloccheck4 = 30 Or memloccheck5 = 30 Then
            e.Graphics.DrawPolygon(bluepen, shoulderr) 'right shoulder
            e.Graphics.FillPolygon(blueBrush, shoulderr) 'right shoulder
            e.Graphics.DrawPolygon(bluepen, shoulderl) 'left shoulder
            e.Graphics.FillPolygon(blueBrush, shoulderl) 'left shoulder
        End If
        If memloccheck1 = 31 Or memloccheck2 = 31 Or memloccheck3 = 31 Or memloccheck4 = 31 Or memloccheck5 = 31 Then
            e.Graphics.DrawPolygon(bluepen, biceptr) 'bicept right
            e.Graphics.FillPolygon(blueBrush, biceptr) 'bicept right
            e.Graphics.DrawPolygon(bluepen, biceptl) 'bicept left
            e.Graphics.FillPolygon(blueBrush, biceptl) 'bicept left
        End If
        If memloccheck1 = 32 Or memloccheck2 = 32 Or memloccheck3 = 32 Or memloccheck4 = 32 Or memloccheck5 = 32 Then
            e.Graphics.DrawPolygon(orangepen, felbowr) 'elbow front right
            e.Graphics.FillPolygon(orangeBrush, felbowr) 'elbow front right
            e.Graphics.DrawPolygon(orangepen, felbowl) 'elbow front left
            e.Graphics.FillPolygon(orangeBrush, felbowl) 'elbow front left
        End If
        If memloccheck1 = 33 Or memloccheck2 = 33 Or memloccheck3 = 33 Or memloccheck4 = 33 Or memloccheck5 = 33 Then
            e.Graphics.DrawPolygon(bluepen, forarmr) 'fore arm front right
            e.Graphics.FillPolygon(blueBrush, forarmr) 'fore arm front right
            e.Graphics.DrawPolygon(bluepen, forarml) 'fore arm front left
            e.Graphics.FillPolygon(blueBrush, forarml) 'fore arm front left
        End If
        If memloccheck1 = 34 Or memloccheck2 = 34 Or memloccheck3 = 34 Or memloccheck4 = 34 Or memloccheck5 = 34 Then
            e.Graphics.DrawPolygon(yellowpen, wristr) 'wrist right
            e.Graphics.FillPolygon(yellowBrush, wristr) 'wrist right
            e.Graphics.DrawPolygon(yellowpen, wristl) 'wrist left
            e.Graphics.FillPolygon(yellowBrush, wristl) 'wrist left
        End If
        If memloccheck1 = 35 Or memloccheck2 = 35 Or memloccheck3 = 35 Or memloccheck4 = 35 Or memloccheck5 = 35 Then
            e.Graphics.DrawPolygon(redpen, thumbl) ' hand right
            e.Graphics.FillPolygon(redBrush, thumbl) 'hand right
            e.Graphics.DrawPolygon(redpen, thumbr) 'hand left
            e.Graphics.FillPolygon(redBrush, thumbr) 'hand left
        End If
        If memloccheck1 = 36 Or memloccheck2 = 36 Or memloccheck3 = 36 Or memloccheck4 = 36 Or memloccheck5 = 36 Then
            e.Graphics.FillRectangle(yellowBrush, 670, 191, 175, 46) 'sternum 1
            e.Graphics.FillRectangle(yellowBrush, 680, 237, 155, 60) 'sternum 2
            e.Graphics.FillRectangle(yellowBrush, 715, 297, 70, 52) 'sternum 3

            e.Graphics.FillRectangle(yellowBrush, 715, 349, 19, 31) 'sternum r 
            e.Graphics.FillRectangle(yellowBrush, 765, 349, 20, 31) 'sternum l
        End If
        If memloccheck1 = 37 Or memloccheck2 = 37 Or memloccheck3 = 37 Or memloccheck4 = 37 Or memloccheck5 = 37 Then
            e.Graphics.FillRectangle(redBrush, 734, 349, 31, 30) 'sternum bottom
        End If
        If memloccheck1 = 38 Or memloccheck2 = 38 Or memloccheck3 = 38 Or memloccheck4 = 38 Or memloccheck5 = 38 Then
            e.Graphics.DrawPolygon(orangepen, innerribr) 'inner rib right
            e.Graphics.FillPolygon(orangeBrush, innerribr) 'inner rib right
            e.Graphics.DrawPolygon(orangepen, innerribl) 'inner rib left
            e.Graphics.FillPolygon(orangeBrush, innerribl) 'inner rib left
        End If
        If memloccheck1 = 39 Or memloccheck2 = 39 Or memloccheck3 = 39 Or memloccheck4 = 39 Or memloccheck5 = 39 Then
            e.Graphics.DrawPolygon(yellowpen, abdomen) 'abdomen
            e.Graphics.FillPolygon(yellowBrush, abdomen) 'abdomen
        End If
        If memloccheck1 = 40 Or memloccheck2 = 40 Or memloccheck3 = 40 Or memloccheck4 = 40 Or memloccheck5 = 40 Then
            e.Graphics.FillRectangle(greenBrush, 712, 438, 80, 40) 'Middriff
        End If
        If memloccheck1 = 41 Or memloccheck2 = 41 Or memloccheck3 = 41 Or memloccheck4 = 41 Or memloccheck5 = 41 Then
            e.Graphics.DrawPolygon(yellowpen, hipr) 'hip right
            e.Graphics.FillPolygon(yellowBrush, hipr) 'hip right
            e.Graphics.DrawPolygon(yellowpen, hipl) 'hip left
            e.Graphics.FillPolygon(yellowBrush, hipl) 'hip left
        End If
        If memloccheck1 = 42 Or memloccheck2 = 42 Or memloccheck3 = 42 Or memloccheck4 = 42 Or memloccheck5 = 42 Then
            e.Graphics.DrawPolygon(orangepen, inthigh) 'inner thigh
            e.Graphics.FillPolygon(orangeBrush, inthigh) 'inner thigh
        End If
        If memloccheck1 = 43 Or memloccheck2 = 43 Or memloccheck3 = 43 Or memloccheck4 = 43 Or memloccheck5 = 43 Then
            e.Graphics.FillRectangle(redBrush, 728, 478, 50, 50) 'crotch
        End If
        If memloccheck1 = 44 Or memloccheck2 = 44 Or memloccheck3 = 44 Or memloccheck4 = 44 Or memloccheck5 = 44 Then
            e.Graphics.DrawPolygon(bluepen, rtthigh) 'rt thigh
            e.Graphics.FillPolygon(blueBrush, rtthigh) 'rt thigh
            e.Graphics.DrawPolygon(bluepen, ltthigh) ' lt thigh
            e.Graphics.FillPolygon(blueBrush, ltthigh) 'lt thigh
        End If
        If memloccheck1 = 45 Or memloccheck2 = 45 Or memloccheck3 = 45 Or memloccheck4 = 45 Or memloccheck5 = 45 Then
            e.Graphics.DrawPolygon(orangepen, rtknee) 'rt knee
            e.Graphics.FillPolygon(orangeBrush, rtknee) 'rt kneee
            e.Graphics.DrawPolygon(orangepen, ltknee) 'lt knee
            e.Graphics.FillPolygon(orangeBrush, ltknee) 'lt knee
        End If
        If memloccheck1 = 46 Or memloccheck2 = 46 Or memloccheck3 = 46 Or memloccheck4 = 46 Or memloccheck5 = 46 Then
            e.Graphics.DrawPolygon(greenpen, rshin) 'shin right 1
            e.Graphics.FillPolygon(greenBrush, rshin) 'shin right 2
            e.Graphics.DrawPolygon(greenpen, rlshin) 'shin right 3
            e.Graphics.FillPolygon(greenBrush, rlshin) 'shin right 4
            e.Graphics.DrawPolygon(greenpen, lshin) 'shin left
            e.Graphics.FillPolygon(greenBrush, lshin) 'shin left
            e.Graphics.DrawPolygon(greenpen, llshin) 'shin left
            e.Graphics.FillPolygon(greenBrush, llshin) 'shin left
        End If
        If memloccheck1 = 47 Or memloccheck2 = 47 Or memloccheck3 = 47 Or memloccheck4 = 47 Or memloccheck5 = 47 Then
            e.Graphics.DrawPolygon(redpen, rankle) ' r ankle
            e.Graphics.FillPolygon(redBrush, rankle) 'r ankle
            e.Graphics.DrawPolygon(redpen, lankle) 'l ankle
            e.Graphics.FillPolygon(redBrush, lankle) 'l ankle
        End If
        If memloccheck1 = 48 Or memloccheck2 = 48 Or memloccheck3 = 48 Or memloccheck4 = 48 Or memloccheck5 = 48 Then
            e.Graphics.DrawPolygon(orangepen, rfoot) 'r foot
            e.Graphics.FillPolygon(orangeBrush, rfoot) ' r foot
            e.Graphics.DrawPolygon(orangepen, lfoot) 'l foot
            e.Graphics.FillPolygon(orangeBrush, lfoot) 'l foot
        End If
        If memloccheck1 = 49 Or memloccheck2 = 49 Or memloccheck3 = 49 Or memloccheck4 = 49 Or memloccheck5 = 49 Then
            e.Graphics.DrawPolygon(redpen, rtoes) 'r toes
            e.Graphics.FillPolygon(redBrush, rtoes) 'r toes
            e.Graphics.DrawPolygon(redpen, ltoes) 'l toes
            e.Graphics.FillPolygon(redBrush, ltoes) 'l toes
        End If

    End Sub

    ' polygon location for back
    Dim thp1 As New Point(199, 47)
    Dim thp2 As New Point(205, 36)
    Dim thp3 As New Point(211, 29)
    Dim thp4 As New Point(221, 20)
    Dim thp5 As New Point(231, 17)
    Dim thp6 As New Point(245, 16)
    Dim thp7 As New Point(256, 18)
    Dim thp8 As New Point(268, 26)
    Dim thp9 As New Point(276, 34)
    Dim thp10 As New Point(280, 41)
    Dim thp11 As New Point(282, 47)
    Dim thp As Point() = {thp1, thp2, thp3, thp4, thp5, thp6, thp7, thp8, thp9, thp10, thp11}

    Dim ltear1 As New Point(183, 86)
    Dim ltear2 As New Point(191, 81)
    Dim ltear3 As New Point(202, 116)
    Dim ltear4 As New Point(196, 113)
    Dim ltear5 As New Point(188, 101)
    Dim ltear6 As New Point(183, 94)
    Dim leftear As Point() = {ltear1, ltear2, ltear3, ltear4, ltear5, ltear6}

    Dim rtear1 As New Point(290, 80)
    Dim rtear2 As New Point(292, 84)
    Dim rtear3 As New Point(292, 94)
    Dim rtear4 As New Point(283, 109)
    Dim rtear5 As New Point(280, 114)
    Dim rtear6 As New Point(274, 115)
    Dim rightear As Point() = {rtear1, rtear2, rtear3, rtear4, rtear5, rtear6}

    Dim basskul1 As New Point(193, 80)
    Dim basskul2 As New Point(286, 80)
    Dim basskul3 As New Point(271, 117)
    Dim basskul4 As New Point(204, 117)
    Dim basskul As Point() = {basskul1, basskul2, basskul3, basskul4}

    Dim spine1 As New Point(208, 153)
    Dim spine2 As New Point(274, 153)
    Dim spine3 As New Point(262, 439)
    Dim spine4 As New Point(224, 439)
    Dim spine As Point() = {spine1, spine2, spine3, spine4}

    Dim rtshoulder1 As New Point(206, 154)
    Dim rtshoulder2 As New Point(150, 188)
    Dim rtshoulder3 As New Point(150, 264)
    Dim rtshoulder4 As New Point(211, 264)
    Dim rtshoulder As Point() = {rtshoulder1, rtshoulder2, rtshoulder3, rtshoulder4}

    Dim ltshoulder1 As New Point(275, 155)
    Dim ltshoulder2 As New Point(334, 193)
    Dim ltshoulder3 As New Point(334, 264)
    Dim ltshoulder4 As New Point(271, 264)
    Dim ltshoulder As Point() = {ltshoulder1, ltshoulder2, ltshoulder3, ltshoulder4}

    Dim rtdel1 As New Point(97, 266)
    Dim rtdel2 As New Point(99, 244)
    Dim rtdel3 As New Point(110, 215)
    Dim rtdel4 As New Point(130, 195)
    Dim rtdel5 As New Point(149, 187)
    Dim rtdel6 As New Point(149, 266)
    Dim rtdel As Point() = {rtdel1, rtdel2, rtdel3, rtdel4, rtdel5, rtdel6}

    Dim ltdel1 As New Point(335, 192)
    Dim ltdel2 As New Point(345, 197)
    Dim ltdel3 As New Point(362, 217)
    Dim ltdel4 As New Point(370, 237)
    Dim ltdel5 As New Point(372, 264)

    Dim ltdel6 As New Point(336, 261)
    Dim ltdel As Point() = {ltdel1, ltdel2, ltdel3, ltdel4, ltdel5, ltdel6}

    Dim rtelbow1 As New Point(98, 268)
    Dim rtelbow2 As New Point(100, 296)
    Dim rtelbow3 As New Point(83, 369)
    Dim rtelbow4 As New Point(126, 369)
    Dim rtelbow5 As New Point(147, 315)
    Dim rtelbow6 As New Point(149, 268)
    Dim rtelbow As Point() = {rtelbow1, rtelbow2, rtelbow3, rtelbow4, rtelbow5, rtelbow6}
    Dim ltelbow1 As New Point(336, 262)
    Dim ltelbow2 As New Point(326, 309)
    Dim ltelbow3 As New Point(345, 377)
    Dim ltelbow4 As New Point(396, 376)
    Dim ltelbow5 As New Point(389, 346)
    Dim ltelbow6 As New Point(373, 266)
    Dim ltelbow As Point() = {ltelbow1, ltelbow2, ltelbow3, ltelbow4, ltelbow5, ltelbow6}

    Dim rtforearmrear1 As New Point(82, 370)
    Dim rtforearmrear2 As New Point(73, 433)
    Dim rtforearmrear3 As New Point(64, 467)
    Dim rtforearmrear4 As New Point(96, 467)
    Dim rtforearmrear5 As New Point(109, 433)
    Dim rtforearmrear6 As New Point(123, 403)
    Dim rtforearmrear7 As New Point(127, 373)
    Dim rtforearmrear8 As New Point(125, 369)
    Dim rtforearmrear As Point() = {rtforearmrear1, rtforearmrear2, rtforearmrear3, rtforearmrear4, rtforearmrear5, rtforearmrear6, rtforearmrear7, rtforearmrear8}

    Dim ltforearmrear1 As New Point(345, 377)
    Dim ltforearmrear2 As New Point(361, 423)
    Dim ltforearmrear3 As New Point(371, 448)
    Dim ltforearmrear4 As New Point(384, 471)
    Dim ltforearmrear5 As New Point(420, 471)
    Dim ltforearmrear6 As New Point(409, 438)
    Dim ltforearmrear7 As New Point(405, 423)
    Dim ltforearmrear8 As New Point(405, 400)
    Dim ltforearmrear9 As New Point(397, 377)
    Dim ltforearmrear As Point() = {ltforearmrear1, ltforearmrear2, ltforearmrear3, ltforearmrear4, ltforearmrear5, ltforearmrear6, ltforearmrear7, ltforearmrear8, ltforearmrear9}

    Dim rtwrist1 As New Point(63, 469)
    Dim rtwrist2 As New Point(51, 488)
    Dim rtwrist3 As New Point(47, 493)
    Dim rtwrist4 As New Point(89, 496)
    Dim rtwrist5 As New Point(90, 482)
    Dim rtwrist6 As New Point(96, 469)
    Dim rtwrist As Point() = {rtwrist1, rtwrist2, rtwrist3, rtwrist4, rtwrist5, rtwrist6}

    Dim ltwrist1 As New Point(385, 474)
    Dim ltwrist2 As New Point(393, 498)
    Dim ltwrist3 As New Point(435, 493)
    Dim ltwrist4 As New Point(425, 483)
    Dim ltwrist5 As New Point(423, 473)
    Dim ltwrist As Point() = {ltwrist1, ltwrist2, ltwrist3, ltwrist4, ltwrist5}

    Dim rthand1 As New Point(48, 492)
    Dim rthand2 As New Point(46, 509)
    Dim rthand3 As New Point(45, 516)
    Dim rthand4 As New Point(48, 527)
    Dim rthand5 As New Point(42, 540)
    Dim rthand6 As New Point(81, 541)
    Dim rthand7 As New Point(84, 532)
    Dim rthand8 As New Point(83, 527)
    Dim rthand9 As New Point(89, 513)
    Dim rthand10 As New Point(90, 492)
    Dim rthand As Point() = {rthand1, rthand2, rthand3, rthand4, rthand5, rthand6, rthand7, rthand8, rthand9, rthand10}

    Dim lthand1 As New Point(393, 495)
    Dim lthand2 As New Point(393, 517)
    Dim lthand3 As New Point(402, 535)
    Dim lthand4 As New Point(400, 542)
    Dim lthand5 As New Point(439, 544)
    Dim lthand6 As New Point(450, 542)
    Dim lthand7 As New Point(438, 495)
    Dim lthand As Point() = {lthand1, lthand2, lthand3, lthand4, lthand5, lthand6, lthand7}

    Dim rtthumb1 As New Point(44, 495)
    Dim rtthumb2 As New Point(26, 511)
    Dim rtthumb3 As New Point(13, 528)
    Dim rtthumb4 As New Point(12, 538)
    Dim rtthumb5 As New Point(19, 531)
    Dim rtthumb6 As New Point(34, 522)
    Dim rtthumb7 As New Point(41, 508)
    Dim rtthumb As Point() = {rtthumb1, rtthumb2, rtthumb3, rtthumb4, rtthumb5, rtthumb6, rtthumb7}

    Dim rtpointfinger1 As New Point(41, 540)
    Dim rtpointfinger2 As New Point(28, 562)
    Dim rtpointfinger3 As New Point(27, 568)
    Dim rtpointfinger4 As New Point(24, 575)
    Dim rtpointfinger5 As New Point(30, 575)
    Dim rtpointfinger6 As New Point(37, 558)
    Dim rtpointfinger7 As New Point(45, 542)
    Dim rtpointfinger As Point() = {rtpointfinger1, rtpointfinger2, rtpointfinger3, rtpointfinger4, rtpointfinger5, rtpointfinger6, rtpointfinger7}

    Dim rtmiddlefinger1 As New Point(49, 544)
    Dim rtmiddlefinger2 As New Point(43, 577)
    Dim rtmiddlefinger3 As New Point(47, 583)
    Dim rtmiddlefinger4 As New Point(47, 566)
    Dim rtmiddlefinger5 As New Point(58, 544)
    Dim rtmiddlefinger As Point() = {rtmiddlefinger1, rtmiddlefinger2, rtmiddlefinger3, rtmiddlefinger4, rtmiddlefinger5}

    Dim rtindexfinger1 As New Point(62, 544)
    Dim rtindexfinger2 As New Point(57, 575)
    Dim rtindexfinger3 As New Point(62, 580)
    Dim rtindexfinger4 As New Point(61, 574)
    Dim rtindexfinger5 As New Point(64, 569)
    Dim rtindexfinger6 As New Point(64, 562)
    Dim rtindexfinger7 As New Point(71, 545)
    Dim rtindexfinger As Point() = {rtindexfinger1, rtindexfinger2, rtindexfinger3, rtindexfinger4, rtindexfinger5, rtindexfinger6, rtindexfinger7}

    Dim rtpinkyfinger1 As New Point(73, 545)
    Dim rtpinkyfinger2 As New Point(75, 563)
    Dim rtpinkyfinger3 As New Point(73, 574)
    Dim rtpinkyfinger4 As New Point(76, 574)
    Dim rtpinkyfinger5 As New Point(76, 559)
    Dim rtpinkyfinger6 As New Point(82, 553)
    Dim rtpinkyfinger7 As New Point(81, 547)
    Dim rtpinkyfinger As Point() = {rtpinkyfinger1, rtpinkyfinger2, rtpinkyfinger3, rtpinkyfinger4, rtpinkyfinger5, rtpinkyfinger6, rtpinkyfinger7}

    Dim ltpinkyfinger1 As New Point(401, 544)
    Dim ltpinkyfinger2 As New Point(402, 556)
    Dim ltpinkyfinger3 As New Point(404, 575)
    Dim ltpinkyfinger4 As New Point(411, 557)
    Dim ltpinkyfinger5 As New Point(411, 544)
    Dim ltpinkyfinger As Point() = {ltpinkyfinger1, ltpinkyfinger2, ltpinkyfinger3, ltpinkyfinger4, ltpinkyfinger5}

    Dim ltindexfinger1 As New Point(415, 544)
    Dim ltindexfinger2 As New Point(421, 564)
    Dim ltindexfinger3 As New Point(423, 564)
    Dim ltindexfinger4 As New Point(419, 582)
    Dim ltindexfinger5 As New Point(421, 582)
    Dim ltindexfinger6 As New Point(427, 569)
    Dim ltindexfinger7 As New Point(428, 544)
    Dim ltindexfinger As Point() = {ltindexfinger1, ltindexfinger2, ltindexfinger3, ltindexfinger4, ltindexfinger5, ltindexfinger6, ltindexfinger7}

    Dim ltmiddlefinger1 As New Point(431, 544)
    Dim ltmiddlefinger2 As New Point(435, 570)
    Dim ltmiddlefinger3 As New Point(436, 582)
    Dim ltmiddlefinger4 As New Point(441, 584)
    Dim ltmiddlefinger5 As New Point(440, 547)
    Dim ltmiddlefinger As Point() = {ltmiddlefinger1, ltmiddlefinger2, ltmiddlefinger3, ltmiddlefinger4, ltmiddlefinger5}

    Dim ltpointfinger1 As New Point(441, 547)
    Dim ltpointfinger2 As New Point(450, 565)
    Dim ltpointfinger3 As New Point(452, 574)
    Dim ltpointfinger4 As New Point(458, 574)
    Dim ltpointfinger5 As New Point(458, 559)
    Dim ltpointfinger6 As New Point(449, 546)
    Dim ltpointfinger As Point() = {ltpointfinger1, ltpointfinger2, ltpointfinger3, ltpointfinger4, ltpointfinger5, ltpointfinger6}

    Dim ltthumb1 As New Point(441, 497)
    Dim ltthumb2 As New Point(473, 526)
    Dim ltthumb3 As New Point(469, 529)
    Dim ltthumb4 As New Point(466, 525)
    Dim ltthumb5 As New Point(443, 516)
    Dim ltthumb As Point() = {ltthumb1, ltthumb2, ltthumb3, ltthumb4, ltthumb5}

    Dim rtmidback1 As New Point(152, 265)
    Dim rtmidback2 As New Point(155, 344)
    Dim rtmidback3 As New Point(161, 384)
    Dim rtmidback4 As New Point(219, 383)
    Dim rtmidback5 As New Point(212, 265)
    Dim rtmidback As Point() = {rtmidback1, rtmidback2, rtmidback3, rtmidback4, rtmidback5}

    Dim ltmidback1 As New Point(271, 264)
    Dim ltmidback2 As New Point(267, 384)
    Dim ltmidback3 As New Point(312, 383)
    Dim ltmidback4 As New Point(310, 347)
    Dim ltmidback5 As New Point(326, 291)
    Dim ltmidback6 As New Point(332, 264)
    Dim ltmidback As Point() = {ltmidback1, ltmidback2, ltmidback3, ltmidback4, ltmidback5, ltmidback6}

    Dim rtlowback1 As New Point(161, 384)
    Dim rtlowback2 As New Point(162, 426)
    Dim rtlowback3 As New Point(161, 439)
    Dim rtlowback4 As New Point(220, 439)
    Dim rtlowback5 As New Point(220, 384)
    Dim rtlowback As Point() = {rtlowback1, rtlowback2, rtlowback3, rtlowback4, rtlowback5}

    Dim ltlowback1 As New Point(267, 384)
    Dim ltlowback2 As New Point(263, 439)
    Dim ltlowback3 As New Point(320, 439)
    Dim ltlowback4 As New Point(312, 414)
    Dim ltlowback5 As New Point(314, 400)
    Dim ltlowback6 As New Point(312, 384)
    Dim ltlowback As Point() = {ltlowback1, ltlowback2, ltlowback3, ltlowback4, ltlowback5, ltlowback6}

    Dim buttocks1 As New Point(159, 441)
    Dim buttocks2 As New Point(153, 464)
    Dim buttocks3 As New Point(151, 484)
    Dim buttocks4 As New Point(145, 518)
    Dim buttocks5 As New Point(148, 542)
    Dim buttocks6 As New Point(205, 542)
    Dim buttocks7 As New Point(220, 543)
    Dim buttocks8 As New Point(239, 535)
    Dim buttocks9 As New Point(240, 441)
    Dim buttocks As Point() = {buttocks1, buttocks2, buttocks3, buttocks4, buttocks5, buttocks6, buttocks7, buttocks8, buttocks9}
    Dim abuttocks1 As New Point(244, 441)
    Dim abuttocks2 As New Point(247, 485)
    Dim abuttocks3 As New Point(247, 526)
    Dim abuttocks4 As New Point(249, 535)
    Dim abuttocks5 As New Point(257, 540)
    Dim abuttocks6 As New Point(335, 540)
    Dim abuttocks7 As New Point(336, 495)
    Dim abuttocks8 As New Point(327, 474)
    Dim abuttocks9 As New Point(321, 441)
    Dim buttocksa As Point() = {abuttocks1, abuttocks2, abuttocks3, abuttocks4, abuttocks5, abuttocks6, abuttocks7, abuttocks8, abuttocks9}

    Dim buttocksb1 As New Point(149, 543)
    Dim buttocksb2 As New Point(202, 541)
    Dim buttocksb3 As New Point(204, 545)
    Dim buttocksb4 As New Point(216, 549)
    Dim buttocksb5 As New Point(238, 543)
    Dim buttocksb6 As New Point(238, 551)
    Dim buttocksb7 As New Point(150, 551)
    Dim buttocksb As Point() = {buttocksb1, buttocksb2, buttocksb3, buttocksb4, buttocksb5, buttocksb6, buttocksb7}

    Dim buttocksc1 As New Point(248, 543)
    Dim buttocksc2 As New Point(263, 546)
    Dim buttocksc3 As New Point(280, 543)
    Dim buttocksc4 As New Point(281, 540)
    Dim buttocksc5 As New Point(335, 540)
    Dim buttocksc6 As New Point(333, 551)
    Dim buttocksc7 As New Point(248, 551)
    Dim buttocksc As Point() = {buttocksc1, buttocksc2, buttocksc3, buttocksc4, buttocksc5, buttocksc6, buttocksc7}

    Dim rtthigh1 As New Point(150, 553)
    Dim rtthigh2 As New Point(167, 643)
    Dim rtthigh3 As New Point(166, 666)
    Dim rtthigh4 As New Point(165, 676)
    Dim rtthigh5 As New Point(167, 695)
    Dim rtthigh6 As New Point(225, 693)
    Dim rtthigh7 As New Point(230, 680)
    Dim rtthigh8 As New Point(230, 642)
    Dim rtthigh9 As New Point(206, 642)
    Dim rtthigh10 As New Point(206, 553)
    Dim rtthighr As Point() = {rtthigh1, rtthigh2, rtthigh3, rtthigh4, rtthigh5, rtthigh6, rtthigh7, rtthigh8, rtthigh9, rtthigh10}

    Dim ltthigh1 As New Point(280, 553)
    Dim ltthigh2 As New Point(280, 640)
    Dim ltthigh3 As New Point(254, 640)
    Dim ltthigh4 As New Point(252, 653)
    Dim ltthigh5 As New Point(256, 695)
    Dim ltthigh6 As New Point(312, 695)
    Dim ltthigh7 As New Point(315, 659)
    Dim ltthigh8 As New Point(312, 647)
    Dim ltthigh9 As New Point(332, 576)
    Dim ltthigh10 As New Point(335, 553)
    Dim ltthighr As Point() = {ltthigh1, ltthigh2, ltthigh3, ltthigh4, ltthigh5, ltthigh6, ltthigh7, ltthigh8, ltthigh9, ltthigh10}

    Dim rinnerthigh1 As New Point(206, 552)
    Dim rinnerthigh2 As New Point(206, 638)
    Dim rinnerthigh3 As New Point(229, 640)
    Dim rinnerthigh4 As New Point(237, 596)
    Dim rinnerthigh5 As New Point(237, 552)
    Dim rinnerthigh As Point() = {rinnerthigh1, rinnerthigh2, rinnerthigh3, rinnerthigh4, rinnerthigh5}

    Dim linnerthigh1 As New Point(248, 552)
    Dim linnerthigh2 As New Point(246, 599)
    Dim linnerthigh3 As New Point(254, 640)
    Dim linnerthigh4 As New Point(279, 640)
    Dim linnerthigh5 As New Point(279, 552)
    Dim linnerthigh As Point() = {linnerthigh1, linnerthigh2, linnerthigh3, linnerthigh4, linnerthigh5}

    Dim rkneerear1 As New Point(168, 698)
    Dim rkneerear2 As New Point(171, 702)
    Dim rkneerear3 As New Point(170, 724)
    Dim rkneerear4 As New Point(174, 729)
    Dim rkneerear5 As New Point(165, 747)
    Dim rkneerear6 As New Point(167, 781)
    Dim rkneerear7 As New Point(177, 828)
    Dim rkneerear8 As New Point(221, 829)
    Dim rkneerear9 As New Point(225, 794)
    Dim rkneerear10 As New Point(219, 759)
    Dim rkneerear11 As New Point(216, 732)
    Dim rkneerear12 As New Point(221, 719)
    Dim rkneerear13 As New Point(222, 698)
    Dim rkneerear As Point() = {rkneerear1, rkneerear2, rkneerear3, rkneerear4, rkneerear5, rkneerear6, rkneerear7, rkneerear8, rkneerear9, rkneerear10, rkneerear11, rkneerear12, rkneerear13}

    Dim lkneerear1 As New Point(254, 698)
    Dim lkneerear2 As New Point(262, 717)
    Dim lkneerear3 As New Point(259, 793)
    Dim lkneerear4 As New Point(272, 829)
    Dim lkneerear5 As New Point(309, 829)
    Dim lkneerear6 As New Point(319, 784)
    Dim lkneerear7 As New Point(321, 781)
    Dim lkneerear8 As New Point(312, 715)
    Dim lkneerear9 As New Point(314, 698)
    Dim lkneerear As Point() = {lkneerear1, lkneerear2, lkneerear3, lkneerear4, lkneerear5, lkneerear6, lkneerear7, lkneerear8, lkneerear9}

    Dim shinbackr1 As New Point(178, 833)
    Dim shinbackr2 As New Point(179, 849)
    Dim shinbackr3 As New Point(181, 897)
    Dim shinbackr4 As New Point(176, 900)
    Dim shinbackr5 As New Point(215, 899)
    Dim shinbackr6 As New Point(213, 893)
    Dim shinbackr7 As New Point(216, 863)
    Dim shinbackr8 As New Point(219, 833)
    Dim shinbackr As Point() = {shinbackr1, shinbackr2, shinbackr3, shinbackr4, shinbackr5, shinbackr6, shinbackr7, shinbackr8}

    Dim shinbackl1 As New Point(270, 833)
    Dim shinbackl2 As New Point(273, 857)
    Dim shinbackl3 As New Point(271, 888)
    Dim shinbackl4 As New Point(267, 900)
    Dim shinbackl5 As New Point(301, 900)
    Dim shinbackl6 As New Point(302, 866)
    Dim shinbackl7 As New Point(308, 833)
    Dim shinbackl As Point() = {shinbackl1, shinbackl2, shinbackl3, shinbackl4, shinbackl5, shinbackl6, shinbackl7}

    Dim ankler1 As New Point(175, 901)
    Dim ankler2 As New Point(176, 903)
    Dim ankler3 As New Point(176, 906)
    Dim ankler4 As New Point(180, 930)
    Dim ankler5 As New Point(179, 946)
    Dim ankler6 As New Point(177, 946)
    Dim ankler7 As New Point(177, 950)
    Dim ankler8 As New Point(207, 950)
    Dim ankler9 As New Point(209, 951)
    Dim ankler10 As New Point(216, 915)
    Dim ankler11 As New Point(215, 901)
    Dim ankler As Point() = {ankler1, ankler2, ankler3, ankler4, ankler5, ankler6, ankler7, ankler8, ankler9, ankler10, ankler11}

    Dim anklel1 As New Point(267, 901)
    Dim anklel2 As New Point(273, 950)
    Dim anklel3 As New Point(310, 950)
    Dim anklel4 As New Point(303, 939)
    Dim anklel5 As New Point(305, 922)
    Dim anklel6 As New Point(303, 901)
    Dim anklel As Point() = {anklel1, anklel2, anklel3, anklel4, anklel5, anklel6}

    Dim footl1 As New Point(177, 951)
    Dim footl2 As New Point(171, 959)
    Dim footl3 As New Point(162, 980)
    Dim footl4 As New Point(168, 984)
    Dim footl5 As New Point(214, 979)
    Dim footl6 As New Point(216, 972)
    Dim footl7 As New Point(210, 963)
    Dim footl8 As New Point(211, 951)
    Dim footl As Point() = {footl1, footl3, footl3, footl4, footl5, footl6, footl7, footl8}

    Dim footr1 As New Point(273, 951)
    Dim footr2 As New Point(274, 968)
    Dim footr3 As New Point(273, 983)
    Dim footr4 As New Point(303, 983)
    Dim footr5 As New Point(313, 984)
    Dim footr6 As New Point(316, 982)
    Dim footr7 As New Point(323, 982)
    Dim footr8 As New Point(312, 962)
    Dim footr9 As New Point(310, 951)
    Dim footr As Point() = {footr1, footr2, footr3, footr4, footr5, footr6, footr7, footr8, footr9}

    Private Sub undoBtn_Click(sender As Object, e As EventArgs) Handles undoBtn.Click
        unpopulate()
        Dim total As Integer
        total = memcheck1 + memcheck2 + memcheck3 + memcheck4 + memcheck5

        If total = 1 Then
            memloccheck1 = 0
            memcheck1 = 0
            total -= 1
        End If
        If total = 2 Then
            memloccheck2 = 0
            memcheck2 = 0
            total -= 1
        End If
        If total = 3 Then
            memloccheck3 = 0
            memcheck3 = 0
            total -= 1
        End If
        If total = 4 Then
            memloccheck4 = 0
            memcheck4 = 0
            total -= 1
        End If
        If total = 5 Then
            memloccheck5 = 0
            memcheck5 = 0
            total -= 1
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Questionair2.Show()
        Me.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        saveinfo2(19) = Staylabel1.Text
        saveinfo2(20) = Staylabel2.Text
        saveinfo2(21) = Staylabel3.Text
        saveinfo2(22) = Staylabel4.Text
        saveinfo2(23) = Staylabel5.Text
        artistselect.Show()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        saveinfo2(19) = Staylabel1.Text
        saveinfo2(20) = Staylabel2.Text
        saveinfo2(21) = Staylabel3.Text
        saveinfo2(22) = Staylabel4.Text
        saveinfo2(23) = Staylabel5.Text

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