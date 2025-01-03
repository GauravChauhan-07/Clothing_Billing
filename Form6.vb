Imports MySql.Data.MySqlClient


Public Class Form6
    Dim cmd As New MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim READER As MySqlDataReader
    Dim query As String
    Dim selectedProductID As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call network()
        'Display()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into product values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "',curdate())"
        cmd.ExecuteNonQuery()


        Cls()
        Display()
        TextBox1.Focus()
        conn.Close()
    End Sub

    Public Sub Display()
        Call network()

        'DATAADPATER FOR FETCH DATA
        adp = New MySqlDataAdapter("select * from product", conn)
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
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call network()
        Display()

        conn.Close()
        Label1.Text = "Product Panel"
        Label1.Font = New Font("Georgia", 22, FontStyle.Bold)
        Label2.Text = "ProductID"
        Label3.Text = "ProductName"
        Label4.Text = "PMRP"
        Label5.Text = "PQuantity"
        Label6.Text = "GSTRate"
        Label7.Text = "Discount"
        Label8.Text = Today
        Label9.Text = "ProductDate"
        Button5.Text = "<-"
        Button4.Text = "Cancel"
        Button1.Text = "Add"
        Button2.Text = "Update"
        Button3.Text = "Delete"
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Call network()

        query = "update cloths.product set ProductName='" & TextBox2.Text & "',PMRP='" & TextBox3.Text & "',PQuantity= '" & TextBox4.Text & "',GSTRate='" & TextBox5.Text & "',Discount='" & TextBox6.Text & "',ProductDate=curdate()  where ProductID='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()

        conn.Close()
        Cls()
        Display()
    End Sub



    'Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
    'If ListView1.SelectedItems.Count > 0 Then
    '    TextBox1.Text = ListView1.SelectedItems(0).Text
    '    TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
    'End If
    'EndSub











    'Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
    '    ' Check if the click is on a valid cell
    '    If e.RowIndex = 0 AndAlso e.ColumnIndex >= 0 Then
    '        ' Get the value of the clicked cell
    '        Dim cellValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
    '        ' Set the value to the TextBox
    '        TextBox1.Text = cellValue
    '    End If
    'End Sub


    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    ' Check if the click is on a valid cell
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
    '        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
    '        selectedProductID = selectedrow.Cells(0).Value
    '    End If
    'End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            TextBox1.Text = selectedRow.Cells(0).Value.ToString()
            TextBox2.Text = selectedRow.Cells(1).Value.ToString()
            TextBox3.Text = selectedRow.Cells(2).Value.ToString()
            TextBox4.Text = selectedRow.Cells(3).Value.ToString()
            TextBox5.Text = selectedRow.Cells(4).Value.ToString()
            TextBox6.Text = selectedRow.Cells(5).Value.ToString()

            ' TextBox8.Text = selectedRow.Cells(6).Value.ToString()

        End If
    End Sub










    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call network()




        ' Check if a ProductID is selected
        'If selectedProductID > 0 Then
        Call network()
        ' DATAADAPTER FOR FETCH DATA
        query = "delete from cloths.product where ProductID='" & TextBox1.Text & "'"
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cls()

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class