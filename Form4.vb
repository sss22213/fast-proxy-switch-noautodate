Imports System.IO

Public Class Form4

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://funnyworker.tw")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim ff1 As StreamReader = New StreamReader("C:\proxy\ChangLog.txt", System.Text.Encoding.Default)
        MsgBox(ff1.ReadToEnd())
        ff1.Close()

    End Sub
End Class