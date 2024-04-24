Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Text
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Main
    Dim notifyIcon As New NotifyIcon()
    Public notifnum As Integer = 2
    Dim expiredItemTimer As New Timer()
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Dim notificationPictureBox As PictureBox ' Added PictureBox for GIF notification

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetime.Enabled = True
        expiredItemTimer.Interval = 1000 ' Set the interval for checking expired items (adjust as needed)
        AddHandler expiredItemTimer.Tick, AddressOf CheckExpiredItems
        expiredItemTimer.Start()
        Dim TimerStatus As New Timer()
        TimerStatus.Interval = 3000
        AddHandler TimerStatus.Tick, AddressOf UpdateExpiredStatuses
        TimerStatus.Start()
    End Sub

    Private Sub UpdateExpiredStatuses(sender As Object, e As EventArgs)
        ' Update the statuses in the database
        Using con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
            Try
                con.Open()

                ' Update the statuses to 'Out-of-Stock' for items with stock = 0 and expired ExpiryDate
                Using cmdOutOfStockExpired As New MySqlCommand("UPDATE inventory SET status = 'Out-of-Stock' WHERE stock = 0 AND ExpiryDate <= CURDATE()", con)
                    cmdOutOfStockExpired.ExecuteNonQuery()
                End Using

                ' Update the statuses to 'Expired' for items with expired ExpiryDate (excluding stock = 0)
                Using cmdExpire As New MySqlCommand("UPDATE inventory SET status = 'Expired' WHERE ExpiryDate <= CURDATE() AND stock > 0", con)
                    cmdExpire.ExecuteNonQuery()
                End Using

                ' Update the statuses to 'Expired' for items with stock > 0 and expired ExpiryDate
                Using cmdAvailableExpired As New MySqlCommand("UPDATE inventory SET status = 'Expired' WHERE ExpiryDate <= CURDATE() AND stock > 25", con)
                    cmdAvailableExpired.ExecuteNonQuery()
                End Using

                ' Update the statuses to 'Out-of-Stock' for items with stock = 0 (excluding expired items)
                Using cmdOutOfStock As New MySqlCommand("UPDATE inventory SET status = 'Out-of-Stock' WHERE stock = 0 AND ExpiryDate > CURDATE()", con)
                    cmdOutOfStock.ExecuteNonQuery()
                End Using

                ' Update the statuses to 'Available' for items with stock > 25
                Using cmdAvailable As New MySqlCommand("UPDATE inventory SET status = 'Available' WHERE stock > 25 AND ExpiryDate > CURDATE()", con)
                    cmdAvailable.ExecuteNonQuery()
                End Using

                ' Update the statuses to 'Low Stock' for items with stock < 25 and expired ExpiryDate
                Using cmdLowStock As New MySqlCommand("UPDATE inventory SET status = 'Low Stock' WHERE stock < 25 AND ExpiryDate > CURDATE()", con)
                    cmdLowStock.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating statuses: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CheckExpiredItems(sender As Object, e As EventArgs)
        ' Check the database for expired items
        If HasExpiredItems() Then
            ' Change the color of the notification button and make it blink
            BlinkNotificationButton()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NotifForm.Show()
        StopBlinkingAndHidePictureBox()
    End Sub
    Private Function HasExpiredItems() As Boolean
        Dim query As String = "SELECT COUNT(*) FROM inventory WHERE (ExpiryDate < NOW()) OR (status IN ('Out-of-Stock', 'Low Stock'))"
        Using cmd As New MySqlCommand(query, con)
            con.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()
            Return count > 0
        End Using
    End Function

    Private Sub BlinkNotificationButton()
        ' Change the color of the notification button and make it blink
        If notifnum = 0 Then
            Guna2Button4.FillColor = Color.Gray
        Else
            Guna2Button4.FillColor = Color.Red ' Change the color as needed
        End If
        notifnum = (notifnum + 1) Mod 2
    End Sub



    Private Sub StopBlinkingAndHidePictureBox()
        expiredItemTimer.Stop() ' Stop the timer to stop blinking
        Me.Controls.Remove(notificationPictureBox) ' Remove the PictureBox
    End Sub

    Private Sub datetime_Tick(sender As Object, e As EventArgs) Handles datetime.Tick
        txtDate.Text = Date.Now.ToString("MM/dd/yyyy")
        txtTime.Text = Date.Now.ToString("hh:mm:ss")


    End Sub
    '' Switching Forms Functions <---------------------------------------------------
    Sub switchforms(ByVal panel As Form)
        PanelForm.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        PanelForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Async Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Cursor = Cursors.WaitCursor
        DisableButtons()
        ' Button to show dashboard and activate the function
        switchforms(Dashboard)
        Await Task.Delay(1000) ' Delay for 1 second (adjust as needed)
        Dashboard.Dashboardfunction()
        EnableButtons()
        Me.Cursor = Cursors.Default
    End Sub

    Private Async Sub btnProdMng_Click(sender As Object, e As EventArgs) Handles btnProdMng.Click
        Me.Cursor = Cursors.WaitCursor
        Label.Text = "PRODUCT MANAGEMENT"
        DisableButtons()
        switchforms(ProdMng)
        Await Task.Delay(1000)
        ProdMng.ProdMngmentFunction()
        EnableButtons()
        Me.Cursor = Cursors.Default
    End Sub

    Private Async Sub btnInvMng_Click(sender As Object, e As EventArgs) Handles btnInvMng.Click
        Me.Cursor = Cursors.WaitCursor
        Label.Text = "INVENTORY MANAGEMENT"
        DisableButtons()
        switchforms(InvMng)
        Await Task.Delay(1000)
        EnableButtons()
        Me.Cursor = Cursors.Default
    End Sub

    Private Async Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        Me.Cursor = Cursors.WaitCursor
        Label.Text = "SALES REPORTING AND ANALYTICS"
        DisableButtons()
        switchforms(SalesRptAna)
        Await Task.Delay(1000)
        SalesRptAna.SalesRptAnaFunction()
        EnableButtons()
        Me.Cursor = Cursors.Default
    End Sub

    Private Async Sub btnSalesMng_Click(sender As Object, e As EventArgs) Handles btnSalesMng.Click
        Me.Cursor = Cursors.WaitCursor
        DisableButtons()
        Await Task.Delay(1000)
        SalesOrderMng.Show()
        EnableButtons()
        GenerateAndSetReferenceNumber()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub GenerateAndSetReferenceNumber()
        ' Generate a new reference number (you may have your own logic for this)
        Dim newReferenceNumber As String = GenerateNewReferenceNumber()
        SalesOrderMng.clear()

        ' Check if the generated reference number already exists
        If Not IsReferenceNumberExists(newReferenceNumber) Then
            ' If it doesn't exist, set the reference number in txtCRef
            SalesOrderMng.txtCRef.Text = newReferenceNumber
        Else
            ' Handle the case where the generated reference number already exists
            MessageBox.Show("Reference number already exists. Please generate a new one.")
        End If
    End Sub
    Private Function GenerateNewReferenceNumber() As String
        ' Generate a string with the current date in "yyyyMMdd" format
        Dim dateString As String = Date.Now.ToString("yyyyMMdd")

        ' Generate 5 random characters
        Dim random As New Random()
        Dim randomChars As String = ""
        For i As Integer = 1 To 5
            randomChars &= ChrW(random.Next(65, 91)) ' ASCII codes for uppercase letters (A-Z)
        Next

        ' Combine the date and random characters to form the reference number
        Return "REF" & dateString & randomChars
    End Function
    Private Function IsReferenceNumberExists(referenceNumber As String) As Boolean
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
    Private Sub DisableButtons()
        btnDashboard.Enabled = False
        btnProdMng.Enabled = False
        btnInvMng.Enabled = False
        btnSalesReport.Enabled = False
        btnSalesMng.Enabled = False
    End Sub
    Private Sub EnableButtons()
        btnDashboard.Enabled = True
        btnProdMng.Enabled = True
        btnInvMng.Enabled = True
        btnSalesReport.Enabled = True
        btnSalesMng.Enabled = True
    End Sub

    ''--------------------------------------------------------->
    Private Sub Guna2Button4_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button4.MouseHover
        notifnum = 0
        Guna2Button4.FillColor = Color.Gray
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        notifnum = 0
    End Sub


    Private Sub DropDown_Click(sender As Object, e As EventArgs) Handles DropDown.Click
        DropDownStrip.Show(DropDown, 0, DropDown.Height)
    End Sub

    Private Sub VIEWPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWPROFILEToolStripMenuItem.Click
        ' Code to handle the "View Profile" menu item click
        mainViewProfile.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        ' Close the current MainForm
        Me.Close()

        ' Open the LoginForm
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub

    Private Sub btnOpenAdmin_Click(sender As Object, e As EventArgs) Handles btnOpenAdmin.Click
        AdminForm.Show()
    End Sub


End Class