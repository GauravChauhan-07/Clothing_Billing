Imports MySql.Data.MySqlClient
Module Database_Connection
    Public conn As MySqlConnection
    Public Sub network()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='1234';database=cloths"
        conn.Open()
        If conn.State <> ConnectionState.Open Then
            MessageBox.Show("No Connection")
        End If
    End Sub

End Module

'Imports MySql.Data.MySqlClient

'Module Database_Connection
'    Public conn As MySqlConnection

'    Public Sub network()
'        If conn Is Nothing Then
'            conn = New MySqlConnection("server=localhost;user=root;password='jatins555';database=zaracom")
'        End If

'        If conn.State = ConnectionState.Closed Then
'            Try
'                conn.Open()
'                If conn.State <> ConnectionState.Open Then
'                    MessageBox.Show("No Connection")
'                End If
'            Catch ex As Exception
'                MessageBox.Show("An error occurred: " & ex.Message)
'            End Try
'        End If
'    End Sub

'    Public Function IsConnectionAvailable() As Boolean
'        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
'            Return True
'        Else
'            Return False
'        End If
'    End Function

'    Public Sub ReadData()
'        network() ' Ensure the connection is open
'        If IsConnectionAvailable() Then
'            Using command As New MySqlCommand("SELECT * FROM YourTable", conn)
'                Try
'                    Using reader As MySqlDataReader = command.ExecuteReader()
'                        While reader.Read()
'                            ' Process your data here
'                        End While
'                    End Using
'                Catch ex As Exception
'                    MessageBox.Show("An error occurred during read operation: " & ex.Message)
'                End Try
'            End Using
'        Else
'            MessageBox.Show("Connection is not available.")
'        End If
'        CloseConnection() ' Close the connection after the operation
'    End Sub

'    Public Sub CloseConnection()
'        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
'            conn.Close()
'        End If
'    End Sub
'End Module
