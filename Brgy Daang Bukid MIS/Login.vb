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

    Private visibilityImage As Image
    Private Function GetVisibilityImage(ByVal imageName As String) As Image
        If imageName = "visible" Then
            visibilityImage = My.Resources.visi_off
        Else
            visibilityImage = My.Resources.visi
        End If
        Return visibilityImage
    End Function

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
                Return
        End Select

        If Len(txtUsername.Text.Trim) = 0 Or Len(txtPassword.Text.Trim) = 0 Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Me.Enabled = True
            txtUsername.Text = "Username*"
            txtPassword.Text = "Password*"
        Else
            Dim mySQLCommand As MySqlCommand
            Dim mySQLReader As MySqlDataReader
            mySQLCommand = mySql.CreateCommand()
            mySQLCommand.CommandType = CommandType.Text
            mySQLCommand.CommandText = "SELECT * FROM accounts WHERE BINARY username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'"
            mySQLReader = mySQLCommand.ExecuteReader
            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    Main_Form.account_type = mySQLReader!account_type
                End While
                Main_Form.Show()
                Me.Close()
            Else
                txtPassword.Clear()
                Me.Enabled = True
                MsgBox("No account found!, Please try again", vbCritical, "Warning")
            End If
            mySQLCommand.Dispose()
            mySQLReader.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If

    End Sub

    'handles the action whenever the user 'enter' in the password
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter And Len(txtPassword.Text) = 0 Then
            Me.btnLogin.PerformClick()
        ElseIf e.KeyCode = Keys.Enter And Len(txtPassword.Text) <> 0 Then
            txtPassword.Text.Remove(txtPassword.Text.Length - 1)
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

    Private Sub labelNoAccount_Click(sender As Object, e As EventArgs) Handles labelNoAccount.Click

    End Sub
End Class
