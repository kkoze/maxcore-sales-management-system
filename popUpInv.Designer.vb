<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popUpInv
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
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnConfirmYes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirmNo = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(21, 132)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(367, 10)
        Me.Guna2Separator1.TabIndex = 11
        '
        'btnConfirmYes
        '
        Me.btnConfirmYes.BorderRadius = 5
        Me.btnConfirmYes.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnConfirmYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmYes.FillColor = System.Drawing.Color.Orange
        Me.btnConfirmYes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmYes.ForeColor = System.Drawing.Color.White
        Me.btnConfirmYes.Location = New System.Drawing.Point(88, 148)
        Me.btnConfirmYes.Name = "btnConfirmYes"
        Me.btnConfirmYes.Size = New System.Drawing.Size(99, 32)
        Me.btnConfirmYes.TabIndex = 9
        Me.btnConfirmYes.Text = "Yes"
        '
        'btnConfirmNo
        '
        Me.btnConfirmNo.BorderRadius = 5
        Me.btnConfirmNo.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnConfirmNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmNo.FillColor = System.Drawing.Color.Orange
        Me.btnConfirmNo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmNo.ForeColor = System.Drawing.Color.White
        Me.btnConfirmNo.Location = New System.Drawing.Point(210, 148)
        Me.btnConfirmNo.Name = "btnConfirmNo"
        Me.btnConfirmNo.Size = New System.Drawing.Size(99, 32)
        Me.btnConfirmNo.TabIndex = 10
        Me.btnConfirmNo.Text = "No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(47, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Do you still want to add this as quantity?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(56, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 36)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Item found in inventory"
        '
        'popUpInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 245)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.btnConfirmYes)
        Me.Controls.Add(Me.btnConfirmNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "popUpInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "popUpInv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnConfirmYes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmNo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
