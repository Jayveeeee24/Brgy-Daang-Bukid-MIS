
Imports System.Data
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class Account_Settings

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"

    Private visibilityImage As Image
    Private Sub Account_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAccountName.Text = Main_Form.account_position
        txtUsername.Text = Main_Form.user_name
        If Main_Form.account_id = 2 Then
            panelGuestAccount.Hide()
        Else
            panelGuestAccount.Show()
        End If
    End Sub

    Private Sub txtViewGuest_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswordGuest.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePasswordGuest.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtViewtKeydown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Account_Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtPassword.Clear()
        txtPasswordGuest.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Me.Enabled = False

        If txtPassword.Text.Trim = "" Or txtUsername.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
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

        mySQLCommand.CommandText = "UPDATE accounts SET account_password = @accountpassword, account_name = @accountname WHERE account_id = @accountid"
        mySQLCommand.Parameters.AddWithValue("@accountid", Main_Form.account_id)
        mySQLCommand.Parameters.AddWithValue("@accountpassword", txtPassword.Text.Trim)
        mySQLCommand.Parameters.AddWithValue("@accountname", txtUsername.Text.Trim)
        mySQLCommand.ExecuteNonQuery()

        Me.Enabled = True
        txtPassword.Clear()
        MsgBox("Password Changed!", vbInformation, "Information")
        mySQLCommand.Dispose()
        mySql.Close()
        mySql.Dispose()

        Me.Close()

    End Sub
    Private Sub btnChangePasswordGuest_Click(sender As Object, e As EventArgs) Handles btnChangePasswordGuest.Click
        Me.Enabled = False

        If txtPasswordGuest.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
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
                txtPasswordGuest.Clear()
                mySql.Close()
                mySql.Dispose()
                Exit Sub
        End Select

        Dim mySQLCommand As MySqlCommand
        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text

        mySQLCommand.CommandText = "UPDATE accounts SET account_password = @accountpassword WHERE account_id = 3 "
        mySQLCommand.Parameters.AddWithValue("@accountpassword", txtPasswordGuest.Text.Trim)
        mySQLCommand.ExecuteNonQuery()
        Me.Enabled = True
        txtPasswordGuest.Clear()
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

    Private Sub btnVisibilityGuest_Click(sender As Object, e As EventArgs) Handles btnVisibilityGuest.Click
        If txtPasswordGuest.PasswordChar = "*" Then
            txtPasswordGuest.PasswordChar = ""
            btnVisibilityGuest.Image = GetVisibilityImage("visible")
        Else
            txtPasswordGuest.PasswordChar = "*"
            btnVisibilityGuest.Image = GetVisibilityImage("invisible")
        End If
    End Sub
End Class