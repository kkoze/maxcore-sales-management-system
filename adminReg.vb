Imports System.IO
Imports MySql.Data.MySqlClient

Public Class adminReg
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Public Sub showAccountsFunction()

        Try
            Using con
                con.Open()

                Dim cmd As New MySqlCommand("SELECT * FROM `user`", con)

                Using msadap As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    msadap.Fill(dt)

                    ' Assuming that dtgAcc is the name of your DataGridView
                    dtgAcc.DataSource = dt
                    dtgAcc.Columns("id").Visible = False
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub dtgAcc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgAcc.CellClick
        ' Check if a valid row is clicked (excluding header row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < dtgAcc.Rows.Count Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dtgAcc.Rows(e.RowIndex)

            ' Extract data from the selected row
            Dim email As String = selectedRow.Cells("Email").Value.ToString()
            Dim password As String = selectedRow.Cells("Password").Value.ToString()
            Dim empName As String = selectedRow.Cells("empname").Value.ToString()
            Dim empRole As String = selectedRow.Cells("emprole").Value.ToString()
            Dim empContact As String = selectedRow.Cells("empcontact").Value.ToString()
            Dim userImg As Byte() = DirectCast(selectedRow.Cells("userimg").Value, Byte())

            ' Create an instance of your EditAcc form
            Dim editAccForm As New editAcc()

            ' Pass the data to the EditAcc form
            editAccForm.txtEmail.Text = email
            editAccForm.txtPass.Text = password
            editAccForm.txtName.Text = empName
            editAccForm.cboEditRole.SelectedItem = empRole
            editAccForm.txtContact.Text = empContact

            ' Convert byte array to image and set it to the PictureBox
            If userImg IsNot Nothing AndAlso userImg.Length > 0 Then
                Dim ms As New MemoryStream(userImg)
                editAccForm.pbEditImg.Image = Image.FromStream(ms)
            End If

            ' Show the EditAcc form
            editAccForm.ShowDialog()
        End If
    End Sub


End Class