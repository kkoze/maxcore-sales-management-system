Imports Guna.UI2.WinForms
Imports System.Management
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Controls
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports Mysqlx.XDevAPI.Relational
Imports System.Runtime.CompilerServices
Public Class InvMng
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Dim dt As New DataTable
    Private Sub btnSIn_Click(sender As Object, e As EventArgs) Handles btnSIn.Click
        panel.Location = New Point(11, 50)
        Panel1.Location = New Point(1186, 60)
        Panel2.Location = New Point(1186, 60)
    End Sub
    Private Sub InvMng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcomboboxRef()
        LoadCustomerRef()
    End Sub
    Public Sub loadcomboboxRef()
        cboRef.Items.Clear()
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                connection.Open()
                Dim query As String = "SELECT `Reference#` FROM inventory"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Dim ref As String = reader.GetString(0)

                                If Not String.IsNullOrWhiteSpace(ref) Then
                                    cboRef.Items.Add(ref)
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
    Private Sub btnUdate_Click(sender As Object, e As EventArgs) Handles btnUdate.Click
        BBD.Show()
        BBD.lblName.Text = "Delivery"
        BBD.lblName.Location = New Point(-83, 148)
        BBD.btnConfirm2.Visible = True
        BBD.btnConfirm.Visible = False
        BBD.Guna2TimePicker.Visible = True

        BBD.Guna2DateTimePicker1.MinDate = DateTimePicker.MinimumDateTime

        Dim initialDateTime As DateTime = DateTime.Today.AddHours(14).AddMinutes(30)
        BBD.Guna2DateTimePicker1.Value = initialDateTime
    End Sub
    Private Sub btnUEx_Click(sender As Object, e As EventArgs)
        BBD.Show()
        BBD.lblName.Text = "Best-Before"
        BBD.lblName.Location = New Point(-27, 148)

        BBD.btnConfirm2.Visible = False
        BBD.btnConfirm.Visible = True
        BBD.Guna2TimePicker.Visible = False

        ' Set MinDate to today's date for btnDate
        BBD.Guna2DateTimePicker1.MinDate = DateTime.Today
    End Sub
    Private Sub btnSr_Click(sender As Object, e As EventArgs) Handles btnSr.Click
        Panel1.Location = New Point(1186, 60)
        panel.Location = New Point(1186, 60)
        Panel2.Location = New Point(11, 50)
    End Sub
    Private Sub btnSH_Click(sender As Object, e As EventArgs) Handles btnSH.Click
        Panel1.Location = New Point(11, 50)
        panel.Location = New Point(1186, 60)
        Panel2.Location = New Point(1186, 60)
        DataGridView2.ClearSelection()
        Dim cmd As New MySqlCommand("SELECT * FROM `inventory`", con)
        Dim msadap As New MySqlDataAdapter(cmd)
        dt.Clear()
        msadap.Fill(dt)

        DataGridView2.DataSource = dt

        DataGridView2.Columns("id").Visible = False
        DataGridView2.Columns("Description").Visible = False
        DataGridView2.Columns("Dosage").Visible = False
        DataGridView2.Columns("StorageCondition").Visible = False
        DataGridView2.Columns("RegulatoryInformation").Visible = False
        DataGridView2.Columns("totalcost").Visible = False
        DataGridView2.Columns("CostPerUnit").Visible = False
        DataGridView2.Columns("ItemImg").Visible = False
        DataGridView2.Columns("status").Visible = False
        DataGridView2.Columns("ExpiryDate").Visible = False

        ' Reorder columns - move "reference#" to the first position
        Dim referenceColumn As DataGridViewColumn = DataGridView2.Columns("reference#")
        ' Move "reference#" column to the first position
        referenceColumn.DisplayIndex = 0

        If dt.Rows.Count > 0 Then
            DataGridView2.ClearSelection()
        End If
    End Sub
    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        FilterDataByDateRange()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        FilterDataByDateRange()
    End Sub

    Private Sub FilterDataByDateRange()
        ' Get the selected date range
        Dim fromDate As String = dtpFrom.Value.ToString("yyyy-MM-dd")
        Dim toDate As String = dtpTo.Value.ToString("yyyy-MM-dd")

        ' Construct the SQL query with the date range filter
        Dim query As String = $"SELECT * FROM `inventory` WHERE `datedelivered` BETWEEN '{fromDate}' AND '{toDate}'"

        ' Execute the query and update the DataGridView
        Dim cmd As New MySqlCommand(query, con)
        Dim msadap As New MySqlDataAdapter(cmd)
        dt.Clear()
        msadap.Fill(dt)
        DataGridView2.DataSource = dt


        ' Set the visibility of specific columns
        DataGridView2.Columns("id").Visible = False
        DataGridView2.Columns("Description").Visible = False
        DataGridView2.Columns("Dosage").Visible = False
        DataGridView2.Columns("StorageCondition").Visible = False
        DataGridView2.Columns("RegulatoryInformation").Visible = False
        DataGridView2.Columns("totalcost").Visible = False
        DataGridView2.Columns("CostPerUnit").Visible = False
        DataGridView2.Columns("ItemImg").Visible = False
        DataGridView2.Columns("ExpiryDate").Visible = False
        DataGridView2.Columns("DateUpdated").Visible = False

        ' Reorder columns - move "reference#" to the first position
        Dim referenceColumn As DataGridViewColumn = DataGridView2.Columns("reference#")
        ' Move "reference#" column to the first position
        referenceColumn.DisplayIndex = 0

        If dt.Rows.Count > 0 Then
            DataGridView2.ClearSelection()
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ' Show the print preview dialog
        Dim printPreviewDialog As New PrintPreviewDialog()
        Dim printDocument As New Printing.PrintDocument()

        ' Set the PrintPage event handler for the print document
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Set the paper size to custom landscape size
        Dim customSize As New PaperSize("Custom Landscape", 1600, 900) ' Width and Height in hundredths of an inch
        printDocument.DefaultPageSettings.PaperSize = customSize
        printDocument.PrinterSettings.DefaultPageSettings.PaperSize = customSize

        ' Set the print document as the document to be previewed
        printPreviewDialog.Document = printDocument

        ' Show the print preview dialog
        printPreviewDialog.ShowDialog()
    End Sub


    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Your code to draw the content of the report on the print page
        ' You can use the Graphics object (e.Graphics) to draw text, images, etc.
        e.PageSettings.Landscape = True

        e.Graphics.DrawString("Inventory Report", New Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 100)

        ' Draw the subtitle
        e.Graphics.DrawString("MAXCORE SALES MANAGEMENT SYSTEM", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 100, 140)

        ' Draw the current date and time
        Dim currentDateAndTime As String = $"Date : {Main.txtDate.Text} Time : {Main.txtTime.Text}"
        e.Graphics.DrawString(currentDateAndTime, New Font("Arial", 12), Brushes.Black, 100, 170)

        ' Draw a line below the time and date
        e.Graphics.DrawLine(Pens.Black, 100, 200, 1000, 200)

        ' Draw the user information
        Dim userInfo As String = $"User: {Main.txtName.Text}   Role: {Main.txtRole.Text}"
        e.Graphics.DrawString(userInfo, New Font("Arial", 12), Brushes.Black, 100, 210)

        ' Draw a line below the user information
        e.Graphics.DrawLine(Pens.Black, 100, 240, 1000, 240)

        ' Example: Draw data from DataGridView
        Dim startX As Integer = 80
        Dim startY As Integer = 260
        If DataGridView2 IsNot Nothing AndAlso DataGridView2.Rows.Count > 0 AndAlso DataGridView2.Columns.Count > 0 Then
            Dim columnOrder() As String = {"Reference#", "Supplier", "Barcode", "Brand Name", "Generic Name", "Manufacturer", "stock", "batch#", "dateDelivered", "dateUpdated"}
            Dim columnWidths() As Integer = {150, 150, 150, 150, 150, 150, 150, 150, 150, 150}
            For i As Integer = 0 To columnOrder.Length - 1
                Dim columnIndex As Integer = -1
                For j As Integer = 0 To DataGridView2.Columns.Count - 1
                    If DataGridView2.Columns(j).HeaderText.Equals(columnOrder(i), StringComparison.OrdinalIgnoreCase) Then
                        columnIndex = j
                        Exit For
                    End If
                Next
                If columnIndex <> -1 Then
                    Dim headerWidth As Integer = columnWidths(i)
                    e.Graphics.FillRectangle(Brushes.LightGray, startX, startY, headerWidth, 30)
                    e.Graphics.DrawRectangle(Pens.Black, startX, startY, headerWidth, 30)
                    e.Graphics.DrawString(DataGridView2.Columns(columnIndex).HeaderText, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, startX + 2, startY + 2)
                    startX += headerWidth
                End If
            Next
            startY += 30
            For i As Integer = 0 To DataGridView2.RowCount - 1
                startX = 80 ' Reset X position for each row
                For j As Integer = 0 To columnOrder.Length - 1
                    Dim columnIndex As Integer = -1
                    For k As Integer = 0 To DataGridView2.Columns.Count - 1
                        If DataGridView2.Columns(k).HeaderText.Equals(columnOrder(j), StringComparison.OrdinalIgnoreCase) Then
                            columnIndex = k
                            Exit For
                        End If
                    Next
                    If columnIndex <> -1 Then
                        Dim cellWidth As Integer = columnWidths(j)
                        e.Graphics.FillRectangle(Brushes.White, startX, startY, cellWidth, 25)
                        e.Graphics.DrawRectangle(Pens.Black, startX, startY, cellWidth, 25)

                        If DataGridView2(columnIndex, i).Value IsNot Nothing Then
                            e.Graphics.DrawString(DataGridView2(columnIndex, i).Value.ToString(), New Font("Arial", 10), Brushes.Black, startX + 2, startY + 2)
                        End If
                        startX += cellWidth
                    End If
                Next
                startY += 25
            Next
        Else
            e.Graphics.DrawString("No reports available for this date", New Font("Arial", 12), Brushes.Black, startX, startY)
        End If
    End Sub
    Private Sub cboRef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRef.SelectedIndexChanged
        Dim selectedReference As String = cboRef.SelectedItem?.ToString()
        If String.IsNullOrEmpty(selectedReference) Then
            MessageBox.Show("Please select a reference.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim query As String = "SELECT * FROM inventory WHERE `Reference#` = @Reference"
        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Reference", selectedReference)
            Dim dt As New DataTable()
            Try
                Using msadap As New MySqlDataAdapter(cmd)
                    msadap.Fill(dt)
                End Using

                If dt.Rows.Count > 0 Then
                    DataGridView2.DataSource = dt
                    DataGridView2.Columns("id").Visible = False
                    DataGridView2.Columns("Description").Visible = False
                    DataGridView2.Columns("Dosage").Visible = False
                    DataGridView2.Columns("StorageCondition").Visible = False
                    DataGridView2.Columns("RegulatoryInformation").Visible = False
                    DataGridView2.Columns("totalcost").Visible = False
                    DataGridView2.Columns("CostPerUnit").Visible = False
                    DataGridView2.Columns("ItemImg").Visible = False
                    DataGridView2.Columns("ExpiryDate").Visible = False
                    DataGridView2.Columns("DateUpdated").Visible = False
                    If DataGridView2.Columns.Contains("Reference#") Then
                        DataGridView2.Columns("Reference#").DisplayIndex = 0
                    End If

                    DataGridView2.ClearSelection()
                Else
                    MessageBox.Show("No data found for the selected reference.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub cboStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStock.SelectedIndexChanged
        dtg1.DataSource = Nothing
        Dim selectedIndex As Integer = cboStock.SelectedIndex
        Dim status As String = ""
        Select Case selectedIndex
            Case 0
                status = "Expired"
            Case 1
                status = "Low Stock"
            Case 2
                status = "Out-of-Stock"
            Case 3 ' Case for "All"

                LoadAllInventoryData()
                Return
            Case Else

                Return
        End Select
        Dim query As String = "SELECT * FROM inventory WHERE Status = @Status"

        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Status", status)
                    Using msadap As New MySqlDataAdapter(command)
                        Dim dt As New DataTable()
                        msadap.Fill(dt)
                        dtg1.DataSource = dt
                        dtg1.Columns("id").Visible = False
                        dtg1.Columns("ItemType").Visible = False
                        dtg1.Columns("Description").Visible = False
                        dtg1.Columns("Dosage").Visible = False
                        dtg1.Columns("ItemImg").Visible = False
                        dtg1.Columns("MerchType").Visible = False
                        dtg1.Columns("Medicine Type").Visible = False
                        dtg1.Columns("Medicine Category").Visible = False
                        dtg1.Columns("Manufacturer").Visible = False
                        dtg1.Columns("SupplierID").Visible = False
                        dtg1.Columns("Supplier").Visible = False
                        dtg1.Columns("SupplierAddress").Visible = False
                        dtg1.Columns("SupplierContact").Visible = False
                        dtg1.Columns("CostPerUnit").Visible = False
                        dtg1.Columns("StorageCondition").Visible = False
                        dtg1.Columns("RegulatoryInformation").Visible = False
                        dtg1.Columns("Status").Visible = False
                        dtg1.Columns("DateDelivered").Visible = False
                        dtg1.Columns("DateUpdated").Visible = False
                        dtg1.Columns("batch#").Visible = False
                        dtg1.Columns("Reference#").Visible = False
                        dtg1.Columns("Description").Visible = False
                        dtg1.Columns("TotalCost").Visible = False
                        dtg1.Columns("ExpiryDate").Visible = False
                        dtg1.ClearSelection()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllInventoryData()
        Dim query As String = "SELECT * FROM inventory"
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    Using msadap As New MySqlDataAdapter(command)
                        Dim dt As New DataTable()
                        msadap.Fill(dt)
                        dtg1.DataSource = dt
                        dtg1.Columns("id").Visible = False
                        dtg1.Columns("ItemType").Visible = False
                        dtg1.Columns("Description").Visible = False
                        dtg1.Columns("Dosage").Visible = False
                        dtg1.Columns("ItemImg").Visible = False
                        dtg1.Columns("MerchType").Visible = False
                        dtg1.Columns("Medicine Type").Visible = False
                        dtg1.Columns("Medicine Category").Visible = False
                        dtg1.Columns("Manufacturer").Visible = False
                        dtg1.Columns("SupplierID").Visible = False
                        dtg1.Columns("Supplier").Visible = False
                        dtg1.Columns("SupplierAddress").Visible = False
                        dtg1.Columns("SupplierContact").Visible = False
                        dtg1.Columns("CostPerUnit").Visible = False
                        dtg1.Columns("StorageCondition").Visible = False
                        dtg1.Columns("RegulatoryInformation").Visible = False
                        dtg1.Columns("Status").Visible = False
                        dtg1.Columns("DateDelivered").Visible = False
                        dtg1.Columns("DateUpdated").Visible = False
                        dtg1.Columns("batch#").Visible = False
                        dtg1.Columns("Reference#").Visible = False
                        dtg1.Columns("Description").Visible = False
                        dtg1.Columns("TotalCost").Visible = False
                        dtg1.ClearSelection()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dtg1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg1.CellClick
        ' Check if a valid cell is clicked
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the barcode value from the clicked cell
            Dim barcodeValue As String = dtg1.Rows(e.RowIndex).Cells("Barcode").Value.ToString()

            ' Display the corresponding row from inventory in dtg2 based on barcode
            If Not BarcodeExistsInDtG2(barcodeValue) Then
                DisplayInventoryRowInDtG2(barcodeValue)
            Else
                MessageBox.Show("Barcode " & barcodeValue & " is already clicked in dtg2.", "Already Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub DisplayInventoryRowInDtG2(barcodeValue As String)
        ' Check if the barcode is already in dtg2
        If BarcodeExistsInDtG2(barcodeValue) Then
            MessageBox.Show("Barcode " & barcodeValue & " is already clicked in dtg2.", "Already Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim query As String = "SELECT * FROM inventory WHERE barcode = @Barcode"
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Barcode", barcodeValue)
                    Using msadap As New MySqlDataAdapter(command)
                        Dim newDataTable As New DataTable()
                        msadap.Fill(newDataTable)
                        Dim existingDataTable As DataTable
                        If dtg2.DataSource IsNot Nothing AndAlso TypeOf dtg2.DataSource Is DataTable Then
                            existingDataTable = DirectCast(dtg2.DataSource, DataTable)
                        Else
                            existingDataTable = New DataTable()
                            Dim cancelButtonColumn As New DataGridViewButtonColumn()
                            cancelButtonColumn.HeaderText = "Cancel"
                            cancelButtonColumn.Name = "btnCancel"
                            cancelButtonColumn.Text = "Cancel"
                            cancelButtonColumn.UseColumnTextForButtonValue = True
                            cancelButtonColumn.DefaultCellStyle.ForeColor = Color.Red
                            cancelButtonColumn.DefaultCellStyle.BackColor = Color.White
                            dtg2.Columns.Add(cancelButtonColumn)
                        End If
                        existingDataTable.Merge(newDataTable, False, MissingSchemaAction.Add)
                        dtg2.DataSource = existingDataTable
                        dtg2.Columns("id").Visible = False
                        dtg2.Columns("Description").Visible = False
                        dtg2.Columns("Dosage").Visible = False
                        dtg2.Columns("ItemImg").Visible = False
                        dtg2.Columns("MerchType").Visible = False
                        dtg2.Columns("Medicine Type").Visible = False
                        dtg2.Columns("Medicine Category").Visible = False
                        dtg2.Columns("Manufacturer").Visible = False
                        dtg2.Columns("StorageCondition").Visible = False
                        dtg2.Columns("RegulatoryInformation").Visible = False
                        dtg2.Columns("Status").Visible = False
                        dtg2.Columns("DateDelivered").Visible = False
                        dtg2.Columns("DateUpdated").Visible = False
                        dtg2.Columns("batch#").Visible = False
                        dtg2.Columns("Reference#").Visible = False
                        dtg2.Columns("Description").Visible = False
                        dtg2.ClearSelection()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dtg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg2.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dtg2.Columns(e.ColumnIndex).Name = "btnCancel" Then
                Dim barcodeValue As String = dtg2.Rows(e.RowIndex).Cells("Barcode").Value.ToString()
                dtg2.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
    Private Function BarcodeExistsInDtG2(barcodeValue As String) As Boolean
        ' Check if the barcode is present in dtg2
        For Each row As DataGridViewRow In dtg2.Rows
            If row.Cells("Barcode").Value IsNot Nothing AndAlso row.Cells("Barcode").Value.ToString() = barcodeValue Then
                Return True
            End If
        Next
        Return False
    End Function
    Private originalStockValue As Integer
    Private editableColumns As List(Of String) = New List(Of String) From {"Stock", "ExpiryDate", "SupplierID", "Supplier", "SupplierAddress", "SupplierContact"}

    Private Sub dtg2_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtg2.CellBeginEdit
        If e.RowIndex >= 0 AndAlso Not editableColumns.Contains(dtg2.Columns(e.ColumnIndex).Name) Then
            e.Cancel = True
        End If
        If e.ColumnIndex = dtg2.Columns("Stock").Index AndAlso e.RowIndex >= 0 Then
            originalStockValue = Convert.ToInt32(dtg2.Rows(e.RowIndex).Cells("Stock").Value)
        End If
    End Sub
    Private Sub dtg2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtg2.CellEndEdit
        ' Check if the edited cell is in an allowed column
        If e.RowIndex >= 0 AndAlso Not editableColumns.Contains(dtg2.Columns(e.ColumnIndex).Name) Then
            Exit Sub ' Exit if not an allowed column
        End If
        If e.ColumnIndex = dtg2.Columns("Stock").Index AndAlso e.RowIndex >= 0 Then
            Dim stock As Integer = Convert.ToInt32(dtg2.Rows(e.RowIndex).Cells("Stock").Value)
            Dim costPerUnit As Decimal = Convert.ToDecimal(dtg2.Rows(e.RowIndex).Cells("CostPerUnit").Value)

            If stock < 30 Then
                MessageBox.Show("Enter Minimum Value. Reverting to the original value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtg2.Rows(e.RowIndex).Cells("Stock").Value = originalStockValue

                Dim totalCost As Decimal = originalStockValue * costPerUnit
                dtg2.Rows(e.RowIndex).Cells("totalcost").Value = totalCost
            Else

                Dim totalCost As Decimal = stock * costPerUnit

                dtg2.Rows(e.RowIndex).Cells("totalcost").Value = totalCost
            End If
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validate if txtRef.text is empty or different from txtUDeliver.text
            If String.IsNullOrEmpty(txtRef.Text) OrElse txtRef.Text <> txtUDeliver.Text Then
                MessageBox.Show("Please enter a valid reference number that matches the delivery date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                For Each row As DataGridViewRow In dtg2.Rows
                    If row.Cells("Stock").Value IsNot Nothing AndAlso row.Cells("ExpiryDate").Value IsNot Nothing AndAlso row.Cells("totalcost").Value IsNot Nothing AndAlso row.Cells("Barcode").Value IsNot Nothing Then
                        Dim stock As Integer = Convert.ToInt32(row.Cells("Stock").Value)
                        Dim expiryDate As DateTime = Convert.ToDateTime(row.Cells("ExpiryDate").Value)
                        Dim totalCost As Decimal = Convert.ToDecimal(row.Cells("totalcost").Value)
                        Dim barcodeValue As String = row.Cells("Barcode").Value.ToString()
                        Dim SupplierID As String = row.Cells("SupplierID").Value.ToString()
                        Dim Supplier As String = row.Cells("Supplier").Value.ToString()
                        Dim SupplierAddress As String = row.Cells("SupplierAddress").Value.ToString()
                        Dim SupplierContact As String = row.Cells("SupplierContact").Value.ToString()


                        ' Use values from textboxes for Reference# and DateDelivered
                        Dim referenceNumber As String = txtRef.Text
                        Dim dateDelivered As DateTime = Convert.ToDateTime(txtUDeliver.Text)
                        Dim dateUpdated As DateTime = DateTime.Now ' Current date and time

                        ' Update the specified columns in your database
                        Dim updateQuery As String = "UPDATE inventory SET Stock = @Stock, DateDelivered = @DateDelivered, ExpiryDate = @ExpiryDate, totalcost = @TotalCost, SupplierID = @SupplierID, Supplier = @Supplier, SupplierAddress = @SuppAdd, SupplierContact = @SuppContact, `Reference#` = @ReferenceNumber, DateUpdated = @DateUpdated WHERE barcode = @Barcode"

                        Using updateCommand As New MySqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@Stock", stock)
                            updateCommand.Parameters.AddWithValue("@DateDelivered", dateDelivered)
                            updateCommand.Parameters.AddWithValue("@ExpiryDate", expiryDate)
                            updateCommand.Parameters.AddWithValue("@TotalCost", totalCost)
                            updateCommand.Parameters.AddWithValue("@ReferenceNumber", referenceNumber)
                            updateCommand.Parameters.AddWithValue("@DateUpdated", dateUpdated)
                            updateCommand.Parameters.AddWithValue("@Barcode", barcodeValue)
                            updateCommand.Parameters.AddWithValue("@SupplierID", SupplierID)
                            updateCommand.Parameters.AddWithValue("@Supplier", Supplier)
                            updateCommand.Parameters.AddWithValue("@SuppAdd", SupplierAddress)
                            updateCommand.Parameters.AddWithValue("@SuppContact", SupplierContact)

                            ' Execute the update query
                            updateCommand.ExecuteNonQuery()
                        End Using
                    End If
                Next

                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Clear dtg1
                dtg1.DataSource = Nothing
                dtg1.Rows.Clear()

                ' Clear dtg2
                dtg2.DataSource = Nothing
                dtg2.Rows.Clear()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadCustomerRef()
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()

                Dim query As String = "SELECT DISTINCT `CustomerRef#` FROM list_sales"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim customerRef As String = reader("CustomerRef#").ToString()

                            ' Check if the item is already in the ComboBox before adding
                            If Not cboCN.Items.Contains(customerRef) Then
                                cboCN.Items.Add(customerRef)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database interaction.
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboCN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCN.SelectedIndexChanged
        Try
            dtg3.DataSource = Nothing
            Dim selectedCustomerRef As String = cboCN.SelectedItem.ToString()
            Dim filterQuery As String = $"SELECT * FROM list_sales WHERE `CustomerRef#` = '{selectedCustomerRef}'"
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Using command As New MySqlCommand(filterQuery, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dtg3.DataSource = dt
                        dtg3.Columns("id").Visible = False
                        dtg3.ClearSelection()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim originalquantityvalue As Integer
    Private Sub dtg3_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtg3.CellBeginEdit
        If e.ColumnIndex = dtg3.Columns("QuantityItem").Index AndAlso e.RowIndex >= 0 Then
            originalquantityvalue = Convert.ToInt32(dtg3.Rows(e.RowIndex).Cells("QuantityItem").Value)
        End If
    End Sub
    Private totalQuantity As Decimal = 0
    Private Sub dtg3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtg3.CellEndEdit
        If e.ColumnIndex = dtg3.Columns("QuantityItem").Index AndAlso e.RowIndex >= 0 Then
            Dim quantity As Integer = Convert.ToInt32(dtg3.Rows(e.RowIndex).Cells("QuantityItem").Value)
            Dim price As Decimal = Convert.ToDecimal(dtg3.Rows(e.RowIndex).Cells("price").Value)
            Dim totalPerItem As Decimal = quantity * price
            dtg3.Rows(e.RowIndex).Cells("TotalPerItem").Value = totalPerItem
            ' Initialize totalQuantity to 0 before recalculating
            Dim totalQuantity As Decimal = 0
            ' Iterate through all rows and sum the quantities
            For Each row As DataGridViewRow In dtg3.Rows
                If Not row.IsNewRow Then ' Skip the new row if present
                    Dim rowQuantity As Integer = Convert.ToInt32(row.Cells("QuantityItem").Value)
                    totalQuantity += rowQuantity
                End If
            Next
            ' Update the "TotalItems" column for each row based on the total quantity
            For Each row As DataGridViewRow In dtg3.Rows
                If Not row.IsNewRow Then
                    row.Cells("TotalItems").Value = totalQuantity
                End If
            Next
            ' Calculate and update the "Subtotal" column based on the sum of TotalPerItem values
            Dim subtotal As Decimal = 0
            For Each row As DataGridViewRow In dtg3.Rows
                If Not row.IsNewRow Then
                    Dim rowTotalPerItem As Decimal = Convert.ToDecimal(row.Cells("TotalPerItem").Value)
                    subtotal += rowTotalPerItem
                End If
            Next
            For Each row As DataGridViewRow In dtg3.Rows
                If Not row.IsNewRow Then
                    row.Cells("Subtotal").Value = subtotal
                End If
            Next
            For Each row As DataGridViewRow In dtg3.Rows
                If Not row.IsNewRow Then
                    row.Cells("TotalTax").Value = subtotal * Convert.ToDecimal(row.Cells("tax").Value)
                End If
            Next
            For Each row As DataGridViewRow In dtg3.Rows
                If Not row.IsNewRow Then
                    row.Cells("TotalAmount").Value = subtotal + Convert.ToDecimal(row.Cells("TotalTax").Value)
                End If
            Next
            For Each row As DataGridViewRow In dtg3.Rows
                If Not row.IsNewRow Then
                    ' Access the Value property of each cell before conversion
                    Dim customerCashValue As Object = row.Cells("customerCash").Value
                    Dim totalAmountValue As Object = row.Cells("totalAmount").Value
                    ' Check if the values are not DBNull or null before conversion
                    If customerCashValue IsNot DBNull.Value AndAlso totalAmountValue IsNot DBNull.Value Then
                        ' Convert.ToDecimal expects an Object parameter
                        Dim customerChange As Decimal = Convert.ToDecimal(customerCashValue) - Convert.ToDecimal(totalAmountValue)
                        ' Check if the result is negative and set it to zero
                        If customerChange < 0 Then
                            customerChange = 0
                        End If
                        row.Cells("customerChange").Value = customerChange
                    Else
                        ' Handle DBNull or null values accordingly
                        ' You may want to set a default value or handle it in a different way
                        row.Cells("customerChange").Value = 0
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub btnNewTrans_Click(sender As Object, e As EventArgs) Handles btnNewTrans.Click
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()
            Dim updateQuery As String = "UPDATE `list_sales` SET `QuantityItem`=@QuantityItem, `barcode`=@Barcode, " &
                                 "`customerChange`=@CustomerChange,`subtotal`=@Subtotal, " &
                                 "`totalAmount`=@TotalAmount, `totalTax`=@TotalTax, `TotalPerItem`=@TotalPerItem, `TotalItems`=@TotalItems, " &
                                 "`TransactionDate`=@TransactionDate WHERE `CustomerRef#`=@CustomerRef"
            For Each row As DataGridViewRow In dtg3.Rows
                Dim customerRef As String = row.Cells("CustomerRef#").Value.ToString()
                Dim qty As Integer = Convert.ToInt32(row.Cells("QuantityItem").Value)
                Dim change As Decimal = Convert.ToDecimal(row.Cells("customerChange").Value)
                Dim totaltax As Decimal = Convert.ToDecimal(row.Cells("totalTax").Value)
                Dim subtotal As Decimal = Convert.ToDecimal(row.Cells("subtotal").Value)
                Dim totalAmount As Decimal = Convert.ToDecimal(row.Cells("totalAmount").Value)
                Dim totalperItem As Decimal = Convert.ToDecimal(row.Cells("TotalPerItem").Value)
                Dim totalItems As Integer = Convert.ToInt32(row.Cells("TotalItems").Value)
                Dim oldQuantityItem As Integer = GetOldQuantityItemFromDatabase(customerRef)
                Console.WriteLine($"Old QuantityItem: {oldQuantityItem}, New QuantityItem: {qty}")
                If qty = 0 Then
                    DeleteFromListSales(customerRef, row.Cells("barcode").Value.ToString())
                    Continue For
                End If
                Using cmd As New MySqlCommand(updateQuery, connection)
                    cmd.Parameters.AddWithValue("@CustomerRef", customerRef)
                    cmd.Parameters.AddWithValue("@QuantityItem", qty)
                    cmd.Parameters.AddWithValue("@Barcode", row.Cells("barcode").Value.ToString())
                    cmd.Parameters.AddWithValue("@CustomerChange", change)
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal)
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.Parameters.AddWithValue("@TotalTax", totaltax)
                    cmd.Parameters.AddWithValue("@TotalPerItem", totalperItem)
                    cmd.Parameters.AddWithValue("@TotalItems", totalItems)
                    cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show($"Update successful for CustomerRef#: {customerRef}")
                        LoadCustomerRef()

                        Dim quantityDifference As Integer = oldQuantityItem - qty
                        UpdateInventoryStock(row.Cells("barcode").Value.ToString(), oldQuantityItem, qty)
                    Else
                        MessageBox.Show($"Update failed for CustomerRef#: {customerRef}")
                    End If
                End Using
            Next
            PrintReceipt()
            ' Assuming dtg3.DataSource is set to a DataTable
            If TypeOf dtg3.DataSource Is DataTable Then
                DirectCast(dtg3.DataSource, DataTable).Rows.Clear()
            Else
                ' If not using a DataTable, you can try clearing the DataGridView rows directly
                dtg3.Rows.Clear()
            End If


        End Using
    End Sub

    Private Sub DeleteFromListSales(customerRef As String, barcode As String)
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()
            Dim deleteQuery As String = "DELETE FROM `list_sales` WHERE `CustomerRef#`=@CustomerRef"
            Using cmd As New MySqlCommand(deleteQuery, connection)
                cmd.Parameters.AddWithValue("@CustomerRef", customerRef)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show($"Delete successful for CustomerRef#: {customerRef}")
                    Dim originalQuantityItem As Integer = GetOldQuantityItemFromDatabase(customerRef)
                    UpdateInventoryStock(barcode, originalQuantityItem, 0) ' Corrected the order of parameters
                Else
                    MessageBox.Show($"Delete failed for CustomerRef#: {customerRef}")
                End If
            End Using
        End Using
    End Sub


    Private Function GetOldQuantityItemFromDatabase(customerRef As String) As Integer
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()
            Dim selectQuery As String = "SELECT `QuantityItem` FROM `list_sales` WHERE `CustomerRef#`=@CustomerRef"
            Using cmd As New MySqlCommand(selectQuery, connection)
                cmd.Parameters.AddWithValue("@CustomerRef", customerRef)
                Dim oldQuantityItem As Object = cmd.ExecuteScalar()
                If oldQuantityItem IsNot Nothing AndAlso oldQuantityItem IsNot DBNull.Value Then
                    Return Convert.ToInt32(oldQuantityItem)
                End If
            End Using
        End Using
        Return 0
    End Function

    Private Sub UpdateInventoryStock(barcode As String, originalQuantityItem As Integer, newQuantityItem As Integer)
        Try
            Dim quantityDifference As Integer = originalQuantityItem - newQuantityItem
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
                connection.Open()
                Dim selectStockQuery As String = "SELECT `Stock` FROM `inventory` WHERE `Barcode`=@Barcode"
                Using selectCmd As New MySqlCommand(selectStockQuery, connection)
                    selectCmd.Parameters.AddWithValue("@Barcode", barcode)
                    Dim currentStock As Object = selectCmd.ExecuteScalar()
                    Dim updateInventoryQuery As String = "UPDATE `inventory` SET `Stock`=`Stock` + @QuantityDifference WHERE `Barcode`=@Barcode"
                    Using cmd As New MySqlCommand(updateInventoryQuery, connection)
                        cmd.Parameters.AddWithValue("@QuantityDifference", quantityDifference)
                        cmd.Parameters.AddWithValue("@Barcode", barcode)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            Dim newStock As Integer = Convert.ToInt32(currentStock) + quantityDifference
                            MessageBox.Show($"Inventory Stock updated for Barcode: {barcode}. From {currentStock} to New Stock: {newStock}. ")
                        Else
                            MessageBox.Show($"Inventory Stock update failed for Barcode: {barcode}. Rows affected: {rowsAffected}")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating Inventory Stock: {ex.Message}")
        End Try
    End Sub
    Private Sub PrintReceipt()
        Dim printDoc As New PrintDocument()

        ' Set the PrintPage event handler
        AddHandler printDoc.PrintPage, AddressOf PrintReceipt_PrintPage

        ' Display the Print Preview Dialog or send it directly to the printer
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDoc

        ' Optionally, set the size of the Print Preview Dialog
        printPreviewDialog.ClientSize = New Size(600, 800) ' Adjust the size as needed

        ' Show the Print Preview Dialog
        printPreviewDialog.ShowDialog()
    End Sub
    Private Sub PrintReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
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
        ' Draw a title with an image from resources
        Dim titleImage As Bitmap = My.Resources.MAXCORE_removebg_preview
        e.Graphics.DrawImage(titleImage, New Rectangle(100, 20, 80, 80))
        e.Graphics.DrawString("MAXCORE : Return Receipt", titleFont, brush, 200, 40)

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
        Dim customerNameColumnIndex As Integer = dtg3.Columns("CustomerName").Index
        Dim customerName As String = If(dtg3.SelectedRows.Count > 0, dtg3.SelectedRows(0).Cells(customerNameColumnIndex).Value.ToString(), "")
        e.Graphics.DrawString("Customer Name: ", boldFont, brush, 100, 240 + verticalSpaceBetweenSections)
        e.Graphics.DrawString(customerName, regularFont, brush, 300, 240 + verticalSpaceBetweenSections)

        ' Draw "Reference#: " and txtCRef.text
        Dim customerRefColumnIndex As Integer = dtg3.Columns("CustomerRef#").Index
        Dim customerRef As String = If(dtg3.SelectedRows.Count > 0, dtg3.SelectedRows(0).Cells(customerRefColumnIndex).Value.ToString(), "")
        e.Graphics.DrawString("Reference#: ", boldFont, brush, 100, 260 + verticalSpaceBetweenSections)
        e.Graphics.DrawString(customerRef, regularFont, brush, 300, 260 + verticalSpaceBetweenSections)

        ' Draw a broken line
        Dim brokenLineAfterReference As String = New String("-"c, 100)
        e.Graphics.DrawString(brokenLineAfterReference, regularFont, brush, 100, 310)

        ' Draw column headers
        Dim columnHeaders As String = "Product Name                              Qty                                           Price"
        e.Graphics.DrawString(columnHeaders, boldFont, brush, 100, 330)

        ' Add more space after drawing headers
        Dim startY As Integer = 350

        ' Draw items from dtg3
        Dim itemHeight As Integer = 30

        For Each row As DataGridViewRow In dtg3.Rows
            Dim quantity As String = row.Cells("QuantityItem").Value.ToString()
            Dim brandName As String = row.Cells("CustomerProducts").Value.ToString()
            Dim vol As String = row.Cells("ProductVolume").Value.ToString()


            ' Concatenate brandName and genericName into a single string

            Dim price As String = row.Cells("price").Value.ToString()

            Dim itemInfo As String = $"{brandName,-10} {vol,-32} {quantity,-10}{price,-19}"
            e.Graphics.DrawString(itemInfo, regularFont, brush, 110, startY + 5)

            ' Calculate the height dynamically for each item
            Dim textHeight As Single = e.Graphics.MeasureString(itemInfo, regularFont).Height

            ' Draw the item with adjusted X and Y coordinates
            e.Graphics.DrawString(itemInfo, regularFont, brush, New RectangleF(110, startY + 5, 500, textHeight))

            startY += CInt(textHeight) + 5 ' Adjust spacing as needed

            ' Draw a broken line after items
            Dim brokenLineItems As String = New String("-"c, 100)
            e.Graphics.DrawString(brokenLineItems, regularFont, brush, 100, startY)

            ' TRANSACTION PART
            startY += 20 ' Add space after items for TRANSACTION PART
        Next
        Dim initialY As Integer = 500
        For Each row As DataGridViewRow In dtg3.Rows
            ' Extract information from the current row
            Dim txtTqty As String = row.Cells("TotalItems").Value.ToString()
            Dim stotal As String = row.Cells("subtotal").Value.ToString()
            Dim tax As String = row.Cells("totalTax").Value.ToString()
            Dim ccash As String = row.Cells("customerCash").Value.ToString()
            Dim change As String = row.Cells("customerChange").Value.ToString()
            Dim total As String = row.Cells("totalAmount").Value.ToString()
            Dim gettax As String = row.Cells("tax").Value.ToString()

            ' Reset startY to its initial value before printing the transaction-related information for each row
            startY = initialY

            ' Print transaction-related information for the current row
            e.Graphics.DrawString($"Number of items:{New String(" "c, 20)}{txtTqty}", boldFont, brush, 100, startY)
            startY += 20

            e.Graphics.DrawString($"Subtotal: {New String(" "c, 30)}₱{stotal}", boldFont, brush, 100, startY)
            startY += 20

            e.Graphics.DrawString($"TAX:{gettax} {New String(" "c, 10)}Total Tax : ₱{tax}", boldFont, brush, 100, startY)
            startY += 20

            e.Graphics.DrawString($"Transaction Amount: {New String(" "c, 8)}₱{ccash}", boldFont, brush, 100, startY)
            startY += 20

            e.Graphics.DrawString($"Change: {New String(" "c, 28)}₱{change}", boldFont, brush, 100, startY)
            startY += 20

            ' Draw total price in bold
            Dim totalPriceInfo As String = $"Total: {New String(" "c, 35)}₱{total}"

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
        Next

    End Sub
End Class