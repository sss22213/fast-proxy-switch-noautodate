Imports System.IO
Imports Microsoft.Win32
Imports System.Threading

Public Class Form3
    Dim k3 As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If File.Exists("C:\proxy\user\" + TextBox1.Text) = False Then
            If TextBox2.Text = "" Then
                MsgBox("請輸入""PROXY""")
                Return
            End If
            If TextBox3.Text = "" Then
                MsgBox("請輸入""連接埠""")
                Return
            End If
            If ComboBox1.Text = "開啟" And TextBox11.Text = "請輸入全名" Then
                MsgBox("請輸入""isp""")
                Return
            End If
            If ComboBox1.Text = "關閉" Then
                TextBox11.Text = "關閉"
            End If
            If ComboBox2.Text = "開啟" And TextBox12.Text = "請輸入IP" Then
                MsgBox("請輸入""ip""")
                Return
            End If
            If ComboBox2.Text = "關閉" Then
                TextBox12.Text = "關閉"
            End If
            If TextBox12.Text = "" Then
                MsgBox("請輸入""ip""")
                Return
            End If
            Dim f11 As StreamWriter = New StreamWriter("C:\proxy\user\" + TextBox1.Text)
            f11.WriteLine(TextBox2.Text + ":" + TextBox3.Text)
            f11.WriteLine(TextBox11.Text)
            If ComboBox1.Text = "開啟" Then
                f11.WriteLine("1")
            Else
                f11.WriteLine("0")
            End If
            f11.WriteLine(TextBox12.Text)
            If ComboBox2.Text = "開啟" Then
                f11.WriteLine("1")
            Else
                f11.WriteLine("0")
            End If
            f11.Close()
        Else
            MsgBox("設定檔已存在")
            Return
        End If
        Form1.Show()
        Form6.Close()
        Me.Hide()

    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim k2 As Integer
        Dim i As Integer = 0
        If Form6.k2 = 1 Then
            Me.Text = "編輯設定檔"
            TextBox1.Text = Trim(Replace(Form6.k3, "C:\proxy\user\", ""))
            '讀取舊資料
            Dim a11 As StreamReader = New StreamReader(Form6.k3, System.Text.Encoding.UTF8)
            Dim a12 As String = a11.ReadLine()
            '取得proxy
            Do
                i = i + 1
                If Not Len(Strings.Right(a12, i)) = Len(Trim(Replace(Strings.Right(a12, i), ":", ""))) Then



                    Exit Do
                End If

            Loop
            TextBox3.Text = Trim(Replace(Strings.Right(a12, i), ":", ""))
            TextBox2.Text = Trim(Replace(Replace(a12, TextBox3.Text, ""), ":", ""))
            TextBox11.Text = a11.ReadLine()
            If a11.ReadLine() = 1 Then
                ComboBox1.Text = "開啟"
            Else
                ComboBox1.Text = "關閉"
            End If

            REM............
            TextBox12.Text = a11.ReadLine()
            If a11.ReadLine() = 1 Then
                ComboBox2.Text = "開啟"
            Else
                ComboBox2.Text = "關閉"
            End If
            a11.Close()

            Button1.Visible = False
            Button2.Visible = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://rms.twnic.net.tw/twnic/User/Member/Search/main7.jsp?Order=ORG.ID")
    End Sub

    Private Sub TextBox17_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        '讀取舊的資料

        If TextBox2.Text = "" Then
            MsgBox("請輸入""PROXY""")
            Return
        End If
        If TextBox3.Text = "" Then
            MsgBox("請輸入""連接埠""")
            Return
        End If
        If ComboBox1.Text = "開啟" And TextBox11.Text = "請輸入全名" Then
            MsgBox("請輸入""isp""")
            Return
        End If
        If ComboBox1.Text = "關閉" Then
            TextBox11.Text = "關閉"
        End If
        If ComboBox2.Text = "開啟" And TextBox12.Text = "請輸入IP" Then
            MsgBox("請輸入""ip""")
            Return
        End If
        If ComboBox2.Text = "關閉" Then
            TextBox12.Text = "關閉"
        End If
        If TextBox12.Text = "" Then
            MsgBox("請輸入""ip""")
            Return
        End If
        Dim f11 As StreamWriter = New StreamWriter("C:\proxy\user\" + TextBox1.Text)
        f11.WriteLine(TextBox2.Text + ":" + TextBox3.Text)
        f11.WriteLine(TextBox11.Text)
        If ComboBox1.Text = "開啟" Then
            f11.WriteLine("1")
        Else
            f11.WriteLine("0")
        End If
        f11.WriteLine(TextBox12.Text)
        If ComboBox2.Text = "開啟" Then
            f11.WriteLine("1")
        Else
            f11.WriteLine("0")
        End If
        f11.Close()
        Form1.Show()
        Form6.Close()
        Me.Close()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'My.Computer.Network.DownloadFile("http://www.getproxy.jp/cn/chinataiwan", "C:\proxy\getproxy.txt", "", "", False, 10000, True)
        'Dim a1 As StreamReader = New StreamReader("C:\proxy\getproxy.txt", System.Text.Encoding.UTF8)
        'Dim d1 As Integer = 1
        'For d1 = 1 To 128
        '    a1.ReadLine()
        'Next
        'Dim k As Integer = 0
        'Dim k1 As Integer = 0
        'Dim i As Integer = 0
        'Dim a12 As String = Trim(a1.ReadLine.Replace("<td style='text-align:left;'>", ""))
        'Dim a13 As String = Trim(a12.Replace("</td>", ""))

        'Do

        '    i = i + 1
        '    If Not Len(Strings.Right(a13, i)) = Len(Trim(Replace(Strings.Right(a13, i), ":", ""))) Then



        '        Exit Do
        '    End If
        'Loop

        'TextBox3.Text = Trim(Replace(Strings.Right(a13, i), ":", ""))
        'Dim a14 As String = Trim(Replace(Strings.Right(a13, Len(a13) - i), ":", "").Replace(TextBox3.Text, ""))
        'Dim a15 As String

        'Do
        '    k = k + 1
        '    If IsNumeric(GetChar(a14, k)) = True Then
        '        Exit Do

        '    End If

        'Loop
        'TextBox2.Text = Trim(Replace(Strings.Right(a13, Len(a13) - i), ":", ""))
        'Dim a16 As String = Trim(TextBox2.Text.Replace(TextBox3.Text, ""))



        'For k1 = k To Len(a14)

        '    a15 = a15 + GetChar(a14, k1)
        '    TextBox2.Text = a15

        'Next

        'a1.Close()
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

            TextBox2.Text = ip
            TextBox3.Text = Trim(f12)
        Catch ex As Exception
            MsgBox("無法取得公共Proxy")
        End Try
    End Sub
End Class