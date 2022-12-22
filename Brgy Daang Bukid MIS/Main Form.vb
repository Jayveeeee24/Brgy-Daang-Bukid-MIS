Imports System.Data
Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class Main_Form
    Public account_type As String
    Public filterModule As String
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Dim totalRowsResident As Integer
    Dim totalPageResident As Integer

    Dim totalRowsHousehold As Integer
    Dim totalPageHousehold As Integer

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

        EnableDoubleBuffered(dataGridBrgyOfficials)
        EnableDoubleBuffered(datagridResident)
        EnableDoubleBuffered(datagridHousehold)

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
            ViewResident.mainTabControl.SelectedIndex = 0
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub btnFilterResident_Click(sender As Object, e As EventArgs) Handles btnFilterResident.Click
        Filter.filterModule = "Resident"
        Filter.ShowDialog()
    End Sub
    Private Sub btnAddResident_Click(sender As Object, e As EventArgs) Handles btnAddResident.Click
        ViewResident.mainTabControl.SelectedIndex = 1
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

    End Sub
    Private Sub btnFilterHousehold_Click(sender As Object, e As EventArgs) Handles btnFilterHousehold.Click
        Filter.filterModule = "Household"
        Filter.ShowDialog()
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

        countRows("")
        loadDataGrid(dataGridBrgyOfficials, Modules.BrgyOfficials)

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
        loadDataGrid(datagridResident, Modules.Residents)

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
        loadDataGrid(datagridHousehold, Modules.Household)

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
    Private Sub countRows(ByVal choice As String)
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

        If choice = "Search Resident" Then
            cmd.CommandText = "Select count(*) From residents" & (If(txtSearchResident.Text.Trim = "" Or txtSearchResident.Text = "Type in your search", " ", " WHERE first_name LIKE @resident_name OR middle_name LIKE @resident_name OR last_name LIKE @resident_name")) & " order by first_name asc "
            cmd.Parameters.AddWithValue("@resident_name", "%" & txtSearchResident.Text & "%")
        Else
            cmd.CommandText = "Select count(*) from residents"
        End If

        totalRowsResident = Convert.ToString(cmd.ExecuteScalar())
        totalPageResident = Math.Ceiling(totalRowsResident / 20)
        labelTotalPageResident.Text = totalPageResident
        labelTotalResident.Text = totalRowsResident
        btnBackResident.Enabled = False
        labelDashboardResident.Text = totalRowsResident

        'HOUSEHOLD  
        totalRowsHousehold = 0
        totalPageHousehold = 0
        labelTotalPageHousehold.Text = totalPageHousehold
        labelTotalHousehold.Text = totalRowsHousehold
        btnBackHousehold.Enabled = False
        labelDashboardHouseholds.Text = totalRowsHousehold

        If choice = "Search Household" Then
            cmd.CommandText = "Select count(*) From household " & (If(txtSearchHousehold.Text.Trim = "" Or txtSearchHousehold.Text = "Type in your search", " ", " WHERE household_id LIKE @householdID")) & " order by household_id asc "
            cmd.Parameters.AddWithValue("@householdID", txtSearchHousehold.Text & "%")
        Else
            cmd.CommandText = "Select count(*) from household"
        End If

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

    Private Sub loadDataGrid(ByVal datagrid As DataGridView, ByVal moduleSelected As Modules)

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

                mySQLCommand.CommandText = "Select * From residents" & (If(txtSearchResident.Text.Trim = "" Or txtSearchResident.Text = "Type in your search", " ", " WHERE (first_name LIKE @resident_name OR middle_name LIKE @resident_name OR last_name LIKE @resident_name)")) & " order by first_name asc limit 20 OFFSET " & (((CInt(Me.txtPageNoResident.Text)) - 1) * 20)
                mySQLCommand.Parameters.AddWithValue("@resident_name", txtSearchResident.Text & "%")
                mySQLReader = mySQLCommand.ExecuteReader

                If txtSearchResident.Text.Trim <> "" Or txtSearchResident.Text <> "Type in your search" Then
                    countRows("Search Resident")
                Else
                    countRows("")
                End If

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

                        datagrid.Rows.Add(New String() {mySQLReader!resident_id, (mySQLReader!first_name + " " + middle + mySQLReader!last_name + " " + mySQLReader!ext_name), mySQLReader!sex, mySQLReader!is_voter, mySQLReader!contact_no})

                    End While
                End If

                mySQLCommand.Dispose()
                mySQLReader.Dispose()

            Case Modules.Household ''''''''''''''Household

                mySQLCommand.CommandText = "Select * From household " & (If(txtSearchHousehold.Text.Trim = "" Or txtSearchHousehold.Text = "Type in your search", " ", " WHERE household_id LIKE @householdID")) & " order by household_id asc limit 30 OFFSET " & (((CInt(Me.txtPageNoHousehold.Text)) - 1) * 30)
                mySQLCommand.Parameters.AddWithValue("@householdID", txtSearchHousehold.Text & "%")
                mySQLReader = mySQLCommand.ExecuteReader

                If txtSearchHousehold.Text.Trim <> "" Or txtSearchHousehold.Text <> "Type in your search" Then
                    countRows("Search Household")
                Else
                    countRows("")
                End If

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
                        datagrid.Rows.Add(New String() {mySQLReader!household_id, "", mySQLReader!bldg_no, mySQLReader!street_name, "", "", ""})

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

End Class