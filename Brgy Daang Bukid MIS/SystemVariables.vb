Imports MySql.Data.MySqlClient

Public Class SystemVariables

    Public mySqlConn As String = My.Resources.constring
    Private Sub SystemVariables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboSystemVariables.SelectedIndex = 0
    End Sub

    Private Sub comboSystemVariables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSystemVariables.SelectedIndexChanged
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                Exit Sub
        End Select

        Dim mySQLCommand As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text

        mySQLCommand.CommandText = "SELECT variable_name FROM system_variables WHERE variable_type=@type"
        mySQLCommand.Parameters.AddWithValue("@type", comboSystemVariables.Text)


        mySQLReader = mySQLCommand.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                datagridViewSystemVariables.Rows.Add(New String() {mySQLReader!id, mySQLReader!variable_name})
            End While
        End If
        mySQLCommand.Dispose()
        mySQLReader.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
End Class