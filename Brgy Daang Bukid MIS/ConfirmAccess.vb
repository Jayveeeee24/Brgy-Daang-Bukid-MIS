Imports System.Data
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class ConfirmAccess

    Public originForm As String
    Public reasonForArchived As String
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"

    Private Sub ConfirmAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        If originForm = "Archive" Then
            mainTabControl.SelectedIndex = 0
        Else
            mainTabControl.SelectedIndex = 1
        End If

        txtAccountName.Text = Main_Form.user_level
    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        mainTabControl.SelectedIndex = 1
        reasonForArchived = txtReasonForArchived.Text
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
            MsgBox("Please fill out the required fields!")
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
                ViewResident.archiveResident()
            ElseIf originForm = "Accounts" Then
                Account_Settings.ShowDialog()
            ElseIf originForm = "BrgyOfficials" Then
                UpdateBrgyOfficials.ShowDialog()
            ElseIf originForm = "DismissBrgyOfficial" Then
                UpdateBrgyOfficials.dismissOfficial()
            End If
        Else
            txtPassword.Clear()
            MsgBox("Password Incorrect!, Please try again", vbCritical, "Warning")
        End If
        mySQLCommand.Dispose()
        mySQLReader.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub ConfirmAccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtPassword.Clear()
        txtReasonForArchived.Clear()
    End Sub

    Private Sub ConfirmAccess_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
    End Sub
End Class