<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminLogin
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.LinkLabel()
        Me.btnAdminLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtAdminPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.drag = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.drag.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.back)
        Me.Panel1.Controls.Add(Me.btnAdminLogin)
        Me.Panel1.Controls.Add(Me.txtAdminPass)
        Me.Panel1.Controls.Add(Me.txtAdminUsername)
        Me.Panel1.Location = New System.Drawing.Point(194, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 193)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ADMIN LOGIN"
        '
        'back
        '
        Me.back.ActiveLinkColor = System.Drawing.Color.SpringGreen
        Me.back.AutoSize = True
        Me.back.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.LinkColor = System.Drawing.Color.Teal
        Me.back.Location = New System.Drawing.Point(199, 165)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(83, 15)
        Me.back.TabIndex = 6
        Me.back.TabStop = True
        Me.back.Text = "not an admin?"
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Animated = True
        Me.btnAdminLogin.AutoRoundedCorners = True
        Me.btnAdminLogin.BorderRadius = 17
        Me.btnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdminLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminLogin.FillColor = System.Drawing.Color.PaleTurquoise
        Me.btnAdminLogin.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.btnAdminLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.ForeColor = System.Drawing.Color.Black
        Me.btnAdminLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnAdminLogin.Location = New System.Drawing.Point(8, 143)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(155, 37)
        Me.btnAdminLogin.TabIndex = 5
        Me.btnAdminLogin.Text = "LOGIN"
        '
        'txtAdminPass
        '
        Me.txtAdminPass.Animated = True
        Me.txtAdminPass.AutoRoundedCorners = True
        Me.txtAdminPass.BackColor = System.Drawing.Color.Transparent
        Me.txtAdminPass.BorderColor = System.Drawing.Color.Gray
        Me.txtAdminPass.BorderRadius = 15
        Me.txtAdminPass.BorderThickness = 0
        Me.txtAdminPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminPass.DefaultText = ""
        Me.txtAdminPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminPass.FillColor = System.Drawing.Color.DarkTurquoise
        Me.txtAdminPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPass.ForeColor = System.Drawing.Color.Black
        Me.txtAdminPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminPass.IconLeft = Global.MAXCORESMS.My.Resources.Resources.pass
        Me.txtAdminPass.Location = New System.Drawing.Point(12, 94)
        Me.txtAdminPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPass.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAdminPass.PlaceholderText = "PASSWORD"
        Me.txtAdminPass.SelectedText = ""
        Me.txtAdminPass.Size = New System.Drawing.Size(262, 33)
        Me.txtAdminPass.TabIndex = 4
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.Animated = True
        Me.txtAdminUsername.AutoRoundedCorners = True
        Me.txtAdminUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtAdminUsername.BorderColor = System.Drawing.Color.Gray
        Me.txtAdminUsername.BorderRadius = 15
        Me.txtAdminUsername.BorderThickness = 0
        Me.txtAdminUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminUsername.DefaultText = ""
        Me.txtAdminUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminUsername.FillColor = System.Drawing.Color.DarkTurquoise
        Me.txtAdminUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtAdminUsername.ForeColor = System.Drawing.Color.Black
        Me.txtAdminUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminUsername.IconLeft = Global.MAXCORESMS.My.Resources.Resources.user
        Me.txtAdminUsername.Location = New System.Drawing.Point(12, 53)
        Me.txtAdminUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminUsername.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAdminUsername.PlaceholderText = "USERNAME"
        Me.txtAdminUsername.SelectedText = ""
        Me.txtAdminUsername.Size = New System.Drawing.Size(262, 33)
        Me.txtAdminUsername.TabIndex = 3
        '
        'drag
        '
        Me.drag.BackColor = System.Drawing.Color.PaleTurquoise
        Me.drag.Controls.Add(Me.Guna2ControlBox2)
        Me.drag.Controls.Add(Me.Guna2ControlBox1)
        Me.drag.Dock = System.Windows.Forms.DockStyle.Top
        Me.drag.Location = New System.Drawing.Point(0, 0)
        Me.drag.Name = "drag"
        Me.drag.Size = New System.Drawing.Size(490, 34)
        Me.drag.TabIndex = 5
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.SeaGreen
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(418, 6)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(26, 21)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.IndianRed
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(450, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(26, 21)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.MAXCORE_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 195)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.drag
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 254)
        Me.Controls.Add(Me.drag)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.drag.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents drag As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtAdminPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAdminUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents back As LinkLabel
    Friend WithEvents btnAdminLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
