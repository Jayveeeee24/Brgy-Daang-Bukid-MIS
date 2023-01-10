Imports System.Data
Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient

Public Class Main_Form
    Public account_id As Integer
    Public account_credentials As String
    Public account_position As String
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
        Incidents
        Complaints
        Blotters
        Vawc
        Inventory
    End Enum

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainTabControl.ItemSize = New Size(0, 1)
        btnDashboard.PerformClick()
        getAccountDetails()

        EnableDoubleBuffered(dataGridBrgyOfficials)
        EnableDoubleBuffered(datagridResident)
        EnableDoubleBuffered(datagridHousehold)
        EnableDoubleBuffered(datagridIncidents)
        EnableDoubleBuffered(datagridComplaints)
        EnableDoubleBuffered(datagridBlotters)
        EnableDoubleBuffered(datagridVawc)



    End Sub
    Private Sub getAccountDetails()

        btnCertificates.Show()
        btnSystemManagement.Show()
        btnInventory.Show()
        btnAddResident.Show()
        btnAddHousehold.Show()
        btnAddIncidents.Show()
        btnAddComplaint.Show()
        btnAddBlotters.Show()
        btnAddVawc.Show()
        btnAccountSettings.Show()
        btnArchivedResidents.Show()
        btnUpdateBrgyOfficials.Show()
        btnAuditLogs.Show()

        If account_id = 2 Then
            btnArchivedResidents.Hide()
            btnUpdateBrgyOfficials.Hide()
            btnAuditLogs.Hide()
        ElseIf account_id = 3 Then
            btnCertificates.Hide()
            btnSystemManagement.Hide()
            btnInventory.Hide()
            btnAddResident.Hide()
            btnAddHousehold.Hide()
            btnAddIncidents.Hide()
            btnAddComplaint.Hide()
            btnAddBlotters.Hide()
            btnAddVawc.Hide()
            btnAccountSettings.Hide()
            btnArchivedResidents.Hide()
            btnUpdateBrgyOfficials.Hide()
            btnAuditLogs.Hide()
        End If

        If account_id = 3 Then
            labelSignedIn.Text = "Logged in as: Guest"
        Else
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
                    account_name = getResidentNameById(mySQLReader!official_name)
                    account_credentials = account_name + " [" + mySQLReader!official_position + "]"
                    labelSignedIn.Text = "Logged in as: " + account_credentials
                End While
            End If
            mySQLCommand.Dispose()
            mySQLReader.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If

    End Sub

    Private Sub dataGridBrgyOfficials_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridBrgyOfficials.CellClick
        If e.RowIndex >= 0 Then
            ViewResident.resident_id = dataGridBrgyOfficials.Rows(e.RowIndex).Cells(0).Value
            ViewResident.viewChoice = "Normal"
            ViewResident.ShowDialog()
        End If
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
        btnSystemManagement.BackColor = Color.FromArgb(25, 117, 211)
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
        btnSystemManagement.BackColor = Color.FromArgb(25, 117, 211)
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
        btnSystemManagement.BackColor = Color.FromArgb(25, 117, 211)
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
        btnSystemManagement.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageReports
        reportTabControl.ItemSize = New Size(0, 1)
        btnIncidents.PerformClick()
        labelTitle.Text = "Services"
    End Sub
    Private Sub btnCertificates_Click(sender As Object, e As EventArgs) Handles btnCertificates.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(52, 152, 219)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnSystemManagement.BackColor = Color.FromArgb(25, 117, 211)
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
        btnSystemManagement.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)
        tabMap.ItemSize = New Size(0, 1)

        mainTabControl.SelectedTab = pageMap
        labelTitle.Text = "Barangay Map"
        timerOpen.Start()
        comboChooseMap.SelectedIndex = 0
        tabMap.SelectedIndex = 0
    End Sub
    Private Sub btnSystemManagement_Click(sender As Object, e As EventArgs) Handles btnSystemManagement.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnSystemManagement.BackColor = Color.FromArgb(52, 152, 219)
        btnInventory.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageSystemManagement
        labelTitle.Text = "Account Settings"
    End Sub
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnSystemManagement.BackColor = Color.FromArgb(25, 117, 211)
        btnInventory.BackColor = Color.FromArgb(52, 152, 219)

        mainTabControl.SelectedTab = pageInventory
        labelTitle.Text = "Inventory Management"

        txtSearchInventory.Text = "Search by Item Name or ID"
        loadDataGridInventory()
        countReports(Modules.Inventory)
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

                mySQLCommand.CommandText = "SELECT brgyOfficials.official_position, brgyOfficials.official_name, residents.contact_no FROM brgyOfficials INNER JOIN residents on brgyOfficials.official_name = residents.resident_id"
                mySQLReader = mySQLCommand.ExecuteReader
                If mySQLReader.HasRows Then
                    While mySQLReader.Read
                        datagrid.Rows.Add(New String() {mySQLReader!official_name, getResidentNameById(mySQLReader!official_name), mySQLReader!official_position, mySQLReader!contact_no})
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
    Private Sub checkInputCharactersOnly(e As KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
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
    Private Sub countReports(reportModule As Modules)
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

        If reportModule = Modules.Incidents Then
            cmd.CommandText = "Select count(*) from incidents"
            labelTotalIncidents.Text = "Total Incidents: " & Convert.ToString(cmd.ExecuteScalar)
        ElseIf reportModule = Modules.Complaints Then
            cmd.CommandText = "Select count(*) from complaints"
            labelTotalComplaints.Text = "Total Complaints: " & Convert.ToString(cmd.ExecuteScalar)
        ElseIf reportModule = Modules.Blotters Then
            cmd.CommandText = "Select count(*) from blotters"
            labelTotalBlotters.Text = "Total Blotters: " & Convert.ToString(cmd.ExecuteScalar)
        ElseIf reportModule = Modules.Vawc Then
            cmd.CommandText = "Select count(*) from vawc"
            labelTotalVawc.Text = "Total VAWC Cases: " & Convert.ToString(cmd.ExecuteScalar)
        ElseIf reportModule = Modules.Inventory Then
            cmd.CommandText = "Select count(*) from item_list"
            labelTotalItems.Text = "Total Items: " & Convert.ToString(cmd.ExecuteScalar)
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
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
        countReports(Modules.Incidents)
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
        countReports(Modules.Complaints)
    End Sub
    Private Sub btnBlotters_Click(sender As Object, e As EventArgs) Handles btnBlotters.Click
        btnIncidents.BackColor = Color.FromArgb(46, 204, 113)
        btnComplaints.BackColor = Color.FromArgb(46, 204, 113)
        btnBlotters.BackColor = Color.FromArgb(39, 174, 96)
        btnVawc.BackColor = Color.FromArgb(46, 204, 113)

        reportTabControl.SelectedIndex = 2
        txtSearchBlotters.Text = "Search by blotter or suspect"
        datePickerBlotters.Format = DateTimePickerFormat.Custom
        datePickerBlotters.CustomFormat = "MMMM d, yyyy"
        loadDataGridBlotters(False)
        countReports(Modules.Blotters)
    End Sub
    Private Sub btnVawc_Click(sender As Object, e As EventArgs) Handles btnVawc.Click
        btnIncidents.BackColor = Color.FromArgb(46, 204, 113)
        btnComplaints.BackColor = Color.FromArgb(46, 204, 113)
        btnBlotters.BackColor = Color.FromArgb(46, 204, 113)
        btnVawc.BackColor = Color.FromArgb(39, 174, 96)

        reportTabControl.SelectedIndex = 3
        txtSearchVawc.Text = "Search by case name or id"
        datePickerVawc.Format = DateTimePickerFormat.Custom
        datePickerVawc.CustomFormat = "MMMM d, yyyy"
        loadDataGridVawc(False)
        countReports(Modules.Vawc)
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

        cmd.CommandText = "SELECT incident_id, incident_name, incident_date, incident_time from incidents WHERE incident_id > 0 " & If(txtSearchIncidents.Text.Trim = "" Or txtSearchIncidents.Text = "Search by incident id or name", "", " AND (incident_id LIKE @searchvalue or incident_name LIKE @searchvalue) ") & If(filtersApplied = True And comboTimeIncidents.SelectedIndex <> 0, " AND incident_time = @time ", "") & If(filtersApplied = True, " AND incident_date = @date ", "") & " ORDER BY incident_date DESC "
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchIncidents.Text.Trim & "%")
        cmd.Parameters.AddWithValue("@date", datePickerIncidents.Value.Date)

        cmd.Parameters.AddWithValue("@time", comboTimeIncidents.Text)
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim date1 As Date = mySQLReader!incident_date
                datagridIncidents.Rows.Add(New String() {mySQLReader!incident_id, mySQLReader!incident_name, date1.ToString("MMMM d, yyyy"), mySQLReader!incident_time})
            End While
        End If
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

        cmd.CommandText = "SELECT complaint_id, complaint, complainant, defendant, complaint_status from complaints where complaint_id > 0 " & If(filtersApplied = True, " AND date_filed = @date ", "") & If(txtSearchComplaints.Text.Trim = "" Or txtSearchComplaints.Text = "Search by complaint, complainant or defendant", "", " AND (complaint LIKE @searchvalue or complainant LIKE @searchvalue or defendant LIKE @searchvalue or complainant LIKE '" & getIdByName(txtSearchComplaints.Text.Trim) & "%'" & " or defendant LIKE '" & getIdByName(txtSearchComplaints.Text.Trim) & "%'" & " ) ") & " ORDER BY date_filed DESC "
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchComplaints.Text.Trim & "%")
        cmd.Parameters.AddWithValue("@date", datePickerComplaints.Value.Date)

        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
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

                datagridComplaints.Rows.Add(New String() {mySQLReader!complaint_id, mySQLReader!complaint, complainant, defendant, mySQLReader!complaint_status})
            End While
        End If
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
                name = mySQLReader!first_name + If(mySQLReader!middle_name = "", "", " " + mySQLReader!middle_name) + " " + mySQLReader!last_name + " " + mySQLReader!ext_name
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
            While mySQLReader.Read
                id = mySQLReader!resident_id
                Exit While
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return id
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
    Private Sub datagridComplaints_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridComplaints.CellClick
        If e.RowIndex >= 0 Then
            ViewComplaints.complaintId = datagridComplaints.Rows(e.RowIndex).Cells(0).Value
            ViewComplaints.action = "modify"
            ViewComplaints.ShowDialog()
        End If
    End Sub
    Private Sub txtSearchComplaints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchComplaints.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub btnAddComplaint_Click(sender As Object, e As EventArgs) Handles btnAddComplaint.Click
        ViewComplaints.action = "add"
        ViewComplaints.ShowDialog()
    End Sub





    '' ''''''''''''''''''''''''''''''BLOTTERS METHODS'''''''''''''''''''''''''''''
    Private Sub loadDataGridBlotters(ByVal filtersApplied As Boolean)
        datagridBlotters.Rows.Clear()

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

        cmd.CommandText = "SELECT blotter_id, blotter, suspect, submitted_on from blotters where blotter_id > 0 " & If(filtersApplied = True, " AND submitted_on = @date ", "") & If(txtSearchBlotters.Text.Trim = "" Or txtSearchBlotters.Text = "Search by blotter or suspect", "", " AND (blotter LIKE @searchvalue or suspect LIKE @searchvalue or suspect LIKE '" & getIdByName(txtSearchBlotters.Text.Trim) & "%') ") & " ORDER BY submitted_on DESC "

        cmd.Parameters.AddWithValue("@searchvalue", txtSearchBlotters.Text.Trim & "%")
        cmd.Parameters.AddWithValue("@date", datePickerBlotters.Value.Date)

        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim suspect As String
                If IsNumeric(mySQLReader!suspect) Then
                    suspect = getResidentNameById(mySQLReader!suspect)
                Else
                    suspect = mySQLReader!suspect
                End If
                Dim date1 As Date = mySQLReader!submitted_on
                datagridBlotters.Rows.Add(New String() {mySQLReader!blotter_id, mySQLReader!blotter, suspect, date1.ToString("MMMM d, yyyy")})
            End While
        End If
        datagridBlotters.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

    End Sub
    Private Sub txtSearchBlotters_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchBlotters.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchBlotters.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearchBlotters_Click(sender As Object, e As EventArgs) Handles txtSearchBlotters.Click
        If txtSearchBlotters.Text = "Search by blotter or suspect" Then
            txtSearchBlotters.Clear()
        End If
    End Sub
    Private Sub btnFilterBlotters_Click(sender As Object, e As EventArgs) Handles btnFilterBlotters.Click
        loadDataGridBlotters(True)
    End Sub
    Private Sub btnSearchBlotters_Click(sender As Object, e As EventArgs) Handles btnSearchBlotters.Click
        loadDataGridBlotters(False)
    End Sub
    Private Sub txtSearchBlotters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBlotters.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub datagridBlotters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridBlotters.CellClick
        If e.RowIndex >= 0 Then
            ViewBlotters.blotterId = datagridBlotters.Rows(e.RowIndex).Cells(0).Value
            ViewBlotters.action = "modify"
            ViewBlotters.ShowDialog()
        End If
    End Sub
    Private Sub btnAddBlotters_Click(sender As Object, e As EventArgs) Handles btnAddBlotters.Click
        ViewBlotters.action = "add"
        ViewBlotters.ShowDialog()
    End Sub



    '' ''''''''''''''''''''''''''''VAWC METHODS''''''''''''''''''''''''''''''''''''
    Private Sub loadDataGridVawc(ByVal filtersApplied As Boolean)
        datagridVawc.Rows.Clear()

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

        cmd.CommandText = "SELECT case_id, case_name, victim, suspect, submitted_on, case_status from vawc where case_id > 0 " & If(filtersApplied = True, " AND submitted_on = @date ", "") & If(txtSearchVawc.Text.Trim = "" Or txtSearchVawc.Text = "Search by case name or id", "", " AND (case_id LIKE @searchvalue or case_name LIKE @searchvalue or victim LIKE '" & getIdByName(txtSearchVawc.Text.Trim) & "%' or suspect LIKE '" & getIdByName(txtSearchVawc.Text.Trim) & "%'" & " or victim like @searchvalue or suspect = @searchvalue ) ") & " ORDER BY submitted_on DESC "
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchVawc.Text.Trim & "%")
        cmd.Parameters.AddWithValue("@date", datePickerVawc.Value.Date)

        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim victim As String
                Dim suspect As String
                If IsNumeric(mySQLReader!victim) Then
                    victim = getResidentNameById(mySQLReader!victim)
                Else
                    victim = mySQLReader!victim
                End If
                If IsNumeric(mySQLReader!suspect) Then
                    suspect = getResidentNameById(mySQLReader!suspect)
                Else
                    suspect = mySQLReader!suspect
                End If
                Dim date1 As Date = mySQLReader!submitted_on
                datagridVawc.Rows.Add(New String() {mySQLReader!case_id, mySQLReader!case_name, victim, suspect, date1.ToString("MMMM d, yyyy"), mySQLReader!case_status})
            End While
        End If
        datagridVawc.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub txtSearchVawc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchVawc.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchVawc.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearchVawc_Click(sender As Object, e As EventArgs) Handles txtSearchVawc.Click
        If txtSearchVawc.Text = "Search by case name or id" Then
            txtSearchVawc.Clear()
        End If
    End Sub
    Private Sub btnSearchVawc_Click(sender As Object, e As EventArgs) Handles btnSearchVawc.Click
        loadDataGridVawc(False)
    End Sub
    Private Sub btnFilterVawc_Click(sender As Object, e As EventArgs) Handles btnFilterVawc.Click
        loadDataGridVawc(True)
    End Sub
    Private Sub datagridVawc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridVawc.CellClick
        If e.RowIndex >= 0 Then
            ViewVawc.caseId = datagridVawc.Rows(e.RowIndex).Cells(0).Value
            ViewVawc.action = "modify"
            ViewVawc.ShowDialog()
        End If
    End Sub
    Private Sub btnAddVawc_Click(sender As Object, e As EventArgs) Handles btnAddVawc.Click
        ViewVawc.action = "add"
        ViewVawc.ShowDialog()
    End Sub


    '' '''''''''''''''''''''''''''''INVENTORY METHODS ''''''''''''''''''''''''''''''
    Private Sub loadDataGridInventory()
        datagridInventory.Rows.Clear()

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

        cmd.CommandText = "SELECT item_id, item_name, item_status, item_stock, added_on from item_list where item_id > 0 " & If(txtSearchInventory.Text.Trim = "" Or txtSearchInventory.Text = "Search by Item Name or ID", "", " AND (item_id LIKE @searchvalue or item_name LIKE @searchvalue) ") & " ORDER BY added_on DESC "
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchInventory.Text.Trim & "%")

        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim date1 As Date = mySQLReader!added_on
                datagridInventory.Rows.Add(New String() {mySQLReader!item_id, mySQLReader!item_name, mySQLReader!item_status, mySQLReader!item_stock, date1.ToString("MMMM d, yyyy")})
            End While
        End If
        datagridInventory.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub txtSearchInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchInventory.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchInventory.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearchInventory_Click(sender As Object, e As EventArgs) Handles txtSearchInventory.Click
        If txtSearchInventory.Text = "Search by Item Name or ID" Then
            txtSearchInventory.Clear()
        End If
    End Sub
    Private Sub btnSearchInventory_Click(sender As Object, e As EventArgs) Handles btnSearchInventory.Click
        loadDataGridInventory()
    End Sub
    Private Sub datagridInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridInventory.CellClick
        If e.RowIndex >= 0 Then
            ViewInventory.itemId = datagridInventory.Rows(e.RowIndex).Cells(0).Value
            ViewInventory.action = "modify"
            ViewInventory.ShowDialog()
        End If
    End Sub
    Private Sub btnAddInventory_Click(sender As Object, e As EventArgs) Handles btnAddInventory.Click
        ViewInventory.action = "add"
        ViewInventory.ShowDialog()
    End Sub
    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        ViewInventory.action = "stock"
        ViewInventory.ShowDialog()
    End Sub

    '' '''''''''''''''''''''''''CERTIFICATES METHODS '''''''''''''''''''''''''''''''''''''''''
    Private Sub pictureboxResidency_Click(sender As Object, e As EventArgs) Handles pictureboxResidency.Click
        Certificate_Setup.action = "residency"
        Certificate_Setup.ShowDialog()
    End Sub
    Private Sub pictureboxClearamce_Click(sender As Object, e As EventArgs) Handles pictureboxClearamce.Click
        Certificate_Setup.action = "clearance"
        Certificate_Setup.ShowDialog()
    End Sub
    Private Sub pictureboxIndigency_Click(sender As Object, e As EventArgs) Handles pictureboxIndigency.Click
        Certificate_Setup.action = "indigency"
        Certificate_Setup.ShowDialog()
    End Sub
    Private Sub pictureboxSummons_Click(sender As Object, e As EventArgs) Handles pictureboxSummons.Click
        Certificate_Setup.action = "summon"
        Certificate_Setup.ShowDialog()
    End Sub


    '' '''''''''''''''''''''''''SYSTEM MANAGEMENT ''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btnArchivedResidents_Click(sender As Object, e As EventArgs) Handles btnArchivedResidents.Click
        ArchivedResidents.ShowDialog()
    End Sub
    Private Sub btnAccountSettings_Click(sender As Object, e As EventArgs) Handles btnAccountSettings.Click
        Account_Settings.ShowDialog()
    End Sub

    '' '''''''''''''''''''''''''MAPS METHODS''''''''''''''''''''''''''''''''''''''''
    Private Sub comboChooseMap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboChooseMap.SelectedIndexChanged
        If comboChooseMap.SelectedIndex = 0 Then
            tabMap.SelectedIndex = 0
        Else
            tabMap.SelectedIndex = 1
        End If
    End Sub
    Private Sub btnPound_Click(sender As Object, e As EventArgs) Handles btnPound.Click
        ViewStreet.streetName = "Pound, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnRiyal_Click(sender As Object, e As EventArgs) Handles btnRiyal.Click
        ViewStreet.streetName = "Riyal, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnDinar_Click(sender As Object, e As EventArgs) Handles btnDinar.Click
        ViewStreet.streetName = "Dinar, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnEuro_Click(sender As Object, e As EventArgs) Handles btnEuro.Click
        ViewStreet.streetName = "Euro, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnYen_Click(sender As Object, e As EventArgs) Handles btnYen.Click
        ViewStreet.streetName = "Yen, Westbay"
        ViewStreet.ShowDialog()
    End Sub

    Private Sub btnUpdateBrgyOfficials_Click(sender As Object, e As EventArgs) Handles btnUpdateBrgyOfficials.Click

    End Sub

    Private Sub btnAuditLogs_Click(sender As Object, e As EventArgs) Handles btnAuditLogs.Click

    End Sub

    Private Sub btnDirham_Click(sender As Object, e As EventArgs) Handles btnDirham.Click
        ViewStreet.streetName = "Dirham, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnFranc_Click(sender As Object, e As EventArgs) Handles btnFranc.Click
        ViewStreet.streetName = "Franc, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnShekel_Click(sender As Object, e As EventArgs) Handles btnShekel.Click
        ViewStreet.streetName = "Shekel, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnCasimiroAve_Click(sender As Object, e As EventArgs) Handles btnCasimiroAve.Click
        ViewStreet.streetName = "Casmiro Ave, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnWon_Click(sender As Object, e As EventArgs) Handles btnWon.Click
        ViewStreet.streetName = "Won, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnPeso_Click(sender As Object, e As EventArgs) Handles btnPeso.Click
        ViewStreet.streetName = "Peso, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnLira_Click(sender As Object, e As EventArgs) Handles btnLira.Click
        ViewStreet.streetName = "Lira, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnBaht_Click(sender As Object, e As EventArgs) Handles btnBaht.Click
        ViewStreet.streetName = "Baht, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnYuan_Click(sender As Object, e As EventArgs) Handles btnYuan.Click
        ViewStreet.streetName = "Yuan, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnRinggit_Click(sender As Object, e As EventArgs) Handles btnRinggit.Click
        ViewStreet.streetName = "Ringgit, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnRuble_Click(sender As Object, e As EventArgs) Handles btnRuble.Click
        ViewStreet.streetName = "Ruble, Westbay"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnEGomez_Click(sender As Object, e As EventArgs) Handles btnEGomez.Click
        ViewStreet.streetName = "E. Gomez"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnFGaudier_Click(sender As Object, e As EventArgs) Handles btnFGaudier.Click
        ViewStreet.streetName = "F. Gaudier"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnAAragon_Click(sender As Object, e As EventArgs) Handles btnAAragon.Click
        ViewStreet.streetName = "A. Aragon"
        ViewStreet.ShowDialog()
    End Sub
    Private Sub btnEvangelista_Click(sender As Object, e As EventArgs) Handles btnEvangelista.Click
        ViewStreet.streetName = "Evangelista"
        ViewStreet.ShowDialog()
    End Sub



End Class