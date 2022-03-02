Public Class LoginForm

    Private Sub loginform_load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub picturebox2_click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub


    Private Sub txtusername_gotfocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtusername_lostfocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.DarkGray
        End If
    End Sub


    Private Sub txtpassword_gotfocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "●"
            txtUsername.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtpassword_lostfocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "1234" Then
            MessageBox.Show("Login Successful")
            Form1.Show()
            Me.Hide()

        ElseIf txtUsername.Text = "" Or txtPassword.Text = "" Then

            MessageBox.Show("Please fill all fields")
        Else
            MessageBox.Show("Username or Password is incorrect")
        End If
    End Sub
End Class