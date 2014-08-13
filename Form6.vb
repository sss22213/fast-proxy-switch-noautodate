Imports System.IO

Public Class Form6
    Public k2 As Integer = 0
    Public k3 As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '讀取設定檔
        For Each a11 As String In System.IO.Directory.GetFileSystemEntries("C:\proxy\user")


            ListBox1.Items.Add(Trim(Replace(a11, "C:\proxy\user\", "")))
        Next
        If ListBox1.Items.Count = 0 Then
            Button2.Visible = False
            Button3.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Not ListBox1.Text = "" Then
            k2 = 1
            k3 = "C:\proxy\user\" + ListBox1.Text
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("請選擇其中一個設定檔")
            Return
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Not ListBox1.Text = "" Then
            File.Delete("C:\proxy\user\" + ListBox1.Text)
          
         
                ListBox1.Items.Remove(ListBox1.Text)




           

        Else
            MsgBox("請選擇其中一個設定檔")
            Return
        End If
    End Sub
End Class