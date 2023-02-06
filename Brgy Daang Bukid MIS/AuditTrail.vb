Imports MySql.Data.MySqlClient

Module AuditTrail

    Public mySqlConn As String = My.Resources.constring

    Public Sub addLog(accountName As String, transaction As String)
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

        Dim cmd As MySqlCommand
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO audit_history (date, time, account_name, transaction) values (@date, @time, @accountName, @transaction)"
        cmd.Parameters.AddWithValue("@date", Date.Now.Date)


        cmd.Parameters.AddWithValue("@time", DateTime.Now)
        cmd.Parameters.AddWithValue("@accountname", accountName)
        cmd.Parameters.AddWithValue("@transaction", transaction)

        cmd.ExecuteNonQuery()
        mySql.Close()
        mySql.Dispose()
    End Sub


End Module
