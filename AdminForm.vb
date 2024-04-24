Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetime.Enabled = True
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Dim loginform As New LoginForm()
        loginform.Show()
    End Sub

    Private Sub datetime_Tick(sender As Object, e As EventArgs) Handles datetime.Tick
        txtdate.Text = Date.Now.ToString("MM/dd/yyyy")
        txttime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    Sub switchforms(ByVal panel As Form)
        PanelForm.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        PanelForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnMngUser_Click(sender As Object, e As EventArgs) Handles btnMngUser.Click
        switchforms(adminReg)
        adminReg.showAccountsFunction()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        switchforms(adminCreateAcc)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Maintenance.Show()
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Me.Close()
    End Sub
End Class