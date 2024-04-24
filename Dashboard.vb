Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Public Sub TotalProductCount()
        Try
            con.Open()

            Dim query As String = "SELECT SUM(Stock) FROM Inventory"
            Using cmd As New MySqlCommand(query, con)
                Dim sumStock As Object = cmd.ExecuteScalar()
                Dim stockSum As Integer = If(sumStock IsNot DBNull.Value, Convert.ToInt32(sumStock), 0)

                lblTP.Text = $"{stockSum}" ' Display the sum of Stock
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub TotalSoldsCount()
        Try
            con.Open()

            Dim query As String = "SELECT SUM(TotalItems) FROM list_sales"
            Using cmd As New MySqlCommand(query, con)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                lblSP.Text = count.ToString() ' Display only the numeric count
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub TotalUsersCount()
        Try
            con.Open()

            Dim query As String = "SELECT COUNT(*) FROM user"
            Using cmd As New MySqlCommand(query, con)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                lblUsers.Text = count.ToString() ' Display only the numeric count
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub TotalsalesCount()
        ' SQL query to get the sum of totalAmount from the database
        Dim query As String = "SELECT SUM(totalAmount) FROM list_sales"
        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Execute the SQL command and get the result
                Dim result As Object = command.ExecuteScalar()

                ' Check if the result is not DBNull
                If Not IsDBNull(result) Then
                    ' Convert the result to a decimal (assuming totalAmount is a decimal in the database)
                    Dim totalAmount As Decimal = Convert.ToDecimal(result)

                    ' Format the totalAmount in thousands with the peso sign
                    If totalAmount >= 1000 Then
                        lblSales.Text = $"₱{totalAmount / 1000:N1}k"
                    Else
                        lblSales.Text = $"₱{totalAmount:N0}"
                    End If
                Else
                    ' Handle the case when the result is DBNull
                    lblSales.Text = "N/A"
                End If
            End Using
        End Using
    End Sub
    ' place all the background functions here
    Public Sub Dashboardfunction()
        TotalProductCount()
        TotalUsersCount()
        TotalsalesCount()
        TotalSoldsCount()
        LoadSalesDataForPieChart()
        LoadSalesDataForPieChart2()
        LoadSalesDataForSplineChart()
        LoadSalesDataForSplineChart2()
        LoadSalesDataForSplineChart3(2023)
        DisplayBestSellingProduct()
        Main.Label.Text = "DASHBOARD"
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboardfunction()
    End Sub
    Private Sub LoadSalesDataForPieChart()
        ' SQL query to get data for the pie chart
        Dim query As String = "SELECT CustomerProducts, SUM(QuantityItem) AS totalQuantity FROM list_sales GROUP BY CustomerProducts"

        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in the chart
                    pieChart.Series.Clear()
                    pieChart.Legends.Clear()

                    ' Create a new series for the chart
                    Dim series As New Series("ItemsSold")
                    series.ChartType = SeriesChartType.Pie

                    ' Add data points to the series
                    While reader.Read()
                        Dim customerProduct As String = reader("CustomerProducts").ToString()
                        Dim totalQuantity As Integer = Convert.ToInt32(reader("totalQuantity"))

                        ' Add data point with value (total quantity) and label (product name)
                        series.Points.AddXY(customerProduct, totalQuantity)

                        ' Set IsValueShownAsLabel to True for each data point
                        series.Points(series.Points.Count - 1).IsValueShownAsLabel = True
                    End While

                    ' Add the series to the chart
                    pieChart.Series.Add(series)

                    ' Add a legend to the chart
                    Dim legend As New Legend("Legend")
                    pieChart.Legends.Add(legend)
                    ' Add title below the pie chart
                End Using
            End Using
        End Using
    End Sub
    Private Sub LoadSalesDataForPieChart2()
        ' SQL query to get data for the second pie chart
        Dim query As String = "SELECT ProductType, SUM(QuantityItem) AS totalQuantity FROM list_sales GROUP BY ProductType"

        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in the second chart
                    pieChart2.Series.Clear()
                    pieChart2.Legends.Clear()

                    ' Create a new series for the second chart
                    Dim series As New Series("ItemsSold")
                    series.ChartType = SeriesChartType.Pie

                    ' Add data points to the series
                    While reader.Read()
                        Dim productType As String = reader("ProductType").ToString()
                        Dim totalQuantity As Integer = Convert.ToInt32(reader("totalQuantity"))

                        ' Add data point with value (total quantity) and label (product type)
                        series.Points.AddXY(productType, totalQuantity)

                        ' Set IsValueShownAsLabel to True for each data point
                        series.Points(series.Points.Count - 1).IsValueShownAsLabel = True
                    End While
                    ' Add the series to the second chart
                    pieChart2.Series.Add(series)
                    ' Add a legend to the second chart
                    Dim legend As New Legend("Legend")
                    pieChart2.Legends.Add(legend)
                    ' Add title below the second pie chart
                End Using
            End Using
        End Using
    End Sub
    Private Sub UpdatePieChart()
        LoadSalesDataForPieChart()
    End Sub
    Private Sub LoadSalesDataForSplineChart()
        ' SQL query to get sales data for the bar chart over a week, including product names
        Dim query As String = "SELECT ls.CustomerProducts, DATE_FORMAT(ls.TransactionDate, '%W') AS SaleDay, SUM(ls.totalAmount) AS TotalSales FROM list_sales ls WHERE ls.TransactionDate >= CURDATE() - INTERVAL 7 DAY GROUP BY ls.CustomerProducts, SaleDay"
        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()
            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in the bar chart
                    Chart3.Series.Clear()
                    ' Create a new series for the bar chart
                    Dim series As New Series("TotalSales")
                    series.ChartType = SeriesChartType.Column
                    ' Dictionary to store days with data
                    Dim daysWithData As New Dictionary(Of String, Boolean)()
                    ' Add data points to the series and populate the daysWithData dictionary
                    While reader.Read()
                        Dim customerProduct As String = reader("CustomerProducts").ToString()
                        Dim saleDay As String = reader("SaleDay").ToString()
                        Dim totalSales As Decimal = Convert.ToDecimal(reader("TotalSales"))
                        ' Add data point with value (total sales)
                        Dim dataPoint As DataPoint = series.Points.Add(totalSales)
                        ' Set the label for the data point to the product name

                        If Not Chart3.Series.IsUniqueName(customerProduct) Then
                            series = Chart3.Series(customerProduct)
                        Else
                            series = New Series(customerProduct)
                            series.ChartType = SeriesChartType.Column
                            Chart3.Series.Add(series)
                        End If
                        series.Points.Add(totalSales).LegendText = customerProduct
                        ' Mark the day as having data
                        daysWithData(saleDay) = True
                    End While
                    ' Set axis labels if needed
                    Chart3.ChartAreas(0).AxisX.Title = "Day of the Week"
                    Chart3.ChartAreas(0).AxisY.Title = "Total Sales"
                End Using
            End Using
        End Using
    End Sub
    Private Sub LoadSalesDataForSplineChart2()
        ' SQL query to get sales data for the spline chart over a month
        Dim query As String = "SELECT DATE_FORMAT(TransactionDate, '%M') AS SaleMonth, SUM(totalAmount) AS TotalSales FROM list_sales WHERE TransactionDate >= CURDATE() - INTERVAL 30 DAY GROUP BY SaleMonth"

        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in the spline chart
                    Chart2.Series.Clear()

                    ' Create a new series for the spline chart
                    Dim series As New Series("TotalSales")
                    series.ChartType = SeriesChartType.Column

                    ' Add data points to the series
                    While reader.Read()
                        Dim saleMonth As String = reader("SaleMonth").ToString()
                        Dim totalSales As Decimal = Convert.ToDecimal(reader("TotalSales"))

                        ' Add data point with value (total sales) and label (month)
                        series.Points.AddXY(saleMonth, totalSales)
                    End While

                    ' Add the series to the spline chart
                    Chart2.Series.Add(series)

                    ' Set axis labels if needed
                    Chart2.ChartAreas(0).AxisX.Title = "Month"
                    Chart2.ChartAreas(0).AxisY.Title = "Total Sales"

                    ' Format x-axis labels to display the month names
                    Chart2.ChartAreas(0).AxisX.LabelStyle.Format = "MMMM"
                End Using
            End Using
        End Using
    End Sub
    Private Sub LoadSalesDataForSplineChart3(startYear As Integer)
        ' SQL query to get sales data for the bar chart from a specific year onwards
        Dim query As String = $"SELECT MONTH(TransactionDate) AS SaleMonth, YEAR(TransactionDate) AS SaleYear, SUM(totalAmount) AS TotalSales FROM list_sales WHERE YEAR(TransactionDate) >= {startYear} GROUP BY SaleYear, SaleMonth"

        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing data in Chart4
                    Chart4.Series.Clear()

                    ' Create a new series for Chart4
                    Dim series As New Series("TotalSales")
                    series.ChartType = SeriesChartType.Spline

                    ' Add data points to the series
                    While reader.Read()
                        Dim saleYear As Integer = Convert.ToInt32(reader("SaleYear"))
                        Dim saleMonth As Integer = Convert.ToInt32(reader("SaleMonth"))
                        Dim totalSales As Decimal = Convert.ToDecimal(reader("TotalSales"))

                        ' Add data point with value (total sales) and label (month)
                        series.Points.AddXY($"{GetMonthName(saleMonth)} {saleYear}", totalSales)
                    End While

                    ' Add the series to Chart4
                    Chart4.Series.Add(series)

                    ' Set axis labels if needed
                    Chart4.ChartAreas(0).AxisX.Title = "Month and Year"
                    Chart4.ChartAreas(0).AxisY.Title = "Total Sales"
                End Using
            End Using
        End Using
    End Sub
    ' Helper function to get the month name from the month number
    Private Function GetMonthName(monthNumber As Integer) As String
        Return New DateTime(1, monthNumber, 1).ToString("MMMM")
    End Function
    Private Sub DisplayBestSellingProduct()
        ' SQL query to find the sum of TotalPerItem for each CustomerProduct
        Dim query As String = "SELECT ls.CustomerProducts,ls.ProductVolume,SUM(ls.QuantityItem) AS TotalQ, SUM(ls.TotalPerItem) AS TotalSales, i.ItemImg FROM list_sales ls INNER JOIN Inventory i ON ls.Barcode = i.Barcode GROUP BY ls.CustomerProducts ORDER BY TotalSales DESC LIMIT 1"

        ' Using block for database connection
        Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            connection.Open()

            ' Using block for SQL command
            Using command As New MySqlCommand(query, connection)
                ' Using block for SQL data reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim customerProducts As String = reader("CustomerProducts").ToString()
                        Dim productVolume As String = reader("ProductVolume").ToString()

                        ' Concatenate values and assign to lblBestP.Text
                        lblBestP.Text = customerProducts & " " & productVolume
                        Dim totalqty As Decimal = Convert.ToDecimal(reader("TotalQ"))
                        Dim totalSales As Decimal = Convert.ToDecimal(reader("TotalSales"))
                        lblBsold.Text = $"Total Sales : ₱{totalSales}"
                        lblQty.Text = $"Items Sold : {totalqty}"
                        ' Assuming that ItemImg is a byte array in the database representing the image
                        Dim imageBytes As Byte() = DirectCast(reader("ItemImg"), Byte())
                        If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                            ' Convert byte array to image and set it to the PictureBox
                            Using ms As New MemoryStream(imageBytes)
                                pbBes.Image = Image.FromStream(ms)
                            End Using
                        Else
                            ' Set a default image or handle the case when the image is not available
                            pbBes.Image = Nothing
                        End If
                    Else
                        ' Handle the case when no data is returned
                        lblBestP.Text = "No data available"
                        lblBsold.Text = ""
                        pbBes.Image = Nothing
                    End If
                End Using
            End Using
        End Using
    End Sub



End Class