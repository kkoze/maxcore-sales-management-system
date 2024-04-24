Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO
Public Class NotifForm
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")

    Private Sub NotifForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        ' Call the method to populate DataGridView with expired items
        LoadExpiredItems()
        LoadExpiredItems2()
    End Sub

    Private Sub LoadExpiredItems()
        Try
            con.Open()

            ' Query to select items with expired ExpiryDate
            Dim query As String = "SELECT * FROM `inventory` WHERE `ExpiryDate` <= CURRENT_DATE"

            Using cmd As New MySqlCommand(query, con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                If dt.Rows.Count > 0 Then
                    ' Bind the DataTable to DataGridView
                    DataGridView1.DataSource = dt
                    DataGridView1.DataSource = dt
                    DataGridView1.Columns("id").Visible = False
                    DataGridView1.Columns("Description").Visible = False
                    DataGridView1.Columns("Dosage").Visible = False
                    DataGridView1.Columns("StorageCondition").Visible = False
                    DataGridView1.Columns("RegulatoryInformation").Visible = False
                    DataGridView1.Columns("totalcost").Visible = False
                    DataGridView1.Columns("CostPerUnit").Visible = False
                    DataGridView1.Columns("ItemImg").Visible = False
                    DataGridView1.Columns("Medicine Category").Visible = False
                    DataGridView1.Columns("Supplier").Visible = False
                    DataGridView1.Columns("SupplierID").Visible = False
                    DataGridView1.Columns("SupplierAddress").Visible = False
                    DataGridView1.Columns("SupplierContact").Visible = False
                    DataGridView1.Columns("totalcost").Visible = False
                    DataGridView1.Columns("CostPerUnit").Visible = False
                    DataGridView1.Columns("ItemImg").Visible = False
                    DataGridView1.Columns("Reference#").Visible = False
                    DataGridView1.Columns("DateUpdated").Visible = False
                    DataGridView1.Columns("status").Visible = False
                    DataGridView1.Columns("DateDelivered").Visible = False

                    ' Hide the label if there are items to display
                    Label3.Visible = False
                Else
                    ' No expired items found, display a message in a label
                    Label3.Text = "No expired items."
                    Label3.Visible = True

                    ' Clear the DataGridView
                    DataGridView1.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading expired items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadExpiredItems2()
        Try
            con.Open()

            ' Query to select items with expired ExpiryDate
            Dim query As String = "SELECT * FROM `inventory` WHERE `status` IN ('Out-of-Stock', 'Low Stock')"


            Using cmd As New MySqlCommand(query, con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                If dt.Rows.Count > 0 Then
                    ' Bind the DataTable to DataGridView
                    DataGridView2.DataSource = dt
                    ' Bind the DataTable to DataGridView
                    DataGridView2.DataSource = dt
                    DataGridView2.Columns("id").Visible = False
                    DataGridView2.Columns("Description").Visible = False
                    DataGridView2.Columns("Dosage").Visible = False
                    DataGridView2.Columns("StorageCondition").Visible = False
                    DataGridView2.Columns("RegulatoryInformation").Visible = False
                    DataGridView2.Columns("totalcost").Visible = False
                    DataGridView2.Columns("CostPerUnit").Visible = False
                    DataGridView2.Columns("ItemImg").Visible = False
                    DataGridView2.Columns("Medicine Category").Visible = False
                    DataGridView2.Columns("Supplier").Visible = False
                    DataGridView2.Columns("SupplierID").Visible = False
                    DataGridView2.Columns("SupplierAddress").Visible = False
                    DataGridView2.Columns("SupplierContact").Visible = False
                    DataGridView2.Columns("totalcost").Visible = False
                    DataGridView2.Columns("CostPerUnit").Visible = False
                    DataGridView2.Columns("ItemImg").Visible = False
                    DataGridView2.Columns("Reference#").Visible = False
                    DataGridView2.Columns("DateUpdated").Visible = False

                    DataGridView2.Columns("DateDelivered").Visible = False

                    ' Hide the label if there are items to display
                    lblNoItems.Visible = False
                Else
                    ' No items found, display a message in a label
                    lblNoItems.Text = "No out-of-stock items today."
                    lblNoItems.Visible = True

                    ' Clear the DataGridView
                    DataGridView2.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading expired items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Main.Enabled = True
        Me.Close()
        Main.Show()
    End Sub
End Class
