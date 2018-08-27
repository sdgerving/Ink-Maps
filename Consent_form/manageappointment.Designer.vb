<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageappointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nextmonthbtn = New System.Windows.Forms.Button()
        Me.prevmonthbtn = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nextmonthbtn
        '
        Me.nextmonthbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextmonthbtn.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextmonthbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nextmonthbtn.Location = New System.Drawing.Point(707, 875)
        Me.nextmonthbtn.Name = "nextmonthbtn"
        Me.nextmonthbtn.Size = New System.Drawing.Size(204, 74)
        Me.nextmonthbtn.TabIndex = 5
        Me.nextmonthbtn.Text = "Button2"
        Me.nextmonthbtn.UseVisualStyleBackColor = True
        '
        'prevmonthbtn
        '
        Me.prevmonthbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prevmonthbtn.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevmonthbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.prevmonthbtn.Location = New System.Drawing.Point(51, 875)
        Me.prevmonthbtn.Name = "prevmonthbtn"
        Me.prevmonthbtn.Size = New System.Drawing.Size(204, 74)
        Me.prevmonthbtn.TabIndex = 4
        Me.prevmonthbtn.Text = "Button1"
        Me.prevmonthbtn.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.FlatAppearance.BorderSize = 5
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Red
        Me.BackButton.Location = New System.Drawing.Point(367, 875)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(204, 74)
        Me.BackButton.TabIndex = 76
        Me.BackButton.Text = "Exit"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'manageappointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 961)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.nextmonthbtn)
        Me.Controls.Add(Me.prevmonthbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageappointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manageappointment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nextmonthbtn As Button
    Friend WithEvents prevmonthbtn As Button
    Friend WithEvents BackButton As Button
End Class
