Imports System.IO
Imports MySql.Data.MySqlClient

Public Class editAcc
    ' Define a MySqlConnection to connect to the database
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    ' Other existing code in your editAcc form...

    ' Update button click event
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Open the connection to the database
            con.Open()

            ' Prepare the SQL query to update the user's information
            Dim query As String = "UPDATE `user` SET `Password` = @password, `empname` = @empname, `emprole` = @emprole, `empcontact` = @empcontact, `userimg` = @userimg WHERE `Email` = @email"

            ' Create a new MySqlCommand with the SQL query and the connection
            Using cmd As New MySqlCommand(query, con)
                ' Add parameters to the query to prevent SQL injection
                cmd.Parameters.AddWithValue("@password", txtPass.Text)
                cmd.Parameters.AddWithValue("@empname", txtName.Text)
                cmd.Parameters.AddWithValue("@emprole", cboEditRole.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@empcontact", txtContact.Text)

                ' Convert the image to a byte array and add it as a parameter
                Dim ms As New MemoryStream()
                pbEditImg.Image.Save(ms, pbEditImg.Image.RawFormat)
                cmd.Parameters.AddWithValue("@userimg", ms.ToArray())

                ' Add the email parameter for the WHERE clause
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)

                ' Execute the update query
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Display a success message
                    MessageBox.Show("Account updated successfully", "[Admin]Maxcore: Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    ' Display a message if no rows were affected

                    MessageBox.Show("No rows were affected. Make sure the email exists in the database.", "[Admin]Maxcore: Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection to the database
            con.Close()
        End Try
    End Sub

    ' Delete button click event
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Open the connection to the database
            con.Open()

            ' Prepare the SQL query to delete the user's account
            Dim query As String = "DELETE FROM `user` WHERE `Email` = @email"

            ' Create a new MySqlCommand with the SQL query and the connection
            Using cmd As New MySqlCommand(query, con)
                ' Add the email parameter for the WHERE clause
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)

                ' Execute the delete query
                cmd.ExecuteNonQuery()

                ' Display a success message
                MessageBox.Show("Account deleted successfully", "[Admin]Maxcore: Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim adminRegForm As adminReg = CType(Application.OpenForms("adminReg"), adminReg)
                adminRegForm.showAccountsFunction()
            End Using
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection to the database
            con.Close()
        End Try

        ' Close the editAcc form after deletion
        Me.Close()
    End Sub

    ' Choose Image button click event
    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        ' Allow the user to choose a new image and display it in the PictureBox
        Dim openFileDialog As New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pbEditImg.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Dim adminRegForm As adminReg = CType(Application.OpenForms("adminReg"), adminReg)
        adminRegForm.showAccountsFunction()
    End Sub
End Class
