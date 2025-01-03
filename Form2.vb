Public Class Form2
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "ADMIN"
        Button2.Text = "EMPLOYEE"
        Button3.Text = "MANAGER"
        Label3.Text = "Date :"
        Label4.Text = "Time :"
        ' Display current date
        Label1.Text = DateTime.Now.ToShortDateString()

        ' Display current time
        Label2.Text = DateTime.Now.ToString("hh:mm:ss tt")

        Button1.BackColor = Color.FromArgb(255, 230, 109)
        Button2.BackColor = Color.FromArgb(255, 230, 109)
        Button3.BackColor = Color.FromArgb(255, 230, 109)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Mane.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the Label with the current time
        Label2.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class