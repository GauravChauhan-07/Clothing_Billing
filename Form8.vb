Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Name :"
        Label2.Text = "Rohit Khatri"
        Label3.Text = "EMPLOYEE PANEL"
        Label3.Font = New Font("Arial", 26, FontStyle.Bold)
        Button1.Text = "Generate Bill"
        Button2.Text = "Today Sale's"
        Button3.Text = "<-"
        Label5.Text = "Time :"
        Button1.BackColor = Color.FromArgb(255, 230, 109)
        Button2.BackColor = Color.FromArgb(255, 230, 109)

        ' Display current time
        Label7.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.Hide()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the Label with the current time
        Label7.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class