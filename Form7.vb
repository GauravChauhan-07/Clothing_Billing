Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Login"
        Button2.Text = "Cancel"

        Label1.Text = "Employee Login"
        Label1.Font = New Font("Arial", 18, FontStyle.Bold)
        Label2.Text = "Emp Id"
        Label3.Text = "Password"

        ' Display current date
        Label6.Text = DateTime.Now.ToShortDateString()
        Label4.Text = "Date :"
        ' Display current time
        Label7.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Label5.Text = "Time :"
        'for password
        TextBox2.PasswordChar = "*"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EmpId As String
        Dim password As String

        EmpId = TextBox1.Text
        password = TextBox2.Text
        If EmpId.Equals("Emp1001") And password.Equals("emp") Then
            MessageBox.Show("Login Succesful")
            Me.Hide()
            Form8.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf EmpId.Equals("") And password.Equals("") Then
            MessageBox.Show("Enter Id and Password")



        Else
            MessageBox.Show("Wrong EmpId or password")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the Label with the current time
        Label7.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class