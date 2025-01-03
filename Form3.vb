Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Administrator Login"
        Button1.Text = "Login"
        Button2.Text = "Cancel"
        Label2.Text = "User Name"
        Label3.Text = "Password"
        Label1.Font = New Font("Arial", 18, FontStyle.Bold)
        TextBox2.PasswordChar = "*"
        Label4.Text = "Date :"
        Label5.Text = "Time :"
        ' Display current date
        Label6.Text = DateTime.Now.ToShortDateString()

        ' Display current time
        Label7.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String

        username = TextBox1.Text
        password = TextBox2.Text
        If username.Equals("admin1001") And password.Equals("admin") Then
            MessageBox.Show("Login Succesful")
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.Hide()
            Form4.Show()
        ElseIf username.Equals("") And password.Equals("") Then
            MessageBox.Show("Enter Id and Password")
        Else
            MessageBox.Show("Wrong username or password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the Label with the current time
        Label7.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class