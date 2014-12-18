<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.imgBannerSplash = New System.Windows.Forms.PictureBox()
        Me.imgSplash = New System.Windows.Forms.PictureBox()
        Me.imgLaunchButton = New System.Windows.Forms.PictureBox()
        CType(Me.imgBannerSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLaunchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'imgSplash
        '
        Me.imgSplash.BackgroundImage = CType(resources.GetObject("imgSplash.BackgroundImage"), System.Drawing.Image)
        Me.imgSplash.Location = New System.Drawing.Point(0, 67)
        Me.imgSplash.Name = "imgSplash"
        Me.imgSplash.Size = New System.Drawing.Size(1277, 606)
        Me.imgSplash.TabIndex = 1
        Me.imgSplash.TabStop = False
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
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 673)
        Me.Controls.Add(Me.imgLaunchButton)
        Me.Controls.Add(Me.imgSplash)
        Me.Controls.Add(Me.imgBannerSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.imgBannerSplash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSplash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLaunchButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBannerSplash As System.Windows.Forms.PictureBox
    Friend WithEvents imgSplash As System.Windows.Forms.PictureBox
    Friend WithEvents imgLaunchButton As System.Windows.Forms.PictureBox

End Class
