Imports System.Data
Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient

Public Class Main_Form
    Public account_type As String
    Public account_id As Integer
    Public account_name As String
    Public filterModule As String
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Dim totalRowsResident As Integer
    Dim totalPageResident As Integer

    Dim totalRowsHousehold As Integer
    Dim totalPageHousehold As Integer


    ''variables for filtering residents
    Public filterHouseholdId, filterMinAge, filterMaxAge, filterDay, filterYear As Integer
    Public filterSex, filterCivilStatus, filterPwd, filterHouseholdRole, filterMonth As String

    ''variables for filtering household
    Public filterResidenceType, filterHouseType, filterStreetName, filterBldgNo, filterWaterSource, filterElectricitySource, filterMonthAdded As String
    Public filterDayAdded, filterYearAdded As Integer


    Enum Modules
        BrgyOfficials
        Residents
        Household
        Report
        Certificates
    End Enum

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainTabControl.ItemSize = New Size(0, 1)
        btnDashboard.PerformClick()
        getAccountDetails()

        EnableDoubleBuffered(dataGridBrgyOfficials)
        EnableDoubleBuffered(datagridResident)
        EnableDoubleBuffered(datagridHousehold)

    End Sub

    Private Sub getAccountDetails()
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                mySql.Close()
                mySql.Dispose()
                Exit Sub
        End Select

        Dim mySQLCommand As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text

        mySQLCommand.CommandText = "SELECT * FROM brgyofficials WHERE id = @account_id"
        mySQLCommand.Parameters.AddWithValue("@account_id", account_id)
        mySQLReader = mySQLCommand.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read

                account_name = mySQLReader!official_name + " [" + mySQLReader!official_position + "]"
                labelSignedIn.Text = "Logged in as: " + account_name
            End While
        End If
        mySQLCommand.Dispose()
        mySQLReader.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    '' ''''''''''''''''''''''RESIDENT UI DEFINITIONS''''''''''''''''''''''''
    Private Sub txtPageNoResident_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPageNoResident.KeyDown
        enterTextPageNo(e, txtPageNoResident, datagridResident, Modules.Residents, totalPageResident)
    End Sub
    Private Sub btnBackResident_Click(sender As Object, e As EventArgs) Handles btnBackResident.Click
        toolStripButtonBack(txtPageNoResident, datagridResident, Modules.Residents, totalPageResident)
    End Sub
    Private Sub btnForwardResident_Click(sender As Object, e As EventArgs) Handles btnForwardResident.Click
        toolStripButtonForward(txtPageNoResident, datagridResident, Modules.Residents, totalPageResident)
    End Sub
    Private Sub txtPageNoResident_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPageNoResident.KeyPress
        checkInputNumbersOnly(e)
    End Sub
    Private Sub txtSearchResident_Click(sender As Object, e As EventArgs) Handles txtSearchResident.Click
        If txtSearchResident.Text = "Type in your search" Then
            txtSearchResident.Clear()
        End If
    End Sub
    Private Sub txtSearchResident_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchResident.KeyDown
        enterTextSearch(e, datagridResident, Modules.Residents, txtPageNoResident)
    End Sub
    Private Sub btnSearchResident_Click(sender As Object, e As EventArgs) Handles btnSearchResident.Click
        loadDataGrid(datagridResident, Modules.Residents)
    End Sub
    Private Sub datagridResident_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridResident.CellClick
        If e.RowIndex >= 0 Then
            ViewResident.resident_id = datagridResident.Rows(e.RowIndex).Cells(0).Value
            ViewResident.viewChoice = "Normal"
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub btnFilterResident_Click(sender As Object, e As EventArgs) Handles btnFilterResident.Click
        Filter.filterModule = "Resident"
        Filter.ShowDialog()
    End Sub
    Private Sub btnAddResident_Click(sender As Object, e As EventArgs) Handles btnAddResident.Click
        ViewResident.action = "add"
        ViewResident.ShowDialog()
    End Sub



    '' ''''''''''''''''''''''HOUSEHOLD UI DEFINITIONS''''''''''''''''''''''''
    Private Sub txtPageNoHousehold_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPageNoHousehold.KeyDown
        enterTextPageNo(e, txtPageNoHousehold, datagridHousehold, Modules.Household, totalPageHousehold)
    End Sub
    Private Sub btnBackHousehold_Click(sender As Object, e As EventArgs) Handles btnBackHousehold.Click
        toolStripButtonBack(txtPageNoHousehold, datagridHousehold, Modules.Household, totalPageHousehold)
    End Sub
    Private Sub btnForwardHousehold_Click(sender As Object, e As EventArgs) Handles btnForwardHousehold.Click
        toolStripButtonForward(txtPageNoHousehold, datagridHousehold, Modules.Household, totalPageHousehold)
    End Sub
    Private Sub txtPageNoHousehold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPageNoHousehold.KeyPress
        checkInputNumbersOnly(e)
    End Sub
    Private Sub txtSearchHousehold_Click(sender As Object, e As EventArgs) Handles txtSearchHousehold.Click
        If txtSearchHousehold.Text = "Type in your search" Then
            txtSearchHousehold.Clear()
        End If
    End Sub
    Private Sub txtSearchHousehold_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchHousehold.KeyDown
        enterTextSearch(e, datagridHousehold, Modules.Household, txtPageNoHousehold)
    End Sub
    Private Sub btnSearchHousehold_Click(sender As Object, e As EventArgs) Handles btnSearchHousehold.Click
        loadDataGrid(datagridHousehold, Modules.Household)
    End Sub
    Private Sub datagridHousehold_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridHousehold.CellClick
        If e.RowIndex >= 0 Then
            ViewHousehold.householdId = datagridHousehold.Rows(e.RowIndex).Cells(0).Value
            ViewHousehold.ShowDialog()
        End If
    End Sub
    Private Sub btnFilterHousehold_Click(sender As Object, e As EventArgs) Handles btnFilterHousehold.Click
        Filter.filterModule = "Household"
        Filter.ShowDialog()
    End Sub
    Private Sub btnAddHousehold_Click(sender As Object, e As EventArgs) Handles btnAddHousehold.Click
        ViewHousehold.action = "add"
        ViewHousehold.ShowDialog()
    End Sub
    Private Sub txtSearchHousehold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchHousehold.KeyPress
        checkInputNumbersOnly(e)
    End Sub


    ''' '''''''''''''' FOR SIDE NAVIGATION MENU
    Private Sub timerOpen_Tick(sender As Object, e As EventArgs) Handles timerOpen.Tick
        If splitContainerMain.SplitterDistance > 60 Then
            splitContainerMain.SplitterDistance = 50
            panelLogo.Size = New Size(43, 37)
            panelLogo.Padding = New Padding(5, 5, 5, 5)
            picLogo.Size = New Size(40, 35)
        Else
            timerOpen.Enabled = False
        End If
    End Sub
    Private Sub timerClose_Tick(sender As Object, e As EventArgs) Handles timerClose.Tick
        If splitContainerMain.SplitterDistance < 60 Then
            splitContainerMain.SplitterDistance = 250
            panelLogo.Size = New Size(250, 245)
            panelLogo.Padding = New Padding(20, 20, 20, 20)
            picLogo.Size = New Size(250, 245)
        Else
            timerClose.Enabled = False
        End If
    End Sub
    'this triggers the timer clocks whenever the user clicks on the menu [ie. minimizing and maximizing side navigation]
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If splitContainerMain.SplitterDistance > 60 Then
            timerOpen.Enabled = True
        Else
            timerClose.Enabled = True
        End If
    End Sub


    '' '''''''''''''''''''''''''''BUTTONS FOR SIDE NAVIGATION''''''''''''''''''''''''''''''
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnDashboard.BackColor = Color.FromArgb(52, 152, 219)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageDashboard
        labelTitle.Text = "Dashboard"

        countRows()
        loadDataGrid(dataGridBrgyOfficials, Modules.BrgyOfficials)
        statisticChecker()

    End Sub
    Private Sub btnResidentInfo_Click(sender As Object, e As EventArgs) Handles btnResidentInfo.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(52, 152, 219)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageResident
        labelTitle.Text = "Resident's Information"

        txtPageNoResident.Text = 1
        txtSearchResident.Text = "Type in your search"
        loadDataGrid(datagridResident, Modules.Residents)
        Filter.clearEverythingResident()
    End Sub
    Private Sub btnHouseholdInfo_Click(sender As Object, e As EventArgs) Handles btnHouseholdInfo.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(52, 152, 219)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageHousehold
        labelTitle.Text = "Household Information"

        txtPageNoHousehold.Text = 1
        txtSearchHousehold.Text = "Type in your search"
        loadDataGrid(datagridHousehold, Modules.Household)
        Filter.clearEverythingHousehold()

    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(52, 152, 219)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageReports
        reportTabControl.ItemSize = New Size(0, 1)
        btnIncidents.PerformClick()
        labelTitle.Text = "Reports"
    End Sub
    Private Sub btnCertificates_Click(sender As Object, e As EventArgs) Handles btnCertificates.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(52, 152, 219)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageCertificates
        labelTitle.Text = "Certificates"
    End Sub
    Private Sub btnBrgyMap_Click(sender As Object, e As EventArgs) Handles btnBrgyMap.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(52, 152, 219)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageMap
        labelTitle.Text = "Barangay Map"
    End Sub
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(52, 152, 219)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageAccount
        labelTitle.Text = "Account Settings"
    End Sub
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(52, 152, 219)

        mainTabControl.SelectedTab = pageInventory
        labelTitle.Text = "Inventory Management"
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim ans As Integer = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Attention!")
        If ans = MsgBoxResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub




    '''''''''''''''''''''''''''''''''''''''' METHODS FOR ACCESS'''''''''''''''''''''''''''''''''''''
    Public Sub countRows()
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

        'RESIDENTS
        totalRowsResident = 0
        totalPageResident = 0
        labelTotalPageResident.Text = 0
        labelTotalResident.Text = totalRowsResident
        btnBackResident.Enabled = False
        labelDashboardResident.Text = totalRowsResident

        cmd.CommandText = "Select count(*) From residents WHERE resident_id > 0 " & (If(filterHouseholdId = 0, "", " AND household_id = @householdid ")) & (If(filterMinAge = 0 Or filterMaxAge = 0, "", " AND age BETWEEN @minAge and @maxAge ")) & (If(filterDay = 0, "", " AND day_registered = @day ")) & (If(filterYear = 0, "", " AND year_registered = @year ")) & (If(filterSex = "", "", " AND sex = @sex ")) & (If(filterCivilStatus = "", "", " AND civil_status = @civilstatus ")) & (If(filterPwd = "", "", " AND is_pwd = @pwd ")) & (If(filterHouseholdRole = "", "", " AND household_role = @householdrole ")) & (If(filterMonth = "", "", " AND month_registered = @month ")) & (If(txtSearchResident.Text.Trim = "" Or txtSearchResident.Text = "Type in your search", " ", " AND first_name LIKE @resident_name OR middle_name LIKE @resident_name OR last_name LIKE @resident_name")) & " order by first_name asc "

        cmd.Parameters.AddWithValue("@resident_name", txtSearchResident.Text & "%")
        cmd.Parameters.AddWithValue("@householdid", filterHouseholdId)
        cmd.Parameters.AddWithValue("@minAge", filterMinAge)
        cmd.Parameters.AddWithValue("@maxAge", filterMaxAge)
        cmd.Parameters.AddWithValue("@day", filterDay)
        cmd.Parameters.AddWithValue("@year", filterYear)
        cmd.Parameters.AddWithValue("@sex", filterSex)
        cmd.Parameters.AddWithValue("@civilstatus", filterCivilStatus)
        cmd.Parameters.AddWithValue("@pwd", filterPwd)
        cmd.Parameters.AddWithValue("@householdrole", filterHouseholdRole)
        cmd.Parameters.AddWithValue("@month", filterMonth)

        totalRowsResident = Convert.ToString(cmd.ExecuteScalar())
        totalPageResident = Math.Ceiling(totalRowsResident / 20)
        labelTotalPageResident.Text = totalPageResident
        labelTotalResident.Text = totalRowsResident
        btnBackResident.Enabled = False
        labelDashboardResident.Text = totalRowsResident

        'HOUSEHOLD  
        totalRowsHousehold = 0
        totalPageHousehold = 0
        labelTotalPageHousehold.Text = 0
        labelTotalHousehold.Text = ""
        btnBackHousehold.Enabled = False
        labelDashboardHouseholds.Text = ""


        'cmd.CommandText = "Select count(*) From household WHERE CAST(household_id AS UNSIGNED) > 0 AND household_id like = @householdid "
        cmd.CommandText = "Select count(*) From household WHERE CAST(household_id AS UNSIGNED) > 0 " & If(filterBldgNo = "", "", " AND bldg_no LIKE @bldgno ") & If(filterStreetName = "", "", " AND street_name LIKE @streetname ") & If(filterResidenceType = "", "", " AND residence_type LIKE @residencetype ") & If(filterHouseType = "", "", " AND house_type LIKE @housetype ") & If(filterWaterSource = "", "", " AND water_source LIKE @watersource ") & If(filterElectricitySource = "", "", " AND electricity_source LIKE @electricitysource ") & If(filterMonthAdded = "", "", " AND month_added = @monthadded ") & If(filterDayAdded = 0, "", " AND day_added = @dayadded ") & If(filterYearAdded = 0, "", " AND year_added = @yearadded ") & (If(txtSearchHousehold.Text.Trim = "" Or txtSearchHousehold.Text = "Type in your search", " ", " AND household_id LIKE '" & txtSearchHousehold.Text.Trim & "%'"))

        'cmd.Parameters.AddWithValue("@householdid", txtSearchHousehold.Text.Trim & "%")
        cmd.Parameters.AddWithValue("@bldgno", "%" & filterBldgNo & "%")
        cmd.Parameters.AddWithValue("@streetname", "%" & filterStreetName & "%")
        cmd.Parameters.AddWithValue("@residencetype", "%" & filterResidenceType & "%")
        cmd.Parameters.AddWithValue("@housetype", "%" & filterHouseType & "%")
        cmd.Parameters.AddWithValue("@watersource", "%" & filterWaterSource & "%")
        cmd.Parameters.AddWithValue("@electricitysource", "%" & filterElectricitySource & "%")
        cmd.Parameters.AddWithValue("@monthadded", filterMonthAdded)
        cmd.Parameters.AddWithValue("@dayadded", filterDayAdded)
        cmd.Parameters.AddWithValue("@yearadded", filterYearAdded)

        totalRowsHousehold = Convert.ToString(cmd.ExecuteScalar())

        totalPageHousehold = Math.Ceiling(totalRowsHousehold / 30)
        labelTotalPageHousehold.Text = totalPageHousehold
        labelTotalHousehold.Text = totalRowsHousehold
        btnBackHousehold.Enabled = False
        labelDashboardHouseholds.Text = totalRowsHousehold

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Public Sub loadDataGrid(ByVal datagrid As DataGridView, ByVal moduleSelected As Modules)

        datagrid.Rows.Clear()
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim mySQLCommand As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text

        Select Case moduleSelected
            Case Modules.BrgyOfficials ''''''''''''''Barangay Officials

                mySQLCommand.CommandText = "Select * From brgyOfficials"
                mySQLReader = mySQLCommand.ExecuteReader
                If mySQLReader.HasRows Then
                    While mySQLReader.Read
                        datagrid.Rows.Add(New String() {mySQLReader!official_name, mySQLReader!official_position, mySQLReader!contact_no})

                    End While
                End If

                mySQLCommand.Dispose()
                mySQLReader.Dispose()

            Case Modules.Residents ''''''''''''''Resident

                mySQLCommand.CommandText = "SELECT resident_id, first_name, middle_name, last_name, ext_name, sex, contact_no FROM residents WHERE resident_id > 0 " & (If(filterHouseholdId = 0, "", " AND household_id = @householdid ")) & (If(filterMinAge = 0 Or filterMaxAge = 0, "", " AND age BETWEEN @minAge and @maxAge ")) & (If(filterDay = 0, "", " AND day_registered = @day ")) & (If(filterYear = 0, "", " AND year_registered = @year ")) & (If(filterSex = "", "", " AND sex = @sex ")) & (If(filterCivilStatus = "", "", " AND civil_status = @civilstatus ")) & (If(filterPwd = "", "", " AND is_pwd = @pwd ")) & (If(filterHouseholdRole = "", "", " AND household_role = @householdrole ")) & (If(filterMonth = "", "", " AND month_registered = @month ")) & (If(txtSearchResident.Text.Trim = "" Or txtSearchResident.Text = "Type in your search", " ", " AND (first_name LIKE @resident_name OR middle_name LIKE @resident_name OR last_name LIKE @resident_name)")) & " order by first_name asc limit 20 OFFSET " & (((CInt(Me.txtPageNoResident.Text)) - 1) * 20)
                mySQLCommand.Parameters.AddWithValue("@resident_name", txtSearchResident.Text & "%")
                mySQLCommand.Parameters.AddWithValue("@householdid", filterHouseholdId)
                mySQLCommand.Parameters.AddWithValue("@minAge", filterMinAge)
                mySQLCommand.Parameters.AddWithValue("@maxAge", filterMaxAge)
                mySQLCommand.Parameters.AddWithValue("@day", filterDay)
                mySQLCommand.Parameters.AddWithValue("@year", filterYear)
                mySQLCommand.Parameters.AddWithValue("@sex", filterSex)
                mySQLCommand.Parameters.AddWithValue("@civilstatus", filterCivilStatus)
                mySQLCommand.Parameters.AddWithValue("@pwd", filterPwd)
                mySQLCommand.Parameters.AddWithValue("@householdrole", filterHouseholdRole)
                mySQLCommand.Parameters.AddWithValue("@month", filterMonth)

                mySQLReader = mySQLCommand.ExecuteReader

                countRows()

                If mySQLReader.HasRows Then
                    If txtPageNoResident.Text = 1 Then
                        btnBackResident.Enabled = False
                    End If
                    If txtPageNoResident.Text < totalPageResident Then
                        btnForwardResident.Enabled = True
                    End If
                    If txtPageNoResident.Text > 1 Then
                        btnBackResident.Enabled = True
                    End If
                    If txtPageNoResident.Text = totalPageResident Then
                        btnForwardResident.Enabled = False
                        labelShownResident.Text = totalRowsResident
                    ElseIf txtPageNoResident.Text < totalPageResident Then
                        labelShownResident.Text = txtPageNoResident.Text * 20
                    End If

                    While mySQLReader.Read
                        Dim middle, ext As String
                        If mySQLReader!middle_name = Nothing Then
                            middle = ""
                        Else
                            middle = mySQLReader!middle_name + " "
                        End If

                        datagrid.Rows.Add(New String() {mySQLReader!resident_id, (mySQLReader!first_name + " " + middle + mySQLReader!last_name + " " + mySQLReader!ext_name), mySQLReader!sex, mySQLReader!contact_no})

                    End While
                End If

                mySQLCommand.Dispose()
                mySQLReader.Dispose()

            Case Modules.Household ''''''''''''''Household

                mySQLCommand.CommandText = "Select household_id, bldg_no, street_name From household WHERE household_id > 0 " & If(filterBldgNo = "", "", " AND bldg_no LIKE @bldgno ") & If(filterStreetName = "", "", " AND street_name LIKE @streetname ") & If(filterResidenceType = "", "", " AND residence_type LIKE @residencetype ") & If(filterHouseType = "", "", " AND house_type LIKE @housetype ") & If(filterWaterSource = "", "", " AND water_source LIKE @watersource ") & If(filterElectricitySource = "", "", " AND electricity_source LIKE @electricitysource ") & If(filterMonthAdded = "", "", " AND month_added = @monthadded ") & If(filterDayAdded = 0, "", " AND day_added = @dayadded ") & If(filterYearAdded = 0, "", " AND year_added = @yearadded ") & (If(txtSearchHousehold.Text.Trim = "" Or txtSearchHousehold.Text = "Type in your search", " ", " AND household_id LIKE @householdID")) & " order by  CAST(household_id AS UNSIGNED) asc limit 30 OFFSET " & (((CInt(Me.txtPageNoHousehold.Text)) - 1) * 30)
                mySQLCommand.Parameters.AddWithValue("@householdID", txtSearchHousehold.Text & "%")
                mySQLCommand.Parameters.AddWithValue("@bldgno", "%" & filterBldgNo & "%")
                mySQLCommand.Parameters.AddWithValue("@streetname", "%" & filterStreetName & "%")
                mySQLCommand.Parameters.AddWithValue("@residencetype", "%" & filterResidenceType & "%")
                mySQLCommand.Parameters.AddWithValue("@housetype", "%" & filterHouseType & "%")
                mySQLCommand.Parameters.AddWithValue("@watersource", "%" & filterWaterSource & "%")
                mySQLCommand.Parameters.AddWithValue("@electricitysource", "%" & filterElectricitySource & "%")
                mySQLCommand.Parameters.AddWithValue("@monthadded", filterMonthAdded)
                mySQLCommand.Parameters.AddWithValue("@dayadded", filterDayAdded)
                mySQLCommand.Parameters.AddWithValue("@yearadded", filterYearAdded)

                mySQLReader = mySQLCommand.ExecuteReader

                countRows()

                If mySQLReader.HasRows Then
                    If txtPageNoHousehold.Text = 1 Then
                        btnBackHousehold.Enabled = False
                    End If
                    If txtPageNoHousehold.Text < totalPageHousehold Then
                        btnForwardHousehold.Enabled = True
                    End If
                    If txtPageNoHousehold.Text > 1 Then
                        btnBackHousehold.Enabled = True
                    End If
                    If txtPageNoHousehold.Text = totalPageHousehold Then
                        btnForwardHousehold.Enabled = False
                        labelShownHousehold.Text = totalRowsHousehold
                    ElseIf txtPageNoHousehold.Text < totalPageHousehold Then
                        labelShownHousehold.Text = txtPageNoHousehold.Text * 30
                    End If

                    While mySQLReader.Read
                        datagrid.Rows.Add(New String() {mySQLReader!household_id, mySQLReader!bldg_no, mySQLReader!street_name, "", "", ""})

                    End While
                End If

                mySQLCommand.Dispose()
                mySQLReader.Dispose()

            Case Modules.Report

            Case Modules.Certificates

        End Select

        mySql.Close()
        mySql.Dispose()

        datagrid.ClearSelection()
    End Sub


    Private Sub enterTextPageNo(e As KeyEventArgs, txtPageNo As ToolStripTextBox, datagrid As DataGridView, modules As Modules, ByVal totalPage As Integer)
        If e.KeyCode = Keys.Enter Then
            If txtPageNo.Text.Trim = "" Then
                MsgBox("Please enter a valid number", vbCritical, "Warning")
                txtPageNo.Text = 1
            ElseIf txtPageNo.Text > totalPage Or txtPageNo.Text = 0 Then
                MsgBox("Please enter a valid number", vbCritical, "Warning")
                txtPageNo.Text = 1
            Else
                loadDataGrid(datagrid, modules)
            End If
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub enterTextSearch(e As KeyEventArgs, datagrid As DataGridView, modules As Modules, txtPageNo As ToolStripTextBox)
        If e.KeyCode = Keys.Enter Then
            txtPageNo.Text = 1
            loadDataGrid(datagrid, modules)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub toolStripButtonBack(txtPageNo As ToolStripTextBox, datagrid As DataGridView, modules As Modules, ByVal totalPage As Integer)
        If txtPageNo.Text <> 1 And txtPageNo.Text <= totalPage Then
            txtPageNo.Text -= 1
            loadDataGrid(datagrid, modules)
        End If
    End Sub
    Private Sub toolStripButtonForward(txtPageNo As ToolStripTextBox, dataGrid As DataGridView, modules As Modules, ByVal totalPage As Integer)
        If txtPageNo.Text < totalPage Then
            txtPageNo.Text += 1
            loadDataGrid(dataGrid, modules)
        End If
    End Sub
    Private Sub checkInputNumbersOnly(e As KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub EnableDoubleBuffered(ByVal datagrid As DataGridView)
        Dim dgvType As Type = datagrid.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered",
                                                 BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(datagrid, True, Nothing)
    End Sub
    Private Sub statisticChecker()
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

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE sex LIKE 'Female'"
        labelDashboardFemale.Text = Convert.ToString(cmd.ExecuteScalar())

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE sex LIKE 'Male'"
        labelDashboardMale.Text = Convert.ToString(cmd.ExecuteScalar())

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE age > 60"
        labelDashboardSeniors.Text = Convert.ToString(cmd.ExecuteScalar())

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE is_voter LIKE 'Yes'"
        labelDashboardVoters.Text = Convert.ToString(cmd.ExecuteScalar())

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE is_pwd LIKE 'Yes'"
        labelDashboardPwd.Text = Convert.ToString(cmd.ExecuteScalar())

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE occupation LIKE 'Student' or occupation LIKE 'N/A' or occupation LIKE '' or occupation LIKE 'NA' or occupation LIKE 'No Work'"
        labelDashboardUnemployed.Text = Convert.ToString(cmd.ExecuteScalar())


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    '' ''''''''''''''''''''''FOR REPORTS'''''''''''''''''''''''''''''''''''''''''''''''

    '' '''''''''''''''''REPORTS UI DEFINITIONS '''''''''''''''''''''''''''''''
    Private Sub btnIncidents_Click(sender As Object, e As EventArgs) Handles btnIncidents.Click
        btnIncidents.BackColor = Color.FromArgb(39, 174, 96)
        btnComplaints.BackColor = Color.FromArgb(46, 204, 113)
        btnBlotters.BackColor = Color.FromArgb(46, 204, 113)
        btnVawc.BackColor = Color.FromArgb(46, 204, 113)

        reportTabControl.SelectedIndex = 0
        comboTimeIncidents.SelectedIndex = 0
        txtSearchIncidents.Text = "Search by incident id or name"
        datePickerIncidents.Format = DateTimePickerFormat.Custom
        datePickerIncidents.CustomFormat = "MMMM d, yyyy"
        loadDatagridIncidents(False)
    End Sub
    Private Sub btnComplaints_Click(sender As Object, e As EventArgs) Handles btnComplaints.Click
        btnIncidents.BackColor = Color.FromArgb(46, 204, 113)
        btnComplaints.BackColor = Color.FromArgb(39, 174, 96)
        btnBlotters.BackColor = Color.FromArgb(46, 204, 113)
        btnVawc.BackColor = Color.FromArgb(46, 204, 113)

        reportTabControl.SelectedIndex = 1
        txtSearchComplaints.Text = "Search by complaint, complainant or defendant"
        datePickerComplaints.Format = DateTimePickerFormat.Custom
        datePickerComplaints.CustomFormat = "MMMM d, yyyy"
        loadDatagridComplaints(False)
    End Sub
    Private Sub btnBlotters_Click(sender As Object, e As EventArgs) Handles btnBlotters.Click
        btnIncidents.BackColor = Color.FromArgb(46, 204, 113)
        btnComplaints.BackColor = Color.FromArgb(46, 204, 113)
        btnBlotters.BackColor = Color.FromArgb(39, 174, 96)
        btnVawc.BackColor = Color.FromArgb(46, 204, 113)

        reportTabControl.SelectedIndex = 2
    End Sub
    Private Sub btnVawc_Click(sender As Object, e As EventArgs) Handles btnVawc.Click
        btnIncidents.BackColor = Color.FromArgb(46, 204, 113)
        btnComplaints.BackColor = Color.FromArgb(46, 204, 113)
        btnBlotters.BackColor = Color.FromArgb(46, 204, 113)
        btnVawc.BackColor = Color.FromArgb(39, 174, 96)

        reportTabControl.SelectedIndex = 3
    End Sub


    '' '''''''''''''''''''''''INCIDENTS METHODS'''''''''''''''''''''''''''''''''
    Private Sub loadDatagridIncidents(ByVal filtersApplied As Boolean)
        datagridIncidents.Rows.Clear()

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
        Dim dateTemp As Date = datePickerIncidents.Value

        cmd.CommandText = "SELECT incident_id, incident_name, incident_date, incident_time from incidents WHERE incident_id > 0 " & If(txtSearchIncidents.Text.Trim = "" Or txtSearchIncidents.Text = "Search by incident id or name", "", " AND (incident_id = @searchvalue or incident_name = @searchvalue) ") & If(filtersApplied = True And comboTimeIncidents.SelectedIndex <> 0, " AND incident_time = @time ", "") & If(filtersApplied = True, " AND incident_date = @date ", "") & " ORDER BY incident_name ASC "
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchIncidents.Text.Trim)
        cmd.Parameters.AddWithValue("@date", datePickerIncidents.Text)

        cmd.Parameters.AddWithValue("@time", comboTimeIncidents.Text)
        Dim totalincidents As Integer = 0
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                totalincidents += 1
                datagridIncidents.Rows.Add(New String() {mySQLReader!incident_id, mySQLReader!incident_name, mySQLReader!incident_date, mySQLReader!incident_time})
            End While
        End If
        labelTotalIncidents.Text = "Total Incidents: " + totalincidents
        datagridIncidents.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub btnFilterIncidents_Click(sender As Object, e As EventArgs) Handles btnFilterIncidents.Click
        loadDatagridIncidents(True)
    End Sub
    Private Sub btnSearchIncidents_Click(sender As Object, e As EventArgs) Handles btnSearchIncidents.Click
        loadDatagridIncidents(False)
    End Sub
    Private Sub txtSearchIncidents_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchIncidents.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchIncidents.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearchIncidents_Click(sender As Object, e As EventArgs) Handles txtSearchIncidents.Click
        If txtSearchIncidents.Text = "Search by incident id or name" Then
            txtSearchIncidents.Clear()
        End If
    End Sub
    Private Sub datagridIncidents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridIncidents.CellClick
        If e.RowIndex >= 0 Then
            ViewIncidents.incidentId = datagridIncidents.Rows(e.RowIndex).Cells(0).Value
            ViewIncidents.action = "modify"
            ViewIncidents.ShowDialog()
        End If
    End Sub
    Private Sub btnAddIncidents_Click(sender As Object, e As EventArgs) Handles btnAddIncidents.Click
        ViewIncidents.action = "add"
        ViewIncidents.ShowDialog()
    End Sub


    '''''' ''''''''''''''''''''''''''''COMPLAINTS METHODS''''''''''''''''''''''''
    Private Sub loadDatagridComplaints(ByVal filtersApplied As Boolean)
        datagridComplaints.Rows.Clear()

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

        MsgBox(getIdByName(txtSearchComplaints.Text.Trim))
        cmd.CommandText = "SELECT complaint_id, complaint, complainant, defendant, status from complaints where complaint_id > 0 " & If(filtersApplied = True, " AND date_filed = @date ", "") & If(txtSearchComplaints.Text.Trim = "" Or txtSearchComplaints.Text = "Search by complaint, complainant or defendant", "", " AND (complaint LIKE @searchvalue or complainant LIKE @searchvalue or defendant LIKE @searchvalue or complaint LIKE '" & getIdByName(txtSearchComplaints.Text.Trim) & "%'" & " or complainant LIKE '" & getIdByName(txtSearchComplaints.Text.Trim) & "%'" & " or defendant LIKE '" & getIdByName(txtSearchComplaints.Text.Trim) & "%'" & " ) ") & " ORDER BY complaint ASC "
        cmd.Parameters.AddWithValue("@convertedsearchvalue", getIdByName(txtSearchComplaints.Text.Trim) & "%")
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchComplaints.Text.Trim & "%")
        cmd.Parameters.AddWithValue("@date", datePickerComplaints.Text)

        Dim totalComplaints As Integer = 0
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                totalComplaints += 1
                Dim complainant As String
                Dim defendant As String
                If IsNumeric(mySQLReader!complainant) Then
                    complainant = getResidentNameById(mySQLReader!complainant)
                Else
                    complainant = mySQLReader!complainant
                End If
                If IsNumeric(mySQLReader!defendant) Then
                    defendant = getResidentNameById(mySQLReader!defendant)
                Else
                    defendant = mySQLReader!defendant
                End If

                datagridComplaints.Rows.Add(New String() {mySQLReader!complaint_id, mySQLReader!complaint, complainant, defendant, mySQLReader!status})
            End While
        End If
        labelTotalComplaints.Text = "Total Complaints: " + totalComplaints
        datagridComplaints.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Function getResidentNameById(ByVal id As Integer) As String

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

        cmd.CommandText = "SELECT first_name, middle_name, last_name, ext_name from residents WHERE resident_id = @residentid "
        cmd.Parameters.AddWithValue("@residentid", id)

        Dim name As String = ""
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                name = mySQLReader!first_name + " " + If(mySQLReader!middle_name = "", "", mySQLReader!middle_name + " ") + mySQLReader!last_name + " " + mySQLReader!ext_name
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return name
    End Function
    Public Function getIdByName(ByVal name As String) As Integer

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

        cmd.CommandText = "SELECT resident_id from residents WHERE first_name like @name or last_name like @name "
        cmd.Parameters.AddWithValue("@name", name & "%")

        Dim id As Integer
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            id = mySQLReader!resident_id
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return name
    End Function
    Private Sub txtSearchComplaints_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchComplaints.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchComplaints.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearchComplaints_Click(sender As Object, e As EventArgs) Handles txtSearchComplaints.Click
        If txtSearchComplaints.Text = "Search by complaint, complainant or defendant" Then
            txtSearchComplaints.Clear()
        End If
    End Sub
    Private Sub btnFilterComplaints_Click(sender As Object, e As EventArgs) Handles btnFilterComplaints.Click
        loadDatagridComplaints(True)
    End Sub
    Private Sub btnSearchComplaints_Click(sender As Object, e As EventArgs) Handles btnSearchComplaints.Click
        loadDatagridComplaints(False)
    End Sub


    '' ''''''''''''''''''''''''''''''BLOTTERS UI DEFINITIONS'''''''''''''''''''''''''''''


End Class