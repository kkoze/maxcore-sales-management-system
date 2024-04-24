Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Drawing.Imaging
Imports System.IO

Public Class popAddMerchItem
    Private Sub popAddMerchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadcomboBox()
        LoadcomboBoxVol()
        LoadComboBoxStorageCond()
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
    Public Sub LoadcomboBox()
        cboMType.Items.Clear() ' Clear existing items

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
                cboMType.Items.Add("Add new merchandise type")
            Catch ex As Exception
                ' Handle any exceptions (e.g., display an error message)
                MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub cboMType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMType.SelectedIndexChanged
        ' Check if the selected item is "Add new medicine type"
        If cboMType.SelectedItem IsNot Nothing AndAlso cboMType.SelectedItem.ToString() = "Add new merchandise type" Then
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
        Dim result As DialogResult = MessageBox.Show("Do you want to add the new merchandise type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Get the new medicine type from the TextBox
            Dim newMedType As String = txtNewType.Text.Trim()
            txtNewType.Clear()
            If Not String.IsNullOrEmpty(newMedType) Then
                ' Check if the medicine type already exists in the database
                If MerchTypeExists(newMedType) Then
                    ' Medicine type already exists, show a message to the user
                    MessageBox.Show("The merchandise type already exists in the database.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    ' Medicine type does not exist, proceed to add
                    AddNewMerchType(newMedType)

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
    Private Sub AddNewMerchType(newMedType As String)
        ' Add the logic to insert the new medicine type into the database
        ' You need to implement the code to execute an SQL INSERT statement
        ' using the provided MySqlConnection.
        ' Ensure to handle exceptions appropriately.
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim insertQuery As String = $"INSERT INTO list_maintenance (MerchType) VALUES ('{newMedType}')"
                Using command As New MySqlCommand(insertQuery, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding new merchandise type: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function MerchTypeExists(medType As String) As Boolean
        ' Check if the medicine type already exists in the database
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim query As String = $"SELECT COUNT(*) FROM list_maintenance WHERE MerchType = '{medType}'"
                Using command As New MySqlCommand(query, connection)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking merchandise type existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Return false in case of an error
        End Try
    End Function
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
        Dim newForm As New popAddMerchItem()
        newForm.Show()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Validate fields before proceeding
            If Not ValidateFields() Then
                Return ' Exit the method if validation fails
            End If

            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()

                ' Calculate the total cost before updating
                Dim totalCost As Decimal = Decimal.Parse(txtPrice.Text.Trim()) * Integer.Parse(txtStock.Text.Trim())
                Dim totalvol As String = txtVolume.Text.Trim()

                Dim updateQuery As String = "UPDATE `inventory` SET `ItemType`=@type, `Brand Name`=@BrandName, `MerchType`=@Mtype, `Volume`=@Volume, `VolType` =@Voltype, `Manufacturer`=@Manufacturer, `SupplierID`=@SupplierID, `Supplier`=@Supplier, `SupplierAddress`=@Address, `SupplierContact`=@SupplierContact, `CostPerUnit`=@CostPerUnit, `Stock`=@Stock, `totalcost`=@TotalCost, `batch#`=@Batch, `StorageCondition`=@StorageCondition, `RegulatoryInformation`=@RegulatoryInformation, `ExpiryDate`=@ExpiryDate, `ItemImg`=@ItemImg, `DateUpdated`=@DateUpdated WHERE `barcode`=@Barcode"

                Using command As New MySqlCommand(updateQuery, connection)
                    ' Assuming you have added parameters accordingly
                    command.Parameters.AddWithValue("@Barcode", txtbarcode.Text.Trim())
                    command.Parameters.AddWithValue("@type", txtItype.Text.Trim())
                    command.Parameters.AddWithValue("@BrandName", txtName.Text.Trim())
                    command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                    command.Parameters.AddWithValue("@Mtype", cboMType.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@Volume", totalvol)
                    command.Parameters.AddWithValue("@Voltype", If(cboVol.SelectedItem IsNot Nothing, cboVol.SelectedItem.ToString(), cboVol.Text.Trim()))
                    command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text.Trim())
                    command.Parameters.AddWithValue("@SupplierID", txtSuppId.Text.Trim())
                    command.Parameters.AddWithValue("@Supplier", txtSupplier.Text.Trim())
                    command.Parameters.AddWithValue("@SupplierContact", txtSuppCont.Text.Trim())
                    command.Parameters.AddWithValue("@CostPerUnit", txtPrice.Text.Trim())
                    command.Parameters.AddWithValue("@Stock", txtStock.Text.Trim())
                    command.Parameters.AddWithValue("@TotalCost", totalCost)
                    command.Parameters.AddWithValue("@Batch", txtBatch.Text.Trim())
                    command.Parameters.AddWithValue("@StorageCondition", If(cboSCond.SelectedItem IsNot Nothing, cboSCond.SelectedItem.ToString(), cboSCond.Text.Trim()))
                    command.Parameters.AddWithValue("@RegulatoryInformation", regulatoryCert)

                    ' Parse and set the date
                    Dim selectedDate As DateTime
                    If DateTime.TryParse(txtDate.Text, selectedDate) Then
                        command.Parameters.AddWithValue("@ExpiryDate", selectedDate)
                    Else
                        command.Parameters.AddWithValue("@ExpiryDate", DBNull.Value)
                    End If

                    ' If an image is uploaded, update it; otherwise, keep the existing one
                    If uploadImg.Image IsNot Nothing Then
                        Dim imageStream As New MemoryStream()
                        uploadImg.Image.Save(imageStream, ImageFormat.Jpeg)
                        command.Parameters.AddWithValue("@ItemImg", imageStream.ToArray())
                    End If

                    command.Parameters.AddWithValue("@DateUpdated", DateTime.Now)

                    ' Execute the SQL command
                    command.ExecuteNonQuery()

                    ' Display a success message
                    MessageBox.Show("Item updated successfully.", "MAXCORE : PRODUCT MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                    Main.Enabled = True
                    Me.Close()
                    ProdMng.ProdMngmentFunction()

                End Using
            End Using

        Catch ex As Exception
            ' Handle any exceptions (display an error message, etc.)
            MessageBox.Show("Error updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
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
                cboMType.SelectedIndex = -1 ' Reset the selected item in the combobox

                txtDate.Clear()
                txtdateDeliver.Clear()
                txtManufacturer.Clear()
                txtStock.Clear()
                txtSupplier.Clear()
                cboSCond.SelectedIndex = -1
                uploadImg.Image = Nothing
                txtBatch.Clear()
                txtSuppId.Clear()
                txtSuppCont.Clear()

            End If
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

                Dim insertQuery As String = "INSERT INTO `inventory`(`barcode`, `ItemType`, `Brand Name`,`MerchType`, `Volume`, `VolType` ,`Manufacturer`, `SupplierID`, `Supplier`,`SupplierAddress`, `SupplierContact`, `CostPerUnit`, `Stock`, `totalcost`, `batch#`,  `StorageCondition`, `RegulatoryInformation`, `status`, `ExpiryDate`, `ItemImg`, `datedelivered`,`DateUpdated`) 
VALUES (@Barcode,@type ,@BrandName, @Mtype, @Volume, @Voltype ,@Manufacturer, @SupplierID, @Supplier,@Address,@SupplierContact, @CostPerUnit, @Stock, @TotalCost, @Batch, @StorageCondition, @RegulatoryInformation, @Status, @ExpiryDate, @ItemImg, @DateDelivered, @DateUpdated)"

                Using command As New MySqlCommand(insertQuery, connection)
                    ' Assuming you have added parameters accordingly
                    command.Parameters.AddWithValue("@Barcode", txtbarcode.Text.Trim())
                    command.Parameters.AddWithValue("@type", txtItype.Text.Trim())
                    command.Parameters.AddWithValue("@BrandName", txtName.Text.Trim())
                    command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                    command.Parameters.AddWithValue("@Mtype", cboMType.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@Volume", totalvol)
                    command.Parameters.AddWithValue("@Voltype", cboVol.SelectedItem?.ToString())
                    command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text.Trim())
                    command.Parameters.AddWithValue("@SupplierID", txtSuppId.Text.Trim())
                    command.Parameters.AddWithValue("@Supplier", txtSupplier.Text.Trim())
                    command.Parameters.AddWithValue("@SupplierContact", txtSuppCont.Text.Trim())
                    command.Parameters.AddWithValue("@CostPerUnit", txtPrice.Text.Trim())
                    command.Parameters.AddWithValue("@Stock", txtStock.Text.Trim())
                    command.Parameters.AddWithValue("@TotalCost", totalCost)
                    command.Parameters.AddWithValue("@Batch", txtBatch.Text.Trim())
                    command.Parameters.AddWithValue("@StorageCondition", If(cboSCond.SelectedItem IsNot Nothing, cboSCond.SelectedItem.ToString(), cboSCond.Text.Trim()))
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
        txtItype.Clear()
        txtDate.Clear()
        txtdateDeliver.Clear()

        ' Reset comboboxes
        cboMType.SelectedIndex = -1

        cboSCond.SelectedIndex = -1

        ' Reset checkboxes
        btnFda.Checked = True


        ' Clear the image
        uploadImg.Image = Nothing
    End Sub
    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(txtbarcode.Text) OrElse
           String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtVolume.Text) OrElse
           String.IsNullOrWhiteSpace(txtManufacturer.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppId.Text) OrElse
           String.IsNullOrWhiteSpace(txtSupplier.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppCont.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtBatch.Text) OrElse
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
           String.IsNullOrWhiteSpace(txtVolume.Text) OrElse
           String.IsNullOrWhiteSpace(txtManufacturer.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppId.Text) OrElse
           String.IsNullOrWhiteSpace(txtSupplier.Text) OrElse
           String.IsNullOrWhiteSpace(txtSuppCont.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtBatch.Text) Then

            ' Display a message if any required field is empty
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False ' Validation failed
        End If

        Return True ' Validation passed
    End Function


End Class