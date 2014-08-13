Imports Microsoft.Win32
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.IO
Imports System.Threading
Public Class Form1

    Dim k As Integer = 1
    Dim k1 As Integer = 1
    '讀取設定檔
    Dim rr1 As Integer = 0
    Dim ispconfig As Integer = 0
    Dim timeconfig As Integer = 0
    Dim ipconfig As Integer = 0
    Dim auto As Integer = 0
    Dim autocheck As Integer = 0
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim readproxy(100)
        Dim fproxy As New FileInfo("C:\proxy\user\" + ListBox1.Text)
        Dim fproxy1 As StreamReader = fproxy.OpenText
        Do

            i = i + 1

            readproxy(i) = fproxy1.ReadLine

        Loop Until readproxy(i) Is Nothing
        Dim orip As String = TextBox1.Text

        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", readproxy(1))
        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", Microsoft.Win32.RegistryValueKind.DWord)
        Process.Start("iexplore.exe", "http://www.yahoo.com.tw")
        TextBox1.Text = a101()
        isp(a101())


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
        Timer1.Interval = 10000
        Timer1.Start()
        Dim now1 As Date = DateTime.Today
        Label3.Text = now1
        'set data.................
        setdata()
        If auto = 1 And BackgroundWorker2.IsBusy = False Then

            BackgroundWorker2.RunWorkerAsync()

        End If
       
        'ip gets...................
        If My.Computer.Network.Ping("74.125.31.94") = True Then
            Do
                'MsgBox(a101)
                TextBox1.Text = a101()
                isp(a101())

            Loop Until Not TextBox1.Text = ""
            For Each a11 As String In System.IO.Directory.GetFileSystemEntries("C:\proxy\user")


                ListBox1.Items.Add(Trim(Replace(a11, "C:\proxy\user\", "")))
            Next




        End If
        'auto設定
        If autocheck = 1 Then
            Button3.PerformClick()
        End If
        'If TextBox1.Text = "" Or TextBox2.Text = "" Then
        '    Form8.Show()
        '    Me.Close()

        'End If
    End Sub
    Sub isp(ByVal str As String)

        If My.Computer.Network.Ping("74.125.31.94") = True And Not str = "偵測中" Then
            My.Computer.Network.DownloadFile("http://rms.twnic.net.tw/twnic/User/Member/Search/main2_2.jsp?queryString=" + str, "C:\proxy\system\ip34.txt", "", "", False, 100000, True)
            Dim i As Integer = 0
            Dim fp2 As StreamReader = New StreamReader("C:\proxy\system\ip34.txt", System.Text.Encoding.Default)
            For i = 0 To 62
                fp2.ReadLine()
            Next
            Dim a12 As String = fp2.ReadLine()


            fp2.Close()
            TextBox2.Text = a12
        Else
            If TextBox2.Text = "" Then
                isp(str)
            End If
        End If



    End Sub
    Public Function a101() As String

        If My.Computer.Network.Ping("74.125.31.94") = True Then
            If File.Exists("C:\proxy\system\ip3.txt") Then
                File.Delete("C:\proxy\system\ip3.txt")
            End If
            Do
                My.Computer.Network.DownloadFile("http://myip.com.tw/", "C:\proxy\system\ip3.txt", "", "", False, 40000, True)




            Loop Until FileLen("C:\proxy\system\ip3.txt") > 0



            Dim fp1 As New FileInfo("C:\proxy\system\ip3.txt")
            Dim fp2 As StreamReader = fp1.OpenText
            fp2.ReadLine()
            fp2.ReadLine()
            fp2.ReadLine()
            fp2.ReadLine()
            fp2.ReadLine()

            Dim a10 As String = fp2.ReadLine()

            Dim a11 As String = a10.Replace("<title>", "")
            Dim a12 As String = a11.Replace("我的 IP 是", "")
            Dim a13 As String = Trim(a12.Replace("- 簡單又快速來取得目前使用的 IP 位置 - MyIP.com.tw</title>", ""))

            fp2.Close()
            'TextBox1.Text = a13
            'isp(a101())
            My.Computer.FileSystem.DeleteFile("C:\proxy\system\ip3.txt")
            Return a13
        Else
            If TextBox1.Text = "" Then
                a101()
            End If

        End If


    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub 功能ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 功能ToolStripMenuItem.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub 觀禮設定檔ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 觀禮設定檔ToolStripMenuItem.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        'TextBox1.Text = a101()
        'isp(a101())

            k = 1
          
        If My.Computer.Network.Ping("74.125.31.94") = True Then


            'If BackgroundWorker1.IsBusy = False Then
            '    BackgroundWorker1.RunWorkerAsync()

            'End If

            'If k = 1 Then
            '    Return
            'End If


            If k1 = 0 Then
                TextBox1.Text = a101()
                isp(a101())
                '先前的ip
                Dim preip As String = TextBox1.Text

                For Each a11 As String In System.IO.Directory.GetFileSystemEntries("C:\proxy\user")

                    Dim a12 As StreamReader = New StreamReader(a11)
                    'proxy ip
                    Dim a13 As String = a12.ReadLine()
                    'isp name
                    Dim a14 As String = a12.ReadLine()
                    'isp turn
                    Dim a15 As String = a12.ReadLine()
                    'ip name
                    Dim a16 As String = a12.ReadLine
                    'ip turn
                    Dim a17 As String = a12.ReadLine
                    
                    'isp偵測..........................................................................
                    If Trim(a14) = TextBox2.Text And a15 = 1 And ispconfig = 1 Then

                        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", a13)
                        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", Microsoft.Win32.RegistryValueKind.DWord)
                        Process.Start("iexplore.exe", "http://www.yahoo.com.tw")
                        Do

                            TextBox1.Text = a101()
                            isp(a101())
                            Thread.Sleep(500)
                        Loop Until Not Trim(a14) = TextBox2.Text


                    End If
                    'ip偵測.................................................................
                    If a16 = TextBox1.Text And a17 = 1 And ipconfig = 1 Then

                        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", a13)
                        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", Microsoft.Win32.RegistryValueKind.DWord)
                        Process.Start("iexplore.exe", "http://www.yahoo.com.tw")



                        Do

                            TextBox1.Text = a101()
                            isp(a101())
                            Thread.Sleep(500)
                        Loop Until Not preip = TextBox1.Text


                    End If
                    '..........................................................................
                    a12.Close()

                Next
            End If
        End If

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim orip As String = TextBox1.Text
        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", Microsoft.Win32.RegistryValueKind.DWord)
        Process.Start("iexplore.exe", "http://tw.yahoo.com/")

        TextBox1.Text = a101()
        isp(a101())
        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", Microsoft.Win32.RegistryValueKind.DWord)

    End Sub

    Private Sub 官方論壇ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 官方論壇ToolStripMenuItem.Click
        Process.Start("http://funny-forum.no-ip.org")
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.WorkerReportsProgress = True
        If My.Computer.Network.Ping("74.125.31.94") = True Then


            k = 0

        Else


            k = 1

            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", Microsoft.Win32.RegistryValueKind.DWord)

        End If




    End Sub


    Private Sub BackgroundWorker2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        'auto update
        'noupdate
        Return


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        k1 = 1
        Button3.Visible = True
        Button4.Visible = False
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Not ListBox1.Items.Count = 0 Then
            k1 = 0
            Button4.Visible = True
            Button3.Visible = False
        Else
            MsgBox("沒有設定檔")
            Return
        End If

    End Sub
    Sub setdata()
        Dim r1 As StreamReader = New StreamReader("C:\proxy\config.inf", System.Text.Encoding.Default)

        If r1.ReadLine = "isp=open" Then

            ispconfig = 1
        End If
        If r1.ReadLine = "time=open" Then
            timeconfig = 1
        End If
        If r1.ReadLine = "ip=open" Then
            ipconfig = 1
        End If
        If r1.ReadLine = "auto=open" Then
            auto = 1
        End If
        If r1.ReadLine = "autocheck=open" Then
            autocheck = 1
        End If
        r1.Close()
       
    End Sub

    Private Sub 關於ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub 設定ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub 註冊訊息ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 註冊訊息ToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub 設定ToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles 設定ToolStripMenuItem.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub 關閉程式ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 關閉程式ToolStripMenuItem.Click
        End
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub 錯誤回報ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 錯誤回報ToolStripMenuItem.Click
        Process.Start("http://gb.tovery.net/sss22213/")
    End Sub

    Private Sub 更新中心ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        'getproxy:
        '        Try


        'a123:
        '            My.Computer.Network.DownloadFile("http://www.getproxy.jp/cn/chinataiwan", "C:\proxy\getproxy.txt", "", "", False, 10000, True)
        '            Dim a1 As StreamReader = New StreamReader("C:\proxy\getproxy.txt", System.Text.Encoding.UTF8)
        '            Dim d1 As Integer = 1
        '            For d1 = 1 To 128
        '                a1.ReadLine()
        '            Next
        '            Dim k As Integer = 0
        '            Dim k1 As Integer = 0
        '            Dim i As Integer = 0
        '            Dim a17 As String
        '            Dim a18 As String
        '            Dim a12 As String = Trim(a1.ReadLine.Replace("<td style='text-align:left;'>", ""))
        '            Dim a13 As String = Trim(a12.Replace("</td>", ""))

        '            Do

        '                i = i + 1
        '                If Not Len(Strings.Right(a13, i)) = Len(Trim(Replace(Strings.Right(a13, i), ":", ""))) Then



        '                    Exit Do
        '                End If
        '            Loop

        '            a17 = Trim(Replace(Strings.Right(a13, i), ":", ""))
        '            Dim a14 As String = Trim(Replace(Strings.Right(a13, Len(a13) - i), ":", "").Replace(a17, ""))
        '            Dim a15 As String

        '            Do
        '                k = k + 1
        '                If IsNumeric(GetChar(a14, k)) = True Then
        '                    Exit Do

        '                End If

        '            Loop
        '            a18 = Trim(Replace(Strings.Right(a13, Len(a13) - i), ":", ""))
        '            Dim a16 As String = Trim(a18.Replace(a18, ""))



        '            For k1 = k To Len(a14)

        '                a15 = a15 + GetChar(a14, k1)
        '                a18 = a15

        '            Next



        '            If My.Computer.Network.Ping(a18) = True Then

        '                Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", a18 + ":" + a17)
        '                Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", Microsoft.Win32.RegistryValueKind.DWord)
        '                Process.Start("iexplore.exe", "http://www.yahoo.com.tw")
        '                TextBox1.Text = a101()
        '                isp(a101())
        '                a1.Close()
        '                LinkLabel2.Visible = True
        '                LinkLabel1.Visible = False
        '            Else
        '                MsgBox("手氣不好，請稍後再試")
        '            End If
        '        Catch exception As Exception
        '            MsgBox("手氣不好，請稍後再試")
        '        End Try

        'code:
        Try
            My.Computer.Network.DownloadFile("http://funnyworker.twbbs.org/homepage/proxy01.php", "C:\proxy\temp\proxy.txt")
            Thread.Sleep(500)
            Dim u1 As StreamReader = New StreamReader("C:\proxy\temp\proxy.txt", System.Text.Encoding.UTF8)
            Dim i As Integer = 0
            Dim a11, p12 As String
            For i = 1 To 24
                a11 = u1.ReadLine()

            Next
            'proxy port:

            p12 = u1.ReadLine()
            u1.Close()
            Dim a12 As String = Replace(a11, "PROXY:<font color='white'><br><center></font><img src='Taiwan.gif'></img><br>		  <script>document.write(", "")
            Dim a13 As String = Replace(a12, ");</script>", "")
            Dim a14 As String = Replace(a13, """", "")

            'getport
            Dim f11 As String = Replace(p12, ":", "")
            Dim f12 As String = Replace(f11, "</center>", "")

            My.Computer.FileSystem.DeleteFile("C:\proxy\temp\proxy.txt")
            REM..............
            ''data formate(port)
            'i = 0

            'Do
            '    i = i + 1

            'Loop Until IsNumeric(GetChar(a14, i)) = True
            'Dim port As String = Strings.Right(a14, Len(a14) - i)
            'MsgBox(Len(port))

            'data formate(ip)
            i = 0

            Do
                i = i + 1

            Loop Until IsNumeric(GetChar(a14, Len(a14) - i)) = True
            Dim ip As String = Strings.Left(a14, Len(a14) - i)

            REM........................


            If My.Computer.Network.Ping(ip) Then

                Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", Trim(ip) + ":" + Trim(f12))
                Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", Microsoft.Win32.RegistryValueKind.DWord)
                Thread.Sleep(500)
                Process.Start("iexplore.exe", "http://tw.yahoo.com/")
                TextBox1.Text = ""
                TextBox2.Text = ""
                Thread.Sleep(500)
                Do

                    TextBox1.Text = a101()
                    isp(a101())
                    Thread.Sleep(500)
                Loop Until Not TextBox1.Text = ""

                LinkLabel2.Visible = True
                '    LinkLabel1.Visible = False
            Else
                MsgBox("手氣不好，請稍後再試")
            End If
        Catch ex As Exception
            MsgBox("手氣不好，請稍後再試")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", Microsoft.Win32.RegistryValueKind.DWord)

        'Process.Start("iexplore.exe", "http://tw.yahoo.com/")
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        'Do

        '    TextBox1.Text = a101()
        '    isp(a101())
        '    Thread.Sleep(500)
        'Loop Until Not TextBox1.Text = "" And TextBox2.Text = ""
        'LinkLabel2.Visible = False
        'LinkLabel1.Visible = True
        Me.Button2.PerformClick()
        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", Microsoft.Win32.RegistryValueKind.DWord)
        Thread.Sleep(5000)
        TextBox1.Text = a101()
        isp(a101())
    End Sub

    Private Sub 引用來源ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 引用來源ToolStripMenuItem.Click
        Form7.Show()
    End Sub
End Class
