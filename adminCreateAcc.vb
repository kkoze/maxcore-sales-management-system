Imports System.Drawing.Drawing2D
Imports MySql
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.SqlClient
Imports ZstdSharp.Unsafe

Public Class adminCreateAcc
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Private Sub adminCreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Background Gradient Color <-----
        Dim GradientBack As New LinearGradientBrush(Me.DisplayRectangle, Color.Aquamarine, Color.White, LinearGradientMode.ForwardDiagonal)
        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)
        Dim Grad As Graphics = Graphics.FromImage(Me.BackgroundImage)
        Grad.FillRectangle(GradientBack, Me.DisplayRectangle)
        '-------->
    End Sub
    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        ' Validate that password is at least 5 characters long
        If txtPass.Text.Length < 5 Then
            ' Show tooltip with an error message
            ToolTip1.Show("Password must be at least 5 characters long.", txtPass, 0, -30, 2000)
        Else
            ' Hide the tooltip if the password is valid
            ToolTip1.Hide(txtPass)
        End If
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Validate that all text fields are not empty
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
       String.IsNullOrWhiteSpace(txtPass.Text) OrElse
       String.IsNullOrWhiteSpace(txtName.Text) OrElse
       String.IsNullOrWhiteSpace(txtContact.Text) OrElse
       cboRole.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all text fields and select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate that an image is selected
        If pbUploadImg.Image Is Nothing Then
            MessageBox.Show("Please select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Do you want to save the account?", "Confirmation", MessageBoxButtons.YesNo)

        ' Check the user's choice
        If result = DialogResult.Yes Then
            ' User clicked Yes, perform the save operation
            ' Add your code to save the account here

            Dim ms As New MemoryStream
            pbUploadImg.Image.Save(ms, pbUploadImg.Image.RawFormat)

            Dim cmd As New MySqlCommand("INSERT INTO `user`(`Email`, `Password`, `empname`, `emprole`, `empcontact`, `userimg`) 
                                    VALUES (@email,@password,@name,@role,@contact,@img)", con)

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPass.Text
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text
            cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = cboRole.SelectedItem
            cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = txtContact.Text
            cmd.Parameters.Add("@img", MySqlDbType.MediumBlob).Value = ms.ToArray

            con.Open()

            ' Check if the account already exists
            Dim checkCmd As New MySqlCommand("SELECT * FROM `user` WHERE `Email` = @email", con)
            checkCmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtUsername.Text

            Dim dt As New DataTable()
            Dim adapter As New MySqlDataAdapter(checkCmd)
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("Account already exists!", "[Admin]Maxcore: Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("WELCOME!", "[Admin]Maxcore : Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.ExecuteNonQuery()

                ' Clear text fields
                txtUsername.Text = ""
                txtPass.Text = ""
                txtName.Text = ""
                txtContact.Text = ""

                ' Clear image preview
                pbUploadImg.Image = Nothing

                ' Clear ComboBox selection
                cboRole.SelectedIndex = -1
            End If

            con.Close()

        ElseIf result = DialogResult.Cancel Then
            ' User clicked Cancel, clear the txtusername TextBox, image preview, and ComboBox selection
            txtUsername.Text = ""
            pbUploadImg.Image = Nothing
            cboRole.SelectedIndex = -1
        End If
    End Sub


    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ' Create an instance of OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to allow only image files
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif"

        ' Check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file's path
            Dim selectedImagePath As String = openFileDialog.FileName

            ' Check if the file exists
            If File.Exists(selectedImagePath) Then
                ' Load the image into the PictureBox
                pbUploadImg.Image = Image.FromFile(selectedImagePath)
            Else
                MessageBox.Show("Selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class