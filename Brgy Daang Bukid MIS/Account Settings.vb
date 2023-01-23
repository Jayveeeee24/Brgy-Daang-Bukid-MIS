Imports System.Data
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class Account_Settings

    Public mySqlConn As String = "server=192.168.1.2; user id=user; password=qwer; database=mis"
    Public accountId As Integer = 0

    Private visibilityImage As Image
    Private Sub Account_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If accountId = 0 Then
            accountId = Main_Form.account_id
        End If

        getAccountDetails(accountId)
    End Sub

    Public Sub getAccountDetails(ByVal id As Integer)

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
        cmd.CommandText = "SELECT accounts.account_name, accounts.question, accounts.answer, brgyofficials.official_position from accounts LEFT JOIN brgyofficials on accounts.account_id = brgyofficials.id where accounts.account_id = @accountid"
        cmd.Parameters.AddWithValue("@accountid", id)
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                comboRecovery.SelectedIndex = comboRecovery.FindStringExact(mySQLReader!question)
                txtAnswer.Text = mySQLReader!answer
                txtUsername.Text = mySQLReader!account_name
                txtAccountName.Text = mySQLReader!official_position

                If accountId > 1 And txtAccountName.Text.Trim = "" Then
                    txtAccountName.Text = "Staff"
                ElseIf accountId = 1 And txtAccountName.Text.Trim = "" Then
                    txtAccountName.Text = "Administrator"
                End If
            End While

        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub txtViewKeydown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown, txtConfirmPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Account_Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Me.Enabled = False

        If txtPassword.Text.Trim = "" Or txtUsername.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Me.Enabled = True
            Exit Sub
        End If
        If txtPassword.Text.Trim <> txtConfirmPassword.Text.Trim Then
            MsgBox("Both passwords must match!", vbCritical, "Warning")
            Me.Enabled = True
            Exit Sub
        End If
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                Me.Enabled = True
                txtPassword.Clear()
                mySql.Close()
                mySql.Dispose()
                Exit Sub
        End Select

        Dim mySQLCommand As MySqlCommand
        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text

        mySQLCommand.CommandText = "UPDATE accounts SET account_password = @accountpassword, account_name = @accountname, question = @question, answer = @answer WHERE account_id = @accountid"
        mySQLCommand.Parameters.AddWithValue("@accountid", accountId)
        mySQLCommand.Parameters.AddWithValue("@accountpassword", txtPassword.Text.Trim)
        mySQLCommand.Parameters.AddWithValue("@accountname", txtUsername.Text.Trim)
        mySQLCommand.Parameters.AddWithValue("@question", comboRecovery.Text)
        mySQLCommand.Parameters.AddWithValue("@answer", txtAnswer.Text.Trim)
        mySQLCommand.ExecuteNonQuery()

        Me.Enabled = True
        txtPassword.Clear()
        MsgBox("Password Changed!", vbInformation, "Information")
        mySQLCommand.Dispose()
        mySql.Close()
        mySql.Dispose()

        Me.Close()

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Function GetVisibilityImage(ByVal imageName As String) As Image
        If imageName = "visible" Then
            visibilityImage = My.Resources.visi_off
        Else
            visibilityImage = My.Resources.visi
        End If
        Return visibilityImage
    End Function
    Private Sub btnVisibilityNewPass_Click(sender As Object, e As EventArgs) Handles btnVisibilityNewPass.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            btnVisibilityNewPass.Image = GetVisibilityImage("visible")
        Else
            txtPassword.PasswordChar = "*"
            btnVisibilityNewPass.Image = GetVisibilityImage("invisible")
        End If
    End Sub
    Private Sub btnVisibilityConfirm_Click(sender As Object, e As EventArgs) Handles btnVisibilityConfirm.Click
        If txtConfirmPassword.PasswordChar = "*" Then
            txtConfirmPassword.PasswordChar = ""
            btnVisibilityConfirm.Image = GetVisibilityImage("visible")
        Else
            txtConfirmPassword.PasswordChar = "*"
            btnVisibilityConfirm.Image = GetVisibilityImage("invisible")
        End If
    End Sub
End Class