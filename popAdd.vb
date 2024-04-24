Imports MySql.Data.MySqlClient

Public Class popAdd
    Public Sub loadcomboboxIType()
        cboTypes.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                Dim query As String = "SELECT ItemType FROM list_maintenance"

                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then

                            While reader.Read()

                                Dim Itemtype As String = reader.GetString(0)

                                If Not String.IsNullOrWhiteSpace(Itemtype) Then
                                    cboTypes.Items.Add(Itemtype)
                                End If
                            End While
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Handle any exceptions (e.g., display an error message)
                MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub popAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcomboboxIType()

    End Sub
    Private Sub cboTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTypes.SelectedIndexChanged
        ' Check if the selected item is "Pharmaceuticals and Medications"
        If cboTypes.SelectedItem IsNot Nothing AndAlso cboTypes.SelectedItem.ToString() = "Pharmaceuticals and Medications" Then
            ' Show the popAddMedItem form

            popAddMedItem.Show()
            popAddMedItem.txtItype.Text = cboTypes.SelectedItem.ToString()
            popAddMedItem.btndelete.Visible = False
            popAddMedItem.btnupdate.Visible = False
            popAddMedItem.txtDate.Clear()
            popAddMedItem.txtdateDeliver.Clear()
        Else
            ' Show the popAddMerchItem form

            popAddMerchItem.Show()
            popAddMerchItem.txtItype.Text = cboTypes.SelectedItem.ToString()
            popAddMerchItem.btndelete.Visible = False
            popAddMerchItem.btnupdate.Visible = False
            popAddMerchItem.txtDate.Clear()
            popAddMerchItem.txtdateDeliver.Clear()
        End If

        ' Close the current form (popAdd)
        Me.Close()
    End Sub


End Class