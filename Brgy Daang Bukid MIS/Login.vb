Imports System.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Login

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Dim isValidated As Boolean = False
    Dim userClick As Integer = 0
    Dim passClick As Integer = 0
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        If userClick = 0 And txtUsername.Text = "Username*" Then
            txtUsername.Clear()
            userClick = 1
        End If
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If passClick = 0 And txtPassword.Text = "Password*" Then
            txtPassword.Clear()
            passClick = 1
        End If
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
                MessageBox.Show("Sever Connection Lost!")
        End Select

        Dim mySQLCommand As MySqlCommand
        Dim mySQLReader As MySqlDataReader

        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text
        mySQLCommand.CommandText = "SELECT * FROM accounts WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'"
        mySQLReader = mySQLCommand.ExecuteReader
        If Len(txtUsername.Text) = 0 Or Len(txtPassword.Text) = 0 Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning!")
        Else
            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    Main_Form.account_type = mySQLReader!account_type
                End While
                Main_Form.Show()
                Me.Close()
            Else
                txtPassword.Clear()
                Me.Enabled = True
                MsgBox("No account found!")
            End If
        End If

        mySQLCommand.Dispose()
        mySQLReader.Dispose()
        mySql.Close()
        mySql.Dispose()

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnLogin.PerformClick()
        End If
    End Sub
End Class
