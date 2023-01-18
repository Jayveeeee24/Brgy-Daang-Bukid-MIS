Imports MySql.Data.MySqlClient


Public Class Create_Account
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Private visibilityImage As Image
    Public action As String


    Private Sub Create_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboRecovery.SelectedIndex = 0
        comboAccountFor.Select()

        Dim official() As String = {"Barangay Captain", "Barangay Secretary", "Barangay Treasurer", "SK Chairperson"}
        Dim i As Integer
        If action = "initial" Then
            txtUserLevel.Text = "Administrator"
            For i = 0 To official.Length - 1
                comboAccountFor.Items.Add(official(i))
            Next i

            comboAccountFor.SelectedIndex = 0
            comboAccountFor.Enabled = False
            labelTitle.Text = "INITIAL SETUP: ACCOUNT CREATION"
            Me.Text = "Initial Setup: Management Information System of Barangay Daang Bukid"
        Else
            txtUserLevel.Text = "Staff"
            For i = 1 To official.Length - 1
                comboAccountFor.Items.Add(official(i))
            Next i

            comboAccountFor.SelectedIndex = 0
            comboAccountFor.Enabled = True

            labelTitle.Text = "ACCOUNT CREATION"
            Me.Text = "CREATE AN ACCOUNT"
        End If
    End Sub

    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsernameAdmin.KeyDown, txtPassword.KeyDown, txtConfirmPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSaveAccounts_Click(sender As Object, e As EventArgs) Handles btnSaveAccounts.Click
        If txtUsernameAdmin.Text.Trim = "" Or txtPassword.Text.Trim = "" Or txtConfirmPassword.Text.Trim = "" Or txtAnswer.Text.Trim = "" Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtPassword.Text.Trim <> txtConfirmPassword.Text Then
            MsgBox("Password and confirm password must match!", vbCritical, "Warning")
            Exit Sub
        End If

        If action = "initial" Then
            saveAccount(1, txtUsernameAdmin.Text.Trim, txtPassword.Text.Trim, txtUserLevel.Text, comboRecovery.Text, txtAnswer.Text.Trim)
            MsgBox("Initial Setup finished!", vbInformation, "Information")
            Login.Show()
            Me.Close()
        Else
            If isAccountAvailable(comboAccountFor.FindStringExact(comboAccountFor.Text) + 2) = True Then
                saveAccount(comboAccountFor.FindStringExact(comboAccountFor.Text) + 2, txtUsernameAdmin.Text.Trim, txtPassword.Text.Trim, txtUserLevel.Text, comboRecovery.Text, txtAnswer.Text.Trim)
                MsgBox("Account Saved!", vbInformation, "Information")
                AccountManagement.loadDatagrid()
                Me.Close()
            Else
                MsgBox("Account already exist for this position!", vbCritical, "Warning")
                Exit Sub
            End If
        End If

    End Sub
    Private Function isAccountAvailable(ByVal id As Integer) As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from accounts WHERE account_id = '" & id & "'"

        If cmd.ExecuteScalar = 0 Then
            Return True
        Else
            Return False
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function
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

    Private Sub btnVisibilityPassword_Click(sender As Object, e As EventArgs) Handles btnVisibilityPassword.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            btnVisibilityPassword.Image = GetVisibilityImage("visible")
        Else
            txtPassword.PasswordChar = "*"
            btnVisibilityPassword.Image = GetVisibilityImage("invisible")
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

    Private Sub Create_Account_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

End Class