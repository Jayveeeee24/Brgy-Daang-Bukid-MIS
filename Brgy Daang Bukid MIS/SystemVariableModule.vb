Imports MySql.Data.MySqlClient

Module SystemVariableModule

    Public mySqlConn As String = My.Resources.constring
    Public Sub getSystemVariable(comboView As ComboBox, ByVal type As String)
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
        mySQLCommand.Parameters.AddWithValue("@type", type)


        mySQLReader = mySQLCommand.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                comboView.Items.Add(mySQLReader!variable_name)
            End While
        End If
        mySQLCommand.Dispose()
        mySQLReader.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
End Module
