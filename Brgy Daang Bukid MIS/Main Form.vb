Imports System.Data
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Main_Form
    Public account_type As String
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.PerformClick()

        loadDataGrid(datagridHousehold, "Household")
        loadDataGrid(dataGridBrgyOfficials, "Barangay Officials")
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
            Dim count As Integer = 50
            Dim count2 As Integer = 100

            mySQLCommand.CommandText = "Select * From household ORDER BY household_id LIMIT 800, 855"
            mySQLReader = mySQLCommand.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    datagrid.Rows.Add(New String() {mySQLReader!household_id, "", mySQLReader!bldg_no, mySQLReader!street_name, "", "", ""})

                End While
            End If

            'txtSearchHousehold.Text = datagrid.RowCount - 1
            mySQLCommand.Dispose()
            mySQLReader.Dispose()
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