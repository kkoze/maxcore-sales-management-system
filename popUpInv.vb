Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Text
Imports Org.BouncyCastle.Utilities.Collections
Imports System.Windows.Forms
Imports System.Diagnostics
Public Class popUpInv
    Dim con As New MySqlConnection("server=db4free.net;port=3306;username=maxcoresms;password=maxcore$;database=dbmaxcore;Connect Timeout=60;pooling=true")

    Private Sub btnConfirmNo_Click(sender As Object, e As EventArgs) Handles btnConfirmNo.Click
        ProdMng.txtnum.Enabled = True
        ProdMng.cboCategory.Enabled = True
        ProdMng.txtprice2.Enabled = True
        ProdMng.txtbarcode2.Enabled = True
        ProdMng.txtitemname2.Enabled = True
        ProdMng.txtquantity2.Enabled = True
        ProdMng.Enabled = True
        ProdMng.txtsearch3.Text = ". . . Search . . ."
        ProdMng.btnsavenew.Text = "Date"
        ProdMng.btndelete.Text = "Cancel"
        ProdMng.lblblb = 3
        ProdMng.lblblb2 = 3
        ProdMng.overnum = 1
        Me.Hide()
    End Sub

    Private Sub btnConfirmYes_Click(sender As Object, e As EventArgs) Handles btnConfirmYes.Click

        Dim cmd As New MySqlCommand("SELECT * FROM `inventory` WHERE itemname='" + ProdMng.txtitemname2.Text + "'and Barcode ='" + ProdMng.txtbarcode2.Text + "'", con)
        Dim msadap As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        msadap.Fill(dt)
        If dt.Rows.Count > 0 Then
            If String.IsNullOrEmpty(ProdMng.txtquantity2.Text) Then

            Else
                Dim selectCmd As New MySqlCommand("SELECT * FROM `inventory` WHERE itemname='" + ProdMng.txtitemname2.Text + "'", con)
                Dim selectmsdap As New MySqlDataAdapter(selectCmd)
                Dim selectdt As New DataTable
                selectdt.Clear()
                selectmsdap.Fill(selectdt)


                If selectdt.Rows.Count > 0 Then

                    ProdMng.cboCategory.Text = selectdt.Rows(0)("Category")
                    ProdMng.txtbarcode2.Text = selectdt.Rows(0)("Barcode")
                    ProdMng.txtprice2.Text = selectdt.Rows(0)("price")
                End If
                Dim updatedQuantinty = Integer.Parse(dt.Rows(0)("stock")) + Integer.Parse(ProdMng.txtquantity2.Text)
                ProdMng.cboCategory.Enabled = False
                ProdMng.txtprice2.Enabled = False
                ProdMng.txtbarcode2.Enabled = False
                ProdMng.txtitemname2.Enabled = False
                ProdMng.btnsavenew.Text = "Add"
                ProdMng.btndelete.Text = "Delete"
                ProdMng.btnupdate.Enabled = True
                ProdMng.btndelete.Enabled = False
                ProdMng.lblblb = 4
                ProdMng.lblblb2 = 4
                ProdMng.overnum = 2
                ProdMng.btnsavenew.Enabled = False
                ProdMng.DataGridView3.Enabled = False
                ProdMng.Enabled = True
                ProdMng.Hide()
            End If

        End If
        Me.Hide()
    End Sub

End Class