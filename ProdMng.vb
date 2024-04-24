Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports System.IO
Imports System.Drawing.Drawing2D
Imports Org.BouncyCastle.Bcpg.OpenPgp

Public Class ProdMng
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    Public dateform4and3 As String
    Public overnum As Integer
    Public lblblb As Integer
    Public lblblb2 As Integer
    ' Declare dt at the class level
    Dim dt As New DataTable

    Public Sub ProdMngmentFunction()
        DataGridView3.ClearSelection()
        Dim cmd As New MySqlCommand("SELECT * FROM `inventory`", con)
        Dim msadap As New MySqlDataAdapter(cmd)
        dt.Clear()
        msadap.Fill(dt)

        DataGridView3.DataSource = dt
        DataGridView3.Columns("id").Visible = False
        DataGridView3.Columns("SupplierID").Visible = False
        DataGridView3.Columns("Supplier").Visible = False
        DataGridView3.Columns("SupplierContact").Visible = False
        DataGridView3.Columns("Description").Visible = False
        DataGridView3.Columns("Dosage").Visible = False
        DataGridView3.Columns("StorageCondition").Visible = False
        DataGridView3.Columns("RegulatoryInformation").Visible = False
        DataGridView3.Columns("totalcost").Visible = False
        DataGridView3.Columns("ItemImg").Visible = False
        DataGridView3.Columns("DateDelivered").Visible = False
        DataGridView3.Columns("ExpiryDate").Visible = False
        DataGridView3.Columns("Reference#").Visible = False
        DataGridView3.Columns("DateUpdated").Visible = False

        If dt.Rows.Count > 0 Then
            DataGridView3.ClearSelection()
        End If
    End Sub

    Private Sub txtsearch3_MouseDown(sender As Object, e As MouseEventArgs) Handles txtsearch3.MouseDown
        DataGridView3.ClearSelection()
        If txtsearch3.Text = ". . . Search . . ." Then
            txtsearch3.Text = ""
            txtsearch3.ForeColor = Color.DarkOrange()
            DataGridView3.ClearSelection()
        End If

        Dim selectionStart As Integer = txtsearch3.SelectionStart
        Dim selectionLength As Integer = txtsearch3.SelectionLength

        ' Convert the input text to lowercase
        txtsearch3.Text = txtsearch3.Text.ToLower()

        ' Set the selection to the previous position
        txtsearch3.SelectionStart = selectionStart
        txtsearch3.SelectionLength = selectionLength
    End Sub

    Private Sub txtsearch3_TextChanged(sender As Object, e As EventArgs) Handles txtsearch3.TextChanged
        Dim searchTerm As String = txtsearch3.Text.ToLower()

        ' Filter rows based on multiple columns containing the search term
        Dim matchedRows() As DataRow = (From row In dt.AsEnumerable()
                                        Where row.Field(Of String)("barcode").ToLower().Contains(searchTerm) Or
                                          row.Field(Of String)("Brand Name").ToLower().Contains(searchTerm) Or
                                          row.Field(Of String)("Generic Name").ToLower().Contains(searchTerm) Or
                                          row.Field(Of String)("Medicine Category").ToLower().Contains(searchTerm)
                                        Select row).ToArray()

        Dim matchedDt As DataTable = dt.Clone()
        ' Import matched row to the cloned DataTable
        For Each matchedRow In matchedRows
            matchedDt.ImportRow(matchedRow)
        Next

        ' Set the filtered DataTable as the DataSource for the DataGridView
        DataGridView3.DataSource = matchedDt

        If matchedDt.Rows.Count > 0 Then
            ' Highlight the entire row with darkseagreen color
            DataGridView3.Rows(0).DefaultCellStyle.BackColor = Color.DarkSeaGreen
        End If
    End Sub
    Private Sub ShowPharmaceuticalsForm(selectedRow As DataGridViewRow)
        ' Check if a valid row is clicked (not header or empty row)
        If selectedRow.Index >= 0 AndAlso selectedRow.Index < DataGridView3.Rows.Count Then
            ' Extract the value from the textboxes
            Dim brandName As String = selectedRow.Cells("Brand Name").Value.ToString()
            Dim barcode As String = selectedRow.Cells("barcode").Value.ToString()
            Dim vol As String = selectedRow.Cells("Volume").Value.ToString()
            Dim manf As String = selectedRow.Cells("Manufacturer").Value.ToString()
            Dim price As String = selectedRow.Cells("CostPerUnit").Value.ToString()
            Dim qty As String = selectedRow.Cells("Stock").Value.ToString()
            Dim batchn As String = selectedRow.Cells("batch#").Value.ToString()
            Dim presc As String = selectedRow.Cells("Description").Value.ToString()
            Dim FDA As String = selectedRow.Cells("RegulatoryInformation").Value.ToString()
            Dim suppN As String = selectedRow.Cells("Supplier").Value.ToString()
            Dim suppId As String = selectedRow.Cells("SupplierID").Value.ToString()
            Dim suppCn As String = selectedRow.Cells("SupplierContact").Value.ToString()
            Dim GenN As String = selectedRow.Cells("Generic Name").Value.ToString()
            Dim Mtype As String = selectedRow.Cells("Medicine Type").Value.ToString()
            Dim MCategory As String = selectedRow.Cells("Medicine Category").Value.ToString()
            Dim StorageCond As String = selectedRow.Cells("StorageCondition").Value.ToString()
            Dim dosage As String = selectedRow.Cells("Dosage").Value.ToString()
            Dim ExDate As String = selectedRow.Cells("ExpiryDate").Value.ToString()
            Dim DelDate As String = selectedRow.Cells("DateDelivered").Value.ToString()
            Dim userImg As Byte() = DirectCast(selectedRow.Cells("ItemImg").Value, Byte())
            Dim Itemtype As String = selectedRow.Cells("ItemType").Value.ToString()
            Dim address As String = selectedRow.Cells("SupplierAddress").Value.ToString()
            Dim voltype As String = selectedRow.Cells("VolType").Value.ToString()
            ' Create an instance of the popAddMedItem form
            Dim popAddMedItemForm As New popAddMedItem()

            ' Set properties of popAddMedItemForm
            popAddMedItemForm.txtName.Text = brandName
            popAddMedItemForm.txtbarcode.Text = barcode
            popAddMedItemForm.txtVolume.Text = vol
            popAddMedItemForm.txtManufacturer.Text = manf
            popAddMedItemForm.txtPrice.Text = price
            popAddMedItemForm.txtStock.Text = qty
            popAddMedItemForm.txtBatch.Text = batchn
            popAddMedItemForm.txtSupplier.Text = suppN
            popAddMedItemForm.txtSuppId.Text = suppId
            popAddMedItemForm.txtSuppCont.Text = suppCn
            popAddMedItemForm.cboGeneric.Text = GenN
            popAddMedItemForm.cboMCategory.Text = MCategory
            popAddMedItemForm.cboMType.Text = Mtype
            popAddMedItemForm.cboSCond.Text = StorageCond
            popAddMedItemForm.txtDosage.Text = dosage
            popAddMedItemForm.txtItype.Text = Itemtype
            popAddMedItemForm.txtAddress.Text = address
            popAddMedItemForm.cboVol.Text = voltype

            Dim parsedExDate As DateTime
            If DateTime.TryParse(ExDate, parsedExDate) Then
                ' Successfully parsed, you can now use parsedExDate as a DateTime
                Dim formattedExDate As String = parsedExDate.ToString("yyyy-MM-dd")
                popAddMedItemForm.txtDate.Text = parsedExDate.ToString("yyyy-MM-dd")
                Dim parsedDelDate As DateTime
                If DateTime.TryParse(DelDate, parsedDelDate) Then
                    ' Successfully parsed, you can now use parsedDelDate as a DateTime
                    Dim formattedDelDate As String = parsedDelDate.ToString("yyyy-MM-dd HH:mm:ss")
                    popAddMedItemForm.txtdateDeliver.Text = parsedDelDate.ToString("yyyy-MM-dd HH:mm:ss")
                Else
                    ' Handle the case when DelDate is not in a valid format
                End If
            Else
                ' Handle the case when ExDate is not in a valid format
            End If

            popAddMedItemForm.btnBarcode.Enabled = False
            popAddMedItemForm.txtbarcode.Enabled = False
            Main.Enabled = False
            popAddMedItemForm.txtDate.Enabled = False
            popAddMedItemForm.txtdateDeliver.Enabled = False
            popAddMedItemForm.btnDate.Visible = False
            popAddMedItemForm.btnDeliver.Visible = False
            popAddMedItemForm.btnadd.Visible = False
            popAddMedItemForm.btnNewItem.Visible = True
            popAddMedItemForm.txtStock.Enabled = False

            If userImg IsNot Nothing AndAlso userImg.Length > 0 Then
                Dim ms As New MemoryStream(userImg)
                popAddMedItemForm.uploadImg.Image = Image.FromStream(ms)
            End If

            If String.Equals(FDA, "FDA Certified", StringComparison.OrdinalIgnoreCase) Then
                popAddMedItemForm.btnFda.Checked = True
            Else
                popAddMedItemForm.btnFda.Checked = False
            End If

            If String.Equals(presc, "Prescripted Medicine", StringComparison.OrdinalIgnoreCase) Then
                popAddMedItemForm.btnPM.Checked = True
            Else
                popAddMedItemForm.btnPM.Checked = False
            End If

            popAddMedItemForm.ShowDialog()
        End If
    End Sub


    Private Sub ShowMerchandiseForm(selectedRow As DataGridViewRow)
        ' Create an instance of the popAddMerchItem form (replace with your actual form name)

        If selectedRow.Index >= 0 AndAlso selectedRow.Index < DataGridView3.Rows.Count Then
            Dim popAddMerchItemForm As New popAddMerchItem()
            ' Extract the value from the textboxes
            Dim brandName As String = selectedRow.Cells("Brand Name").Value.ToString()
            Dim barcode As String = selectedRow.Cells("barcode").Value.ToString()
            Dim vol As String = selectedRow.Cells("Volume").Value.ToString()
            Dim manf As String = selectedRow.Cells("Manufacturer").Value.ToString()
            Dim price As String = selectedRow.Cells("CostPerUnit").Value.ToString()
            Dim qty As String = selectedRow.Cells("Stock").Value.ToString()
            Dim batchn As String = selectedRow.Cells("batch#").Value.ToString()
            Dim presc As String = selectedRow.Cells("Description").Value.ToString()
            Dim FDA As String = selectedRow.Cells("RegulatoryInformation").Value.ToString()
            Dim suppN As String = selectedRow.Cells("Supplier").Value.ToString()
            Dim suppId As String = selectedRow.Cells("SupplierID").Value.ToString()
            Dim suppCn As String = selectedRow.Cells("SupplierContact").Value.ToString()
            Dim GenN As String = selectedRow.Cells("Generic Name").Value.ToString()
            Dim Mtype As String = selectedRow.Cells("MerchType").Value.ToString()
            Dim MCategory As String = selectedRow.Cells("Medicine Category").Value.ToString()
            Dim StorageCond As String = selectedRow.Cells("StorageCondition").Value.ToString()
            Dim dosage As String = selectedRow.Cells("Dosage").Value.ToString()
            Dim ExDate As String = selectedRow.Cells("ExpiryDate").Value.ToString()
            Dim DelDate As String = selectedRow.Cells("DateDelivered").Value.ToString()
            Dim userImg As Byte() = DirectCast(selectedRow.Cells("ItemImg").Value, Byte())
            Dim Itemtype As String = selectedRow.Cells("ItemType").Value.ToString()
            Dim address As String = selectedRow.Cells("SupplierAddress").Value.ToString()
            Dim voltype As String = selectedRow.Cells("VolType").Value.ToString()

            ' Set properties of popAddMedItemForm
            popAddMerchItemForm.txtName.Text = brandName
            popAddMerchItemForm.txtbarcode.Text = barcode
            popAddMerchItemForm.txtVolume.Text = vol
            popAddMerchItemForm.txtManufacturer.Text = manf
            popAddMerchItemForm.txtPrice.Text = price
            popAddMerchItemForm.txtStock.Text = qty
            popAddMerchItemForm.txtBatch.Text = batchn
            popAddMerchItemForm.txtSupplier.Text = suppN
            popAddMerchItemForm.txtSuppId.Text = suppId
            popAddMerchItemForm.txtSuppCont.Text = suppCn
            popAddMerchItemForm.txtAddress.Text = address
            popAddMerchItemForm.cboSCond.Text = StorageCond
            popAddMerchItemForm.cboMType.Text = Mtype
            popAddMerchItemForm.txtItype.Text = Itemtype
            popAddMerchItemForm.cboVol.Text = voltype

            Dim parsedExDate As DateTime
            If DateTime.TryParse(ExDate, parsedExDate) Then
                ' Successfully parsed, you can now use parsedExDate as a DateTime
                Dim formattedExDate As String = parsedExDate.ToString("yyyy-MM-dd")
                ' ...
                popAddMerchItemForm.txtDate.Text = parsedExDate.ToString("yyyy-MM-dd")
                Dim parsedDelDate As DateTime
                If DateTime.TryParse(DelDate, parsedDelDate) Then
                    ' Successfully parsed, you can now use parsedDelDate as a DateTime
                    Dim formattedDelDate As String = parsedDelDate.ToString("yyyy-MM-dd HH:mm:ss")
                    ' ...
                    popAddMerchItemForm.txtdateDeliver.Text = parsedDelDate.ToString("yyyy-MM-dd HH:mm:ss")
                Else
                    ' Handle the case when DelDate is not in a valid format
                End If
            Else
                ' Handle the case when ExDate is not in a valid format
            End If

            ' Assuming you have TextBox controls named txtExDate and txtDelDate in popAddMedItemForm
            popAddMerchItemForm.btnBarcode.Enabled = False
            popAddMerchItemForm.txtbarcode.Enabled = False
            Main.Enabled = False
            popAddMerchItemForm.txtDate.Enabled = False
            popAddMerchItemForm.txtdateDeliver.Enabled = False
            popAddMerchItemForm.btnDate.Visible = False
            popAddMerchItemForm.btnDeliver.Visible = False
            popAddMerchItemForm.btnadd.Visible = False
            popAddMerchItemForm.btnNewItem.Visible = True
            popAddMerchItemForm.txtStock.Enabled = False

            If userImg IsNot Nothing AndAlso userImg.Length > 0 Then
                Dim ms As New MemoryStream(userImg)
                popAddMerchItemForm.uploadImg.Image = Image.FromStream(ms)
            End If

            If String.Equals(FDA, "FDA Certified", StringComparison.OrdinalIgnoreCase) Then
                popAddMerchItemForm.btnFda.Checked = True
            Else
                popAddMerchItemForm.btnFda.Checked = False
            End If



            popAddMerchItemForm.ShowDialog()
        End If

    End Sub
    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        ' Check if a valid row is clicked (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView3.Rows.Count Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView3.Rows(e.RowIndex)

            ' Extract the value from the "ItemType" column
            Dim itemType As String = selectedRow.Cells("ItemType").Value.ToString()

            ' Check the value of "ItemType" and show the appropriate form
            If String.Equals(itemType, "Pharmaceuticals and Medications", StringComparison.OrdinalIgnoreCase) Then
                ShowPharmaceuticalsForm(selectedRow)
            Else
                ShowMerchandiseForm(selectedRow)
            End If
        End If
    End Sub

    Private Sub btnAddItems_Click(sender As Object, e As EventArgs) Handles btnAddItems.Click
        popAdd.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Maintenance.Show()
        Main.Enabled = False
    End Sub
End Class