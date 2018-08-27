<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calendar
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
        Me.nextmonthbtn = New System.Windows.Forms.Button()
        Me.prevmonthbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nextmonthbtn
        '
        Me.nextmonthbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextmonthbtn.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextmonthbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nextmonthbtn.Location = New System.Drawing.Point(695, 875)
        Me.nextmonthbtn.Name = "nextmonthbtn"
        Me.nextmonthbtn.Size = New System.Drawing.Size(204, 74)
        Me.nextmonthbtn.TabIndex = 3
        Me.nextmonthbtn.Text = "Button2"
        Me.nextmonthbtn.UseVisualStyleBackColor = True
        '
        'prevmonthbtn
        '
        Me.prevmonthbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prevmonthbtn.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevmonthbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.prevmonthbtn.Location = New System.Drawing.Point(53, 875)
        Me.prevmonthbtn.Name = "prevmonthbtn"
        Me.prevmonthbtn.Size = New System.Drawing.Size(204, 74)
        Me.prevmonthbtn.TabIndex = 2
        Me.prevmonthbtn.Text = "Button1"
        Me.prevmonthbtn.UseVisualStyleBackColor = True
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.nextmonthbtn)
        Me.Controls.Add(Me.prevmonthbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nextmonthbtn As Button
    Friend WithEvents prevmonthbtn As Button
End Class
