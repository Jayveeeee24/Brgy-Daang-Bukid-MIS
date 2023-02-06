Imports MySql.Data.MySqlClient

Public Class AuditHistory

    Public mySqlConn As String = My.Resources.constring

    Private Sub AuditHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagrid()
    End Sub
    Private Sub AuditHistory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Sub loadDatagrid()
        datagridAuditHistory.Rows.Clear()

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select


        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM audit_history ORDER BY date DESC, time desc"
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim dateAudit As Date = mySQLReader!date
                Dim time As DateTime = mySQLReader!time

                datagridAuditHistory.Rows.Add(New String() {dateAudit.ToString("MMMM d, yyyy"), time.ToString("hh:mm tt").ToString, mySQLReader!account_name, mySQLReader!transaction})
                Dim transaction As String = mySQLReader!transaction
                If transaction.Length >= 25 And datagridAuditHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill Then
                    datagridAuditHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Else
                    datagridAuditHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End If
            End While

        End If
        datagridAuditHistory.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

    End Sub

    Private Sub datagridAuditHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridAuditHistory.CellClick
        datagridAuditHistory.ClearSelection()
    End Sub
End Class