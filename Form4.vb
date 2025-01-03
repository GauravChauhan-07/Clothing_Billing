Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Name :"
        Label2.Text = "Gaurav Chauhan"
        Button1.Text = "Employee Details"
        Button2.Text = "Product Details"
        Button3.Text = "Sales Detail"
        Button4.Text = "Customer Detail"
        Button6.Text = "Generate Bill"
        Button5.Text = "<-"
        Label3.Text = "ADMIN PANEL"
        Label3.Font = New Font("Georgia", 26, FontStyle.Bold)
        ' Display current time
        Label4.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Label5.Text = "Time :"

        Button1.BackColor = Color.FromArgb(255, 230, 109)
        Button2.BackColor = Color.FromArgb(255, 230, 109)
        Button3.BackColor = Color.FromArgb(255, 230, 109)
        Button4.BackColor = Color.FromArgb(255, 230, 109)
        Button6.BackColor = Color.FromArgb(255, 230, 109)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        Customer_detail.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the Label with the current time
        Label4.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class