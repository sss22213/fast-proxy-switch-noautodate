Imports System.IO

Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim a12 As StreamReader = New StreamReader("C:\proxy\config.inf", System.Text.Encoding.Default)

        Dim a13 As String = a12.ReadLine
        Dim a14 As String = a12.ReadLine
        Dim a15 As String = a12.ReadLine
        Dim a16 As String = a12.ReadLine
         Dim a17 As String = a12.ReadLine

        a12.Close()

        If a13 = "isp=open" Then
            CheckBox1.Checked = True
        End If
        If a14 = "time=open" Then
            CheckBox3.Checked = True
        End If
        If a15 = "ip=open" Then
            CheckBox2.Checked = True
        End If
        If a16 = "auto=open" Then
            CheckBox4.Checked = True
        End If
        If a17 = "autocheck=open" Then
            CheckBox5.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim w2 As New FileInfo("C:\proxy\config.inf")
        Dim w1 As StreamWriter = w2.CreateText
        If CheckBox1.Checked = True Then
            w1.WriteLine("isp=open")
        Else
            w1.WriteLine("isp=close")
        End If

        If CheckBox3.Checked = True Then
            w1.WriteLine("time=open")
        Else
            w1.WriteLine("time=close")
        End If
        If CheckBox2.Checked = True Then
            w1.WriteLine("ip=open")
        Else
            w1.WriteLine("ip=close")
        End If
        If CheckBox4.Checked = True Then
            w1.WriteLine("auto=open")
        Else
            w1.WriteLine("auto=close")
        End If
        If CheckBox5.Checked = True Then
            w1.WriteLine("autocheck=open")
        Else
            w1.WriteLine("autocheck=close")
        End If
        w1.Close()
        Form1.Show()
        Me.Close()
    End Sub
End Class