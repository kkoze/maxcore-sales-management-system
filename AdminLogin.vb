Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class AdminLogin
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Background Gradient Color <-----
        Dim GradientBack As New LinearGradientBrush(Me.DisplayRectangle, Color.Aquamarine, Color.White, LinearGradientMode.ForwardDiagonal)
        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)
        Dim Grad As Graphics = Graphics.FromImage(Me.BackgroundImage)
        Grad.FillRectangle(GradientBack, Me.DisplayRectangle)
        '-------->
    End Sub

    Private Sub back_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles back.LinkClicked
        ' Close the current MainForm
        Me.Close()

        ' Open the LoginForm
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Using con
            con.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM `user` WHERE Email = @Email AND Password = @Password AND emprole = 'admin'", con)
            cmd.Parameters.AddWithValue("@Email", txtAdminUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtAdminPass.Text)

            Using msadap As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                msadap.Fill(dt)

                If dt.Rows.Count > 0 Then
                    ' Check if the user has the "admin" role
                    If dt.Rows(0)("emprole").ToString() = "admin" Then
                        AdminForm.txtAdminName.Text = dt.Rows(0)("empname").ToString()
                        AdminForm.txtContact.Text = dt.Rows(0)("empcontact").ToString()

                        ' Displaying user image (assuming userimg is a BLOB field)
                        Dim imageData As Byte() = DirectCast(dt.Rows(0)("userimg"), Byte())
                        Dim ms As New System.IO.MemoryStream(imageData)
                        AdminForm.AdminPic.Image = Image.FromStream(ms)

                        Me.Hide()
                        AdminForm.Show()
                    Else
                        MessageBox.Show("Not an admin. Access denied.")
                    End If
                Else
                    MessageBox.Show("Can't Find User!")
                End If
            End Using
        End Using
    End Sub


End Class