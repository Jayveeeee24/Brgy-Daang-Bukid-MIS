Imports MySql.Data.MySqlClient

Public Class Filter
    Public filterModule As String

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"

    Private Sub Filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        mainTabControl.SelectedIndex = 0

        If filterModule = "Household" Then
            mainTabControl.SelectedIndex = 1
        End If

        If mainTabControl.SelectedIndex = 0 Then
            setUpInitialData()
        Else

        End If


    End Sub

    Private Sub setUpInitialData()
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

        comboHouseholdId.Items.Add("Any")

        cmd.CommandText = "SELECT household_id from household"
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                comboHouseholdId.Items.Add(mySQLReader!household_id)
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        comboHouseholdId.SelectedIndex = If(comboHouseholdId.FindStringExact(Main_Form.filterHouseholdId) = 0 Or comboHouseholdId.FindStringExact(Main_Form.filterHouseholdId) = -1, 0, comboHouseholdId.FindStringExact(Main_Form.filterHouseholdId))
        comboSex.SelectedIndex = If(Main_Form.filterSex = "", 0, comboSex.FindStringExact(Main_Form.filterSex))
        comboCivilStatus.SelectedIndex = If(Main_Form.filterCivilStatus = "", 0, comboCivilStatus.FindStringExact(Main_Form.filterCivilStatus))
        comboPwd.SelectedIndex = If(Main_Form.filterPwd = "", 0, comboPwd.FindStringExact(Main_Form.filterPwd))
        comboHouseholdRole.SelectedIndex = If(Main_Form.filterHouseholdRole = "", 0, comboHouseholdRole.FindStringExact(Main_Form.filterHouseholdRole))
        comboMonthRegistered.SelectedIndex = If(Main_Form.filterSex = "", 0, comboMonthRegistered.FindStringExact(Main_Form.filterMonth))

        txtAgeMin.Text = If(Main_Form.filterMinAge = 0, "", Main_Form.filterMinAge)
        txtAgeMax.Text = If(Main_Form.filterMaxAge = 0, "", Main_Form.filterMaxAge)
        txtDayRegistered.Text = If(Main_Form.filterDay = 0, "", Main_Form.filterDay)
        txtYearRegistered.Text = If(Main_Form.filterYear = 0, "", Main_Form.filterYear)
    End Sub

    Public Sub clearEverything()

        'comboHouseholdId.Text = ""
        comboSex.SelectedIndex = 0
        comboCivilStatus.SelectedIndex = 0
        comboPwd.SelectedIndex = 0
        comboHouseholdRole.SelectedIndex = 0
        comboMonthRegistered.SelectedIndex = 0
        comboHouseholdId.Items.Clear()
        comboHouseholdId.Text = ""


        txtAgeMin.Text = ""
        txtAgeMax.Text = ""
        txtDayRegistered.Text = ""
        txtYearRegistered.Text = ""

        Main_Form.filterHouseholdId = 0
        Main_Form.filterMinAge = 0
        Main_Form.filterMaxAge = 0
        Main_Form.filterDay = 0
        Main_Form.filterYear = 0

        Main_Form.filterSex = ""
        Main_Form.filterCivilStatus = ""
        Main_Form.filterPwd = ""
        Main_Form.filterHouseholdRole = ""
        Main_Form.filterMonth = ""

    End Sub

    Private Sub txtViewKeyDown(sender As Object, e As KeyEventArgs) Handles txtYearRegistered.KeyDown, txtDayRegistered.KeyDown, txtAgeMin.KeyDown, txtAgeMax.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtViewKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYearRegistered.KeyPress, txtDayRegistered.KeyPress, txtAgeMin.KeyPress, txtAgeMax.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnClearSelectionResidents_Click(sender As Object, e As EventArgs) Handles btnClearSelectionResidents.Click
        clearEverything()
        setUpInitialData()
    End Sub

    Private Sub btnApplyFiltersResidents_Click(sender As Object, e As EventArgs) Handles btnApplyFiltersResidents.Click

        If txtAgeMin.Text.Trim <> "" And txtAgeMax.Text.Trim = "" Then
            MsgBox("Please fill out a valid AGE range!", vbExclamation, "Warning")
            Exit Sub
        End If

        If txtAgeMin.Text.Trim = "" And txtAgeMax.Text.Trim <> "" Then
            MsgBox("Please fill out a valid AGE range!", vbExclamation, "Warning")
            Exit Sub
        End If

        If Int(If(txtAgeMin.Text.Trim = "", 0, txtAgeMin.Text)) >= Int(If(txtAgeMax.Text.Trim = "", 0, txtAgeMax.Text)) And txtAgeMin.Text.Trim <> "" Then
            MsgBox("Please fill out a valid AGE range!", vbExclamation, "Warning")
            Exit Sub
        End If

        If Int(If(txtDayRegistered.Text.Trim = "", 0, txtDayRegistered.Text)) > 31 And txtDayRegistered.Text.Trim <> "" Then
            MsgBox("Please fill out a valid day registered!", vbExclamation, "Warning")
            Exit Sub
        End If
        If txtYearRegistered.Text.Trim <> "" And Int(If(txtYearRegistered.Text.Trim = "", 0, txtYearRegistered.Text)) < 1111 Or Int(If(txtYearRegistered.Text.Trim = "", 0, txtYearRegistered.Text)) > 3000 Then
            MsgBox("Please fill out a valid year registered!", vbExclamation, "Warning")
            Exit Sub
        End If

        Main_Form.filterHouseholdId = If(comboHouseholdId.FindStringExact(comboHouseholdId.Text) = -1 Or comboHouseholdId.FindStringExact(comboHouseholdId.Text) = 0 Or comboHouseholdId.Text = "Any", 0, comboHouseholdId.Text)

        Main_Form.filterMinAge = If(txtAgeMin.Text.Trim = "", 0, Int(txtAgeMin.Text))
        Main_Form.filterMaxAge = If(txtAgeMax.Text.Trim = "", 0, Int(txtAgeMax.Text))
        Main_Form.filterDay = If(txtDayRegistered.Text.Trim = "", 0, Int(txtDayRegistered.Text))
        Main_Form.filterYear = If(txtYearRegistered.Text.Trim = "", 0, Int(txtYearRegistered.Text))

        Main_Form.filterSex = If(comboSex.Text.Trim = "Any", "", comboSex.Text)
        Main_Form.filterCivilStatus = If(comboCivilStatus.Text.Trim = "Any", "", comboCivilStatus.Text)
        Main_Form.filterPwd = If(comboPwd.Text.Trim = "Any", "", comboPwd.Text)
        Main_Form.filterHouseholdRole = If(comboHouseholdRole.Text.Trim = "Any", "", comboHouseholdRole.Text)
        Main_Form.filterMonth = If(comboMonthRegistered.Text.Trim = "Any", "", comboMonthRegistered.Text)

        Main_Form.txtPageNoResident.Text = 1
        Main_Form.loadDataGrid(Main_Form.datagridResident, Main_Form.Modules.Residents)
        Main_Form.countRows()

        Me.Close()

    End Sub
End Class