<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainViewProfile
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.drag = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.userImg = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtContact = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.Label()
        Me.drag.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.userImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.drag
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'drag
        '
        Me.drag.BackColor = System.Drawing.Color.Transparent
        Me.drag.Controls.Add(Me.Guna2ControlBox1)
        Me.drag.Dock = System.Windows.Forms.DockStyle.Top
        Me.drag.Location = New System.Drawing.Point(0, 0)
        Me.drag.Name = "drag"
        Me.drag.Size = New System.Drawing.Size(311, 28)
        Me.drag.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(279, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.DarkRed
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 22)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtRole)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Location = New System.Drawing.Point(12, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 313)
        Me.Panel1.TabIndex = 15
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me.Panel1
        '
        'userImg
        '
        Me.userImg.BackColor = System.Drawing.Color.Transparent
        Me.userImg.FillColor = System.Drawing.Color.Transparent
        Me.userImg.Image = Global.MAXCORESMS.My.Resources.Resources.NoImage
        Me.userImg.ImageRotate = 0!
        Me.userImg.Location = New System.Drawing.Point(50, 34)
        Me.userImg.Name = "userImg"
        Me.userImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.userImg.Size = New System.Drawing.Size(212, 206)
        Me.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userImg.TabIndex = 1
        Me.userImg.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.icons8_mail_24
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(37, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.icons8_call_50
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(37, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BackgroundImage = Global.MAXCORESMS.My.Resources.Resources.MAXCORE_removebg_preview
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel2.Location = New System.Drawing.Point(8, 241)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(65, 61)
        Me.Guna2Panel2.TabIndex = 26
        '
        'txtContact
        '
        Me.txtContact.AutoSize = True
        Me.txtContact.BackColor = System.Drawing.Color.Transparent
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtContact.Location = New System.Drawing.Point(116, 152)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(119, 20)
        Me.txtContact.TabIndex = 25
        Me.txtContact.Text = "Contact#01921"
        Me.txtContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.txtEmail.Location = New System.Drawing.Point(78, 102)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(172, 20)
        Me.txtEmail.TabIndex = 24
        Me.txtEmail.Text = "example@gmail.com"
        Me.txtEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtRole
        '
        Me.txtRole.AutoSize = True
        Me.txtRole.BackColor = System.Drawing.Color.Transparent
        Me.txtRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.Location = New System.Drawing.Point(117, 35)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(62, 18)
        Me.txtRole.TabIndex = 23
        Me.txtRole.Text = "emprole"
        Me.txtRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUser
        '
        Me.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(61, 11)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(189, 24)
        Me.txtUser.TabIndex = 22
        Me.txtUser.Text = "username example"
        Me.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainViewProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 573)
        Me.Controls.Add(Me.userImg)
        Me.Controls.Add(Me.drag)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainViewProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainViewProfile"
        Me.drag.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.userImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents drag As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents userImg As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtContact As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtRole As Label
    Friend WithEvents txtUser As Label
End Class
