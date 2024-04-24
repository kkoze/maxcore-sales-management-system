Imports System.Windows

Public Class BBD

    Private Sub BBD_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna2CircleProgressBar1.Value = 1
        Guna2CircleProgressBar1.Maximum = 1


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Get the current date without formatting (DateTime type)
        Dim currentDate As DateTime = Date.Today

        ' Get the selected date from Guna2DateTimePicker and format it
        Dim selectedDate As String = Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim selectedDate2 As String = Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim selectedDate3 As String = Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")
        ' Enable controls and set the formatted date in the other form


        popAddMedItem.txtDate.Text = selectedDate
        popAddMerchItem.txtDate.Text = selectedDate2
        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub btnConfirm2_Click(sender As Object, e As EventArgs) Handles btnConfirm2.Click
        ' Get the selected date from Guna2DateTimePicker
        Dim selectedDate As DateTime = Guna2DateTimePicker1.Value.Date

        ' Get the selected time from Guna2TimePicker
        Dim selectedTime As TimeSpan = Guna2TimePicker.Value.TimeOfDay

        ' Combine the date and time
        Dim selectedDateTime As DateTime = selectedDate.Add(selectedTime)

        ' Format the selected date and time
        Dim formattedDateTime As String = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss tt")
        Dim formattedDateTime2 As String = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss tt")
        Dim formattedDateTime3 As String = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss tt")

        ' Enable controls and set the formatted date and time in the other form


        popAddMedItem.txtdateDeliver.Text = formattedDateTime
        popAddMerchItem.txtdateDeliver.Text = formattedDateTime2
        InvMng.txtUDeliver.Text = formattedDateTime3
        ' Hide the current form
        Me.Hide()
    End Sub

End Class