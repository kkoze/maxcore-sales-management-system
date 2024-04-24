Imports System.Drawing.Drawing2D

Public Class mainViewProfile
    Private Sub mainViewProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Background Gradient Color <-----
        Dim GradientBack As New LinearGradientBrush(Me.DisplayRectangle, Color.Aquamarine, Color.White, LinearGradientMode.ForwardDiagonal)
        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)
        Dim Grad As Graphics = Graphics.FromImage(Me.BackgroundImage)
        Grad.FillRectangle(GradientBack, Me.DisplayRectangle)
        '-------->
    End Sub
End Class