Public Class Form1
    Private Sub txtLogin_Click(sender As Object, e As EventArgs) Handles txtLogin.Click
        If txtUser.Text = "admin" And txtPassword.Text = "admin" Then
            Form2.Show()
            Me.Hide()
            txtUser.Clear()
            txtPassword.Clear()
        Else
            MsgBox("Invalid Username and Password")
        End If
    End Sub

    Private Sub chkboxHide_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxHide.CheckedChanged
        If chkboxHide.Checked Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class
