Imports System.Data
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class AccountManagement

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public accountId As Integer

    Private Sub AccountManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagrid()
    End Sub
    Private Sub AccountManagement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Public Sub loadDatagrid()
        datagridViewAccounts.Rows.Clear()

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
        cmd.CommandText = "SELECT accounts.account_id, accounts.user_level, accounts.account_name, accounts.question, accounts.answer, brgyofficials.official_name, brgyofficials.official_position from accounts LEFT JOIN brgyofficials on accounts.account_id = brgyofficials.id order by accounts.account_id asc"
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim officialName As String = " "
                officialName = getResidentNameById(mySQLReader!official_name)
                Dim officialPosition As String = " "
                officialPosition = mySQLReader!official_position
                datagridViewAccounts.Rows.Add(New String() {mySQLReader!account_id, mySQLReader!user_level, mySQLReader!account_name, officialName, officialPosition})
            End While

        End If
        datagridViewAccounts.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Function getResidentNameById(ByVal id As Integer) As String

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

        cmd.CommandText = "SELECT first_name, middle_name, last_name, ext_name from residents WHERE resident_id = @residentid "
        cmd.Parameters.AddWithValue("@residentid", id)

        Dim name As String = ""
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                name = mySQLReader!first_name + If(mySQLReader!middle_name = "", "", " " + mySQLReader!middle_name) + " " + mySQLReader!last_name + " " + mySQLReader!ext_name
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return name
    End Function

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Create_Account.action = "account"
        Create_Account.ShowDialog()
    End Sub

    Private Sub datagridViewAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridViewAccounts.CellClick
        If e.RowIndex >= 0 Then
            If e.RowIndex = 0 Then
                btnUpdateAccount.Enabled = True
                btnRemoveAccount.Enabled = False
            Else
                btnUpdateAccount.Enabled = True
                btnRemoveAccount.Enabled = True
            End If
            accountId = datagridViewAccounts.Rows(e.RowIndex).Cells(0).Value

        End If
    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        ConfirmAccess.originForm = "UpdateAccount"
        ConfirmAccess.Show()
    End Sub

    Public Sub updateAccount()
        Account_Settings.accountId = accountId
        Account_Settings.getAccountDetails(accountId)
        Account_Settings.ShowDialog()


        loadDatagrid()
        accountId = 0
        btnUpdateAccount.Enabled = False
        btnRemoveAccount.Enabled = False
        datagridViewAccounts.ClearSelection()
    End Sub

    Private Sub btnRemoveAccount_Click(sender As Object, e As EventArgs) Handles btnRemoveAccount.Click
        If MsgBox("Are you sure to remove this account?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            ConfirmAccess.originForm = "RemoveAccount"
            ConfirmAccess.Show()
        End If
    End Sub

    Public Sub removeAccount()
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
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE FROM accounts WHERE account_id = @accountid"
        cmd.Parameters.AddWithValue("@accountid", accountId)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Account Removed!", vbInformation, "Information")
        loadDatagrid()
        accountId = 0
        btnRemoveAccount.Enabled = False
        btnUpdateAccount.Enabled = False
        datagridViewAccounts.ClearSelection()
    End Sub

End Class