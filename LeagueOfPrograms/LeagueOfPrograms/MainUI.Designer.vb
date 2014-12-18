<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.timerPing = New System.Windows.Forms.Timer(Me.components)
        Me.lblping = New System.Windows.Forms.Label()
        Me.imgBackground = New System.Windows.Forms.PictureBox()
        Me.imgTopBar = New System.Windows.Forms.PictureBox()
        Me.imgBottomBar = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.imgExitButton = New System.Windows.Forms.PictureBox()
        CType(Me.imgBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTopBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBottomBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerPing
        '
        Me.timerPing.Enabled = True
        Me.timerPing.Interval = 10000
        '
        'lblping
        '
        Me.lblping.AutoSize = True
        Me.lblping.BackColor = System.Drawing.Color.Black
        Me.lblping.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblping.ForeColor = System.Drawing.Color.Green
        Me.lblping.Location = New System.Drawing.Point(1072, 11)
        Me.lblping.Name = "lblping"
        Me.lblping.Size = New System.Drawing.Size(92, 20)
        Me.lblping.TabIndex = 1
        Me.lblping.Text = "Connecting..."
        '
        'imgBackground
        '
        Me.imgBackground.BackgroundImage = CType(resources.GetObject("imgBackground.BackgroundImage"), System.Drawing.Image)
        Me.imgBackground.Location = New System.Drawing.Point(-1, 71)
        Me.imgBackground.Name = "imgBackground"
        Me.imgBackground.Size = New System.Drawing.Size(1288, 626)
        Me.imgBackground.TabIndex = 2
        Me.imgBackground.TabStop = False
        '
        'imgTopBar
        '
        Me.imgTopBar.BackgroundImage = CType(resources.GetObject("imgTopBar.BackgroundImage"), System.Drawing.Image)
        Me.imgTopBar.Location = New System.Drawing.Point(0, 0)
        Me.imgTopBar.Name = "imgTopBar"
        Me.imgTopBar.Size = New System.Drawing.Size(1281, 74)
        Me.imgTopBar.TabIndex = 3
        Me.imgTopBar.TabStop = False
        '
        'imgBottomBar
        '
        Me.imgBottomBar.BackgroundImage = CType(resources.GetObject("imgBottomBar.BackgroundImage"), System.Drawing.Image)
        Me.imgBottomBar.Location = New System.Drawing.Point(-1, 658)
        Me.imgBottomBar.Name = "imgBottomBar"
        Me.imgBottomBar.Size = New System.Drawing.Size(1282, 36)
        Me.imgBottomBar.TabIndex = 4
        Me.imgBottomBar.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(11, 140)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(11, 190)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(11, 240)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(11, 290)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox7.TabIndex = 8
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(11, 339)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox8.TabIndex = 9
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(11, 389)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox9.TabIndex = 10
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(11, 439)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox10.TabIndex = 11
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackgroundImage = CType(resources.GetObject("PictureBox11.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(11, 489)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox11.TabIndex = 12
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(11, 539)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox12.TabIndex = 13
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(11, 589)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(143, 50)
        Me.PictureBox13.TabIndex = 14
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackgroundImage = CType(resources.GetObject("PictureBox14.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(11, 92)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(143, 49)
        Me.PictureBox14.TabIndex = 15
        Me.PictureBox14.TabStop = False
        '
        'imgExitButton
        '
        Me.imgExitButton.BackgroundImage = CType(resources.GetObject("imgExitButton.BackgroundImage"), System.Drawing.Image)
        Me.imgExitButton.Location = New System.Drawing.Point(1250, 0)
        Me.imgExitButton.Name = "imgExitButton"
        Me.imgExitButton.Size = New System.Drawing.Size(29, 23)
        Me.imgExitButton.TabIndex = 16
        Me.imgExitButton.TabStop = False
        '
        'MainUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 695)
        Me.Controls.Add(Me.lblping)
        Me.Controls.Add(Me.imgExitButton)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.imgBottomBar)
        Me.Controls.Add(Me.imgTopBar)
        Me.Controls.Add(Me.imgBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainUI"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AboutBox1"
        CType(Me.imgBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTopBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBottomBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerPing As System.Windows.Forms.Timer
    Friend WithEvents lblping As System.Windows.Forms.Label
    Friend WithEvents imgBackground As System.Windows.Forms.PictureBox
    Friend WithEvents imgTopBar As System.Windows.Forms.PictureBox
    Friend WithEvents imgBottomBar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents imgExitButton As System.Windows.Forms.PictureBox

End Class
