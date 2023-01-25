Imports MySql.Data.MySqlClient

Public Class SystemVariables

    Public mySqlConn As String = My.Resources.constring
    Public variableId As Integer
    Public variableName As String
    Private Sub SystemVariables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboSystemVariables.SelectedIndex = 0
    End Sub
    Private Sub SystemVariables_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Sub comboSystemVariables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSystemVariables.SelectedIndexChanged
        loadDatagrid()
    End Sub
    Public Sub loadDatagrid()
        datagridViewSystemVariables.Rows.Clear()

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

        mySQLCommand.CommandText = "SELECT id, variable_name FROM system_variables WHERE variable_type=@type " & If(txtSearchVariable.Text.Trim = "" Or txtSearchVariable.Text.Trim = "Search by variable name", "", " AND variable_name = @variablename")
        mySQLCommand.Parameters.AddWithValue("@type", comboSystemVariables.Text)
        mySQLCommand.Parameters.AddWithValue("@variablename", txtSearchVariable.Text.Trim)


        mySQLReader = mySQLCommand.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                datagridViewSystemVariables.Rows.Add(New String() {mySQLReader!id, mySQLReader!variable_name})
            End While
        End If
        mySQLCommand.Dispose()
        mySQLReader.Dispose()
        mySql.Close()
        mySql.Dispose()
        datagridViewSystemVariables.ClearSelection()
    End Sub

    Private Sub txtSearchVariable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchVariable.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSearchVariable.PerformClick()
        End If
    End Sub

    Private Sub btnSearchVariable_Click(sender As Object, e As EventArgs) Handles btnSearchVariable.Click
        loadDatagrid()
    End Sub

    Private Sub btnAddVariable_Click(sender As Object, e As EventArgs) Handles btnAddVariable.Click
        AddVariable.action = "add"
        AddVariable.labelAddVariableCategory.Text = comboSystemVariables.Text
        AddVariable.ShowDialog()
    End Sub

    Private Sub btnModifyVariable_Click(sender As Object, e As EventArgs) Handles btnModifyVariable.Click
        AddVariable.action = "modify"
        AddVariable.variableId = variableId
        AddVariable.txtModifyVariableName.Text = variableName
        AddVariable.labelModifyVariableCategory.Text = comboSystemVariables.Text

        AddVariable.ShowDialog()
    End Sub

    Private Sub btnDeleteVariable_Click(sender As Object, e As EventArgs) Handles btnDeleteVariable.Click
        If MsgBox("Are you sure to delete this variable?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            ConfirmAccess.originForm = "DeleteVariable"
            ConfirmAccess.Show()
        End If
    End Sub
    Public Sub deleteVariable()
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

        cmd.CommandText = "DELETE FROM system_variables WHERE id = @id"
        cmd.Parameters.AddWithValue("@id", variableId)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Official Dismissed!", vbInformation, "Information")
        loadDatagrid()
        variableId = 0
        btnDeleteVariable.Enabled = False
        btnModifyVariable.Enabled = False
        datagridViewSystemVariables.ClearSelection()
    End Sub

    Private Sub datagridViewSystemVariables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridViewSystemVariables.CellClick
        If e.RowIndex >= 0 Then
            btnModifyVariable.Enabled = True
            btnDeleteVariable.Enabled = True
            variableId = datagridViewSystemVariables.Rows(e.RowIndex).Cells(0).Value
            variableName = datagridViewSystemVariables.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub
End Class