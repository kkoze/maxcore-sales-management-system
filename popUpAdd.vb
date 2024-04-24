Imports MySql.Data.MySqlClient
Imports System.Windows

Public Class popUpAdd
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=dbmaxcore;Connect Timeout=60;pooling=true")
    'Private Sub popUpAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Timer1.Enabled = True
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Dim bfalse = True
    '    Label1.Text = Integer.Parse(Label1.Text) + 1
    '    Guna2CircleProgressBar1.Maximum = 10
    '    Guna2CircleProgressBar1.Value = Integer.Parse(Label1.Text) * 0.7
    '    If Guna2CircleProgressBar1.Value = 10 Then
    '        Label2.Visible = True
    '    End If

    '    If Integer.Parse(Label1.Text) = 5 Then

    '        Dim cmd As New MySqlCommand("SELECT * FROM `inventory`", con)
    '        Dim msadap As New MySqlDataAdapter(cmd)
    '        Dim dt As New DataTable
    '        dt.Clear()
    '        msadap.Fill(dt)
    '        Dim dset = New DataSet
    '        dt.Columns.Remove("Id")
    '        ProdMng.DataGridView3.DataSource = dt
    '        ProdMng.DataGridView3.ClearSelection()
    '    ElseIf Integer.Parse(Label1.Text) = 60 Then
    '        ProdMng.txtsearch3.Enabled = True
    '        ProdMng.DataGridView3.Enabled = True
    '        'ProdMng.txtitemname2.Text = ""
    '        'ProdMng.txtprice2.Text = ""
    '        'ProdMng.txtquantity2.Text = ""
    '        'ProdMng.txtbarcode2.Text = ""
    '        'ProdMng.cboCategory.Text = ""
    '        'ProdMng.txtsearch3.Text = ". . . Search . . ."
    '        'ProdMng.tralse.Text = "1"
    '        'ProdMng.btnupdate.Enabled = False
    '        'ProdMng.txtbarcode2.Enabled = False
    '        ''txtitemname2.Enabled = False
    '        'ProdMng.txtquantity2.Enabled = False
    '        'ProdMng.cboCategory.Enabled = False
    '        'ProdMng.txtprice2.Enabled = False
    '        'ProdMng.btnsavenew.Enabled = True
    '        ProdMng.DataGridView3.ClearSelection()
    '        Me.Close()
    '    End If
    'End Sub
End Class