Imports System.Management
Imports MySql.Data.MySqlClient

Public Class Maintenance
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Private Sub btnAT_Click(sender As Object, e As EventArgs) Handles btnAT.Click
        reset()
        load1()
        load2()
        load3()
        load4()
        load5()
        load6()
        load7()

        panel1.Location = New Point(302, 78)
        panel2.Location = New Point(1055, 86)
    End Sub

    Private Sub btnEdT_Click(sender As Object, e As EventArgs) Handles btnEdT.Click
        load1()
        load2()
        load3()
        load4()
        load5()
        load6()
        load7()

        panel1.Location = New Point(1055, 86)
        panel2.Location = New Point(233, 78)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Main.Enabled = True
    End Sub


    Private Sub Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
        load1()
        load2()
        load3()
        load4()
        load5()
        load6()
        load7()

    End Sub

    Private Sub txtGn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGn.KeyDown

        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            Try
                ' Open the connection
                con.Open()

                ' Check if the entered generic name already exists in the database
                Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM list_genericname WHERE GenericName = @type", con)
                cmdCheck.Parameters.AddWithValue("@type", txtGn.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    ' Generic Name already exists, show a message box
                    MessageBox.Show("Type already exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Generic Name does not exist
                    Dim cmdInsert As New MySqlCommand("INSERT INTO list_genericname (GenericName) VALUES (@type)", con)
                    cmdInsert.Parameters.AddWithValue("@type", txtGn.Text.Trim())

                    cmdInsert.ExecuteNonQuery()

                    ' Provide feedback to the user
                    MessageBox.Show("Type added", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Clear the text box after processing
                txtGn.Clear()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                ' Prevent the Enter key from being processed further
                e.SuppressKeyPress = True
            End Try
        End If
    End Sub
    Private Sub txtMedt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMedT.KeyDown

        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            Try
                ' Open the connection
                con.Open()

                ' Check if the entered generic name already exists in the database
                Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM list_maintenance WHERE Medtype = @type", con)
                cmdCheck.Parameters.AddWithValue("@type", txtMedT.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    ' Generic Name already exists, show a message box
                    MessageBox.Show("Type already exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Generic Name does not exist
                    Dim cmdInsert As New MySqlCommand("INSERT INTO list_maintenance (MedType) VALUES (@type)", con)
                    cmdInsert.Parameters.AddWithValue("@type", txtMedT.Text.Trim())

                    cmdInsert.ExecuteNonQuery()

                    ' Provide feedback to the user
                    MessageBox.Show("Type added", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Clear the text box after processing
                txtMedT.Clear()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                ' Prevent the Enter key from being processed further
                e.SuppressKeyPress = True
            End Try
        End If
    End Sub
    Private Sub txtMedc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMedC.KeyDown

        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            Try
                ' Open the connection
                con.Open()

                ' Check if the entered generic name already exists in the database
                Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM list_maintenance WHERE MedCategory = @type", con)
                cmdCheck.Parameters.AddWithValue("@type", txtMedC.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    ' Generic Name already exists, show a message box
                    MessageBox.Show("Type already exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Generic Name does not exist
                    Dim cmdInsert As New MySqlCommand("INSERT INTO list_maintenance (MedCategory) VALUES (@type)", con)
                    cmdInsert.Parameters.AddWithValue("@type", txtMedC.Text.Trim())

                    cmdInsert.ExecuteNonQuery()

                    ' Provide feedback to the user
                    MessageBox.Show("Type added", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Clear the text box after processing
                txtMedC.Clear()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                ' Prevent the Enter key from being processed further
                e.SuppressKeyPress = True
            End Try
        End If
    End Sub
    Private Sub txtvol_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVol.KeyDown

        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            Try
                ' Open the connection
                con.Open()

                ' Check if the entered generic name already exists in the database
                Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM list_volume WHERE Formulation = @type", con)
                cmdCheck.Parameters.AddWithValue("@type", txtVol.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    ' Generic Name already exists, show a message box
                    MessageBox.Show("Type already exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Generic Name does not exist
                    Dim cmdInsert As New MySqlCommand("INSERT INTO list_volume (Formulation) VALUES (@type)", con)
                    cmdInsert.Parameters.AddWithValue("@type", txtVol.Text.Trim())

                    cmdInsert.ExecuteNonQuery()

                    ' Provide feedback to the user
                    MessageBox.Show("Type added", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Clear the text box after processing
                txtVol.Clear()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                ' Prevent the Enter key from being processed further
                e.SuppressKeyPress = True
            End Try
        End If
    End Sub
    Private Sub txtMert_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMerT.KeyDown

        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            Try
                ' Open the connection
                con.Open()

                ' Check if the entered generic name already exists in the database
                Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM list_maintenance WHERE MerchType = @type", con)
                cmdCheck.Parameters.AddWithValue("@type", txtMerT.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    ' Generic Name already exists, show a message box
                    MessageBox.Show("Type already exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Generic Name does not exist
                    Dim cmdInsert As New MySqlCommand("INSERT INTO list_maintenance (MerchType) VALUES (@type)", con)
                    cmdInsert.Parameters.AddWithValue("@type", txtMerT.Text.Trim())

                    cmdInsert.ExecuteNonQuery()

                    ' Provide feedback to the user
                    MessageBox.Show("Type added", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Clear the text box after processing
                txtMerT.Clear()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                ' Prevent the Enter key from being processed further
                e.SuppressKeyPress = True
            End Try
        End If
    End Sub
    Private Sub txtScon_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSCon.KeyDown

        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            Try
                ' Open the connection
                con.Open()

                ' Check if the entered generic name already exists in the database
                Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM list_maintenance WHERE StorageCond = @type", con)
                cmdCheck.Parameters.AddWithValue("@type", txtSCon.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    ' Generic Name already exists, show a message box
                    MessageBox.Show("Type already exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Generic Name does not exist
                    Dim cmdInsert As New MySqlCommand("INSERT INTO list_maintenance (StorageCond) VALUES (@type)", con)
                    cmdInsert.Parameters.AddWithValue("@type", txtSCon.Text.Trim())

                    cmdInsert.ExecuteNonQuery()

                    ' Provide feedback to the user
                    MessageBox.Show("Type added", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Clear the text box after processing
                txtSCon.Clear()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                ' Prevent the Enter key from being processed further
                e.SuppressKeyPress = True
            End Try
        End If
    End Sub




    Private Sub txtGn_TextChanged(sender As Object, e As EventArgs) Handles txtGn.TextChanged
        reset()
    End Sub

    Private Sub txtMedT_TextChanged(sender As Object, e As EventArgs) Handles txtMedT.TextChanged
        reset()
    End Sub

    Private Sub txtMedC_TextChanged(sender As Object, e As EventArgs) Handles txtMedC.TextChanged
        reset()
    End Sub

    Private Sub txtVol_TextChanged(sender As Object, e As EventArgs) Handles txtVol.TextChanged
        reset()
    End Sub

    Private Sub txtMerT_TextChanged(sender As Object, e As EventArgs) Handles txtMerT.TextChanged
        reset()
    End Sub

    Private Sub txtSCon_TextChanged(sender As Object, e As EventArgs) Handles txtSCon.TextChanged
        reset()
    End Sub

    Private Sub txtPromo_TextChanged(sender As Object, e As EventArgs) Handles txtPromo.TextChanged
        reset()
    End Sub

    Private Sub txtTValue_TextChanged(sender As Object, e As EventArgs) Handles txtTValue.TextChanged
        reset()
    End Sub
    Public Sub reset()

        txtET.Clear()
        cboT.SelectedIndex = -1
    End Sub




    Public Sub load1()
        cboG.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database
                Dim query As String = "SELECT GenericName FROM list_genericname"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then
                            ' Iterate through the rows and add items to the ComboBox
                            While reader.Read()
                                ' Assuming the data is in the first column (index 0)
                                Dim Itemtype As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(Itemtype) Then
                                    cboG.Items.Add(Itemtype)
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
    Public Sub load2()
        cboMedT.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database
                Dim query As String = "SELECT MedType FROM list_maintenance"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then
                            ' Iterate through the rows and add items to the ComboBox
                            While reader.Read()
                                ' Assuming the data is in the first column (index 0)
                                Dim Itemtype As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(Itemtype) Then
                                    cboMedT.Items.Add(Itemtype)
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
    Public Sub load3()
        cboMedc.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database
                Dim query As String = "SELECT MedCategory FROM list_maintenance"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then
                            ' Iterate through the rows and add items to the ComboBox
                            While reader.Read()
                                ' Assuming the data is in the first column (index 0)
                                Dim Itemtype As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(Itemtype) Then
                                    cboMedc.Items.Add(Itemtype)
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
    Public Sub load4()
        cboVol.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database
                Dim query As String = "SELECT Formulation FROM list_volume"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then
                            ' Iterate through the rows and add items to the ComboBox
                            While reader.Read()
                                ' Assuming the data is in the first column (index 0)
                                Dim Itemtype As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(Itemtype) Then
                                    cboVol.Items.Add(Itemtype)
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
    Public Sub load5()
        cboMerC.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database
                Dim query As String = "SELECT MerchType FROM list_maintenance"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then
                            ' Iterate through the rows and add items to the ComboBox
                            While reader.Read()
                                ' Assuming the data is in the first column (index 0)
                                Dim Itemtype As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(Itemtype) Then
                                    cboMerC.Items.Add(Itemtype)
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
    Public Sub load6()
        cboSc.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database
                Dim query As String = "SELECT StorageCond FROM list_maintenance"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then
                            ' Iterate through the rows and add items to the ComboBox
                            While reader.Read()
                                ' Assuming the data is in the first column (index 0)
                                Dim Itemtype As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(Itemtype) Then
                                    cboSc.Items.Add(Itemtype)
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
    Public Sub load7()
        cboT.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database
                Dim query As String = "SELECT TaxName, TaxValue FROM list_tax"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Execute the query and get a data reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows in the result set
                        If reader.HasRows Then
                            ' Iterate through the rows and add items to the ComboBox
                            While reader.Read()
                                ' Assuming the data is in the first and second columns (indexes 0 and 1)
                                Dim taxName As String = reader.GetString(0)
                                Dim taxValue As String = reader.GetString(1)

                                ' Check if the values are not null or empty before adding them to the ComboBox
                                If Not String.IsNullOrWhiteSpace(taxName) Then
                                    cboT.Items.Add(taxName)
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

    Private Sub cboT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboT.SelectedIndexChanged
        ' Display the corresponding TaxValue in txtET when an item is selected in the ComboBox
        If cboT.SelectedIndex >= 0 AndAlso cboT.SelectedIndex < cboT.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedTaxName As String = cboT.SelectedItem.ToString()

            ' Query the database to get the corresponding TaxValue
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                Try
                    ' Open the connection
                    connection.Open()

                    ' SQL query to retrieve TaxValue based on TaxName
                    Dim query As String = "SELECT TaxValue FROM list_tax WHERE TaxName = @taxName"

                    ' Create a command to execute the query
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameter for TaxName
                        command.Parameters.AddWithValue("@taxName", selectedTaxName)

                        ' Execute the query and get the TaxValue
                        Dim taxValue As Object = command.ExecuteScalar()

                        ' Display the TaxValue in txtET
                        If taxValue IsNot Nothing AndAlso Not DBNull.Value.Equals(taxValue) Then
                            txtET.Text = taxValue.ToString()
                        Else
                            txtET.Text = "N/A" ' Set a default value if TaxValue is null
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error retrieving TaxValue: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Ensure that an item is selected in the ComboBox
        If cboG.SelectedIndex >= 0 AndAlso cboG.SelectedIndex < cboG.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedGenericName As String = cboG.SelectedItem.ToString()

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                Try
                    ' Open the connection
                    connection.Open()

                    ' SQL query to delete the selected Generic Name
                    Dim query As String = "DELETE FROM list_genericname WHERE GenericName = @genericName"

                    ' Create a command to execute the query
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameter for Generic Name
                        command.Parameters.AddWithValue("@genericName", selectedGenericName)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if any rows were affected (i.e., the input exists)
                        If rowsAffected > 0 Then
                            ' If the input exists and deletion is successful, reload the data in the ComboBox
                            load1()
                            MessageBox.Show("Type deleted", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' If the input doesn't exist, show a message box
                            MessageBox.Show("Type does not exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error deleting Generic Name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            ' Handle the case where no item is selected in the ComboBox
        End If
    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ' Ensure that an item is selected in the ComboBox
        If cboMedT.SelectedIndex >= 0 AndAlso cboMedT.SelectedIndex < cboMedT.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedName As String = cboMedT.SelectedItem.ToString()

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                Try
                    ' Open the connection
                    connection.Open()

                    ' SQL query to delete the selected Generic Name
                    Dim query As String = "DELETE FROM list_maintenance WHERE MedType = @type"

                    ' Create a command to execute the query
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameter for Generic Name
                        command.Parameters.AddWithValue("@type", selectedName)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if any rows were affected (i.e., the input exists)
                        If rowsAffected > 0 Then
                            ' If the input exists and deletion is successful, reload the data in the ComboBox
                            load1()
                            MessageBox.Show("Type deleted", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' If the input doesn't exist, show a message box
                            MessageBox.Show("Type does not exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error deleting Generic Name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            ' Handle the case where no item is selected in the ComboBox
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ' Ensure that an item is selected in the ComboBox
        If cboMedc.SelectedIndex >= 0 AndAlso cboMedc.SelectedIndex < cboMedc.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedName As String = cboMedc.SelectedItem.ToString()

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                Try
                    ' Open the connection
                    connection.Open()

                    ' SQL query to delete the selected Generic Name
                    Dim query As String = "DELETE FROM list_maintenance WHERE MedCategory = @type"

                    ' Create a command to execute the query
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameter for Generic Name
                        command.Parameters.AddWithValue("@type", selectedName)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if any rows were affected (i.e., the input exists)
                        If rowsAffected > 0 Then
                            ' If the input exists and deletion is successful, reload the data in the ComboBox
                            load1()
                            MessageBox.Show("Type deleted", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' If the input doesn't exist, show a message box
                            MessageBox.Show("Type does not exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error deleting Generic Name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            ' Handle the case where no item is selected in the ComboBox
        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        ' Ensure that an item is selected in the ComboBox
        If cboVol.SelectedIndex >= 0 AndAlso cboVol.SelectedIndex < cboVol.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedName As String = cboVol.SelectedItem.ToString()

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                Try
                    ' Open the connection
                    connection.Open()

                    ' SQL query to delete the selected Generic Name
                    Dim query As String = "DELETE FROM list_volume WHERE Formulation = @type"

                    ' Create a command to execute the query
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameter for Generic Name
                        command.Parameters.AddWithValue("@type", selectedName)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if any rows were affected (i.e., the input exists)
                        If rowsAffected > 0 Then
                            ' If the input exists and deletion is successful, reload the data in the ComboBox
                            load1()
                            MessageBox.Show("Type deleted", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' If the input doesn't exist, show a message box
                            MessageBox.Show("Type does not exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error deleting Generic Name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            ' Handle the case where no item is selected in the ComboBox
        End If
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        ' Ensure that an item is selected in the ComboBox
        If cboMerC.SelectedIndex >= 0 AndAlso cboMerC.SelectedIndex < cboMerC.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedName As String = cboMerC.SelectedItem.ToString()

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                Try
                    ' Open the connection
                    connection.Open()

                    ' SQL query to delete the selected Generic Name
                    Dim query As String = "DELETE FROM list_maintenance WHERE MerchType = @type"

                    ' Create a command to execute the query
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameter for Generic Name
                        command.Parameters.AddWithValue("@type", selectedName)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if any rows were affected (i.e., the input exists)
                        If rowsAffected > 0 Then
                            ' If the input exists and deletion is successful, reload the data in the ComboBox
                            load1()
                            MessageBox.Show("Type deleted", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' If the input doesn't exist, show a message box
                            MessageBox.Show("Type does not exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error deleting Generic Name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            ' Handle the case where no item is selected in the ComboBox
        End If
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        ' Ensure that an item is selected in the ComboBox
        If cboSc.SelectedIndex >= 0 AndAlso cboSc.SelectedIndex < cboSc.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedName As String = cboSc.SelectedItem.ToString()

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                Try
                    ' Open the connection
                    connection.Open()

                    ' SQL query to delete the selected Generic Name
                    Dim query As String = "DELETE FROM list_maintenance WHERE StorageCond = @type"

                    ' Create a command to execute the query
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameter for Generic Name
                        command.Parameters.AddWithValue("@type", selectedName)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if any rows were affected (i.e., the input exists)
                        If rowsAffected > 0 Then
                            ' If the input exists and deletion is successful, reload the data in the ComboBox
                            load1()
                            MessageBox.Show("Type deleted", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' If the input doesn't exist, show a message box
                            MessageBox.Show("Type does not exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error deleting Generic Name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            ' Handle the case where no item is selected in the ComboBox
        End If
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        ' Ensure that an item is selected in the ComboBox
        If cboT.SelectedIndex >= 0 AndAlso cboT.SelectedIndex < cboT.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedTaxName As String = cboT.SelectedItem.ToString()

            ' Call the DeleteTax function without confirmation or notifications
            DeleteTax(selectedTaxName)

            ' After deletion, reload the data in the ComboBox
            load7()
        Else
            MessageBox.Show("Please select a Tax Name to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DeleteTax(taxName As String)
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to delete the selected Tax
                Dim query As String = "DELETE FROM list_tax WHERE TaxName = @taxName"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Add parameter for Tax Name
                    command.Parameters.AddWithValue("@taxName", taxName)

                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                ' Handle any exceptions (e.g., display an error message)
                MessageBox.Show("Error deleting Tax Name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click

        ' Ensure that an item is selected in the ComboBox
        If cboT.SelectedIndex >= 0 AndAlso cboT.SelectedIndex < cboT.Items.Count Then
            ' Get the selected item from the ComboBox
            Dim selectedTaxName As String = cboT.SelectedItem.ToString()

            ' Check if the txtET is not empty
            If Not String.IsNullOrWhiteSpace(txtET.Text) Then
                ' Get the updated TaxValue from the txtET
                Dim updatedTaxValue As String = txtET.Text

                ' Call the UpdateTax function
                UpdateTax(selectedTaxName, updatedTaxValue)

                ' After updating, reload the data in the ComboBox
                load7()
                reset()
            Else
            End If
        Else
        End If
    End Sub

    Private Sub UpdateTax(taxName As String, updatedTaxValue As String)
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to update the TaxValue for the selected Tax
                Dim query As String = "UPDATE list_tax SET TaxValue = @updatedTaxValue WHERE TaxName = @taxName"

                ' Create a command to execute the query
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters for TaxName and updated TaxValue
                    command.Parameters.AddWithValue("@taxName", taxName)
                    command.Parameters.AddWithValue("@updatedTaxValue", updatedTaxValue)

                    ' Execute the query
                    command.ExecuteNonQuery()

                End Using
            Catch ex As Exception
                ' Handle any exceptions (e.g., display an error message)
                MessageBox.Show("Error updating Tax Value: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnNewM_Click(sender As Object, e As EventArgs) Handles btnNewM.Click
        Try
            ' Validate that txtPromo and txtTValue are not null or empty
            If String.IsNullOrEmpty(txtPromo.Text.Trim()) Then
                MessageBox.Show("Please enter a valid Tax Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrEmpty(txtTValue.Text.Trim()) Then
                MessageBox.Show("Please enter a valid Tax Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Open the connection
            con.Open()

            ' Check if the entered generic name already exists in the database
            Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM list_tax WHERE Taxname = @type", con)
            cmdCheck.Parameters.AddWithValue("@type", txtPromo.Text.Trim())

            Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If count > 0 Then
                ' Generic Name already exists, show a message box
                MessageBox.Show("TAX already exist", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Generic Name does not exist
                ' Validate that txtTValue contains a valid double value
                Dim taxValue As Double

                If Double.TryParse(txtTValue.Text, taxValue) Then
                    Dim cmdInsert As New MySqlCommand("INSERT INTO list_tax (Taxname, TaxValue) VALUES (@type, @value)", con)
                    cmdInsert.Parameters.AddWithValue("@type", txtPromo.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@value", taxValue)

                    cmdInsert.ExecuteNonQuery()

                    ' Provide feedback to the user
                    MessageBox.Show("Type added", "MAXCORE : MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Invalid Tax Value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            ' Clear the text boxes after processing
            txtPromo.Clear()
            txtTValue.Clear()
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class