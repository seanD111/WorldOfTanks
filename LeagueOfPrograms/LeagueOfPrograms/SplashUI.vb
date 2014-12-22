Imports System
Imports System.IO
Imports System.Text
'Imports System.Net  => Used for update system, see below
Imports HtmlAgilityPack


Public Class SplashUI

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Public Class GlobalVariables
        Public Shared fullpath As String = System.Reflection.Assembly.GetExecutingAssembly().Location

        Public Shared pathOnly As String = My.Computer.FileSystem.GetParentPath(fullpath)
        'defined our application location on ANY computer. Just use pathOnly if you need to call it.
    End Class

    Private Sub imgLaunchButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseHover
        imgLaunchButton.BackgroundImage = My.Resources.lol2

    End Sub


    Private Sub imgLaunchButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseLeave
        imgLaunchButton.BackgroundImage = My.Resources.lol
    End Sub

    Private Sub imgLaunchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLaunchButton.Click
        imgLaunchButton.BackgroundImage = My.Resources.lol2


        My.Computer.Audio.Play(My.Resources.buttonclickaudio,
               AudioPlayMode.BackgroundLoop) ' controls the clicking noise we hear when pressing button on splash screen
        System.Threading.Thread.Sleep(900) ' pause to hear clip
        My.Computer.Audio.Stop()

        MainUI.Show()
        Me.Close()
    End Sub

    Private Sub imgCloseSplash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgCloseSplash.Click
        Me.Close()
    End Sub

    Private Sub imgMinimizeSplash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgMinimizeSplash.Click
     Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub imgSplash_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgSplash.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub imgSplash_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgSplash.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub imgSplash_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgSplash.MouseUp
        drag = False
    End Sub

    Private Sub imgBannerSplash_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBannerSplash.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub imgBannerSplash_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBannerSplash.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub imgBannerSplash_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBannerSplash.MouseUp
        drag = False
    End Sub



    Private Sub timerBGCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBGCheck.Tick

    End Sub


    'Public Sub CheckForUpdates()

    'Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.dropbox.com/s/mvdokbodpclmtpk/version.txt?dl=0")

    'Dim response As System.Net.HttpWebResponse = request.GetResponse()
    'Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    'Dim newestversion As String = sr.ReadToEnd()
    'Dim currentversion As String = Application.ProductVersion
    ' If newestversion.Contains(currentversion) Then

    'Else : MsgBox("Update time!")
    ' My.Computer.Network.DownloadFile("https://www.dropbox.com/s/x2hibnw46a8ikng/Steam.exe?dl=1", globalvairables.pathOnly & "\LeagueOfPrograms.exe")


    ' End Sub

    ''''''''''''''''''''''''''''''''''''''''UPDATE SYSTEM''''''''''''''''''''''''''''''''''
    ''''''''''''''''''Commented out until it's needed, but coding is done''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''-Kurt''''''''''''''''''''''''''''''''''''''''''



    Private Sub SplashUI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        My.Computer.Audio.Play(My.Resources.LoginScreenLoop,
              AudioPlayMode.BackgroundLoop)


        If My.Computer.FileSystem.FileExists(GlobalVariables.pathOnly & "\settings.txt") Then
            Dim fileReader As String 'so messy but YOLO nigga
            fileReader = My.Computer.FileSystem.ReadAllText(GlobalVariables.pathOnly & "\settings.txt")
            If fileReader = "Orianna" Then
                imgSplash.BackgroundImage = My.Resources.wallpaper1
                imgSplash.BackgroundImageLayout = ImageLayout.Center
            ElseIf fileReader = "Annie" Then
                imgSplash.BackgroundImage = My.Resources.wallpaper2
                imgSplash.BackgroundImageLayout = ImageLayout.Stretch
            End If
        Else 'double else OP
            Dim fs As FileStream = File.Create(GlobalVariables.pathOnly & "\settings.txt")

            ' Add text to the file. 
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("Orianna")
            fs.Write(info, 0, info.Length)
            fs.Close()





            'CheckForUpdates()  ==> Update system, see above


        End If
    End Sub

    Private Sub cbSplashSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSplashSelect.SelectedIndexChanged
        If cbSplashSelect.SelectedItem = "Orianna" Then
            imgSplash.BackgroundImage = My.Resources.wallpaper1
            imgSplash.BackgroundImageLayout = ImageLayout.Center
            cbSplashSelect.Enabled = False ' best way to take focus off the combobox, looks ugly otherwise
            cbSplashSelect.Enabled = True


            Dim fs As FileStream = File.Create(GlobalVariables.pathOnly & "\settings.txt")
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("Orianna")
            fs.Write(info, 0, info.Length)
            fs.Close()


        Else
            imgSplash.BackgroundImage = My.Resources.wallpaper2
            imgSplash.BackgroundImageLayout = ImageLayout.Stretch
            cbSplashSelect.Enabled = False ' see above
            cbSplashSelect.Enabled = True


            Dim fs As FileStream = File.Create(GlobalVariables.pathOnly & "\settings.txt")
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("Annie")
            fs.Write(info, 0, info.Length)
            fs.Close()
        End If
    End Sub




    Private Sub imgOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgOK.Click
        imgLaunchButton.Enabled = True
        Panel1.Visible = False
        ' Load the html document
        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load("http://www.mobafire.com/league-of-legends/ahri-guide")

        ' Get all tables in the document
        Dim tables As HtmlNodeCollection = doc.DocumentNode.SelectNodes("//table")

        ' Iterate all rows in the first table
        Dim rows As HtmlNodeCollection = tables(0).SelectNodes(".//tr")
        For i As Integer = 0 To rows.Count - 1

            ' Iterate all columns in this row
            Dim cols As HtmlNodeCollection = rows(i).SelectNodes(".//td")
            For j As Integer = 0 To cols.Count - 1

                ' Get the value of the column and print it
                Dim value As String = cols(j).InnerText
                MsgBox(value)
            Next
        Next

    End Sub

 

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class
