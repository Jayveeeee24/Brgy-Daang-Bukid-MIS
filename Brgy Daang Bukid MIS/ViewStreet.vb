Imports MySql.Data.MySqlClient

Public Class ViewStreet
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public streetName As String
    Dim total As Integer = 0

    Private Sub ViewStreet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.VerticalScroll.Value = 0
        loadInitialData()
    End Sub

    Private Sub ViewStreet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()
    End Sub

    Private Sub clearEverything()
        datagridHoseholds.Rows.Clear()
        labelStreetName.Text = ""
        labelNoHousehold.Text = ""
        labelResidents.Text = ""
        labelMale.Text = ""
        labelFemale.Text = ""
        labelSeniors.Text = ""
        labelRegisteredVoters.Text = ""
        labelUnemployed.Text = ""
        labelPwd.Text = ""
        comboTemp.Items.Clear()

        Panel1.VerticalScroll.Value = 0
        total = 0
    End Sub
    Private Sub loadInitialData()
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
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT household_id, bldg_no FROM household where street_name LIKE @streetname"
        cmd.Parameters.AddWithValue("@streetname", "%" & streetName & "%")
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                comboTemp.Items.Add(mySQLReader!household_id)
                datagridHoseholds.Rows.Add(New String() {mySQLReader!household_id, getHouseholdHeadById(mySQLReader!household_id), mySQLReader!bldg_no})
            End While
        End If
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        getStatistic()

    End Sub

    Private Sub getIndividualStatistic(ByVal loopCount As Integer, ByVal action As String)
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

        If action = "Female" Then
            cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid and sex LIKE 'Female'"
        ElseIf action = "Male" Then
            cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid and sex LIKE 'Male'"
        ElseIf action = "Senior" Then
            cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid and age > 60"
        ElseIf action = "Voter" Then
            cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid and is_voter LIKE 'Yes'"
        ElseIf action = "PWD" Then
            cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid and is_pwd LIKE 'Yes'"
        ElseIf action = "Unemployed" Then
            cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid and (occupation LIKE 'Student' or occupation LIKE 'N/A' or occupation LIKE '' or occupation LIKE 'NA' or occupation LIKE 'No Work')"
        ElseIf action = "Residents" Then
            cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid "
        End If

        comboTemp.SelectedIndex = loopCount
        cmd.Parameters.AddWithValue("@householdid", comboTemp.Text)

        Dim temp As Integer = cmd.ExecuteScalar()
        total = temp + total

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        If loopCount < comboTemp.Items.Count Then
            getIndividualStatistic(loopCount + 1, action)
        End If

    End Sub

    Private Sub getStatistic()

        labelStreetName.Text = streetName
        labelNoHousehold.Text = comboTemp.Items.Count

        getIndividualStatistic(0, "Female")
        labelFemale.Text = total
        total = 0

        getIndividualStatistic(0, "Male")
        labelMale.Text = total
        total = 0

        getIndividualStatistic(0, "Senior")
        labelSeniors.Text = total
        total = 0

        getIndividualStatistic(0, "Voter")
        labelRegisteredVoters.Text = total
        total = 0

        getIndividualStatistic(0, "PWD")
        labelPwd.Text = total
        total = 0

        getIndividualStatistic(0, "Unemployed")
        labelUnemployed.Text = total
        total = 0

        getIndividualStatistic(0, "Residents")
        labelResidents.Text = total
        total = 0

    End Sub

    Private Function getHouseholdHeadById(ByVal householdId As String) As String

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
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT first_name, middle_name, last_name, ext_name FROM residents where household_id = @householdid And household_role = 'Head'"
        cmd.Parameters.AddWithValue("@householdid", householdId)
        mySQLReader = cmd.ExecuteReader
        Dim headName As String = ""
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                headName = mySQLReader!first_name + " " + If(mySQLReader!middle_name = Nothing Or mySQLReader!middle_name = "", "", mySQLReader!middle_name + " ") + mySQLReader!last_name + mySQLReader!ext_name
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        Return headName
    End Function

    Private Sub datagridHoseholds_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridHoseholds.CellClick
        If e.RowIndex >= 0 Then
            ViewHousehold.householdId = datagridHoseholds.Rows(e.RowIndex).Cells(0).Value
            ViewHousehold.ShowDialog()
        End If
    End Sub
End Class