Public Class Form2
    Dim Score3 As Integer
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Score3 = 0
        If RadioButton3.Checked Then
            Score3 += 1
        End If
        If RadioButton4.Checked Then
            Score3 += 1
        End If
        If RadioButton9.Checked Then
            Score3 += 1
        End If
        If RadioButton10.Checked Then
            Score3 += 1
        End If
        If RadioButton13.Checked Then
            Score3 += 1
        End If
        txtScore.Text = "Congrats You got" & Score3 & "/5"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim Answer = DialogResult
        Answer = MessageBox.Show("Are you sure you want to clear?", "CLEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Answer = DialogResult.Yes Then

            RadioButton1.Checked() = False
            RadioButton2.Checked() = False
            RadioButton3.Checked() = False
            RadioButton4.Checked() = False
            RadioButton5.Checked() = False
            RadioButton6.Checked() = False
            RadioButton7.Checked() = False
            RadioButton8.Checked() = False
            RadioButton9.Checked() = False
            RadioButton10.Checked() = False
            RadioButton11.Checked() = False
            RadioButton12.Checked() = False
            RadioButton13.Checked() = False
            RadioButton14.Checked() = False
            RadioButton15.Checked() = False
            txtScore.Text = ""
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class