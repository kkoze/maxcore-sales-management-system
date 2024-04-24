<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popAddMerchItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboSCond = New System.Windows.Forms.ComboBox()
        Me.cboMType = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBatch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFda = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnBarcode = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeliver = New Guna.UI2.WinForms.Guna2Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnDate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNewType = New Guna.UI2.WinForms.Guna2Button()
        Me.txtVolume = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblvol = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnadd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSc = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItype = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSuppId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSuppCont = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtdateDeliver = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnUploadImg = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtStock = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSupplier = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtManufacturer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbarcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.uploadImg = New System.Windows.Forms.PictureBox()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnNewItem = New Guna.UI2.WinForms.Guna2Button()
        Me.cboVol = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uploadImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSCond
        '
        Me.cboSCond.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSCond.FormattingEnabled = True
        Me.cboSCond.ItemHeight = 20
        Me.cboSCond.Location = New System.Drawing.Point(931, 210)
        Me.cboSCond.Name = "cboSCond"
        Me.cboSCond.Size = New System.Drawing.Size(333, 28)
        Me.cboSCond.TabIndex = 138
        '
        'cboMType
        '
        Me.cboMType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboMType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboMType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMType.FormattingEnabled = True
        Me.cboMType.ItemHeight = 20
        Me.cboMType.Location = New System.Drawing.Point(503, 135)
        Me.cboMType.Name = "cboMType"
        Me.cboMType.Size = New System.Drawing.Size(393, 28)
        Me.cboMType.TabIndex = 136
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(712, 506)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 16)
        Me.Label16.TabIndex = 131
        Me.Label16.Text = "CONTACT#"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(27, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 16)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "PRODUCT INFORMATION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(470, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(467, 503)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 16)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "ID"
        '
        'txtBatch
        '
        Me.txtBatch.Animated = True
        Me.txtBatch.AutoRoundedCorners = True
        Me.txtBatch.BackColor = System.Drawing.Color.Transparent
        Me.txtBatch.BorderRadius = 17
        Me.txtBatch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBatch.DefaultText = ""
        Me.txtBatch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBatch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBatch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBatch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBatch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBatch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatch.ForeColor = System.Drawing.Color.Black
        Me.txtBatch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBatch.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBatch.Location = New System.Drawing.Point(921, 594)
        Me.txtBatch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBatch.PlaceholderText = ""
        Me.txtBatch.SelectedText = ""
        Me.txtBatch.Size = New System.Drawing.Size(201, 37)
        Me.txtBatch.TabIndex = 125
        Me.txtBatch.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(918, 575)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "BATCH#"
        '
        'btnFda
        '
        Me.btnFda.Animated = True
        Me.btnFda.AutoSize = True
        Me.btnFda.BackColor = System.Drawing.Color.Transparent
        Me.btnFda.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.btnFda.CheckedState.BorderRadius = 0
        Me.btnFda.CheckedState.BorderThickness = 0
        Me.btnFda.CheckedState.FillColor = System.Drawing.Color.Gainsboro
        Me.btnFda.CheckMarkColor = System.Drawing.Color.ForestGreen
        Me.btnFda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFda.Location = New System.Drawing.Point(766, 339)
        Me.btnFda.Name = "btnFda"
        Me.btnFda.Size = New System.Drawing.Size(182, 28)
        Me.btnFda.TabIndex = 122
        Me.btnFda.Text = "FDA CERTIFIED"
        Me.btnFda.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.btnFda.UncheckedState.BorderRadius = 0
        Me.btnFda.UncheckedState.BorderThickness = 0
        Me.btnFda.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnFda.UseVisualStyleBackColor = False
        '
        'btnBarcode
        '
        Me.btnBarcode.Animated = True
        Me.btnBarcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBarcode.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBarcode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBarcode.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnBarcode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarcode.ForeColor = System.Drawing.Color.White
        Me.btnBarcode.Location = New System.Drawing.Point(30, 97)
        Me.btnBarcode.Name = "btnBarcode"
        Me.btnBarcode.Size = New System.Drawing.Size(409, 35)
        Me.btnBarcode.TabIndex = 121
        Me.btnBarcode.Text = "GENERATE BARCODE"
        '
        'btnDeliver
        '
        Me.btnDeliver.Animated = True
        Me.btnDeliver.AutoRoundedCorners = True
        Me.btnDeliver.BackColor = System.Drawing.Color.Transparent
        Me.btnDeliver.BorderRadius = 12
        Me.btnDeliver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeliver.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeliver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeliver.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeliver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeliver.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnDeliver.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliver.ForeColor = System.Drawing.Color.White
        Me.btnDeliver.Location = New System.Drawing.Point(1169, 525)
        Me.btnDeliver.Name = "btnDeliver"
        Me.btnDeliver.Size = New System.Drawing.Size(132, 26)
        Me.btnDeliver.TabIndex = 118
        Me.btnDeliver.Text = "CHANGE DATE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(921, 506)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 13)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "DATE DELIVERED"
        '
        'btnDate
        '
        Me.btnDate.Animated = True
        Me.btnDate.AutoRoundedCorners = True
        Me.btnDate.BackColor = System.Drawing.Color.Transparent
        Me.btnDate.BorderRadius = 12
        Me.btnDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDate.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDate.ForeColor = System.Drawing.Color.White
        Me.btnDate.Location = New System.Drawing.Point(1169, 461)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(132, 26)
        Me.btnDate.TabIndex = 116
        Me.btnDate.Text = "CHANGE DATE"
        '
        'btnNewType
        '
        Me.btnNewType.Animated = True
        Me.btnNewType.AutoRoundedCorners = True
        Me.btnNewType.BackColor = System.Drawing.Color.Transparent
        Me.btnNewType.BorderRadius = 17
        Me.btnNewType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewType.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewType.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnNewType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewType.ForeColor = System.Drawing.Color.White
        Me.btnNewType.Location = New System.Drawing.Point(1272, 125)
        Me.btnNewType.Name = "btnNewType"
        Me.btnNewType.Size = New System.Drawing.Size(132, 36)
        Me.btnNewType.TabIndex = 113
        Me.btnNewType.Text = "ADD TYPE"
        Me.btnNewType.Visible = False
        '
        'txtVolume
        '
        Me.txtVolume.Animated = True
        Me.txtVolume.AutoRoundedCorners = True
        Me.txtVolume.BackColor = System.Drawing.Color.Transparent
        Me.txtVolume.BorderRadius = 16
        Me.txtVolume.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVolume.DefaultText = ""
        Me.txtVolume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVolume.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVolume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVolume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVolume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVolume.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.ForeColor = System.Drawing.Color.Black
        Me.txtVolume.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVolume.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtVolume.Location = New System.Drawing.Point(503, 192)
        Me.txtVolume.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVolume.PlaceholderText = ""
        Me.txtVolume.SelectedText = ""
        Me.txtVolume.Size = New System.Drawing.Size(99, 35)
        Me.txtVolume.TabIndex = 109
        Me.txtVolume.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblvol
        '
        Me.lblvol.AutoSize = True
        Me.lblvol.BackColor = System.Drawing.Color.Transparent
        Me.lblvol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvol.Location = New System.Drawing.Point(461, 176)
        Me.lblvol.Name = "lblvol"
        Me.lblvol.Size = New System.Drawing.Size(63, 16)
        Me.lblvol.TabIndex = 110
        Me.lblvol.Text = "VOLUME"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(1444, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(42, 23)
        Me.btnCancel.TabIndex = 108
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Animated = True
        Me.btndelete.AutoRoundedCorners = True
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.BorderRadius = 21
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndelete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(1314, 658)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(180, 45)
        Me.btndelete.TabIndex = 107
        Me.btndelete.Text = "Delete Item"
        '
        'btnupdate
        '
        Me.btnupdate.Animated = True
        Me.btnupdate.AutoRoundedCorners = True
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BorderRadius = 21
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnupdate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(1128, 658)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(180, 45)
        Me.btnupdate.TabIndex = 106
        Me.btnupdate.Text = "Update Item"
        '
        'btnadd
        '
        Me.btnadd.Animated = True
        Me.btnadd.AutoRoundedCorners = True
        Me.btnadd.BackColor = System.Drawing.Color.Transparent
        Me.btnadd.BorderRadius = 21
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnadd.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnadd.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnadd.Location = New System.Drawing.Point(942, 658)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(180, 45)
        Me.btnadd.TabIndex = 105
        Me.btnadd.Text = "Add Item"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.Location = New System.Drawing.Point(459, 387)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(1027, 10)
        Me.Guna2Separator2.TabIndex = 102
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(33, 642)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1461, 10)
        Me.Guna2Separator1.TabIndex = 101
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(921, 431)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "EXPIRY DATE"
        '
        'lblSc
        '
        Me.lblSc.AutoSize = True
        Me.lblSc.BackColor = System.Drawing.Color.Transparent
        Me.lblSc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSc.Location = New System.Drawing.Point(928, 193)
        Me.lblSc.Name = "lblSc"
        Me.lblSc.Size = New System.Drawing.Size(147, 13)
        Me.lblSc.TabIndex = 99
        Me.lblSc.Text = "STORAGE CONDITIONS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(622, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "STOCK"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(471, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 16)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "SUPPLIER INFORMATION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(463, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 16)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "MERCHANDISE TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(463, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "MANUFACTURER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(466, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "COST PER UNIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "PRODUCT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(928, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "ITEM TYPE"
        '
        'txtItype
        '
        Me.txtItype.Animated = True
        Me.txtItype.AutoRoundedCorners = True
        Me.txtItype.BackColor = System.Drawing.Color.Transparent
        Me.txtItype.BorderRadius = 16
        Me.txtItype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItype.DefaultText = ""
        Me.txtItype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItype.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItype.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItype.ForeColor = System.Drawing.Color.Black
        Me.txtItype.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItype.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_ingredients_50
        Me.txtItype.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtItype.Location = New System.Drawing.Point(931, 56)
        Me.txtItype.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtItype.Name = "txtItype"
        Me.txtItype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItype.PlaceholderText = ""
        Me.txtItype.SelectedText = ""
        Me.txtItype.Size = New System.Drawing.Size(437, 35)
        Me.txtItype.TabIndex = 141
        Me.txtItype.TextOffset = New System.Drawing.Point(5, 0)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_category_50
        Me.PictureBox1.Location = New System.Drawing.Point(466, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 140
        Me.PictureBox1.TabStop = False
        '
        'txtSuppId
        '
        Me.txtSuppId.Animated = True
        Me.txtSuppId.AutoRoundedCorners = True
        Me.txtSuppId.BackColor = System.Drawing.Color.Transparent
        Me.txtSuppId.BorderRadius = 19
        Me.txtSuppId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuppId.DefaultText = ""
        Me.txtSuppId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSuppId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSuppId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppId.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppId.ForeColor = System.Drawing.Color.Black
        Me.txtSuppId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppId.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_supplier_50
        Me.txtSuppId.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtSuppId.Location = New System.Drawing.Point(464, 525)
        Me.txtSuppId.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSuppId.Name = "txtSuppId"
        Me.txtSuppId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuppId.PlaceholderText = ""
        Me.txtSuppId.SelectedText = ""
        Me.txtSuppId.Size = New System.Drawing.Size(226, 40)
        Me.txtSuppId.TabIndex = 128
        Me.txtSuppId.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtSuppCont
        '
        Me.txtSuppCont.Animated = True
        Me.txtSuppCont.AutoRoundedCorners = True
        Me.txtSuppCont.BackColor = System.Drawing.Color.Transparent
        Me.txtSuppCont.BorderRadius = 19
        Me.txtSuppCont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuppCont.DefaultText = ""
        Me.txtSuppCont.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSuppCont.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSuppCont.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppCont.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuppCont.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppCont.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppCont.ForeColor = System.Drawing.Color.Black
        Me.txtSuppCont.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuppCont.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_supplier_50
        Me.txtSuppCont.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtSuppCont.Location = New System.Drawing.Point(700, 525)
        Me.txtSuppCont.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSuppCont.Name = "txtSuppCont"
        Me.txtSuppCont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuppCont.PlaceholderText = ""
        Me.txtSuppCont.SelectedText = ""
        Me.txtSuppCont.Size = New System.Drawing.Size(196, 40)
        Me.txtSuppCont.TabIndex = 126
        Me.txtSuppCont.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtdateDeliver
        '
        Me.txtdateDeliver.AutoRoundedCorners = True
        Me.txtdateDeliver.BackColor = System.Drawing.Color.Transparent
        Me.txtdateDeliver.BorderRadius = 14
        Me.txtdateDeliver.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdateDeliver.DefaultText = ""
        Me.txtdateDeliver.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdateDeliver.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdateDeliver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdateDeliver.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdateDeliver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdateDeliver.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdateDeliver.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdateDeliver.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_date_50
        Me.txtdateDeliver.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtdateDeliver.Location = New System.Drawing.Point(921, 525)
        Me.txtdateDeliver.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdateDeliver.Name = "txtdateDeliver"
        Me.txtdateDeliver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdateDeliver.PlaceholderText = ""
        Me.txtdateDeliver.SelectedText = ""
        Me.txtdateDeliver.Size = New System.Drawing.Size(241, 31)
        Me.txtdateDeliver.TabIndex = 120
        Me.txtdateDeliver.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtDate
        '
        Me.txtDate.AutoRoundedCorners = True
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.BorderRadius = 14
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate.DefaultText = ""
        Me.txtDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDate.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_date_50
        Me.txtDate.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtDate.Location = New System.Drawing.Point(921, 461)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDate.PlaceholderText = ""
        Me.txtDate.SelectedText = ""
        Me.txtDate.Size = New System.Drawing.Size(241, 31)
        Me.txtDate.TabIndex = 119
        Me.txtDate.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtNewType
        '
        Me.txtNewType.Animated = True
        Me.txtNewType.AutoRoundedCorners = True
        Me.txtNewType.BackColor = System.Drawing.Color.Transparent
        Me.txtNewType.BorderRadius = 19
        Me.txtNewType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewType.DefaultText = ""
        Me.txtNewType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewType.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewType.ForeColor = System.Drawing.Color.Black
        Me.txtNewType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewType.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_create_1001
        Me.txtNewType.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtNewType.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtNewType.Location = New System.Drawing.Point(931, 125)
        Me.txtNewType.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtNewType.Name = "txtNewType"
        Me.txtNewType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewType.PlaceholderText = ""
        Me.txtNewType.SelectedText = ""
        Me.txtNewType.Size = New System.Drawing.Size(333, 41)
        Me.txtNewType.TabIndex = 112
        Me.txtNewType.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtNewType.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_measuring_cup_24__1_
        Me.PictureBox3.Location = New System.Drawing.Point(464, 192)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 111
        Me.PictureBox3.TabStop = False
        '
        'btnUploadImg
        '
        Me.btnUploadImg.Animated = True
        Me.btnUploadImg.BackColor = System.Drawing.Color.Transparent
        Me.btnUploadImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUploadImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUploadImg.FillColor = System.Drawing.Color.Transparent
        Me.btnUploadImg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUploadImg.ForeColor = System.Drawing.Color.White
        Me.btnUploadImg.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_add_64
        Me.btnUploadImg.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnUploadImg.Location = New System.Drawing.Point(395, 514)
        Me.btnUploadImg.Name = "btnUploadImg"
        Me.btnUploadImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnUploadImg.Size = New System.Drawing.Size(44, 42)
        Me.btnUploadImg.TabIndex = 94
        Me.btnUploadImg.UseTransparentBackground = True
        '
        'txtStock
        '
        Me.txtStock.Animated = True
        Me.txtStock.AutoRoundedCorners = True
        Me.txtStock.BackColor = System.Drawing.Color.Transparent
        Me.txtStock.BorderRadius = 17
        Me.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStock.DefaultText = ""
        Me.txtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.ForeColor = System.Drawing.Color.Black
        Me.txtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStock.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_boxes_30
        Me.txtStock.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtStock.Location = New System.Drawing.Point(625, 339)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStock.PlaceholderText = ""
        Me.txtStock.SelectedText = ""
        Me.txtStock.Size = New System.Drawing.Size(117, 37)
        Me.txtStock.TabIndex = 97
        Me.txtStock.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtSupplier
        '
        Me.txtSupplier.Animated = True
        Me.txtSupplier.AutoRoundedCorners = True
        Me.txtSupplier.BackColor = System.Drawing.Color.Transparent
        Me.txtSupplier.BorderRadius = 19
        Me.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplier.DefaultText = ""
        Me.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplier.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplier.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_supplier_50
        Me.txtSupplier.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtSupplier.Location = New System.Drawing.Point(466, 452)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupplier.PlaceholderText = ""
        Me.txtSupplier.SelectedText = ""
        Me.txtSupplier.Size = New System.Drawing.Size(430, 40)
        Me.txtSupplier.TabIndex = 88
        Me.txtSupplier.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Animated = True
        Me.txtManufacturer.AutoRoundedCorners = True
        Me.txtManufacturer.BackColor = System.Drawing.Color.Transparent
        Me.txtManufacturer.BorderRadius = 18
        Me.txtManufacturer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtManufacturer.DefaultText = ""
        Me.txtManufacturer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtManufacturer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtManufacturer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtManufacturer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtManufacturer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtManufacturer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.ForeColor = System.Drawing.Color.Black
        Me.txtManufacturer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtManufacturer.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_manufacture_50
        Me.txtManufacturer.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtManufacturer.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtManufacturer.Location = New System.Drawing.Point(459, 269)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtManufacturer.PlaceholderText = ""
        Me.txtManufacturer.SelectedText = ""
        Me.txtManufacturer.Size = New System.Drawing.Size(437, 39)
        Me.txtManufacturer.TabIndex = 87
        Me.txtManufacturer.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtPrice
        '
        Me.txtPrice.Animated = True
        Me.txtPrice.AutoRoundedCorners = True
        Me.txtPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtPrice.BorderRadius = 17
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.IconLeft = Global.MAXCORESMS.My.Resources.Resources.peso_sign_solid
        Me.txtPrice.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPrice.IconLeftSize = New System.Drawing.Size(13, 17)
        Me.txtPrice.Location = New System.Drawing.Point(469, 339)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(146, 37)
        Me.txtPrice.TabIndex = 89
        Me.txtPrice.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.AutoRoundedCorners = True
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.BorderRadius = 16
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_ingredients_50
        Me.txtName.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtName.Location = New System.Drawing.Point(459, 54)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(437, 35)
        Me.txtName.TabIndex = 83
        Me.txtName.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtbarcode
        '
        Me.txtbarcode.Animated = True
        Me.txtbarcode.AutoRoundedCorners = True
        Me.txtbarcode.BackColor = System.Drawing.Color.Transparent
        Me.txtbarcode.BorderRadius = 17
        Me.txtbarcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbarcode.DefaultText = ""
        Me.txtbarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbarcode.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarcode.ForeColor = System.Drawing.Color.Black
        Me.txtbarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbarcode.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_barcode_64__1_
        Me.txtbarcode.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtbarcode.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtbarcode.Location = New System.Drawing.Point(29, 55)
        Me.txtbarcode.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbarcode.PlaceholderText = ""
        Me.txtbarcode.SelectedText = ""
        Me.txtbarcode.Size = New System.Drawing.Size(410, 36)
        Me.txtbarcode.TabIndex = 82
        Me.txtbarcode.TextOffset = New System.Drawing.Point(5, 0)
        '
        'uploadImg
        '
        Me.uploadImg.BackColor = System.Drawing.Color.Transparent
        Me.uploadImg.Location = New System.Drawing.Point(30, 135)
        Me.uploadImg.Name = "uploadImg"
        Me.uploadImg.Size = New System.Drawing.Size(409, 421)
        Me.uploadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadImg.TabIndex = 81
        Me.uploadImg.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.Animated = True
        Me.txtAddress.AutoRoundedCorners = True
        Me.txtAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtAddress.BorderRadius = 19
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.IconLeft = Global.MAXCORESMS.My.Resources.Resources.icons8_supplier_50
        Me.txtAddress.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtAddress.Location = New System.Drawing.Point(464, 594)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(432, 40)
        Me.txtAddress.TabIndex = 142
        Me.txtAddress.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(466, 573)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "ADDRESS"
        '
        'btnNewItem
        '
        Me.btnNewItem.Animated = True
        Me.btnNewItem.AutoRoundedCorners = True
        Me.btnNewItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNewItem.BorderRadius = 21
        Me.btnNewItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewItem.FillColor = System.Drawing.Color.DarkGoldenrod
        Me.btnNewItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewItem.ForeColor = System.Drawing.Color.White
        Me.btnNewItem.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewItem.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnNewItem.Location = New System.Drawing.Point(942, 658)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(180, 45)
        Me.btnNewItem.TabIndex = 139
        Me.btnNewItem.Text = "New Item"
        Me.btnNewItem.Visible = False
        '
        'cboVol
        '
        Me.cboVol.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVol.FormattingEnabled = True
        Me.cboVol.Location = New System.Drawing.Point(610, 192)
        Me.cboVol.Name = "cboVol"
        Me.cboVol.Size = New System.Drawing.Size(80, 33)
        Me.cboVol.TabIndex = 144
        '
        'popAddMerchItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1506, 746)
        Me.Controls.Add(Me.cboVol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtItype)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboSCond)
        Me.Controls.Add(Me.cboMType)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSuppId)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSuppCont)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBatch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFda)
        Me.Controls.Add(Me.btnBarcode)
        Me.Controls.Add(Me.txtdateDeliver)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnDeliver)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.btnNewType)
        Me.Controls.Add(Me.txtNewType)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.lblvol)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.btnUploadImg)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblSc)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbarcode)
        Me.Controls.Add(Me.uploadImg)
        Me.Controls.Add(Me.btnNewItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "popAddMerchItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "popAddMerchItem"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uploadImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSCond As ComboBox
    Friend WithEvents cboMType As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSuppId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSuppCont As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBatch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFda As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnBarcode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtdateDeliver As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDeliver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnDate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewType As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNewType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtVolume As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblvol As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnUploadImg As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label13 As Label
    Friend WithEvents lblSc As Label
    Friend WithEvents txtStock As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSupplier As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtManufacturer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbarcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents uploadImg As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtItype As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnNewItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cboVol As ComboBox
End Class
