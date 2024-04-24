Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Text
Imports System.Windows.Controls
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class SalesOrderMng
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Dim dt As New DataTable
    Private bs As New BindingSource()
    Private taxRate As Decimal = 0.12 ' Set the tax rate as a class-level variable

    Private Sub SalesOrderMng_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            GenerateAndSetReferenceNumber()
        End If
        If e.KeyCode = Keys.F1 Then
            ProcessPayment()
        End If
    End Sub
    Private Sub SalesOrderMng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empname.Text = Main.txtName.Text
        Timer1.Enabled = True
        txtSearchC.Enabled = True
        ' Initialize your DataTable (dt)
        dt.Columns.Add("Item#", GetType(Integer))
        dt.Columns.Add("Qty", GetType(Integer))
        dt.Columns.Add("Barcode", GetType(String))
        dt.Columns.Add("Product Name", GetType(String))
        dt.Columns.Add("Item Type", GetType(String))
        dt.Columns.Add("Volume", GetType(String))
        dt.Columns.Add("Price per Item", GetType(Single))
        dt.Columns.Add("Total Price", GetType(Single))

        ' Set the DataSource property of dtgSales to dt
        dtgSales.DataSource = dt
        ' Set the DataSource property of dtgSales to the BindingSource
        bs.DataSource = dt
        dtgSales.DataSource = bs

        ' Make all columns read-only by default
        For Each column As DataGridViewColumn In dtgSales.Columns
            column.ReadOnly = True
        Next

        ' Allow editing for the "Qty" column
        dtgSales.Columns("Qty").ReadOnly = False
        ' Add the CellEndEdit event handler

        PopulateTaxComboBox()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dates.Text = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub
    Private Sub PopulateTaxComboBox()
        ' Connection string
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"

        ' SQL query to select TaxName from list_tax table
        Dim query As String = "SELECT TaxName FROM list_tax"

        ' Create connection and command objects
        Using con As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, con)
                Try
                    ' Open the connection
                    con.Open()

                    ' Execute the query and read the data
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear existing items in the ComboBox
                        cboTax.Items.Clear()

                        ' Iterate through the result set and add each TaxName to the ComboBox
                        While reader.Read()
                            cboTax.Items.Add(reader("TaxName").ToString())
                        End While
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error loading tax names: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Event handler for the ComboBox's SelectedIndexChanged event
    Private Sub cboTax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTax.SelectedIndexChanged
        ' Check if an item is selected
        If cboTax.SelectedIndex <> -1 Then
            ' Get the selected item
            Dim selectedTaxName As String = cboTax.SelectedItem.ToString()

            ' Query the database for the tax rate associated with the selected item
            Dim taxRateFromDatabase As Decimal = GetTaxRateFromDatabase(selectedTaxName)

            ' Update the taxRate based on the retrieved value
            If taxRateFromDatabase <> -1 Then
                taxRate = taxRateFromDatabase
                ' Optionally, display the updated tax rate
                Debug.WriteLine("Updated Tax Rate: " & taxRate.ToString())
            Else
                ' Handle the case where the tax rate is not found in the database
                MessageBox.Show("Tax rate not found for selected item.")
            End If

            ' Recalculate and display the total price when the tax changes
            UpdateTotalPriceAndQuantity()

            ' Update txtChange based on the selected tax
            UpdateChangeAmount()
        End If
    End Sub

    Private Sub UpdateChangeAmount()
        Dim totalPriceText As String = lbltotalPrice.Text
        Dim singleResult As Single

        ' Try to parse the string into a Single
        If Single.TryParse(totalPriceText, singleResult) Then
            ' Parsing successful, singleResult now contains the parsed value
            Debug.WriteLine("Parsed Single: " & singleResult)

            ' Check if txtCCash is not empty
            If Not String.IsNullOrWhiteSpace(txtCCash.Text) Then
                ' Parse txtCCash.Text into numeric variable
                Dim cashAmount As Single
                If Single.TryParse(txtCCash.Text, cashAmount) Then
                    ' Parsing successful, cashAmount now contains the numeric value

                    ' Ensure the result is not negative
                    If cashAmount >= singleResult Then
                        ' Perform subtraction
                        Dim changeAmount As Single = cashAmount - singleResult

                        ' Display the result in txtChange
                        txtChange.Text = changeAmount.ToString("F2")
                    Else
                        ' Handle the case where cash amount is less than total price
                        txtChange.Text = "0.00"
                    End If
                Else
                    ' Parsing failed for cash amount, handle the error as needed
                    txtChange.Text = "0.00"
                    Debug.WriteLine("Failed to parse cash amount.")
                End If
            Else
                ' Handle the case where txtCCash is empty
                txtChange.Text = "0.00"
            End If
        Else
            ' Parsing failed for total price, handle the error as needed
            Debug.WriteLine("Failed to parse the float.")
        End If
    End Sub

    Private Function GetTaxRateFromDatabase(selectedTaxName As String) As Decimal
        Dim taxRate As Decimal = -1 ' Default value indicating failure
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"
        Dim query As String = "SELECT TaxValue FROM list_tax WHERE TaxName = @TaxName"
        ' Create connection and command objects
        Using con As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, con)
                ' Add parameter to the command
                cmd.Parameters.AddWithValue("@TaxName", selectedTaxName)
                Try
                    ' Open the connection
                    con.Open()

                    ' Execute the query and read the data
                    Dim result As Object = cmd.ExecuteScalar()

                    ' Check if the result is not null
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        ' Parse the result to Decimal
                        taxRate = Convert.ToDecimal(result)
                    End If
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error retrieving tax rate: " & ex.Message)
                End Try
            End Using
        End Using

        Return taxRate
    End Function
    Private Sub txtSearchC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchC.KeyPress
        ' Check if the pressed key is Enter
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Prevent the Enter key from being processed further
            e.Handled = True

            If Not String.IsNullOrEmpty(txtSearchC.Text.Trim()) Then

                Dim existingRow As DataRow = dt.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("Barcode").ToString() = txtSearchC.Text.Trim())
                If existingRow IsNot Nothing Then
                    ' If the row with the same barcode already exists, update the quantity
                    Dim newQuantity As Integer = CInt(existingRow("Qty")) + 1
                    existingRow("Qty") = newQuantity
                Else

                    con.Open()
                    Dim query As String = "SELECT `prdname`,`barcode`, `genname`,`type`, `volume`, `volumetype`,`costunit`,`quantity` FROM transaction WHERE cusref = @cusref"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@cusref", txtSearchC.Text.Trim())
                        Dim dtFromDb As New DataTable()
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dtFromDb)
                        End Using

                        If dtFromDb.Rows.Count > 0 Then
                            txtSearchC.Enabled = False
                            For Each dbRow As DataRow In dtFromDb.Rows
                                Dim foundRow As DataRow = dt.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) String.Equals(row("Barcode").ToString(), dbRow("barcode").ToString(), StringComparison.OrdinalIgnoreCase))

                                If foundRow IsNot Nothing Then
                                    ' If the row with the same barcode already exists, update the quantity
                                    Dim newQuantity As Integer = CInt(foundRow("Qty")) + 1
                                    foundRow("Qty") = newQuantity
                                Else
                                    ' If the row with the same barcode does not exist, add a new row
                                    Dim newRowFromDb As DataRow = dt.NewRow()

                                    Dim itemNumberFromDb As Integer = dt.Rows.Count + 1
                                    newRowFromDb("Item#") = itemNumberFromDb
                                    newRowFromDb("Item Type") = dbRow("type")
                                    newRowFromDb("Product Name") = $"{dbRow("prdname")} {dbRow("genname")}"
                                    newRowFromDb("Volume") = $"{dbRow("volume")} {dbRow("volumetype")}"
                                    newRowFromDb("Price per Item") = dbRow("costunit")
                                    newRowFromDb("Qty") = dbRow("quantity")
                                    newRowFromDb("Barcode") = dbRow("barcode")
                                    newRowFromDb("Total Price") = Convert.ToSingle(newRowFromDb("Qty")) * Convert.ToSingle(newRowFromDb("Price per Item"))
                                    txtCRef.Text = txtSearchC.Text.Trim()

                                    dt.Rows.Add(newRowFromDb)
                                End If
                            Next
                        Else
                            MessageBox.Show("Customer Ref# not found", "MAXCORE : SALES ORDER MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            con.Close()
                            Exit Sub ' Exit the sub if no cusref is found
                        End If
                    End Using
                    con.Close()
                End If
                dtgSales.DataSource = dt
                UpdateTotalPriceAndQuantity()
            End If
        End If
    End Sub
    ' SEARCH PER ITEMS IN TEXT BOX
    Private Sub txtSearchCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchCode.KeyPress
        ' Check if the pressed key is Enter
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Prevent the Enter key from being processed further
            e.Handled = True

            If Not String.IsNullOrEmpty(txtSearchCode.Text.Trim()) Then

                Dim itemNumber As Integer = dt.Rows.Count + 1

                Dim availableStock As Integer = GetAvailableStockFromDatabase(txtSearchCode.Text.Trim())

                If availableStock > 0 Then
                    Dim existingRow As DataRow = dt.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("Barcode").ToString() = txtSearchCode.Text.Trim())
                    If existingRow IsNot Nothing Then
                        Dim newQuantity As Integer = CInt(existingRow("Qty")) + 1
                        newQuantity = Math.Min(newQuantity, availableStock)
                        existingRow("Qty") = newQuantity
                        If newQuantity >= availableStock Then
                            MessageBox.Show("Item is out of stock. Quantity set to available stock.", "MAXCORE : SALES ORDER MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        Dim newRow As DataRow = dt.NewRow()
                        newRow("Item#") = itemNumber
                        newRow("Qty") = 1
                        newRow("Barcode") = txtSearchCode.Text.Trim()
                        con.Open()
                        Dim query As String = "SELECT `Brand Name`,`ItemType`, `Generic Name`, `Volume`, `VolType`,`CostPerUnit` FROM inventory WHERE barcode = @Barcode"
                        Using cmd As New MySqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@Barcode", txtSearchCode.Text.Trim())
                            Dim dtFromDb As New DataTable()
                            Using da As New MySqlDataAdapter(cmd)
                                da.Fill(dtFromDb)
                            End Using
                            If dtFromDb.Rows.Count > 0 Then
                                newRow("Product Name") = $"{dtFromDb.Rows(0)("Brand Name")} {dtFromDb.Rows(0)("Generic Name")}"
                                newRow("Volume") = $"{dtFromDb.Rows(0)("Volume")} {dtFromDb.Rows(0)("VolType")}"
                                newRow("Price per Item") = dtFromDb.Rows(0)("CostPerUnit")
                                newRow("Item Type") = dtFromDb.Rows(0)("ItemType")
                                newRow("Total Price") = CInt(newRow("Qty")) * Convert.ToSingle(newRow("Price per Item"))

                            End If
                        End Using
                        con.Close()

                        dt.Rows.Add(newRow)
                    End If
                    dtgSales.DataSource = dt
                    UpdateTotalPriceAndQuantity()
                Else
                    MessageBox.Show("Item is out of stock", "MAXCORE : SALES ORDER MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub dtgSales_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgSales.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                ' Check if there are rows in the DataGridView
                If dtgSales.SelectedRows.Count > 0 Then
                    ' Get the unique identifier (Item# in this case) of the selected row
                    Dim itemNumber As Integer = CInt(dtgSales.SelectedRows(0).Cells("Item#").Value)

                    ' Find and remove the row from the DataTable
                    For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                        If CInt(dt.Rows(i)("Item#")) = itemNumber Then
                            dt.Rows.RemoveAt(i)

                            ' Decrement the Item# for rows with Item# greater than the deleted row
                            For j As Integer = i To dt.Rows.Count - 1
                                dt.Rows(j)("Item#") = CInt(dt.Rows(j)("Item#")) - 1
                            Next

                            Exit For
                        End If
                    Next

                    ' Recalculate and display the total price
                    UpdateTotalPriceAndQuantity()

                    ' Reset the selection to avoid issues with subsequent row deletion
                    dtgSales.ClearSelection()

                    ' Display a message after deleting the row
                    MessageBox.Show("Item Deleted", "MAXCORE: SALES ORDER MANAGEMENT")
                End If
            End If
        Catch ex As Exception
            ' Handle exceptions (e.g., display a message)
            MessageBox.Show("Error handling key: " & ex.Message)
        Finally
            ' Check if there are no rows in dtgSales
            If dtgSales.Rows.Count = 0 Then
                MessageBox.Show("Input product.", "MAXCORE: SALES ORDER MANAGEMENT")
            End If
        End Try
    End Sub
    Private Sub dtgSales_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtgSales.CellBeginEdit
        ' Check if the editing cell is not in the "Qty" column
        If e.RowIndex >= 0 AndAlso dtgSales.Columns(e.ColumnIndex).Name <> "Qty" Then
            ' Cancel the edit for other columns
            e.Cancel = True
        End If
    End Sub

    Private Sub dtgSales_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSales.CellEndEdit
        Try
            ' Check if the edited cell is in the "Qty" column
            If e.ColumnIndex = dtgSales.Columns("Qty").Index Then
                ' Get the edited row
                Dim editedRow As DataGridViewRow = dtgSales.Rows(e.RowIndex)

                ' Get the unique identifier (Item# in this case) of the edited row
                Dim itemNumber As Integer = CInt(editedRow.Cells("Item#").Value)

                ' Find the corresponding row in the DataTable
                Dim rowToUpdate As DataRow = dt.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) CInt(row("Item#")) = itemNumber)

                ' Update the quantity in the DataTable
                If rowToUpdate IsNot Nothing Then
                    Dim newQuantity As Integer = CInt(editedRow.Cells("Qty").Value)

                    ' Perform a database query to get the available stock
                    Dim availableStock As Integer = GetAvailableStockFromDatabase(rowToUpdate("Barcode").ToString())
                    MessageBox.Show("Low Stock! Entered quantity exceeds available stock.", "MAXCORE: SALES ORDER MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ' Limit the entered quantity to the available stock
                    newQuantity = Math.Min(newQuantity, availableStock)

                    ' Update the quantity in the DataTable
                    rowToUpdate("Qty") = newQuantity

                    ' Recalculate and display the total price
                    UpdateTotalPriceAndQuantity()
                End If
            End If
        Catch ex As Exception
            ' Handle exceptions (e.g., display a message)
            MessageBox.Show("Error updating quantity: " & ex.Message)
        End Try
    End Sub

    Private Function GetAvailableStockFromDatabase(barcode As String) As Integer
        ' Replace the connection string with your actual database connection string
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"

        ' SQL query to select the 'Stock' column from the 'inventory' table based on the barcode
        Dim query As String = "SELECT `Stock` FROM `inventory` WHERE `barcode` = @Barcode"

        ' Create connection and command objects
        Using con As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, con)
                ' Add parameter to the command
                cmd.Parameters.AddWithValue("@Barcode", barcode)

                Try
                    ' Open the connection
                    con.Open()

                    ' Execute the query and read the data
                    Dim result As Object = cmd.ExecuteScalar()

                    ' Check if the result is not null
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        ' Parse the result to Integer
                        Return Convert.ToInt32(result)
                    Else
                        ' If the result is null or DBNull, return 0 or any default value
                        Return 0
                    End If
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error retrieving available stock: " & ex.Message)
                    ' Return 0 or any default value in case of an error
                    Return 0
                End Try
            End Using
        End Using
    End Function


    Private Sub UpdateTotalPriceAndQuantity()
        ' Your existing logic to calculate and display the total price
        Dim totalPrice As Decimal = 0
        Dim totalQuantity As Integer = 0

        For Each row As DataRow In dt.Rows
            Dim quantity As Integer = If(Convert.IsDBNull(row("Qty")), 0, CInt(row("Qty")))
            Dim costPerUnit As Decimal = If(Convert.IsDBNull(row("Price per Item")), 0, Convert.ToDecimal(row("Price per Item")))
            Dim totalPerRow As Decimal = quantity * costPerUnit

            ' Update the "Total Price" column for the current row
            row("Total Price") = totalPerRow

            totalQuantity += quantity
            totalPrice += totalPerRow
        Next

        ' Calculate and display the subtotal
        Dim subtotal As Decimal = totalPrice

        ' Calculate and add the tax
        Dim tax As Decimal = totalPrice * taxRate
        totalPrice += tax

        ' Display the total price, total quantity, and subtotal in the appropriate TextBoxes
        lbltotalPrice.Text = totalPrice.ToString("F2") ' You can format it as currency if needed
        txtTqty.Text = totalQuantity.ToString()
        txtSTotal.Text = subtotal.ToString("F2") ' You can format it as currency if needed
        txtTax.Text = tax.ToString("F2")
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        productList.Show()
        productList.productFunction()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
    End Sub
    Private Sub txtCCash_TextChanged(sender As Object, e As EventArgs) Handles txtCCash.TextChanged
        Dim totalPriceText As String = lbltotalPrice.Text ' Correct the label name to "lblTotalPrice"
        Dim singleResult As Single
        ' Try to parse the string into a Single
        If Single.TryParse(totalPriceText, singleResult) Then
            ' Parsing successful, singleResult now contains the parsed value
            Debug.WriteLine("Parsed Single: " & singleResult)

            ' Check if txtCCash is not empty
            If Not String.IsNullOrWhiteSpace(txtCCash.Text) Then
                ' Parse txtCCash.Text into numeric variable
                Dim cashAmount As Single
                If Single.TryParse(txtCCash.Text, cashAmount) Then
                    ' Parsing successful, cashAmount now contains the numeric value

                    ' Ensure the result is not negative
                    If cashAmount >= singleResult Then
                        ' Perform subtraction
                        Dim changeAmount As Single = cashAmount - singleResult

                        ' Display the result in txtChange
                        txtChange.Text = changeAmount.ToString("F2")
                    Else
                        ' Handle the case where cash amount is less than total price
                        txtChange.Text = "Insufficient Amount"
                    End If
                Else
                    ' Parsing failed for cash amount, handle the error as needed
                    txtChange.Text = "0.00"
                    Debug.WriteLine("Failed to parse cash amount.")
                End If
            Else
                ' Handle the case where txtCCash is empty
                txtChange.Text = "0.00"
            End If
        Else
            ' Parsing failed for total price, handle the error as needed
            Debug.WriteLine("Failed to parse the float.")
        End If
    End Sub
    Public Sub clear()
        dtgSales.DataSource = Nothing
        dtgSales.Rows.Clear()
        txtCCash.Clear()
        txtChange.Clear()
        txtCRef.Clear()
        txtCustomer.Clear()
        txtSearchCode.Clear()
        txtTax.Clear()
        txtSTotal.Clear()
        lbltotalPrice.Text = "0"
        txtTqty.Clear()
        cboTax.SelectedIndex = -1
        txtSearchC.Clear()
        txtSearchC.Enabled = True
    End Sub
    Private Sub GenerateAndSetReferenceNumber()
        ' Generate a new reference number (you may have your own logic for this)
        Dim newReferenceNumber As String = GenerateNewReferenceNumber()
        clear()

        ' Check if the generated reference number already exists
        If Not IsReferenceNumberExists(newReferenceNumber) Then
            ' If it doesn't exist, set the reference number in txtCRef
            txtCRef.Text = newReferenceNumber
        Else
            ' Handle the case where the generated reference number already exists
            MessageBox.Show("Reference number already exists. Please generate a new one.")
        End If
    End Sub
    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        GenerateAndSetReferenceNumber()
        dt.Rows.Clear()
        dtgSales.DataSource = Nothing
        dtgSales.DataSource = dt
        txtSearchC.Enabled = True
    End Sub
    Public Function GenerateNewReferenceNumber() As String
        ' Generate a string with the current date in "yyyyMMdd" format
        Dim dateString As String = DateTime.Now.ToString("yyyyMMdd")

        ' Generate 5 random characters
        Dim random As New Random()
        Dim randomChars As String = ""
        For i As Integer = 1 To 5
            randomChars &= ChrW(random.Next(65, 91)) ' ASCII codes for uppercase letters (A-Z)
        Next

        ' Combine the date and random characters to form the reference number
        Return "REF" & dateString & randomChars
    End Function
    Public Function IsReferenceNumberExists(referenceNumber As String) As Boolean
        ' Your database connection string
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"

        ' SQL query to check if the reference number already exists
        Dim query As String = "SELECT COUNT(*) FROM `list_sales` WHERE `CustomerRef#` = @ReferenceNumber"

        ' Create connection and command objects
        Using con As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, con)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumber)

                Try
                    ' Open the connection
                    con.Open()

                    ' Execute the query and get the count
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' If count is greater than 0, the reference number exists
                    Return count > 0
                Catch ex As Exception
                    ' Handle any exceptions (e.g., display an error message)
                    MessageBox.Show("Error checking reference number: " & ex.Message)
                End Try
            End Using
        End Using

        ' Return false by default (an error occurred)
        Return False
    End Function


    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        ' Process payment
        ProcessPayment()
    End Sub
    Private Sub deleteCus()
        ' Assuming you have a connection object named "con" and it's open
        Using con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            con.Open()

            ' Construct the SQL query to delete based on cusref
            Dim deleteQuery As String = "DELETE FROM `transaction` WHERE `cusref` = @cusref"

            ' Assuming you have a command object named "cmd"
            Using cmd As New MySqlCommand(deleteQuery, con)
                ' Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@cusref", txtCRef.Text)

                ' Execute the delete query
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ProcessPayment()
        ' Validate if cash amount is entered
        If String.IsNullOrEmpty(txtCCash.Text) Then
            MessageBox.Show("Please enter the cash amount before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if there are items in the sales order
        If dt.Rows.Count > 0 Then
            ' Generate a new reference number
            Dim referenceNumber As String = txtCRef.Text

            ' Process each row in the DataGridView
            For Each row As DataGridViewRow In dtgSales.Rows
                ' Assuming column indices, replace with actual column indices
                Dim barcode As String = row.Cells("barcode").Value.ToString()
                Dim productStatus As String = GetProductStatus(barcode)

                ' Check if the product status is "Expired"
                If productStatus = "Expired" Then
                    MessageBox.Show($"Product with barcode {barcode} is expired. Cannot proceed with the payment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next

            ' Insert sales order information into the database
            If InsertSalesOrder(referenceNumber) Then
                ' Update stock quantities in the database
                If UpdateStockQuantities() Then
                    ' Create a PrintDocument object
                    Dim printDoc As New PrintDocument()

                    ' Set the PrintPage event handler
                    AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

                    ' Display the Print Preview Dialog or send it directly to the printer
                    Dim printPreviewDialog As New PrintPreviewDialog()
                    printPreviewDialog.Document = printDoc

                    ' Optionally, set the size of the Print Preview Dialog
                    printPreviewDialog.ClientSize = New Size(600, 800) ' Adjust the size as needed

                    ' Show the Print Preview Dialog
                    printPreviewDialog.ShowDialog()
                    deleteCus()
                    ' Clear the form
                    clear()
                Else
                    ' Display an error message if updating stock quantities fails
                    MessageBox.Show("Error updating stock quantities.", "MAXCORE: SALES ORDER MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ' Display an error message if inserting sales order information fails
                MessageBox.Show("Error processing payment.", "MAXCORE: SALES ORDER MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Display a message if there are no items in the sales order
            MessageBox.Show("No items in the sales order.", "MAXCORE: SALES ORDER MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function GetProductStatus(barcode As String) As String
        ' Your logic to retrieve the product status from the database
        ' You may need to adjust this based on your actual database schema
        Dim status As String = ""
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"
        ' Your database query to get the product status based on the barcode
        Dim query As String = "SELECT `status` FROM `inventory` WHERE `barcode` = @Barcode"

        ' Create connection and command objects
        Using con As New MySqlConnection(connectionString)
            con.Open() ' Open the connection

            Using cmd As New MySqlCommand(query, con)
                ' Add parameter to the command
                cmd.Parameters.AddWithValue("@Barcode", barcode)

                ' Execute the query
                status = Convert.ToString(cmd.ExecuteScalar())
            End Using
        End Using

        Return status
    End Function


    Private Function InsertSalesOrder(referenceNumber As String) As Boolean
        ' Your database connection string
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"

        ' SQL query to insert sales order information
        Dim query As String = "INSERT INTO `list_sales` (`CustomerName`, `CustomerRef#`, `CustomerProducts`,`ProductType`, `ProductVolume`, `QuantityItem`, `barcode`, `price`, `customerCash`, `customerChange`, `tax`, `subtotal`, `totalAmount`, `totalTax`, `TotalPerItem`, `TotalItems`, `Employee`, `TransactionDate`) 
    VALUES (@CustomerName, @ReferenceNumber, @CustomerProducts,@type, @ProductVolume, @QuantityItem, @Barcode, @Price, @CustomerCash, @CustomerChange, @Tax, @Subtotal, @TotalAmount, @TotalTax, @TotalPerItem, @TotalItems, @EmployeeName, @TransactionDate)"

        ' Create connection and command objects
        Using con As New MySqlConnection(connectionString)
            con.Open() ' Open the connection

            Using cmd As New MySqlCommand(query, con)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumber)
                cmd.Parameters.AddWithValue("@EmployeeName", Main.txtName.Text.Trim())
                cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToSingle(lbltotalPrice.Text))
                cmd.Parameters.AddWithValue("@Tax", taxRate)
                cmd.Parameters.AddWithValue("@Subtotal", Convert.ToSingle(txtSTotal.Text))
                cmd.Parameters.AddWithValue("@TransactionDate", Date.Now)
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomer.Text.Trim())
                cmd.Parameters.AddWithValue("@TotalItems", Convert.ToInt32(txtTqty.Text))
                cmd.Parameters.AddWithValue("@CustomerCash", Convert.ToSingle(txtCCash.Text))
                cmd.Parameters.AddWithValue("@CustomerChange", Convert.ToSingle(txtChange.Text))
                cmd.Parameters.AddWithValue("@TotalTax", Convert.ToDouble(txtTax.Text))

                ' Process each row in the DataGridView
                For Each row As DataGridViewRow In dtgSales.Rows
                    ' Assuming column indices, replace with actual column indices
                    Dim productName As String = row.Cells("Product Name").Value.ToString()
                    Dim productVolume As String = row.Cells("Volume").Value.ToString()
                    Dim pricePerItem As Decimal = Convert.ToDecimal(row.Cells("Price per Item").Value)
                    Dim totalPrice As Decimal = Convert.ToDecimal(row.Cells("Total Price").Value)
                    Dim barcode As String = row.Cells("barcode").Value.ToString()
                    Dim qtyItem As String = row.Cells("Qty").Value.ToString()
                    Dim type As String = row.Cells("Item Type").Value.ToString()
                    ' Add parameters for each product
                    cmd.Parameters.AddWithValue("@CustomerProducts", productName)
                    cmd.Parameters.AddWithValue("@ProductVolume", productVolume)
                    cmd.Parameters.AddWithValue("@QuantityItem", qtyItem) ' You may need to adjust this based on your data model
                    cmd.Parameters.AddWithValue("@Barcode", barcode) ' Replace with actual barcode data
                    cmd.Parameters.AddWithValue("@Price", pricePerItem)
                    cmd.Parameters.AddWithValue("@TotalPerItem", totalPrice)
                    cmd.Parameters.AddWithValue("@type", type)
                    ' Execute the query for each product
                    cmd.ExecuteNonQuery()

                    ' Reset the command parameters for the next iteration
                    cmd.Parameters.Clear()
                    ' Add parameters for the main query again
                    cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumber)
                    cmd.Parameters.AddWithValue("@EmployeeName", Main.txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToSingle(lbltotalPrice.Text))
                    cmd.Parameters.AddWithValue("@Tax", taxRate)
                    cmd.Parameters.AddWithValue("@Subtotal", Convert.ToSingle(txtSTotal.Text))
                    cmd.Parameters.AddWithValue("@TransactionDate", Date.Now)
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomer.Text.Trim())
                    cmd.Parameters.AddWithValue("@TotalItems", Convert.ToInt32(txtTqty.Text))
                    cmd.Parameters.AddWithValue("@CustomerCash", Convert.ToSingle(txtCCash.Text))
                    cmd.Parameters.AddWithValue("@CustomerChange", Convert.ToSingle(txtChange.Text))
                    cmd.Parameters.AddWithValue("@TotalTax", Convert.ToDouble(txtTax.Text))
                Next
            End Using
        End Using
        Return True
    End Function


    Private Function UpdateStockQuantities() As Boolean
        Try
            ' Your database connection string
            Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"

            ' SQL query to update stock quantities and set status based on barcode
            Dim updateQuery As String = "UPDATE `inventory` SET 
                                        `Stock` = `Stock` - @Quantity, 
                                        `status` = CASE 
                                                        WHEN (`Stock` - @Quantity) = 0 THEN 'Out-of-Stock' 
                                                        WHEN (`Stock` - @Quantity) < 25 THEN 'Low Stock' 
                                                        ELSE 'Available' 
                                                    END 
                                     WHERE `barcode` = @Barcode"
            ' Create connection and command objects
            Using con As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(updateQuery, con)
                    ' Open the connection
                    con.Open()

                    ' Iterate through each row in the DataTable
                    For Each row As DataRow In dt.Rows
                        ' Add parameters to the command
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Quantity", row("Qty"))
                        cmd.Parameters.AddWithValue("@Barcode", row("Barcode"))

                        ' Execute the update query
                        cmd.ExecuteNonQuery()
                    Next

                    Return True
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions (e.g., log the error)
            MessageBox.Show("Error updating stock quantities: " & ex.Message)
            Return False
        End Try
    End Function
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Set fonts and brushes
        Dim titleFont As New Font("Arial", 24, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 16, FontStyle.Bold)
        Dim boldFont As New Font("Arial", 14, FontStyle.Bold)
        Dim regularFont As New Font("Arial", 14)
        Dim brush As New SolidBrush(Color.Black)
        Dim verticalSpaceBetweenSections As Integer = 20

        ' Enable anti-aliasing for smoother text rendering
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        ' Draw a title with an image from resources
        Dim titleImage As Bitmap = My.Resources.MAXCORE_removebg_preview
        e.Graphics.DrawImage(titleImage, New Rectangle(100, 20, 80, 80))
        e.Graphics.DrawString("MAXCORE : POS Receipt", titleFont, brush, 200, 40)

        ' Draw a broken line under the title
        Dim brokenLineTitle As String = New String("-"c, 100)
        e.Graphics.DrawString(brokenLineTitle, regularFont, brush, 100, 110)

        ' Draw cashier information in bold
        Dim cashierInfo As String = $"CASHIER: {Main.txtName.Text}"
        Dim roleInfo As String = $"ROLE: {Main.txtRole.Text}"

        e.Graphics.DrawString(cashierInfo, boldFont, brush, 100, 130)
        e.Graphics.DrawString(roleInfo, regularFont, brush, 100, 160)

        ' Draw date and time
        Dim dateTimeInfo As String = $"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}"
        e.Graphics.DrawString(dateTimeInfo, regularFont, brush, 100, 200)

        ' Draw a broken line under the date
        Dim brokenLineDate As String = New String("-"c, 100)
        e.Graphics.DrawString(brokenLineDate, regularFont, brush, 100, 230)

        ' Draw "Customer Name" and txtCustomer.text
        e.Graphics.DrawString("Customer Name: ", boldFont, brush, 100, 240 + verticalSpaceBetweenSections)
        e.Graphics.DrawString(txtCustomer.Text, regularFont, brush, 300, 240 + verticalSpaceBetweenSections)

        ' Draw "Reference#: " and txtCRef.text
        ' Draw "Reference#: " and txtCRef.text with added space
        e.Graphics.DrawString("Reference#: ", boldFont, brush, 100, 260 + verticalSpaceBetweenSections)
        e.Graphics.DrawString(txtCRef.Text, regularFont, brush, 300, 260 + verticalSpaceBetweenSections)

        ' Draw a broken line
        Dim brokenLineAfterReference As String = New String("-"c, 100)
        e.Graphics.DrawString(brokenLineAfterReference, regularFont, brush, 100, 310)

        ' Draw column headers
        Dim columnHeaders As String = "Item#    Qty    Product Name                                       Price"
        e.Graphics.DrawString(columnHeaders, boldFont, brush, 100, 330)

        ' Add more space after drawing headers
        Dim startY As Integer = 350

        ' Draw items from dtgSales
        Dim itemHeight As Integer = 30

        For Each row As DataGridViewRow In dtgSales.Rows
            Dim itemNumber As String = row.Cells("Item#").Value.ToString()
            Dim quantity As String = row.Cells("Qty").Value.ToString()
            Dim brandName As String = row.Cells("Product Name").Value.ToString()
            Dim vol As String = row.Cells("Volume").Value.ToString()


            ' Concatenate brandName and genericName into a single string

            Dim price As String = row.Cells("Price per Item").Value.ToString()

            Dim itemInfo As String = $"{itemNumber,-10} {quantity,-10} {brandName,-32} {vol,-10}{price,-19}"
            e.Graphics.DrawString(itemInfo, regularFont, brush, 110, startY + 5)

            ' Calculate the height dynamically for each item
            Dim textHeight As Single = e.Graphics.MeasureString(itemInfo, regularFont).Height

            ' Draw the item with adjusted X and Y coordinates
            e.Graphics.DrawString(itemInfo, regularFont, brush, New RectangleF(110, startY + 5, 500, textHeight))

            startY += CInt(textHeight) + 5 ' Adjust spacing as needed
        Next

        ' Draw a broken line after items
        Dim brokenLineItems As String = New String("-"c, 100)
        e.Graphics.DrawString(brokenLineItems, regularFont, brush, 100, startY)

        ' TRANSACTION PART
        startY += 20 ' Add space after items for TRANSACTION PART

        e.Graphics.DrawString($"Number of items:{New String(" "c, 20)}{txtTqty.Text}", boldFont, brush, 100, startY)
        startY += 20

        e.Graphics.DrawString($"Subtotal: {New String(" "c, 30)}₱{txtSTotal.Text}", boldFont, brush, 100, startY)
        startY += 20

        e.Graphics.DrawString($"TAX:{cboTax.SelectedItem} {New String(" "c, 10)}₱{txtTax.Text}", boldFont, brush, 100, startY)
        startY += 20

        e.Graphics.DrawString($"Transaction Amount: {New String(" "c, 8)}₱{txtCCash.Text}", boldFont, brush, 100, startY)
        startY += 20

        e.Graphics.DrawString($"Change: {New String(" "c, 28)}₱{txtChange.Text}", boldFont, brush, 100, startY)
        startY += 20

        ' Draw total price in bold
        Dim totalPriceInfo As String = $"Total: {New String(" "c, 35)}₱{lbltotalPrice.Text}"

        ' Calculate the height dynamically for the total price
        Dim totalPriceHeight As Single = e.Graphics.MeasureString(totalPriceInfo, boldFont).Height

        ' Draw total price with adjusted spacing
        e.Graphics.DrawString(totalPriceInfo, boldFont, brush, 100, startY)

        startY += CInt(totalPriceHeight) + 10 ' Adjust spacing as needed

        ' Draw a broken line after total price
        Dim brokenLineTotal As String = New String("-"c, 100)
        e.Graphics.DrawString(brokenLineTotal, regularFont, brush, 100, startY + 5)

        ' Add a thank you message
        Dim text As String = "Thank you for shopping with us!"

        ' Measure the width of the text
        Dim textWidth As Single = e.Graphics.MeasureString(text, boldFont).Width

        ' Calculate the x-coordinate for centering
        Dim centerX As Integer = CInt((e.PageBounds.Width - textWidth) / 2)

        ' Draw the text at the center horizontally
        e.Graphics.DrawString(text, boldFont, brush, centerX, startY + 25)
    End Sub


End Class

