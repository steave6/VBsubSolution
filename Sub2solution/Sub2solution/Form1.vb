Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Dim frm As Form = New mainProject.MainForm
            frm.ShowDialog()
        End If
    End Sub
End Class
