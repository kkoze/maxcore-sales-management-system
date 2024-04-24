Imports MySql.Data.MySqlClient
Public Class productList
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Dim dt As New DataTable
    Public Sub productFunction()
        DataGridView1.ClearSelection()
        Dim cmd As New MySqlCommand("SELECT * FROM `inventory`", con)
        Dim msadap As New MySqlDataAdapter(cmd)
        dt.Clear()
        msadap.Fill(dt)

        DataGridView1.DataSource = dt

        ' Set the visibility of specific columns
        DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("SupplierID").Visible = False
        DataGridView1.Columns("Supplier").Visible = False
        DataGridView1.Columns("SupplierContact").Visible = False
        DataGridView1.Columns("Description").Visible = False
        DataGridView1.Columns("Dosage").Visible = False
        DataGridView1.Columns("StorageCondition").Visible = False
        DataGridView1.Columns("RegulatoryInformation").Visible = False
        DataGridView1.Columns("totalcost").Visible = False
        DataGridView1.Columns("ItemImg").Visible = False
        DataGridView1.Columns("DateDelivered").Visible = False
        DataGridView1.Columns("ExpiryDate").Visible = False
        DataGridView1.Columns("Reference#").Visible = False
        DataGridView1.Columns("DateUpdated").Visible = False

        If dt.Rows.Count > 0 Then
            DataGridView1.ClearSelection()
        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedBarcode As String = DataGridView1.Rows(e.RowIndex).Cells("barcode").Value.ToString()
            Dim salesOrderForm As SalesOrderMng = TryCast(Application.OpenForms("SalesOrderMng"), SalesOrderMng)
            If salesOrderForm IsNot Nothing Then
                salesOrderForm.txtSearchCode.Text = selectedBarcode
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ControlExit_Click(sender As Object, e As EventArgs) Handles ControlExit.Click
        Me.Close()
    End Sub
End Class