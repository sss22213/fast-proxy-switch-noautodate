Imports System.Threading

Public Class Form8

    Private Sub Form8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Thread.Sleep(2000)
        Form1.Show()
        Me.Hide()


    End Sub
End Class