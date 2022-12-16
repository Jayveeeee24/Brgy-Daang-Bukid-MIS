Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Main_Form
    Public account_type As String
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Dim totalRows As Integer
    Dim totalPage As Integer

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.PerformClick()

        countHousehold()
        loadDataGrid(dataGridBrgyOfficials, "Barangay Officials")
        loadDataGrid(datagridHousehold, "Household")
    End Sub

    Private Sub countHousehold()
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
        cmd.CommandText = "Select count(*) from household"
        totalRows = Convert.ToString(cmd.ExecuteScalar())
        totalPage = Math.Ceiling(totalRows / 30)
        labelTotalPageHousehold.Text = totalPage
        labelTotalHousehold.Text = totalRows
        btnBackHousehold.Enabled = False

        cmd.Dispose()

        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub txtPageNoHousehold_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPageNoHousehold.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPageNoHousehold.Text > totalPage Then
                MsgBox("Please enter a valid number", vbCritical, "Warning")
                txtPageNoHousehold.Text = 1
            Else
                If txtPageNoHousehold.Text = 0 Or Len(txtPageNoHousehold.Text.Trim) <> 0 Or Not (String.IsNullOrEmpty(txtPageNoHousehold.Text.Trim)) Or txtPageNoHousehold.Text <= totalPage Then
                    loadDataGrid(datagridHousehold, "Household")
                End If
            End If

            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub btnBackHousehold_Click(sender As Object, e As EventArgs) Handles btnBackHousehold.Click
        If txtPageNoHousehold.Text <> 1 And txtPageNoHousehold.Text <= totalPage Then
            txtPageNoHousehold.Text -= 1
            loadDataGrid(datagridHousehold, "Household")
        End If
    End Sub

    Private Sub btnForwardHousehold_Click(sender As Object, e As EventArgs) Handles btnForwardHousehold.Click
        If txtPageNoHousehold.Text < totalPage Then
            txtPageNoHousehold.Text += 1
            loadDataGrid(datagridHousehold, "Household")
        End If
    End Sub

    Private Sub txtPageNoHousehold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPageNoHousehold.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub loadDataGrid(ByVal datagrid As DataGridView, ByVal choice As String)

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


        If choice = "Barangay Officials" Then
            mySQLCommand.CommandText = "Select * From brgyOfficials"
            mySQLReader = mySQLCommand.ExecuteReader
            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    datagrid.Rows.Add(New String() {mySQLReader!official_name, mySQLReader!official_position, mySQLReader!contact_no})

                End While
            End If

            mySQLCommand.Dispose()
            mySQLReader.Dispose()

        ElseIf choice = "Household" Then

            mySQLCommand.CommandText = "Select * From household order by household_id asc limit 30 OFFSET " & ((IIf(Me.txtPageNoHousehold.Text = "", 1, CInt(Me.txtPageNoHousehold.Text)) - 1) * 30)
            mySQLReader = mySQLCommand.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    datagrid.Rows.Add(New String() {mySQLReader!household_id, "", mySQLReader!bldg_no, mySQLReader!street_name, "", "", ""})

                End While
            End If

            mySQLCommand.Dispose()
            mySQLReader.Dispose()


            If txtPageNoHousehold.Text = 1 Then
                    btnBackHousehold.Enabled = False
                End If
            If txtPageNoHousehold.Text < totalPage And txtPageNoHousehold.Text <> 1 Then
                btnForwardHousehold.Enabled = True
            End If
            If txtPageNoHousehold.Text > 1 Then
                    btnBackHousehold.Enabled = True
                End If
            If txtPageNoHousehold.Text = totalPage Then
                btnForwardHousehold.Enabled = False
                labelShownHousehold.Text = totalPage
            ElseIf txtPageNoHousehold.Text < totalPage Then
                labelShownHousehold.Text = txtPageNoHousehold.Text * 30
            End If
        End If

            mySql.Close()
        mySql.Dispose()

        datagrid.ClearSelection()
    End Sub


    'this triggers the timer clocks whenever the user clicks on the menu [ie. minimizing and maximizing side navigation]
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If splitContainerMain.SplitterDistance > 60 Then
            timerOpen.Enabled = True
        Else
            timerClose.Enabled = True
        End If
    End Sub

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
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim ans As Integer = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Attention!")
        If ans = MsgBoxResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnDashboard.BackColor = Color.FromArgb(52, 152, 219)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageDashboard
        labelTitle.Text = "Dashboard"

    End Sub

    Private Sub btnResidentInfo_Click(sender As Object, e As EventArgs) Handles btnResidentInfo.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(52, 152, 219)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageResident
        labelTitle.Text = "Resident's Information"
    End Sub

    Private Sub btnHouseholdInfo_Click(sender As Object, e As EventArgs) Handles btnHouseholdInfo.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(52, 152, 219)
        btnReports.BackColor = Color.FromArgb(25, 117, 211)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)

        mainTabControl.SelectedTab = pageHousehold
        labelTitle.Text = "Household Information"

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        btnDashboard.BackColor = Color.FromArgb(25, 117, 211)
        btnResidentInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnHouseholdInfo.BackColor = Color.FromArgb(25, 117, 211)
        btnReports.BackColor = Color.FromArgb(52, 152, 219)
        btnCertificates.BackColor = Color.FromArgb(25, 117, 211)
        btnBrgyMap.BackColor = Color.FromArgb(25, 117, 211)
        btnAccount.BackColor = Color.FromArgb(25, 117, 211)

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

        mainTabControl.SelectedTab = pageAccount
        labelTitle.Text = "Account Settings"
    End Sub

    Private Sub txtSearchResident_Click(sender As Object, e As EventArgs) Handles txtSearchResident.Click
        If txtSearchResident.Text = "Type in your search" Then
            txtSearchResident.Clear()
        End If
    End Sub


End Class