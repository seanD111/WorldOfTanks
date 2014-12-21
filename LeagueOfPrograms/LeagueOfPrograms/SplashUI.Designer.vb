<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashUI))
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.timerBGCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.imgRightSide = New System.Windows.Forms.PictureBox()
        Me.imgLeftSideBar = New System.Windows.Forms.PictureBox()
        Me.imgBottomBar = New System.Windows.Forms.PictureBox()
        Me.imgMinimizeSplash = New System.Windows.Forms.PictureBox()
        Me.imgCloseSplash = New System.Windows.Forms.PictureBox()
        Me.imgLaunchButton = New System.Windows.Forms.PictureBox()
        Me.imgSplash = New System.Windows.Forms.PictureBox()
        Me.imgBannerSplash = New System.Windows.Forms.PictureBox()
        CType(Me.imgRightSide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLeftSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBottomBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMinimizeSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCloseSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLaunchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBannerSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Black
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(1088, 49)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(29, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Black
        Me.RadioButton2.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(1125, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(29, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'timerBGCheck
        '
        Me.timerBGCheck.Enabled = True
        Me.timerBGCheck.Interval = 1000
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Black
        Me.lblVersion.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(10, 671)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(32, 16)
        Me.lblVersion.TabIndex = 10
        Me.lblVersion.Text = "1.0.0"
        '
        'imgRightSide
        '
        Me.imgRightSide.BackgroundImage = CType(resources.GetObject("imgRightSide.BackgroundImage"), System.Drawing.Image)
        Me.imgRightSide.Location = New System.Drawing.Point(1267, 67)
        Me.imgRightSide.Name = "imgRightSide"
        Me.imgRightSide.Size = New System.Drawing.Size(10, 625)
        Me.imgRightSide.TabIndex = 9
        Me.imgRightSide.TabStop = False
        '
        'imgLeftSideBar
        '
        Me.imgLeftSideBar.BackgroundImage = CType(resources.GetObject("imgLeftSideBar.BackgroundImage"), System.Drawing.Image)
        Me.imgLeftSideBar.Location = New System.Drawing.Point(0, 67)
        Me.imgLeftSideBar.Name = "imgLeftSideBar"
        Me.imgLeftSideBar.Size = New System.Drawing.Size(10, 625)
        Me.imgLeftSideBar.TabIndex = 8
        Me.imgLeftSideBar.TabStop = False
        '
        'imgBottomBar
        '
        Me.imgBottomBar.BackgroundImage = CType(resources.GetObject("imgBottomBar.BackgroundImage"), System.Drawing.Image)
        Me.imgBottomBar.Location = New System.Drawing.Point(0, 667)
        Me.imgBottomBar.Name = "imgBottomBar"
        Me.imgBottomBar.Size = New System.Drawing.Size(1277, 25)
        Me.imgBottomBar.TabIndex = 7
        Me.imgBottomBar.TabStop = False
        '
        'imgMinimizeSplash
        '
        Me.imgMinimizeSplash.BackgroundImage = CType(resources.GetObject("imgMinimizeSplash.BackgroundImage"), System.Drawing.Image)
        Me.imgMinimizeSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgMinimizeSplash.Location = New System.Drawing.Point(1231, -1)
        Me.imgMinimizeSplash.Name = "imgMinimizeSplash"
        Me.imgMinimizeSplash.Size = New System.Drawing.Size(21, 20)
        Me.imgMinimizeSplash.TabIndex = 4
        Me.imgMinimizeSplash.TabStop = False
        '
        'imgCloseSplash
        '
        Me.imgCloseSplash.BackgroundImage = CType(resources.GetObject("imgCloseSplash.BackgroundImage"), System.Drawing.Image)
        Me.imgCloseSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgCloseSplash.Location = New System.Drawing.Point(1253, 0)
        Me.imgCloseSplash.Name = "imgCloseSplash"
        Me.imgCloseSplash.Size = New System.Drawing.Size(23, 20)
        Me.imgCloseSplash.TabIndex = 3
        Me.imgCloseSplash.TabStop = False
        '
        'imgLaunchButton
        '
        Me.imgLaunchButton.BackgroundImage = CType(resources.GetObject("imgLaunchButton.BackgroundImage"), System.Drawing.Image)
        Me.imgLaunchButton.Location = New System.Drawing.Point(561, 7)
        Me.imgLaunchButton.Name = "imgLaunchButton"
        Me.imgLaunchButton.Size = New System.Drawing.Size(150, 50)
        Me.imgLaunchButton.TabIndex = 2
        Me.imgLaunchButton.TabStop = False
        '
        'imgSplash
        '
        Me.imgSplash.BackgroundImage = CType(resources.GetObject("imgSplash.BackgroundImage"), System.Drawing.Image)
        Me.imgSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgSplash.Location = New System.Drawing.Point(0, 67)
        Me.imgSplash.Name = "imgSplash"
        Me.imgSplash.Size = New System.Drawing.Size(1276, 625)
        Me.imgSplash.TabIndex = 1
        Me.imgSplash.TabStop = False
        '
        'imgBannerSplash
        '
        Me.imgBannerSplash.BackgroundImage = CType(resources.GetObject("imgBannerSplash.BackgroundImage"), System.Drawing.Image)
        Me.imgBannerSplash.Location = New System.Drawing.Point(0, 0)
        Me.imgBannerSplash.Name = "imgBannerSplash"
        Me.imgBannerSplash.Size = New System.Drawing.Size(1277, 68)
        Me.imgBannerSplash.TabIndex = 0
        Me.imgBannerSplash.TabStop = False
        '
        'SplashUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 691)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.imgRightSide)
        Me.Controls.Add(Me.imgLeftSideBar)
        Me.Controls.Add(Me.imgBottomBar)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.imgMinimizeSplash)
        Me.Controls.Add(Me.imgCloseSplash)
        Me.Controls.Add(Me.imgLaunchButton)
        Me.Controls.Add(Me.imgSplash)
        Me.Controls.Add(Me.imgBannerSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.imgRightSide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLeftSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBottomBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMinimizeSplash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCloseSplash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLaunchButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSplash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBannerSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBannerSplash As System.Windows.Forms.PictureBox
    Friend WithEvents imgSplash As System.Windows.Forms.PictureBox
    Friend WithEvents imgLaunchButton As System.Windows.Forms.PictureBox
    Friend WithEvents imgCloseSplash As System.Windows.Forms.PictureBox
    Friend WithEvents imgMinimizeSplash As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents timerBGCheck As System.Windows.Forms.Timer
    Friend WithEvents imgBottomBar As System.Windows.Forms.PictureBox
    Friend WithEvents imgLeftSideBar As System.Windows.Forms.PictureBox
    Friend WithEvents imgRightSide As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label

End Class
