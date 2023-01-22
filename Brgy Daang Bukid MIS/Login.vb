Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Login

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Dim isValidated As Boolean = False
    Dim userClick As Integer = 0
    Dim passClick As Integer = 0

    Private visibilityImage As Image
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isAccountAvailable() = False Then
            Create_Account.action = "initial"
            Create_Account.Show()
            Me.Close()
        End If
    End Sub


    Private Function isAccountAvailable() As Boolean
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
        cmd.CommandText = "SELECT count(*) FROM accounts"
        If cmd.ExecuteScalar() = 0 Then
            Return False
        Else
            Return True
        End If
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function


    Private Function GetVisibilityImage(ByVal imageName As String) As Image
        If imageName = "visible" Then
            visibilityImage = My.Resources.visi_off
        Else
            visibilityImage = My.Resources.visi
        End If
        Return visibilityImage
    End Function

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        If txtUsername.Text = "Username*" Then
            txtUsername.Clear()
        End If
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If txtPassword.Text = "Password*" Then
            txtPassword.Clear()
        End If
    End Sub

    Private Sub labelNoAccount_Click(sender As Object, e As EventArgs) Handles labelNoAccount.Click
        NoAccount.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Me.Enabled = False

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                Me.Enabled = True
                mySql.Close()
                mySql.Dispose()
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Select()
                Return
        End Select

        If Len(txtUsername.Text.Trim) = 0 Or Len(txtPassword.Text.Trim) = 0 Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Me.Enabled = True
            txtUsername.Text = "Username*"
            txtUsername.Select()
            txtPassword.Text = "Password*"
        Else

            Dim mySQLCommand As MySqlCommand
            Dim mySQLReader As MySqlDataReader
            mySQLCommand = mySql.CreateCommand()
            mySQLCommand.CommandType = CommandType.Text

            mySQLCommand.CommandText = "SELECT * FROM accounts WHERE BINARY account_name=@username AND BINARY account_password=@password"
            mySQLCommand.Parameters.AddWithValue("@username", txtUsername.Text)
            mySQLCommand.Parameters.AddWithValue("@password", txtPassword.Text)


            mySQLReader = mySQLCommand.ExecuteReader
            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    Main_Form.account_id = mySQLReader!account_id
                    Main_Form.user_name = mySQLReader!account_name
                    Main_Form.user_level = mySQLReader!user_level
                End While
                Main_Form.Show()
                Me.Close()
            Else
                txtUsername.Clear()
                txtPassword.Clear()
                Me.Enabled = True
                MsgBox("Incorrect login credentials!, Please try again", vbCritical, "Warning")
                txtUsername.Select()
            End If
            mySQLCommand.Dispose()
            mySQLReader.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    'handles the action whenever the user 'enter' in the password
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnVisibility_Click(sender As Object, e As EventArgs) Handles btnVisibility.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            btnVisibility.Image = GetVisibilityImage("visible")
        Else
            txtPassword.PasswordChar = "*"
            btnVisibility.Image = GetVisibilityImage("invisible")
        End If
    End Sub

    Private Sub labelForgotPassword_Click(sender As Object, e As EventArgs) Handles labelForgotPassword.Click
        ForgotPassword.ShowDialog()
    End Sub
End Class
