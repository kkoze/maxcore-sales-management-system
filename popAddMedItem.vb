Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class popAddMedItem
    Private Sub popAddMedItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadcomboBox()
        LoadcomboBox2()
        LoadcomboBox3()
        LoadComboBoxStorageCond()
        LoadcomboBoxGeneric()
        LoadcomboBoxVol()

    End Sub
    Public Sub LoadcomboBoxVol()
        cboVol.Items.Clear() ' Clear existing items

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
                                Dim medType As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(medType) Then
                                    cboVol.Items.Add(medType)
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

    'Populate combobox for MedType
    Public Sub LoadcomboBox()
        cboMType.Items.Clear() ' Clear existing items

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
                                Dim medType As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(medType) Then
                                    cboMType.Items.Add(medType)
                                End If
                            End While
                        End If
                    End Using
                End Using

                ' Add the "Add new medicine type" option
                cboMType.Items.Add("Add new medicine type")
            Catch ex As Exception
                ' Handle any exceptions (e.g., display an error message)
                MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub cboMType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMType.SelectedIndexChanged
        ' Check if the selected item is "Add new medicine type"
        If cboMType.SelectedItem IsNot Nothing AndAlso cboMType.SelectedItem.ToString() = "Add new medicine type" Then
            ' Show the controls for adding a new medicine type
            txtNewType.Visible = True
            btnNewType.Visible = True
        Else
            ' Hide the controls if a different item is selected
            txtNewType.Visible = False
            btnNewType.Visible = False
        End If
    End Sub

    Private Sub btnNewType_Click(sender As Object, e As EventArgs) Handles btnNewType.Click
        ' Prompt the user to confirm adding the new medicine type
        Dim result As DialogResult = MessageBox.Show("Do you want to add the new medicine type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Get the new medicine type from the TextBox
            Dim newMedType As String = txtNewType.Text.Trim()
            txtNewType.Clear()
            If Not String.IsNullOrEmpty(newMedType) Then
                ' Check if the medicine type already exists in the database
                If MedicineTypeExists(newMedType) Then
                    ' Medicine type already exists, show a message to the user
                    MessageBox.Show("The medicine type already exists in the database.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    ' Medicine type does not exist, proceed to add
                    AddNewMedicineType(newMedType)

                    ' Refresh the ComboBox with updated data from the database
                    LoadcomboBox()
                End If
            End If
            txtNewType.Clear()
        End If

        ' Hide the controls
        btnNewType.Visible = False
        txtNewType.Visible = False
    End Sub
    Private Sub AddNewMedicineType(newMedType As String)
        ' Add the logic to insert the new medicine type into the database
        ' You need to implement the code to execute an SQL INSERT statement
        ' using the provided MySqlConnection.
        ' Ensure to handle exceptions appropriately.
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim insertQuery As String = $"INSERT INTO list_maintenance (MedType) VALUES ('{newMedType}')"
                Using command As New MySqlCommand(insertQuery, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding new medicine type: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function MedicineTypeExists(medType As String) As Boolean
        ' Check if the medicine type already exists in the database
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim query As String = $"SELECT COUNT(*) FROM list_maintenance WHERE MedType = '{medType}'"
                Using command As New MySqlCommand(query, connection)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking medicine type existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Return false in case of an error
        End Try
    End Function

    'Populate combobox2 for MedCategory
    Private Sub LoadcomboBox2()
        cboMCategory.Items.Clear() ' Clear existing items

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
                                Dim medCategory As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(medCategory) Then
                                    cboMCategory.Items.Add(medCategory)
                                End If
                            End While
                        End If
                    End Using
                End Using

                ' Add the "Add new medicine category" option
                cboMCategory.Items.Add("Add new medicine category")
            Catch ex As Exception
                ' Handle any exceptions (e.g., display an error message)
                MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub cboMCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMCategory.SelectedIndexChanged
        ' Check if the selected item is "Add new medicine type"
        If cboMCategory.SelectedItem IsNot Nothing AndAlso cboMCategory.SelectedItem.ToString() = "Add new medicine category" Then
            ' Show the controls for adding a new medicine type
            txtNewCateg.Visible = True
            btnNewCateg.Visible = True
        Else
            ' Hide the controls if a different item is selected
            txtNewCateg.Visible = False
            btnNewCateg.Visible = False
        End If
    End Sub
    Private Sub btnNewCateg_Click(sender As Object, e As EventArgs) Handles btnNewCateg.Click
        ' Prompt the user to confirm adding the new medicine category
        Dim result As DialogResult = MessageBox.Show("Do you want to add the new medicine category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            ' Get the new medicine category from the TextBox
            Dim newMedCategory As String = txtNewCateg.Text.Trim()
            If Not String.IsNullOrEmpty(newMedCategory) Then
                ' Check if the medicine category already exists in the database
                If MedicineCategoryExists(newMedCategory) Then
                    ' Medicine category already exists, show a message to the user
                    MessageBox.Show("The medicine category already exists in the database.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' Medicine category does not exist, proceed to add
                    AddNewMedicineCategory(newMedCategory)

                    ' Refresh the ComboBox with updated data from the database
                    LoadcomboBox2()
                End If
            End If

        End If
        txtNewCateg.Clear()
        ' Hide the controls
        btnNewCateg.Visible = False
        txtNewCateg.Visible = False
    End Sub

    Private Function MedicineCategoryExists(medCategory As String) As Boolean
        ' Check if the medicine category already exists in the database
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim query As String = $"SELECT COUNT(*) FROM list_maintenance WHERE MedCategory = '{medCategory}'"
                Using command As New MySqlCommand(query, connection)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking medicine category existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Return false in case of an error
        End Try
    End Function

    Private Sub AddNewMedicineCategory(newMedCategory As String)
        ' Add the logic to insert the new medicine category into the database
        ' You need to implement the code to execute an SQL INSERT statement
        ' using the provided MySqlConnection.
        ' Ensure to handle exceptions appropriately.
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim insertQuery As String = $"INSERT INTO list_maintenance (MedCategory) VALUES ('{newMedCategory}')"
                Using command As New MySqlCommand(insertQuery, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show($"Error adding new medicine category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Populate combobox 4 for generic
    Private Sub LoadcomboBoxGeneric()
        cboGeneric.Items.Clear() ' Clear existing items

        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database for generic names
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
                                Dim genericName As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(genericName) Then
                                    cboGeneric.Items.Add(genericName)
                                End If
                            End While
                        End If
                    End Using
                End Using

                ' Add the "Add new generic name" option
                cboGeneric.Items.Add("Add new generic name")
            Catch ex As Exception
                ' Handle any exceptions (e.g., display an error message)
                MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub cboGeneric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeneric.SelectedIndexChanged

        ' Check if the selected item is "Add new generic name"
        If cboGeneric.SelectedItem IsNot Nothing AndAlso cboGeneric.SelectedItem.ToString() = "Add new generic name" Then
            ' Show the controls for adding a new generic name
            txtNewGen.Visible = True
            btnNewGen.Visible = True
        Else
            ' Hide the controls if a different item is selected
            txtNewGen.Visible = False
            btnNewGen.Visible = False
        End If
    End Sub

    Private Sub btnNewGen_Click(sender As Object, e As EventArgs) Handles btnNewGen.Click
        ' Prompt the user to confirm adding the new generic name
        Dim result As DialogResult = MessageBox.Show("Do you want to add the new generic name?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Get the new generic name from the TextBox
            Dim newGenericName As String = txtNewGen.Text.Trim()
            If Not String.IsNullOrEmpty(newGenericName) Then
                ' Check if the generic name already exists in the database
                If GenericNameExists(newGenericName) Then
                    ' Generic name already exists, show a message to the user
                    MessageBox.Show("The generic name already exists in the database.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' Generic name does not exist, proceed to add
                    AddNewGenericName(newGenericName)

                    ' Refresh the ComboBox with updated data from the database
                    LoadcomboBoxGeneric()
                End If
            End If
        End If

        txtNewGen.Clear()
        ' Hide the controls
        btnNewGen.Visible = False
        txtNewGen.Visible = False
    End Sub

    Private Function GenericNameExists(genericName As String) As Boolean
        ' Check if the generic name already exists in the database
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim query As String = $"SELECT COUNT(*) FROM list_genericname WHERE GenericName = '{genericName}'"
                Using command As New MySqlCommand(query, connection)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking generic name existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Return false in case of an error
        End Try
    End Function

    Private Sub AddNewGenericName(newGenericName As String)
        ' Add the logic to insert the new generic name into the database
        ' You need to implement the code to execute an SQL INSERT statement
        ' using the provided MySqlConnection.
        ' Ensure to handle exceptions appropriately.
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim insertQuery As String = $"INSERT INTO list_genericname (GenericName) VALUES ('{newGenericName}')"
                Using command As New MySqlCommand(insertQuery, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show($"Error adding new generic name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Populate combobox3 for volume
    Public Sub LoadcomboBox3()
        ' Connect to your MySQL database and retrieve data
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"
        Dim query As String = "SELECT Formulation FROM list_volume"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' Create a List to store autocomplete suggestions
                            Dim autoCompleteList As New List(Of String)()

                            While reader.Read()
                                ' Add each value from the database to the List
                                autoCompleteList.Add(reader.GetString(0))
                            End While

                            ' Convert the List to an array
                            Dim autoCompleteArray As String() = autoCompleteList.ToArray()

                            ' Set AutoComplete properties for the TextBox
                            Dim autoComplete As New AutoCompleteStringCollection()
                            autoComplete.AddRange(autoCompleteArray)
                            txtVolume.AutoCompleteCustomSource = autoComplete
                            txtVolume.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                            txtVolume.AutoCompleteSource = AutoCompleteSource.CustomSource
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions (display an error message, etc.)
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Populate combobox4 for storage conditions
    Public Sub LoadComboBoxStorageCond()
        cboSCond.Items.Clear() ' Clear existing items

        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                ' Open the connection
                connection.Open()

                ' SQL query to retrieve data from the database for the "StorageCond" column
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
                                Dim storageCond As String = reader.GetString(0)

                                ' Check if the value is not null or empty before adding it to the ComboBox
                                If Not String.IsNullOrWhiteSpace(storageCond) Then
                                    cboSCond.Items.Add(storageCond)
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





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Display a confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Do you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' User clicked Yes, close the form
            Main.Enabled = True
            Me.Close()
        Else
            ' User clicked No, do nothing (cancel closing)
        End If
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        BBD.Show()
        BBD.lblName.Text = "Best-Before"
        BBD.lblName.Location = New Point(-27, 148)

        BBD.btnConfirm2.Visible = False
        BBD.btnConfirm.Visible = True
        BBD.Guna2TimePicker.Visible = False
        txtDate.Clear()
        ' Set MinDate to today's date for btnDate
        BBD.Guna2DateTimePicker1.MinDate = DateTime.Today
    End Sub

    Private Sub btnDeliver_Click(sender As Object, e As EventArgs) Handles btnDeliver.Click
        BBD.Show()
        txtdateDeliver.Clear()

        BBD.lblName.Text = "Delivery"
        BBD.lblName.Location = New Point(-83, 148)
        BBD.btnConfirm2.Visible = True
        BBD.btnConfirm.Visible = False
        BBD.Guna2TimePicker.Visible = True

        ' Remove the MinDate constraint for btnDeliver
        BBD.Guna2DateTimePicker1.MinDate = DateTimePicker.MinimumDateTime

        ' Set the initial value of Guna2DateTimePicker1
        Dim initialDateTime As DateTime = DateTime.Today.AddHours(14).AddMinutes(30)
        BBD.Guna2DateTimePicker1.Value = initialDateTime
    End Sub

    Private Sub btnUploadImg_Click(sender As Object, e As EventArgs) Handles btnUploadImg.Click
        ' Allow the user to choose a new image and display it in the PictureBox
        Dim openFileDialog As New OpenFileDialog()

        Try
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                uploadImg.Image = Image.FromFile(openFileDialog.FileName)
            End If
        Catch ex As OutOfMemoryException
            MessageBox.Show("File not supported. Please choose another image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Generating Barcode
    Private Sub btnBarcode_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        ' Generate a random barcode
        Dim generatedBarcode As String = GenerateRandomBarcode()

        ' Check if the generated barcode already exists in the database
        If Not BarcodeExistsInDatabase(generatedBarcode) Then
            ' If it doesn't exist, set it in the txtbarcode textbox
            txtbarcode.Text = generatedBarcode
        Else
            ' If it exists, generate a new one or handle it as per your requirement
            MessageBox.Show("Generated barcode already exists in the database. Generating a new one.")
            btnBarcode_Click(sender, e) ' Recursive call to generate a new barcode
        End If
    End Sub

    Private Function GenerateRandomBarcode() As String
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim random As New Random()
        Dim barcode As New StringBuilder()

        For i As Integer = 0 To 11 ' Change 12 to the desired length of your barcode
            Dim index As Integer = random.Next(0, characters.Length)
            barcode.Append(characters(index))
        Next

        Return barcode.ToString()
    End Function

    Private Function BarcodeExistsInDatabase(barcode As String) As Boolean
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM inventory WHERE barcode = @barcode"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@barcode", barcode)

                ' Check if the barcode exists in the database
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    'Check buttons if Prescripted / Not
    Public medicineValue As String = ""

    Private Sub btnPM_CheckedChanged(sender As Object, e As EventArgs) Handles btnPM.CheckedChanged
        ' Set the value when the button is checked
        If btnPM.Checked Then
            medicineValue = "Prescripted Medicine"

            lblSc.Location = New Point(368, 769)
            cboSCond.Location = New Point(371, 785)
            Label11.Visible = True
            txtDosage.Visible = True
        Else
            ' If the button is unchecked, you may want to reset the value
            medicineValue = ""
            lblSc.Location = New Point(368, 698)
            cboSCond.Location = New Point(371, 714)
            Label11.Visible = False
            txtDosage.Visible = False

        End If
    End Sub
    'Check buttons if Regulatory Certified / Not
    Public regulatoryCert As String = ""

    Private Sub btnFda_CheckedChanged(sender As Object, e As EventArgs) Handles btnFda.CheckedChanged
        If btnFda.Checked Then
            regulatoryCert = "FDA Certified"
        Else
            ' Prompt the user and reset the input on the same form
            Dim result As DialogResult = MessageBox.Show("FDA certification not selected. Press OK to reset all.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                ' Reset input on the same form
                txtName.Clear()
                txtbarcode.Clear()
                cboMCategory.SelectedIndex = -1 ' Reset the selected item in the combobox
                cboMType.SelectedIndex = -1
                txtDate.Clear()
                txtdateDeliver.Clear()
                cboGeneric.SelectedIndex = -1
                txtManufacturer.Clear()
                txtStock.Clear()
                txtSupplier.Clear()
                cboSCond.SelectedIndex = -1
                txtDosage.Clear()
                uploadImg.Image = Nothing
                txtBatch.Clear()
                txtSuppId.Clear()
                txtSuppCont.Clear()

            End If
        End If
    End Sub

    'Inputting Information to database
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            ' Validate fields before proceeding
            If Not ValidateFields() Then
                Return ' Exit the method if validation fails
            End If

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()

                ' Calculate the total cost before inserting
                Dim totalCost As Decimal = Decimal.Parse(txtPrice.Text.Trim()) * Integer.Parse(txtStock.Text.Trim())
                Dim totalvol As String = txtVolume.Text.Trim()

                Dim insertQuery As String = "INSERT INTO `inventory`(`barcode`, `ItemType`,`Medicine Type`, `Medicine Category`, `Generic Name`, `Brand Name`, `Volume`,`VolType`, `Manufacturer`, `SupplierID`, `Supplier`,`SupplierAddress`, `SupplierContact`, `CostPerUnit`, `Stock`, `totalcost`, `batch#`, `Description`, `Dosage`, `StorageCondition`, `RegulatoryInformation`, `status`, `ExpiryDate`, `ItemImg`, `datedelivered`,`DateUpdated`) 
VALUES (@Barcode,@type ,@MedType, @MedCategory, @GenericName, @BrandName, @Volume,@Voltype, @Manufacturer, @SupplierID, @Supplier,@Address, @SupplierContact, @CostPerUnit, @Stock, @TotalCost, @Batch, @Description, @Dosage, @StorageCondition, @RegulatoryInformation, @Status, @ExpiryDate, @ItemImg, @DateDelivered,@DateUpdated)"

                Using command As New MySqlCommand(insertQuery, connection)
                    ' Assuming you have added parameters accordingly
                    command.Parameters.AddWithValue("@Barcode", txtbarcode.Text.Trim())
                    command.Parameters.AddWithValue("@type", txtItype.Text.Trim())
                    command.Parameters.AddWithValue("@MedType", cboMType.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@MedCategory", cboMCategory.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@GenericName", cboGeneric.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@BrandName", txtName.Text.Trim())
                    command.Parameters.AddWithValue("@Volume", totalvol)
                    command.Parameters.AddWithValue("@Voltype", cboVol.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text.Trim())
                    command.Parameters.AddWithValue("@SupplierID", txtSuppId.Text.Trim())
                    command.Parameters.AddWithValue("@Supplier", txtSupplier.Text.Trim())
                    command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                    command.Parameters.AddWithValue("@SupplierContact", txtSuppCont.Text.Trim())
                    command.Parameters.AddWithValue("@CostPerUnit", txtPrice.Text.Trim())
                    command.Parameters.AddWithValue("@Stock", txtStock.Text.Trim())
                    command.Parameters.AddWithValue("@TotalCost", totalCost)
                    command.Parameters.AddWithValue("@Batch", txtBatch.Text.Trim())
                    command.Parameters.AddWithValue("@Description", medicineValue)
                    command.Parameters.AddWithValue("@Dosage", txtDosage.Text.Trim())
                    command.Parameters.AddWithValue("@StorageCondition", cboSCond.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@RegulatoryInformation", regulatoryCert)
                    command.Parameters.AddWithValue("@Status", "Available")
                    command.Parameters.AddWithValue("@DateUpdated", DateTime.Now)

                    ' Parse and set the date
                    Dim selectedDate As DateTime
                    If DateTime.TryParse(txtDate.Text, selectedDate) Then
                        command.Parameters.AddWithValue("@ExpiryDate", selectedDate)
                    Else
                        ' Handle the case when the date in txtExpiryDate is not in a valid format
                        command.Parameters.AddWithValue("@ExpiryDate", DBNull.Value)
                    End If

                    ' Parse and set the date delivered
                    If DateTime.TryParse(txtdateDeliver.Text, selectedDate) Then
                        command.Parameters.AddWithValue("@DateDelivered", selectedDate)
                    Else
                        ' Handle the case when the date in txtDateDelivered is not in a valid format
                        command.Parameters.AddWithValue("@DateDelivered", DBNull.Value)
                    End If

                    If uploadImg.Image IsNot Nothing Then
                        ' User has uploaded a custom image
                        Dim imageStream As New MemoryStream()
                        uploadImg.Image.Save(imageStream, ImageFormat.Jpeg)
                        command.Parameters.AddWithValue("@ItemImg", imageStream.ToArray())
                    Else
                        ' No custom image uploaded, prompt the user
                        Dim result As DialogResult = MessageBox.Show("Do you want to use a default image?", "Default Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            ' User chooses to use a default image
                            Dim defaultImage As New Bitmap(My.Resources.MAXCORE_removebg_preview) ' Replace 'DefaultImage' with the name of your default image resource
                            Dim defaultImageStream As New MemoryStream()
                            defaultImage.Save(defaultImageStream, ImageFormat.Jpeg)
                            command.Parameters.AddWithValue("@ItemImg", defaultImageStream.ToArray())
                        Else
                            ' User chooses not to use a default image
                            ' Skip adding the @ItemImg parameter altogether
                        End If
                    End If

                    ' Execute the SQL command
                    command.ExecuteNonQuery()

                    ' Display a success message
                    MessageBox.Show("Item added successfully.", "MAXCORE : PRODUCT MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                    Me.Close()
                    ProdMng.ProdMngmentFunction()
                    Main.Enabled = True
                End Using
            End Using

        Catch ex As Exception
            ' Handle any exceptions (display an error message, etc.)
            MessageBox.Show("Error adding data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(txtbarcode.Text) OrElse
           cboMType.SelectedItem Is Nothing OrElse
           cboMCategory.SelectedItem Is Nothing OrElse
           cboGeneric.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(txtItype.Text) OrElse
           String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtVolume.Text) OrElse
           String.IsNullOrWhiteSpace(txtManufacturer.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppId.Text) OrElse
           String.IsNullOrWhiteSpace(txtSupplier.Text) OrElse
           String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppCont.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtBatch.Text) OrElse
           cboSCond.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(regulatoryCert) OrElse
           String.IsNullOrWhiteSpace(txtDate.Text) OrElse
           String.IsNullOrWhiteSpace(txtdateDeliver.Text) Then

            ' Display a message if any required field is empty
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False ' Validation failed
        End If

        Return True ' Validation passed
    End Function
    Private Function ValidateFields2() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           cboMType.SelectedItem Is Nothing OrElse
           cboMCategory.SelectedItem Is Nothing OrElse
           cboGeneric.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(txtItype.Text) OrElse
           String.IsNullOrWhiteSpace(txtVolume.Text) OrElse
           String.IsNullOrWhiteSpace(txtManufacturer.Text) OrElse
           String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppId.Text) OrElse
           String.IsNullOrWhiteSpace(txtSupplier.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppCont.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtBatch.Text) OrElse
           cboSCond.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(regulatoryCert) Then

            ' Display a message if any required field is empty
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False ' Validation failed
        End If

        Return True ' Validation passed
    End Function
    Private Sub ClearFields()
        ' Clear text fields
        txtbarcode.Clear()
        txtName.Clear()
        txtVolume.Clear()
        txtManufacturer.Clear()
        txtSuppId.Clear()
        txtSupplier.Clear()
        txtSuppCont.Clear()
        txtPrice.Clear()
        txtStock.Clear()
        txtBatch.Clear()
        txtDosage.Clear()
        txtDate.Clear()
        txtdateDeliver.Clear()
        txtItype.Clear()
        ' Reset comboboxes
        cboMType.SelectedIndex = -1
        cboMCategory.SelectedIndex = -1
        cboGeneric.SelectedIndex = -1
        cboSCond.SelectedIndex = -1
        cboVol.SelectedIndex = -1
        ' Reset checkboxes
        btnFda.Checked = True
        btnPM.Checked = False

        ' Clear the image
        uploadImg.Image = Nothing
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim updateQuery As String = "UPDATE `inventory` SET `Medicine Type` = @MedType, `Medicine Category` = @MedCategory, `Generic Name` = @GenericName, `Brand Name` = @BrandName,`ItemType` = @type, `Volume` = @Volume, `VolType` = @Voltype, `Manufacturer` = @Manufacturer, `SupplierID` = @SupplierID, `Supplier` = @Supplier,`SupplierAddress` = @Address, `SupplierContact` = @SupplierContact, `CostPerUnit` = @CostPerUnit, `Stock` = @Stock, `totalcost` = @TotalCost, `batch#` = @Batch, `Description` = @Description, `Dosage` = @Dosage, `StorageCondition` = @StorageCondition, `RegulatoryInformation` = @RegulatoryInformation, `status` = @Status, `ExpiryDate` = @ExpiryDate, `ItemImg` = @ItemImg, `datedelivered` = @DateDelivered,`DateUpdated` = @DateUpdated WHERE `barcode` = @Barcode"
        Dim totalCost As Decimal = Decimal.Parse(txtPrice.Text.Trim()) * Integer.Parse(txtStock.Text.Trim())
        Dim totalvol As String = txtVolume.Text.Trim()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            Using command As New MySqlCommand(updateQuery, connection)
                ' Assuming you have added parameters accordingly

                ' Assuming GetDefaultValueFromDatabase is a method to retrieve default values from the database
                command.Parameters.AddWithValue("@MedType", If(cboMType.SelectedItem IsNot Nothing, cboMType.SelectedItem.ToString(), cboMType.Text.Trim()))
                command.Parameters.AddWithValue("@type", txtItype.Text.Trim())
                command.Parameters.AddWithValue("@MedCategory", If(cboMCategory.SelectedItem IsNot Nothing, cboMCategory.SelectedItem.ToString(), cboMCategory.Text.Trim()))
                command.Parameters.AddWithValue("@GenericName", If(cboGeneric.SelectedItem IsNot Nothing, cboGeneric.SelectedItem.ToString(), cboGeneric.Text.Trim()))
                command.Parameters.AddWithValue("@BrandName", txtName.Text.Trim())
                command.Parameters.AddWithValue("@Barcode", txtbarcode.Text.Trim())
                command.Parameters.AddWithValue("@Volume", totalvol)
                command.Parameters.AddWithValue("@Voltype", If(cboVol.SelectedItem IsNot Nothing, cboVol.SelectedItem.ToString(), cboVol.Text.Trim()))
                command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text.Trim())
                command.Parameters.AddWithValue("@SupplierID", txtSuppId.Text.Trim())
                command.Parameters.AddWithValue("@Supplier", txtSupplier.Text.Trim())
                command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                command.Parameters.AddWithValue("@SupplierContact", txtSuppCont.Text.Trim())
                command.Parameters.AddWithValue("@CostPerUnit", txtPrice.Text.Trim())
                command.Parameters.AddWithValue("@Stock", txtStock.Text.Trim())
                command.Parameters.AddWithValue("@TotalCost", totalCost)
                command.Parameters.AddWithValue("@Batch", txtBatch.Text.Trim())
                command.Parameters.AddWithValue("@Description", medicineValue)
                command.Parameters.AddWithValue("@Dosage", txtDosage.Text.Trim())
                command.Parameters.AddWithValue("@StorageCondition", If(cboSCond.SelectedItem IsNot Nothing, cboSCond.SelectedItem.ToString(), cboSCond.Text.Trim()))
                command.Parameters.AddWithValue("@RegulatoryInformation", regulatoryCert)
                command.Parameters.AddWithValue("@Status", "Available")
                command.Parameters.AddWithValue("@DateUpdated", DateTime.Now)
                ' Add other parameters...
                ' Parse and set the date


                Dim selectedDate As DateTime
                If DateTime.TryParse(txtDate.Text, selectedDate) Then
                    command.Parameters.AddWithValue("@ExpiryDate", selectedDate)
                Else
                    ' Handle the case when the date in txtExpiryDate is not in a valid format
                    command.Parameters.AddWithValue("@ExpiryDate", DBNull.Value)
                End If

                ' Parse and set the date delivered
                If DateTime.TryParse(txtdateDeliver.Text, selectedDate) Then
                    command.Parameters.AddWithValue("@DateDelivered", selectedDate)
                Else
                    ' Handle the case when the date in txtDateDelivered is not in a valid format
                    command.Parameters.AddWithValue("@DateDelivered", DBNull.Value)
                End If

                If uploadImg.Image IsNot Nothing Then
                    ' User has uploaded a custom image
                    Dim imageStream As New MemoryStream()
                    uploadImg.Image.Save(imageStream, ImageFormat.Jpeg)
                    command.Parameters.AddWithValue("@ItemImg", imageStream.ToArray())
                Else
                    ' No custom image uploaded, prompt the user
                    Dim result As DialogResult = MessageBox.Show("Do you want to use a default image?", "Default Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        ' User chooses to use a default image
                        Dim defaultImage As New Bitmap(My.Resources.MAXCORE_removebg_preview) ' Replace 'DefaultImage' with the name of your default image resource
                        Dim defaultImageStream As New MemoryStream()
                        defaultImage.Save(defaultImageStream, ImageFormat.Jpeg)
                        command.Parameters.AddWithValue("@ItemImg", defaultImageStream.ToArray())
                    Else
                        ' User chooses not to use a default image
                        ' Skip adding the @ItemImg parameter altogether
                    End If
                End If
                ' Execute the SQL command
                command.ExecuteNonQuery()

                ' Display a success message
                MessageBox.Show("Item updated successfully.", "MAXCORE : PRODUCT MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Main.Enabled = True
                ' Optionally, you can clear fields or perform other actions after the update
                ClearFields()
                ProdMng.ProdMngmentFunction()
            End Using
        End Using


        'Catch ex As Exception
        '    ' Handle any exceptions (display an error message, etc.)
        '    MessageBox.Show("Error updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            ' Assuming you have a unique identifier for the record (e.g., barcode)
            Dim deleteQuery As String = "DELETE FROM `inventory` WHERE `barcode` = @Barcode"

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()

                Using command As New MySqlCommand(deleteQuery, connection)
                    ' Assuming you have added parameters accordingly
                    command.Parameters.AddWithValue("@Barcode", txtbarcode.Text.Trim())

                    ' Execute the SQL command
                    command.ExecuteNonQuery()

                    ' Display a success message
                    MessageBox.Show("Item deleted successfully.", "MAXCORE : PRODUCT MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    ' Optionally, you can clear fields or perform other actions after the delete
                    ClearFields()
                    ProdMng.ProdMngmentFunction()
                    Main.Enabled = True
                End Using
            End Using

        Catch ex As Exception
            ' Handle any exceptions (display an error message, etc.)
            MessageBox.Show("Error deleting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        ' Close the current instance of the form
        Me.Close()

        ' Create and show a new instance of the form
        Dim newForm As New popAddMedItem()
        newForm.Show()
    End Sub
    ' Declare the ListBox with WithEvents
    WithEvents listBoxSuggestions As New ListBox()

    Private Sub txtVolume_TextChanged(sender As Object, e As EventArgs) Handles txtVolume.TextChanged
        ' Clear the existing items in the ListBox
        listBoxSuggestions.Items.Clear()

        ' Get suggestions from the database based on the current input
        Dim suggestions As List(Of String) = GetSuggestionsFromDatabase(txtVolume.Text)

        ' Add suggestions to the ListBox
        listBoxSuggestions.Items.AddRange(suggestions.ToArray())

        ' Show the ListBox
        listBoxSuggestions.Visible = True
    End Sub

    Private Function GetSuggestionsFromDatabase(prefix As String) As List(Of String)
        Dim suggestions As New List(Of String)()
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Construct the SQL query with a WHERE clause to filter results based on the current input
            Dim query As String = "SELECT Formulation FROM list_volume WHERE Formulation LIKE @prefix"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@prefix", prefix & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        suggestions.Add(reader("Formulation").ToString())
                    End While
                End Using
            End Using
        End Using

        Return suggestions
    End Function

    Private Sub listBoxSuggestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxSuggestions.SelectedIndexChanged
        ' Set the selected item from the ListBox to the TextBox
        If listBoxSuggestions.SelectedItem IsNot Nothing Then
            txtVolume.Text = listBoxSuggestions.SelectedItem.ToString()
        End If

        ' Hide the ListBox after selecting an item
        listBoxSuggestions.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show("Hello")
    End Sub
End Class