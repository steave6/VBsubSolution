﻿Imports mainProject
Public Class SubForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As Form = New mainProject.MainForm
        frm.Show()
    End Sub
End Class
