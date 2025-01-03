Imports MySql.Data.MySqlClient
Public Class Form5
    Dim cmd As New MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim READER As MySqlDataReader
    Dim query As String
    Dim selectedProductID As Integer
    Dim Gender As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call network()
        'Display()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into employee values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Gender + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "',curdate())"
        cmd.ExecuteNonQuery()
        Cls()
        Display()
        TextBox1.Focus()
        conn.Close()
    End Sub
    Public Sub Display()
        Call network()

        'DATAADPATER FOR FETCH DATA
        adp = New MySqlDataAdapter("select * from cloths.employee", conn)
        Dim dt As New DataTable
        adp.Fill(dt)

        'Check IF any data is present in table
        If (dt.Rows.Count > 0) Then
            DataGridView1.DataSource = dt

        End If
        conn.Close()
    End Sub
    Public Sub Cls()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call network()
        'Display()
        Button1.Text = "Add"
        Button2.Text = "Modify"
        Button3.Text = "Delete"
        Button4.Text = "Cancel"
        Button5.Text = "<-"
        Label13.Text = "Employee Panel"
        Label13.Font = New Font("Georgia", 22, FontStyle.Bold)
        Label1.Text = "Emp Id"
        Label2.Text = "Name"
        Label3.Text = "Aadhar NO"
        Label4.Text = "Gender"
        Label5.Text = "Pin Code"
        Label6.Text = "Phone No"
        Label7.Text = "Email"
        Label8.Text = "Address"
        Label9.Text = "State"
        Label10.Text = "City"
        Label11.Text = "Password"
        Label12.Text = "Date Of Join"
        RadioButton1.Text = "Male"
        RadioButton2.Text = "Female"
        Label14.Text = Today

        'color
        ' Me.BackColor = Color.FromArgb(146, 220, 229)

        'albaster
        TextBox1.BackColor = Color.FromArgb(236, 235, 228)
        TextBox2.BackColor = Color.FromArgb(236, 235, 228)
        TextBox3.BackColor = Color.FromArgb(236, 235, 228)
        TextBox5.BackColor = Color.FromArgb(236, 235, 228)
        TextBox6.BackColor = Color.FromArgb(236, 235, 228)
        TextBox7.BackColor = Color.FromArgb(236, 235, 228)
        TextBox8.BackColor = Color.FromArgb(236, 235, 228)
        TextBox9.BackColor = Color.FromArgb(236, 235, 228)
        TextBox10.BackColor = Color.FromArgb(236, 235, 228)
        TextBox11.BackColor = Color.FromArgb(236, 235, 228)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call network()

        query = "update cloths.employee set EmpName='" & TextBox2.Text & "',EmpAdhar='" & TextBox3.Text & "',Gender= '" & If(RadioButton1.Checked, "Male", "Female") & "',PinCode='" & TextBox5.Text & "',PhoneNo='" & TextBox6.Text & "',Email='" & TextBox7.Text & "',Address='" & TextBox8.Text & "',State='" & TextBox9.Text & "',City='" & TextBox10.Text & "',EmpPass='" & TextBox11.Text & "',EmpDateOfJoin= curdate()  where EmpID='" & TextBox1.Text & "'"
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
            TextBox3.Text = selectedRow.Cells(2).Value.ToString()
            If selectedRow.Cells(3).Value.ToString() = "Male" Then
                RadioButton1.Checked = True
            ElseIf selectedRow.Cells(3).Value.ToString() = "Female" Then
                RadioButton2.Checked = True
            End If
            TextBox5.Text = selectedRow.Cells(4).Value.ToString()
            TextBox6.Text = selectedRow.Cells(5).Value.ToString()
            TextBox7.Text = selectedRow.Cells(6).Value.ToString()
            TextBox8.Text = selectedRow.Cells(7).Value.ToString()
            TextBox9.Text = selectedRow.Cells(8).Value.ToString()
            TextBox10.Text = selectedRow.Cells(9).Value.ToString()
            TextBox11.Text = selectedRow.Cells(10).Value.ToString()
            Label14.Text = selectedRow.Cells(11).Value.ToString()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call network()




        ' Check if a ProductID is selected
        'If selectedProductID > 0 Then
        Call network()
        ' DATAADAPTER FOR FETCH DATA
        query = "delete from cloths.employee where EmpID='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        Display()
        ' Else
        'MsgBox("Please select a product first.")
        ''End If
        Cls()
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cls()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Gender = "Female"
    End Sub
End Class