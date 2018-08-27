<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class artistselect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.plpicbox = New System.Windows.Forms.PictureBox()
        Me.jwpicbox = New System.Windows.Forms.PictureBox()
        Me.crpicbox = New System.Windows.Forms.PictureBox()
        Me.pllabel = New System.Windows.Forms.Label()
        Me.jwlabel = New System.Windows.Forms.Label()
        Me.crlabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.warningtxt = New System.Windows.Forms.Label()
        CType(Me.plpicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jwpicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crpicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plpicbox
        '
        Me.plpicbox.BackgroundImage = Global.Consent_form.My.Resources.Resources.face2
        Me.plpicbox.Location = New System.Drawing.Point(99, 215)
        Me.plpicbox.Name = "plpicbox"
        Me.plpicbox.Size = New System.Drawing.Size(140, 175)
        Me.plpicbox.TabIndex = 84
        Me.plpicbox.TabStop = False
        '
        'jwpicbox
        '
        Me.jwpicbox.BackgroundImage = Global.Consent_form.My.Resources.Resources.face3
        Me.jwpicbox.Location = New System.Drawing.Point(425, 215)
        Me.jwpicbox.Name = "jwpicbox"
        Me.jwpicbox.Size = New System.Drawing.Size(140, 175)
        Me.jwpicbox.TabIndex = 85
        Me.jwpicbox.TabStop = False
        '
        'crpicbox
        '
        Me.crpicbox.BackgroundImage = Global.Consent_form.My.Resources.Resources.face5
        Me.crpicbox.Location = New System.Drawing.Point(755, 215)
        Me.crpicbox.Name = "crpicbox"
        Me.crpicbox.Size = New System.Drawing.Size(140, 175)
        Me.crpicbox.TabIndex = 86
        Me.crpicbox.TabStop = False
        '
        'pllabel
        '
        Me.pllabel.AutoSize = True
        Me.pllabel.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pllabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pllabel.Location = New System.Drawing.Point(129, 393)
        Me.pllabel.Name = "pllabel"
        Me.pllabel.Size = New System.Drawing.Size(100, 25)
        Me.pllabel.TabIndex = 87
        Me.pllabel.Text = "Paul Lunetta"
        '
        'jwlabel
        '
        Me.jwlabel.AutoSize = True
        Me.jwlabel.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jwlabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.jwlabel.Location = New System.Drawing.Point(440, 393)
        Me.jwlabel.Name = "jwlabel"
        Me.jwlabel.Size = New System.Drawing.Size(106, 25)
        Me.jwlabel.TabIndex = 88
        Me.jwlabel.Text = "Jazmin Webb"
        '
        'crlabel
        '
        Me.crlabel.AutoSize = True
        Me.crlabel.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crlabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.crlabel.Location = New System.Drawing.Point(767, 393)
        Me.crlabel.Name = "crlabel"
        Me.crlabel.Size = New System.Drawing.Size(128, 25)
        Me.crlabel.TabIndex = 89
        Me.crlabel.Text = "Colt Richardson"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(285, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 25)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Please click the artist you would like to make an appointment with."
        '
        'BackButton
        '
        Me.BackButton.FlatAppearance.BorderSize = 5
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Red
        Me.BackButton.Location = New System.Drawing.Point(12, 875)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(204, 74)
        Me.BackButton.TabIndex = 91
        Me.BackButton.Text = "Go Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.FlatAppearance.BorderSize = 5
        Me.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoButton.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GoButton.Location = New System.Drawing.Point(785, 875)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(187, 74)
        Me.GoButton.TabIndex = 92
        Me.GoButton.Text = "Continue"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'warningtxt
        '
        Me.warningtxt.AutoSize = True
        Me.warningtxt.Font = New System.Drawing.Font("Papyrus", 15.75!, System.Drawing.FontStyle.Bold)
        Me.warningtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.warningtxt.Location = New System.Drawing.Point(310, 839)
        Me.warningtxt.Name = "warningtxt"
        Me.warningtxt.Size = New System.Drawing.Size(397, 33)
        Me.warningtxt.TabIndex = 93
        Me.warningtxt.Text = "Please fill in all the shaded yellow areas."
        Me.warningtxt.Visible = False
        '
        'artistselect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 961)
        Me.Controls.Add(Me.warningtxt)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crlabel)
        Me.Controls.Add(Me.jwlabel)
        Me.Controls.Add(Me.pllabel)
        Me.Controls.Add(Me.crpicbox)
        Me.Controls.Add(Me.jwpicbox)
        Me.Controls.Add(Me.plpicbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "artistselect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "artistselect"
        CType(Me.plpicbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jwpicbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crpicbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents plpicbox As PictureBox
    Friend WithEvents jwpicbox As PictureBox
    Friend WithEvents crpicbox As PictureBox
    Friend WithEvents pllabel As Label
    Friend WithEvents jwlabel As Label
    Friend WithEvents crlabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents warningtxt As Label
End Class
