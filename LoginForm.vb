Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        AdminLogin.Show()
    End Sub
    Sub switchforms(ByVal panel As Form)
        Main.PanelForm.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Main.PanelForm.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Login()
        Using con
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `user` WHERE Email = @Email AND Password = @Password", con)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            Using msadap As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                msadap.Fill(dt)
                If dt.Rows.Count > 0 Then
                    ' Display User 
                    Main.txtName.Text = dt.Rows(0)("empname").ToString()
                    Main.txtRole.Text = dt.Rows(0)("emprole").ToString()
                    mainViewProfile.txtUser.Text = dt.Rows(0)("empname").ToString()
                    mainViewProfile.txtRole.Text = dt.Rows(0)("emprole").ToString()
                    mainViewProfile.txtEmail.Text = dt.Rows(0)("Email").ToString()
                    mainViewProfile.txtContact.Text = dt.Rows(0)("empcontact").ToString()
                    AdminForm.txtAdminName.Text = dt.Rows(0)("empname").ToString()
                    AdminForm.txtContact.Text = dt.Rows(0)("empcontact").ToString()
                    Dim imageData As Byte() = DirectCast(dt.Rows(0)("userimg"), Byte())
                    Dim ms As New System.IO.MemoryStream(imageData)
                    Main.UserPic.Image = Image.FromStream(ms)
                    mainViewProfile.userImg.Image = Image.FromStream(ms)
                    AdminForm.AdminPic.Image = Image.FromStream(ms)
                    Dim userRole As String = dt.Rows(0)("emprole").ToString()
                    Select Case userRole
                        Case "inventory"
                            Main.btnSalesReport.Visible = False
                            Main.btnSalesMng.Visible = False
                            Main.btnOpenAdmin.Visible = False
                        Case "sales"
                            Main.btnInvMng.Visible = False
                            Main.btnProdMng.Visible = False
                            Main.btnOpenAdmin.Visible = False
                        Case "manager"
                            Main.btnOpenAdmin.Visible = False
                    End Select

                    Me.Hide()
                    Main.Show()
                    switchforms(Dashboard)
                    Dashboard.Dashboardfunction()
                Else
                    MessageBox.Show("Account does not exist", "MAXCORE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Clear()
                End If
            End Using
        End Using
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Cursor = Cursors.WaitCursor
        Login()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub LoginForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview property to True in the form's Load event
        Me.KeyPreview = True
    End Sub
End Class
