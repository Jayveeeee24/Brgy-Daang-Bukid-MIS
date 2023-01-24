Imports System.Data
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class ConfirmAccess

    Public originForm As String
    Public reasonForArchived As String
    Dim allowDeactivate As Boolean = True
    Public mySqlConn As String = My.Resources.constring

    Private Sub ConfirmAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        If originForm = "Archive" Then
            mainTabControl.SelectedIndex = 0
        Else
            mainTabControl.SelectedIndex = 1
        End If

        comboReason.SelectedIndex = -1
        txtAccountName.Text = Main_Form.user_level
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        mainTabControl.SelectedIndex = 1
        reasonForArchived = comboReason.Text
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirmAccess.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnConfirmAccess_Click(sender As Object, e As EventArgs) Handles btnConfirmAccess.Click
        Me.Enabled = False

        If txtPassword.Text.Trim = "" Then
            Me.Enabled = True
            allowDeactivate = False
            MsgBox("Please fill out the required fields!")
            allowDeactivate = True
            Exit Sub
        End If
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                allowDeactivate = False
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                allowDeactivate = True

                Me.Enabled = True
                txtPassword.Clear()
                mySql.Close()
                mySql.Dispose()
                Exit Sub
        End Select

        Dim mySQLCommand As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text

        mySQLCommand.CommandText = "SELECT * FROM accounts WHERE BINARY account_id = @accountid AND BINARY account_password = @accountpassword "
        mySQLCommand.Parameters.AddWithValue("@accountid", Main_Form.account_id)
        mySQLCommand.Parameters.AddWithValue("@accountpassword", txtPassword.Text.Trim)

        mySQLReader = mySQLCommand.ExecuteReader

        Me.Enabled = True
        If mySQLReader.HasRows Then

            Me.Close()
            If originForm = "Archive" Then
                ViewResident.reasonForArchive = reasonForArchived
                ViewResident.checkIfHead()
            ElseIf originForm = "Accounts" Then
                Account_Settings.ShowDialog()
            ElseIf originForm = "AccountManagement" Then
                AccountManagement.ShowDialog()
            ElseIf originForm = "BrgyOfficials" Then
                UpdateBrgyOfficials.ShowDialog()
            ElseIf originForm = "DismissBrgyOfficial" Then
                UpdateBrgyOfficials.dismissOfficial()
            ElseIf originForm = "RemoveAccount" Then
                AccountManagement.removeAccount()
            ElseIf originForm = "SystemVariables" Then
                SystemVariables.ShowDialog()
                'ElseIf originForm = "UpdateAccount" Then
                '    AccountManagement.updateAccount()
            End If
        Else
            txtPassword.Clear()

            allowDeactivate = False
            MsgBox("Password Incorrect!, Please try again", vbCritical, "Warning")
            allowDeactivate = True

        End If
        mySQLCommand.Dispose()
        mySQLReader.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub ConfirmAccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtPassword.Clear()
    End Sub

    Private Sub ConfirmAccess_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        If allowDeactivate = True Then
            Me.Close()
        End If
    End Sub
End Class