<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TOS))
        Me.imgBG = New System.Windows.Forms.PictureBox()
        Me.imgOK = New System.Windows.Forms.PictureBox()
        Me.rtbTOS = New System.Windows.Forms.RichTextBox()
        CType(Me.imgBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBG
        '
        Me.imgBG.BackgroundImage = CType(resources.GetObject("imgBG.BackgroundImage"), System.Drawing.Image)
        Me.imgBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgBG.Location = New System.Drawing.Point(-17, -4)
        Me.imgBG.Name = "imgBG"
        Me.imgBG.Size = New System.Drawing.Size(470, 533)
        Me.imgBG.TabIndex = 0
        Me.imgBG.TabStop = False
        '
        'imgOK
        '
        Me.imgOK.BackgroundImage = CType(resources.GetObject("imgOK.BackgroundImage"), System.Drawing.Image)
        Me.imgOK.Location = New System.Drawing.Point(152, 464)
        Me.imgOK.Name = "imgOK"
        Me.imgOK.Size = New System.Drawing.Size(126, 36)
        Me.imgOK.TabIndex = 1
        Me.imgOK.TabStop = False
        '
        'rtbTOS
        '
        Me.rtbTOS.BackColor = System.Drawing.Color.Black
        Me.rtbTOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbTOS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTOS.ForeColor = System.Drawing.Color.White
        Me.rtbTOS.Location = New System.Drawing.Point(36, 91)
        Me.rtbTOS.Name = "rtbTOS"
        Me.rtbTOS.Size = New System.Drawing.Size(363, 357)
        Me.rtbTOS.TabIndex = 3
        Me.rtbTOS.Text = resources.GetString("rtbTOS.Text")
        '
        'TOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 526)
        Me.Controls.Add(Me.rtbTOS)
        Me.Controls.Add(Me.imgOK)
        Me.Controls.Add(Me.imgBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TOS"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutBox1"
        Me.TopMost = True
        CType(Me.imgBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBG As System.Windows.Forms.PictureBox
    Friend WithEvents imgOK As System.Windows.Forms.PictureBox
    Friend WithEvents rtbTOS As System.Windows.Forms.RichTextBox

End Class
