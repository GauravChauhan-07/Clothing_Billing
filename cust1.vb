Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClie
Imports MySql.Data.MySqlClient
Public Class cust1
    Dim cmd As New MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim READER As MySqlDataReader
    Dim query As String
    Dim selectedProductID As Integer
    Dim Gender As String
    Private Sub cust1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Customer Id"
        Label2.Text = "Phone"
        Label4.Text = "Customer Name"
        Label5.Text = "Email"
        Label6.Text = "Gender"
        Label7.Text = "Loyalty points"
        RadioButton1.Text = "Male"
        RadioButton2.Text = "Female"
        Button5.Text = "<-"

        Label8.Text = "Customer Panel"
        Label8.Font = New Font("Georgia", 26, FontStyle.Bold)

        Button1.Text = "Add"
        Button2.Text = "Modify"
        Button3.Text = "Delete"
        Button4.Text = "Cancel"
        Display()



        'color
        ' Me.BackColor = Color.FromArgb(134, 187, 216)

        'albaster
        TextBox1.BackColor = Color.FromArgb(236, 235, 228)
        TextBox2.BackColor = Color.FromArgb(236, 235, 228)

        TextBox4.BackColor = Color.FromArgb(236, 235, 228)
        TextBox5.BackColor = Color.FromArgb(236, 235, 228)
        TextBox6.BackColor = Color.FromArgb(236, 235, 228)


        'Licorice
        Button1.BackColor = Color.FromArgb(41, 31, 30)
        Button2.BackColor = Color.FromArgb(41, 31, 30)
        Button3.BackColor = Color.FromArgb(41, 31, 30)
        Button4.BackColor = Color.FromArgb(41, 31, 30)
        Button5.BackColor = Color.FromArgb(41, 31, 30)

        'Yellow
        Button1.ForeColor = Color.FromArgb(246, 249, 48)
        Button2.ForeColor = Color.FromArgb(246, 249, 48)
        Button3.ForeColor = Color.FromArgb(246, 249, 48)
        Button4.ForeColor = Color.FromArgb(246, 249, 48)
        Button5.ForeColor = Color.FromArgb(246, 249, 48)
    End Sub

    Public Sub Cls()
        TextBox1.Text = ""
        TextBox2.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call network()
        'Display()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into customer values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + Gender + "','" + TextBox6.Text + "')"
        cmd.ExecuteNonQuery()
        Cls()
        Display()
        TextBox1.Focus()
        conn.Close()
    End Sub
    Public Sub Display()
        Call network()

        'DATAADPATER FOR FETCH DATA
        adp = New MySqlDataAdapter("select * from cloths.customer", conn)
        Dim dt As New DataTable
        adp.Fill(dt)

        'Check IF any data is present in table
        If (dt.Rows.Count > 0) Then
            DataGridView1.DataSource = dt

        End If
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call network()

        query = "update cloths.customer set Phone='" & TextBox2.Text & "',CustName='" & TextBox4.Text & "',Email='" & TextBox5.Text & "',Gender='" & If(RadioButton1.Checked, "Male", "Female") & "',LoyaltyPoints='" & TextBox6.Text & "' where CustomerID='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        Cls()
        Display()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            TextBox1.Text = selectedRow.Cells(0).Value.ToString()
            TextBox2.Text = selectedRow.Cells(1).Value.ToString()

            TextBox4.Text = selectedRow.Cells(2).Value.ToString()
            TextBox5.Text = selectedRow.Cells(3).Value.ToString()
            If selectedRow.Cells(4).Value.ToString() = "Male" Then
                RadioButton1.Checked = True
            ElseIf selectedRow.Cells(4).Value.ToString() = "Female" Then
                RadioButton2.Checked = True
            End If
            TextBox6.Text = selectedRow.Cells(5).Value.ToString()


        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call network()
        Call network()
        ' DATAADAPTER FOR FETCH DATA
        query = "delete from cloths.customer where CustomerID='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        Display()
        Cls()
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cls()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        man.Show()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Gender = "Female"
    End Sub



End Class