Imports MySql.Data.MySqlClient


Public Class AddVariable
    Public mySqlConn As String = My.Resources.constring
    Public variableId As Integer = 0
    Public action As String

    Private Sub AddVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainTabControl.ItemSize = New Size(0, 1)

        If action = "add" Then
            mainTabControl.SelectedIndex = 0
        Else
            mainTabControl.SelectedIndex = 1
        End If
    End Sub
    Private Sub AddVariable_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
        variableId = 0
    End Sub
    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddVariableName.KeyDown, txtModifyVariableName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnAddVariable_Click(sender As Object, e As EventArgs) Handles btnAddVariable.Click
        If txtAddVariableName.Text.Trim = "" Then
            MsgBox("Please provide a valid variable name!", vbCritical, "Warning")
            Exit Sub
        End If
        If isVariableNameAvailable(txtAddVariableName, labelAddVariableCategory) = False Then
            MsgBox("Variable name already exists!", vbCritical, "Warning")
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
        End Select

        Dim cmd As MySqlCommand
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO system_variables (variable_name, variable_type) VALUES (@variablename, @variabletype)"
        cmd.Parameters.AddWithValue("@variablename", txtAddVariableName.Text.Trim)
        cmd.Parameters.AddWithValue("@variabletype", labelAddVariableCategory.Text)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        MsgBox("Variable: " & txtAddVariableName.Text.Trim & " has been added to " & labelAddVariableCategory.Text & " category!", vbInformation, "Information")
        Me.Close()

        SystemVariables.loadDatagrid()
        variableId = 0
        SystemVariables.btnDeleteVariable.Enabled = False
        SystemVariables.btnModifyVariable.Enabled = False
        SystemVariables.datagridViewSystemVariables.ClearSelection()
    End Sub

    Private Sub btnModifyVariable_Click(sender As Object, e As EventArgs) Handles btnModifyVariable.Click
        If txtModifyVariableName.Text.Trim = "" Then
            MsgBox("Please provide a valid variable name!", vbCritical, "Warning")
            Exit Sub
        End If
        If isVariableNameAvailable(txtModifyVariableName, labelModifyVariableCategory) = False Then
            MsgBox("Variable name already exists!", vbCritical, "Warning")
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
        End Select

        Dim cmd As MySqlCommand
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE system_variables SET variable_name = @variablename WHERE id = @id"
        cmd.Parameters.AddWithValue("@variablename", txtAddVariableName.Text.Trim)
        cmd.Parameters.AddWithValue("@id", variableId)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        MsgBox("Variable: " & txtAddVariableName.Text.Trim & " has been updated!", vbInformation, "Information")
        Me.Close()

        SystemVariables.loadDatagrid()
        variableId = 0
        SystemVariables.btnDeleteVariable.Enabled = False
        SystemVariables.btnModifyVariable.Enabled = False
        SystemVariables.datagridViewSystemVariables.ClearSelection()
    End Sub
    Private Function isVariableNameAvailable(txtView As TextBox, labelView As Label) As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from system_variables WHERE variable_name = @variablename and variable_type = @variabletype"
        cmd.Parameters.AddWithValue("@variablename", txtView.Text.Trim)
        cmd.Parameters.AddWithValue("@variabletype", labelView.Text)

        If cmd.ExecuteScalar = 0 Then
            Return True
        Else
            Return False
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function
End Class