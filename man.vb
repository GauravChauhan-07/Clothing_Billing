Public Class man
    Private Sub man_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Name :"
        Label2.Text = "Gaurav Chauhan"
        Button1.Text = "Generate Bill"
        Button2.Text = "Sales Detail"
        Button3.Text = "Customer Detail"
        Button5.Text = "<-"
        Label3.Text = "MANAGER PANEL"
        Label3.Font = New Font("Georgia", 26, FontStyle.Bold)
        ' Display current time
        Label4.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Label5.Text = "Time :"

        Button1.BackColor = Color.FromArgb(255, 230, 109)
        Button2.BackColor = Color.FromArgb(255, 230, 109)
        Button3.BackColor = Color.FromArgb(255, 230, 109)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the Label with the current time
        Label4.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Mane.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        cust1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class