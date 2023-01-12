Imports MySql.Data.MySqlClient


Public Class Create_Account
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Private visibilityImage As Image


    Private Sub Create_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboRecoveryAdmin.SelectedIndex = 0
        comboRecoveryStaff.SelectedIndex = 0
    End Sub

    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsernameStaff.KeyDown, txtUsernameAdmin.KeyDown, txtPasswordStaff.KeyDown, txtPasswordAdmin.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSaveAccounts_Click(sender As Object, e As EventArgs) Handles btnSaveAccounts.Click
        If txtUsernameAdmin.Text.Trim = "" Or txtPasswordAdmin.Text.Trim = "" Or txtUsernameStaff.Text.Trim = "" Or txtPasswordStaff.Text.Trim = "" Or txtAnswerAdmin.Text.Trim = "" Or txtAnswerStaff.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Exit Sub
        End If
        saveAccount(1, txtUsernameAdmin.Text.Trim, txtPasswordAdmin.Text.Trim, txtLevelAdmin.Text, comboRecoveryAdmin.Text, txtAnswerAdmin.Text.Trim)
        saveAccount(2, txtUsernameStaff.Text.Trim, txtPasswordStaff.Text.Trim, txtLevelStaff.Text, comboRecoveryStaff.Text, txtAnswerStaff.Text.Trim)
        saveAccount(3, "guest", "guest", "Guest", "", "")
        MsgBox("Initial Setup finished!", vbInformation, "Information")
        Login.Show()
        Me.Close()

    End Sub

    Private Sub saveAccount(ByVal accountid As Integer, ByVal accountname As String, ByVal accountpassword As String, ByVal userlevel As String, ByVal question As String, ByVal answer As String)
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

        cmd.CommandText = "INSERT INTO accounts (account_id, account_name, account_password, user_level, question, answer) VALUES (@accountid, @accountname, @accountpassword, @userlevel, @question, @answer)"
        cmd.Parameters.AddWithValue("@accountid", accountid)
        cmd.Parameters.AddWithValue("@accountname", accountname)
        cmd.Parameters.AddWithValue("@accountpassword", accountpassword)
        cmd.Parameters.AddWithValue("@userlevel", userlevel)
        cmd.Parameters.AddWithValue("@question", question)
        cmd.Parameters.AddWithValue("@answer", answer)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub btnVisibilityAdmin_Click(sender As Object, e As EventArgs) Handles btnVisibilityAdmin.Click
        If txtPasswordAdmin.PasswordChar = "*" Then
            txtPasswordAdmin.PasswordChar = ""
            btnVisibilityAdmin.Image = GetVisibilityImage("visible")
        Else
            txtPasswordAdmin.PasswordChar = "*"
            btnVisibilityAdmin.Image = GetVisibilityImage("invisible")
        End If
    End Sub

    Private Sub btnVisibilityStaff_Click(sender As Object, e As EventArgs) Handles btnVisibilityStaff.Click
        If txtPasswordStaff.PasswordChar = "*" Then
            txtPasswordStaff.PasswordChar = ""
            btnVisibilityStaff.Image = GetVisibilityImage("visible")
        Else
            txtPasswordStaff.PasswordChar = "*"
            btnVisibilityStaff.Image = GetVisibilityImage("invisible")
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