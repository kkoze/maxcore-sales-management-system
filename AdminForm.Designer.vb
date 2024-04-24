<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.drag = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtAdminName = New System.Windows.Forms.Label()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.datetime = New System.Windows.Forms.Timer(Me.components)
        Me.txtContact = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.AdminPic = New System.Windows.Forms.PictureBox()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMngUser = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.drag.SuspendLayout()
        CType(Me.AdminPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.drag
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'drag
        '
        Me.drag.BackColor = System.Drawing.Color.PaleTurquoise
        Me.drag.Controls.Add(Me.Guna2ControlBox2)
        Me.drag.Dock = System.Windows.Forms.DockStyle.Top
        Me.drag.Location = New System.Drawing.Point(0, 0)
        Me.drag.Name = "drag"
        Me.drag.Size = New System.Drawing.Size(1195, 34)
        Me.drag.TabIndex = 4
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Aquamarine
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1153, 6)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(26, 21)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 100
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(83, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Administrator Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label2.Location = New System.Drawing.Point(200, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Welcome Admin!"
        '
        'txtdate
        '
        Me.txtdate.AutoSize = True
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(1108, 667)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(40, 16)
        Me.txtdate.TabIndex = 7
        Me.txtdate.Text = "Date"
        '
        'txttime
        '
        Me.txttime.AutoSize = True
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(1106, 647)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(42, 16)
        Me.txttime.TabIndex = 8
        Me.txttime.Text = "Time"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 634)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1168, 10)
        Me.Guna2Separator1.TabIndex = 9
        '
        'txtAdminName
        '
        Me.txtAdminName.AutoSize = True
        Me.txtAdminName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminName.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtAdminName.Location = New System.Drawing.Point(69, 650)
        Me.txtAdminName.Name = "txtAdminName"
        Me.txtAdminName.Size = New System.Drawing.Size(63, 13)
        Me.txtAdminName.TabIndex = 10
        Me.txtAdminName.Text = "Username"
        '
        'PanelForm
        '
        Me.PanelForm.Location = New System.Drawing.Point(297, 65)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(882, 563)
        Me.PanelForm.TabIndex = 13
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(15, 576)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(272, 10)
        Me.Guna2Separator2.TabIndex = 15
        '
        'datetime
        '
        '
        'txtContact
        '
        Me.txtContact.AutoSize = True
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtContact.Location = New System.Drawing.Point(69, 670)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(51, 13)
        Me.txtContact.TabIndex = 17
        Me.txtContact.Text = "Contact"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkTurquoise
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.LimeGreen
        Me.Guna2Button1.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_create_1001
        Me.Guna2Button1.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_create_100
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 182)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(279, 60)
        Me.Guna2Button1.TabIndex = 18
        Me.Guna2Button1.Text = "CREATE ACCOUNT"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AdminPic
        '
        Me.AdminPic.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.NoImage
        Me.AdminPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminPic.Location = New System.Drawing.Point(13, 643)
        Me.AdminPic.Name = "AdminPic"
        Me.AdminPic.Size = New System.Drawing.Size(50, 47)
        Me.AdminPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AdminPic.TabIndex = 16
        Me.AdminPic.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.HoverState.FillColor = System.Drawing.Color.Silver
        Me.btnExit.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_logout_1001
        Me.btnExit.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_logout_100
        Me.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExit.Location = New System.Drawing.Point(15, 592)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 33)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "EXIT / LOGOUT"
        Me.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMngUser
        '
        Me.btnMngUser.Animated = True
        Me.btnMngUser.BackColor = System.Drawing.Color.Transparent
        Me.btnMngUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMngUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMngUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMngUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMngUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMngUser.FillColor = System.Drawing.Color.DarkTurquoise
        Me.btnMngUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMngUser.ForeColor = System.Drawing.Color.White
        Me.btnMngUser.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnMngUser.HoverState.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnMngUser.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_select_users_64__1_
        Me.btnMngUser.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_select_users_64
        Me.btnMngUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMngUser.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnMngUser.Location = New System.Drawing.Point(12, 116)
        Me.btnMngUser.Name = "btnMngUser"
        Me.btnMngUser.Size = New System.Drawing.Size(279, 60)
        Me.btnMngUser.TabIndex = 11
        Me.btnMngUser.Text = "MANAGE USERS"
        Me.btnMngUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.MAXCORE_removebg_preview
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 40)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(65, 61)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.DarkTurquoise
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.LimeGreen
        Me.Guna2Button2.HoverState.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_create_1001
        Me.Guna2Button2.Image = Global.MAXCORESMS.My.Resources.Resources.icons8_create_100
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.Location = New System.Drawing.Point(12, 248)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(279, 60)
        Me.Guna2Button2.TabIndex = 19
        Me.Guna2Button2.Text = "MAINTENANCE"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1195, 691)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.AdminPic)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.btnMngUser)
        Me.Controls.Add(Me.txtAdminName)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.drag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        Me.drag.ResumeLayout(False)
        CType(Me.AdminPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents txtAdminName As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txttime As Label
    Friend WithEvents txtdate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents drag As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelForm As Panel
    Friend WithEvents btnMngUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents datetime As Timer
    Friend WithEvents txtContact As Label
    Friend WithEvents AdminPic As PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
