Imports Guna.UI2.WinForms

Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class SalesRptAna
    Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"
    Public Sub SalesRptAnaFunction()
        LoadSalesData()
        TSalesFunc()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim sumQueryHighest As String = "SELECT SUM(TotalItems) AS MonthlyTotal, 
                                      DATE_FORMAT(`TransactionDate`, '%M') AS TransactionMonthName 
                                      FROM list_sales 
                                      GROUP BY TransactionMonthName 
                                      ORDER BY MonthlyTotal DESC 
                                      LIMIT 1"
            Using sumCommandHighest As New MySqlCommand(sumQueryHighest, connection)
                Using sumReaderHighest As MySqlDataReader = sumCommandHighest.ExecuteReader()
                    If sumReaderHighest.Read() Then
                        Dim highestMonthTotalItems As Integer = Convert.ToInt32(sumReaderHighest("MonthlyTotal"))
                        Dim highestMonthName As String = sumReaderHighest("TransactionMonthName").ToString()

                        Guna2ProgressBar1.Value = highestMonthTotalItems
                        lblHm.Text = $"{highestMonthName}: {highestMonthTotalItems}"
                    End If
                End Using
            End Using
            Dim sumQueryLowest As String = "SELECT SUM(TotalItems) AS MonthlyTotal, 
                                     DATE_FORMAT(`TransactionDate`, '%M') AS TransactionMonthName 
                                     FROM list_sales 
                                     GROUP BY TransactionMonthName 
                                     ORDER BY MonthlyTotal ASC 
                                     LIMIT 1"
            Using sumCommandLowest As New MySqlCommand(sumQueryLowest, connection)
                Using sumReaderLowest As MySqlDataReader = sumCommandLowest.ExecuteReader()
                    If sumReaderLowest.Read() Then
                        Dim lowestMonthTotalItems As Integer = Convert.ToInt32(sumReaderLowest("MonthlyTotal"))
                        Dim lowestMonthName As String = sumReaderLowest("TransactionMonthName").ToString()

                        Guna2ProgressBar2.Value = lowestMonthTotalItems
                        lblLm.Text = $"{lowestMonthName}: {lowestMonthTotalItems}"
                    End If
                End Using
            End Using
            Dim overallSumQuery As String = "SELECT SUM(TotalItems) AS OverallSum FROM list_sales"

            Using overallSumCommand As New MySqlCommand(overallSumQuery, connection)
                Dim overallSum As Object = overallSumCommand.ExecuteScalar()
                lblOverallqty.Text = $"Overall: {Convert.ToInt32(overallSum)}"
                Guna2ProgressBar3.Value = overallSum
            End Using
            ' Highest TotalAmount
            Dim highestAmountQuery As String = "SELECT MAX(TotalAmount) AS HighestAmount, 
                                        DATE_FORMAT(`TransactionDate`, '%M') AS TransactionMonthName 
                                        FROM list_sales 
                                        GROUP BY TransactionMonthName 
                                        ORDER BY HighestAmount DESC 
                                        LIMIT 1"

            Using highestAmountCommand As New MySqlCommand(highestAmountQuery, connection)
                Using highestAmountReader As MySqlDataReader = highestAmountCommand.ExecuteReader()
                    If highestAmountReader.Read() Then
                        Dim highestMonthAmount As Decimal = Convert.ToDecimal(highestAmountReader("HighestAmount"))
                        Dim highestMonthNameAmount As String = highestAmountReader("TransactionMonthName").ToString()

                        ' Update your progress bar or display the result as needed
                        Guna2ProgressBar5.Value = highestMonthAmount

                        lblHA.Text = $"{highestMonthNameAmount}:₱{highestMonthAmount}"
                    End If
                End Using
            End Using

            ' Lowest TotalAmount
            Dim lowestAmountQuery As String = "SELECT MIN(TotalAmount) AS LowestAmount, 
                                       DATE_FORMAT(`TransactionDate`, '%M') AS TransactionMonthName 
                                       FROM list_sales 
                                       GROUP BY TransactionMonthName 
                                       ORDER BY LowestAmount ASC 
                                       LIMIT 1"

            Using lowestAmountCommand As New MySqlCommand(lowestAmountQuery, connection)
                Using lowestAmountReader As MySqlDataReader = lowestAmountCommand.ExecuteReader()
                    If lowestAmountReader.Read() Then
                        Dim lowestMonthAmount As Decimal = Convert.ToDecimal(lowestAmountReader("LowestAmount"))
                        Dim lowestMonthNameAmount As String = lowestAmountReader("TransactionMonthName").ToString()

                        ' Update your progress bar or display the result as needed
                        Guna2ProgressBar6.Value = lowestMonthAmount

                        lblLA.Text = $"{lowestMonthNameAmount}:₱{lowestMonthAmount}"
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        Dim selectedYear As Date = DateTimePicker1.Value.Date
        Dim selectedMonth As Integer = DateTimePicker1.Value.Month
        ' Check the selected chart type and call the appropriate method
        Select Case cboChart.SelectedItem?.ToString()
            Case "Yearly"
                LoadSalesDataForSplineChart3(selectedYear)
                GetQtySold(selectedYear)
            Case "Monthly"
                LoadSalesDataForSplineChart2(selectedYear, selectedMonth)
                GetQtyMnthSold(selectedYear, selectedMonth)
            Case "Weekly"
                LoadSalesDataForSplineChart(selectedYear)
                GetQtyWeekSold(selectedYear)
        End Select
    End Sub

    Private Sub cboChart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChart.SelectedIndexChanged
        Dim selectedYear As Date = DateTimePicker1.Value.Date
        Dim selectedMonth As Integer = DateTimePicker1.Value.Month

        Select Case cboChart.SelectedItem.ToString()
            Case "Yearly"
                LoadSalesDataForSplineChart3(selectedYear)
                GetQtySold(selectedYear)
            Case "Monthly"
                LoadSalesDataForSplineChart2(selectedYear, selectedMonth)
                GetQtyMnthSold(selectedYear, selectedMonth)
            Case "Weekly"
                LoadSalesDataForSplineChart(selectedYear)
                GetQtyWeekSold(selectedYear)
        End Select

    End Sub
    Private Sub LoadSalesDataForSplineChart(selectedDate As Date)
        Dim selectedYear As Integer = selectedDate.Year
        Dim selectedWeek As Integer = DatePart(DateInterval.WeekOfYear, selectedDate)

        ' Calculate the start and end dates for the selected week
        Dim startDate As Date = DateSerial(selectedYear, 1, 1).AddDays((selectedWeek - 1) * 7 - CInt(DatePart(DateInterval.Weekday, DateSerial(selectedYear, 1, 1), FirstDayOfWeek.Sunday)) + 1)
        Dim endDate As Date = startDate.AddDays(6)

        ' Format the dates for the SQL query
        Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd")
        Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd")

        Dim query As String = $"SELECT DATE(TransactionDate) AS SaleDay, SUM(totalAmount) AS TotalSales FROM list_sales WHERE TransactionDate >= '{formattedStartDate}' AND TransactionDate <= '{formattedEndDate}' GROUP BY SaleDay"

        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in the spline chart
                    Chart1.Series.Clear()

                    ' Create a new series for the spline chart
                    Dim series As New Series("TotalSales")
                    series.ChartType = SeriesChartType.Column

                    ' Add data points to the series
                    While reader.Read()
                        Dim saleDay As Date = Convert.ToDateTime(reader("SaleDay"))
                        Dim totalSales As Decimal = Convert.ToDecimal(reader("TotalSales"))

                        ' Convert the date to the day of the week name
                        Dim dayOfWeekName As String = saleDay.ToString("dddd")

                        ' Format totalSales with two decimal places and add peso sign
                        Dim formattedTotalSales As String = $"{totalSales:N2} ₱"

                        ' Modify the label to include overall sales value
                        Dim label As String = $"{dayOfWeekName}{Environment.NewLine}Total Sales: {formattedTotalSales}"

                        ' Add data point with value (total sales) and modified label
                        series.Points.AddXY(dayOfWeekName, totalSales)
                        series.Points(series.Points.Count - 1).Label = label
                    End While

                    ' Add the series to the spline chart
                    Chart1.Series.Add(series)

                    ' Set axis labels if needed
                    Chart1.ChartAreas(0).AxisX.Title = "Day of the Week"
                    Chart1.ChartAreas(0).AxisY.Title = "Total Sales (₱)"
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadSalesDataForSplineChart2(selectedYear As Date, selectedMonth As Integer)
        Dim query As String = $"SELECT WEEK(TransactionDate, 3) - WEEK(DATE_SUB(TransactionDate, INTERVAL (DAY(TransactionDate) - 1) DAY), 3) + 1 AS SaleWeek, MONTH(TransactionDate) AS SaleMonth, SUM(totalAmount) AS TotalSales FROM list_sales WHERE YEAR(TransactionDate) = {selectedYear.Year} AND MONTH(TransactionDate) = {selectedMonth} GROUP BY SaleWeek, SaleMonth"
        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()
            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in the spline chart
                    Chart1.Series.Clear()
                    ' Create a new series for the spline chart
                    Dim series As New Series("TotalSales")
                    series.ChartType = SeriesChartType.Column
                    ' Add data points to the series
                    While reader.Read()
                        Dim saleWeek As Integer = Convert.ToInt32(reader("SaleWeek"))
                        Dim saleMonth As Integer = Convert.ToInt32(reader("SaleMonth"))
                        Dim totalSales As Decimal = Convert.ToDecimal(reader("TotalSales"))
                        ' Format totalSales with two decimal places and add peso sign
                        Dim formattedTotalSales As String = $"{totalSales:N2} ₱"
                        ' Create a label for the data point (e.g., "December - 1st week")
                        Dim label As String = $"{GetMonthName(saleMonth)} - {GetWeekOrdinal(saleWeek)} week"
                        ' Add data point with value (total sales) and label (month and week)
                        series.Points.AddXY(label, totalSales)
                        series.Points(series.Points.Count - 1).Label = formattedTotalSales
                    End While
                    ' Add the series to the spline chart
                    Chart1.Series.Add(series)
                    ' Set axis labels if needed
                    Chart1.ChartAreas(0).AxisX.Title = "Month and Weeks"
                    Chart1.ChartAreas(0).AxisY.Title = "Total Sales (₱)"
                End Using
            End Using
        End Using
    End Sub
    Private Function GetWeekOrdinal(weekNumber As Integer) As String
        If weekNumber >= 11 AndAlso weekNumber <= 13 Then
            Return $"{weekNumber}th"
        End If
        Select Case weekNumber Mod 10
            Case 1
                Return $"{weekNumber}st"
            Case 2
                Return $"{weekNumber}nd"
            Case 3
                Return $"{weekNumber}rd"
            Case Else
                Return $"{weekNumber}th"
        End Select
    End Function
    Private Sub LoadSalesDataForSplineChart3(selectedYear As Date)
        Dim query As String = $"SELECT MONTH(TransactionDate) AS SaleMonth, YEAR(TransactionDate) AS SaleYear, SUM(totalAmount) AS TotalSales FROM list_sales WHERE YEAR(TransactionDate) = {selectedYear.Year} GROUP BY SaleYear, SaleMonth"
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Chart1.Series.Clear()
                    Dim series As New Series("TotalSales")
                    series.ChartType = SeriesChartType.Spline
                    While reader.Read()
                        Dim saleYear As Integer = Convert.ToInt32(reader("SaleYear"))
                        Dim saleMonth As Integer = Convert.ToInt32(reader("SaleMonth"))
                        Dim totalSales As Decimal = Convert.ToDecimal(reader("TotalSales"))
                        series.Points.AddXY($"{GetMonthName(saleMonth)} {saleYear}", totalSales)
                    End While

                    Chart1.Series.Add(series)
                    Chart1.ChartAreas(0).AxisX.Title = "Month and Year"
                    Chart1.ChartAreas(0).AxisY.Title = "Total Sales"
                End Using
            End Using
        End Using
    End Sub
    Private Function GetMonthName(monthNumber As Integer) As String
        Return New DateTime(1, monthNumber, 1).ToString("MMMM")
    End Function
    Public Sub TSalesFunc()
        ' Assuming you have a CircleBar control named CircleBar1 and a Label named lblSales
        ' Your database connection string
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"
        ' Your database query to get the total amount
        Dim query As String = "SELECT SUM(TotalAmount) FROM list_sales"
        Dim totalAmount As Decimal = 0
        ' Using block for database connection
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the totalAmount from the database
                        totalAmount = If(reader.IsDBNull(0), 0, Convert.ToDecimal(reader(0)))
                    End If
                End Using
            End Using
        End Using
        ' Format the totalAmount with two decimal places and add peso sign
        Dim formattedTotalAmount As String = $"₱{totalAmount:N2} "
        ' Calculate the percentage based on the maximum value (50,000)
        Dim percentage As Double = Math.Min(1.0, totalAmount / 50000.0) ' Ensure the percentage does not exceed 100%
        ' Update the CircleBar value (assuming CircleBar1 has a MaxValue property)
        circleBar.Maximum = 50000
        circleBar.Value = Convert.ToInt32(percentage * circleBar.Maximum)
        Progbar.Maximum = 50000
        Progbar.Value = Convert.ToInt32(percentage * Progbar.Maximum)
        ' Update the Label text
        lblSales.Text = formattedTotalAmount
        lblSales2.Text = formattedTotalAmount
    End Sub
    Public Sub GetQtySold(selectedYear As Date)
        ' Your database connection string
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"
        ' Your database query to get the quantity sold for each product in the selected year
        Dim query As String = "SELECT CustomerProducts, SUM(QuantityItem) AS QtySold FROM list_sales WHERE YEAR(TransactionDate) = @SelectedYear GROUP BY CustomerProducts"
        ' Using block for database connection
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Add parameter to the query
                command.Parameters.AddWithValue("@SelectedYear", selectedYear.Year)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in chart2
                    Chart2.Series.Clear()
                    ' Create a new series for chart2
                    Dim series As New Series("Item Sold")
                    series.ChartType = SeriesChartType.Column
                    ' Add data points to the series
                    While reader.Read()
                        Dim productName As String = Convert.ToString(reader("CustomerProducts"))
                        Dim qtySold As Integer = Convert.ToInt32(reader("QtySold"))
                        ' Add data point with value (quantity sold) and label (product name)
                        series.Points.AddXY(productName, qtySold)
                    End While
                    ' Add the series to chart2
                    Chart2.Series.Add(series)

                    ' Set axis labels if needed
                    Chart2.ChartAreas(0).AxisX.Title = "Product Name"
                    Chart2.ChartAreas(0).AxisY.Title = "Quantity Sold"
                End Using
            End Using
        End Using
    End Sub

    Public Sub GetQtyMnthSold(selectedYear As Date, selectedMonth As Integer)
        ' Your database connection string
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"
        ' Your database query to get the quantity sold for each product in the selected month and year
        Dim query As String = $"SELECT CustomerProducts, WEEK(TransactionDate, 3) - WEEK(DATE_SUB(TransactionDate, INTERVAL (DAY(TransactionDate) - 1) DAY), 3) + 1 AS SaleWeek, MONTH(TransactionDate) AS SaleMonth, SUM(QuantityItem) AS TotalQuantity FROM list_sales WHERE YEAR(TransactionDate) = {selectedYear.Year} AND MONTH(TransactionDate) = {selectedMonth} GROUP BY CustomerProducts, SaleWeek, SaleMonth"

        ' Using block for database connection
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in chart2
                    Chart2.Series.Clear()
                    ' Create a new series for chart2
                    Dim series As New Series("Item Sold")
                    series.ChartType = SeriesChartType.Column
                    ' Add data points to the series
                    While reader.Read()
                        Dim productName As String = Convert.ToString(reader("CustomerProducts"))
                        Dim qtySold As Integer = Convert.ToInt32(reader("TotalQuantity")) ' Changed to TotalQuantity
                        ' Add data point with value (quantity sold) and label (product name)
                        series.Points.AddXY(productName, qtySold)
                    End While
                    ' Add the series to chart2
                    Chart2.Series.Add(series)
                    ' Set axis labels if needed
                    Chart2.ChartAreas(0).AxisX.Title = "Product Name"
                    Chart2.ChartAreas(0).AxisY.Title = "Quantity Sold"
                End Using
            End Using
        End Using
    End Sub
    Public Sub GetQtyWeekSold(selectedDate As Date)
        Dim selectedYear As Integer = selectedDate.Year
        Dim selectedWeek As Integer = DatePart(DateInterval.WeekOfYear, selectedDate)
        Dim startDate As Date = DateSerial(selectedYear, 1, 1).AddDays((selectedWeek - 1) * 7 - CInt(DatePart(DateInterval.Weekday, DateSerial(selectedYear, 1, 1), FirstDayOfWeek.Sunday)) + 1)
        Dim endDate As Date = startDate.AddDays(6)
        Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd")
        Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd")

        Dim query As String = $"SELECT DATE(TransactionDate) AS SaleDay, CustomerProducts, SUM(QuantityItem) AS TotalQuantity FROM list_sales WHERE TransactionDate >= '{formattedStartDate}' AND TransactionDate <= '{formattedEndDate}' GROUP BY SaleDay, CustomerProducts"

        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Chart2.Series.Clear()

                    ' Create a new series for the chart
                    Dim series As New Series("Total Quantity Sold")
                    series.ChartType = SeriesChartType.Column

                    While reader.Read()
                        Dim saleDay As Date = Convert.ToDateTime(reader("SaleDay"))
                        Dim product As String = Convert.ToString(reader("CustomerProducts"))
                        Dim totalQuantity As Decimal = Convert.ToDecimal(reader("TotalQuantity"))
                        Dim dayOfWeekName As String = saleDay.ToString("dddd")

                        ' Format totalQuantity with two decimal places and add appropriate unit
                        Dim formattedTotalQuantity As String = $"{totalQuantity:N2} items"

                        ' Modify the label to include overall quantity value and product name
                        Dim label As String = $"{Environment.NewLine}{product}: {formattedTotalQuantity}"

                        ' Add data point with value (total quantity) and modified label
                        series.Points.AddXY(dayOfWeekName, totalQuantity)
                        series.Points(series.Points.Count - 1).Label = label
                    End While

                    ' Add the series to the chart
                    Chart2.Series.Add(series)

                    ' Set axis labels if needed
                    Chart2.ChartAreas(0).AxisX.Title = "Day of the Week"
                    Chart2.ChartAreas(0).AxisY.Title = "Total Quantity Sold"
                End Using
            End Using
        End Using
    End Sub
    Dim dt As New DataTable

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        ' Reload data based on the new date filter
        LoadSalesData()
    End Sub
    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        ' Reload data based on the new date filter
        LoadSalesData()
    End Sub

    Public Sub LoadSalesData()
        Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")

        ' Get the selected dates from DateTimePickers
        Dim fromDate As String = dtpFrom.Value.ToString("yyyy-MM-dd")
        Dim toDate As String = dtpTo.Value.ToString("yyyy-MM-dd")
        Dim selectedYear As String = dtpFrom.Value.Year.ToString()
        Dim cmdText As String = "SELECT * FROM `list_sales` WHERE TransactionDate BETWEEN @FromDate AND @ToDate AND YEAR(TransactionDate) = @SelectedYear"
        Dim cmd As New MySqlCommand(cmdText, con)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)
        cmd.Parameters.AddWithValue("@SelectedYear", selectedYear)
        Dim msadap As New MySqlDataAdapter(cmd)
        dt.Clear()
        msadap.Fill(dt)

        DataGridView1.DataSource = dt

        ' Set the visibility of specific columns
        ' (Assuming these columns are common to both tables)
        DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("tax").Visible = False
        DataGridView1.Columns("subtotal").Visible = False
        DataGridView1.Columns("totaltax").Visible = False
        DataGridView1.Columns("TotalItems").Visible = False
        DataGridView1.Columns("TotalPerItem").Visible = False
        DataGridView1.Columns("price").Visible = False
        DataGridView1.Columns("customerCash").Visible = False
        DataGridView1.Columns("customerChange").Visible = False
        DataGridView1.Columns("Employee").Visible = False

        If dt.Rows.Count > 0 Then
            DataGridView1.ClearSelection()
        End If
    End Sub

    Private Sub btnPrntY_Click(sender As Object, e As EventArgs) Handles btnPrntY.Click
        If yearButtonClicked Then
            LoadSalesData()
            yearButtonClicked = True
            monthlyButtonClicked = False
            weekButtonClicked = False
        End If
        If monthlyButtonClicked Then
            LoadSalesData()
            monthlyButtonClicked = True
            yearButtonClicked = False
            weekButtonClicked = False
        End If
        If weekButtonClicked Then
            LoadSalesData()
            weekButtonClicked = True
            yearButtonClicked = False
            monthlyButtonClicked = False
        End If

        Dim printDialog As New PrintDialog()
        Dim printDocument As New PrintDocument()

        ' Set the PrintPage event handler
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Set paper orientation to landscape
        printDocument.DefaultPageSettings.Landscape = True

        ' Set paper size to legal
        Dim legalPaperSize As New PaperSize("Legal", 850, 1400)
        printDocument.DefaultPageSettings.PaperSize = legalPaperSize

        ' Display the print preview dialog
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Header
        Dim headerFont As New Font("Arial", 14, FontStyle.Bold)
        e.Graphics.DrawString("MAXCORE : SALES MANAGEMENT SYSTEM", headerFont, Brushes.Black, New PointF(10, 10))
        ' Subheader
        Dim subHeaderFont As New Font("Arial", 12, FontStyle.Bold)

        If yearButtonClicked Then
            Dim selectedYear As String = dtpFrom.Value.ToString("yyyy")
            e.Graphics.DrawString($"YEARLY SALES REPORT - {selectedYear}", subHeaderFont, Brushes.Black, New PointF(10, 40))
        ElseIf monthlyButtonClicked Then
            Dim monthName As String = dtpFrom.Value.ToString("MMMM")
            e.Graphics.DrawString($"MONTH OF {monthName} SALES REPORT", subHeaderFont, Brushes.Black, New PointF(10, 40))
        ElseIf weekButtonClicked Then
            Dim weekStartDate As String = dtpFrom.Value.ToString("MMMM dd, yyyy")
            Dim weekEndDate As String = dtpTo.Value.ToString("MMMM dd, yyyy")
            e.Graphics.DrawString($"WEEKLY SALES REPORT ({weekStartDate} to {weekEndDate})", subHeaderFont, Brushes.Black, New PointF(10, 40))
        Else
            e.Graphics.DrawString("SALES REPORT", subHeaderFont, Brushes.Black, New PointF(10, 40))
        End If
        ' Separator line
        e.Graphics.DrawLine(Pens.Black, New Point(10, 70), New Point(e.PageBounds.Width - 10, 70))

        ' Print the date and time
        Dim dateFont As New Font("Arial", 8)
        Dim dateText As String = $"Date: {Main.txtDate.Text}    Time: {Main.txtTime.Text}"
        e.Graphics.DrawString(dateText, dateFont, Brushes.Black, New PointF(10, 80))

        ' Separator line
        e.Graphics.DrawLine(Pens.Black, New Point(10, 100), New Point(e.PageBounds.Width - 10, 100))

        ' Print each column separately
        Dim xPosition As Integer = 10

        ' Define the order of columns you want to print
        Dim columnOrder() As String = {"CustomerName", "CustomerRef#", "Barcode", "CustomerProducts", "ProductType", "ProductVolume", "CustomerCash", "TransactionDate", "TotalPerItem", "totalTax", "TotalAmount"}

        ' Define custom widths for each column
        Dim columnWidths() As Integer = {120, 120, 100, 180, 178, 90, 100, 150, 100, 100, 100}

        ' Draw column headers with custom widths
        For i As Integer = 0 To columnOrder.Length - 1
            Dim columnIndex As Integer = -1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                If DataGridView1.Columns(j).HeaderText.Equals(columnOrder(i), StringComparison.OrdinalIgnoreCase) Then
                    columnIndex = j
                    Exit For
                End If
            Next

            If columnIndex <> -1 Then
                Dim headerWidth As Integer = columnWidths(i)
                e.Graphics.FillRectangle(Brushes.LightGray, xPosition, 110, headerWidth, 20)
                e.Graphics.DrawRectangle(Pens.Black, xPosition, 110, headerWidth, 20)
                e.Graphics.DrawString(DataGridView1.Columns(columnIndex).HeaderText, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, xPosition + 2, 112)
                xPosition += headerWidth
            End If
        Next

        ' Move to the next line after drawing column headers
        Dim startY As Integer = 130

        ' Draw data from DataGridView with custom column widths
        For i As Integer = 0 To DataGridView1.RowCount - 1
            xPosition = 10 ' Reset X position for each row
            Dim currentCustomerRef As String = DataGridView1("CustomerRef#", i).Value?.ToString()
            For j As Integer = 0 To columnOrder.Length - 1
                Dim columnIndex As Integer = -1
                For k As Integer = 0 To DataGridView1.Columns.Count - 1
                    If DataGridView1.Columns(k).HeaderText.Equals(columnOrder(j), StringComparison.OrdinalIgnoreCase) Then
                        columnIndex = k
                        Exit For
                    End If
                Next

                If columnIndex <> -1 Then
                    Dim cellWidth As Integer = columnWidths(j)
                    e.Graphics.FillRectangle(Brushes.White, xPosition, startY, cellWidth, 15)
                    e.Graphics.DrawRectangle(Pens.Black, xPosition, startY, cellWidth, 15)

                    If DataGridView1(columnIndex, i).Value IsNot Nothing Then
                        Dim cellValue As String = DataGridView1(columnIndex, i).Value.ToString()
                        e.Graphics.DrawString(cellValue, New Font("Arial", 8), Brushes.Black, xPosition + 2, startY + 2)
                    End If

                    xPosition += cellWidth
                End If
            Next



            ' Move to the next line after drawing each row
            startY += 15
        Next

        ' Add a new line in the document
        startY += 20


        ' Calculate total tax for the current row

        ' Display the total tax for each row
        Dim totalTax As Decimal = CalculateTotalTaxForAllRows()

        ' Display the total tax for all rows
        e.Graphics.DrawString("Total Tax: ₱" & totalTax.ToString("F2"), New Font("Arial", 10, FontStyle.Bold), Brushes.Black, 60, startY)

        ' Move to the next line after drawing total tax
        startY += 15

        ' Draw total amount for all rows
        e.Graphics.DrawString("Total Amount for this sales:₱", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, 100 - 50, startY)
        e.Graphics.DrawString(CalculateTotalAmount().ToString(), New Font("Arial", 10), Brushes.Black, 250 - 10, startY)
    End Sub
    Private Function CalculateTotalTaxForAllRows() As Decimal
        ' Calculate the total tax from the "TotalTax" column in DataGridView1 for all rows
        Dim totalTax As Decimal = 0

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1("TotalTax", i).Value IsNot Nothing Then
                Dim cellValue As Decimal
                If Decimal.TryParse(DataGridView1("TotalTax", i).Value.ToString(), cellValue) Then
                    totalTax += cellValue
                End If
            End If
        Next

        Return totalTax
    End Function
    Private Function CalculateTotalAmount() As Decimal
        ' Calculate the total amount from the "TotalAmount" column in DataGridView2
        Dim totalAmount As Decimal = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1("TotalPerItem", i).Value IsNot Nothing Then
                Dim cellValue As Decimal
                If Decimal.TryParse(DataGridView1("TotalPerItem", i).Value.ToString(), cellValue) Then
                    totalAmount += cellValue
                End If
            End If
        Next
        Return totalAmount
    End Function
    Private Sub Year_Click(sender As Object, e As EventArgs) Handles Year.Click
        ' Set the DateTimePicker values to cover the entire year
        dtpFrom.Value = New DateTime(dtpFrom.Value.Year, 1, 1)
        dtpTo.Value = New DateTime(dtpFrom.Value.Year, 12, 31)
        yearButtonClicked = True
        ' Print the data
        btnPrntY_Click(sender, e)
        yearButtonClicked = False
    End Sub
    Private yearButtonClicked As Boolean = False

    Private Sub monthly_Click(sender As Object, e As EventArgs) Handles monthly.Click
        dtpFrom.Value = New DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, 1)
        dtpTo.Value = New DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, DateTime.DaysInMonth(dtpFrom.Value.Year, dtpFrom.Value.Month))

        ' Set the flag to indicate that the Monthly button was clicked
        monthlyButtonClicked = True

        ' Print the data
        btnPrntY_Click(sender, e)

        ' Reset the flag after using it
        monthlyButtonClicked = False
    End Sub
    Private monthlyButtonClicked As Boolean = False

    Private Sub Week_Click(sender As Object, e As EventArgs) Handles Week.Click
        ' Set the DateTimePicker values to cover the entire week
        Dim selectedDate As DateTime = dtpFrom.Value
        Dim firstDayOfWeek As DateTime = selectedDate.AddDays(DayOfWeek.Sunday - selectedDate.DayOfWeek)
        Dim lastDayOfWeek As DateTime = firstDayOfWeek.AddDays(6)

        dtpFrom.Value = firstDayOfWeek
        dtpTo.Value = lastDayOfWeek

        ' Set the flag to indicate that the Week button was clicked
        weekButtonClicked = True

        ' Print the data
        btnPrntY_Click(sender, e)

        ' Reset the flag after using it
        weekButtonClicked = False
    End Sub
    Private weekButtonClicked As Boolean = False

End Class
