Imports MySql.Data.MySqlClient

Public Class ForgotPassword

    Public mySqlConn As String = My.Resources.constring
    Dim accountId As Integer
    Private visibilityImage As Image
    Dim oldPass As String

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnUsername.PerformClick()
        End If
    End Sub

    Private Sub txtAnswer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnRecovery.PerformClick()
        End If
    End Sub

    Private Sub txtConfirmPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirmPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnPassword.PerformClick()
        End If
    End Sub

    Private Sub txtNewPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNewPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnUsername_Click(sender As Object, e As EventArgs) Handles btnUsername.Click
        If txtUsername.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Exit Sub
        Else
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
            Dim mySQLCommand As MySqlCommand
            Dim mySQLReader As MySqlDataReader
            mySQLCommand = mySql.CreateCommand()
            mySQLCommand.CommandType = CommandType.Text


            mySQLCommand.CommandText = "SELECT * FROM accounts WHERE BINARY account_name= @accountname"
            mySQLCommand.Parameters.AddWithValue("@accountname", txtUsername.Text.Trim)


            mySQLReader = mySQLCommand.ExecuteReader
            If mySQLReader.HasRows Then
                mainTabControl.SelectedIndex = 1
                While mySQLReader.Read
                    accountId = mySQLReader!account_id
                    oldPass = mySQLReader!account_password
                    labelRecovery.Text = mySQLReader!question
                End While
            Else
                MsgBox("No account found!, Please try again", vbCritical, "Warning")
                txtUsername.Clear()
                txtUsername.Select()
            End If
            mySQLCommand.Dispose()
            mySQLReader.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click

        If txtAnswer.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Exit Sub
        Else
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

            Dim mySQLCommand As MySqlCommand
            mySQLCommand = mySql.CreateCommand()
            mySQLCommand.CommandType = CommandType.Text


            mySQLCommand.CommandText = "SELECT count(*) FROM accounts WHERE BINARY account_id= @accountid and answer = @answer"
            mySQLCommand.Parameters.AddWithValue("@accountid", accountId)
            mySQLCommand.Parameters.AddWithValue("@answer", txtAnswer.Text.Trim)

            If mySQLCommand.ExecuteScalar = 0 Then
                MsgBox("Incorrect Recovery Answer, Please try again", vbCritical, "Warning")
                txtAnswer.Clear()
            Else
                mainTabControl.SelectedIndex = 2
            End If
            mySQLCommand.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If txtNewPassword.Text.Trim = "" Or txtConfirmPassword.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
        ElseIf txtNewPassword.Text.Trim <> txtConfirmPassword.Text.Trim Then
            MsgBox("Password didn't match, Please try again!", vbCritical, "Warning")
        ElseIf txtNewPassword.Text.Trim = oldPass Then
            MsgBox("It is the same as the old password, Please try again", vbCritical, "Warning")
        Else
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

            Dim mySQLCommand As MySqlCommand
            mySQLCommand = mySql.CreateCommand()
            mySQLCommand.CommandType = CommandType.Text


            mySQLCommand.CommandText = "UPDATE accounts SET account_password= @accountpassword WHERE account_id = @accountid"
            mySQLCommand.Parameters.AddWithValue("@accountid", accountId)
            mySQLCommand.Parameters.AddWithValue("@accountpassword", txtNewPassword.Text.Trim)
            mySQLCommand.ExecuteNonQuery()

            mySQLCommand.Dispose()
            mySql.Close()
            mySql.Dispose()
            MsgBox("Password has been updated!", vbInformation, "Information")
            Login.Show()
            Me.Close()
        End If
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        txtNewPassword.Select()
    End Sub

    Private Sub ForgotPassword_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtUsername.Clear()
        txtAnswer.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        accountId = 0
        mainTabControl.SelectedIndex = 0
    End Sub

    Private Sub btnNewPassowrd_Click(sender As Object, e As EventArgs) Handles btnNewPassowrd.Click
        If txtNewPassword.PasswordChar = "*" Then
            txtNewPassword.PasswordChar = ""
            btnNewPassowrd.Image = GetVisibilityImage("visible")
        Else
            txtNewPassword.PasswordChar = "*"
            btnNewPassowrd.Image = GetVisibilityImage("invisible")
        End If
    End Sub

    Private Sub btnConfirmPassword_Click(sender As Object, e As EventArgs) Handles btnConfirmPassword.Click
        If txtConfirmPassword.PasswordChar = "*" Then
            txtConfirmPassword.PasswordChar = ""
            btnConfirmPassword.Image = GetVisibilityImage("visible")
        Else
            txtConfirmPassword.PasswordChar = "*"
            btnConfirmPassword.Image = GetVisibilityImage("invisible")
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

End Class
