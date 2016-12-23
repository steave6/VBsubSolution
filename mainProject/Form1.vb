Imports WindowsApplication1

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1 As Form = New WindowsApplication1.SubForm
        Form1.ShowDialog()
    End Sub
End Class
