<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesOrderMng
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnPay = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.lbltotalPrice = New System.Windows.Forms.Label()
        Me.dtgSales = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTax = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtCCash = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTax = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtChange = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnItemSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dates = New System.Windows.Forms.Label()
        Me.empname = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtSearchCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCRef = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2VSeparator2 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNewCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearchC = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dtgSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnPay
        '
        Me.btnPay.Animated = True
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPay.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.Black
        Me.btnPay.Location = New System.Drawing.Point(1080, 620)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(449, 43)
        Me.btnPay.TabIndex = 6
        Me.btnPay.Text = "PAY"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.White
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.DarkTurquoise
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-56, 4)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(572, 86)
        Me.Guna2Shapes1.TabIndex = 11
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.UseTransparentBackground = True
        Me.Guna2Shapes1.Zoom = 80
        '
        'lbltotalPrice
        '
        Me.lbltotalPrice.AutoSize = True
        Me.lbltotalPrice.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lbltotalPrice.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbltotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbltotalPrice.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalPrice.Location = New System.Drawing.Point(381, 16)
        Me.lbltotalPrice.Name = "lbltotalPrice"
        Me.lbltotalPrice.Size = New System.Drawing.Size(64, 50)
        Me.lbltotalPrice.TabIndex = 13
        Me.lbltotalPrice.Text = "00"
        Me.lbltotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtgSales
        '
        Me.dtgSales.AllowUserToAddRows = False
        Me.dtgSales.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dtgSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgSales.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dtgSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgSales.ColumnHeadersHeight = 40
        Me.dtgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgSales.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgSales.GridColor = System.Drawing.Color.DarkTurquoise
        Me.dtgSales.Location = New System.Drawing.Point(12, 181)
        Me.dtgSales.Name = "dtgSales"
        Me.dtgSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSales.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgSales.RowHeadersVisible = False
        Me.dtgSales.Size = New System.Drawing.Size(1062, 601)
        Me.dtgSales.TabIndex = 18
        Me.dtgSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgSales.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgSales.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtgSales.ThemeStyle.GridColor = System.Drawing.Color.DarkTurquoise
        Me.dtgSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgSales.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgSales.ThemeStyle.HeaderStyle.Height = 40
        Me.dtgSales.ThemeStyle.ReadOnly = False
        Me.dtgSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgSales.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgSales.ThemeStyle.RowsStyle.Height = 22
        Me.dtgSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboTax)
        Me.GroupBox1.Controls.Add(Me.txtCCash)
        Me.GroupBox1.Controls.Add(Me.txtSTotal)
        Me.GroupBox1.Controls.Add(Me.txtTax)
        Me.GroupBox1.Controls.Add(Me.txtChange)
        Me.GroupBox1.Controls.Add(Me.txtTqty)
        Me.GroupBox1.Controls.Add(Me.lbltotalPrice)
        Me.GroupBox1.Controls.Add(Me.Guna2Shapes1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1080, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 477)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSACTION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 413)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Change :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 32)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Transaction " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "TAX :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Subtotal :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Number of Items :"
        '
        'cboTax
        '
        Me.cboTax.BackColor = System.Drawing.Color.Transparent
        Me.cboTax.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTax.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTax.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboTax.ItemHeight = 30
        Me.cboTax.Location = New System.Drawing.Point(301, 228)
        Me.cboTax.Name = "cboTax"
        Me.cboTax.Size = New System.Drawing.Size(141, 36)
        Me.cboTax.TabIndex = 19
        '
        'txtCCash
        '
        Me.txtCCash.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCCash.DefaultText = ""
        Me.txtCCash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCCash.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCCash.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCCash.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCash.ForeColor = System.Drawing.Color.Black
        Me.txtCCash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCCash.Location = New System.Drawing.Point(132, 322)
        Me.txtCCash.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCCash.Name = "txtCCash"
        Me.txtCCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCCash.PlaceholderText = ""
        Me.txtCCash.SelectedText = ""
        Me.txtCCash.Size = New System.Drawing.Size(310, 36)
        Me.txtCCash.TabIndex = 18
        Me.txtCCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSTotal
        '
        Me.txtSTotal.BorderColor = System.Drawing.Color.White
        Me.txtSTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSTotal.DefaultText = ""
        Me.txtSTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTotal.ForeColor = System.Drawing.Color.Black
        Me.txtSTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSTotal.Location = New System.Drawing.Point(132, 155)
        Me.txtSTotal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSTotal.Name = "txtSTotal"
        Me.txtSTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSTotal.PlaceholderText = ""
        Me.txtSTotal.ReadOnly = True
        Me.txtSTotal.SelectedText = ""
        Me.txtSTotal.Size = New System.Drawing.Size(310, 36)
        Me.txtSTotal.TabIndex = 17
        Me.txtSTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.BorderColor = System.Drawing.Color.White
        Me.txtTax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTax.DefaultText = ""
        Me.txtTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTax.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.ForeColor = System.Drawing.Color.Black
        Me.txtTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTax.Location = New System.Drawing.Point(132, 228)
        Me.txtTax.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTax.PlaceholderText = ""
        Me.txtTax.ReadOnly = True
        Me.txtTax.SelectedText = ""
        Me.txtTax.Size = New System.Drawing.Size(163, 36)
        Me.txtTax.TabIndex = 16
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChange
        '
        Me.txtChange.BorderColor = System.Drawing.Color.White
        Me.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChange.DefaultText = ""
        Me.txtChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.Location = New System.Drawing.Point(132, 413)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChange.PlaceholderText = ""
        Me.txtChange.ReadOnly = True
        Me.txtChange.SelectedText = ""
        Me.txtChange.Size = New System.Drawing.Size(310, 36)
        Me.txtChange.TabIndex = 15
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTqty
        '
        Me.txtTqty.BorderColor = System.Drawing.Color.White
        Me.txtTqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTqty.DefaultText = ""
        Me.txtTqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTqty.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTqty.ForeColor = System.Drawing.Color.Black
        Me.txtTqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTqty.Location = New System.Drawing.Point(343, 96)
        Me.txtTqty.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTqty.Name = "txtTqty"
        Me.txtTqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTqty.PlaceholderText = ""
        Me.txtTqty.ReadOnly = True
        Me.txtTqty.SelectedText = ""
        Me.txtTqty.Size = New System.Drawing.Size(99, 36)
        Me.txtTqty.TabIndex = 14
        Me.txtTqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Animated = True
        Me.btnItemSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnItemSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnItemSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnItemSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnItemSearch.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnItemSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnItemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnItemSearch.Location = New System.Drawing.Point(816, 137)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(256, 36)
        Me.btnItemSearch.TabIndex = 22
        Me.btnItemSearch.Text = "PRODUCT LIST"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SALES ORDER MANAGEMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label2.Location = New System.Drawing.Point(177, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Welcome Sales!"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.DarkTurquoise
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(279, 6)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(8, 68)
        Me.Guna2VSeparator1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label3.Location = New System.Drawing.Point(293, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "USER :"
        '
        'dates
        '
        Me.dates.AutoSize = True
        Me.dates.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dates.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.dates.Location = New System.Drawing.Point(293, 46)
        Me.dates.Name = "dates"
        Me.dates.Size = New System.Drawing.Size(63, 17)
        Me.dates.TabIndex = 28
        Me.dates.Text = "Datetime"
        '
        'empname
        '
        Me.empname.AutoSize = True
        Me.empname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empname.ForeColor = System.Drawing.Color.Black
        Me.empname.Location = New System.Drawing.Point(345, 9)
        Me.empname.Name = "empname"
        Me.empname.Size = New System.Drawing.Size(51, 20)
        Me.empname.TabIndex = 29
        Me.empname.Text = "USER :"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.DarkTurquoise
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 80)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1060, 10)
        Me.Guna2Separator1.TabIndex = 30
        '
        'Timer1
        '
        '
        'txtSearchCode
        '
        Me.txtSearchCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCode.DefaultText = ""
        Me.txtSearchCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchCode.ForeColor = System.Drawing.Color.Black
        Me.txtSearchCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchCode.Location = New System.Drawing.Point(12, 137)
        Me.txtSearchCode.Name = "txtSearchCode"
        Me.txtSearchCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCode.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtSearchCode.PlaceholderText = "ENTER BARCODE"
        Me.txtSearchCode.SelectedText = ""
        Me.txtSearchCode.Size = New System.Drawing.Size(798, 36)
        Me.txtSearchCode.TabIndex = 31
        '
        'txtCRef
        '
        Me.txtCRef.BackColor = System.Drawing.Color.DarkGray
        Me.txtCRef.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCRef.DefaultText = ""
        Me.txtCRef.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCRef.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCRef.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRef.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRef.FillColor = System.Drawing.Color.LightGray
        Me.txtCRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRef.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCRef.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRef.Location = New System.Drawing.Point(1080, 95)
        Me.txtCRef.Name = "txtCRef"
        Me.txtCRef.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCRef.PlaceholderText = ""
        Me.txtCRef.SelectedText = ""
        Me.txtCRef.Size = New System.Drawing.Size(445, 36)
        Me.txtCRef.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1080, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Reference#"
        '
        'Guna2VSeparator2
        '
        Me.Guna2VSeparator2.FillColor = System.Drawing.Color.DarkTurquoise
        Me.Guna2VSeparator2.Location = New System.Drawing.Point(1066, 6)
        Me.Guna2VSeparator2.Name = "Guna2VSeparator2"
        Me.Guna2VSeparator2.Size = New System.Drawing.Size(8, 68)
        Me.Guna2VSeparator2.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1080, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Customer :"
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.DarkGray
        Me.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomer.DefaultText = ""
        Me.txtCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.FillColor = System.Drawing.Color.LightGray
        Me.txtCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Location = New System.Drawing.Point(1080, 37)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomer.PlaceholderText = ""
        Me.txtCustomer.SelectedText = ""
        Me.txtCustomer.Size = New System.Drawing.Size(445, 36)
        Me.txtCustomer.TabIndex = 35
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Animated = True
        Me.btnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewCustomer.FillColor = System.Drawing.Color.PaleTurquoise
        Me.btnNewCustomer.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnNewCustomer.Location = New System.Drawing.Point(1078, 669)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(225, 70)
        Me.btnNewCustomer.TabIndex = 37
        Me.btnNewCustomer.Text = "NEW"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.PaleTurquoise
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Location = New System.Drawing.Point(1309, 669)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(220, 70)
        Me.Guna2Button3.TabIndex = 39
        Me.Guna2Button3.Text = "EXIT"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.MAXCORE_removebg_preview
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 6)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(69, 68)
        Me.Guna2Panel2.TabIndex = 23
        '
        'txtSearchC
        '
        Me.txtSearchC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchC.DefaultText = ""
        Me.txtSearchC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchC.ForeColor = System.Drawing.Color.Black
        Me.txtSearchC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchC.Location = New System.Drawing.Point(12, 95)
        Me.txtSearchC.Name = "txtSearchC"
        Me.txtSearchC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchC.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtSearchC.PlaceholderText = "ENTER CUSTOMER REFERENCE"
        Me.txtSearchC.SelectedText = ""
        Me.txtSearchC.Size = New System.Drawing.Size(275, 36)
        Me.txtSearchC.TabIndex = 40
        '
        'SalesOrderMng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1541, 827)
        Me.Controls.Add(Me.txtSearchC)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.Guna2VSeparator2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCRef)
        Me.Controls.Add(Me.txtSearchCode)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.empname)
        Me.Controls.Add(Me.dates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.btnItemSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesOrderMng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.dtgSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtgSales As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lbltotalPrice As Label
    Friend WithEvents btnItemSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents empname As Label
    Friend WithEvents dates As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtSearchCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2VSeparator2 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCRef As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtChange As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cboTax As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtCCash As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTax As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchC As Guna.UI2.WinForms.Guna2TextBox
End Class
