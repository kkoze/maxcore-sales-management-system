<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Drag = New System.Windows.Forms.Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.ControlExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.txtRole = New System.Windows.Forms.Label()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtName = New System.Windows.Forms.Label()
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.datetime = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.btnOpenAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalesMng = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalesReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInvMng = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProdMng = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.iconpanel = New System.Windows.Forms.Panel()
        Me.logoIco = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logopanel = New System.Windows.Forms.Panel()
        Me.DropDown = New Guna.UI2.WinForms.Guna2Button()
        Me.UserPic = New System.Windows.Forms.PictureBox()
        Me.menuPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.DropDownStrip = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.VIEWPROFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerStatus = New System.Windows.Forms.Timer(Me.components)
        Me.Drag.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.iconpanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logopanel.SuspendLayout()
        CType(Me.UserPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuPanel.SuspendLayout()
        Me.DropDownStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Drag
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Drag
        '
        Me.Drag.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Drag.Controls.Add(Me.Guna2VSeparator1)
        Me.Drag.Controls.Add(Me.Label)
        Me.Drag.Controls.Add(Me.Label2)
        Me.Drag.Controls.Add(Me.Label1)
        Me.Drag.Controls.Add(Me.txtTime)
        Me.Drag.Controls.Add(Me.txtDate)
        Me.Drag.Controls.Add(Me.ControlExit)
        Me.Drag.Dock = System.Windows.Forms.DockStyle.Top
        Me.Drag.Location = New System.Drawing.Point(358, 0)
        Me.Drag.Name = "Drag"
        Me.Drag.Size = New System.Drawing.Size(1093, 46)
        Me.Drag.TabIndex = 3
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(435, 10)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 29)
        Me.Guna2VSeparator1.TabIndex = 11
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(484, 13)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(58, 21)
        Me.Label.TabIndex = 10
        Me.Label.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(196, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Server Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date"
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.Black
        Me.txtTime.Location = New System.Drawing.Point(293, 14)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(42, 20)
        Me.txtTime.TabIndex = 7
        Me.txtTime.Text = "Time"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.Location = New System.Drawing.Point(53, 14)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(41, 20)
        Me.txtDate.TabIndex = 6
        Me.txtDate.Text = "Date"
        '
        'ControlExit
        '
        Me.ControlExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlExit.Animated = True
        Me.ControlExit.BackColor = System.Drawing.Color.Transparent
        Me.ControlExit.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlExit.FillColor = System.Drawing.Color.Black
        Me.ControlExit.IconColor = System.Drawing.Color.White
        Me.ControlExit.Location = New System.Drawing.Point(1062, 5)
        Me.ControlExit.Name = "ControlExit"
        Me.ControlExit.Size = New System.Drawing.Size(25, 20)
        Me.ControlExit.TabIndex = 2
        '
        'txtRole
        '
        Me.txtRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRole.AutoSize = True
        Me.txtRole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtRole.Location = New System.Drawing.Point(129, 166)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(97, 15)
        Me.txtRole.TabIndex = 12
        Me.txtRole.Text = "Admin/Manager"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Gray
        Me.Guna2Button4.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Italic)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.Orange
        Me.Guna2Button4.Location = New System.Drawing.Point(322, 19)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(20, 20)
        Me.Guna2Button4.TabIndex = 11
        Me.Guna2Button4.Text = "1"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.AutoSize = True
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(74, 137)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 20)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = "example@gmail.com"
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 1
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 1
        '
        'datetime
        '
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 100
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'ButtonPanel
        '
        Me.ButtonPanel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPanel.Controls.Add(Me.btnOpenAdmin)
        Me.ButtonPanel.Controls.Add(Me.btnSalesMng)
        Me.ButtonPanel.Controls.Add(Me.btnSalesReport)
        Me.ButtonPanel.Controls.Add(Me.btnInvMng)
        Me.ButtonPanel.Controls.Add(Me.btnProdMng)
        Me.ButtonPanel.Controls.Add(Me.btnDashboard)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPanel.Location = New System.Drawing.Point(0, 272)
        Me.ButtonPanel.MaximumSize = New System.Drawing.Size(358, 0)
        Me.ButtonPanel.MinimumSize = New System.Drawing.Size(70, 0)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(358, 513)
        Me.ButtonPanel.TabIndex = 0
        '
        'btnOpenAdmin
        '
        Me.btnOpenAdmin.Animated = True
        Me.btnOpenAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenAdmin.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnOpenAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnOpenAdmin.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnOpenAdmin.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btnOpenAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOpenAdmin.FillColor = System.Drawing.Color.Transparent
        Me.btnOpenAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenAdmin.ForeColor = System.Drawing.Color.Black
        Me.btnOpenAdmin.HoverState.FillColor = System.Drawing.Color.SlateGray
        Me.btnOpenAdmin.HoverState.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnOpenAdmin.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_admin_50__1_
        Me.btnOpenAdmin.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_admin_50
        Me.btnOpenAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOpenAdmin.ImageSize = New System.Drawing.Size(46, 46)
        Me.btnOpenAdmin.Location = New System.Drawing.Point(0, 277)
        Me.btnOpenAdmin.Name = "btnOpenAdmin"
        Me.btnOpenAdmin.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnOpenAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOpenAdmin.Size = New System.Drawing.Size(358, 59)
        Me.btnOpenAdmin.TabIndex = 5
        Me.btnOpenAdmin.Text = "ADMINISTRATOR"
        Me.btnOpenAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSalesMng
        '
        Me.btnSalesMng.Animated = True
        Me.btnSalesMng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalesMng.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnSalesMng.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnSalesMng.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnSalesMng.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btnSalesMng.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalesMng.FillColor = System.Drawing.Color.Transparent
        Me.btnSalesMng.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesMng.ForeColor = System.Drawing.Color.Black
        Me.btnSalesMng.HoverState.FillColor = System.Drawing.Color.SlateGray
        Me.btnSalesMng.HoverState.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnSalesMng.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_sales_1001
        Me.btnSalesMng.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_sales_100
        Me.btnSalesMng.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSalesMng.ImageSize = New System.Drawing.Size(46, 46)
        Me.btnSalesMng.Location = New System.Drawing.Point(0, 218)
        Me.btnSalesMng.Name = "btnSalesMng"
        Me.btnSalesMng.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnSalesMng.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalesMng.Size = New System.Drawing.Size(358, 59)
        Me.btnSalesMng.TabIndex = 4
        Me.btnSalesMng.Text = "SALES ORDER MANAGEMENT"
        Me.btnSalesMng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Animated = True
        Me.btnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalesReport.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnSalesReport.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnSalesReport.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnSalesReport.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalesReport.FillColor = System.Drawing.Color.Transparent
        Me.btnSalesReport.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.ForeColor = System.Drawing.Color.Black
        Me.btnSalesReport.HoverState.FillColor = System.Drawing.Color.SlateGray
        Me.btnSalesReport.HoverState.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnSalesReport.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_analytics_64__1_
        Me.btnSalesReport.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_analytics_64
        Me.btnSalesReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSalesReport.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnSalesReport.Location = New System.Drawing.Point(0, 169)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnSalesReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalesReport.Size = New System.Drawing.Size(358, 49)
        Me.btnSalesReport.TabIndex = 3
        Me.btnSalesReport.Text = "SALES REPORTING AND ANALYTICS"
        Me.btnSalesReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnInvMng
        '
        Me.btnInvMng.Animated = True
        Me.btnInvMng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvMng.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnInvMng.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnInvMng.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnInvMng.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btnInvMng.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInvMng.FillColor = System.Drawing.Color.Transparent
        Me.btnInvMng.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvMng.ForeColor = System.Drawing.Color.Black
        Me.btnInvMng.HoverState.FillColor = System.Drawing.Color.SlateGray
        Me.btnInvMng.HoverState.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnInvMng.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_trolley_1001
        Me.btnInvMng.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_trolley_100
        Me.btnInvMng.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInvMng.ImageSize = New System.Drawing.Size(46, 46)
        Me.btnInvMng.Location = New System.Drawing.Point(0, 109)
        Me.btnInvMng.Name = "btnInvMng"
        Me.btnInvMng.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnInvMng.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnInvMng.Size = New System.Drawing.Size(358, 60)
        Me.btnInvMng.TabIndex = 2
        Me.btnInvMng.Text = "INVENTORY MANAGEMENT"
        Me.btnInvMng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnProdMng
        '
        Me.btnProdMng.Animated = True
        Me.btnProdMng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdMng.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnProdMng.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnProdMng.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnProdMng.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btnProdMng.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProdMng.FillColor = System.Drawing.Color.Transparent
        Me.btnProdMng.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdMng.ForeColor = System.Drawing.Color.Black
        Me.btnProdMng.HoverState.FillColor = System.Drawing.Color.SlateGray
        Me.btnProdMng.HoverState.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnProdMng.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_product_management_641
        Me.btnProdMng.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_product_management_64
        Me.btnProdMng.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProdMng.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnProdMng.Location = New System.Drawing.Point(0, 55)
        Me.btnProdMng.Name = "btnProdMng"
        Me.btnProdMng.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnProdMng.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProdMng.Size = New System.Drawing.Size(358, 54)
        Me.btnProdMng.TabIndex = 1
        Me.btnProdMng.Text = "PRODUCT MANAGEMENT"
        Me.btnProdMng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDashboard
        '
        Me.btnDashboard.Animated = True
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.SlateGray
        Me.btnDashboard.HoverState.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnDashboard.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_dashboard_1001
        Me.btnDashboard.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_dashboard_100
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDashboard.Size = New System.Drawing.Size(358, 55)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "DASHBOARD"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.DimGray
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelForm.Location = New System.Drawing.Point(358, 44)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1093, 741)
        Me.PanelForm.TabIndex = 7
        '
        'iconpanel
        '
        Me.iconpanel.BackColor = System.Drawing.Color.Transparent
        Me.iconpanel.Controls.Add(Me.Guna2Button4)
        Me.iconpanel.Controls.Add(Me.logoIco)
        Me.iconpanel.Controls.Add(Me.PictureBox1)
        Me.iconpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.iconpanel.Location = New System.Drawing.Point(0, 0)
        Me.iconpanel.Name = "iconpanel"
        Me.iconpanel.Size = New System.Drawing.Size(358, 76)
        Me.iconpanel.TabIndex = 0
        '
        'logoIco
        '
        Me.logoIco.BackColor = System.Drawing.Color.Transparent
        Me.logoIco.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.MAXCORE_removebg_preview
        Me.logoIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoIco.Location = New System.Drawing.Point(147, 3)
        Me.logoIco.Name = "logoIco"
        Me.logoIco.Size = New System.Drawing.Size(62, 71)
        Me.logoIco.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_notifications_64
        Me.PictureBox1.Location = New System.Drawing.Point(296, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'logopanel
        '
        Me.logopanel.BackColor = System.Drawing.Color.Transparent
        Me.logopanel.Controls.Add(Me.DropDown)
        Me.logopanel.Controls.Add(Me.txtName)
        Me.logopanel.Controls.Add(Me.UserPic)
        Me.logopanel.Controls.Add(Me.txtRole)
        Me.logopanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logopanel.Location = New System.Drawing.Point(0, 76)
        Me.logopanel.Name = "logopanel"
        Me.logopanel.Size = New System.Drawing.Size(358, 196)
        Me.logopanel.TabIndex = 2
        '
        'DropDown
        '
        Me.DropDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropDown.BackColor = System.Drawing.Color.Transparent
        Me.DropDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DropDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DropDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DropDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DropDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DropDown.FillColor = System.Drawing.Color.Transparent
        Me.DropDown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DropDown.ForeColor = System.Drawing.Color.White
        Me.DropDown.Image = Global.MAXCORESMS.My.Resources.Resources.down_arrow
        Me.DropDown.Location = New System.Drawing.Point(12, 6)
        Me.DropDown.Name = "DropDown"
        Me.DropDown.Size = New System.Drawing.Size(26, 27)
        Me.DropDown.TabIndex = 8
        '
        'UserPic
        '
        Me.UserPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserPic.BackColor = System.Drawing.Color.Transparent
        Me.UserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserPic.Image = Global.MAXCORESMS.My.Resources.Resources.NoImage
        Me.UserPic.Location = New System.Drawing.Point(109, 6)
        Me.UserPic.Name = "UserPic"
        Me.UserPic.Size = New System.Drawing.Size(136, 128)
        Me.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserPic.TabIndex = 3
        Me.UserPic.TabStop = False
        '
        'menuPanel
        '
        Me.menuPanel.Controls.Add(Me.ButtonPanel)
        Me.menuPanel.Controls.Add(Me.logopanel)
        Me.menuPanel.Controls.Add(Me.iconpanel)
        Me.menuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuPanel.FillColor = System.Drawing.Color.Transparent
        Me.menuPanel.FillColor2 = System.Drawing.Color.Transparent
        Me.menuPanel.FillColor3 = System.Drawing.Color.Transparent
        Me.menuPanel.FillColor4 = System.Drawing.Color.Transparent
        Me.menuPanel.Location = New System.Drawing.Point(0, 0)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Quality = 1
        Me.menuPanel.Size = New System.Drawing.Size(358, 785)
        Me.menuPanel.TabIndex = 0
        '
        'DropDownStrip
        '
        Me.DropDownStrip.BackColor = System.Drawing.Color.LightGreen
        Me.DropDownStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropDownStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWPROFILEToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.DropDownStrip.Name = "DropDownStrip"
        Me.DropDownStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DropDownStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.DropDownStrip.RenderStyle.ColorTable = Nothing
        Me.DropDownStrip.RenderStyle.RoundedEdges = True
        Me.DropDownStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.DropDownStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DropDownStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DropDownStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.DropDownStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.DropDownStrip.Size = New System.Drawing.Size(153, 48)
        '
        'VIEWPROFILEToolStripMenuItem
        '
        Me.VIEWPROFILEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.VIEWPROFILEToolStripMenuItem.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_select_users_64
        Me.VIEWPROFILEToolStripMenuItem.Name = "VIEWPROFILEToolStripMenuItem"
        Me.VIEWPROFILEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VIEWPROFILEToolStripMenuItem.Text = "VIEW PROFILE"
        Me.VIEWPROFILEToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen
        Me.LOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.LOGOUTToolStripMenuItem.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_logout_100
        Me.LOGOUTToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1451, 785)
        Me.Controls.Add(Me.Drag)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.menuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Drag.ResumeLayout(False)
        Me.Drag.PerformLayout()
        Me.ButtonPanel.ResumeLayout(False)
        Me.iconpanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logopanel.ResumeLayout(False)
        Me.logopanel.PerformLayout()
        CType(Me.UserPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuPanel.ResumeLayout(False)
        Me.DropDownStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents datetime As Timer
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents btnSalesMng As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSalesReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInvMng As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProdMng As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logoIco As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtDate As Label
    Friend WithEvents txtTime As Label
    Friend WithEvents txtName As Label
    Friend WithEvents txtEm As Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelForm As Panel
    Friend WithEvents Drag As Panel
    Friend WithEvents ControlExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menuPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents logopanel As Panel
    Friend WithEvents iconpanel As Panel
    Friend WithEvents UserPic As PictureBox
    Friend WithEvents DropDown As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DropDownStrip As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents VIEWPROFILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtRole As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerStatus As Timer
End Class
